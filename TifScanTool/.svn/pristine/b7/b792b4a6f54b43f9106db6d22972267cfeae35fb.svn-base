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
   public partial class AboutDialog : Form
   {
      private string _demoName;

      public AboutDialog(string demoName)
      {
         InitializeComponent();

         _demoName = demoName;
      }

      private void AboutDialog_Load(object sender, System.EventArgs e)
      {
          _tb1.Text = string.Format("{0}{0}Unisystems Scan Utility {0} Copyright © Unisystems 2008 {0}{0}", Environment.NewLine);

         if (DialogUtilities.CanRunPrintPreview)
         {
            _lblWebSite.Visible = false;
            LinkLabel ll = new LinkLabel();
            ll.Text = _lblWebSite.Text;
            ll.TextAlign = ContentAlignment.MiddleCenter;
            ll.Location = _lblWebSite.Location;
            ll.Size = _lblWebSite.Size;
            _gbHelp.Controls.Add(ll);
            ll.LinkClicked += new LinkLabelLinkClickedEventHandler(ll_LinkClicked);
         }
      }

      private void ll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         Process.Start(_lblWebSite.Text);
      }
   }
}