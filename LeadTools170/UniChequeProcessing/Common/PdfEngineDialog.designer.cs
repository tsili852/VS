namespace Unisystems.Cheques.UniChequeProcessing.Common
{
   partial class PdfEngineDialog
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
         if(disposing && (components != null))
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
      private void InitializeComponent( )
      {
         this._gbOptions = new System.Windows.Forms.GroupBox();
         this._rbContinue = new System.Windows.Forms.RadioButton();
         this._rbCancel = new System.Windows.Forms.RadioButton();
         this._lblLine1 = new System.Windows.Forms.Label();
         this._lbEngine = new System.Windows.Forms.LinkLabel();
         this._lblLine2 = new System.Windows.Forms.Label();
         this._btnOk = new System.Windows.Forms.Button();
         this._gbOptions.SuspendLayout();
         this.SuspendLayout();
         // 
         // _gbOptions
         // 
         this._gbOptions.Controls.Add(this._rbContinue);
         this._gbOptions.Controls.Add(this._rbCancel);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbOptions.Location = new System.Drawing.Point(9, 86);
         this._gbOptions.Margin = new System.Windows.Forms.Padding(2);
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.Padding = new System.Windows.Forms.Padding(2);
         this._gbOptions.Size = new System.Drawing.Size(396, 75);
         this._gbOptions.TabIndex = 9;
         this._gbOptions.TabStop = false;
         this._gbOptions.Text = "What do you want to do now:";
         // 
         // _rbContinue
         // 
         this._rbContinue.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._rbContinue.Location = new System.Drawing.Point(14, 45);
         this._rbContinue.Margin = new System.Windows.Forms.Padding(2);
         this._rbContinue.Name = "_rbContinue";
         this._rbContinue.Size = new System.Drawing.Size(368, 23);
         this._rbContinue.TabIndex = 1;
         this._rbContinue.Text = "Try to load the image anyway";
         // 
         // _rbCancel
         // 
         this._rbCancel.Checked = true;
         this._rbCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._rbCancel.Location = new System.Drawing.Point(14, 15);
         this._rbCancel.Margin = new System.Windows.Forms.Padding(2);
         this._rbCancel.Name = "_rbCancel";
         this._rbCancel.Size = new System.Drawing.Size(368, 23);
         this._rbCancel.TabIndex = 0;
         this._rbCancel.TabStop = true;
         this._rbCancel.Text = "Cancel loading the image";
         // 
         // _lblLine1
         // 
         this._lblLine1.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblLine1.Location = new System.Drawing.Point(9, 11);
         this._lblLine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this._lblLine1.Name = "_lblLine1";
         this._lblLine1.Size = new System.Drawing.Size(194, 22);
         this._lblLine1.TabIndex = 6;
         this._lblLine1.Text = "The LEADTOOLS Pdf engine is missing.";
         this._lblLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lbEngine
         // 
         this._lbEngine.Location = new System.Drawing.Point(6, 54);
         this._lbEngine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this._lbEngine.Name = "_lbEngine";
         this._lbEngine.Size = new System.Drawing.Size(399, 21);
         this._lbEngine.TabIndex = 8;
         this._lbEngine.TabStop = true;
         this._lbEngine.Text = "http://www.leadtools.com/rd/v160/LEADTOOLSPDFRuntime.exe";
         this._lbEngine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this._lbEngine.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._lbEngine_LinkClicked);
         // 
         // _lblLine2
         // 
         this._lblLine2.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblLine2.Location = new System.Drawing.Point(9, 33);
         this._lblLine2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this._lblLine2.Name = "_lblLine2";
         this._lblLine2.Size = new System.Drawing.Size(403, 21);
         this._lblLine2.TabIndex = 7;
         this._lblLine2.Text = "Please download and install the LEADTOOLS Pdf engine from the following address:";
         this._lblLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _btnOk
         // 
         this._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnOk.Location = new System.Drawing.Point(418, 100);
         this._btnOk.Margin = new System.Windows.Forms.Padding(2);
         this._btnOk.Name = "_btnOk";
         this._btnOk.Size = new System.Drawing.Size(68, 22);
         this._btnOk.TabIndex = 5;
         this._btnOk.Text = "OK";
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // PdfEngineDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnOk;
         this.ClientSize = new System.Drawing.Size(496, 172);
         this.Controls.Add(this._gbOptions);
         this.Controls.Add(this._lblLine1);
         this.Controls.Add(this._lbEngine);
         this.Controls.Add(this._lblLine2);
         this.Controls.Add(this._btnOk);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Margin = new System.Windows.Forms.Padding(2);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "PdfEngineDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "LEADTOOLS Pdf Engine Warning";
         this.Load += new System.EventHandler(this.PdfEngineDialog_Load);
         this._gbOptions.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.RadioButton _rbContinue;
      private System.Windows.Forms.RadioButton _rbCancel;
      private System.Windows.Forms.Label _lblLine1;
      private System.Windows.Forms.LinkLabel _lbEngine;
      private System.Windows.Forms.Label _lblLine2;
      private System.Windows.Forms.Button _btnOk;
   }
}