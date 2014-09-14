using System;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.Collections.Generic;

using Leadtools;
using Leadtools.Codecs;
using Leadtools.WinForms.CommonDialogs.File;

#if !LEADTOOLS_V17_OR_LATER
using LeadPoint = System.Drawing.Point;
using LeadSize = System.Drawing.Size;
using LeadRect = System.Drawing.Rectangle;
#endif // #if !LEADTOOLS_V17_OR_LATER

namespace Leadtools.Demos
{
   public class ImageFileLoader
   {
      private static int _filterIndex = 1;
      private string _fileName;
      private RasterOpenDialogLoadFormat[] _filters;
      private RasterImage _image;
      private bool _loadOnlyOnePage = false;
      private int _firstPage;
      private int _lastPage;
      private bool _showLoadPagesDialog = false;
      private bool _showPdfOptions = true;
      private bool _showXpsOptions = true;
#if LEADTOOLS_V16_OR_LATER
      private bool _showXlsOptions = true;
      private bool _showRasterizeDocumentOptions = true;
#endif // #if LEADTOOLS_V16_OR_LATER

      private bool _multiSelect = false;
      private bool _useGdiPlus = false;
      private string _openDialogInitialPath;

      private List<ImageInformation> _images = new List<ImageInformation>();

      public ImageFileLoader()
      {
      }

      public string FileName
      {
         get
         {
            return _fileName;
         }
         set
         {
            _fileName = value;
         }
      }

      public RasterImage Image
      {
         get
         {
            return _image;
         }
      }

      public List<ImageInformation> Images
      {
         get
         {
            return _images;
         }
      }

      public RasterOpenDialogLoadFormat[] Filters
      {
         get
         {
            return _filters;
         }
         set
         {
            _filters = value;
         }
      }

      public bool ShowLoadPagesDialog
      {
         get
         {
            return _showLoadPagesDialog;
         }
         set
         {
            _showLoadPagesDialog = value;
         }
      }

      public bool LoadOnlyOnePage
      {
         get
         {
            return _loadOnlyOnePage;
         }
         set
         {
            _loadOnlyOnePage = value;
         }
      }

      public static int FilterIndex
      {
         get
         {
            return _filterIndex;
         }
         set
         {
            _filterIndex = value;
         }
      }

      public int FirstPage
      {
         get
         {
            return _firstPage;
         }
      }

      public int LastPage
      {
         get
         {
            return _lastPage;
         }
      }

      public bool ShowPdfOptions
      {
         get
         {
            return _showPdfOptions;
         }
         set
         {
            _showPdfOptions = value;
         }
      }

      public bool ShowXpsOptions
      {
         get
         {
            return _showXpsOptions;
         }
         set
         {
            _showXpsOptions = value;
         }
      }

#if LEADTOOLS_V16_OR_LATER
      public bool ShowXlsOptions
      {
         get
         {
            return _showXlsOptions;
         }
         set
         {
            _showXlsOptions = value;
         }
      }

      public bool ShowRasterizeDocumentOptions
      {
         get
         {
            return _showRasterizeDocumentOptions;
         }
         set
         {
            _showRasterizeDocumentOptions = value;
         }
      }
#endif // #if LEADTOOLS_V16_OR_LATER

      public bool MultiSelect
      {
         get
         {
            return _multiSelect;
         }
         set
         {
            _multiSelect = value;
         }
      }

      public bool UseGdiPlus
      {
         get { return _useGdiPlus; }
         set { _useGdiPlus = value; }
      }

      public string OpenDialogInitialPath
      {
         get
         {
            return _openDialogInitialPath;
         }
         set
         {
            _openDialogInitialPath = value;
         }
      }

      //Use this load to load a specific image without showing the open dialog
      public bool Load(IWin32Window owner, string fileName, RasterCodecs codecs, int firstPage, int lastPage)
      {
         _fileName = fileName;
         _firstPage = firstPage;
         _lastPage = lastPage;

         using (WaitCursor wait = new WaitCursor())
         {
            using(CodecsImageInfo info = codecs.GetInformation(FileName, true))
            {
               if(info.Format == RasterImageFormat.RasPdf || info.Format == RasterImageFormat.Postscript)
               {
                  if(!codecs.Options.Pdf.IsEngineInstalled)
                  {
                     using(PdfEngineDialog dlg = new PdfEngineDialog())
                     {
                        if(dlg.ShowDialog(owner) != DialogResult.OK)
                           return false;
                     }
                  }
               }
            }

            _image = codecs.Load(FileName, 0, CodecsLoadByteOrder.BgrOrGray, _firstPage, _lastPage);
         }

         return true;
      }

