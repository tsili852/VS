namespace MainDemo
{
   partial class HalftoneDialog
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
         this._btnCancel = new System.Windows.Forms.Button();
         this._btnOk = new System.Windows.Forms.Button();
         this._gbOptions = new System.Windows.Forms.GroupBox();
         this._cbType = new System.Windows.Forms.ComboBox();
         this._numDimension = new System.Windows.Forms.NumericUpDown();
         this._numAngle = new System.Windows.Forms.NumericUpDown();
         this._lblDimension = new System.Windows.Forms.Label();
         this._lblAngle = new System.Windows.Forms.Label();
         this._lblType = new System.Windows.Forms.Label();
         this._gbOptions.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._numDimension)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._numAngle)).BeginInit();
         this.SuspendLayout();
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnCancel.Location = new System.Drawing.Point(346, 55);
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
         this._btnOk.Location = new System.Drawing.Point(346, 18);
         this._btnOk.Name = "_btnOk";
         this._btnOk.Size = new System.Drawing.Size(90, 27);
         this._btnOk.TabIndex = 1;
         this._btnOk.Text = "OK";
         this._btnOk.UseVisualStyleBackColor = true;
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // _gbOptions
         // 
         this._gbOptions.Controls.Add(this._cbType);
         this._gbOptions.Controls.Add(this._numDimension);
         this._gbOptions.Controls.Add(this._numAngle);
         this._gbOptions.Controls.Add(this._lblDimension);
         this._gbOptions.Controls.Add(this._lblAngle);
         this._gbOptions.Controls.Add(this._lblType);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbOptions.Location = new System.Drawing.Point(10, 9);
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.Size = new System.Drawing.Size(316, 139);
         this._gbOptions.TabIndex = 0;
         this._gbOptions.TabStop = false;
         // 
         // _cbType
         // 
         this._cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._cbType.FormattingEnabled = true;
         this._cbType.Location = new System.Drawing.Point(106, 28);
         this._cbType.Name = "_cbType";
         this._cbType.Size = new System.Drawing.Size(192, 24);
         this._cbType.TabIndex = 1;
         this._cbType.SelectedIndexChanged += new System.EventHandler(this._cbType_SelectedIndexChanged);
         // 
         // _numDimension
         // 
         this._numDimension.Location = new System.Drawing.Point(106, 102);
         this._numDimension.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this._numDimension.Name = "_numDimension";
         this._numDimension.Size = new System.Drawing.Size(105, 22);
         this._numDimension.TabIndex = 5;
         this._numDimension.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this._numDimension.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _numAngle
         // 
         this._numAngle.Location = new System.Drawing.Point(106, 65);
         this._numAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
         this._numAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
         this._numAngle.Name = "_numAngle";
         this._numAngle.Size = new System.Drawing.Size(105, 22);
         this._numAngle.TabIndex = 3;
         this._numAngle.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _lblDimension
         // 
         this._lblDimension.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblDimension.Location = new System.Drawing.Point(19, 102);
         this._lblDimension.Name = "_lblDimension";
         this._lblDimension.Size = new System.Drawing.Size(77, 26);
         this._lblDimension.TabIndex = 4;
         this._lblDimension.Text = "Dimension";
         this._lblDimension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblAngle
         // 
         this._lblAngle.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblAngle.Location = new System.Drawing.Point(19, 65);
         this._lblAngle.Name = "_lblAngle";
         this._lblAngle.Size = new System.Drawing.Size(77, 26);
         this._lblAngle.TabIndex = 2;
         this._lblAngle.Text = "Angle";
         this._lblAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblType
         // 
         this._lblType.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblType.Location = new System.Drawing.Point(19, 28);
         this._lblType.Name = "_lblType";
         this._lblType.Size = new System.Drawing.Size(77, 26);
         this._lblType.TabIndex = 0;
         this._lblType.Text = "Type";
         this._lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // HalftoneDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(452, 166);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.Controls.Add(this._gbOptions);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "HalftoneDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Halftone";
         this.Load += new System.EventHandler(this.HalftoneDialog_Load);
         this._gbOptions.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this._numDimension)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._numAngle)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.NumericUpDown _numDimension;
      private System.Windows.Forms.NumericUpDown _numAngle;
      private System.Windows.Forms.Label _lblDimension;
      private System.Windows.Forms.Label _lblAngle;
      private System.Windows.Forms.Label _lblType;
      private System.Windows.Forms.ComboBox _cbType;

   }
}