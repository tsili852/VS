namespace MainDemo
{
   partial class EdgeDetectorDialog
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
         this._cbFilter = new System.Windows.Forms.ComboBox();
         this._numThreshold = new System.Windows.Forms.NumericUpDown();
         this._lblFilter = new System.Windows.Forms.Label();
         this._lblThreshold = new System.Windows.Forms.Label();
         this._gbOptions.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._numThreshold)).BeginInit();
         this.SuspendLayout();
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnCancel.Location = new System.Drawing.Point(394, 55);
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
         this._btnOk.Location = new System.Drawing.Point(394, 18);
         this._btnOk.Name = "_btnOk";
         this._btnOk.Size = new System.Drawing.Size(90, 27);
         this._btnOk.TabIndex = 1;
         this._btnOk.Text = "OK";
         this._btnOk.UseVisualStyleBackColor = true;
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // _gbOptions
         // 
         this._gbOptions.Controls.Add(this._cbFilter);
         this._gbOptions.Controls.Add(this._numThreshold);
         this._gbOptions.Controls.Add(this._lblFilter);
         this._gbOptions.Controls.Add(this._lblThreshold);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbOptions.Location = new System.Drawing.Point(10, 9);
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.Size = new System.Drawing.Size(364, 93);
         this._gbOptions.TabIndex = 0;
         this._gbOptions.TabStop = false;
         // 
         // _cbFilter
         // 
         this._cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._cbFilter.FormattingEnabled = true;
         this._cbFilter.Location = new System.Drawing.Point(115, 55);
         this._cbFilter.Name = "_cbFilter";
         this._cbFilter.Size = new System.Drawing.Size(231, 24);
         this._cbFilter.TabIndex = 3;
         // 
         // _numThreshold
         // 
         this._numThreshold.Location = new System.Drawing.Point(115, 18);
         this._numThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
         this._numThreshold.Name = "_numThreshold";
         this._numThreshold.Size = new System.Drawing.Size(144, 22);
         this._numThreshold.TabIndex = 1;
         this._numThreshold.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _lblFilter
         // 
         this._lblFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblFilter.Location = new System.Drawing.Point(19, 55);
         this._lblFilter.Name = "_lblFilter";
         this._lblFilter.Size = new System.Drawing.Size(77, 27);
         this._lblFilter.TabIndex = 2;
         this._lblFilter.Text = "Filter";
         this._lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblThreshold
         // 
         this._lblThreshold.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblThreshold.Location = new System.Drawing.Point(19, 18);
         this._lblThreshold.Name = "_lblThreshold";
         this._lblThreshold.Size = new System.Drawing.Size(77, 27);
         this._lblThreshold.TabIndex = 0;
         this._lblThreshold.Text = "Threshold";
         this._lblThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // EdgeDetectorDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(501, 120);
         this.Controls.Add(this._gbOptions);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "EdgeDetectorDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Edge Detector";
         this.Load += new System.EventHandler(this.EdgeDetectorDialog_Load);
         this._gbOptions.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this._numThreshold)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.Label _lblThreshold;
      private System.Windows.Forms.Label _lblFilter;
      private System.Windows.Forms.NumericUpDown _numThreshold;
      private System.Windows.Forms.ComboBox _cbFilter;
   }
}