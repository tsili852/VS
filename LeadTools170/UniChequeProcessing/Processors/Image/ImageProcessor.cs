using System;
using System.Collections.Generic;
using System.Text;
using Leadtools;
using Leadtools.ImageProcessing.Core;

namespace Unisystems.Cheques.UniChequeProcessing.Processors.Image
{
    public class ImageProcessor
    {

        public void Binarize(RasterImage image)
        {
            AutoBinarizeCommand cmd = new AutoBinarizeCommand();
            cmd.Run(image);
        }

        public void RemoveBorders(RasterImage image)
        {
            BorderRemoveCommand cmd = new BorderRemoveCommand();
            cmd.Run(image);
        }

        public void Crop(RasterImage image)
        {
            AutoCropCommand cmd = new AutoCropCommand();
            cmd.Run(image);
        }

        public void Despeckle(RasterImage image)
        {
            DespeckleCommand cmd = new DespeckleCommand();
            cmd.Run(image);
        }

        public void Deskew(RasterImage image)
        {
            DeskewCommand cmd = new DeskewCommand();
            cmd.Flags = DeskewCommandFlags.UseCheckDeskew | DeskewCommandFlags.UseLineDetectionCheckDeskew;
            cmd.Run(image);
        }

        public void RemoveDots(RasterImage image)
        {
            //N.T.
            //DotRemoveCommand cmd = new DotRemoveCommand();
            //cmd.Run(image);
        }

        public void RemoveLines(RasterImage image)
        {
            //LineRemoveCommand cmd = new LineRemoveCommand();
            //cmd.Run(image);
        }


    }
}
