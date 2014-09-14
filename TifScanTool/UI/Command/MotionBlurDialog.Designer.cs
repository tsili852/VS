namespace MainDemo
{
   partial class MotionBlurDialog
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
         this._lblAngle = new System.Windows.Forms.Label();
         this._numDimension = new System.Windows.Forms.NumericUpDown();
         this._gbOptions = new System.Windows.Forms.GroupBox();
         this._cbUniDirectional = new System.Windows.Forms.CheckBox();
         this._numAngle = new System.Windows.Forms.NumericUpDown();
         this._lblDimension = new System.Windows.Forms.Label();
         this._btnCancel = new System.Windows.Forms.Button();
         this._btnOk = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this._numDimension)).BeginInit();
         this._gbOptions.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._numAngle)).BeginInit();
         this.SuspendLayout();
         // 
         // _lblAngle
         // 
         this._lblAngle.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblAngle.Location = new System.Drawing.Point(19, 55);
         this._lblAngle.Name = "_lblAngle";
         this._lblAngle.Size = new System.Drawing.Size(77, 27);
         this._lblAngle.TabIndex = 2;
         this._lblAngle.Text = "Angle";
         this._lblAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _numDimension
         // 
         this._numDimension.Location = new System.Drawing.Point(115, 18);
         this._numDimension.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
         this._numDimension.Name = "_numDimension";
         this._numDimension.Size = new System.Drawing.Size(144, 22);
         this._numDimension.TabIndex = 1;
         this._numDimension.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numDimension.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _gbOptions
         // 
         this._gbOptions.Controls.Add(this._cbUniDirectional);
         this._gbOptions.Controls.Add(this._numAngle);
         this._gbOptions.Controls.Add(this._lblAngle);
         this._gbOptions.Controls.Add(this._numDimension);
         this._gbOptions.Controls.Add(this._lblDimension);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbOptions.Location = new System.Drawing.Point(12, 12);
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.Size = new System.Drawing.Size(278, 129);
         this._gbOptions.TabIndex = 0;
         this._gbOptions.TabStop = false;
         // 
         // _cbUniDirectional
         // 
         this._cbUniDirectional.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._cbUniDirectional.Location = new System.Drawing.Point(19, 92);
         this._cbUniDirectional.Name = "_cbUniDirectional";
         this._cbUniDirectional.Size = new System.Drawing.Size(125, 28);
         this._cbUniDirectional.TabIndex = 4;
         this._cbUniDirectional.Text = "Uni Directional";
         // 
         // _numAngle
         // 
         this._numAngle.Location = new System.Drawing.Point(115, 55);
         this._numAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
         this._numAngle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numAngle.Name = "_numAngle";
         this._numAngle.Size = new System.Drawing.Size(144, 22);
         this._numAngle.TabIndex = 3;
         this._numAngle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numAngle.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _lblDimension
         // 
         this._lblDimension.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblDimension.Location = new System.Drawing.Point(19, 18);
         this._lblDimension.Name = "_lblDimension";
         this._lblDimension.Size = new System.Drawing.Size(77, 27);
         this._lblDimension.TabIndex = 0;
         this._lblDimension.Text = "Dimension";
         this._lblDimension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnCancel.Location = new System.Drawing.Point(319, 58);
         this._btnCancel.Name = "_btnCancel";
         this._btnCancel.Size = new System.Drawing.Size(90, 27);
         this._btnCancel.TabIndex = 2;
         this._btnCancel.Text = "Cancel";
         // 
         // _btnOk
         // 
         this._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnOk.Location = new System.Drawing.Point(319, 21);
         this._btnOk.Name = "_btnOk";
         this._btnOk.Size = new System.Drawing.Size(90, 27);
         this._btnOk.TabIndex = 1;
         this._btnOk.Text = "OK";
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // MotionBlurDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(424, 158);
         this.Controls.Add(this._gbOptions);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "MotionBlurDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Motion Blur";
         this.Load += new System.EventHandler(this.MotionBlurDialog_Load);
         ((System.ComponentModel.ISupportInitialize)(this._numDimension)).EndInit();
         this._gbOptions.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this._numAngle)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label _lblAngle;
      private System.Windows.Forms.NumericUpDown _numDimension;
      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.CheckBox _cbUniDirectional;
      private System.Windows.Forms.NumericUpDown _numAngle;
      private System.Windows.Forms.Label _lblDimension;
      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
   }
}