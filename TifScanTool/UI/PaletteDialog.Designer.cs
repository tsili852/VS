namespace MainDemo
{
   partial class PaletteDialog
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
         this._lblPaletteInfo = new System.Windows.Forms.Label();
         this._lblCurrentColor = new System.Windows.Forms.Label();
         this._btnClose = new System.Windows.Forms.Button();
         this._pnlPalette = new System.Windows.Forms.Panel();
         this.SuspendLayout();
         // 
         // _lblPaletteInfo
         // 
         this._lblPaletteInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this._lblPaletteInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblPaletteInfo.Location = new System.Drawing.Point(15, 9);
         this._lblPaletteInfo.Name = "_lblPaletteInfo";
         this._lblPaletteInfo.Size = new System.Drawing.Size(615, 27);
         this._lblPaletteInfo.TabIndex = 0;
         this._lblPaletteInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // _lblCurrentColor
         // 
         this._lblCurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this._lblCurrentColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblCurrentColor.Location = new System.Drawing.Point(15, 46);
         this._lblCurrentColor.Name = "_lblCurrentColor";
         this._lblCurrentColor.Size = new System.Drawing.Size(615, 27);
         this._lblCurrentColor.TabIndex = 1;
         this._lblCurrentColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // _btnClose
         // 
         this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnClose.Location = new System.Drawing.Point(278, 600);
         this._btnClose.Name = "_btnClose";
         this._btnClose.Size = new System.Drawing.Size(90, 27);
         this._btnClose.TabIndex = 3;
         this._btnClose.Text = "Close";
         this._btnClose.UseVisualStyleBackColor = true;
         // 
         // _pnlPalette
         // 
         this._pnlPalette.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this._pnlPalette.Location = new System.Drawing.Point(14, 83);
         this._pnlPalette.Name = "_pnlPalette";
         this._pnlPalette.Size = new System.Drawing.Size(615, 489);
         this._pnlPalette.TabIndex = 2;
         this._pnlPalette.MouseMove += new System.Windows.Forms.MouseEventHandler(this._pnlPalette_MouseMove);
         this._pnlPalette.Paint += new System.Windows.Forms.PaintEventHandler(this._pnlPalette_Paint);
         // 
         // PaletteDialog
         // 
         this.AcceptButton = this._btnClose;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnClose;
         this.ClientSize = new System.Drawing.Size(643, 638);
         this.Controls.Add(this._pnlPalette);
         this.Controls.Add(this._btnClose);
         this.Controls.Add(this._lblCurrentColor);
         this.Controls.Add(this._lblPaletteInfo);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "PaletteDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Palette";
         this.Load += new System.EventHandler(this.PaletteDialog_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label _lblPaletteInfo;
      private System.Windows.Forms.Label _lblCurrentColor;
      private System.Windows.Forms.Button _btnClose;
      private System.Windows.Forms.Panel _pnlPalette;
   }
}