namespace MainDemo
{
   partial class ShearDialog
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
         this._gb = new System.Windows.Forms.GroupBox();
         this._lblDirection = new System.Windows.Forms.Label();
         this._gbDirection = new System.Windows.Forms.GroupBox();
         this._btnFillColor = new System.Windows.Forms.Button();
         this._pnlFillColor = new System.Windows.Forms.Panel();
         this._lblFillColor = new System.Windows.Forms.Label();
         this._numAngle = new System.Windows.Forms.NumericUpDown();
         this._lblAngle = new System.Windows.Forms.Label();
         this._rbHorizontal = new System.Windows.Forms.RadioButton();
         this._rbVertical = new System.Windows.Forms.RadioButton();
         this._btnCancel = new System.Windows.Forms.Button();
         this._btnOk = new System.Windows.Forms.Button();
         this._gb.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._numAngle)).BeginInit();
         this.SuspendLayout();
         // 
         // _gb
         // 
         this._gb.Controls.Add(this._lblDirection);
         this._gb.Controls.Add(this._gbDirection);
         this._gb.Controls.Add(this._btnFillColor);
         this._gb.Controls.Add(this._pnlFillColor);
         this._gb.Controls.Add(this._lblFillColor);
         this._gb.Controls.Add(this._numAngle);
         this._gb.Controls.Add(this._lblAngle);
         this._gb.Controls.Add(this._rbHorizontal);
         this._gb.Controls.Add(this._rbVertical);
         this._gb.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gb.Location = new System.Drawing.Point(12, 12);
         this._gb.Name = "_gb";
         this._gb.Size = new System.Drawing.Size(316, 231);
         this._gb.TabIndex = 0;
         this._gb.TabStop = false;
         // 
         // _lblDirection
         // 
         this._lblDirection.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblDirection.Location = new System.Drawing.Point(19, 120);
         this._lblDirection.Name = "_lblDirection";
         this._lblDirection.Size = new System.Drawing.Size(120, 27);
         this._lblDirection.TabIndex = 6;
         this._lblDirection.Text = "Direction";
         this._lblDirection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _gbDirection
         // 
         this._gbDirection.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbDirection.Location = new System.Drawing.Point(19, 102);
         this._gbDirection.Name = "_gbDirection";
         this._gbDirection.Size = new System.Drawing.Size(279, 9);
         this._gbDirection.TabIndex = 5;
         this._gbDirection.TabStop = false;
         // 
         // _btnFillColor
         // 
         this._btnFillColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnFillColor.Location = new System.Drawing.Point(269, 65);
         this._btnFillColor.Name = "_btnFillColor";
         this._btnFillColor.Size = new System.Drawing.Size(29, 26);
         this._btnFillColor.TabIndex = 4;
         this._btnFillColor.Text = "...";
         this._btnFillColor.Click += new System.EventHandler(this._btnFillColor_Click);
         // 
         // _pnlFillColor
         // 
         this._pnlFillColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this._pnlFillColor.Location = new System.Drawing.Point(154, 65);
         this._pnlFillColor.Name = "_pnlFillColor";
         this._pnlFillColor.Size = new System.Drawing.Size(115, 27);
         this._pnlFillColor.TabIndex = 3;
         this._pnlFillColor.Paint += new System.Windows.Forms.PaintEventHandler(this._pnlFillColor_Paint);
         // 
         // _lblFillColor
         // 
         this._lblFillColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblFillColor.Location = new System.Drawing.Point(19, 65);
         this._lblFillColor.Name = "_lblFillColor";
         this._lblFillColor.Size = new System.Drawing.Size(120, 26);
         this._lblFillColor.TabIndex = 2;
         this._lblFillColor.Text = "Fill Color";
         this._lblFillColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _numAngle
         // 
         this._numAngle.Location = new System.Drawing.Point(154, 28);
         this._numAngle.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
         this._numAngle.Name = "_numAngle";
         this._numAngle.Size = new System.Drawing.Size(144, 22);
         this._numAngle.TabIndex = 1;
         this._numAngle.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _lblAngle
         // 
         this._lblAngle.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblAngle.Location = new System.Drawing.Point(19, 28);
         this._lblAngle.Name = "_lblAngle";
         this._lblAngle.Size = new System.Drawing.Size(120, 26);
         this._lblAngle.TabIndex = 0;
         this._lblAngle.Text = "Angle";
         this._lblAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _rbHorizontal
         // 
         this._rbHorizontal.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._rbHorizontal.Location = new System.Drawing.Point(19, 157);
         this._rbHorizontal.Name = "_rbHorizontal";
         this._rbHorizontal.Size = new System.Drawing.Size(154, 28);
         this._rbHorizontal.TabIndex = 7;
         this._rbHorizontal.Text = "Horizontal";
         // 
         // _rbVertical
         // 
         this._rbVertical.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._rbVertical.Location = new System.Drawing.Point(19, 194);
         this._rbVertical.Name = "_rbVertical";
         this._rbVertical.Size = new System.Drawing.Size(154, 28);
         this._rbVertical.TabIndex = 8;
         this._rbVertical.Text = "Vertical";
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnCancel.Location = new System.Drawing.Point(348, 58);
         this._btnCancel.Name = "_btnCancel";
         this._btnCancel.Size = new System.Drawing.Size(90, 27);
         this._btnCancel.TabIndex = 2;
         this._btnCancel.Text = "Cancel";
         // 
         // _btnOk
         // 
         this._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnOk.Location = new System.Drawing.Point(348, 21);
         this._btnOk.Name = "_btnOk";
         this._btnOk.Size = new System.Drawing.Size(90, 27);
         this._btnOk.TabIndex = 1;
         this._btnOk.Text = "OK";
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // ShearDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(450, 259);
         this.Controls.Add(this._gb);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "ShearDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Shear";
         this.Load += new System.EventHandler(this.ShearDialog_Load);
         this._gb.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this._numAngle)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox _gb;
      private System.Windows.Forms.Label _lblDirection;
      private System.Windows.Forms.GroupBox _gbDirection;
      private System.Windows.Forms.Button _btnFillColor;
      private System.Windows.Forms.Panel _pnlFillColor;
      private System.Windows.Forms.Label _lblFillColor;
      private System.Windows.Forms.NumericUpDown _numAngle;
      private System.Windows.Forms.Label _lblAngle;
      private System.Windows.Forms.RadioButton _rbHorizontal;
      private System.Windows.Forms.RadioButton _rbVertical;
      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
   }
}