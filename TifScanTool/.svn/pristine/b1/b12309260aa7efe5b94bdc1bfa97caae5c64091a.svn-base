using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Leadtools.Demos
{
   public partial class PdfEngineDialog : Form
   {
      public PdfEngineDialog()
      {
         DialogUtilities.RunFPU();

         InitializeComponent();
      }

      private void _btnOk_Click(object sender, System.EventArgs e)
      {
         if (_rbCancel.Checked)
            DialogResult = DialogResult.Cancel;
         else
            DialogResult = DialogResult.OK;
      }

      private void _lbEngine_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
      {
         Process.Start(_lbEngine.Text);
      }
   }
}