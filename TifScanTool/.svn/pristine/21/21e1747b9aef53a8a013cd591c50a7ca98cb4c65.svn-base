using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data;
using System.Text;
using System.IO;

using Leadtools.Demos;
using Leadtools;
using Leadtools.Codecs;
using Leadtools.ImageProcessing;
using Leadtools.ImageProcessing.Effects;
using Leadtools.ImageProcessing.Color;
using Leadtools.ImageProcessing.Core;
using Leadtools.WinForms;
using Leadtools.Twain;
//using Leadtools.Helpers;
using Leadtools.WinForms.CommonDialogs.Color;


namespace MainDemo
{
   public partial class MainForm : Form
   {
      private RasterCodecs _codecs;
      private RasterColor _fillColor;
      private PrintDocument _printDocument;
      private TwainSession _twainSession;
      private int _acquirePageCount;
      private bool _inTwainAcquire;
      private RasterPaintProperties _paintProperties;
      private PanViewerForm _panViewerForm;
      private RawData _rawdataLoad;
      private RawData _rawdataSave;
      private static readonly float _minimumScaleFactor = 0.05f;
      private static readonly float _maximumScaleFactor = 11f;
      private ImageFileSaver _saver;
       private RasterImage _image;
       private String _filename = "";
       private RasterImagePanViewer _panViewer;
       private String _openedfilename = "";

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
       static void Main(String[] args)
       {
         
         if (Support.KernelExpired)
            return;
         //added by unisystems 10/7/2008
         
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         if (args.Length == 0)
         {
             Application.Run(new MainForm(@"C:\BlankTIFFDocument.tif"));
         }
         else
         {
             String filename = args[0].Replace("\\", @"\\");
            filename = Convert.ToString(filename);
             Application.Run(new MainForm(args[0]));
         }
             
          //MessageBox.Show("C:\\Documents and Settings\\daskalakia.CTNT\\Desktop\\SampleImages\\hello.tif");
         //Application.Run(new MainForm(@"C:\BlankTIFFDocument.tif"));
      }

      public MainForm(String filename)
      {
         Support.Unlock(false);
         //RasterSupport.Unlock(RasterSupportType.Pro, "LhwcFdF3jN");
         InitializeComponent();
         _filename = filename;
         InitClass();
         
         _saver = new ImageFileSaver();
          AutoOpen(filename); 
      }

       public MainForm()
       {
           Support.Unlock(false);
           //RasterSupport.Unlock(RasterSupportType.Pro, "LhwcFdF3jN");
           InitializeComponent();
           InitClass();
           _saver = new ImageFileSaver();
           
       }

      private void InitClass()
      {
          _panViewer = new RasterImagePanViewer();
          _panViewer.Enabled = true;
          _panViewer.Dock = DockStyle.Fill;
          
          _panViewer.AllowDrop = true;


          _panViewer.BorderStyle = BorderStyle.None;
          //this.splitterMain.Controls.Add(_panViewer);
          //this.splitContainer1.Panel1.Controls.Add(_panViewer);
          _panViewer.BringToFront();

          
         Messager.Caption = "Unisystems Scan Utility";
         Text = Messager.Caption;

         //Support.Unlock(false);

         //RasterClipboard.RegisterFormats(); not used in version 15

         //DemosGlobal.SetupCodecsPath(); not used in version 15
         RasterCodecs.Startup(); //added from version 15
         _codecs = new RasterCodecs();
         _codecs.Options.Txt.Load.Enabled = false;
         _fillColor = RasterColor.FromGdiPlusColor(Color.White);
         _paintProperties = RasterPaintProperties.Default;
         _paintProperties.PaintDisplayMode |= RasterPaintDisplayModeFlags.ScaleToGray;
         _rawdataLoad = RawData.Default;
         _rawdataSave = RawData.Default;

         _menuItemPreferencesProgressBar.Checked = true;

         try
         {

            if (PrinterSettings.InstalledPrinters != null && PrinterSettings.InstalledPrinters.Count > 0)
            {
               _printDocument = new PrintDocument();
               _printDocument.PrintPage += new PrintPageEventHandler(_printDocument_PrintPage);
            }
            else
               _printDocument = null;
         }
         catch (Exception)
         {
            _printDocument = null;
         }

         try
         {
            using (WaitCursor wait = new WaitCursor())
            {
               if (TwainSession.IsAvailable(this))
               {
                  _twainSession = new TwainSession();
                  _twainSession.Startup(this, "LEADTOOLS", "LEADTOOLS for .NET", "15.0", Messager.Caption, TwainStartupFlags.None);
                  _twainSession.AcquirePage += new EventHandler<TwainAcquirePageEventArgs>(_twainSession_AcquirePage);
               }
            }
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
            _twainSession = null;
         }

        

         //_panViewerForm = new PanViewerForm();
         //_panViewerForm.Owner = this;
         

         UpdateControls();
         
         
      }

      private void CleanUp()
      {
         if (_twainSession != null)
         {
            try
            {
               _twainSession.Shutdown();
            }
            catch (Exception ex)
            {
               Messager.ShowError(this, ex);
            }
         }
      }

      public ViewerForm ActiveViewerForm
      {
         get
         {
            return ActiveMdiChild as ViewerForm;
         }
      }

