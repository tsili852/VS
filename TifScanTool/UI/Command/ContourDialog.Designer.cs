namespace MainDemo
{
   partial class ContourDialog
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
         this._numMaximumError = new System.Windows.Forms.NumericUpDown();
         this._numDeltaDirection = new System.Windows.Forms.NumericUpDown();
         this._numThreshold = new System.Windows.Forms.NumericUpDown();
         this._lblType = new System.Windows.Forms.Label();
         this._lblMaximumError = new System.Windows.Forms.Label();
         this._lblDeltaDirection = new System.Windows.Forms.Label();
         this._lblThreshold = new System.Windows.Forms.Label();
         this._gbOptions.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._numMaximumError)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._numDeltaDirection)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._numThreshold)).BeginInit();
         this.SuspendLayout();
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnCancel.Location = new System.Drawing.Point(365, 55);
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
         this._btnOk.Location = new System.Drawing.Point(365, 18);
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
         this._gbOptions.Controls.Add(this._numMaximumError);
         this._gbOptions.Controls.Add(this._numDeltaDirection);
         this._gbOptions.Controls.Add(this._numThreshold);
         this._gbOptions.Controls.Add(this._lblType);
         this._gbOptions.Controls.Add(this._lblMaximumError);
         this._gbOptions.Controls.Add(this._lblDeltaDirection);
         this._gbOptions.Controls.Add(this._lblThreshold);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbOptions.Location = new System.Drawing.Point(10, 9);
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.Size = new System.Drawing.Size(326, 176);
         this._gbOptions.TabIndex = 0;
         this._gbOptions.TabStop = false;
         // 
         // _cbType
         // 
         this._cbType.FormattingEnabled = true;
         this._cbType.Location = new System.Drawing.Point(134, 129);
         this._cbType.Name = "_cbType";
         this._cbType.Size = new System.Drawing.Size(173, 24);
         this._cbType.TabIndex = 7;
         this._cbType.SelectedIndexChanged += new System.EventHandler(this._cbType_SelectedIndexChanged);
         // 
         // _numMaximumError
         // 
         this._numMaximumError.Location = new System.Drawing.Point(134, 92);
         this._numMaximumError.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
         this._numMaximumError.Name = "_numMaximumError";
         this._numMaximumError.Size = new System.Drawing.Size(173, 22);
         this._numMaximumError.TabIndex = 5;
         this._numMaximumError.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numMaximumError.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _numDeltaDirection
         // 
         this._numDeltaDirection.Location = new System.Drawing.Point(134, 55);
         this._numDeltaDirection.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
         this._numDeltaDirection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numDeltaDirection.Name = "_numDeltaDirection";
         this._numDeltaDirection.Size = new System.Drawing.Size(173, 22);
         this._numDeltaDirection.TabIndex = 3;
         this._numDeltaDirection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numDeltaDirection.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _numThreshold
         // 
         this._numThreshold.Location = new System.Drawing.Point(134, 18);
         this._numThreshold.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
         this._numThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numThreshold.Name = "_numThreshold";
         this._numThreshold.Size = new System.Drawing.Size(173, 22);
         this._numThreshold.TabIndex = 1;
         this._numThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numThreshold.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _lblType
         // 
         this._lblType.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblType.Location = new System.Drawing.Point(19, 129);
         this._lblType.Name = "_lblType";
         this._lblType.Size = new System.Drawing.Size(106, 27);
         this._lblType.TabIndex = 6;
         this._lblType.Text = "Type";
         this._lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblMaximumError
         // 
         this._lblMaximumError.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblMaximumError.Location = new System.Drawing.Point(19, 92);
         this._lblMaximumError.Name = "_lblMaximumError";
         this._lblMaximumError.Size = new System.Drawing.Size(106, 27);
         this._lblMaximumError.TabIndex = 4;
         this._lblMaximumError.Text = "Maximum Error";
         this._lblMaximumError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblDeltaDirection
         // 
         this._lblDeltaDirection.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblDeltaDirection.Location = new System.Drawing.Point(19, 55);
         this._lblDeltaDirection.Name = "_lblDeltaDirection";
         this._lblDeltaDirection.Size = new System.Drawing.Size(106, 27);
         this._lblDeltaDirection.TabIndex = 2;
         this._lblDeltaDirection.Text = "Delta Direction";
         this._lblDeltaDirection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblThreshold
         // 
         this._lblThreshold.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblThreshold.Location = new System.Drawing.Point(19, 18);
         this._lblThreshold.Name = "_lblThreshold";
         this._lblThreshold.Size = new System.Drawing.Size(106, 27);
         this._lblThreshold.TabIndex = 0;
         this._lblThreshold.Text = "Threshold";
         this._lblThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // ContourDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(470, 201);
         this.Controls.Add(this._gbOptions);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "ContourDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Contour";
         this.Load += new System.EventHandler(this.ContourDialog_Load);
         this._gbOptions.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this._numMaximumError)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._numDeltaDirection)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._numThreshold)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.Label _lblThreshold;
      private System.Windows.Forms.Label _lblType;
      private System.Windows.Forms.Label _lblMaximumError;
      private System.Windows.Forms.Label _lblDeltaDirection;
      private System.Windows.Forms.NumericUpDown _numMaximumError;
      private System.Windows.Forms.NumericUpDown _numDeltaDirection;
      private System.Windows.Forms.NumericUpDown _numThreshold;
      private System.Windows.Forms.ComboBox _cbType;
   }
}