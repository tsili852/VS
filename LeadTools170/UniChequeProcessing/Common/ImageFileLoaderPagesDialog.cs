using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Unisystems.Cheques.UniChequeProcessing.Common
{
   public partial class ImageFileLoaderPagesDialog : Form
   {
      private int _pages;
      private bool _loadOnlyOnePage;

      public int FirstPage;
      public int LastPage;
      public bool AllPages;

      public ImageFileLoaderPagesDialog(int pages, bool loadOnlyOnePage)
      {
         InitializeComponent();

         _pages = pages;
         _loadOnlyOnePage = loadOnlyOnePage;
      }

      private void ImageFileLoaderPagesDialog_Load(object sender, System.EventArgs e)
      {
         AllPages = true;
         FirstPage = 1;
         LastPage = 1;

         string text = _lblInfo.Text;
         text = text.Replace("###", _pages.ToString());

         if(!_loadOnlyOnePage)
         {
            _cbAllPages.Checked = AllPages;
            text = text.Replace("$$$", "pages");
         }
         else
         {
            _cbAllPages.Checked = false;
            text = text.Replace("$$$", "page");
         }

         _lblInfo.Text = text;

         _tbFirstPage.Text = FirstPage.ToString();
         _tbLastPage.Text = LastPage.ToString();
         UpdateControls();
      }

      private void _cbAllPages_CheckedChanged(object sender, System.EventArgs e)
      {
         UpdateControls();
      }

      private void UpdateControls( )
      {
         if(_loadOnlyOnePage)
         {
            _lblFirstPage.Text = "Page:";
            _lblLastPage.Visible = false;
            _lblLastPage.Enabled = false;
            _tbLastPage.Visible = false;
            _tbLastPage.Enabled = false;
            _cbAllPages.Visible = false;
            _cbAllPages.Enabled = false;
         }
         else
         {
            _lblFirstPage.Enabled = !_cbAllPages.Checked;
            _tbFirstPage.Enabled = !_cbAllPages.Checked;
            _lblLastPage.Enabled = !_cbAllPages.Checked;
            _tbLastPage.Enabled = !_cbAllPages.Checked;
         }
      }

      private void _tb_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
      {
         if(!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            e.Handled = true;
      }

      private void _btnOk_Click(object sender, System.EventArgs e)
      {
         if(_loadOnlyOnePage)
         {
            if(!DialogUtilities.ParseInteger(_tbFirstPage, "Page", 1, true, _pages, true, true, out FirstPage))
               return;

            AllPages = false;
            LastPage = FirstPage;
         }
         else
         {
            AllPages = _cbAllPages.Checked;

            if(!AllPages)
            {
               if(!DialogUtilities.ParseInteger(_tbFirstPage, "First Page", 1, true, _pages, true, true, out FirstPage))
                  return;

               if(!DialogUtilities.ParseInteger(_tbLastPage, "Last Page", FirstPage, true, _pages, true, true, out LastPage))
                  return;
            }
         }
      }
   }
}