      public void UpdateControls()
      {

          if (this.ActiveMdiChild == null || (ActiveViewerForm.Viewer.Image.Width == 1 && ActiveViewerForm.Viewer.Image.Height == 1) )
          {
              EnableButton(toolStripDiscard, false);
              EnableButton(toolStripZoomIn, false);
              EnableButton(toolStripZoomOut,false);
              EnableButton(toolStripSplitButton1, false);
              EnableButton(toolStripNext, false);
              EnableButton(toolStripPrevious, false);
              EnableButton(toolStripLast, false);
              EnableButton(toolStripFirst, false);
          }
          else {
              EnableButton(toolStripDiscard,true);
              EnableButton(toolStripZoomIn, true);
              EnableButton(toolStripZoomOut, true);
              EnableButton(toolStripSplitButton1, true);
              EnableButton(toolStripNext,true);
              EnableButton(toolStripPrevious, true);
              EnableButton(toolStripLast, true);
              EnableButton(toolStripFirst, true);
          }

         

         ViewerForm activeForm = ActiveViewerForm;

         EnableAndVisibleMenu(_menuItemFileSave, activeForm != null);
         EnableAndVisibleMenu(_menuItemFileSaveRaw, activeForm != null);
         EnableAndVisibleMenu(_menuItemFilePrint, _printDocument != null && activeForm != null);
         EnableAndVisibleMenu(_menuItemFilePrintPreview, _printDocument != null && activeForm != null && DialogUtilities.CanRunPrintPreview);
         _menuItemFileSep3.Visible = (_printDocument != null && activeForm != null);

         _menuItemFileSep1.Visible = _twainSession != null;
         EnableAndVisibleMenu(_menuItemFileTwainSelectSource, _twainSession != null);
         EnableAndVisibleMenu(_menuItemFileTwainAcquire, _twainSession != null);

         EnableAndVisibleMenu(_menuItemEditCut, activeForm != null && activeForm.Viewer.FloaterImage != null && activeForm.Viewer.FloaterVisible);
         EnableAndVisibleMenu(_menuItemEditCopy, activeForm != null);
         EnableAndVisibleMenu(_menuItemEditCombine, activeForm != null && activeForm.Viewer.FloaterImage != null && activeForm.Viewer.FloaterVisible);
         EnableAndVisibleMenu(_menuItemEditDelete, activeForm != null && activeForm.Viewer.FloaterImage != null && activeForm.Viewer.FloaterVisible);
         _menuItemEditSep1.Visible = activeForm != null && activeForm.Viewer.FloaterImage != null && activeForm.Viewer.FloaterVisible;
         EnableAndVisibleMenu(_menuItemEditRegion, activeForm != null );
         _menuItemEditSep2.Visible = activeForm != null;

         EnableAndVisibleMenu(_menuItemImage, activeForm != null);
         EnableAndVisibleMenu(_menuItemPage, activeForm != null);
         EnableAndVisibleMenu(_menuItemView, activeForm != null);
         EnableAndVisibleMenu(_menuItemInteractive, activeForm != null);
         EnableAndVisibleMenu(_menuItemColor, activeForm != null);
         EnableAndVisibleMenu(_menuItemEffects, activeForm != null);
         EnableAndVisibleMenu(_menuItemWindow, activeForm != null && MdiChildren.Length > 0);
         _menuItemColorWindowLevel.Enabled = (activeForm != null) &&
                                             ((activeForm.Image.BitsPerPixel == 12 || activeForm.Image.BitsPerPixel == 16) && activeForm.Image.GrayscaleMode != RasterGrayscaleMode.None);
         if (activeForm != null)
         {
            //EnableAndVisibleMenu(_menuItemPageFirst, activeForm.Image.PageCount > 1);
            //EnableAndVisibleMenu(_menuItemPagePrevious, activeForm.Image.PageCount > 1);
            //EnableAndVisibleMenu(_menuItemPageNext, activeForm.Image.PageCount > 1);
            //EnableAndVisibleMenu(_menuItemPageLast, activeForm.Image.PageCount > 1);
            //_menuItemPageSep1.Visible = activeForm.Image.PageCount > 1;
            //EnableAndVisibleMenu(_menuItemPageDeleteCurrentPage, activeForm.Image.PageCount > 1);

             EnableButton(toolStripFirst, activeForm.Image.PageCount > 1);
             EnableButton(toolStripPrevious, activeForm.Image.PageCount > 1);
             EnableButton(toolStripNext, activeForm.Image.PageCount > 1);
             EnableButton(toolStripLast, activeForm.Image.PageCount > 1);
             
            
            if (activeForm.Image.PageCount > 1)
            {
               //_menuItemPageFirst.Enabled = activeForm.Image.Page > 1;
               //_menuItemPagePrevious.Enabled = activeForm.Image.Page > 1;
               //_menuItemPageNext.Enabled = activeForm.Image.Page != activeForm.Image.PageCount;
               //_menuItemPageLast.Enabled = activeForm.Image.Page != activeForm.Image.PageCount;

               toolStripFirst.Enabled = activeForm.Image.Page > 1;
               toolStripPrevious.Enabled = activeForm.Image.Page > 1;
               toolStripNext.Enabled = activeForm.Image.Page != activeForm.Image.PageCount;
               toolStripLast.Enabled = activeForm.Image.Page != activeForm.Image.PageCount;

            }



            _menuItemViewSizeModeNormal.Checked = activeForm.Viewer.SizeMode == RasterPaintSizeMode.Normal;
            _menuItemViewSizeModeStretch.Checked = activeForm.Viewer.SizeMode == RasterPaintSizeMode.Stretch;
            _menuItemViewSizeModeFit.Checked = activeForm.Viewer.SizeMode == RasterPaintSizeMode.Fit;
            _menuItemViewSizeModeFitWidth.Checked = activeForm.Viewer.SizeMode == RasterPaintSizeMode.FitWidth;
            _menuItemViewSizeModeFitIfLarger.Checked = activeForm.Viewer.SizeMode == RasterPaintSizeMode.Fit;


            _menuItemViewAlignModeHorizontalNear.Checked = activeForm.Viewer.HorizontalAlignMode == RasterPaintAlignMode.Near;
            _menuItemViewAlignModeHorizontalCenter.Checked = activeForm.Viewer.HorizontalAlignMode == RasterPaintAlignMode.Center;
            _menuItemViewAlignModeHorizontalFar.Checked = activeForm.Viewer.HorizontalAlignMode == RasterPaintAlignMode.Far;

            _menuItemViewAlignModeVerticalNear.Checked = activeForm.Viewer.VerticalAlignMode == RasterPaintAlignMode.Near;
            _menuItemViewAlignModeVerticalCenter.Checked = activeForm.Viewer.VerticalAlignMode == RasterPaintAlignMode.Center;
            _menuItemViewAlignModeVerticalFar.Checked = activeForm.Viewer.VerticalAlignMode == RasterPaintAlignMode.Far;

            //not used in version 15 -- instead 6 lines above are used
            //_menuItemViewCenterNone.Checked = activeForm.Viewer.CenterMode == RasterViewerCenterMode.None;
            //_menuItemViewCenterHorizontal.Checked = activeForm.Viewer.CenterMode == RasterViewerCenterMode.Horizontal;
            //_menuItemViewCenterVertical.Checked = activeForm.Viewer.CenterMode == RasterViewerCenterMode.Vertical;
            //_menuItemViewCenterBoth.Checked = activeForm.Viewer.CenterMode == RasterViewerCenterMode.Both;

            _menuItemViewPalette.Enabled = activeForm.Image.BitsPerPixel <= 8;
            _menuItemViewPaddingFrame.Checked = activeForm.Viewer.FrameSize != SizeF.Empty;
            _menuItemViewPaddingFrameShadow.Checked = activeForm.Viewer.FrameShadowSize != SizeF.Empty;
            _menuItemViewPaddingBorder.Checked = activeForm.Viewer.BorderPadding.All != 0;

            _menuItemInteractiveNone.Checked = activeForm.Viewer.InteractiveMode == RasterViewerInteractiveMode.None || activeForm.Viewer.InteractiveMode == RasterViewerInteractiveMode.Floater;
            _menuItemInteractivePan.Checked = activeForm.Viewer.InteractiveMode == RasterViewerInteractiveMode.Pan;
            //_menuItemInteractiveOffset.Checked = activeForm.Viewer.InteractiveMode == RasterViewerInteractiveMode.Offset; removed from version 15
            _menuItemInteractiveCenterAt.Checked = activeForm.Viewer.InteractiveMode == RasterViewerInteractiveMode.CenterAt;
            _menuItemInteractiveZoomTo.Checked = activeForm.Viewer.InteractiveMode == RasterViewerInteractiveMode.ZoomTo;
            _menuItemInteractiveScale.Checked = activeForm.Viewer.InteractiveMode == RasterViewerInteractiveMode.Scale;
            _menuItemInteractivePage.Checked = activeForm.Viewer.InteractiveMode == RasterViewerInteractiveMode.Page;
            _menuItemInteractiveMagnifyGlass.Checked = activeForm.Viewer.InteractiveMode == RasterViewerInteractiveMode.MagnifyGlass;

            _menuItemEditRegionRectangle.Checked =
               activeForm.Viewer.InteractiveMode == RasterViewerInteractiveMode.Region &&
               activeForm.Viewer.InteractiveRegionType == RasterViewerInteractiveRegionType.Rectangle;
            _menuItemEditRegionEllipse.Checked =
               activeForm.Viewer.InteractiveMode == RasterViewerInteractiveMode.Region &&
               activeForm.Viewer.InteractiveRegionType == RasterViewerInteractiveRegionType.Ellipse;
            _menuItemEditRegionFreehand.Checked =
               activeForm.Viewer.InteractiveMode == RasterViewerInteractiveMode.Region &&
               activeForm.Viewer.InteractiveRegionType == RasterViewerInteractiveRegionType.Freehand;

            _menuItemEditRegionCancel.Enabled = activeForm.Viewer.Image.HasRegion || (activeForm.Viewer.FloaterImage != null && activeForm.Viewer.FloaterVisible);

            _menuItemViewZoom.Enabled = activeForm.Viewer.SizeMode == RasterPaintSizeMode.Normal;

            //_menuItemInteractivePanWindow.Checked = _panViewerForm.Visible;
         }
      }

      private void EnableAndVisibleMenu(ToolStripMenuItem menu, bool value)
      {
         menu.Enabled = value;
         menu.Visible = value;
      }
       private void EnableButton(ToolStripItem button, bool value)
       {
           button.Enabled = value;
       }


