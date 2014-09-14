using System;
using System.Windows.Forms;
using System.Text;
using System.Drawing;

using Leadtools;
using Leadtools.Codecs;
using Leadtools.WinForms.CommonDialogs.File;

namespace Leadtools.Demos
{
   public class ImageFileLoader
   {
      private static int _filterIndex = 0;
      private string _fileName;
       private RasterOpenDialogLoadFormat[] _filters;
      private RasterImage _image;
      private bool _loadOnlyOnePage = false;
      private int _firstPage;
      private int _lastPage;
      private bool _showLoadPagesDialog = false;
      private bool _showPdfOptions = true;

      public ImageFileLoader()
      {
      }

      public string FileName
      {
         get { return _fileName; }
         set { _fileName = value; }
      }

      public RasterImage Image
      {
         get { return _image; }
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
         get { return _showLoadPagesDialog; }
         set { _showLoadPagesDialog = value; }
      }

      public bool LoadOnlyOnePage
      {
         get { return _loadOnlyOnePage; }
         set { _loadOnlyOnePage = value; }
      }

      public static int FilterIndex
      {
         get { return _filterIndex; }
         set { _filterIndex = value; }
      }

      public int FirstPage
      {
         get { return _firstPage; }
      }

      public int LastPage
      {
         get { return _lastPage; }
      }

      public bool ShowPdfOptions
      {
         get { return _showPdfOptions; }
         set { _showPdfOptions = value; }
      }

