namespace MainDemo
{
   partial class GrayScaleDialog
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
         this._rb8 = new System.Windows.Forms.RadioButton();
         this._rb12 = new System.Windows.Forms.RadioButton();
         this._gbOptions = new System.Windows.Forms.GroupBox();
         this._rb16 = new System.Windows.Forms.RadioButton();
         this._btnCancel = new System.Windows.Forms.Button();
         this._btnOk = new System.Windows.Forms.Button();
         this._gbOptions.SuspendLayout();
         this.SuspendLayout();
         // 
         // _rb8
         // 
         this._rb8.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._rb8.Location = new System.Drawing.Point(19, 28);
         this._rb8.Name = "_rb8";
         this._rb8.Size = new System.Drawing.Size(192, 27);
         this._rb8.TabIndex = 0;
         this._rb8.TabStop = true;
         this._rb8.Text = "Gray Scale 8 Bits/Pixel";
         this._rb8.UseVisualStyleBackColor = true;
         // 
         // _rb12
         // 
         this._rb12.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._rb12.Location = new System.Drawing.Point(19, 65);
         this._rb12.Name = "_rb12";
         this._rb12.Size = new System.Drawing.Size(192, 27);
         this._rb12.TabIndex = 1;
         this._rb12.TabStop = true;
         this._rb12.Text = "Gray Scale 12 Bits/Pixel";
         this._rb12.UseVisualStyleBackColor = true;
         // 
         // _gbOptions
         // 
         this._gbOptions.Controls.Add(this._rb16);
         this._gbOptions.Controls.Add(this._rb12);
         this._gbOptions.Controls.Add(this._rb8);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbOptions.Location = new System.Drawing.Point(10, 9);
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.Size = new System.Drawing.Size(249, 148);
         this._gbOptions.TabIndex = 0;
         this._gbOptions.TabStop = false;
         // 
         // _rb16
         // 
         this._rb16.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._rb16.Location = new System.Drawing.Point(19, 102);
         this._rb16.Name = "_rb16";
         this._rb16.Size = new System.Drawing.Size(192, 27);
         this._rb16.TabIndex = 2;
         this._rb16.TabStop = true;
         this._rb16.Text = "Gray Scale 16 Bits/Pixel";
         this._rb16.UseVisualStyleBackColor = true;
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnCancel.Location = new System.Drawing.Point(282, 55);
         this._btnCancel.Name = "_btnCancel";
         this._btnCancel.Size = new System.Drawing.Size(90, 27);
         this._btnCancel.TabIndex = 2;
         this._btnCancel.Text = "Cancel";
         this._btnCancel.UseVisualStyleBackColor = true;
         // 
         // _btnOk
         // 
         this._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnOk.Location = new System.Drawing.Point(282, 18);
         this._btnOk.Name = "_btnOk";
         this._btnOk.Size = new System.Drawing.Size(90, 27);
         this._btnOk.TabIndex = 1;
         this._btnOk.Text = "OK";
         this._btnOk.UseVisualStyleBackColor = true;
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // GrayScaleDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(386, 175);
         this.Controls.Add(this._gbOptions);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "GrayScaleDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Gray Scale";
         this.Load += new System.EventHandler(this.GrayScaleDialog_Load);
         this._gbOptions.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.RadioButton _rb8;
      private System.Windows.Forms.RadioButton _rb12;
      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
      private System.Windows.Forms.RadioButton _rb16;
   }
}