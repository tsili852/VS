namespace MainDemo
{
   partial class InvertedTextDialog
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
         this._lblUnitsHeight = new System.Windows.Forms.Label();
         this._lblUnitsWidth = new System.Windows.Forms.Label();
         this._numMaxBlackPercent = new System.Windows.Forms.NumericUpDown();
         this._lblMaxBlackPercent = new System.Windows.Forms.Label();
         this._gbOptions = new System.Windows.Forms.GroupBox();
         this._lblUnits = new System.Windows.Forms.Label();
         this._lblMinBlackPercent = new System.Windows.Forms.Label();
         this._numMinBlackPercent = new System.Windows.Forms.NumericUpDown();
         this._lblMinInvertHeight = new System.Windows.Forms.Label();
         this._numMinInvertHeight = new System.Windows.Forms.NumericUpDown();
         this._lblMinInvertWidth = new System.Windows.Forms.Label();
         this._numMinInvertWidth = new System.Windows.Forms.NumericUpDown();
         this._btnCancel = new System.Windows.Forms.Button();
         this._cbUseDiagonals = new System.Windows.Forms.CheckBox();
         this._cbImageUnchanged = new System.Windows.Forms.CheckBox();
         this._btnOk = new System.Windows.Forms.Button();
         this._cbUseDpi = new System.Windows.Forms.CheckBox();
         this._gbFlags = new System.Windows.Forms.GroupBox();
         ((System.ComponentModel.ISupportInitialize)(this._numMaxBlackPercent)).BeginInit();
         this._gbOptions.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._numMinBlackPercent)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._numMinInvertHeight)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._numMinInvertWidth)).BeginInit();
         this._gbFlags.SuspendLayout();
         this.SuspendLayout();
         // 
         // _lblUnitsHeight
         // 
         this._lblUnitsHeight.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblUnitsHeight.Location = new System.Drawing.Point(326, 102);
         this._lblUnitsHeight.Name = "_lblUnitsHeight";
         this._lblUnitsHeight.Size = new System.Drawing.Size(77, 26);
         this._lblUnitsHeight.TabIndex = 6;
         this._lblUnitsHeight.Text = "Pixels";
         this._lblUnitsHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblUnitsWidth
         // 
         this._lblUnitsWidth.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblUnitsWidth.Location = new System.Drawing.Point(326, 65);
         this._lblUnitsWidth.Name = "_lblUnitsWidth";
         this._lblUnitsWidth.Size = new System.Drawing.Size(77, 26);
         this._lblUnitsWidth.TabIndex = 3;
         this._lblUnitsWidth.Text = "Pixels";
         this._lblUnitsWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _numMaxBlackPercent
         // 
         this._numMaxBlackPercent.Location = new System.Drawing.Point(182, 175);
         this._numMaxBlackPercent.Name = "_numMaxBlackPercent";
         this._numMaxBlackPercent.Size = new System.Drawing.Size(135, 22);
         this._numMaxBlackPercent.TabIndex = 10;
         this._numMaxBlackPercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numMaxBlackPercent.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _lblMaxBlackPercent
         // 
         this._lblMaxBlackPercent.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblMaxBlackPercent.Location = new System.Drawing.Point(19, 175);
         this._lblMaxBlackPercent.Name = "_lblMaxBlackPercent";
         this._lblMaxBlackPercent.Size = new System.Drawing.Size(154, 27);
         this._lblMaxBlackPercent.TabIndex = 9;
         this._lblMaxBlackPercent.Text = "Maximum Black Percent";
         this._lblMaxBlackPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _gbOptions
         // 
         this._gbOptions.Controls.Add(this._lblUnits);
         this._gbOptions.Controls.Add(this._lblUnitsHeight);
         this._gbOptions.Controls.Add(this._lblUnitsWidth);
         this._gbOptions.Controls.Add(this._lblMaxBlackPercent);
         this._gbOptions.Controls.Add(this._numMaxBlackPercent);
         this._gbOptions.Controls.Add(this._lblMinBlackPercent);
         this._gbOptions.Controls.Add(this._numMinBlackPercent);
         this._gbOptions.Controls.Add(this._lblMinInvertHeight);
         this._gbOptions.Controls.Add(this._numMinInvertHeight);
         this._gbOptions.Controls.Add(this._lblMinInvertWidth);
         this._gbOptions.Controls.Add(this._numMinInvertWidth);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbOptions.Location = new System.Drawing.Point(12, 123);
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.Size = new System.Drawing.Size(460, 222);
         this._gbOptions.TabIndex = 1;
         this._gbOptions.TabStop = false;
         this._gbOptions.Text = "Options";
         // 
         // _lblUnits
         // 
         this._lblUnits.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblUnits.Location = new System.Drawing.Point(19, 28);
         this._lblUnits.Name = "_lblUnits";
         this._lblUnits.Size = new System.Drawing.Size(298, 26);
         this._lblUnits.TabIndex = 0;
         this._lblUnits.Text = "Units of 1/1000 inch means 1000 is an inch.";
         // 
         // _lblMinBlackPercent
         // 
         this._lblMinBlackPercent.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblMinBlackPercent.Location = new System.Drawing.Point(19, 138);
         this._lblMinBlackPercent.Name = "_lblMinBlackPercent";
         this._lblMinBlackPercent.Size = new System.Drawing.Size(154, 27);
         this._lblMinBlackPercent.TabIndex = 7;
         this._lblMinBlackPercent.Text = "Minimum Black Percent";
         this._lblMinBlackPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _numMinBlackPercent
         // 
         this._numMinBlackPercent.Location = new System.Drawing.Point(182, 138);
         this._numMinBlackPercent.Name = "_numMinBlackPercent";
         this._numMinBlackPercent.Size = new System.Drawing.Size(135, 22);
         this._numMinBlackPercent.TabIndex = 8;
         this._numMinBlackPercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numMinBlackPercent.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _lblMinInvertHeight
         // 
         this._lblMinInvertHeight.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblMinInvertHeight.Location = new System.Drawing.Point(19, 102);
         this._lblMinInvertHeight.Name = "_lblMinInvertHeight";
         this._lblMinInvertHeight.Size = new System.Drawing.Size(154, 26);
         this._lblMinInvertHeight.TabIndex = 4;
         this._lblMinInvertHeight.Text = "Minimum Invert Height";
         this._lblMinInvertHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _numMinInvertHeight
         // 
         this._numMinInvertHeight.Location = new System.Drawing.Point(182, 102);
         this._numMinInvertHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this._numMinInvertHeight.Name = "_numMinInvertHeight";
         this._numMinInvertHeight.Size = new System.Drawing.Size(135, 22);
         this._numMinInvertHeight.TabIndex = 5;
         this._numMinInvertHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numMinInvertHeight.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _lblMinInvertWidth
         // 
         this._lblMinInvertWidth.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblMinInvertWidth.Location = new System.Drawing.Point(19, 65);
         this._lblMinInvertWidth.Name = "_lblMinInvertWidth";
         this._lblMinInvertWidth.Size = new System.Drawing.Size(154, 26);
         this._lblMinInvertWidth.TabIndex = 1;
         this._lblMinInvertWidth.Text = "Minimum Invert Width";
         this._lblMinInvertWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _numMinInvertWidth
         // 
         this._numMinInvertWidth.Location = new System.Drawing.Point(182, 65);
         this._numMinInvertWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this._numMinInvertWidth.Name = "_numMinInvertWidth";
         this._numMinInvertWidth.Size = new System.Drawing.Size(135, 22);
         this._numMinInvertWidth.TabIndex = 2;
         this._numMinInvertWidth.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnCancel.Location = new System.Drawing.Point(386, 58);
         this._btnCancel.Name = "_btnCancel";
         this._btnCancel.Size = new System.Drawing.Size(86, 27);
         this._btnCancel.TabIndex = 3;
         this._btnCancel.Text = "Cancel";
         // 
         // _cbUseDiagonals
         // 
         this._cbUseDiagonals.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._cbUseDiagonals.Location = new System.Drawing.Point(19, 60);
         this._cbUseDiagonals.Name = "_cbUseDiagonals";
         this._cbUseDiagonals.Size = new System.Drawing.Size(144, 28);
         this._cbUseDiagonals.TabIndex = 2;
         this._cbUseDiagonals.Text = "Use Diagonals";
         // 
         // _cbImageUnchanged
         // 
         this._cbImageUnchanged.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._cbImageUnchanged.Location = new System.Drawing.Point(19, 28);
         this._cbImageUnchanged.Name = "_cbImageUnchanged";
         this._cbImageUnchanged.Size = new System.Drawing.Size(144, 27);
         this._cbImageUnchanged.TabIndex = 0;
         this._cbImageUnchanged.Text = "Image Unchanged";
         // 
         // _btnOk
         // 
         this._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnOk.Location = new System.Drawing.Point(386, 21);
         this._btnOk.Name = "_btnOk";
         this._btnOk.Size = new System.Drawing.Size(86, 27);
         this._btnOk.TabIndex = 2;
         this._btnOk.Text = "OK";
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // _cbUseDpi
         // 
         this._cbUseDpi.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._cbUseDpi.Location = new System.Drawing.Point(182, 28);
         this._cbUseDpi.Name = "_cbUseDpi";
         this._cbUseDpi.Size = new System.Drawing.Size(144, 27);
         this._cbUseDpi.TabIndex = 1;
         this._cbUseDpi.Text = "Use Dpi";
         this._cbUseDpi.CheckedChanged += new System.EventHandler(this._cbUseDpi_CheckedChanged);
         // 
         // _gbFlags
         // 
         this._gbFlags.Controls.Add(this._cbUseDpi);
         this._gbFlags.Controls.Add(this._cbUseDiagonals);
         this._gbFlags.Controls.Add(this._cbImageUnchanged);
         this._gbFlags.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbFlags.Location = new System.Drawing.Point(12, 12);
         this._gbFlags.Name = "_gbFlags";
         this._gbFlags.Size = new System.Drawing.Size(345, 102);
         this._gbFlags.TabIndex = 0;
         this._gbFlags.TabStop = false;
         this._gbFlags.Text = "Flags";
         // 
         // InvertedTextDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(487, 356);
         this.Controls.Add(this._gbOptions);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.Controls.Add(this._gbFlags);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "InvertedTextDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Inverted Text";
         this.Load += new System.EventHandler(this.InvertedTextDialog_Load);
         ((System.ComponentModel.ISupportInitialize)(this._numMaxBlackPercent)).EndInit();
         this._gbOptions.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this._numMinBlackPercent)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._numMinInvertHeight)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._numMinInvertWidth)).EndInit();
         this._gbFlags.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label _lblUnitsHeight;
      private System.Windows.Forms.Label _lblUnitsWidth;
      private System.Windows.Forms.NumericUpDown _numMaxBlackPercent;
      private System.Windows.Forms.Label _lblMaxBlackPercent;
      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.Label _lblUnits;
      private System.Windows.Forms.Label _lblMinBlackPercent;
      private System.Windows.Forms.NumericUpDown _numMinBlackPercent;
      private System.Windows.Forms.Label _lblMinInvertHeight;
      private System.Windows.Forms.NumericUpDown _numMinInvertHeight;
      private System.Windows.Forms.Label _lblMinInvertWidth;
      private System.Windows.Forms.NumericUpDown _numMinInvertWidth;
      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.CheckBox _cbUseDiagonals;
      private System.Windows.Forms.CheckBox _cbImageUnchanged;
      private System.Windows.Forms.Button _btnOk;
      private System.Windows.Forms.CheckBox _cbUseDpi;
      private System.Windows.Forms.GroupBox _gbFlags;
   }
}