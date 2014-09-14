using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Unisystems.Cheques.UniChequeProcessing.Common
{
   public partial class PdfEngineDialog : Form
   {
      public PdfEngineDialog( )
      {
         DialogUtilities.RunFPU();

         InitializeComponent();
      }

      public void ShowWarningMessagesOnly()
      {
         _gbOptions.Text = "The demo can continue without PDF support. What do you want to do now:";
         _rbCancel.Text = "Close the demo";
         _rbContinue.Text = "Continue with the demo without PDF support";
         _rbContinue.Checked = true;
      }

      private void _btnOk_Click(object sender, System.EventArgs e)
      {
         if(_rbCancel.Checked)
            DialogResult = DialogResult.Cancel;
         else
            DialogResult = DialogResult.OK;
      }

      private void _lbEngine_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
      {
         Process.Start(_lbEngine.Text);
      }

      private void PdfEngineDialog_Load(object sender, EventArgs e)
      {
#if LTV17_CONFIG
         this._lbEngine.Text = "http://www.leadtools.com/rd/v170/LEADTOOLSPDFRuntime.exe";
#elif LTV16_CONFIG
         this._lbEngine.Text = "http://www.leadtools.com/rd/v160/LEADTOOLSPDFRuntime.exe";
#else
         this._lbEngine.Text = "http://www.leadtools.com/rd/v150/LEADTOOLSPDFRuntime.exe";
#endif
      }
   }
}