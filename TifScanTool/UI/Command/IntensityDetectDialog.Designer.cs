namespace MainDemo
{
   partial class IntensityDetectDialog
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
         this._lblMsg = new System.Windows.Forms.Label();
         this._gbOptions = new System.Windows.Forms.GroupBox();
         this._btnOutColor = new System.Windows.Forms.Button();
         this._btnInColor = new System.Windows.Forms.Button();
         this._cbChannel = new System.Windows.Forms.ComboBox();
         this._pnlOutColor = new System.Windows.Forms.Panel();
         this._pnlInColor = new System.Windows.Forms.Panel();
         this._numHigh = new System.Windows.Forms.NumericUpDown();
         this._numLow = new System.Windows.Forms.NumericUpDown();
         this._lblChannel = new System.Windows.Forms.Label();
         this._lblOutColor = new System.Windows.Forms.Label();
         this._lblInColor = new System.Windows.Forms.Label();
         this._lblHigh = new System.Windows.Forms.Label();
         this._lblLow = new System.Windows.Forms.Label();
         this._gbOptions.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._numHigh)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._numLow)).BeginInit();
         this.SuspendLayout();
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnCancel.Location = new System.Drawing.Point(317, 55);
         this._btnCancel.Name = "_btnCancel";
         this._btnCancel.Size = new System.Drawing.Size(90, 27);
         this._btnCancel.TabIndex = 3;
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
         this._btnOk.TabIndex = 2;
         this._btnOk.Text = "OK";
         this._btnOk.UseVisualStyleBackColor = true;
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // _lblMsg
         // 
         this._lblMsg.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblMsg.Location = new System.Drawing.Point(10, 258);
         this._lblMsg.Name = "_lblMsg";
         this._lblMsg.Size = new System.Drawing.Size(278, 27);
         this._lblMsg.TabIndex = 1;
         this._lblMsg.Text = "Low must be less than High.";
         // 
         // _gbOptions
         // 
         this._gbOptions.Controls.Add(this._btnOutColor);
         this._gbOptions.Controls.Add(this._btnInColor);
         this._gbOptions.Controls.Add(this._cbChannel);
         this._gbOptions.Controls.Add(this._pnlOutColor);
         this._gbOptions.Controls.Add(this._pnlInColor);
         this._gbOptions.Controls.Add(this._numHigh);
         this._gbOptions.Controls.Add(this._numLow);
         this._gbOptions.Controls.Add(this._lblChannel);
         this._gbOptions.Controls.Add(this._lblOutColor);
         this._gbOptions.Controls.Add(this._lblInColor);
         this._gbOptions.Controls.Add(this._lblHigh);
         this._gbOptions.Controls.Add(this._lblLow);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbOptions.Location = new System.Drawing.Point(10, 9);
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.Size = new System.Drawing.Size(278, 231);
         this._gbOptions.TabIndex = 0;
         this._gbOptions.TabStop = false;
         // 
         // _btnOutColor
         // 
         this._btnOutColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnOutColor.Location = new System.Drawing.Point(230, 138);
         this._btnOutColor.Name = "_btnOutColor";
         this._btnOutColor.Size = new System.Drawing.Size(29, 27);
         this._btnOutColor.TabIndex = 9;
         this._btnOutColor.Text = "...";
         this._btnOutColor.UseVisualStyleBackColor = true;
         this._btnOutColor.Click += new System.EventHandler(this._btnOutColor_Click);
         // 
         // _btnInColor
         // 
         this._btnInColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnInColor.Location = new System.Drawing.Point(230, 102);
         this._btnInColor.Name = "_btnInColor";
         this._btnInColor.Size = new System.Drawing.Size(29, 26);
         this._btnInColor.TabIndex = 6;
         this._btnInColor.Text = "...";
         this._btnInColor.UseVisualStyleBackColor = true;
         this._btnInColor.Click += new System.EventHandler(this._btnInColor_Click);
         // 
         // _cbChannel
         // 
         this._cbChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._cbChannel.FormattingEnabled = true;
         this._cbChannel.Location = new System.Drawing.Point(106, 185);
         this._cbChannel.Name = "_cbChannel";
         this._cbChannel.Size = new System.Drawing.Size(153, 24);
         this._cbChannel.TabIndex = 11;
         this._cbChannel.SelectedIndexChanged += new System.EventHandler(this._cbChannel_SelectedIndexChanged);
         // 
         // _pnlOutColor
         // 
         this._pnlOutColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this._pnlOutColor.Location = new System.Drawing.Point(106, 138);
         this._pnlOutColor.Name = "_pnlOutColor";
         this._pnlOutColor.Size = new System.Drawing.Size(124, 28);
         this._pnlOutColor.TabIndex = 8;
         this._pnlOutColor.Paint += new System.Windows.Forms.PaintEventHandler(this._pnlOutColor_Paint);
         // 
         // _pnlInColor
         // 
         this._pnlInColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this._pnlInColor.Location = new System.Drawing.Point(106, 102);
         this._pnlInColor.Name = "_pnlInColor";
         this._pnlInColor.Size = new System.Drawing.Size(124, 27);
         this._pnlInColor.TabIndex = 5;
         this._pnlInColor.Paint += new System.Windows.Forms.PaintEventHandler(this._pnlInColor_Paint);
         // 
         // _numHigh
         // 
         this._numHigh.Location = new System.Drawing.Point(106, 65);
         this._numHigh.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
         this._numHigh.Name = "_numHigh";
         this._numHigh.Size = new System.Drawing.Size(153, 22);
         this._numHigh.TabIndex = 3;
         this._numHigh.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _numLow
         // 
         this._numLow.Location = new System.Drawing.Point(106, 28);
         this._numLow.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
         this._numLow.Name = "_numLow";
         this._numLow.Size = new System.Drawing.Size(153, 22);
         this._numLow.TabIndex = 1;
         this._numLow.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _lblChannel
         // 
         this._lblChannel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblChannel.Location = new System.Drawing.Point(19, 185);
         this._lblChannel.Name = "_lblChannel";
         this._lblChannel.Size = new System.Drawing.Size(75, 26);
         this._lblChannel.TabIndex = 10;
         this._lblChannel.Text = "Blue Factor";
         this._lblChannel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblOutColor
         // 
         this._lblOutColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblOutColor.Location = new System.Drawing.Point(19, 138);
         this._lblOutColor.Name = "_lblOutColor";
         this._lblOutColor.Size = new System.Drawing.Size(75, 26);
         this._lblOutColor.TabIndex = 7;
         this._lblOutColor.Text = "Out Color";
         this._lblOutColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblInColor
         // 
         this._lblInColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblInColor.Location = new System.Drawing.Point(19, 102);
         this._lblInColor.Name = "_lblInColor";
         this._lblInColor.Size = new System.Drawing.Size(75, 26);
         this._lblInColor.TabIndex = 4;
         this._lblInColor.Text = "In Color";
         this._lblInColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblHigh
         // 
         this._lblHigh.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblHigh.Location = new System.Drawing.Point(19, 65);
         this._lblHigh.Name = "_lblHigh";
         this._lblHigh.Size = new System.Drawing.Size(75, 26);
         this._lblHigh.TabIndex = 2;
         this._lblHigh.Text = "High";
         this._lblHigh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblLow
         // 
         this._lblLow.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblLow.Location = new System.Drawing.Point(19, 28);
         this._lblLow.Name = "_lblLow";
         this._lblLow.Size = new System.Drawing.Size(75, 26);
         this._lblLow.TabIndex = 0;
         this._lblLow.Text = "Low";
         this._lblLow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // IntensityDetectDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(422, 292);
         this.Controls.Add(this._lblMsg);
         this.Controls.Add(this._gbOptions);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "IntensityDetectDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Intensity Detect";
         this.Load += new System.EventHandler(this.IntensityDetectDialog_Load);
         this._gbOptions.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this._numHigh)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._numLow)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
      private System.Windows.Forms.Label _lblMsg;
      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.NumericUpDown _numHigh;
      private System.Windows.Forms.NumericUpDown _numLow;
      private System.Windows.Forms.Label _lblInColor;
      private System.Windows.Forms.Label _lblHigh;
      private System.Windows.Forms.Label _lblLow;
      private System.Windows.Forms.Button _btnOutColor;
      private System.Windows.Forms.Button _btnInColor;
      private System.Windows.Forms.ComboBox _cbChannel;
      private System.Windows.Forms.Panel _pnlOutColor;
      private System.Windows.Forms.Panel _pnlInColor;
      private System.Windows.Forms.Label _lblChannel;
      private System.Windows.Forms.Label _lblOutColor;
   }
}