namespace MainDemo
{
   partial class CropDialog
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
         this._numHeight = new System.Windows.Forms.NumericUpDown();
         this._numWidth = new System.Windows.Forms.NumericUpDown();
         this._numTop = new System.Windows.Forms.NumericUpDown();
         this._numLeft = new System.Windows.Forms.NumericUpDown();
         this._lblHeight = new System.Windows.Forms.Label();
         this._lblWidth = new System.Windows.Forms.Label();
         this._lblTop = new System.Windows.Forms.Label();
         this._lblLeft = new System.Windows.Forms.Label();
         this._gbOptions.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._numHeight)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._numWidth)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._numTop)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._numLeft)).BeginInit();
         this.SuspendLayout();
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnCancel.Location = new System.Drawing.Point(317, 55);
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
         this._btnOk.Location = new System.Drawing.Point(317, 18);
         this._btnOk.Name = "_btnOk";
         this._btnOk.Size = new System.Drawing.Size(90, 27);
         this._btnOk.TabIndex = 1;
         this._btnOk.Text = "OK";
         this._btnOk.UseVisualStyleBackColor = true;
         this._btnOk.Click +=new System.EventHandler(_btnOk_Click);
         // 
         // _gbOptions
         // 
         this._gbOptions.Controls.Add(this._numHeight);
         this._gbOptions.Controls.Add(this._numWidth);
         this._gbOptions.Controls.Add(this._numTop);
         this._gbOptions.Controls.Add(this._numLeft);
         this._gbOptions.Controls.Add(this._lblHeight);
         this._gbOptions.Controls.Add(this._lblWidth);
         this._gbOptions.Controls.Add(this._lblTop);
         this._gbOptions.Controls.Add(this._lblLeft);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbOptions.Location = new System.Drawing.Point(10, 9);
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.Size = new System.Drawing.Size(278, 166);
         this._gbOptions.TabIndex = 0;
         this._gbOptions.TabStop = false;
         // 
         // _numHeight
         // 
         this._numHeight.Location = new System.Drawing.Point(115, 129);
         this._numHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this._numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numHeight.Name = "_numHeight";
         this._numHeight.Size = new System.Drawing.Size(144, 22);
         this._numHeight.TabIndex = 7;
         this._numHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numHeight.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _numWidth
         // 
         this._numWidth.Location = new System.Drawing.Point(115, 92);
         this._numWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this._numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numWidth.Name = "_numWidth";
         this._numWidth.Size = new System.Drawing.Size(144, 22);
         this._numWidth.TabIndex = 5;
         this._numWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numWidth.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _numTop
         // 
         this._numTop.Location = new System.Drawing.Point(115, 55);
         this._numTop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this._numTop.Name = "_numTop";
         this._numTop.Size = new System.Drawing.Size(144, 22);
         this._numTop.TabIndex = 3;
         this._numTop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numTop.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _numLeft
         // 
         this._numLeft.Location = new System.Drawing.Point(115, 18);
         this._numLeft.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this._numLeft.Name = "_numLeft";
         this._numLeft.Size = new System.Drawing.Size(144, 22);
         this._numLeft.TabIndex = 1;
         this._numLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numLeft.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _lblHeight
         // 
         this._lblHeight.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblHeight.Location = new System.Drawing.Point(19, 129);
         this._lblHeight.Name = "_lblHeight";
         this._lblHeight.Size = new System.Drawing.Size(77, 27);
         this._lblHeight.TabIndex = 6;
         this._lblHeight.Text = "Height";
         this._lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblWidth
         // 
         this._lblWidth.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblWidth.Location = new System.Drawing.Point(19, 92);
         this._lblWidth.Name = "_lblWidth";
         this._lblWidth.Size = new System.Drawing.Size(77, 27);
         this._lblWidth.TabIndex = 4;
         this._lblWidth.Text = "Width";
         this._lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblTop
         // 
         this._lblTop.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblTop.Location = new System.Drawing.Point(19, 55);
         this._lblTop.Name = "_lblTop";
         this._lblTop.Size = new System.Drawing.Size(77, 27);
         this._lblTop.TabIndex = 2;
         this._lblTop.Text = "Top";
         this._lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblLeft
         // 
         this._lblLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblLeft.Location = new System.Drawing.Point(19, 18);
         this._lblLeft.Name = "_lblLeft";
         this._lblLeft.Size = new System.Drawing.Size(77, 27);
         this._lblLeft.TabIndex = 0;
         this._lblLeft.Text = "Left";
         this._lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // CropDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(420, 190);
         this.Controls.Add(this._gbOptions);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "CropDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Crop (Trim)";
         this.Load += new System.EventHandler(this.CropDialog_Load);
         this._gbOptions.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this._numHeight)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._numWidth)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._numTop)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._numLeft)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.NumericUpDown _numWidth;
      private System.Windows.Forms.NumericUpDown _numTop;
      private System.Windows.Forms.NumericUpDown _numLeft;
      private System.Windows.Forms.Label _lblHeight;
      private System.Windows.Forms.Label _lblWidth;
      private System.Windows.Forms.Label _lblTop;
      private System.Windows.Forms.Label _lblLeft;
      private System.Windows.Forms.NumericUpDown _numHeight;
   }
}