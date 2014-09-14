namespace MainDemo
{
   partial class BorderRemoveDialog
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
         this._gbFlags = new System.Windows.Forms.GroupBox();
         this._cbUseVariance = new System.Windows.Forms.CheckBox();
         this._cbImageUnchanged = new System.Windows.Forms.CheckBox();
         this._gbBorder = new System.Windows.Forms.GroupBox();
         this._cbBottom = new System.Windows.Forms.CheckBox();
         this._cbRight = new System.Windows.Forms.CheckBox();
         this._cbTop = new System.Windows.Forms.CheckBox();
         this._cbLeft = new System.Windows.Forms.CheckBox();
         this._gbOptions = new System.Windows.Forms.GroupBox();
         this._numWhiteNoiseLength = new System.Windows.Forms.NumericUpDown();
         this._numVariance = new System.Windows.Forms.NumericUpDown();
         this._numPercent = new System.Windows.Forms.NumericUpDown();
         this._lblWhiteNoiseLength = new System.Windows.Forms.Label();
         this._lblVariance = new System.Windows.Forms.Label();
         this._lblPercent = new System.Windows.Forms.Label();
         this._gbFlags.SuspendLayout();
         this._gbBorder.SuspendLayout();
         this._gbOptions.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._numWhiteNoiseLength)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._numVariance)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._numPercent)).BeginInit();
         this.SuspendLayout();
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnCancel.Location = new System.Drawing.Point(346, 55);
         this._btnCancel.Name = "_btnCancel";
         this._btnCancel.Size = new System.Drawing.Size(90, 27);
         this._btnCancel.TabIndex = 4;
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
         this._btnOk.TabIndex = 3;
         this._btnOk.Text = "OK";
         this._btnOk.UseVisualStyleBackColor = true;
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // _gbFlags
         // 
         this._gbFlags.Controls.Add(this._cbUseVariance);
         this._gbFlags.Controls.Add(this._cbImageUnchanged);
         this._gbFlags.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbFlags.Location = new System.Drawing.Point(10, 9);
         this._gbFlags.Name = "_gbFlags";
         this._gbFlags.Size = new System.Drawing.Size(182, 157);
         this._gbFlags.TabIndex = 0;
         this._gbFlags.TabStop = false;
         this._gbFlags.Text = "Flags";
         // 
         // _cbUseVariance
         // 
         this._cbUseVariance.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._cbUseVariance.Location = new System.Drawing.Point(19, 60);
         this._cbUseVariance.Name = "_cbUseVariance";
         this._cbUseVariance.Size = new System.Drawing.Size(144, 28);
         this._cbUseVariance.TabIndex = 1;
         this._cbUseVariance.Text = "Use Variance";
         this._cbUseVariance.UseVisualStyleBackColor = true;
         // 
         // _cbImageUnchanged
         // 
         this._cbImageUnchanged.AutoSize = true;
         this._cbImageUnchanged.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._cbImageUnchanged.Location = new System.Drawing.Point(19, 28);
         this._cbImageUnchanged.Name = "_cbImageUnchanged";
         this._cbImageUnchanged.Size = new System.Drawing.Size(148, 22);
         this._cbImageUnchanged.TabIndex = 0;
         this._cbImageUnchanged.Text = "Image Unchanged";
         this._cbImageUnchanged.UseVisualStyleBackColor = true;
         // 
         // _gbBorder
         // 
         this._gbBorder.Controls.Add(this._cbBottom);
         this._gbBorder.Controls.Add(this._cbRight);
         this._gbBorder.Controls.Add(this._cbTop);
         this._gbBorder.Controls.Add(this._cbLeft);
         this._gbBorder.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbBorder.Location = new System.Drawing.Point(202, 9);
         this._gbBorder.Name = "_gbBorder";
         this._gbBorder.Size = new System.Drawing.Size(115, 157);
         this._gbBorder.TabIndex = 1;
         this._gbBorder.TabStop = false;
         this._gbBorder.Text = "Border";
         // 
         // _cbBottom
         // 
         this._cbBottom.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._cbBottom.Location = new System.Drawing.Point(19, 125);
         this._cbBottom.Name = "_cbBottom";
         this._cbBottom.Size = new System.Drawing.Size(87, 27);
         this._cbBottom.TabIndex = 3;
         this._cbBottom.Text = "Bottom";
         this._cbBottom.UseVisualStyleBackColor = true;
         // 
         // _cbRight
         // 
         this._cbRight.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._cbRight.Location = new System.Drawing.Point(19, 92);
         this._cbRight.Name = "_cbRight";
         this._cbRight.Size = new System.Drawing.Size(87, 27);
         this._cbRight.TabIndex = 2;
         this._cbRight.Text = "Right";
         this._cbRight.UseVisualStyleBackColor = true;
         // 
         // _cbTop
         // 
         this._cbTop.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._cbTop.Location = new System.Drawing.Point(19, 60);
         this._cbTop.Name = "_cbTop";
         this._cbTop.Size = new System.Drawing.Size(87, 27);
         this._cbTop.TabIndex = 1;
         this._cbTop.Text = "Top";
         this._cbTop.UseVisualStyleBackColor = true;
         // 
         // _cbLeft
         // 
         this._cbLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._cbLeft.Location = new System.Drawing.Point(19, 28);
         this._cbLeft.Name = "_cbLeft";
         this._cbLeft.Size = new System.Drawing.Size(87, 27);
         this._cbLeft.TabIndex = 0;
         this._cbLeft.Text = "Left";
         this._cbLeft.UseVisualStyleBackColor = true;
         // 
         // _gbOptions
         // 
         this._gbOptions.Controls.Add(this._numWhiteNoiseLength);
         this._gbOptions.Controls.Add(this._numVariance);
         this._gbOptions.Controls.Add(this._numPercent);
         this._gbOptions.Controls.Add(this._lblWhiteNoiseLength);
         this._gbOptions.Controls.Add(this._lblVariance);
         this._gbOptions.Controls.Add(this._lblPercent);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbOptions.Location = new System.Drawing.Point(10, 175);
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.Size = new System.Drawing.Size(307, 139);
         this._gbOptions.TabIndex = 2;
         this._gbOptions.TabStop = false;
         this._gbOptions.Text = "Options";
         // 
         // _numWhiteNoiseLength
         // 
         this._numWhiteNoiseLength.Location = new System.Drawing.Point(160, 104);
         this._numWhiteNoiseLength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
         this._numWhiteNoiseLength.Name = "_numWhiteNoiseLength";
         this._numWhiteNoiseLength.Size = new System.Drawing.Size(119, 22);
         this._numWhiteNoiseLength.TabIndex = 5;
         this._numWhiteNoiseLength.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _numVariance
         // 
         this._numVariance.Location = new System.Drawing.Point(160, 65);
         this._numVariance.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
         this._numVariance.Name = "_numVariance";
         this._numVariance.Size = new System.Drawing.Size(119, 22);
         this._numVariance.TabIndex = 3;
         this._numVariance.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _numPercent
         // 
         this._numPercent.Location = new System.Drawing.Point(160, 28);
         this._numPercent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numPercent.Name = "_numPercent";
         this._numPercent.Size = new System.Drawing.Size(119, 22);
         this._numPercent.TabIndex = 1;
         this._numPercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numPercent.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _lblWhiteNoiseLength
         // 
         this._lblWhiteNoiseLength.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblWhiteNoiseLength.Location = new System.Drawing.Point(14, 102);
         this._lblWhiteNoiseLength.Name = "_lblWhiteNoiseLength";
         this._lblWhiteNoiseLength.Size = new System.Drawing.Size(142, 26);
         this._lblWhiteNoiseLength.TabIndex = 4;
         this._lblWhiteNoiseLength.Text = "White Noise Length";
         this._lblWhiteNoiseLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblVariance
         // 
         this._lblVariance.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblVariance.Location = new System.Drawing.Point(14, 65);
         this._lblVariance.Name = "_lblVariance";
         this._lblVariance.Size = new System.Drawing.Size(125, 26);
         this._lblVariance.TabIndex = 2;
         this._lblVariance.Text = "Variance";
         this._lblVariance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblPercent
         // 
         this._lblPercent.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblPercent.Location = new System.Drawing.Point(14, 28);
         this._lblPercent.Name = "_lblPercent";
         this._lblPercent.Size = new System.Drawing.Size(125, 26);
         this._lblPercent.TabIndex = 0;
         this._lblPercent.Text = "Percent";
         this._lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // BorderRemoveDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(443, 326);
         this.Controls.Add(this._gbOptions);
         this.Controls.Add(this._gbBorder);
         this.Controls.Add(this._gbFlags);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "BorderRemoveDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Border Remove";
         this.Load += new System.EventHandler(this.BorderRemoveDialog_Load);
         this._gbFlags.ResumeLayout(false);
         this._gbFlags.PerformLayout();
         this._gbBorder.ResumeLayout(false);
         this._gbOptions.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this._numWhiteNoiseLength)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._numVariance)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._numPercent)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
      private System.Windows.Forms.GroupBox _gbFlags;
      private System.Windows.Forms.GroupBox _gbBorder;
      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.CheckBox _cbUseVariance;
      private System.Windows.Forms.CheckBox _cbImageUnchanged;
      private System.Windows.Forms.CheckBox _cbBottom;
      private System.Windows.Forms.CheckBox _cbRight;
      private System.Windows.Forms.CheckBox _cbTop;
      private System.Windows.Forms.CheckBox _cbLeft;
      private System.Windows.Forms.Label _lblPercent;
      private System.Windows.Forms.NumericUpDown _numWhiteNoiseLength;
      private System.Windows.Forms.NumericUpDown _numVariance;
      private System.Windows.Forms.NumericUpDown _numPercent;
      private System.Windows.Forms.Label _lblWhiteNoiseLength;
      private System.Windows.Forms.Label _lblVariance;
   }
}