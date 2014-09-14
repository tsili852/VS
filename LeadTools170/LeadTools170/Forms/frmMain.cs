using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using Leadtools.Codecs;
using Leadtools.Twain;
using Leadtools.WinForms;
using Leadtools.Forms.Ocr;
using Leadtools;
using Leadtools.Forms;
using Leadtools.ImageProcessing.Core;

using Unisystems.Cheques.EUR.Model;
using Unisystems.Cheques.EUR.Extraction;
using Unisystems.Cheques.EUR.Validation;

using System.Globalization;
using LeadTools170.ImageProcessing;
using LeadTools170.OCR;
using Leadtools.Demos;

namespace LeadTools170.Forms
{
    public partial class frmMain : Form
    {


        RasterCodecs _codecs;
        RasterImageViewer _viewer;
        TwainSession _twainSession;
        TwainCapabilityValue _transferMode = TwainCapabilityValue.TransferMechanismNative;

        IOcrEngine _ocrEngine;
        IOcrDocument _ocrDocument;

        OCRProcessor _ocrProcessor;

        RectangleF _currentHighlightRect;
        ViewerRubberBandingHelper _rubberBandingHelper;

        int widthDivider = 1;
        int heightDivider = 5;

        string regExChequeNoPattern = @"\d{8}\s?[-=]\s?\d{1}\s";

        string[] regExAmountPattern = new string[] { @"\d*[,.]?\d+[.,]\d{2}[#]?" };

        static bool _twainAvailable = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Support.Unlock(false);

            
            _viewer = new RasterImageViewer();
            panelImage.Controls.Add(_viewer);
            
            _viewer.SizeMode = Leadtools.RasterPaintSizeMode.FitAlways;
            _viewer.BackColor = Color.DarkGray;
            _viewer.Dock = DockStyle.Fill;
            _viewer.BringToFront();
            _viewer.ScaleFactorChanged += new EventHandler(_viewer_ScaleFactorChanged);


            RasterCodecs.Startup();

            _codecs = new RasterCodecs();

            _ocrEngine = OcrEngineManager.CreateEngine(OcrEngineType.Professional, true);
            _ocrEngine.Startup(_codecs, null, null, null);
            _ocrEngine.LanguageManager.EnableLanguages(new string[] { "en", "el" });

            _twainAvailable = TwainSession.IsAvailable(this);

            if (_twainAvailable)
            {
                _twainSession = new TwainSession();
                _twainSession.Startup(this, "Unisystems", "Scanning utilities", "v0.1", "Testing scanning/ocr", TwainStartupFlags.None);
                _twainSession.AcquirePage += new EventHandler<TwainAcquirePageEventArgs>(_twain_AcquirePage);
            }
            else 
            {
                miSelectDevice.Enabled = false;
                miAcquireImage.Enabled = false;
            }

            _ocrProcessor = new OCRProcessor();

            btnZoomIn.Enabled = false;
            btnZoomOut.Enabled = false;
            btnNextPage.Enabled = false;
            btnPreviousPage.Enabled = false;
            btnRotateCW.Enabled = false;
            btnRotateCCW.Enabled = false;
            menuProcessing.Enabled = false;
            menuOCR.Enabled = false;
            menuDatabase.Enabled = false;
            miSave.Enabled = false;
        }

