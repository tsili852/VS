using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Leadtools;

namespace MainDemo
{
   public partial class ImageInformationDialog : Form
   {
      public RasterImage Image;

      public ImageInformationDialog()
      {
         InitializeComponent();
      }

      private void ImageInformationDialog_Load(object sender, System.EventArgs e)
      {
         for (int i = 0; i < _lvInfo.Items.Count; i++)
            _lvInfo.Items[i].SubItems.Add(string.Empty);

         UpdateControls();
      }

      private void UpdateControls()
      {
         _lblPage.Text = string.Format("Page {0}:{1}", Image.Page, Image.PageCount);
         _btnPageFirst.Enabled = Image.Page > 1;
         _btnPagePrevious.Enabled = Image.Page > 1;
         _btnPageNext.Enabled = Image.Page < Image.PageCount;
         _btnPageLast.Enabled = Image.Page < Image.PageCount;

         int index = 0;
         _lvInfo.Items[index++].SubItems[1].Text = Image.OriginalFormat.ToString();
         _lvInfo.Items[index++].SubItems[1].Text = string.Format("{0} x {1} pixels", Image.Width, Image.Height);
         _lvInfo.Items[index++].SubItems[1].Text = string.Format("{0} x {1} pixels", Image.ImageWidth, Image.ImageHeight);
         _lvInfo.Items[index++].SubItems[1].Text = string.Format("{0} x {1} dpi", Image.XResolution, Image.YResolution);
         _lvInfo.Items[index++].SubItems[1].Text = Image.BitsPerPixel.ToString();
         _lvInfo.Items[index++].SubItems[1].Text = Image.BytesPerLine.ToString();
         _lvInfo.Items[index++].SubItems[1].Text = Image.DataSize.ToString();
         _lvInfo.Items[index++].SubItems[1].Text = Constants.GetNameFromValue(typeof(RasterViewPerspective), Image.ViewPerspective);
         _lvInfo.Items[index++].SubItems[1].Text = Constants.GetNameFromValue(typeof(RasterByteOrder), Image.Order);
         _lvInfo.Items[index++].SubItems[1].Text = Image.HasRegion ? "Yes" : "No";
         if (Image.IsCompressed)
            _lvInfo.Items[index++].SubItems[1].Text = "Run Length Limited (RLE)";
         else
            _lvInfo.Items[index++].SubItems[1].Text = "Not compressed";

         if (Image.IsDiskMemory)
            _lvInfo.Items[index++].SubItems[1].Text = "Disk";
         else if (Image.IsTiled)
            _lvInfo.Items[index++].SubItems[1].Text = "Tiled";
         else if (Image.IsConventionalMemory)
            _lvInfo.Items[index++].SubItems[1].Text = "Managed memory";
         else
            _lvInfo.Items[index++].SubItems[1].Text = "Unmanaged memory";

         _lvInfo.Items[index++].SubItems[1].Text = Image.Signed ? "Yes" : "No";
         _lvInfo.Items[index++].SubItems[1].Text = Constants.GetNameFromValue(typeof(RasterGrayscaleMode), Image.GrayscaleMode);

         RasterColor[] palette = Image.GetPalette();
         _btnPalette.Enabled = palette != null && palette.Length > 0;
      }

      private void _btnPalette_Click(object sender, System.EventArgs e)
      {
          PaletteDialog dlg = new PaletteDialog();
          dlg.Palette = Image.GetPalette();
          dlg.ShowDialog(this);
      }

      private void _btnPageFirst_Click(object sender, System.EventArgs e)
      {
         Image.Page = 1;
         UpdateControls();
      }

      private void _btnPagePrevious_Click(object sender, System.EventArgs e)
      {
         Image.Page--;
         UpdateControls();
      }

      private void _btnPageNext_Click(object sender, System.EventArgs e)
      {
         Image.Page++;
         UpdateControls();
      }

      private void _btnPageLast_Click(object sender, System.EventArgs e)
      {
         Image.Page = Image.PageCount;
         UpdateControls();
      }
   }
}