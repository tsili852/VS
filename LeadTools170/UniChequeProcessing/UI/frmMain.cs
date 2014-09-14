using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Unisystems.Cheques.UniChequeProcessing.Common;
using Leadtools.WinForms;
using Leadtools.Codecs;
using Leadtools.Forms.Ocr;
using Leadtools.Twain;
using Leadtools;
using Unisystems.Cheques.UniChequeProcessing.Processors.OCR;
using Unisystems.Cheques.EUR.Extraction;
using Unisystems.Cheques.EUR.Model;
using System.Globalization;
using Unisystems.Cheques.EUR.Validation;
using Leadtools.Forms;
using Unisystems.Cheques.UniChequeProcessing.Processors.Image;
using System.Threading;
using System.Resources;


namespace Unisystems.Cheques.UniChequeProcessing.UI
{
    public partial class frmMain : Form
    {
        RasterCodecs _codecs;
        RasterImageViewer _viewer;
        IOcrEngine _ocrEngine;

        TwainSession _twainSession;
        TwainCapabilityValue _transferMode = TwainCapabilityValue.TransferMechanismNative;
        static bool _twainAvailable = false;

        OCRProcessor _ocrProcessor;

        RectangleF _currentHighlightRect;
        ViewerRubberBandingHelper _rubberBandingHelper;

        public readonly string[] OCREngineEnabledLanguages = new string[] { "en"};

        public frmMain()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
            
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Support.Unlock(false);
            _codecs = new RasterCodecs();


            _viewer = new RasterImageViewer();
            _viewer.SizeMode = Leadtools.RasterPaintSizeMode.FitAlways;
            _viewer.BackColor = Color.DarkGray;
            _viewer.Dock = DockStyle.Fill;
            _viewer.BringToFront();
            _viewer.ScaleFactorChanged += new EventHandler(_viewer_ScaleFactorChanged);
            panelImage.Controls.Add(_viewer);


            try
            {
                _ocrEngine = OcrEngineManager.CreateEngine(OcrEngineType.Professional, true);
                _ocrEngine.Startup(_codecs, null, null, null);
                _ocrEngine.LanguageManager.EnableLanguages(OCREngineEnabledLanguages);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            _twainAvailable = TwainSession.IsAvailable(this);

            if (_twainAvailable)
            {
                _twainSession = new TwainSession();
                _twainSession.Startup(this, "Unisystems", "Cheque Processing", "v0.1", "Cheque Processing", TwainStartupFlags.None);
                _twainSession.AcquirePage += new EventHandler<TwainAcquirePageEventArgs>(_twain_AcquirePage);

                menuScanner.Enabled = true;
            }
            else
            {
                menuScanner.Enabled = false;
            }

            _ocrProcessor = new OCRProcessor();

        }

        // Non button event handlers
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
                lblCurrentPage.Text = "Εικόνα: " + _viewer.Image.Page + " από " + _viewer.Image.PageCount;

                if (_viewer.Image.PageCount == 1)
                {
                    btnPreviousPage.Enabled = false;
                    btnNextPage.Enabled = false;
                    //miOCRAllPages.Enabled = false;
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

                    //miOCRAllPages.Enabled = true;
                }

                groupZoom.Enabled = true;

