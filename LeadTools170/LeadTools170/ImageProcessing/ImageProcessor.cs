using System;
using System.Collections.Generic;
using System.Text;

using Leadtools.ImageProcessing.Core;
using Leadtools;

namespace LeadTools170.ImageProcessing
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

        public void Despecle(RasterImage image)
        {
            DespeckleCommand cmd = new DespeckleCommand();
            cmd.Run(image);
        }

        public void Deskew(RasterImage image)
        {
            DeskewCommand cmd = new DeskewCommand();
            cmd.Flags = DeskewCommandFlags.UseLineDetectionCheckDeskew;
            cmd.Run(image);
        }

        public void RemoveDots(RasterImage image)
        {
            DotRemoveCommand cmd = new DotRemoveCommand();
            cmd.Run(image);
        }

        public void RemoveLines(RasterImage image)
        {
            LineRemoveCommand cmd = new LineRemoveCommand();
            cmd.Run(image);
        }
	

    }
}
