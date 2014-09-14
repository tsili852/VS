namespace MainDemo
{
   partial class GrayScaleFactorDialog
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
         this._numBlue = new System.Windows.Forms.NumericUpDown();
         this._numGreen = new System.Windows.Forms.NumericUpDown();
         this._numRed = new System.Windows.Forms.NumericUpDown();
         this._lblBlue = new System.Windows.Forms.Label();
         this._lblGreen = new System.Windows.Forms.Label();
         this._lblRed = new System.Windows.Forms.Label();
         this._lblMsg = new System.Windows.Forms.Label();
         this._gbOptions.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._numBlue)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._numGreen)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._numRed)).BeginInit();
         this.SuspendLayout();
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._btnCancel.Location = new System.Drawing.Point(278, 55);
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
         this._btnOk.Location = new System.Drawing.Point(278, 18);
         this._btnOk.Name = "_btnOk";
         this._btnOk.Size = new System.Drawing.Size(90, 27);
         this._btnOk.TabIndex = 2;
         this._btnOk.Text = "OK";
         this._btnOk.UseVisualStyleBackColor = true;
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // _gbOptions
         // 
         this._gbOptions.Controls.Add(this._numBlue);
         this._gbOptions.Controls.Add(this._numGreen);
         this._gbOptions.Controls.Add(this._numRed);
         this._gbOptions.Controls.Add(this._lblBlue);
         this._gbOptions.Controls.Add(this._lblGreen);
         this._gbOptions.Controls.Add(this._lblRed);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._gbOptions.Location = new System.Drawing.Point(10, 9);
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.Size = new System.Drawing.Size(240, 139);
         this._gbOptions.TabIndex = 0;
         this._gbOptions.TabStop = false;
         // 
         // _numBlue
         // 
         this._numBlue.Location = new System.Drawing.Point(125, 102);
         this._numBlue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
         this._numBlue.Name = "_numBlue";
         this._numBlue.Size = new System.Drawing.Size(96, 22);
         this._numBlue.TabIndex = 5;
         this._numBlue.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _numGreen
         // 
         this._numGreen.Location = new System.Drawing.Point(125, 65);
         this._numGreen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
         this._numGreen.Name = "_numGreen";
         this._numGreen.Size = new System.Drawing.Size(96, 22);
         this._numGreen.TabIndex = 3;
         this._numGreen.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _numRed
         // 
         this._numRed.Location = new System.Drawing.Point(125, 28);
         this._numRed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
         this._numRed.Name = "_numRed";
         this._numRed.Size = new System.Drawing.Size(96, 22);
         this._numRed.TabIndex = 1;
         this._numRed.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _lblBlue
         // 
         this._lblBlue.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblBlue.Location = new System.Drawing.Point(19, 102);
         this._lblBlue.Name = "_lblBlue";
         this._lblBlue.Size = new System.Drawing.Size(96, 26);
         this._lblBlue.TabIndex = 4;
         this._lblBlue.Text = "Blue Factor";
         this._lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblGreen
         // 
         this._lblGreen.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblGreen.Location = new System.Drawing.Point(19, 65);
         this._lblGreen.Name = "_lblGreen";
         this._lblGreen.Size = new System.Drawing.Size(96, 26);
         this._lblGreen.TabIndex = 2;
         this._lblGreen.Text = "Green Factor";
         this._lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblRed
         // 
         this._lblRed.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblRed.Location = new System.Drawing.Point(19, 28);
         this._lblRed.Name = "_lblRed";
         this._lblRed.Size = new System.Drawing.Size(96, 26);
         this._lblRed.TabIndex = 0;
         this._lblRed.Text = "Red Factor";
         this._lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lblMsg
         // 
         this._lblMsg.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lblMsg.Location = new System.Drawing.Point(10, 166);
         this._lblMsg.Name = "_lblMsg";
         this._lblMsg.Size = new System.Drawing.Size(336, 40);
         this._lblMsg.TabIndex = 1;
         this._lblMsg.Text = "The sum of the Red, Green, and Blue values must be less than or equal to 1000.";
         // 
         // GrayScaleFactorDialog
         // 
         this.AcceptButton = this._btnOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._btnCancel;
         this.ClientSize = new System.Drawing.Size(374, 218);
         this.Controls.Add(this._lblMsg);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.Controls.Add(this._gbOptions);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "GrayScaleFactorDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Gray Scale Factor";
         this._gbOptions.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this._numBlue)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._numGreen)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._numRed)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.Label _lblRed;
      private System.Windows.Forms.Label _lblBlue;
      private System.Windows.Forms.Label _lblGreen;
      private System.Windows.Forms.Label _lblMsg;
      private System.Windows.Forms.NumericUpDown _numRed;
      private System.Windows.Forms.NumericUpDown _numBlue;
      private System.Windows.Forms.NumericUpDown _numGreen;
   }
}