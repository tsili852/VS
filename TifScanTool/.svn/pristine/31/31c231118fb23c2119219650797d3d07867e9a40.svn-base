using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Leadtools.WinForms;

namespace MainDemo
{
   public partial class PanViewerForm : Form
   {
      private RasterImagePanViewer _panViewer;

      public PanViewerForm()
      {
         InitializeComponent();

         InitClass();
      }

      private void InitClass()
      {
         _panViewer = new RasterImagePanViewer();
         _panViewer.Dock = DockStyle.Fill;
         

         _panViewer.BorderStyle = BorderStyle.None;
         Controls.Add(_panViewer);
         _panViewer.BringToFront();
      }

      private void PanViewerForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
      {
         e.Cancel = true;
         Visible = false;
         ((MainForm)Owner).UpdateControls();
      }

      public void SetViewer(RasterImageViewer viewer)
      {
         _panViewer.Viewer = viewer;
      }

   }
}