                groupRotation.Enabled = true;

            }
            catch (Exception ex)
            {
                Messager.ShowError(this, ex);
            }

        }

        private void _twain_AcquirePage(object sender, TwainAcquirePageEventArgs e)
        {
            richtxtProcessorCodelineOCRB.Rtf = string.Empty;

            ClearValidationValues();

            try
            {
                if (_transferMode != TwainCapabilityValue.TransferMechanismFile)
                {
                    if (e.Image != null)
                    {
                        if (_viewer.Image == null)
                        {
                            RasterCodecs testCodecs = new RasterCodecs();
                            RasterImage testImage = testCodecs.Load(@"C:\Users\nick\Desktop\1.jpg");
                            //_viewer.Image = e.Image;
                            _viewer.Image = testImage;
                            _viewer.Image.Changed += new EventHandler<RasterImageChangedEventArgs>(_viewer_ImageChanged);

                            btnPreviousPage.Enabled = false;
                            btnNextPage.Enabled = false;

                            btnZoomIn.Enabled = true;
                            btnZoomOut.Enabled = true;
                            
                            btnRotateCCW.Enabled = true;
                            btnRotateCW.Enabled = true;

                            //miOCRAllPages.Enabled = false;

                            _rubberBandingHelper = new ViewerRubberBandingHelper();
                            _rubberBandingHelper.Viewer = _viewer;
                            _rubberBandingHelper.RubberBand += new EventHandler<ViewerRubberBandingHelperEventArgs>(_rubberBandingHelper_RubberBand);
                            _rubberBandingHelper.Start();

                            lblCurrentPage.Text = "Εικόνα: " + _viewer.Image.Page + " από " + _viewer.Image.PageCount;

                        }
                        else
                        {
                            _viewer.Image.AddPage(e.Image);
                            _viewer.Image.Page = _viewer.Image.PageCount;
                            //miOCRAllPages.Enabled = true;

                        }

                        //menuProcessing.Enabled = true;
                        //menuOCR.Enabled = true;
                        //miSave.Enabled = true;

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

        private void _rubberBandingHelper_RubberBand(object sender, ViewerRubberBandingHelperEventArgs e)
        {
            try
            {
                if (_rubberBandingHelper.IsStarted)
                {
                    _rubberBandingHelper.Stop();
                }

                ClearValidationValues();
                richtxtProcessorCodelineOCRB.Text = string.Empty;

                this.Cursor = Cursors.WaitCursor;

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

                    if (e.Bounds.Right >= _viewer.Image.ImageWidth)
                        newRight = _viewer.Image.ImageWidth - 1;

                    if (e.Bounds.Bottom >= _viewer.Image.ImageHeight)
                        newBottom = _viewer.Image.ImageHeight - 1;

                    _currentHighlightRect = new RectangleF(newLeft, newTop, newRight - newLeft, newBottom - newTop);

                    LogicalRectangle highLightRect = new LogicalRectangle(_currentHighlightRect.Left, _currentHighlightRect.Top, _currentHighlightRect.Width, _currentHighlightRect.Height, LogicalUnit.Pixel);

                    richTextRubberBand.Text = _ocrProcessor.OCRRubberBandZone(_viewer.Image, _viewer.Image.ViewPerspective, highLightRect, _ocrEngine);
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

        }

        // Menu Items
        // File Menu
        private void miFileOpen_Click(object sender, EventArgs e)
        {
            using (Leadtools.Codecs.RasterCodecs codecs = new Leadtools.Codecs.RasterCodecs())
            {
                _viewer.Image = codecs.Load(@"C:\Users\nick\Desktop\MICR_SAMPLE.tif");
            }
        }
        
        private void miFileSaveTIFF_Click(object sender, EventArgs e)
        {

        }

        private void miFileSaveJPG_Click(object sender, EventArgs e)
        {

        }

        private void miFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Menu Scanner
        private void miScannerSelectDevice_Click(object sender, EventArgs e)
        {
            _twainSession.SelectSource(string.Empty);
        }

        private void miScannerAcquireFull_Click(object sender, EventArgs e)
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

        private void miScannerAcquireQuick_Click(object sender, EventArgs e)
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

        // Menu Processing
        private void miProcAutoFix_Click(object sender, EventArgs e)
        {
            ImageProcessor pr = new ImageProcessor();
            //pr.Deskew(_viewer.Image);
            pr.Binarize(_viewer.Image);
            pr.Despeckle(_viewer.Image);
            pr.RemoveDots(_viewer.Image);
            pr.RemoveLines(_viewer.Image);
            pr.Crop(_viewer.Image);
            pr.RemoveBorders(_viewer.Image);
            pr.Crop(_viewer.Image);
            
        }

        private void miProcBinarize_Click(object sender, EventArgs e)
        {
            ImageProcessor pr = new ImageProcessor();
            pr.Binarize(_viewer.Image);
        }

        private void miProcAutoCrop_Click(object sender, EventArgs e)
        {
            ImageProcessor pr = new ImageProcessor();
            pr.Crop(_viewer.Image);
        }

        private void miProcDeskew_Click(object sender, EventArgs e)
        {
            ImageProcessor pr = new ImageProcessor();
            pr.Deskew(_viewer.Image);
        }

        private void miProcDespeckle_Click(object sender, EventArgs e)
        {
            ImageProcessor pr = new ImageProcessor();
            pr.Despeckle(_viewer.Image);
        }

        private void miProcRemoveBorders_Click(object sender, EventArgs e)
        {
            ImageProcessor pr = new ImageProcessor();
            pr.RemoveBorders(_viewer.Image);
        }

        private void miProcRemoveDots_Click(object sender, EventArgs e)
        {
            ImageProcessor pr = new ImageProcessor();
            pr.RemoveDots(_viewer.Image);
        }

        private void miProcRemoveLines_Click(object sender, EventArgs e)
        {
            ImageProcessor pr = new ImageProcessor();
            pr.RemoveLines(_viewer.Image);
        }

        private void miProcRotateCW_Click(object sender, EventArgs e)
        {
            pageRotation_Click(sender, e);
        }

        private void miProcRotateCCW_Click(object sender, EventArgs e)
        {
            pageRotation_Click(sender, e);
        }

        // Menu OCR
        private void miOCRCurrentPage_Click(object sender, EventArgs e)
        {
            richtxtProcessorCodelineOCRB.Text = string.Empty;
            richtxtProcessorCodelineOCRB.Text = _ocrProcessor.OCRCodelineZoneOCRB(_viewer.Image, _viewer.Image.ViewPerspective, _ocrEngine);

            fillValidationGroupFields(richtxtProcessorCodelineOCRB.Text);
        }

        private void miOCRAllPages_Click(object sender, EventArgs e)
        {

        }

        // Button click events
        private void pageRotation_Click(object sender, EventArgs e)
        {
            if (sender == btnRotateCCW)
                _viewer.Image.RotateViewPerspective(-90);
            else if (sender == btnRotateCW)
                _viewer.Image.RotateViewPerspective(+90);
        }

        private void pageNavigation_Click(object sender, EventArgs e)
        {
            int currentPage = _viewer.Image.Page;

            if (sender == btnNextPage)
                currentPage++;
            else if (sender == btnPreviousPage)
                currentPage--;

            _viewer.Image.Page = currentPage;

            if (currentPage == 1)
                btnPreviousPage.Enabled = false;
            else if (currentPage == _viewer.Image.PageCount)
                btnNextPage.Enabled = false;

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

        // Validation events
        private void validatingGroup_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;

            if (sender == txtValSpecialChars)
            {
                e.Cancel = !EURFieldsValidator.ValidateSpecialCharactersF5(txtValSpecialChars.Text);

                if (e.Cancel)
                {
                    lblValidationSpecialCharacters.Text = "Μη έγκυρο";
                    lblValidationSpecialCharacters.BackColor = Color.Red;
                }
                else
                {
                    lblValidationSpecialCharacters.Text = "Έγκυρο";
                    lblValidationSpecialCharacters.BackColor = Color.Green;
                }
            }
            else if (sender == txtValIBAN)
            {

                txtIBANAccountNumber.Text = string.Empty;
                txtIBANBankCode.Text = string.Empty;
                txtIBANBranchCode.Text = string.Empty;
                txtIBANCheckDigits.Text = string.Empty;
                txtIBANCountryCode.Text = string.Empty;

                e.Cancel = !EURFieldsValidator.ValidateIBANF4(txtValIBAN.Text);

                if (e.Cancel)
                {
                    lblValidationIBAN.Text = "Μη έγκυρο";
                    lblValidationIBAN.BackColor = Color.Red;
                }
                else
                {
                    lblValidationIBAN.Text = "Έγκυρο";
                    lblValidationIBAN.BackColor = Color.Green;

                    EURFieldsExtractor clFieldsExtractor = new EURFieldsExtractor();
                    GRIBANFields ibanFields = clFieldsExtractor.extractIBANFields(txtValIBAN.Text);

                    txtIBANAccountNumber.Text = ibanFields.AccountNumber;
                    txtIBANBankCode.Text = ibanFields.BankCode;
                    txtIBANBranchCode.Text = ibanFields.BranchCode;
                    txtIBANCheckDigits.Text = ibanFields.CheckDigits;
                    txtIBANCountryCode.Text = ibanFields.CountryCode;
                }

            }
            else if (sender == txtValChequeNumber)
            {
                e.Cancel = !EURFieldsValidator.ValidateChequeNoF2(txtValChequeNumber.Text);

                if (e.Cancel)
                {
                    lblValidationChequeNumber.Text = "Μη έγκυρο";
                    lblValidationChequeNumber.BackColor = Color.Red;
                }
                else
                {
                    lblValidationChequeNumber.Text = "Έγκυρο";
                    lblValidationChequeNumber.BackColor = Color.Green;
                }
            }
            else if (sender == txtValChequeDate)
            {
                e.Cancel = !EURFieldsValidator.ValidateDateF3(txtValChequeDate.Text);

                if (e.Cancel)
                {
                    lblValidationChequeDate.Text = "Μη έγκυρο";
                    lblValidationChequeDate.BackColor = Color.Red;
                }
                else
                {
                    lblValidationChequeDate.Text = "Έγκυρο";
                    lblValidationChequeDate.BackColor = Color.Green;
                }
            }
            else if (sender == txtValChequeAmount)
            {
                e.Cancel = !EURFieldsValidator.ValidateAmountF1(txtValChequeAmount.Text);

                if (e.Cancel)
                {
                    lblValidationChequeAmount.Text = "Μη έγκυρο";
                    lblValidationChequeAmount.BackColor = Color.Red;
                }
                else
                {
                    lblValidationChequeAmount.Text = "Έγκυρο";
                    lblValidationChequeAmount.BackColor = Color.Green;
                }
            }


        }

        // Helpers
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

        private void ClearValidationValues()
        {
            this.txtValChequeAmount.Text = string.Empty;
            this.txtValChequeDate.Text = string.Empty;
            this.txtValChequeNumber.Text = string.Empty;
            this.txtValIBAN.Text = string.Empty;
            this.txtValSpecialChars.Text = string.Empty;

            this.lblValidationChequeAmount.Text = string.Empty;
            this.lblValidationChequeDate.Text = string.Empty;
            this.lblValidationChequeNumber.Text = string.Empty;
            this.lblValidationIBAN.Text = string.Empty;
            this.lblValidationSpecialCharacters.Text = string.Empty;

            this.lblValidationChequeAmount.BackColor = Color.DarkGray;
            this.lblValidationChequeDate.BackColor = Color.DarkGray;
            this.lblValidationChequeNumber.BackColor = Color.DarkGray;
            this.lblValidationIBAN.BackColor = Color.DarkGray;
            this.lblValidationSpecialCharacters.BackColor = Color.DarkGray;

            this.txtIBANAccountNumber.Text = string.Empty;
            this.txtIBANBankCode.Text = string.Empty;
            this.txtIBANBranchCode.Text = string.Empty;
            this.txtIBANCheckDigits.Text = string.Empty;
            this.txtIBANCountryCode.Text = string.Empty;
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
        }


    }
}