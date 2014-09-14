using System;

using Leadtools;

namespace Unisystems.Cheques.UniChequeProcessing.Common
{
   public class ImageInformation
   {
      public RasterImage Image;
      public string Name;

      public ImageInformation( )
      {
         Image = null;
         Name = string.Empty;
      }

      public ImageInformation(RasterImage image, string name)
      {
         Image = image;
         Name = name;
      }

      public ImageInformation(RasterImage image)
      {
         Image = image;
         Name = "Untitled";
      }
   }
}