      public bool Load(IWin32Window owner, RasterCodecs codecs, bool autoLoad)
      {
         RasterOpenDialog ofd = new RasterOpenDialog(codecs);
         
         
         ofd.DereferenceLinks = true;
         ofd.CheckFileExists = false;
         ofd.CheckPathExists = true;
         ofd.EnableSizing = true;
         //ofd.Filter = Filters;
         ofd.Filter = new RasterOpenDialogLoadFormat[]
   {
      new RasterOpenDialogLoadFormat ( "All Files", "*.*" ),
      //new RasterOpenDialogLoadFormat ( "Tiff", "*.tiff" ),
       new RasterOpenDialogLoadFormat ( "Tiff", "*.tif*" )
   };
         ofd.FilterIndex = _filterIndex;
         ofd.LoadFileImage = false;
         ofd.LoadOptions = false;
         ofd.LoadRotated = true;
         ofd.LoadCompressed = true;
         ofd.Multiselect = false;
         ofd.ShowGeneralOptions = true;
         ofd.ShowLoadCompressed = true;
         //ofd.ShowLoadOptions = true;
         ofd.ShowLoadOptions = false;
         ofd.ShowLoadRotated = true;
         ofd.ShowMultipage = false;
         //ofd.ShowMultipage = true;
         ofd.ShowPdfOptions = ShowPdfOptions;
         ofd.ShowPreview = true;
         ofd.ShowProgressive = true;
         ofd.ShowRasterOptions = true;
         ofd.ShowTotalPages = true;
         //ofd.ShowDeletePage = true;
         ofd.ShowDeletePage = false;
         ofd.ShowFileInformation = true;
         ofd.UseFileStamptoPreview = true;
         ofd.PreviewWindowVisible = true;
         ofd.GenerateThumbnail = true; //added
         ofd.Title = "’νοιγμα αρχείου";
         ofd.FileName = FileName;
         //ofd.Filter = _filters;

         bool ok = false;

         if (ofd.ShowDialog(owner) == DialogResult.OK)
         {
             RasterDialogFileData firstItem = ofd.OpenedFileData[0] as RasterDialogFileData;

            FileName = firstItem.Name;

            ok = true;

            _filterIndex = ofd.FilterIndex;

            CodecsImageInfo info;

            using (WaitCursor wait = new WaitCursor())
               info = codecs.GetInformation(FileName, true);

            if (info.Format == RasterImageFormat.RasPdf ||
               info.Format == RasterImageFormat.RasPdfG31Dim ||
               info.Format == RasterImageFormat.RasPdfG32Dim ||
               info.Format == RasterImageFormat.RasPdfG4 ||
               info.Format == RasterImageFormat.RasPdfJpeg ||
               info.Format == RasterImageFormat.RasPdfJpeg422 ||
               info.Format == RasterImageFormat.RasPdfJpeg411)
            {
               if (!codecs.Options.Pdf.IsEngineInstalled)
               {
                  PdfEngineDialog dlg = new PdfEngineDialog();
                  if (dlg.ShowDialog(owner) != DialogResult.OK)
                     return false;
               }
            }

            // Set the user Options
            codecs.Options.Load.Passes = firstItem.Passes;
            codecs.Options.Load.Rotated = firstItem.LoadRotated;
            codecs.Options.Load.Compressed = firstItem.LoadCompressed;

            switch (firstItem.Options.FileType)
            {
                case RasterDialogFileOptionsType.Meta:
                  {
                     // Set the user options
                     codecs.Options.Wmf.Load.XResolution = firstItem.Options.MetaOptions.XResolution;
                     codecs.Options.Wmf.Load.YResolution = firstItem.Options.MetaOptions.XResolution;

                     break;
                  }

              case RasterDialogFileOptionsType.Pdf:
                  {
                     if (codecs.Options.Pdf.IsEngineInstalled)
                     {
                        // Set the user options
                        codecs.Options.Pdf.Load.DisplayDepth = firstItem.Options.PdfOptions.DisplayDepth;
                        codecs.Options.Pdf.Load.GraphicsAlpha = firstItem.Options.PdfOptions.GraphicsAlpha;
                        codecs.Options.Pdf.Load.TextAlpha = firstItem.Options.PdfOptions.TextAlpha;
                        codecs.Options.Pdf.Load.UseLibFonts = firstItem.Options.PdfOptions.UseLibFonts;
                        codecs.Options.Pdf.Load.XResolution = firstItem.Options.PdfOptions.XResolution;
                        codecs.Options.Pdf.Load.YResolution = firstItem.Options.PdfOptions.YResolution;
                     }

                     break;
                  }

              case RasterDialogFileOptionsType.Misc:
                  {
                     switch (firstItem.FileInfo.Format)
                     {
                        case RasterImageFormat.Jbig:
                           {
                              // Set the user options
                              codecs.Options.Jbig.Load.Resolution = new Size(firstItem.Options.MiscOptions.XResolution,
                                                                              firstItem.Options.MiscOptions.YResolution);
                              break;
                           }

                        case RasterImageFormat.Cmw:
                           {
                              // Set the user options
                              codecs.Options.Jpeg2000.Load.CmwResolution = new Size(firstItem.Options.MiscOptions.XResolution,
                                                                                    firstItem.Options.MiscOptions.YResolution);
                              break;
                           }

                        case RasterImageFormat.Jp2:
                           {
                              // Set the user options
                              codecs.Options.Jpeg2000.Load.Jp2Resolution = new Size(firstItem.Options.MiscOptions.XResolution,
                                                                                    firstItem.Options.MiscOptions.YResolution);
                              break;
                           }

                        case RasterImageFormat.J2k:
                           {
                              // Set the user options
                              codecs.Options.Jpeg2000.Load.J2kResolution = new Size(firstItem.Options.MiscOptions.XResolution,
                                                                                    firstItem.Options.MiscOptions.YResolution);
                              break;
                           }
                     }

                     break;
                  }
            }

            int firstPage = 1;
            int lastPage = 1;

            if (ShowLoadPagesDialog)
            {
               firstPage = 1;
               lastPage = info.TotalPages;

               if (firstPage != lastPage)
               {
                  ImageFileLoaderPagesDialog dlg = new ImageFileLoaderPagesDialog(info.TotalPages, LoadOnlyOnePage);
                  if (dlg.ShowDialog(owner) == DialogResult.OK)
                  {
                     if (dlg.AllPages)
                        lastPage = -1;
                     else
                     {
                        firstPage = dlg.FirstPage;
                        lastPage = dlg.LastPage;
                     }
                  }
                  else
                     ok = false;
               }
            }
            else
            {
               firstPage = firstItem.PageNumber;
               lastPage = firstItem.PageNumber;
            }

            _firstPage = firstPage;
            _lastPage = lastPage;

            if (autoLoad && ok)
               using (WaitCursor wait = new WaitCursor())
               {
                  _image = codecs.Load(FileName, 0, CodecsLoadByteOrder.BgrOrGray, firstPage, lastPage);
               }
         }

         return ok;
      }
   }
}