      //Use this load to load an image using the open dialog
      public int Load(IWin32Window owner, RasterCodecs codecs, bool autoLoad)
      {
#if LEADTOOLS_V16_OR_LATER
         // Load using the RasterizeDocument options
         codecs.Options.RasterizeDocument.Load.Enabled = true;
#endif // #if LEADTOOLS_V16_OR_LATER

         using(RasterOpenDialog ofd = new RasterOpenDialog(codecs))
         {
            ofd.DereferenceLinks = true;
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            ofd.EnableSizing = true;
            ofd.Filter = Filters;
            ofd.FilterIndex = _filterIndex;
            ofd.LoadFileImage = false;
            ofd.LoadOptions = false;
            ofd.LoadRotated = true;
            ofd.LoadCompressed = true;
            ofd.Multiselect = _multiSelect;
            ofd.ShowGeneralOptions = true;
            ofd.ShowLoadCompressed = true;
            ofd.ShowLoadOptions = true;
            ofd.ShowLoadRotated = true;
            ofd.ShowMultipage = true;
            ofd.UseGdiPlus = UseGdiPlus;
            ofd.ShowPdfOptions = ShowPdfOptions;
            ofd.ShowXpsOptions = ShowXpsOptions;
#if LEADTOOLS_V16_OR_LATER
            ofd.ShowXlsOptions = ShowXlsOptions;
            ofd.ShowRasterizeDocumentOptions = ShowRasterizeDocumentOptions;
            ofd.EnableFileInfoModeless = true;
            ofd.EnableFileInfoResizing = true;
#endif // #if LEADTOOLS_V16_OR_LATER

            ofd.ShowPreview = true;
            ofd.ShowProgressive = true;
            ofd.ShowRasterOptions = true;
            ofd.ShowTotalPages = true;
            ofd.ShowDeletePage = true;
            ofd.ShowFileInformation = true;
            ofd.UseFileStamptoPreview = true;
            ofd.PreviewWindowVisible = true;
            ofd.Title = "LEADTOOLS Open Dialog";
            ofd.FileName = FileName;
            if (!String.IsNullOrEmpty(_openDialogInitialPath))
               ofd.InitialDirectory = _openDialogInitialPath;

            if(ofd.ShowDialog(owner) == DialogResult.OK)
            {
               foreach(RasterDialogFileData item in ofd.OpenedFileData)
               {
                  FileName = item.Name;

                  _filterIndex = ofd.FilterIndex;

#if LEADTOOLS_V16_OR_LATER
                  // Set the RasterizeDocument load options before calling GetInformation
                  codecs.Options.RasterizeDocument.Load.Enabled = item.Options.RasterizeDocumentOptions.Enabled;
                  codecs.Options.RasterizeDocument.Load.PageWidth = item.Options.RasterizeDocumentOptions.PageWidth;
                  codecs.Options.RasterizeDocument.Load.PageHeight = item.Options.RasterizeDocumentOptions.PageHeight;
                  codecs.Options.RasterizeDocument.Load.LeftMargin = item.Options.RasterizeDocumentOptions.LeftMargin;
                  codecs.Options.RasterizeDocument.Load.TopMargin = item.Options.RasterizeDocumentOptions.TopMargin;
                  codecs.Options.RasterizeDocument.Load.RightMargin = item.Options.RasterizeDocumentOptions.RightMargin;
                  codecs.Options.RasterizeDocument.Load.BottomMargin = item.Options.RasterizeDocumentOptions.BottomMargin;
                  codecs.Options.RasterizeDocument.Load.Unit = item.Options.RasterizeDocumentOptions.Unit;
                  codecs.Options.RasterizeDocument.Load.XResolution = item.Options.RasterizeDocumentOptions.XResolution;
                  codecs.Options.RasterizeDocument.Load.YResolution = item.Options.RasterizeDocumentOptions.YResolution;
                  codecs.Options.RasterizeDocument.Load.SizeMode = item.Options.RasterizeDocumentOptions.SizeMode;
#endif // #if LEADTOOLS_V16_OR_LATER

                  int infoTotalPages;

                  using(WaitCursor wait = new WaitCursor())
                  {
                     using(CodecsImageInfo info = codecs.GetInformation(FileName, true))
                     {
                        infoTotalPages = info.TotalPages;

                        if(info.Format == RasterImageFormat.RasPdf || info.Format == RasterImageFormat.Postscript)
                        {
                           if(!codecs.Options.Pdf.IsEngineInstalled)
                           {
                              using(PdfEngineDialog dlg = new PdfEngineDialog())
                              {
                                 if(dlg.ShowDialog(owner) != DialogResult.OK)
                                    continue;
                              }
                           }
                        }
                     }
                  }

                  // Set the user Options
                  codecs.Options.Load.Passes = item.Passes;
                  codecs.Options.Load.Rotated = item.LoadRotated;
                  codecs.Options.Load.Compressed = item.LoadCompressed;

                  switch(item.Options.FileType)
                  {
                     case RasterDialogFileOptionsType.Meta:
                        {
                           // Set the user options
                           codecs.Options.Wmf.Load.XResolution = item.Options.MetaOptions.XResolution;
                           codecs.Options.Wmf.Load.YResolution = item.Options.MetaOptions.XResolution;
                           break;
                        }

                     case RasterDialogFileOptionsType.Pdf:
                        {
                           if(codecs.Options.Pdf.IsEngineInstalled)
                           {
                              // Set the user options
                              codecs.Options.Pdf.Load.DisplayDepth = item.Options.PdfOptions.DisplayDepth;
                              codecs.Options.Pdf.Load.GraphicsAlpha = item.Options.PdfOptions.GraphicsAlpha;
                              codecs.Options.Pdf.Load.TextAlpha = item.Options.PdfOptions.TextAlpha;
                              codecs.Options.Pdf.Load.UseLibFonts = item.Options.PdfOptions.UseLibFonts;
                              codecs.Options.Pdf.Load.XResolution = item.Options.PdfOptions.XResolution;
                              codecs.Options.Pdf.Load.YResolution = item.Options.PdfOptions.YResolution;
                           }

                           break;
                        }

                     case RasterDialogFileOptionsType.Misc:
                        {
                           switch(item.FileInfo.Format)
                           {
                              case RasterImageFormat.Jbig:
                                 {
                                    // Set the user options
                                    codecs.Options.Jbig.Load.Resolution = new LeadSize(item.Options.MiscOptions.XResolution,
                                                                                    item.Options.MiscOptions.YResolution);
                                    break;
                                 }

                              case RasterImageFormat.Cmw:
                                 {
                                    // Set the user options
                                    codecs.Options.Jpeg2000.Load.CmwResolution = new LeadSize(item.Options.MiscOptions.XResolution,
                                                                                          item.Options.MiscOptions.YResolution);
                                    break;
                                 }

                              case RasterImageFormat.Jp2:
                                 {
                                    // Set the user options
                                    codecs.Options.Jpeg2000.Load.Jp2Resolution = new LeadSize(item.Options.MiscOptions.XResolution,
                                                                                          item.Options.MiscOptions.YResolution);
                                    break;
                                 }

                              case RasterImageFormat.J2k:
                                 {
                                    // Set the user options
                                    codecs.Options.Jpeg2000.Load.J2kResolution = new LeadSize(item.Options.MiscOptions.XResolution,
                                                                                          item.Options.MiscOptions.YResolution);
                                    break;
                                 }
                           }

                           break;
                        }
                     case RasterDialogFileOptionsType.Xps:
                        {
                           // Set the user options
                           codecs.Options.Xps.Load.Resolution = new LeadSize(item.Options.XpsOptions.XResolution,
                                                                          item.Options.XpsOptions.XResolution);
                        }
                        break;
#if LEADTOOLS_V16_OR_LATER
                     case RasterDialogFileOptionsType.Xls:
                        {
                           // Set the user options
                           codecs.Options.Xls.Load.MultiPageSheet = item.Options.XlsOptions.MultiPageSheet;
                        }
                        break;
#endif // #if LEADTOOLS_V16_OR_LATER
                  }

                  int firstPage = 1;
                  int lastPage = 1;

                  if(_showLoadPagesDialog)
                  {
                     firstPage = 1;
                     lastPage = infoTotalPages;

                     if(firstPage != lastPage)
                     {
                        using(ImageFileLoaderPagesDialog dlg = new ImageFileLoaderPagesDialog(infoTotalPages, LoadOnlyOnePage))
                        {
                           if(dlg.ShowDialog(owner) == DialogResult.OK)
                           {
                              if(dlg.AllPages)
                                 lastPage = -1;
                              else
                              {
                                 firstPage = dlg.FirstPage;
                                 lastPage = dlg.LastPage;
                              }
                           }
                           else
                              continue;
                        }
                     }
                  }
                  else
                  {
                     firstPage = item.PageNumber;
                     lastPage = item.PageNumber;
                  }

                  _firstPage = firstPage;
                  _lastPage = lastPage;

                  if(autoLoad)
                  {
                     using(WaitCursor wait = new WaitCursor())
                     {
                        _image = codecs.Load(FileName, 0, CodecsLoadByteOrder.BgrOrGray, firstPage, lastPage);
                     }
                  }

                  _images.Add(new ImageInformation(_image, item.Name));
               }
            }

            return ofd.OpenedFileData.Count;
         }
      }
   }
}
