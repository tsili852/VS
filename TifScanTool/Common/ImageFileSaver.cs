using System;
using System.Windows.Forms;

using Leadtools;
using Leadtools.Codecs;
using Leadtools.WinForms.CommonDialogs.File;
using System.IO;

namespace Leadtools.Demos
{
   public class ImageFileSaver
   {
      private string _fileName;
      private RasterImageFormat _format;
       private RasterDialogFileTypesIndex _fileTypeIndex;
      private int _fileSubTypeIndex;
      private int _bitsPerPixel;
      private int _firstPage;
      private int _lastPage;
      private int _savePageNumber;
      private CodecsSavePageMode _pageMode;
       private RasterSaveDialogFileFormatsList _saveFormats;
      private bool _autoSave;

      public ImageFileSaver()
      {
         _fileName = String.Empty;
         _bitsPerPixel = 24;
         _firstPage = 0;
         _lastPage = 0;
         _savePageNumber = 1;
         _pageMode = CodecsSavePageMode.Overwrite;
         _saveFormats = null;
         _fileTypeIndex = RasterDialogFileTypesIndex.Lead;
         _fileSubTypeIndex = (int)RasterDialogCmpSubTypesIndex.Progressive;
         _autoSave = true;
      }

      public string FileName
      {
         get { return _fileName; }
         set { _fileName = value; }
      }

       public RasterSaveDialogFileFormatsList SaveFormats
      {
         get { return _saveFormats; }
         set { _saveFormats = value; }
      }

       public RasterDialogFileTypesIndex FormatIndex
      {
         get { return _fileTypeIndex; }
         set { _fileTypeIndex = value; }
      }

      public int SubTypeIndex
      {
         get { return _fileSubTypeIndex; }
         set { _fileSubTypeIndex = value; }
      }

      public RasterImageFormat Format
      {
         get { return _format; }
      }

      public int BitsPerPixel
      {
         get { return _bitsPerPixel; }
      }

      public int FirstPage
      {
         get { return _firstPage; }
      }

      public int LastPage
      {
         get { return _lastPage; }
      }

      public int SavePageNumber
      {
         get { return _savePageNumber; }
      }

      public CodecsSavePageMode PageMode
      {
         get { return _pageMode; }
      }

      public bool AutoSave
      {
         get { return _autoSave; }
         set { _autoSave = value; }
      }

