using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Leadtools.Demos;
using Leadtools;
using Leadtools.ImageProcessing;
using Leadtools.ImageProcessing.Effects;

namespace MainDemo
{
   partial class AddNoiseDialog
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
         this._gbOptions = new System.Windows.Forms.GroupBox();
         this._lblRange = new System.Windows.Forms.Label();
         this._cbChannel = new System.Windows.Forms.ComboBox();
         this._numRange = new System.Windows.Forms.NumericUpDown();
         this._lblChannel = new System.Windows.Forms.Label();
         this._btnOk = new System.Windows.Forms.Button();
         this._btnCancel = new System.Windows.Forms.Button();
         this._gbOptions.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._numRange)).BeginInit();
         this.SuspendLayout();
         // 
         // _gbOptions
         // 
         this._gbOptions.Controls.Add(this._lblRange);
         this._gbOptions.Controls.Add(this._cbChannel);
         this._gbOptions.Controls.Add(this._numRange);
         this._gbOptions.Controls.Add(this._lblChannel);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbOptions.Location = new System.Drawing.Point(10, 9);
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.Size = new System.Drawing.Size(278, 93);
         this._gbOptions.TabIndex = 0;
         this._gbOptions.TabStop = false;
         // 
         // _lblRange
         // 
         this._lblRange.AutoSize = true;
         this._lblRange.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblRange.Location = new System.Drawing.Point(19, 18);
         this._lblRange.Name = "_lblRange";
         this._lblRange.Size = new System.Drawing.Size(50, 17);
         this._lblRange.TabIndex = 0;
         this._lblRange.Text = "Range";
         // 
         // _cbChannel
         // 
         this._cbChannel.FormattingEnabled = true;
         this._cbChannel.Location = new System.Drawing.Point(115, 55);
         this._cbChannel.Name = "_cbChannel";
         this._cbChannel.Size = new System.Drawing.Size(145, 24);
         this._cbChannel.TabIndex = 3;
         // 
         // _numRange
         // 
         this._numRange.Location = new System.Drawing.Point(115, 18);
         this._numRange.Name = "_numRange";
         this._numRange.Size = new System.Drawing.Size(144, 22);
         this._numRange.TabIndex = 1;
         this._numRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numRange.Leave += new System.EventHandler(this._numRange_Leave);
         // 
         // _lblChannel
         // 
         this._lblChannel.AutoSize = true;
         this._lblChannel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblChannel.Location = new System.Drawing.Point(19, 55);
         this._lblChannel.Name = "_lblChannel";
         this._lblChannel.Size = new System.Drawing.Size(60, 17);
         this._lblChannel.TabIndex = 2;
         this._lblChannel.Text = "Channel";
         // 
         // _btnOk
         // 
         this._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnOk.Location = new System.Drawing.Point(317, 18);
         this._btnOk.Name = "_btnOk";
         this._btnOk.Size = new System.Drawing.Size(90, 27);
         this._btnOk.TabIndex = 1;
         this._btnOk.Text = "OK";
         this._btnOk.UseVisualStyleBackColor = true;
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnCancel.Location = new System.Drawing.Point(317, 55);
         this._btnCancel.Name = "_btnCancel";
         this._btnCancel.Size = new System.Drawing.Size(90, 27);
         this._btnCancel.TabIndex = 1;
         this._btnCancel.Text = "Cancel";
         this._btnCancel.UseVisualStyleBackColor = true;
         // 
         // AddNoiseDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(422, 116);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.Controls.Add(this._gbOptions);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "AddNoiseDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "AddNoiseDialog";
         this.Load += new System.EventHandler(this.AddNoiseDialog_Load);
         this._gbOptions.ResumeLayout(false);
         this._gbOptions.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this._numRange)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.ComboBox _cbChannel;
      private System.Windows.Forms.NumericUpDown _numRange;
      private System.Windows.Forms.Label _lblChannel;
      private System.Windows.Forms.Label _lblRange;
      private System.Windows.Forms.Button _btnOk;
      private System.Windows.Forms.Button _btnCancel;
   }
}