        private void _rubberBandingHelper_RubberBand(object sender, ViewerRubberBandingHelperEventArgs e)
        {
            try
            {
                if (_rubberBandingHelper.IsStarted)
                {
                    _rubberBandingHelper.Stop();
                }

                txtFullPageOCR.Text = string.Empty;

                this.Cursor = Cursors.WaitCursor;

                _ocrDocument = _ocrEngine.DocumentManager.CreateDocument();

                using (_ocrDocument)
                {

                    if (_viewer.Image != null)
                    {
                        int newLeft = e.Bounds.Left;
                        int newTop = e.Bounds.Top;
                        int newRight = e.Bounds.Right;
                        int newBottom = e.Bounds.Bottom;

                        if (e.Bounds.Left <= 0)
                            newLeft = 1;

                        if (e.Bounds.Top <= 0)
                            newTop = 1;

                        if (e.Bounds.Right >= _viewer.Image.Width)
                            newRight = _viewer.Image.Width - 1;

                        if (e.Bounds.Bottom >= _viewer.Image.Height)
                            newBottom = _viewer.Image.Height - 1;

                        _currentHighlightRect = new RectangleF(newLeft, newTop, newRight - newLeft, newBottom - newTop);

                        OcrZone zone = new Leadtools.Forms.Ocr.OcrZone();
                        zone.Bounds = new LogicalRectangle(_currentHighlightRect.Left, _currentHighlightRect.Top, _currentHighlightRect.Width, _currentHighlightRect.Height, LogicalUnit.Pixel);
                        zone.ZoneType = OcrZoneType.Text;
                        zone.FillMethod = OcrZoneFillMethod.Default;
                        zone.RecognitionModule = OcrZoneRecognitionModule.Auto;
                        zone.CharacterFilters = OcrZoneCharacterFilters.None;

                        _ocrDocument.Pages.Clear();
                        _ocrDocument.Pages.AddPage(_viewer.Image, null);
                        _ocrDocument.Pages[0].Zones.Add(zone);

                        txtFullPageOCR.Text = _ocrDocument.Pages[0].RecognizeText(null);

                        if (txtFullPageOCR.Text == "\n" || txtFullPageOCR.Text == "")
                            Messager.ShowInformation(this, "No text was recognized.");
                       
                    }

                }
                
            }
            catch (Exception ex)
            {
                Messager.ShowError(this, ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;

                _viewer.Invalidate();

                Application.DoEvents();
                if (!_rubberBandingHelper.IsStarted)
                {
                    _rubberBandingHelper.Start();
                }
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (_twainSession != null)
                _twainSession.Shutdown();

            if (_ocrEngine != null)
            {
                _ocrEngine.Shutdown();
                _ocrEngine.Dispose();
            }

            if (_codecs != null)
                _codecs.Dispose();

            RasterCodecs.Shutdown();
        }

        private void miSelectDevice_Click(object sender, EventArgs e)
        {
            _twainSession.SelectSource(string.Empty);
        }

        private void miAcquireImage_Click(object sender, EventArgs e)
        {
            try
            {
                _twainSession.Acquire(TwainUserInterfaceFlags.Show | TwainUserInterfaceFlags.Modal);
                
            }
            catch (Exception ex)
            {
                Messager.ShowError(this, ex);
            }
        }

        private void miAcquirePageNoDialog_Click(object sender, EventArgs e)
        {
            try
            {
                _twainSession.Acquire(TwainUserInterfaceFlags.None);
            }
            catch (Exception ex)
            {
                Messager.ShowError(this, ex);
            }
        }

        private void _viewer_ScaleFactorChanged(object sender, EventArgs e)
        {
            double scaleFactor = _viewer.ScaleFactor;

            if (scaleFactor > 32)
            {
                scaleFactor = 32;
                btnZoomIn.Enabled = false;
            }
            else if (scaleFactor < 0.1)
            {
                scaleFactor = 0.1f;
                btnZoomOut.Enabled = false;
            }
            else
            {
                 btnZoomIn.Enabled = true;
                 btnZoomOut.Enabled = true;
            }
        }

        private void _viewer_ImageChanged(object sender, RasterImageChangedEventArgs e)
        {
            try
            {
                lblCurrentPage.Text = "Page: " + _viewer.Image.Page + " of " + _viewer.Image.PageCount;

                if (_viewer.Image.PageCount == 1)
                {
                    btnPreviousPage.Enabled = false;
                    btnNextPage.Enabled = false;
                    miOCRAllPages.Enabled = false;
                }
                else
                {
                    if (_viewer.Image.Page == 1)
                    {
                        btnPreviousPage.Enabled = false;
                        btnNextPage.Enabled = true;
                    }
                    else if (_viewer.Image.Page == _viewer.Image.PageCount)
                    {
                        btnPreviousPage.Enabled = true;
                        btnNextPage.Enabled = false;
                    }
                    else
                    {
                        btnPreviousPage.Enabled = true;
                        btnNextPage.Enabled = true;
                    }

                    miOCRAllPages.Enabled = true;
                }

                btnZoomIn.Enabled = true;
                btnZoomOut.Enabled = true;
                btnRotateCCW.Enabled = true;
                btnRotateCW.Enabled = true;

            }
            catch (Exception ex)
            {
                Messager.ShowError(this, ex);
            }
 
        }

        private void _twain_AcquirePage(object sender, TwainAcquirePageEventArgs e)
        {
            txtFullPageOCR.Text = string.Empty;

            txtCodeline.Text = string.Empty;
            txtOCRCodeline.Text = string.Empty;
            txtChequeNo.Text = string.Empty;
            txtChequeNoOCR.Text = string.Empty;
            txtAmountOCR.Text = string.Empty;

            try
            {
                if (_transferMode != TwainCapabilityValue.TransferMechanismFile)
                {
                    if (e.Image != null)
                    {
                        if (_viewer.Image == null)
                        {
                            _viewer.Image = e.Image;
                            _viewer.Image.Changed += new EventHandler<RasterImageChangedEventArgs>(_viewer_ImageChanged);

                            btnPreviousPage.Enabled = false;
                            btnNextPage.Enabled = false;

                            btnZoomIn.Enabled = true;
                            btnZoomOut.Enabled = true;
                            btnRotateCCW.Enabled = true;
                            btnRotateCW.Enabled = true;

                            miOCRAllPages.Enabled = false;

                            _rubberBandingHelper = new ViewerRubberBandingHelper();
                            _rubberBandingHelper.Viewer = _viewer;
                            _rubberBandingHelper.RubberBand += new EventHandler<ViewerRubberBandingHelperEventArgs>(_rubberBandingHelper_RubberBand);
                            _rubberBandingHelper.Start();

                            lblCurrentPage.Text = "Page: " + _viewer.Image.Page + " of " + _viewer.Image.PageCount;

                        }
                        else
                        {
                            _viewer.Image.AddPage(e.Image);
                            _viewer.Image.Page = _viewer.Image.PageCount;
                            miOCRAllPages.Enabled = true;

                        }

                        menuProcessing.Enabled = true;
                        menuOCR.Enabled = true;
                        miSave.Enabled = true;

                    }
                }
                else
                {
                    MessageBox.Show(this, "Acquired page(s) is saved to file(s)", "Acquire to File");
                }
                    
            }
            catch (Exception ex)
            {
                Messager.ShowError(this, ex);
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            ImageFileSaver saver = new ImageFileSaver();
            try
            {
                saver.Save(this, _codecs, _viewer.Image);
            }
            catch (Exception ex)
            {
                Messager.ShowFileSaveError(this, saver.FileName, ex);
            }
        }

        private void miSaveCurrentPage_Click(object sender, EventArgs e)
        {
            string filename = Guid.NewGuid() + ".jpg";
            try
            {
                RasterImage img = _viewer.Image;
                _codecs.Options.Jpeg.Save.QualityFactor = 95;
                _codecs.Save(img, @"C:\UniScanningUtilities\" + filename, RasterImageFormat.Jpeg, 8);

                Messager.ShowInformation(this, "Image saved as:" + @"C:\UniScanningUtilities\" + filename);
            }
            catch (Exception ex)
            {
                Messager.ShowFileSaveError(this, filename, ex);
            }
        }

        private void pageRotation_Click(object sender, EventArgs e)
        {
            if (sender == btnRotateCCW || sender == miRotateCCW)
            {
                _viewer.Image.RotateViewPerspective(-90);
                /*
                miDeskew.Enabled = false;
                miDespeckle.Enabled = false;
                miBinarize.Enabled = false;
                 */
            }
            else if (sender == btnRotateCW || sender == miRotateCW)
            {
                _viewer.Image.RotateViewPerspective(+90);
                /*
                  miDeskew.Enabled = false;
                miDespeckle.Enabled = false;
                miBinarize.Enabled = false;
                 */
            }
        }

        private void pageNavigation_Click(object sender, EventArgs e)
        {
            int currentPage = _viewer.Image.Page;

            if (sender == btnNextPage)
            {
                currentPage++;
 
            }
            else if (sender == btnPreviousPage)
            {
                currentPage--;
 
            }

            _viewer.Image.Page = currentPage;

            if (currentPage == 1)
            {
                btnPreviousPage.Enabled = false;
            }
            else if (currentPage == _viewer.Image.PageCount)
            {
                btnNextPage.Enabled = false;
            }

        }

        private void imageZoom_Click(object sender, EventArgs e)
        {
            double scaleFactor = _viewer.ScaleFactor;

            if (sender == btnZoomIn)
            {
                scaleFactor *= 2;
                if (scaleFactor > 32)
                    scaleFactor = 32;
            }
            else if (sender == btnZoomOut)
            {
                scaleFactor /= 2;
                if (scaleFactor < 0.1)
                    scaleFactor = 0.1f;
            }

            _viewer.ScaleFactor = scaleFactor;

        }

        private Dictionary<string, string> ocrUpperZone()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            txtUpperOCR.Text = string.Empty;

            try
            {
                _ocrDocument = _ocrEngine.DocumentManager.CreateDocument();

                using (_ocrDocument)
                {
                    IOcrPage _ocrPage = _ocrDocument.Pages.AddPage(_viewer.Image, null);

                    OcrZone _ocrZone = new OcrZone();

                    int startingXPoint = 0;
                    int startingYPoint = 0;


                    LeadRect _searchRect = new LeadRect(startingXPoint, startingYPoint, _viewer.Image.ImageWidth, _viewer.Image.ImageHeight / heightDivider);

                    _ocrZone.Bounds = new LogicalRectangle(_searchRect);

                    _ocrZone.ZoneType = OcrZoneType.Text;
                    _ocrZone.FillMethod = OcrZoneFillMethod.OmniFont;
                    _ocrZone.RecognitionModule = OcrZoneRecognitionModule.Auto;

                    _ocrPage.Zones.Add(_ocrZone);

                    string ocred = _ocrPage.RecognizeText(null);

                    txtUpperOCR.Text = ocred;

                    result.Add("amount", extractAmount(ocred));
                    result.Add("chequeNo", extractChequeNo(ocred));
                }
            }
            catch (Exception ex)
            {
                Messager.ShowError(this, ex);
            }

            return result;
        }

        private Dictionary<string,string> ocrLowerZone()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            txtLowerOCR.Text = string.Empty;

            try
            {
                _ocrDocument = _ocrEngine.DocumentManager.CreateDocument();

                using (_ocrDocument)
                {
                    IOcrPage _ocrPage = _ocrDocument.Pages.AddPage(_viewer.Image, null);

                    OcrZone _ocrZone = new OcrZone();

                    int startingXPoint = _viewer.Image.ImageWidth - (_viewer.Image.ImageWidth / widthDivider);
                    int startingYPoint = _viewer.Image.ImageHeight - (_viewer.Image.ImageHeight / heightDivider);


                    LeadRect _searchRect = new LeadRect(startingXPoint, startingYPoint, _viewer.Image.ImageWidth, _viewer.Image.ImageHeight - startingYPoint);

                    _ocrZone.Bounds = new LogicalRectangle(_searchRect);

                    _ocrZone.ZoneType = OcrZoneType.Text;
                    _ocrZone.FillMethod = OcrZoneFillMethod.OmniFont;
                    _ocrZone.RecognitionModule = OcrZoneRecognitionModule.Auto;
                    
                    _ocrPage.Zones.Add(_ocrZone);

                    string ocred = _ocrPage.RecognizeText(null);

                    txtLowerOCR.Text = ocred;
                    result.Add("codeline", determineCheckCodeline(ocred));
                }
            }
            catch (Exception ex)
            {
                Messager.ShowError(this, ex);
            }

            return result;
        }

        private void miOCRCodeline_Click(object sender, EventArgs e)
        {
            String resultOCR = string.Empty;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                _ocrDocument = _ocrEngine.DocumentManager.CreateDocument();

                using (_ocrDocument)
                {
                    IOcrPage _ocrPage = _ocrDocument.Pages.AddPage(_viewer.Image, null);

                    OcrZone _ocrZone = new OcrZone();

                    int startingXPoint = _viewer.Image.ImageWidth - (_viewer.Image.ImageWidth / widthDivider);
                    int startingYPoint = _viewer.Image.ImageHeight - (_viewer.Image.ImageHeight / heightDivider);


                    LeadRect _searchRect = new LeadRect(startingXPoint, startingYPoint, _viewer.Image.ImageWidth, _viewer.Image.ImageHeight - startingYPoint);

                    _ocrZone.Bounds = new LogicalRectangle(_searchRect);

                    _ocrZone.ZoneType = OcrZoneType.Text;
                    _ocrZone.RecognitionModule = OcrZoneRecognitionModule.Auto;
                    _ocrZone.FillMethod = OcrZoneFillMethod.OcrB;
                    _ocrPage.Zones.Add(_ocrZone);

                    resultOCR = _ocrPage.RecognizeText(null);

                    txtFullPageOCR.Text = resultOCR;
                    txtCodeline.Text = determineCheckCodeline(resultOCR);
                    txtChequeNo.Text = string.Empty;

                    menuDatabase.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                Messager.ShowError(this, ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
 
        }

        private void miOCRCurrentPage_Click(object sender, EventArgs e)
        {
            String resultOCR = string.Empty;

            txtFullPageOCR.Text = string.Empty;
            txtUpperOCR.Text = string.Empty;
            txtLowerOCR.Text = string.Empty;

            txtCodeline.Text = string.Empty;
            txtOCRCodeline.Text = string.Empty;
            txtChequeNo.Text = string.Empty;
            txtChequeNoOCR.Text = string.Empty;
            txtAmountOCR.Text = string.Empty;

            txtProcessorCodelineOCRB.Text = string.Empty;
            txtProcessorCodelineOmni.Text = string.Empty;

            this.Cursor = Cursors.WaitCursor;

            try
            {
                _ocrDocument = _ocrEngine.DocumentManager.CreateDocument();

                using (_ocrDocument)
                {
                    IOcrPage _ocrPage = _ocrDocument.Pages.AddPage(_viewer.Image, null);

                    OcrZone _ocrZone = new OcrZone();

                    LeadRect _searchRect = new LeadRect(0, 0, _viewer.Image.ImageWidth, _viewer.Image.ImageHeight);

                    _searchRect = _viewer.Image.RectangleFromImage(_viewer.Image.ViewPerspective, _searchRect);

                    _ocrZone.Bounds = new LogicalRectangle(_searchRect);

                    _ocrZone.ZoneType = OcrZoneType.Text;
                    _ocrZone.RecognitionModule = OcrZoneRecognitionModule.Auto;
                    _ocrZone.FillMethod = OcrZoneFillMethod.Default;
                    _ocrPage.Zones.Add(_ocrZone);

                    resultOCR = _ocrPage.RecognizeText(null);

                    txtFullPageOCR.Text = resultOCR;

                    menuDatabase.Enabled = true;

                    txtCodeline.Text = determineCheckCodeline(resultOCR);

                    Dictionary<string, string> lowerZone = ocrLowerZone();
                    //Dictionary<string, string> upperZone = ocrUpperZone();

                    txtOCRCodeline.Text = lowerZone["codeline"];
                    txtChequeNo.Text = extractChequeNo(resultOCR);
                    //txtChequeNoOCR.Text = upperZone["chequeNo"];
                    //txtAmountOCR.Text = upperZone["amount"];

                    fillValidationGroupFields(txtOCRCodeline.Text);

                }
                //String tm = _ocrProcessor.OCRAmountZone(_viewer.Image, _viewer.Image.ViewPerspective, _ocrEngine);
                //String tm2 = _ocrProcessor.ICRAmountZone(_viewer.Image, _viewer.Image.ViewPerspective, _ocrEngine);

                txtProcessorCodelineOCRB.Text = _ocrProcessor.OCRCodelineZoneOCRB(_viewer.Image, _viewer.Image.ViewPerspective, _ocrEngine);
                txtProcessorCodelineOmni.Text = _ocrProcessor.OCRCodelineZoneOmni(_viewer.Image, _viewer.Image.ViewPerspective, _ocrEngine);
            }
            catch (Exception ex)
            {
                Messager.ShowError(this, ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;

            }
            
        }

        private void fillValidationGroupFields(String codeline)
        {

            EURFieldsExtractor fe = new EURFieldsExtractor();
            fe.ExtractFields(codeline);
            EURCodelineFields fields = fe.CodelineFields;

            if (fields.Amount != EURChequeConstants.DefaultChequeAmount)
            {
                txtValChequeAmount.Text = fields.Amount.ToString();
            }
            else
            {
                txtValChequeAmount.Text = string.Empty;
            }

            if (DateTime.Compare(fields.ChequeDate, DateTime.Parse(EURChequeConstants.DefaultChequeDate, CultureInfo.CurrentCulture)) != 0)
            {
                txtValChequeDate.Text = fields.ChequeDate.ToString("dd/MM/yyyy");
            }
            else
            {
                txtValChequeDate.Text = string.Empty;
            }
            
            txtValChequeNumber.Text = fields.ChequeNo;
            txtValIBAN.Text = fields.IBAN;
            txtValSpecialChars.Text = fields.SpecialCharacters;

            this.ValidateChildren();
 
        }

        private void validatingGroup_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;

            if (sender == txtValSpecialChars)
            {
                e.Cancel = !EURFieldsValidator.ValidateSpecialCharactersF5(txtValSpecialChars.Text);

                if (e.Cancel)
                {
                    lblValidCharacters.Text = EURChequeConstants.DefaultInvalidLabel;
                    lblValidCharacters.BackColor = Color.Red;
                }
                else
                {
                    lblValidCharacters.Text = EURChequeConstants.DefaultValidLabel;
                    lblValidCharacters.BackColor = Color.Green;
                }
            }
            else if (sender == txtValIBAN)
            {
                e.Cancel = !EURFieldsValidator.ValidateIBANF4(txtValIBAN.Text);

                if (e.Cancel)
                {
                    lblValidIBAN.Text = EURChequeConstants.DefaultInvalidLabel;
                    lblValidIBAN.BackColor = Color.Red;
                }
                else
                {
                    lblValidIBAN.Text = EURChequeConstants.DefaultValidLabel;
                    lblValidIBAN.BackColor = Color.Green;
                }

            }
            else if (sender == txtValChequeNumber)
            {
                e.Cancel = !EURFieldsValidator.ValidateChequeNoF2(txtValChequeNumber.Text);

                if (e.Cancel)
                {
                    lblValidNumber.Text = EURChequeConstants.DefaultInvalidLabel;
                    lblValidNumber.BackColor = Color.Red;
                }
                else
                {
                    lblValidNumber.Text = EURChequeConstants.DefaultValidLabel;
                    lblValidNumber.BackColor = Color.Green;
                }
            }
            else if (sender == txtValChequeDate)
            {
                e.Cancel = !EURFieldsValidator.ValidateDateF3(txtValChequeDate.Text);

                if (e.Cancel)
                {
                    lblValidDate.Text = EURChequeConstants.DefaultInvalidLabel;
                    lblValidDate.BackColor = Color.Red;
                }
                else
                {
                    lblValidDate.Text = EURChequeConstants.DefaultValidLabel;
                    lblValidDate.BackColor = Color.Green;
                }
            }
            else if (sender == txtValChequeAmount)
            {
                e.Cancel = !EURFieldsValidator.ValidateAmountF1(txtValChequeAmount.Text);

                if (e.Cancel)
                {
                    lblValidAmount.Text = EURChequeConstants.DefaultInvalidLabel;
                    lblValidAmount.BackColor = Color.Red;
                }
                else
                {
                    lblValidAmount.Text = EURChequeConstants.DefaultValidLabel;
                    lblValidAmount.BackColor = Color.Green;
                }
            }
                    
 
        }

        private void miOCRAllPages_Click(object sender, EventArgs e)
        {
            String resultOCR = string.Empty;

            txtFullPageOCR.Text = string.Empty;

            this.Cursor = Cursors.WaitCursor;

            try
            {

                _ocrDocument = _ocrEngine.DocumentManager.CreateDocument();

                using (_ocrDocument)
                {

                    for (int i = 1; i <= _viewer.Image.PageCount; i++)
                    {
                        _viewer.Image.Page = i;

                        IOcrPage _ocrPage = _ocrDocument.Pages.AddPage(_viewer.Image, null);

                        OcrZone _ocrZone = new OcrZone();

                        LeadRect _searchRect = new LeadRect(0, 0, _viewer.Image.ImageWidth, _viewer.Image.ImageHeight);

                        _searchRect = _viewer.Image.RectangleFromImage(_viewer.Image.ViewPerspective, _searchRect);

                        _ocrZone.Bounds = new LogicalRectangle(_searchRect);

                        _ocrZone.ZoneType = OcrZoneType.Text;
                        _ocrZone.RecognitionModule = OcrZoneRecognitionModule.Auto;
                        _ocrZone.FillMethod = OcrZoneFillMethod.Default;
                        _ocrPage.Zones.Add(_ocrZone);

                        resultOCR = _ocrPage.RecognizeText(null);

                        txtFullPageOCR.AppendText(resultOCR);
                        txtFullPageOCR.AppendText(Environment.NewLine);
                    }

                    menuDatabase.Enabled = true;
                }
                

            }
            catch (Exception ex)
            {
                Messager.ShowError(this, ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void miDeskew_Click(object sender, EventArgs e)
        {
            DeskewCommand cmd = new DeskewCommand();
            cmd.Flags = DeskewCommandFlags.DeskewImage | DeskewCommandFlags.DoNotFillExposedArea;
            cmd.FillColor = new Leadtools.RasterColor(255, 255, 255);
            cmd.Run(_viewer.Image);
        }

        private void miAutoBinarize_Click(object sender, EventArgs e)
        {
            AutoBinarizeCommand cmd = new AutoBinarizeCommand();
            cmd.Run(_viewer.Image);
        }

        private void miDespeckle_Click(object sender, EventArgs e)
        {
            DespeckleCommand cmd = new DespeckleCommand();
            cmd.Run(_viewer.Image);
        }

        private void miAutoCrop_Click(object sender, EventArgs e)
        {
            AutoCropCommand cmd = new AutoCropCommand();
            cmd.Run(_viewer.Image);
        }

        private void miBorderRemoval_Click(object sender, EventArgs e)
        {
            BorderRemoveCommand cmd = new BorderRemoveCommand();
            cmd.Run(_viewer.Image);
        }

        private void miScannerSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have not found the way yet... working on it though ;-)");
        }

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = null;

            try
            {
                string conString = @"Password=checks_full;Persist Security Info=True;User ID=checks_full;Initial Catalog=ChecksTesting;Data Source=.\SQLEXPRESS";

                sqlCon = new SqlConnection();
                sqlCon.ConnectionString = conString;

                string cmdText = "INSERT INTO ProcessedChecks (CheckFullText, CheckCodeline) VALUES (@FullText, @Codeline)";

                sqlCon.Open();

                SqlCommand insertCmd = sqlCon.CreateCommand();
                insertCmd.CommandText = cmdText;
                insertCmd.Parameters.Add("@FullText", SqlDbType.Text);
                insertCmd.Parameters.Add("@Codeline", SqlDbType.NVarChar);

                insertCmd.Parameters["@FullText"].Value = txtFullPageOCR.Text;
                insertCmd.Parameters["@Codeline"].Value = determineCheckCodeline(txtFullPageOCR.Text);

                insertCmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Messager.ShowError(this, ex);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State != ConnectionState.Closed)
                    sqlCon.Close();
            }
        }

        private string determineCheckCodeline(string checkFullText)
        {

            string result = string.Empty;

            if (checkFullText != null)
            {
                if (checkFullText != Environment.NewLine && !checkFullText.Trim().Equals(""))
                {
                    string[] txtLines = checkFullText.Split(Environment.NewLine.ToCharArray());

                    result = txtLines[txtLines.Length - 1];

                    for (int i = txtLines.Length - 1; i > -1; i--)
                    {
                        if (!txtLines[i].Equals(""))
                        {
                            result = txtLines[i];
                            break;
                        }
                    }
                }
            }

            return result;
 
        }

        private string extractChequeNo(string checkFullText)
        {
            string result = string.Empty;

            List<string> possibleLines = new List<string>();

            if (checkFullText != null)
            {
                if (checkFullText != Environment.NewLine && !checkFullText.Trim().Equals(""))
                {
                    string[] txtLines = checkFullText.Split(Environment.NewLine.ToCharArray());

                    result = txtLines[txtLines.Length - 1];

                    for (int i = 0; i < txtLines.Length; i++)
                    {
                        if(Regex.IsMatch(txtLines[i], regExChequeNoPattern))
                        {
                            possibleLines.Add(txtLines[i]);
                        }

                    }

                    if (possibleLines.Count == 1)
                    {
                        Regex chequeNoRegEx = new Regex(regExChequeNoPattern);

                        Match m = chequeNoRegEx.Match(possibleLines[0]);
                        if (m.Success)
                        {
                            result = possibleLines[0].Substring(m.Index, m.Length).Trim().Replace('=','-');
                        }
                        else
                        {
                            result = "Cannot determine chequeNo";
                        }
                    }
                    else
                    {
                        result = "Cannot determine chequeNo";
                    }
                }
            }


            return result;
        }

        private string extractAmount(string checkFullText)
        {
            string result = string.Empty;

            List<string> possibleLines = new List<string>();

            if (checkFullText != null)
            {
                if (checkFullText != Environment.NewLine && !checkFullText.Trim().Equals(""))
                {
                    string[] txtLines = checkFullText.Split(Environment.NewLine.ToCharArray());

                    result = txtLines[txtLines.Length - 1];

                    for (int i = 0; i < txtLines.Length; i++)
                    {

                        for (int j = 0; j < regExAmountPattern.Length; j++)
                        {
                            if (Regex.IsMatch(txtLines[i], regExAmountPattern[j]))
                            {
                                possibleLines.Add(txtLines[i]);
                            }
                        }
                    }

                    if (possibleLines.Count == 1)
                    {
                        
                        for (int k = 0; k < regExAmountPattern.Length; k++)
                        {

                            Regex amountRegEx = new Regex(regExAmountPattern[k]);

                            Match m = amountRegEx.Match(possibleLines[0]);

                            if (m.Success)
                            {
                                result = possibleLines[0].Substring(m.Index, m.Length).Trim();
                                if (result.StartsWith("#"))
                                    result = result.Substring(1);

                                if (result.EndsWith("#"))
                                    result = result.Substring(0, result.Length - 1);

                                break;
                            }
                        }

                        if (result.Equals(string.Empty))
                        {
                            result = "Cannot determine chequeNo";
                        }
                    }
                    else
                    {
                        result = "Cannot determine chequeNo";
                    }
                }
            }

            return result;
        }

        private void miOneClickProcessing_Click(object sender, EventArgs e)
        {

            ImageProcessor pr = new ImageProcessor();

            pr.Binarize(_viewer.Image);
            pr.Crop(_viewer.Image);
            pr.RemoveBorders(_viewer.Image);
            pr.Despecle(_viewer.Image);
            pr.RemoveDots(_viewer.Image);
            //pr.Deskew(_viewer.Image);
            pr.RemoveLines(_viewer.Image);


        }

        private void miFileOpen_Click(object sender, EventArgs e)
        {
            try
            {
                // load the image
                ImageFileLoader loader = new ImageFileLoader();
                if (loader.Load(this, _codecs, true) > 0)
                {
                    // update the caption
                    Text = string.Format("{0} - {1}", loader.FileName, Messager.Caption);

                    //set the new image in the viewer
                    _viewer.Image = loader.Image;
                }
            }
            catch (Exception ex)
            {
                Messager.ShowError(this, ex);
            }
        }

        private void grpValidation_Enter(object sender, EventArgs e)
        {

        }
    }
}