namespace Leadtools.Demos
{
   partial class ImageFileLoaderPagesDialog
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this._tbFirstPage = new System.Windows.Forms.TextBox();
         this._lblInfo = new System.Windows.Forms.Label();
         this._gbPages = new System.Windows.Forms.GroupBox();
         this._cbAllPages = new System.Windows.Forms.CheckBox();
         this._tbLastPage = new System.Windows.Forms.TextBox();
         this._lblLastPage = new System.Windows.Forms.Label();
         this._lblFirstPage = new System.Windows.Forms.Label();
         this._btnCancel = new System.Windows.Forms.Button();
         this._btnOk = new System.Windows.Forms.Button();
         this._gbPages.SuspendLayout();
         this.SuspendLayout();
         // 
         // _tbFirstPage
         // 
         this._tbFirstPage.Location = new System.Drawing.Point(115, 74);
         this._tbFirstPage.Name = "_tbFirstPage";
         this._tbFirstPage.Size = new System.Drawing.Size(120, 22);
         this._tbFirstPage.TabIndex = 2;
         this._tbFirstPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tb_KeyPress);
         // 
         // _lblInfo
         // 
         this._lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblInfo.Location = new System.Drawing.Point(19, 28);
         this._lblInfo.Name = "_lblInfo";
         this._lblInfo.Size = new System.Drawing.Size(288, 37);
         this._lblInfo.TabIndex = 0;
         this._lblInfo.Text = "This file has ### total pages.  Select the $$$ you want to load:";
         // 
         // _gbPages
         // 
         this._gbPages.Controls.Add(this._cbAllPages);
         this._gbPages.Controls.Add(this._tbLastPage);
         this._gbPages.Controls.Add(this._lblLastPage);
         this._gbPages.Controls.Add(this._tbFirstPage);
         this._gbPages.Controls.Add(this._lblInfo);
         this._gbPages.Controls.Add(this._lblFirstPage);
         this._gbPages.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbPages.Location = new System.Drawing.Point(12, 12);
         this._gbPages.Name = "_gbPages";
         this._gbPages.Size = new System.Drawing.Size(326, 194);
         this._gbPages.TabIndex = 3;
         this._gbPages.TabStop = false;
         // 
         // _cbAllPages
         // 
         this._cbAllPages.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._cbAllPages.Location = new System.Drawing.Point(19, 148);
         this._cbAllPages.Name = "_cbAllPages";
         this._cbAllPages.Size = new System.Drawing.Size(125, 27);
         this._cbAllPages.TabIndex = 5;
         this._cbAllPages.Text = "Load All Pages";
         this._cbAllPages.CheckedChanged += new System.EventHandler(this._cbAllPages_CheckedChanged);
         // 
         // _tbLastPage
         // 
         this._tbLastPage.Location = new System.Drawing.Point(115, 111);
         this._tbLastPage.Name = "_tbLastPage";
         this._tbLastPage.Size = new System.Drawing.Size(120, 22);
         this._tbLastPage.TabIndex = 4;
         this._tbLastPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tb_KeyPress);
         // 
         // _lblLastPage
         // 
         this._lblLastPage.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblLastPage.Location = new System.Drawing.Point(19, 111);
         this._lblLastPage.Name = "_lblLastPage";
         this._lblLastPage.Size = new System.Drawing.Size(87, 26);
         this._lblLastPage.TabIndex = 3;
         this._lblLastPage.Text = "Last Page:";
         this._lblLastPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblFirstPage
         // 
         this._lblFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblFirstPage.Location = new System.Drawing.Point(19, 74);
         this._lblFirstPage.Name = "_lblFirstPage";
         this._lblFirstPage.Size = new System.Drawing.Size(87, 26);
         this._lblFirstPage.TabIndex = 1;
         this._lblFirstPage.Text = "First Page:";
         this._lblFirstPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnCancel.Location = new System.Drawing.Point(349, 58);
         this._btnCancel.Name = "_btnCancel";
         this._btnCancel.Size = new System.Drawing.Size(90, 27);
         this._btnCancel.TabIndex = 5;
         this._btnCancel.Text = "Cancel";
         // 
         // _btnOk
         // 
         this._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnOk.Location = new System.Drawing.Point(349, 21);
         this._btnOk.Name = "_btnOk";
         this._btnOk.Size = new System.Drawing.Size(90, 27);
         this._btnOk.TabIndex = 4;
         this._btnOk.Text = "OK";
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // ImageFileLoaderPagesDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(451, 220);
         this.Controls.Add(this._gbPages);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "ImageFileLoaderPagesDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Load Pages";
         this.Load += new System.EventHandler(this.ImageFileLoaderPagesDialog_Load);
         this._gbPages.ResumeLayout(false);
         this._gbPages.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TextBox _tbFirstPage;
      private System.Windows.Forms.Label _lblInfo;
      private System.Windows.Forms.GroupBox _gbPages;
      private System.Windows.Forms.CheckBox _cbAllPages;
      private System.Windows.Forms.TextBox _tbLastPage;
      private System.Windows.Forms.Label _lblLastPage;
      private System.Windows.Forms.Label _lblFirstPage;
      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
   }
}