      private void _menuItemFileOpen_Click(object sender, System.EventArgs e)
      {
         try
         {
            ImageInformation info = LoadImage();
            if (info != null)
               NewImage(info);
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         finally
         {
            UpdateControls();
         }
      }

      private void _menuItemFileSave_Click(object sender, System.EventArgs e)
      {
         try
         {
            CombineFloater();
            _saver.Save(this, _codecs, ActiveViewerForm.Viewer.Image);
            
         }
         catch (Exception ex)
         {
            Messager.ShowFileSaveError(this, _saver.FileName, ex);
         }
      }

      private void _menuItemFileTwainSelectSource_Click(object sender, System.EventArgs e)
      {
         _inTwainAcquire = true;
         try
         {
            if (_twainSession != null)
                _twainSession.SelectSource(null);
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         _inTwainAcquire = false;
      }

      private void _menuItemFileTwainAcquire_Click(object sender, System.EventArgs e)
      {
         _inTwainAcquire = true;
         _acquirePageCount = 1;

         try
         {
            if (_twainSession != null)
            {
               DialogResult res = _twainSession.Acquire(TwainUserInterfaceFlags.Modal | TwainUserInterfaceFlags.Show);
            }
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         finally
         {
            _acquirePageCount = -1;
         }
         _inTwainAcquire = false;
      }

      private void _menuItemFilePrint_Click(object sender, System.EventArgs e)
      {
         if (_printDocument != null)
            _printDocument.Print();
      }

      private void _menuItemFilePrintPreview_Click(object sender, System.EventArgs e)
      {
         if (_printDocument != null)
         {
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = _printDocument;
            dlg.ShowDialog(this);
         }
      }

      private void _menuItemFileExit_Click(object sender, System.EventArgs e)
      {
         Close();
      }

      private void MainForm_MdiChildActivate(object sender, System.EventArgs e)
      {
         ViewerForm activeForm = ActiveViewerForm;

         //if (activeForm != null)
         //   _panViewerForm.SetViewer(activeForm.Viewer);
         //else
         //   _panViewerForm.SetViewer(null);
         if (activeForm != null)
             _panViewer.Viewer=activeForm.Viewer;
         else
             _panViewer.Viewer=null;
         
         //this.flowLayoutPanel1.Controls.Add(_panViewer);
         //this.flowLayoutPanel1.Refresh();
         //Image oneimage = activeForm.Viewer.Image.ConvertToGdiPlusImage();
         //Image thumbimage = oneimage.GetThumbnailImage(20,20, null, new IntPtr());
         //DataGridViewImageCell iconCell = new DataGridViewImageCell();
         
          //DataGridViewRow onerow = new DataGridViewRow();
          //DataGridViewCell onecell = new DataGridViewImageCell();
          //onecell.Value =  thumbimage;
          //onerow.Cells.Add( onecell);
         //dataGridView1.Rows.Add(onerow);
         
        //**added by unisystems 15/1/2008
        Size mySize = new Size(600, 850);
        Size currSize = activeForm.Viewer.Image.ImageSize;
        Size small = new Size(1, 1);
        activeForm.Viewer.SizeMode = RasterPaintSizeMode.Fit;
        if (currSize!=small)
        {
            activeForm.Snap();
            if (activeForm.WindowState != FormWindowState.Normal)
            {
                activeForm.WindowState = FormWindowState.Normal;
            }
            mySize = new Size(activeForm.Width, activeForm.Height);
        }
          
           
            this.Size = mySize;
            this.Refresh();
            activeForm.WindowState = FormWindowState.Maximized;
            activeForm.Refresh();
        
        //Size currSize = activeForm.Viewer.Image.ImageSize;
        //if (currSize.Width < 1200 && currSize.Height < 1700)
        //{
        //    RasterColor[] colors = null;
        //    RasterImage blank = new RasterImage(RasterMemoryFlags.Unmanaged, 1, 1, 1, RasterByteOrder.Gray, RasterViewPerspective.TopLeft, colors, null);
        //    activeForm.Image.AddPage(blank);
        //    activeForm.Image.RemovePageAt(1);
        //}

        //**
        UpdateControls();
      }

      void _menuItemEdit_DropDownOpened(object sender, System.EventArgs e)
      {
         _menuItemEditPaste.Enabled = RasterClipboard.IsReady;
      }

      private void _menuItemEditCut_Click(object sender, System.EventArgs e)
      {
         try
         {
            using (WaitCursor wait = new WaitCursor())
            {
               RasterClipboard.Copy(
                  this,
                  ImageToRun,
                  RasterClipboardCopyFlags.Empty |
                  RasterClipboardCopyFlags.Dib |
                  RasterClipboardCopyFlags.Palette |
                  RasterClipboardCopyFlags.Region);

               ViewerForm activeForm = ActiveViewerForm;

               if (activeForm.Viewer.FloaterImage != null && activeForm.Viewer.FloaterVisible)
                  activeForm.Viewer.FloaterImage = null;
            }
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         finally
         {
            UpdateControls();
         }
      }

      private void _menuItemEditCopy_Click(object sender, System.EventArgs e)
      {
         try
         {
            using (WaitCursor wait = new WaitCursor())
            {
               RasterClipboard.Copy(
                  this,
                  ImageToRun,
                  RasterClipboardCopyFlags.Empty |
                  RasterClipboardCopyFlags.Dib |
                  RasterClipboardCopyFlags.Palette |
                  RasterClipboardCopyFlags.Region);
            }
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         finally
         {
            UpdateControls();
         }
      }

      private void _menuItemEditPaste_Click(object sender, System.EventArgs e)
      {
         try
         {
            using (WaitCursor wait = new WaitCursor())
            {
               RasterImage image = RasterClipboard.Paste(this);
               if (image != null)
               {
                  ViewerForm activeForm = ActiveViewerForm;

                  if (image.HasRegion && activeForm == null)
                     image.MakeRegionEmpty();

                  if (image.HasRegion)
                  {
                     CombineFloater();
                     // make sure the images have the same BitsPerPixel and Palette
                     if (activeForm.Viewer.Image.BitsPerPixel > 8)
                     {
                        if (image.BitsPerPixel != activeForm.Viewer.Image.BitsPerPixel)
                        {
                           try
                           {
                              ColorResolutionCommand colorRes = new ColorResolutionCommand();
                              colorRes.BitsPerPixel = activeForm.Viewer.Image.BitsPerPixel;
                              colorRes.Order = activeForm.Viewer.Image.Order;
                              colorRes.Mode = Leadtools.ImageProcessing.ColorResolutionCommandMode.InPlace;
                              colorRes.Run(image);
                           }
                           catch (Exception ex)
                           {
                              Messager.ShowError(this, ex);
                           }
                        }
                     }
                     else
                     {
                        try
                        {
                            ColorResolutionCommand colorRes = new ColorResolutionCommand();
                            colorRes.BitsPerPixel = activeForm.Viewer.Image.BitsPerPixel;
                            colorRes.SetPalette(activeForm.Viewer.Image.GetPalette());
                            colorRes.PaletteFlags = ColorResolutionCommandPaletteFlags.UsePalette;
                            colorRes.Mode = ColorResolutionCommandMode.InPlace;
                            colorRes.Run(image);
                        }
                        catch (Exception ex)
                        {
                           Messager.ShowError(this, ex);
                        }
                     }
                     activeForm.Viewer.FloaterImage = image;
                     activeForm.Viewer.FloaterVisible = true;
                     Transformer t = new Transformer(activeForm.Viewer.Transform);
                     activeForm.Viewer.FloaterPosition = Point.Round(t.PointToLogical(Point.Empty));
                     activeForm.Viewer.InteractiveMode = RasterViewerInteractiveMode.Floater;
                  }
                  else
                     NewImage(new ImageInformation(image));
               }
            }
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         finally
         {
            UpdateControls();
         }
      }

      private void CancelFloater()
      {
         try
         {
            ViewerForm activeForm = ActiveViewerForm;

            if (activeForm.Viewer.FloaterImage != null)
               activeForm.Viewer.FloaterImage = null;
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         finally
         {
            UpdateControls();
         }
      }

      private void _menuItemEditDelete_Click(object sender, System.EventArgs e)
      {
         CancelFloater();
      }

      private void _menuItemEditCombine_Click(object sender, System.EventArgs e)
      {
         try
         {
            CombineFloater();
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         finally
         {
            UpdateControls();
         }
      }

      private void _menuItemImageInformation_Click(object sender, System.EventArgs e)
      {
         ImageInformationDialog dlg = new ImageInformationDialog();
         dlg.Image = ActiveViewerForm.Image;
         dlg.ShowDialog(this);
      }

      private void _menuItemImageUnderlay_Click(object sender, System.EventArgs e)
      {
         try
         {
            ImageInformation info = LoadImage();
            if (info != null)
            {
               UnderlayDialog dlg = new UnderlayDialog();
               if (dlg.ShowDialog(this) == DialogResult.OK)
               {
                  using (WaitCursor wait = new WaitCursor())
                  {
                     ViewerForm activeForm = ActiveViewerForm;

                     if (activeForm.Viewer.FloaterVisible && (activeForm.Viewer.FloaterImage != null))
                        activeForm.Viewer.FloaterImage.Underlay(info.Image, dlg.Flags);
                     else
                        activeForm.Viewer.Image.Underlay(info.Image, dlg.Flags);
                  }
               }
            }
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
      }

      private void _menuItemInteractive_Click(object sender, System.EventArgs e)
      {
         ViewerForm activeForm = ActiveViewerForm;

         if (sender == _menuItemInteractiveNone)
         {
             if (activeForm.Viewer.FloaterImage != null && activeForm.Viewer.FloaterVisible)
                 activeForm.Viewer.InteractiveMode = RasterViewerInteractiveMode.Floater;
             else
                 activeForm.Viewer.InteractiveMode = RasterViewerInteractiveMode.None;
         }
         else if (sender == _menuItemInteractivePan)
             activeForm.Viewer.InteractiveMode = RasterViewerInteractiveMode.Pan;
         else if (sender == _menuItemInteractiveCenterAt)
             activeForm.Viewer.InteractiveMode = RasterViewerInteractiveMode.CenterAt;
         else if (sender == _menuItemInteractiveZoomTo)
             activeForm.Viewer.InteractiveMode = RasterViewerInteractiveMode.ZoomTo;
         else if (sender == _menuItemInteractiveScale)
             activeForm.Viewer.InteractiveMode = RasterViewerInteractiveMode.Scale;
         else if (sender == _menuItemInteractivePage)
         {
             CancelFloater();
             activeForm.Viewer.InteractiveMode = RasterViewerInteractiveMode.Page;
         }
         else if (sender == _menuItemInteractiveMagnifyGlass)
         {
             CancelFloater();
             activeForm.Viewer.InteractiveMode = RasterViewerInteractiveMode.MagnifyGlass;
         }

         UpdateControls();
      }

      private void _menuItemInteractivePanWindow_Click(object sender, System.EventArgs e)
      {
         _panViewerForm.Visible = !_panViewerForm.Visible;
         UpdateControls();
      }

      private void _menuItemPage_Click(object sender, System.EventArgs e)
      {
         try
         {
            ViewerForm activeForm = ActiveViewerForm;

            if (activeForm.Viewer.Image.HasRegion)
               activeForm.Viewer.Image.MakeRegionEmpty();
            if (activeForm.Viewer.FloaterImage != null)
            {
               activeForm.Viewer.FloaterImage.Dispose();
               activeForm.Viewer.FloaterImage = null;
            }

            if (sender == _menuItemPageFirst)
               activeForm.Image.Page = 1;
            else if (sender == _menuItemPagePrevious)
               activeForm.Image.Page--;
            else if (sender == _menuItemPageNext)
               activeForm.Image.Page++;
            else if (sender == _menuItemPageLast)
               activeForm.Image.Page = activeForm.Image.PageCount;
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         finally
         {
            UpdateControls();
         }
      }

      private void _menuItemPageAdd_Click(object sender, System.EventArgs e)
      {
         try
         {
            ImageInformation info = LoadImage();
            if (info != null)
               ActiveViewerForm.Image.AddPages(info.Image, 1, info.Image.PageCount);
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         finally
         {
            UpdateControls();
         }
      }

      private void _menuItemPageDeleteCurrentPage_Click(object sender, System.EventArgs e)
      {
         try
         {
            ViewerForm activeForm = ActiveViewerForm;

            activeForm.Image.RemovePageAt(activeForm.Image.Page);
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         finally
         {
            UpdateControls();
         }
      }


      private void _menuItemViewSizeMode_Click(object sender, System.EventArgs e)
      {
         ViewerForm activeForm = ActiveViewerForm;

         if (sender == _menuItemViewSizeModeNormal)
         {
             activeForm.Viewer.SizeMode = RasterPaintSizeMode.Normal;
            activeForm.Viewer.ScaleFactor = 1;
         }
         else if (sender == _menuItemViewSizeModeSnap)
         {
            activeForm.Snap();
            if (activeForm.WindowState != FormWindowState.Normal)
            {
                activeForm.WindowState = FormWindowState.Normal;
                

            }

         }
         else
         {
            activeForm.Viewer.BeginUpdate();
            if (sender == _menuItemViewSizeModeStretch) activeForm.Viewer.SizeMode = RasterPaintSizeMode.Stretch;
            else if (sender == _menuItemViewSizeModeFit) activeForm.Viewer.SizeMode = RasterPaintSizeMode.Fit;
            else if (sender == _menuItemViewSizeModeFitWidth) activeForm.Viewer.SizeMode = RasterPaintSizeMode.FitWidth;
            else if (sender == _menuItemViewSizeModeFitIfLarger) activeForm.Viewer.SizeMode = RasterPaintSizeMode.Fit;
            activeForm.Viewer.ScaleFactor = 1;
            activeForm.Viewer.EndUpdate();
         }

         UpdateControls();
      }

      private void _menuItemViewCenter_Click(object sender, System.EventArgs e)
      {
         ViewerForm activeForm = ActiveViewerForm;

         if (sender == _menuItemViewAlignModeHorizontalNear)
             activeForm.Viewer.HorizontalAlignMode = RasterPaintAlignMode.Near;
         else if (sender == _menuItemViewAlignModeHorizontalCenter)
             activeForm.Viewer.HorizontalAlignMode = RasterPaintAlignMode.Center;
         else if (sender == _menuItemViewAlignModeHorizontalFar)
             activeForm.Viewer.HorizontalAlignMode = RasterPaintAlignMode.Far;
         else if (sender == _menuItemViewAlignModeVerticalNear)
             activeForm.Viewer.VerticalAlignMode = RasterPaintAlignMode.Near;
         else if (sender == _menuItemViewAlignModeVerticalCenter)
             activeForm.Viewer.VerticalAlignMode = RasterPaintAlignMode.Center;
         else if (sender == _menuItemViewAlignModeVerticalFar)
             activeForm.Viewer.VerticalAlignMode = RasterPaintAlignMode.Far;
         //not used in version 15 
         //if (sender == _menuItemViewCenterNone) activeForm.Viewer.CenterMode = RasterViewerCenterMode.None;
         //else if (sender == _menuItemViewCenterHorizontal) activeForm.Viewer.CenterMode = RasterViewerCenterMode.Horizontal;
         //else if (sender == _menuItemViewCenterVertical) activeForm.Viewer.CenterMode = RasterViewerCenterMode.Vertical;
         ////else if (sender == _menuItemViewCenterBoth) activeForm.Viewer.CenterMode = RasterViewerCenterMode.Both;
         UpdateControls();
      }

      public void Zoom(bool zoomIn)
      {
         if (zoomIn)
            _menuItemViewZoomIn.PerformClick();
         else
            _menuItemViewZoomOut.PerformClick();
      }

      private void _menuItemViewZoom_Click(object sender, System.EventArgs e)
      {
         // get the current center in logical units
         RasterImageViewer viewer = ActiveViewerForm.Viewer; // get the active viewer
         Rectangle rc = Rectangle.Intersect(viewer.PhysicalViewRectangle, viewer.ClientRectangle); // get what you see in physical coordinates
         PointF center = new PointF(rc.Left + rc.Width / 2, rc.Top + rc.Height / 2); // get the center of what you see in physical coordinates
         Transformer t = new Transformer(viewer.Transform);
         center = t.PointToLogical(center);  // get the center of what you see in logical coordinates

         // zoom     
         double scaleFactor = viewer.ScaleFactor;

         const float ratio = 1.2F;

         if (sender == _menuItemViewZoomIn)
         {
            scaleFactor *= ratio;
         }
         else if (sender == _menuItemViewZoomOut)
         {
            scaleFactor /= ratio;
         }
         else if (sender == _menuItemViewZoomNormal)
         {
            scaleFactor = 1;
            if (viewer.SizeMode != RasterPaintSizeMode.Normal)
                viewer.SizeMode = RasterPaintSizeMode.Normal;
            //viewer.Offset = SizeF.Empty; not used in version 15
         }
         else
         {
            ZoomDialog dlg = new ZoomDialog();
            dlg.Value = (int)(scaleFactor * 100);
            dlg.MinimumValue = (int)(_minimumScaleFactor * 100F);
            dlg.MaximumValue = (int)(_maximumScaleFactor * 100F);

            if (dlg.ShowDialog(this) == DialogResult.OK)
               scaleFactor = (float)dlg.Value / 100f;
         }

         scaleFactor = Math.Max(_minimumScaleFactor, Math.Min(_maximumScaleFactor, scaleFactor));

         if (viewer.ScaleFactor != scaleFactor)
         {
            viewer.ScaleFactor = scaleFactor;

            // bring the original center into the view center
            t = new Transformer(viewer.Transform);
            center = t.PointToPhysical(center); // get the center of what you saw before the zoom in physical coordinates
            viewer.CenterAtPoint(Point.Round(center)); // bring the old center into the center of the view
         }
      }

      private void _menuItemViewPadding_Click(object sender, System.EventArgs e)
      {
         ViewerForm activeForm = ActiveViewerForm;

         if (sender == _menuItemViewPaddingFrame) activeForm.Viewer.FrameSize = activeForm.Viewer.FrameSize == SizeF.Empty ? new SizeF(10, 10) : SizeF.Empty;
         else if (sender == _menuItemViewPaddingFrameShadow) activeForm.Viewer.FrameShadowSize = activeForm.Viewer.FrameShadowSize == SizeF.Empty ? new SizeF(10, 10) : SizeF.Empty;
         else if (sender == _menuItemViewPaddingBorder) activeForm.Viewer.BorderPadding.All = activeForm.Viewer.BorderPadding.All == 0 ? 100 : 0;
         UpdateControls();
      }

      private void _menuItemViewPalette_Click(object sender, System.EventArgs e)
      {
          PaletteDialog dlg = new PaletteDialog();
          dlg.Palette = ActiveViewerForm.Image.GetPalette();
          dlg.ShowDialog(this);
      }

      private void _menuItemViewPaint_Click(object sender, System.EventArgs e)
      {
         ValueDialog dlg = null;

         ViewerForm activeForm = ActiveViewerForm;

         if (sender == _menuItemViewPaintIntensity)
         {
            dlg = new ValueDialog(ValueDialog.TypeConstants.PaintIntensity);
            dlg.Value = dlg.Value = activeForm.Viewer.Image.PaintIntensity;
         }
         else if (sender == _menuItemViewPaintContrast)
         {
            dlg = new ValueDialog(ValueDialog.TypeConstants.PaintContrast);
            dlg.Value = dlg.Value = activeForm.Viewer.Image.PaintContrast;
         }
         else if (sender == _menuItemViewPaintGamma)
         {
            dlg = new ValueDialog(ValueDialog.TypeConstants.PaintGamma);
            dlg.Value = dlg.Value = activeForm.Viewer.Image.PaintGamma;
         }

         if (dlg != null && dlg.ShowDialog(this) == DialogResult.OK)
         {
            if (sender == _menuItemViewPaintIntensity)
               activeForm.Viewer.Image.PaintIntensity = dlg.Value;
            else if (sender == _menuItemViewPaintContrast)
               activeForm.Viewer.Image.PaintContrast = dlg.Value;
            else if (sender == _menuItemViewPaintGamma)
               activeForm.Viewer.Image.PaintGamma = dlg.Value;

            SetFloaterPaintValues();
         }
      }

      public void SetFloaterPaintValues()
      {
         ViewerForm activeForm = ActiveViewerForm;
         if (activeForm != null)
         {
            if (activeForm.Viewer.FloaterImage != null && activeForm.Viewer.FloaterVisible)
            {
               activeForm.Viewer.FloaterImage.PaintIntensity = activeForm.Viewer.Image.PaintIntensity;
               activeForm.Viewer.FloaterImage.PaintContrast = activeForm.Viewer.Image.PaintContrast;
               activeForm.Viewer.FloaterImage.PaintGamma = activeForm.Viewer.Image.PaintGamma;
            }
         }
      }

      private void _menuItemViewPaintProperties_Click(object sender, System.EventArgs e)
      {
         PaintPropertiesDialog dlg = new PaintPropertiesDialog();
         dlg.PaintProperties = _paintProperties;
         dlg.Apply += new EventHandler(PaintPropertiesDialog_Apply);
         dlg.ShowDialog(this);
      }

      private void PaintPropertiesDialog_Apply(object sender, EventArgs e)
      {
         PaintPropertiesDialog dlg = sender as PaintPropertiesDialog;
         _paintProperties = dlg.PaintProperties;
         foreach (ViewerForm i in MdiChildren)
            i.UpdatePaintProperties(_paintProperties);
      }

      private void _menuItemViewFastFlip_Click(object sender, System.EventArgs e)
      {
         try
         {
            ImageToRun.FlipViewPerspective(sender == _menuItemViewFastFlipHorizontal);
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
      }

      private void _menuItemViewFastRotate_Click(object sender, System.EventArgs e)
      {
         int degrees;
         if (sender == _menuItemViewFastRotate180)
            degrees = 180;
         else if (sender == _menuItemViewFastRotate270)
            degrees = 270;
         else
            degrees = 90;

         try
         {
            ImageToRun.RotateViewPerspective(degrees);
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
      }

      private void _menuItemEditRegion_Click(object sender, System.EventArgs e)
      {
         ViewerForm activeForm = ActiveViewerForm;

         if (sender == _menuItemEditRegionRectangle)
         {
            activeForm.Viewer.InteractiveMode = RasterViewerInteractiveMode.Region;
            activeForm.Viewer.InteractiveRegionType = RasterViewerInteractiveRegionType.Rectangle;
         }
         else if (sender == _menuItemEditRegionEllipse)
         {
            activeForm.Viewer.InteractiveMode = RasterViewerInteractiveMode.Region;
            activeForm.Viewer.InteractiveRegionType = RasterViewerInteractiveRegionType.Ellipse;
         }
         else if (sender == _menuItemEditRegionFreehand)
         {
            activeForm.Viewer.InteractiveMode = RasterViewerInteractiveMode.Region;
            activeForm.Viewer.InteractiveRegionType = RasterViewerInteractiveRegionType.Freehand;
         }

         UpdateControls();
      }

      private void _menuItemEditRegionCancel_Click(object sender, System.EventArgs e)
      {
         CombineFloater();
      }

      private void _menuItemFormat_Click(object sender, System.EventArgs e)
      {
         IRasterCommand command = null;

         if (sender == _menuItemColorTransformColorResolution)
         {
            ViewerForm activeForm = ActiveViewerForm;
            ColorResolutionDialog dlg = new ColorResolutionDialog();
            dlg.BitsPerPixel = activeForm.Viewer.Image.BitsPerPixel;
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new ColorResolutionCommand(ColorResolutionCommandMode.InPlace, dlg.BitsPerPixel, dlg.Order, dlg.DitheringMethod, dlg.PaletteFlags, null);
         }
         else if (sender == _menuItemColorTransformHalftone)
         {
            HalftoneDialog dlg = new HalftoneDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new HalfToneCommand(dlg.Type, dlg.Angle, dlg.Dimension, null);
         }
         else if (sender == _menuItemColorGrayScale)
         {
            GrayScaleDialog dlg = new GrayScaleDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
                command = new GrayscaleCommand(dlg.BitsPerPixel);
         }
         else if (sender == _menuItemColorTransformGrayScaleFactor)
         {
            GrayScaleFactorDialog dlg = new GrayScaleFactorDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new GrayScaleExtendedCommand(dlg.RedFactor, dlg.GreenFactor, dlg.BlueFactor);
         }

         if (command != null)
            RunCommand(command);
      }

      private void _menuItemImage_Click(object sender, System.EventArgs e)
      {
         IRasterCommand command = null;
         ViewerForm activeForm = ActiveViewerForm;

         if (sender == _menuItemImageAutoTrim)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.AutoCrop);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new AutoCropCommand(dlg.Value);
         }
         else if (sender == _menuItemImageTrim)
         {
            CropDialog dlg = new CropDialog(activeForm.Image.Width, activeForm.Image.Height);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               RasterImage image = activeForm.Image;
               if (dlg.CropLeft > image.Width ||
                  dlg.CropTop > image.Height ||
                  (dlg.CropLeft + dlg.CropWidth) > image.Width ||
                  (dlg.CropTop + dlg.CropHeight) > image.Height)
                  Messager.ShowError(this, "Crop values greater than image dimension!");
               else
                  command = new CropCommand(new Rectangle(dlg.CropLeft, dlg.CropTop, dlg.CropWidth, dlg.CropHeight));
            }
         }
         else if (sender == _menuItemImageDeskew)
         {
            DeskewDialog dlg = new DeskewDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new DeskewCommand(dlg.FillColor, dlg.Flags);
         }
         else if (sender == _menuItemImageFlip)
         {
            FlipDialog dlg = new FlipDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new FlipCommand(dlg.Horizontal);
         }
         else if (sender == _menuItemImageRotate)
         {
            RotateDialog dlg = new RotateDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new RotateCommand(dlg.Angle, dlg.Flags, dlg.FillColor);
         }
         else if (sender == _menuItemImageResize)
         {
            ResizeDialog dlg = new ResizeDialog(activeForm.Image.Width, activeForm.Image.Height);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new SizeCommand(dlg.ImageWidth, dlg.ImageHeight, dlg.Flags);
         }
         else if (sender == _menuItemImageShear)
         {
            ShearDialog dlg = new ShearDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new ShearCommand(dlg.Angle, dlg.Horizontal, dlg.FillColor);
         }

         if (command != null)
            RunCommand(command);
      }

      private void _menuItemEffectsSpecial_Click(object sender, System.EventArgs e)
      {
         IRasterCommand command = null;
         ViewerForm activeForm = ActiveViewerForm;

         if (sender == _menuItemEffectsNoiseAddNoise)
         {
            AddNoiseDialog dlg = new AddNoiseDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new AddNoiseCommand(dlg.Range, dlg.Channel);
         }
         else if (sender == _menuItemEffectsBlurAntiAlias)
         {
            AntiAliasDialog dlg = new AntiAliasDialog(activeForm.Image.BitsPerPixel);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new AntiAliasingCommand(dlg.Threshold, dlg.Dimension, dlg.Filter);
         }
         else if (sender == _menuItemEffectsBlurAverage)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Average);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new AverageCommand(dlg.Value);
         }
         else if (sender == _menuItemEffectsEdgeDetector)
         {
            EdgeDetectorDialog dlg = new EdgeDetectorDialog(activeForm.Image.BitsPerPixel);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new EdgeDetectorCommand(dlg.Threshold, dlg.Filter);
         }
         else if (sender == _menuItemEffects3DEffectsEmboss)
         {
            EmbossDialog dlg = new EmbossDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new EmbossCommand(dlg.Direction, dlg.Depth);
         }
         else if (sender == _menuItemEffectsSpecialGaussian)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Gaussian);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new GaussianCommand(dlg.Value);
         }
         else if (sender == _menuItemEffectsNoiseMedian)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Median);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new MedianCommand(dlg.Value);
         }
         else if (sender == _menuItemEffectsPixelateMosaic)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Mosaic);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new MosaicCommand(dlg.Value);
         }
         else if (sender == _menuItemEffectsBlurMotionBlur)
         {
            MotionBlurDialog dlg = new MotionBlurDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new MotionBlurCommand(dlg.Dimension, dlg.Angle, dlg.UniDirectional);
         }
         else if (sender == _menuItemEffectsArtisticOilify)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Oilify);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new OilifyCommand(dlg.Value);
         }
         else if (sender == _menuItemColorPosterize)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Posterize);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new PosterizeCommand(dlg.Value);
         }
         else if (sender == _menuItemEffectsSharpenSharpen)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Sharpen);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new SharpenCommand(dlg.Value);
         }
         else if (sender == _menuItemEffectsSharpenUnsharpMask)
         {
            UnsharpMaskDialog dlg = new UnsharpMaskDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new UnsharpMaskCommand(dlg.Amount, dlg.Radius, dlg.Threshold, dlg.ColorSpace);
         }

         if (command != null)
            RunCommand(command);
      }

      private void _menuItemEffectsSpatialSpatialFilters_Click(object sender, System.EventArgs e)
      {
         SpatialDialog dlg = new SpatialDialog();
         if (dlg.ShowDialog(this) == DialogResult.OK)
            RunCommand(new SpatialFilterCommand(dlg.Filter));
      }

      private void _menuItemEffectsBinary_Click(object sender, System.EventArgs e)
      {
         IRasterCommand command = null;

         if (sender == _menuItemEffectsBinaryBinaryFilters)
         {
            BinaryDialog dlg = new BinaryDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new BinaryFilterCommand(dlg.Filter);
         }
         else if (sender == _menuItemEffectsNoiseMin)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Min);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new MinimumCommand(dlg.Value);
         }
         else if (sender == _menuItemEffectsNoiseMax)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Max);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new MaximumCommand(dlg.Value);
         }

         if (command != null)
            RunCommand(command);
      }

      private void _menuItemColor_Click(object sender, System.EventArgs e)
      {
         IRasterCommand command = null;

         if (sender == _menuItemColorAdjustContrast)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Contrast);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new ChangeContrastCommand(dlg.Value);
         }
         else if (sender == _menuItemEffectsEdgeContour)
         {
            ContourDialog dlg = new ContourDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new ContourFilterCommand(dlg.Threshold, dlg.DeltaDirection, dlg.MaximumError, dlg.Type);
         }
         else if (sender == _menuItemColorFill)
         {
            if (Tools.ShowColorDialog(this, ref _fillColor))
               command = new FillCommand(_fillColor);
         }
         else if (sender == _menuItemColorAdjustGammaCorrect)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.GammaCorrect);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new GammaCorrectCommand(dlg.Value);
         }
         else if (sender == _menuItemColorHistogramContrast)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.HistoContrast);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new HistogramContrastCommand(dlg.Value);
         }
         else if (sender == _menuItemColorHistogramEqualize)
         {
            HistogramEqualizeDialog dlg = new HistogramEqualizeDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new HistogramEqualizeCommand(dlg.ColorSpace);
         }
         else if (sender == _menuItemColorAdjustHue)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Hue);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new ChangeHueCommand(dlg.Value);
         }
         else if (sender == _menuItemColorInvert)
         {
            command = new InvertCommand();
         }
         else if (sender == _menuItemColorAdjustBrightness)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Intensity);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new ChangeIntensityCommand(dlg.Value);
         }
         else if (sender == _menuItemColorIntensityDetect)
         {
            IntensityDetectDialog dlg = new IntensityDetectDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new IntensityDetectCommand(dlg.Low, dlg.High, dlg.InColor, dlg.OutColor, dlg.Channel);
         }
         else if (sender == _menuItemColorAdjustSaturation)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Saturation);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new ChangeSaturationCommand(dlg.Value);
         }
         else if (sender == _menuItemColorSolarize)
         {
            ValueDialog dlg = new ValueDialog(ValueDialog.TypeConstants.Solarize);
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new SolarizeCommand(dlg.Value);
         }
         else if (sender == _menuItemColorHistogramStretchIntensity)
         {
            command = new StretchIntensityCommand();
         }
         else if (sender == _menuItemColorSwapColors)
         {
            SwapColorsDialog dlg = new SwapColorsDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new SwapColorsCommand(dlg.Type);
         }
         else if(sender == _menuItemColorUniqueColors)
         {
            ColorCountCommand colorCount = new ColorCountCommand();
            colorCount.Run(ActiveViewerForm.Image);
            string message = string.Format("Image contains {0} unique colors", colorCount.ColorCount);
            Messager.ShowInformation(this, message);
         }

         if (command != null)
            RunCommand(command);
      }

      private void _menuItemDocument_Click(object sender, System.EventArgs e)
      {
         IRasterCommand command = null;

         if (sender == _menuItemDocumentBorderRemove)
         {
            BorderRemoveDialog dlg = new BorderRemoveDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new BorderRemoveCommand(dlg.Flags, dlg.Border, dlg.Percent, dlg.WhiteNoiseLength, dlg.Variance);
         }
         else if (sender == _menuItemDocumentDespeckle)
         {
            command = new DespeckleCommand();
         }
         else if (sender == _menuItemDocumentDotRemove)
         {
            DotRemoveDialog dlg = new DotRemoveDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new DotRemoveCommand(dlg.Flags, dlg.MinWidth, dlg.MinHeight, dlg.MaxWidth, dlg.MaxHeight);
         }
         else if (sender == _menuItemDocumentHolePunchRemove)
         {
            HolePunchRemoveDialog dlg = new HolePunchRemoveDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new HolePunchRemoveCommand(dlg.Flags, dlg.HoleLocation, dlg.MinCount, dlg.MaxCount, dlg.MinWidth, dlg.MinHeight, dlg.MaxWidth, dlg.MaxHeight);
         }
         else if (sender == _menuItemDocumentInvertedText)
         {
            InvertedTextDialog dlg = new InvertedTextDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new InvertedTextCommand(dlg.Flags, dlg.MinInvertWidth, dlg.MinInvertHeight, dlg.MinBlackPercent, dlg.MaxBlackPercent);
         }
         else if (sender == _menuItemDocumentLineRemove)
         {
            LineRemoveDialog dlg = new LineRemoveDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new LineRemoveCommand(dlg.Flags, dlg.MinLineLength, dlg.MaxLineWidth, dlg.Wall, dlg.MaxWallPercent, dlg.GapLength, dlg.LineVariance, dlg.Remove);
         }
         else if (sender == _menuItemDocumentSmooth)
         {
            SmoothDialog dlg = new SmoothDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
               command = new SmoothCommand(dlg.Flags, dlg.Length);
         }

         if (command != null)
            RunCommand(command);
      }

      private void _menuItemPreferencesProgressBar_Click(object sender, System.EventArgs e)
      {
         _menuItemPreferencesProgressBar.Checked = !_menuItemPreferencesProgressBar.Checked;
      }

      private void _menuItemHelpAbout_Click(object sender, System.EventArgs e)
      {
         new AboutDialog("Main").ShowDialog(this);
      }

      private void _menuItemWindow_Click(object sender, System.EventArgs e)
      {
         if (sender == _menuItemWindowCascade)
            LayoutMdi(MdiLayout.Cascade);
         else if (sender == _menuItemWindowTileHorizontally)
            LayoutMdi(MdiLayout.TileHorizontal);
         else if (sender == _menuItemWindowTileVertically)
            LayoutMdi(MdiLayout.TileVertical);
         else if (sender == _menuItemWindowArrangeIcons)
            LayoutMdi(MdiLayout.ArrangeIcons);
         else if (sender == _menuItemWindowCloseAll)
         {
            while (MdiChildren.Length > 0)
               MdiChildren[0].Close();
            UpdateControls();
         }
      }

      private ImageInformation LoadImage()
      {
         ImageFileLoader loader = new ImageFileLoader();

         try
         {
            loader.ShowLoadPagesDialog = true;

            if (loader.Load(this, _codecs, true))

               
               return new ImageInformation(loader.Image, loader.FileName);
         }
         catch (Exception ex)
         {
            Messager.ShowFileOpenError(this, loader.FileName, ex);
         }

         return null;
      }

      private void NewImage(ImageInformation info)
      {
         ViewerForm child = new ViewerForm();
         child.MdiParent = this;
         child.Initialize(info, _paintProperties, true);
         child.Show();



         _menuItemColorWindowLevel.Enabled = (info.Image.GrayscaleMode != RasterGrayscaleMode.None);
         
      }

      private bool ShouldProcessMainImage(IRasterCommand command)
      {
         ViewerForm activeForm = ActiveViewerForm;
         if (activeForm.Viewer.FloaterImage != null && activeForm.Viewer.FloaterVisible)
         {
             if (command is GrayscaleCommand)
               return true;
            if (command is GrayScaleExtendedCommand)
               return true;
            if (command is ColorResolutionCommand)
               return true;
            if (command is HalfToneCommand)
               return true;
         }
         return false;
      }

      private RasterImage ImageToRun
      {
         get
         {
            ViewerForm activeForm = ActiveViewerForm;

            if (activeForm.Viewer.FloaterImage != null && activeForm.Viewer.FloaterVisible)
               return activeForm.Viewer.FloaterImage;
            else
               return activeForm.Viewer.Image;
         }
         set
         {
            if (value != null)
            {
               ViewerForm activeForm = ActiveViewerForm;

               if (activeForm.Viewer.FloaterImage != null && activeForm.Viewer.FloaterVisible)
                  activeForm.Viewer.FloaterImage = value;
               else
                  activeForm.Viewer.Image = value;
            }
         }
      }

      private void RunCommand(IRasterCommand command)
      {
         ViewerForm activeForm = ActiveViewerForm;

         try
         {
            // save the floater position so we preserve the center
            Point oldFloaterCenter = new Point(0, 0);
            if (activeForm.Viewer.FloaterVisible && (activeForm.Viewer.FloaterImage != null))
            {
               oldFloaterCenter = activeForm.Viewer.FloaterPosition;
               Rectangle rect = activeForm.Viewer.FloaterImage.GetRegionBounds(null);
               oldFloaterCenter.Offset(rect.Right / 2, rect.Bottom / 2);
            }
            if (_menuItemPreferencesProgressBar.Checked)
            {
               CommandProgressDialog dlg = new CommandProgressDialog();
               dlg.Command = command;
               dlg.Image = ImageToRun;
               // save the image, in case the command is canceled
               int currentPage = ImageToRun.Page;
               using (RasterImage backupImage = ImageToRun.CloneAll())
               {
                  dlg.ShowDialog(this);
                  if (dlg.Cancel)
                  {
                     ImageToRun = backupImage.CloneAll();
                     ImageToRun.Page = currentPage;
                  }
                  dlg.Hide();
                  dlg.Dispose();
                  Application.DoEvents();
               }
               if (ShouldProcessMainImage(command))// if true, then the floater has been processed
               {
                  dlg.Image = activeForm.Viewer.Image;
                  // save the image, in case the command is canceled
                  currentPage = activeForm.Viewer.Image.Page;
                  using (RasterImage backupImage = activeForm.Viewer.Image.CloneAll())
                  {
                     CommandProgressDialog dlg2 = new CommandProgressDialog();
                     dlg2.Command = dlg.Command;
                     dlg2.Image = dlg.Image;
                     dlg2.ShowDialog(this);
                     if (dlg2.Cancel)
                     {
                        activeForm.Viewer.Image = backupImage.CloneAll();
                        activeForm.Viewer.Image.Page = currentPage;
                     }
                     dlg2.Hide();
                     dlg2.Dispose();
                     Application.DoEvents();
                  }
               }
            }
            else
            {
               using (WaitCursor wait = new WaitCursor())
               {
                  command.Run(ImageToRun);
                  if (ShouldProcessMainImage(command))// if true, then the floater has been processed
                     command.Run(activeForm.Viewer.Image); // now process the main image
               }
            }
            if (activeForm.Viewer.FloaterVisible && (activeForm.Viewer.FloaterImage != null))
            {
               Point newFloaterCenter = activeForm.Viewer.FloaterPosition;
               newFloaterCenter.Offset(activeForm.Viewer.FloaterImage.Width / 2, activeForm.Viewer.FloaterImage.Height / 2);
               // move the floater so the center is preserved
               Point floaterPosition = activeForm.Viewer.FloaterPosition;
               floaterPosition.Offset(oldFloaterCenter.X - newFloaterCenter.X,
                  oldFloaterCenter.Y - newFloaterCenter.Y);
               activeForm.Viewer.FloaterPosition = floaterPosition;
            }
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
      }

      private void _printDocument_PrintPage(object sender, PrintPageEventArgs e)
      {
         CombineFloater();
         RasterImage image = ActiveViewerForm.Viewer.Image;

         RasterImagePrinter printer = new RasterImagePrinter();
         printer.Print(image, image.Page, e);
      }

      private void _twainSession_AcquirePage(object sender, TwainAcquirePageEventArgs e)
      {
          //DialogResult result = DialogResult.Cancel;

         Application.DoEvents();

         if (e.Image != null)
         {  //commented by unisystems 9/7/2008
             //if (_acquirePageCount == 1)
             //    NewImage(new ImageInformation(e.Image, "Twain Image"));
             //else
               ActiveViewerForm.Image.AddPage(e.Image);


            _acquirePageCount++;
            //result = DialogResult.OK;
         }

         //return result;
      }

      private void MainForm_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
      {
         if (Tools.CanDrop(e.Data))
            e.Effect = DragDropEffects.Copy;
      }

      private void MainForm_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
      {
         if (Tools.CanDrop(e.Data))
         {
            string[] files = Tools.GetDropFiles(e.Data);
            if (files != null)
               LoadDropFiles(null, files);
         }
      }

      public void LoadDropFiles(ViewerForm viewer, string[] files)
      {
         try
         {
            if (files != null)
            {
               for (int i = 0; i < files.Length; i++)
               {
                  try
                  {
                     RasterImage image = _codecs.Load(files[i]);
                     ImageInformation info = new ImageInformation(image, files[i]);
                     if (i == 0 && viewer != null)
                        viewer.Initialize(info, _paintProperties, false);
                     else
                        NewImage(info);
                  }
                  catch (Exception ex)
                  {
                     Messager.ShowFileOpenError(this, files[i], ex);
                  }
               }
            }
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         finally
         {
            UpdateControls();
         }
      }

      private void CombineFloater()
      {
         ViewerForm activeForm = ActiveViewerForm;

         if (activeForm.Viewer.Image.HasRegion)
            activeForm.Viewer.Image.MakeRegionEmpty();
         else if (activeForm.Viewer.FloaterVisible && activeForm.Viewer.FloaterImage != null)
         {
            activeForm.Viewer.InteractiveMode = RasterViewerInteractiveMode.None;
            activeForm.Viewer.CombineFloater(true, CombineFastCommandFlags.SourceCopy);
            activeForm.Viewer.FloaterImage = null;
         }

         UpdateControls();
      }

      private void _menuItemImage_DropDownOpened (object sender, System.EventArgs e)
      {
         if (ActiveViewerForm.Viewer.Image.BitsPerPixel > 1)
            _menuItemDocument.Enabled = false;
         else
            _menuItemDocument.Enabled = true;
      }

      private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (_inTwainAcquire)
            e.Cancel = true;
      }

      private void codecs_LoadInformation(object sender, CodecsLoadInformationEventArgs e)
      {
         // Set the information
         e.Format = _rawdataLoad.Format;
         e.Width = _rawdataLoad.Width;
         e.Height = _rawdataLoad.Height;
         e.BitsPerPixel = _rawdataLoad.BitsPerPixel;
         e.XResolution = _rawdataLoad.XResolution;
         e.YResolution = _rawdataLoad.YResolution;
         e.Offset = _rawdataLoad.Offset;
         e.WhiteOnBlack = _rawdataLoad.WhiteOnBlack;

         if (_rawdataLoad.Padding)
            e.Pad4 = true;

         e.Order = _rawdataLoad.Order;

         if (_rawdataLoad.ReverseBits)
            e.LeastSignificantBitFirst = true;

         e.ViewPerspective = _rawdataLoad.ViewPerspective;

         // If image is palettized create a grayscale palette
         if (_rawdataLoad.PaletteEnabled)
         {
            if (e.BitsPerPixel <= 8)
            {
               if (!_rawdataLoad.FixedPalette)
               {
                  int colors = 1 << e.BitsPerPixel;
                  RasterColor[] palette = new RasterColor[colors];
                  for (int i = 0; i < palette.Length; i++)
                  {
                     byte val = (byte)((i * 256) / colors);
                     palette[i] = new RasterColor(val, val, val);
                  }

                  e.SetPalette(palette);
               }
               else
               {
                   e.SetPalette(RasterPalette.Fixed(e.BitsPerPixel));
               }
            }
         }
      }

      private void LoadRaw(string fileName)
      {
         RawDialog dlg = new RawDialog(true);
         dlg.CurrentRawData = _rawdataLoad;
         if (dlg.ShowDialog(this) == DialogResult.OK)
         {
             ImageInformation imageInfo = new ImageInformation();
             imageInfo.Name = fileName;
             _rawdataLoad = dlg.CurrentRawData;

             EventHandler<CodecsLoadInformationEventArgs> handler = new EventHandler<CodecsLoadInformationEventArgs>(codecs_LoadInformation);
             _codecs.Options.Load.Format = _rawdataLoad.Format;
             _codecs.LoadInformation += new EventHandler<CodecsLoadInformationEventArgs>(codecs_LoadInformation);



            try
            {
               using (WaitCursor wait = new WaitCursor())
               {
                  imageInfo.Image = _codecs.Load(fileName);
                  NewImage(imageInfo);
               }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Invalid File Parameter " + ex.Message);
            }
            finally
            {
               _codecs.LoadInformation -= handler;
               _codecs.Options.Load.Format = RasterImageFormat.Unknown;
            }
         }
      }

      private void SaveRaw(string fileName)
      {
         ViewerForm activeForm = ActiveViewerForm;

         RawDialog dlg = new RawDialog(false);
         _rawdataSave.Width = activeForm.Viewer.Image.Width;
         _rawdataSave.Height = activeForm.Viewer.Image.Height;
         _rawdataSave.BitsPerPixel = activeForm.Viewer.Image.BitsPerPixel;
         dlg.CurrentRawData = _rawdataSave;
         if (dlg.ShowDialog(this) == DialogResult.OK)
         {
            ImageInformation imageInfo = new ImageInformation();
            _rawdataSave = dlg.CurrentRawData;
            try
            {
               using (WaitCursor wait = new WaitCursor())
               {
                  // Set RAW options
                  _codecs.Options.Raw.Save.Pad4 = _rawdataSave.Padding;
                  _codecs.Options.Raw.Save.ReverseBits = _rawdataSave.ReverseBits;
                  _codecs.Options.Save.OptimizedPalette = false;
                  if (_rawdataSave.Format == RasterImageFormat.Unknown)
                     _rawdataSave.Format = RasterImageFormat.Raw;

                  FileStream fs = File.Create(fileName);
                  using (fs)
                  {
                     _codecs.Save(activeForm.Viewer.Image,
                        fs,
                        _rawdataSave.Offset,
                        _rawdataSave.Format,
                        _rawdataSave.BitsPerPixel,
                        1,
                        1,
                        1,
                        CodecsSavePageMode.Overwrite);
                     fs.Close();
                  }
               }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Invalid File Parameter " + ex.Message);
            }
         }
      }

      private void _menuItemFileOpenRaw_Click(object sender, System.EventArgs e)
      {
         try
         {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"All Files (*.*)|*.*|RAW (*.raw)|*.raw|Fax (*.fax)|*.fax|ABIC (*.abic;*.abc)|*.abic;*.abc";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
               LoadRaw(ofd.FileName);
            }
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         finally
         {
            UpdateControls();
         }
      }

      private void _menuItemFileSaveRaw_Click(object sender, System.EventArgs e)
      {
         ImageFileSaver saver = new ImageFileSaver();

         try
         {
            CombineFloater();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = @"RAW (*.raw)|*.raw|Fax (*.fax)|*.fax";
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
               SaveRaw(sfd.FileName);
            }
         }
         catch (Exception ex)
         {
            Messager.ShowFileSaveError(this, saver.FileName, ex);
         }
      }

      private void _menuItemColorWindowLevel_Click(object sender, System.EventArgs e)
      {
         try
         {
            RasterWindowLevelDialog windowLevelDlg = new RasterWindowLevelDialog();
            ViewerForm activeForm = ActiveViewerForm;
            int lookupSize;
            MinMaxBitsCommand minMaxBits = new MinMaxBitsCommand();
            MinMaxValuesCommand minMaxValues = new MinMaxValuesCommand();
            RasterColor[] lookupTable;

            minMaxBits.Run(activeForm.Viewer.Image);
            minMaxValues.Run(activeForm.Viewer.Image);

            lookupSize = (1 << (minMaxBits.MaximumBit - minMaxBits.MinimumBit + 1));
            lookupTable = new RasterColor[lookupSize];


            windowLevelDlg.Image = activeForm.Viewer.Image;
            windowLevelDlg.ShowPreview = true;
            windowLevelDlg.ShowRange = true;
            windowLevelDlg.ShowZoomLevel = true;
            windowLevelDlg.ZoomToFit = false;
            windowLevelDlg.LowBit = minMaxBits.MinimumBit;
            windowLevelDlg.HighBit = minMaxBits.MaximumBit;
            windowLevelDlg.Low = minMaxValues.MinimumValue;
            windowLevelDlg.High = minMaxValues.MaximumValue;
            windowLevelDlg.WindowLevelFlags = RasterPaletteWindowLevelFlags.Inside | RasterPaletteWindowLevelFlags.Linear;
            windowLevelDlg.LookupTable = lookupTable;

            switch (activeForm.Viewer.Image.GrayscaleMode)
            {
               case RasterGrayscaleMode.OrderedNormal:
                  {
                     windowLevelDlg.StartColor = new RasterColor(0, 0, 0);
                     windowLevelDlg.EndColor = new RasterColor(255, 255, 255);

                     break;
                  }

               case RasterGrayscaleMode.OrderedInverse:
                  {
                     windowLevelDlg.StartColor = new RasterColor(255, 255, 255);
                     windowLevelDlg.EndColor = new RasterColor(0, 0, 0);

                     break;
                  }

               case RasterGrayscaleMode.NotOrdered:
                  {
                     windowLevelDlg.StartColor = new RasterColor(0, 0, 0);
                     windowLevelDlg.EndColor = new RasterColor(255, 255, 255);

                     break;
                  }

               default:
                  {
                     MessageBox.Show(Owner,
                                       "Window Level is not supported for this bitmap order",
                                       "Window Level Error",
                                       MessageBoxButtons.OK);

                     _menuItemColorWindowLevel.Enabled = false;

                     return;
                  }
            }

            if (windowLevelDlg.ShowDialog(Owner) == DialogResult.OK)
            {
               RasterPalette.WindowLevelFillLookupTable(lookupTable,
                                                         windowLevelDlg.StartColor,
                                                         windowLevelDlg.EndColor,
                                                         windowLevelDlg.Low,
                                                         windowLevelDlg.High,
                                                         windowLevelDlg.LowBit,
                                                         windowLevelDlg.HighBit,
                                                         minMaxValues.MinimumValue,
                                                         minMaxValues.MaximumValue,
                                                         windowLevelDlg.Factor,
                                                         windowLevelDlg.WindowLevelFlags |
                                                         (windowLevelDlg.Signed ? 0 : RasterPaletteWindowLevelFlags.None));

               activeForm.Viewer.Image.WindowLevel(windowLevelDlg.LowBit,
                                                   windowLevelDlg.HighBit,
                                                   lookupTable,
                                                   RasterWindowLevelMode.PaintAndProcessing);
            }
         }
         catch (Exception ex)
         {
            Messager.ShowError(this, ex);
         }
         finally
         {
            UpdateControls();
         }
      }

      private void _menuItemPreferencesLoadTextFile_Click(object sender, System.EventArgs e)
      {
         _menuItemPreferencesLoadTextFile.Checked = !_menuItemPreferencesLoadTextFile.Checked;
         _codecs.Options.Txt.Load.Enabled = _menuItemPreferencesLoadTextFile.Checked;
      }

       private void btnAcquire_Click(object sender, EventArgs e)
       {
           
       }

       private void btnOpen_Click(object sender, EventArgs e)
       {
           
       }

       private void btnPages_click(object sender, EventArgs e)
       {
           
       }

       private void toolStripScan_Click(object sender, EventArgs e)
       {
           toolStripScan.Enabled = false;
           _inTwainAcquire = true;
           _acquirePageCount = 1;

           try
           {
               if (_twainSession != null)
               {
                   //TwainSourceInformation[] info = _twainSession.QuerySourceInformation();
                   //lblSourceInfo.Text = "";
                   //for (int i = 0; i < info.Length; i++)
                   //{
                   //    lblSourceInfo.Text += info[i].Name + "|";
                   //}

                   DialogResult res = _twainSession.Acquire(TwainUserInterfaceFlags.Modal | TwainUserInterfaceFlags.Show);
                   if (this.ActiveMdiChild != null) // cause the stupid Acquire modal returns cancel ??? despite the selection of the user...
                       //&& res != DialogResult.Cancel)
                   {
                       int pagecount = ActiveViewerForm.Viewer.Image.PageCount;

                       ActiveViewerForm.Viewer.Image.Page = 1;
                       //MessageBox.Show("" + ActiveViewerForm.Viewer.Image.ImageSize + "");

                       // Check the pageCount from the actual Image and then do anything

                       Size currSize = ActiveViewerForm.Viewer.Image.ImageSize;
                       if (currSize.Width == 1 && currSize.Height == 1 && ActiveViewerForm.Viewer.Image.PageCount > 1)
                       {
                           ActiveViewerForm.Viewer.Image.RemovePageAt(1);
                       }
                      
                       ActiveViewerForm.Viewer.Image.Page = ActiveViewerForm.Viewer.Image.PageCount;
                               
                   }
                   this.toolStripSave.Enabled = true;
               }
           }
           catch (Exception ex)
           {
               Messager.ShowError(this, ex);
           }
           finally
           {
               _acquirePageCount = -1;
               toolStripScan.Enabled = true;
               _inTwainAcquire = false;
           }
           
       }

       private void toolStripOpen_Click(object sender, EventArgs e)
       {
           
               try
               {
                   if (this.ActiveMdiChild != null)
                   {

                       int pagecount = ActiveViewerForm.Viewer.Image.PageCount;
                       ImageInformation info = LoadImage();
                       if (info != null)
                       {
                           ActiveViewerForm.Image.AddPages(info.Image, 1, info.Image.PageCount);

                           ActiveViewerForm.Viewer.Image.Page = 1;
                           //MessageBox.Show("" + ActiveViewerForm.Viewer.Image.ImageSize + "");
                           Size currSize = ActiveViewerForm.Viewer.Image.ImageSize;
                           if (currSize.Width == 1 && currSize.Height == 1)
                           {
                               ActiveViewerForm.Viewer.Image.RemovePageAt(1);

                           }
                           //if (pagecount != 1)
                               ActiveViewerForm.Viewer.Image.Page = ++pagecount;

                           
                       }
                   }
                   else
                   {
                       ImageInformation info = LoadImage();
                       if (info != null)
                           NewImage(info);

                       _openedfilename = info.Name;
                   }
                   this.toolStripSave.Enabled = true;
               }
               catch (Exception ex)
               {
                   Messager.ShowError(this, ex);
               }
               finally
               {

                   UpdateControls();
               }
           
      
       }

       private void toolsPages_Click(object sender, EventArgs e)
       {
       try
           {
               ViewerForm activeForm = ActiveViewerForm;

               if (activeForm.Viewer.Image.HasRegion)
                   activeForm.Viewer.Image.MakeRegionEmpty();
               if (activeForm.Viewer.FloaterImage != null)
               {
                   activeForm.Viewer.FloaterImage.Dispose();
                   activeForm.Viewer.FloaterImage = null;
               }

               if (sender == toolStripFirst)
                   activeForm.Image.Page = 1;
               else if (sender == toolStripPrevious)
                   activeForm.Image.Page--;
               else if (sender == toolStripNext)
                   activeForm.Image.Page++;
               else if (sender == toolStripLast)
                   activeForm.Image.Page = activeForm.Image.PageCount;
           }
           catch (Exception ex)
           {
               Messager.ShowError(this, ex);
           }
           finally
           {
               UpdateControls();
           }

            }

       private void AutoOpen(String FileName)
       {
           
           
           try
           {

               
               //_image = _codecs.Load(new FileStream(FileName,FileMode.Open));
               _image = _codecs.Load(FileName);

               ImageInformation info = new ImageInformation(_image, FileName);
               
               if (info != null)
               {
                   NewImage(info);
                   
               }

               
               
               
           }
           catch (Exception ex)
           {
               Messager.ShowError(this, ex);
           }
           finally
           {
               
               this.toolStripSave.Enabled = false;
               
               UpdateControls();
               
           }

       }

       private void toolStripSave_Click(object sender, EventArgs e)
       {
           try
           {   CombineFloater();
               if (_filename.Equals(""))
                   _saver.Save(this, _codecs, ActiveViewerForm.Viewer.Image,_openedfilename);
               else
               _saver.Save(this, _codecs, ActiveViewerForm.Viewer.Image, _filename);


               ActiveViewerForm.Image_Saved();
               
               


           }
           catch (Exception ex)
           {
               Messager.ShowFileSaveError(this, _saver.FileName, ex);
           }

           finally
           {
               UpdateControls();
           }

       }

       private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
       {
           if (this.ActiveMdiChild != null)
           {
               DialogResult dialogr;

               if (!ActiveViewerForm._saved)
               {
                   if (ActiveViewerForm.Viewer.Image.Width == 1 && ActiveViewerForm.Viewer.Image.Height == 1)
                   {
                       dialogr = MessageBox.Show("Δεν έχετε εισάγει σελίδα στο αρχείο. \n Είστε σίγουροι ότι θέλετε να το κλείσετε; ", "Επιβεβαίωση", MessageBoxButtons.YesNo);
                       if (dialogr == DialogResult.Yes) e.Cancel = false;
                       if (dialogr == DialogResult.No) e.Cancel = true;
                       return;
                   }

                   dialogr = MessageBox.Show("Θέλετε να σώσετε το αρχείο;", "Επιβεβαίωση", MessageBoxButtons.YesNoCancel);
                   if (dialogr == DialogResult.Cancel)
                       e.Cancel = true;

                   else if (dialogr == DialogResult.Yes)
                   {
                       this.toolStripSave_Click(this, null);
                       e.Cancel = false;
                   }
                   else
                       e.Cancel = false;

               }
           }


       }

       

       private void toolStripDiscard_Click(object sender, EventArgs e)
       {
           
           
       }
       //Requires document imaging pro
       //private void deskewToolStripMenuItem_Click(object sender, EventArgs e)
       //{
       //    IRasterCommand command = null;
       //    ViewerForm activeForm = ActiveViewerForm;

       //    DeskewDialog dlg = new DeskewDialog();
       //    if (dlg.ShowDialog(this) == DialogResult.OK)
       //        command = new DeskewCommand(dlg.FillColor, dlg.Flags);
       //    if (command != null)
       //        RunCommand(command);

       //}

       //Requires document imaging pro
       //private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
       //{
       //    try
       //    {
       //        ImageToRun.RotateViewPerspective(180);
       //    }
       //    catch (Exception ex)
       //    {
       //        Messager.ShowError(this, ex);
       //    }
       //}


       private void ZoomFunctions_Click(object sender, System.EventArgs e)
       {
           // get the current center in logical units
         RasterImageViewer viewer = ActiveViewerForm.Viewer; // get the active viewer
         Rectangle rc = Rectangle.Intersect(viewer.PhysicalViewRectangle, viewer.ClientRectangle); // get what you see in physical coordinates
         PointF center = new PointF(rc.Left + rc.Width / 2, rc.Top + rc.Height / 2); // get the center of what you see in physical coordinates
         Transformer t = new Transformer(viewer.Transform);
         center = t.PointToLogical(center);  // get the center of what you see in logical coordinates

         // zoom     
         double scaleFactor = viewer.ScaleFactor;

         const float ratio = 1.2F;

         if (sender == toolStripZoomIn)
         {
            scaleFactor *= ratio;
         }
         else if (sender == toolStripZoomOut)
         {
            scaleFactor /= ratio;
         }
         //else if (sender == _menuItemViewZoomNormal)
         //{
         //   scaleFactor = 1;
         //   if (viewer.SizeMode != RasterViewerSizeMode.Normal)
         //      viewer.SizeMode = RasterViewerSizeMode.Normal;
         //   viewer.Offset = SizeF.Empty;
         //}
         //else
         //{
         //   ZoomDialog dlg = new ZoomDialog();
         //   dlg.Value = (int)(scaleFactor * 100);
         //   dlg.MinimumValue = (int)(_minimumScaleFactor * 100F);
         //   dlg.MaximumValue = (int)(_maximumScaleFactor * 100F);

         //   if (dlg.ShowDialog(this) == DialogResult.OK)
         //      scaleFactor = (float)dlg.Value / 100f;
         //}

         scaleFactor = Math.Max(_minimumScaleFactor, Math.Min(_maximumScaleFactor, scaleFactor));

         if (viewer.ScaleFactor != scaleFactor)
         {//
            viewer.ScaleFactor = scaleFactor;

            // bring the original center into the view center
            t = new Transformer(viewer.Transform);
            center = t.PointToPhysical(center); // get the center of what you saw before the zoom in physical coordinates
            viewer.CenterAtPoint(Point.Round(center)); // bring the old center into the center of the view
         }
      }

       private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
       {

       }

       

       private void _menuItemViewCenter_Click_1(object sender, EventArgs e)
       {

       }

       

       private void ContentsToolsStrip_Click(object sender, EventArgs e)
       {
           
           //Help.ShowHelp(this, "file://C:\\dotNET Projects\\TifScanTool\\Chm\\UniScan.chm");
           Help.ShowHelp(this, "Help Files\\UniScan.chm");
       
       }

       private void toolStripHelp_ButtonClick(object sender, EventArgs e)
       {

       }

       private void AboutToolStrip_Click(object sender, EventArgs e)
       {
           new AboutDialog("Main").ShowDialog(this);
       }

       private void toolStripDiscard_ButtonClick(object sender, EventArgs e)
       {

       }

       private void deleteAllToolStrip_Click(object sender, EventArgs e)
       {
           int pagecount = ActiveViewerForm.Viewer.Image.PageCount;
           try
           {
               if (MessageBox.Show("Απαλοιφή Όλων;", "Επιβεβαίωση", MessageBoxButtons.YesNo) == DialogResult.Yes)
               {

                   ViewerForm activeForm = ActiveViewerForm;

                   if (activeForm.Image.PageCount > 1)
                       activeForm.Image.RemoveAllPages();
                   
                       RasterColor[] colors;
                       colors = new RasterColor[1];
                       colors[0] = new RasterColor(255, 255, 255);


                       RasterImage blank = new RasterImage(RasterMemoryFlags.NoDisk, 1, 1, 1, RasterByteOrder.Gray, RasterViewPerspective.TopLeft, colors, IntPtr.Zero, 0);
                       activeForm.Image.AddPage(blank);
                       activeForm.Image.RemovePageAt(1);
               }
               
           }
           catch (Exception ex)
           {
               Messager.ShowError(this, ex);
           }
           finally
           {
               UpdateControls();
               this.toolStripSave.Enabled = false;
           }

       }

       private void deletePageToolStrip_Click(object sender, EventArgs e)
       {
           try
           {
               ViewerForm activeForm = ActiveViewerForm;
               if (MessageBox.Show("Να διαγραφεί η τρέχουσα σελίδα;", "Επιβεβαίωση", MessageBoxButtons.YesNo) == DialogResult.Yes)
               {
                   if (activeForm.Image.PageCount == 1){
                       
                   
                       RasterColor[] colors;
                       colors = new RasterColor[1];
                       colors[0] = new RasterColor(255, 255, 255);


                       RasterImage blank = new RasterImage(RasterMemoryFlags.NoDisk, 1, 1, 1, RasterByteOrder.Gray, RasterViewPerspective.TopLeft, colors, IntPtr.Zero, 0);
                       activeForm.Image.AddPage(blank);
                       activeForm.Image.RemovePageAt(1);
                   }
                   else activeForm.Image.RemovePageAt(activeForm.Image.Page);
               }

                   
               
           }
           catch (Exception ex)
           {
               Messager.ShowError(this, ex);
           }
       finally
       {
           UpdateControls();
           this.toolStripSave.Enabled = false;
       }
       }

       private void toolStripButton1_Click(object sender, EventArgs e)
       {
           if (_twainSession != null)
           {
               _twainSession.SelectSource(null);
           }
       }

       private void MainForm_Load(object sender, EventArgs e)
       {

       }

       

      

       
       

       

   }
}