      public bool Save(IWin32Window owner, RasterCodecs codecs, RasterImage image)
      {

          _format = RasterImageFormat.Unknown;
          _firstPage = -1;
          _lastPage = -1;
          _savePageNumber = -1;
          _pageMode = CodecsSavePageMode.Overwrite;

          RasterSaveDialog dlg = new RasterSaveDialog(codecs);

          dlg.PromptOverwrite = true;
          dlg.ShowFileOptionsBasicJ2kOptions = true;
          dlg.ShowFileOptionsJ2kOptions = true;
          dlg.ShowFileOptionsMultipage = true;
          dlg.ShowFileOptionsProgressive = true;
          dlg.ShowFileOptionsQualityFactor = true;
          dlg.ShowFileOptionsStamp = true;
          dlg.ShowOptions = true;
          dlg.ShowQualityFactor = true;
          dlg.PageNumber = SavePageNumber;
          dlg.Title = "LEADTOOLS Save Dialog";
          dlg.EnableSizing = true;
          dlg.FileName = FileName;
          dlg.FileSubTypeIndex = _fileSubTypeIndex;
          dlg.FileTypeIndex = _fileTypeIndex;
          dlg.BitsPerPixel = _bitsPerPixel;

          if (null == SaveFormats)
          {
              dlg.FileFormatsList = new RasterSaveDialogFileFormatsList(RasterDialogFileFormatDataContent.Default);
          }
          else
          {
              dlg.FileFormatsList = SaveFormats;
          }

          if (dlg.ShowDialog(owner) == DialogResult.OK)
          {
              FileName = dlg.FileName;
              _fileSubTypeIndex = dlg.FileSubTypeIndex;
              _fileTypeIndex = dlg.FileTypeIndex;
              _format = dlg.Format;
              _bitsPerPixel = dlg.BitsPerPixel;
              _firstPage = dlg.PageNumber;
              _lastPage = dlg.PageNumber;
              _savePageNumber = dlg.PageNumber;
              _pageMode = dlg.MultiPage;


              if (_autoSave)
              {
                  switch (dlg.Format)
                  {
                      case RasterImageFormat.Abc:
                          {
                              codecs.Options.Abc.Save.QualityFactor = dlg.AbcQualityFactor;

                              break;
                          }

                      case RasterImageFormat.Ecw:
                          {
                              codecs.Options.Ecw.Save.QualityFactor = dlg.QualityFactor;

                              break;
                          }

                      case RasterImageFormat.Png:
                          {
                              codecs.Options.Png.Save.QualityFactor = dlg.QualityFactor;

                              break;
                          }

                      case RasterImageFormat.Cmp:
                          {
                              codecs.Options.Jpeg.Save.QualityFactor = dlg.QualityFactor;
                              codecs.Options.Jpeg.Save.CmpQualityFactorPredefined = dlg.CmpQualityFactor;

                              break;
                          }

                      default:
                          {
                              codecs.Options.Jpeg.Save.QualityFactor = dlg.QualityFactor;

                              break;
                          }
                  }

                  codecs.Options.Jpeg.Save.SaveWithStamp = dlg.WithStamp;
                  codecs.Options.Jpeg.Save.StampWidth = dlg.StampWidth;
                  codecs.Options.Jpeg.Save.StampHeight = dlg.StampHeight;
                  codecs.Options.Jpeg.Save.StampBitsPerPixel = dlg.StampBitsPerPixel;

                  if ((Format == RasterImageFormat.Cmw) ||
                     (Format == RasterImageFormat.J2k) ||
                     (Format == RasterImageFormat.Jp2) ||
                     (Format == RasterImageFormat.TifJ2k))
                  {
                      codecs.Options.Jpeg2000.Save.CodeBlockHeight = dlg.FileJ2kOptions.CodeBlockHeight;
                      codecs.Options.Jpeg2000.Save.CodeBlockWidth = dlg.FileJ2kOptions.CodeBlockWidth;
                      codecs.Options.Jpeg2000.Save.CompressionControl = dlg.FileJ2kOptions.CompressionControl;
                      codecs.Options.Jpeg2000.Save.CompressionRatio = dlg.FileJ2kOptions.CompressionRatio;
                      codecs.Options.Jpeg2000.Save.DecompositionLevels = dlg.FileJ2kOptions.DecompositionLevels;
                      codecs.Options.Jpeg2000.Save.DerivedBaseExponent = dlg.FileJ2kOptions.DerivedBaseExponent;
                      codecs.Options.Jpeg2000.Save.DerivedBaseMantissa = dlg.FileJ2kOptions.DerivedBaseMantissa;
                      codecs.Options.Jpeg2000.Save.DerivedQuantization = dlg.FileJ2kOptions.DerivedQuantization;
                      codecs.Options.Jpeg2000.Save.ErrorResilienceSymbol = dlg.FileJ2kOptions.ErrorResilienceSymbol;
                      codecs.Options.Jpeg2000.Save.GuardBits = dlg.FileJ2kOptions.GuardBits;
                      codecs.Options.Jpeg2000.Save.ImageAreaHorizontalOffset = dlg.FileJ2kOptions.ImageAreaHorizontalOffset;
                      codecs.Options.Jpeg2000.Save.ImageAreaVerticalOffset = dlg.FileJ2kOptions.ImageAreaVerticalOffset;
                      codecs.Options.Jpeg2000.Save.PredictableTermination = dlg.FileJ2kOptions.PredictableTermination;
                      codecs.Options.Jpeg2000.Save.ProgressingOrder = dlg.FileJ2kOptions.ProgressingOrder;
                      codecs.Options.Jpeg2000.Save.ReferenceTileHeight = dlg.FileJ2kOptions.ReferenceTileHeight;
                      codecs.Options.Jpeg2000.Save.ReferenceTileWidth = dlg.FileJ2kOptions.ReferenceTileWidth;
                      codecs.Options.Jpeg2000.Save.RegionOfInterest = dlg.FileJ2kOptions.RegionOfInterest;
                      codecs.Options.Jpeg2000.Save.RegionOfInterestRectangle = dlg.FileJ2kOptions.RegionOfInterestRectangle;
                      codecs.Options.Jpeg2000.Save.RegionOfInterestWeight = dlg.FileJ2kOptions.RegionOfInterestWeight;
                      codecs.Options.Jpeg2000.Save.ResetContextOnBoundaries = dlg.FileJ2kOptions.ResetContextOnBoundaries;
                      codecs.Options.Jpeg2000.Save.SelectiveAcBypass = dlg.FileJ2kOptions.SelectiveAcBypass;
                      codecs.Options.Jpeg2000.Save.TargetFileSize = dlg.FileJ2kOptions.TargetFileSize;
                      codecs.Options.Jpeg2000.Save.TerminationOnEachPass = dlg.FileJ2kOptions.TerminationOnEachPass;
                      codecs.Options.Jpeg2000.Save.TileHorizontalOffset = dlg.FileJ2kOptions.TileHorizontalOffset;
                      codecs.Options.Jpeg2000.Save.TileVerticalOffset = dlg.FileJ2kOptions.TileVerticalOffset;
                      codecs.Options.Jpeg2000.Save.UseColorTransform = dlg.FileJ2kOptions.UseColorTransform;
                      codecs.Options.Jpeg2000.Save.UseEphMarker = dlg.FileJ2kOptions.UseEphMarker;
                      codecs.Options.Jpeg2000.Save.UseRegionOfInterest = dlg.FileJ2kOptions.UseRegionOfInterest;
                      codecs.Options.Jpeg2000.Save.UseSopMarker = dlg.FileJ2kOptions.UseSopMarker;
                      codecs.Options.Jpeg2000.Save.VerticallyCausalContext = dlg.FileJ2kOptions.VerticallyCausalContext;
                  }

                  codecs.Save(image,
                     _fileName,
                     _format,
                     _bitsPerPixel,
                     image.Page,
                     image.Page,
                     _savePageNumber,
                     _pageMode);
              }


              return true;
          }
          else
              return false;
      }
      //**added by unisystems 10/7/2008
       public bool Save(IWin32Window owner, RasterCodecs codecs, RasterImage image, String filename)
       {
           FileInfo fileInfo = new FileInfo(filename);
           if (fileInfo.Extension == ".tiff" || fileInfo.Extension==".tif")
           _format = RasterImageFormat.CcittGroup4;
             else if (fileInfo.Extension == ".pdf")
           _format = RasterImageFormat.RasPdfG4;    
           
           _firstPage = 1;
           _lastPage = image.PageCount;
           _savePageNumber = image.PageCount;
           _pageMode = CodecsSavePageMode.Overwrite;
           _fileName = filename;
           _bitsPerPixel = 1;

           codecs.Save(image, _fileName, _format, _bitsPerPixel, _firstPage, _lastPage, _firstPage, _pageMode);
           

           return true;
       }
       //**
   }
}