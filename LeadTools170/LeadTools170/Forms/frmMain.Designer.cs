namespace LeadTools170.Forms
{
    partial class frmMain
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSaveCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScanner = new System.Windows.Forms.ToolStripMenuItem();
            this.miSelectDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.miScannerSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.miAcquireImage = new System.Windows.Forms.ToolStripMenuItem();
            this.miAcquirePageNoDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProcessing = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeskew = new System.Windows.Forms.ToolStripMenuItem();
            this.miBinarize = new System.Windows.Forms.ToolStripMenuItem();
            this.miDespeckle = new System.Windows.Forms.ToolStripMenuItem();
            this.miAutoCrop = new System.Windows.Forms.ToolStripMenuItem();
            this.miBorderRemoval = new System.Windows.Forms.ToolStripMenuItem();
            this.miRotateCCW = new System.Windows.Forms.ToolStripMenuItem();
            this.miRotateCW = new System.Windows.Forms.ToolStripMenuItem();
            this.miOneClickProcessing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOCR = new System.Windows.Forms.ToolStripMenuItem();
            this.miOCRCurrentPage = new System.Windows.Forms.ToolStripMenuItem();
            this.miOCRAllPages = new System.Windows.Forms.ToolStripMenuItem();
            this.miOCRCodeline = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveToDB = new System.Windows.Forms.ToolStripMenuItem();
            this.panelImage = new System.Windows.Forms.Panel();
            this.panelText = new System.Windows.Forms.Panel();
            this.txtFullPageOCR = new System.Windows.Forms.RichTextBox();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.btnRotateCW = new System.Windows.Forms.Button();
            this.btnRotateCCW = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.txtCodeline = new System.Windows.Forms.TextBox();
            this.lblCodeline = new System.Windows.Forms.Label();
            this.lblChequeNo = new System.Windows.Forms.Label();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.lblOCRCodeline = new System.Windows.Forms.Label();
            this.txtOCRCodeline = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChequeNoOCR = new System.Windows.Forms.TextBox();
            this.lblAmountOCR = new System.Windows.Forms.Label();
            this.txtAmountOCR = new System.Windows.Forms.TextBox();
            this.txtUpperOCR = new System.Windows.Forms.TextBox();
            this.txtLowerOCR = new System.Windows.Forms.TextBox();
            this.grpValidation = new System.Windows.Forms.GroupBox();
            this.lblValidIBAN = new System.Windows.Forms.Label();
            this.lblValidNumber = new System.Windows.Forms.Label();
            this.lblValidDate = new System.Windows.Forms.Label();
            this.lblValidAmount = new System.Windows.Forms.Label();
            this.lblValidCharacters = new System.Windows.Forms.Label();
            this.txtValChequeAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValChequeDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValChequeNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSpecialChars = new System.Windows.Forms.Label();
            this.txtValIBAN = new System.Windows.Forms.TextBox();
            this.txtValSpecialChars = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProcessorCodelineOCRB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcessorCodelineOmni = new System.Windows.Forms.TextBox();
            this.mainMenu.SuspendLayout();
            this.panelText.SuspendLayout();
            this.grpValidation.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuScanner,
            this.menuProcessing,
            this.menuOCR,
            this.menuDatabase});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(994, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileOpen,
            this.miSave,
            this.miFileSaveCurrent,
            this.miExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(35, 20);
            this.menuFile.Text = "File";
            // 
            // miFileOpen
            // 
            this.miFileOpen.Name = "miFileOpen";
            this.miFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miFileOpen.Size = new System.Drawing.Size(244, 22);
            this.miFileOpen.Text = "Open";
            this.miFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(244, 22);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miFileSaveCurrent
            // 
            this.miFileSaveCurrent.Name = "miFileSaveCurrent";
            this.miFileSaveCurrent.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.miFileSaveCurrent.Size = new System.Drawing.Size(244, 22);
            this.miFileSaveCurrent.Text = "Save Current Page";
            this.miFileSaveCurrent.Click += new System.EventHandler(this.miSaveCurrentPage_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(244, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // menuScanner
            // 
            this.menuScanner.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSelectDevice,
            this.miScannerSettings,
            this.miAcquireImage,
            this.miAcquirePageNoDialog});
            this.menuScanner.Name = "menuScanner";
            this.menuScanner.Size = new System.Drawing.Size(58, 20);
            this.menuScanner.Text = "Scanner";
            // 
            // miSelectDevice
            // 
            this.miSelectDevice.Name = "miSelectDevice";
            this.miSelectDevice.Size = new System.Drawing.Size(265, 22);
            this.miSelectDevice.Text = "Select Device";
            this.miSelectDevice.Click += new System.EventHandler(this.miSelectDevice_Click);
            // 
            // miScannerSettings
            // 
            this.miScannerSettings.Name = "miScannerSettings";
            this.miScannerSettings.Size = new System.Drawing.Size(265, 22);
            this.miScannerSettings.Text = "Scanner Settings";
            this.miScannerSettings.Click += new System.EventHandler(this.miScannerSettings_Click);
            // 
            // miAcquireImage
            // 
            this.miAcquireImage.Name = "miAcquireImage";
            this.miAcquireImage.Size = new System.Drawing.Size(265, 22);
            this.miAcquireImage.Text = "Acquire Image";
            this.miAcquireImage.Click += new System.EventHandler(this.miAcquireImage_Click);
            // 
            // miAcquirePageNoDialog
            // 
            this.miAcquirePageNoDialog.Name = "miAcquirePageNoDialog";
            this.miAcquirePageNoDialog.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.miAcquirePageNoDialog.Size = new System.Drawing.Size(265, 22);
            this.miAcquirePageNoDialog.Text = "Acquire Image (No TWAIN dialog)";
            this.miAcquirePageNoDialog.Click += new System.EventHandler(this.miAcquirePageNoDialog_Click);
            // 
            // menuProcessing
            // 
            this.menuProcessing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDeskew,
            this.miBinarize,
            this.miDespeckle,
            this.miAutoCrop,
            this.miBorderRemoval,
            this.miRotateCCW,
            this.miRotateCW,
            this.miOneClickProcessing});
            this.menuProcessing.Name = "menuProcessing";
            this.menuProcessing.Size = new System.Drawing.Size(70, 20);
            this.menuProcessing.Text = "Processing";
            // 
            // miDeskew
            // 
            this.miDeskew.Name = "miDeskew";
            this.miDeskew.Size = new System.Drawing.Size(180, 22);
            this.miDeskew.Text = "Deskew";
            this.miDeskew.Click += new System.EventHandler(this.miDeskew_Click);
            // 
            // miBinarize
            // 
            this.miBinarize.Name = "miBinarize";
            this.miBinarize.Size = new System.Drawing.Size(180, 22);
            this.miBinarize.Text = "Binarize";
            this.miBinarize.Click += new System.EventHandler(this.miAutoBinarize_Click);
            // 
            // miDespeckle
            // 
            this.miDespeckle.Name = "miDespeckle";
            this.miDespeckle.Size = new System.Drawing.Size(180, 22);
            this.miDespeckle.Text = "Despeckle";
            this.miDespeckle.Click += new System.EventHandler(this.miDespeckle_Click);
            // 
            // miAutoCrop
            // 
            this.miAutoCrop.Name = "miAutoCrop";
            this.miAutoCrop.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.miAutoCrop.Size = new System.Drawing.Size(180, 22);
            this.miAutoCrop.Text = "AutoCrop";
            this.miAutoCrop.Click += new System.EventHandler(this.miAutoCrop_Click);
            // 
            // miBorderRemoval
            // 
            this.miBorderRemoval.Name = "miBorderRemoval";
            this.miBorderRemoval.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.miBorderRemoval.Size = new System.Drawing.Size(180, 22);
            this.miBorderRemoval.Text = "Border Removal";
            this.miBorderRemoval.Click += new System.EventHandler(this.miBorderRemoval_Click);
            // 
            // miRotateCCW
            // 
            this.miRotateCCW.Name = "miRotateCCW";
            this.miRotateCCW.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.miRotateCCW.Size = new System.Drawing.Size(180, 22);
            this.miRotateCCW.Text = "Rotate CCW";
            this.miRotateCCW.Click += new System.EventHandler(this.pageRotation_Click);
            // 
            // miRotateCW
            // 
            this.miRotateCW.Name = "miRotateCW";
            this.miRotateCW.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.miRotateCW.Size = new System.Drawing.Size(180, 22);
            this.miRotateCW.Text = "Rotate CW";
            this.miRotateCW.Click += new System.EventHandler(this.pageRotation_Click);
            // 
            // miOneClickProcessing
            // 
            this.miOneClickProcessing.Name = "miOneClickProcessing";
            this.miOneClickProcessing.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.miOneClickProcessing.Size = new System.Drawing.Size(180, 22);
            this.miOneClickProcessing.Text = "One-Click Fixing";
            this.miOneClickProcessing.Click += new System.EventHandler(this.miOneClickProcessing_Click);
            // 
            // menuOCR
            // 
            this.menuOCR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOCRCurrentPage,
            this.miOCRAllPages,
            this.miOCRCodeline});
            this.menuOCR.Name = "menuOCR";
            this.menuOCR.Size = new System.Drawing.Size(41, 20);
            this.menuOCR.Text = "OCR";
            // 
            // miOCRCurrentPage
            // 
            this.miOCRCurrentPage.Name = "miOCRCurrentPage";
            this.miOCRCurrentPage.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.miOCRCurrentPage.Size = new System.Drawing.Size(197, 22);
            this.miOCRCurrentPage.Text = "OCR current page";
            this.miOCRCurrentPage.Click += new System.EventHandler(this.miOCRCurrentPage_Click);
            // 
            // miOCRAllPages
            // 
            this.miOCRAllPages.Name = "miOCRAllPages";
            this.miOCRAllPages.Size = new System.Drawing.Size(197, 22);
            this.miOCRAllPages.Text = "OCR all pages";
            this.miOCRAllPages.Click += new System.EventHandler(this.miOCRAllPages_Click);
            // 
            // miOCRCodeline
            // 
            this.miOCRCodeline.Name = "miOCRCodeline";
            this.miOCRCodeline.Size = new System.Drawing.Size(197, 22);
            this.miOCRCodeline.Text = "OCR codeline";
            this.miOCRCodeline.Click += new System.EventHandler(this.miOCRCodeline_Click);
            // 
            // menuDatabase
            // 
            this.menuDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSaveToDB});
            this.menuDatabase.Name = "menuDatabase";
            this.menuDatabase.Size = new System.Drawing.Size(65, 20);
            this.menuDatabase.Text = "Database";
            // 
            // miSaveToDB
            // 
            this.miSaveToDB.Name = "miSaveToDB";
            this.miSaveToDB.Size = new System.Drawing.Size(171, 22);
            this.miSaveToDB.Text = "Save to Database";
            this.miSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // panelImage
            // 
            this.panelImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelImage.Location = new System.Drawing.Point(0, 27);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(607, 329);
            this.panelImage.TabIndex = 1;
            // 
            // panelText
            // 
            this.panelText.AutoScroll = true;
            this.panelText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelText.Controls.Add(this.txtFullPageOCR);
            this.panelText.Location = new System.Drawing.Point(0, 362);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(607, 122);
            this.panelText.TabIndex = 0;
            // 
            // txtFullPageOCR
            // 
            this.txtFullPageOCR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFullPageOCR.Location = new System.Drawing.Point(0, 0);
            this.txtFullPageOCR.Name = "txtFullPageOCR";
            this.txtFullPageOCR.ReadOnly = true;
            this.txtFullPageOCR.Size = new System.Drawing.Size(607, 122);
            this.txtFullPageOCR.TabIndex = 0;
            this.txtFullPageOCR.Text = "";
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Location = new System.Drawing.Point(613, 27);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentPage.TabIndex = 2;
            // 
            // btnRotateCW
            // 
            this.btnRotateCW.Image = global::LeadTools170.Properties.Resources.rotate_cw_icon;
            this.btnRotateCW.Location = new System.Drawing.Point(685, 180);
            this.btnRotateCW.Name = "btnRotateCW";
            this.btnRotateCW.Size = new System.Drawing.Size(35, 35);
            this.btnRotateCW.TabIndex = 8;
            this.btnRotateCW.UseVisualStyleBackColor = true;
            this.btnRotateCW.Click += new System.EventHandler(this.pageRotation_Click);
            // 
            // btnRotateCCW
            // 
            this.btnRotateCCW.Image = global::LeadTools170.Properties.Resources.rotate_ccw_icon;
            this.btnRotateCCW.Location = new System.Drawing.Point(626, 180);
            this.btnRotateCCW.Name = "btnRotateCCW";
            this.btnRotateCCW.Size = new System.Drawing.Size(35, 35);
            this.btnRotateCCW.TabIndex = 7;
            this.btnRotateCCW.UseVisualStyleBackColor = true;
            this.btnRotateCCW.Click += new System.EventHandler(this.pageRotation_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Image = global::LeadTools170.Properties.Resources.Next_icon;
            this.btnNextPage.Location = new System.Drawing.Point(685, 66);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(35, 35);
            this.btnNextPage.TabIndex = 6;
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.pageNavigation_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Image = global::LeadTools170.Properties.Resources.Previous_icon;
            this.btnPreviousPage.Location = new System.Drawing.Point(626, 66);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(35, 35);
            this.btnPreviousPage.TabIndex = 5;
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.pageNavigation_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Image = global::LeadTools170.Properties.Resources.Zoom_Out_icon;
            this.btnZoomOut.Location = new System.Drawing.Point(626, 119);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(35, 35);
            this.btnZoomOut.TabIndex = 4;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.imageZoom_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Image = global::LeadTools170.Properties.Resources.Zoom_In_icon;
            this.btnZoomIn.Location = new System.Drawing.Point(685, 119);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(35, 35);
            this.btnZoomIn.TabIndex = 3;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.imageZoom_Click);
            // 
            // txtCodeline
            // 
            this.txtCodeline.Location = new System.Drawing.Point(104, 664);
            this.txtCodeline.Name = "txtCodeline";
            this.txtCodeline.Size = new System.Drawing.Size(503, 20);
            this.txtCodeline.TabIndex = 1;
            // 
            // lblCodeline
            // 
            this.lblCodeline.AutoSize = true;
            this.lblCodeline.Location = new System.Drawing.Point(47, 664);
            this.lblCodeline.Name = "lblCodeline";
            this.lblCodeline.Size = new System.Drawing.Size(51, 13);
            this.lblCodeline.TabIndex = 9;
            this.lblCodeline.Text = "Codeline:";
            this.lblCodeline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.Location = new System.Drawing.Point(37, 544);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(61, 13);
            this.lblChequeNo.TabIndex = 11;
            this.lblChequeNo.Text = "ChequeNo:";
            this.lblChequeNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Location = new System.Drawing.Point(104, 541);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(178, 20);
            this.txtChequeNo.TabIndex = 10;
            // 
            // lblOCRCodeline
            // 
            this.lblOCRCodeline.AutoSize = true;
            this.lblOCRCodeline.Location = new System.Drawing.Point(15, 693);
            this.lblOCRCodeline.Name = "lblOCRCodeline";
            this.lblOCRCodeline.Size = new System.Drawing.Size(83, 13);
            this.lblOCRCodeline.TabIndex = 13;
            this.lblOCRCodeline.Text = "Codeline (OCR):";
            this.lblOCRCodeline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOCRCodeline
            // 
            this.txtOCRCodeline.Location = new System.Drawing.Point(104, 690);
            this.txtOCRCodeline.Name = "txtOCRCodeline";
            this.txtOCRCodeline.ReadOnly = true;
            this.txtOCRCodeline.Size = new System.Drawing.Size(503, 20);
            this.txtOCRCodeline.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ChequeNo (OCR):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChequeNoOCR
            // 
            this.txtChequeNoOCR.Location = new System.Drawing.Point(104, 567);
            this.txtChequeNoOCR.Name = "txtChequeNoOCR";
            this.txtChequeNoOCR.ReadOnly = true;
            this.txtChequeNoOCR.Size = new System.Drawing.Size(178, 20);
            this.txtChequeNoOCR.TabIndex = 14;
            // 
            // lblAmountOCR
            // 
            this.lblAmountOCR.AutoSize = true;
            this.lblAmountOCR.Location = new System.Drawing.Point(295, 566);
            this.lblAmountOCR.Name = "lblAmountOCR";
            this.lblAmountOCR.Size = new System.Drawing.Size(78, 13);
            this.lblAmountOCR.TabIndex = 17;
            this.lblAmountOCR.Text = "Amount (OCR):";
            this.lblAmountOCR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAmountOCR
            // 
            this.txtAmountOCR.Location = new System.Drawing.Point(394, 563);
            this.txtAmountOCR.Name = "txtAmountOCR";
            this.txtAmountOCR.ReadOnly = true;
            this.txtAmountOCR.Size = new System.Drawing.Size(178, 20);
            this.txtAmountOCR.TabIndex = 16;
            // 
            // txtUpperOCR
            // 
            this.txtUpperOCR.Location = new System.Drawing.Point(0, 490);
            this.txtUpperOCR.Multiline = true;
            this.txtUpperOCR.Name = "txtUpperOCR";
            this.txtUpperOCR.ReadOnly = true;
            this.txtUpperOCR.Size = new System.Drawing.Size(607, 40);
            this.txtUpperOCR.TabIndex = 18;
            // 
            // txtLowerOCR
            // 
            this.txtLowerOCR.Location = new System.Drawing.Point(0, 602);
            this.txtLowerOCR.Multiline = true;
            this.txtLowerOCR.Name = "txtLowerOCR";
            this.txtLowerOCR.ReadOnly = true;
            this.txtLowerOCR.Size = new System.Drawing.Size(607, 56);
            this.txtLowerOCR.TabIndex = 19;
            // 
            // grpValidation
            // 
            this.grpValidation.Controls.Add(this.lblValidIBAN);
            this.grpValidation.Controls.Add(this.lblValidNumber);
            this.grpValidation.Controls.Add(this.lblValidDate);
            this.grpValidation.Controls.Add(this.lblValidAmount);
            this.grpValidation.Controls.Add(this.lblValidCharacters);
            this.grpValidation.Controls.Add(this.txtValChequeAmount);
            this.grpValidation.Controls.Add(this.label5);
            this.grpValidation.Controls.Add(this.txtValChequeDate);
            this.grpValidation.Controls.Add(this.label4);
            this.grpValidation.Controls.Add(this.txtValChequeNumber);
            this.grpValidation.Controls.Add(this.label3);
            this.grpValidation.Controls.Add(this.txtValIBAN);
            //this.grpValidation.Controls.Add(this.lblValIBAN);
            this.grpValidation.Controls.Add(this.txtValSpecialChars);
            this.grpValidation.Controls.Add(this.lblSpecialChars);
            this.grpValidation.Location = new System.Drawing.Point(616, 362);
            this.grpValidation.Name = "grpValidation";
            this.grpValidation.Size = new System.Drawing.Size(366, 349);
            this.grpValidation.TabIndex = 20;
            this.grpValidation.TabStop = false;
            this.grpValidation.Text = "Validation";
            this.grpValidation.Enter += new System.EventHandler(this.grpValidation_Enter);
            // 
            // lblValidIBAN
            // 
            this.lblValidIBAN.AutoSize = true;
            this.lblValidIBAN.Location = new System.Drawing.Point(307, 58);
            this.lblValidIBAN.Name = "lblValidIBAN";
            this.lblValidIBAN.Size = new System.Drawing.Size(25, 13);
            this.lblValidIBAN.TabIndex = 14;
            this.lblValidIBAN.Text = "ddd";
            // 
            // lblValidNumber
            // 
            this.lblValidNumber.AutoSize = true;
            this.lblValidNumber.Location = new System.Drawing.Point(307, 84);
            this.lblValidNumber.Name = "lblValidNumber";
            this.lblValidNumber.Size = new System.Drawing.Size(25, 13);
            this.lblValidNumber.TabIndex = 13;
            this.lblValidNumber.Text = "ddd";
            // 
            // lblValidDate
            // 
            this.lblValidDate.AutoSize = true;
            this.lblValidDate.Location = new System.Drawing.Point(307, 110);
            this.lblValidDate.Name = "lblValidDate";
            this.lblValidDate.Size = new System.Drawing.Size(25, 13);
            this.lblValidDate.TabIndex = 12;
            this.lblValidDate.Text = "ddd";
            // 
            // lblValidAmount
            // 
            this.lblValidAmount.AutoSize = true;
            this.lblValidAmount.Location = new System.Drawing.Point(307, 136);
            this.lblValidAmount.Name = "lblValidAmount";
            this.lblValidAmount.Size = new System.Drawing.Size(25, 13);
            this.lblValidAmount.TabIndex = 11;
            this.lblValidAmount.Text = "ddd";
            // 
            // lblValidCharacters
            // 
            this.lblValidCharacters.AutoSize = true;
            this.lblValidCharacters.Location = new System.Drawing.Point(307, 32);
            this.lblValidCharacters.Name = "lblValidCharacters";
            this.lblValidCharacters.Size = new System.Drawing.Size(25, 13);
            this.lblValidCharacters.TabIndex = 10;
            this.lblValidCharacters.Text = "ddd";
            // 
            // txtValChequeAmount
            // 
            this.txtValChequeAmount.Location = new System.Drawing.Point(115, 133);
            this.txtValChequeAmount.Name = "txtValChequeAmount";
            this.txtValChequeAmount.Size = new System.Drawing.Size(186, 20);
            this.txtValChequeAmount.TabIndex = 9;
            this.txtValChequeAmount.Validating += new System.ComponentModel.CancelEventHandler(this.validatingGroup_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValChequeDate
            // 
            this.txtValChequeDate.Location = new System.Drawing.Point(115, 107);
            this.txtValChequeDate.Name = "txtValChequeDate";
            this.txtValChequeDate.Size = new System.Drawing.Size(186, 20);
            this.txtValChequeDate.TabIndex = 7;
            this.txtValChequeDate.Validating += new System.ComponentModel.CancelEventHandler(this.validatingGroup_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cheque Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValChequeNumber
            // 
            this.txtValChequeNumber.Location = new System.Drawing.Point(115, 81);
            this.txtValChequeNumber.Name = "txtValChequeNumber";
            this.txtValChequeNumber.Size = new System.Drawing.Size(186, 20);
            this.txtValChequeNumber.TabIndex = 5;
            this.txtValChequeNumber.Validating += new System.ComponentModel.CancelEventHandler(this.validatingGroup_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cheque Number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValIBAN
            // 
            this.txtValIBAN.Location = new System.Drawing.Point(115, 55);
            this.txtValIBAN.Name = "txtValIBAN";
            this.txtValIBAN.Size = new System.Drawing.Size(186, 20);
            this.txtValIBAN.TabIndex = 3;
            this.txtValIBAN.Validating += new System.ComponentModel.CancelEventHandler(this.validatingGroup_Validating);
            // 
            // lblValIBAN
            // 
            //this.lblValIBAN.AutoSize = true;
            //this.lblValIBAN.Location = new System.Drawing.Point(74, 58);
            //this.lblValIBAN.Name = "lblValIBAN";
            //this.lblValIBAN.Size = new System.Drawing.Size(35, 13);
            //this.lblValIBAN.TabIndex = 2;
            //this.lblValIBAN.Text = "IBAN:";
            //this.lblValIBAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValSpecialChars
            // 
            this.txtValSpecialChars.Location = new System.Drawing.Point(115, 29);
            this.txtValSpecialChars.Name = "txtValSpecialChars";
            this.txtValSpecialChars.Size = new System.Drawing.Size(186, 20);
            this.txtValSpecialChars.TabIndex = 1;
            this.txtValSpecialChars.Validating += new System.ComponentModel.CancelEventHandler(this.validatingGroup_Validating);
            // 
            // lblSpecialChars
            // 
            this.lblSpecialChars.AutoSize = true;
            this.lblSpecialChars.Location = new System.Drawing.Point(10, 32);
            this.lblSpecialChars.Name = "lblSpecialChars";
            this.lblSpecialChars.Size = new System.Drawing.Size(99, 13);
            this.lblSpecialChars.TabIndex = 0;
            this.lblSpecialChars.Text = "Special Characters:";
            this.lblSpecialChars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 723);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Codeline (OCRB):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProcessorCodelineOCRB
            // 
            this.txtProcessorCodelineOCRB.Location = new System.Drawing.Point(104, 720);
            this.txtProcessorCodelineOCRB.Name = "txtProcessorCodelineOCRB";
            this.txtProcessorCodelineOCRB.ReadOnly = true;
            this.txtProcessorCodelineOCRB.Size = new System.Drawing.Size(503, 20);
            this.txtProcessorCodelineOCRB.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 749);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Codeline (Omni):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProcessorCodelineOmni
            // 
            this.txtProcessorCodelineOmni.Location = new System.Drawing.Point(104, 746);
            this.txtProcessorCodelineOmni.Name = "txtProcessorCodelineOmni";
            this.txtProcessorCodelineOmni.ReadOnly = true;
            this.txtProcessorCodelineOmni.Size = new System.Drawing.Size(503, 20);
            this.txtProcessorCodelineOmni.TabIndex = 23;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 771);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProcessorCodelineOmni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProcessorCodelineOCRB);
            this.Controls.Add(this.grpValidation);
            this.Controls.Add(this.txtLowerOCR);
            this.Controls.Add(this.txtUpperOCR);
            this.Controls.Add(this.lblAmountOCR);
            this.Controls.Add(this.txtAmountOCR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChequeNoOCR);
            this.Controls.Add(this.lblOCRCodeline);
            this.Controls.Add(this.txtOCRCodeline);
            this.Controls.Add(this.lblChequeNo);
            this.Controls.Add(this.txtChequeNo);
            this.Controls.Add(this.lblCodeline);
            this.Controls.Add(this.txtCodeline);
            this.Controls.Add(this.btnRotateCW);
            this.Controls.Add(this.btnRotateCCW);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.lblCurrentPage);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.Text = "Unisystems Scanning Utility";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panelText.ResumeLayout(false);
            this.grpValidation.ResumeLayout(false);
            this.grpValidation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuScanner;
        private System.Windows.Forms.ToolStripMenuItem miSelectDevice;
        private System.Windows.Forms.ToolStripMenuItem miAcquireImage;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.RichTextBox txtFullPageOCR;
        private System.Windows.Forms.ToolStripMenuItem menuOCR;
        private System.Windows.Forms.ToolStripMenuItem miOCRCurrentPage;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miOCRAllPages;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnRotateCCW;
        private System.Windows.Forms.Button btnRotateCW;
        private System.Windows.Forms.ToolStripMenuItem menuProcessing;
        private System.Windows.Forms.ToolStripMenuItem miDeskew;
        private System.Windows.Forms.ToolStripMenuItem miBinarize;
        private System.Windows.Forms.ToolStripMenuItem miDespeckle;
        private System.Windows.Forms.ToolStripMenuItem miAcquirePageNoDialog;
        private System.Windows.Forms.ToolStripMenuItem miScannerSettings;
        private System.Windows.Forms.ToolStripMenuItem menuDatabase;
        private System.Windows.Forms.ToolStripMenuItem miSaveToDB;
        private System.Windows.Forms.ToolStripMenuItem miOCRCodeline;
        private System.Windows.Forms.TextBox txtCodeline;
        private System.Windows.Forms.Label lblCodeline;
        private System.Windows.Forms.Label lblChequeNo;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.Label lblOCRCodeline;
        private System.Windows.Forms.TextBox txtOCRCodeline;
        private System.Windows.Forms.ToolStripMenuItem miAutoCrop;
        private System.Windows.Forms.ToolStripMenuItem miBorderRemoval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChequeNoOCR;
        private System.Windows.Forms.ToolStripMenuItem miRotateCCW;
        private System.Windows.Forms.ToolStripMenuItem miRotateCW;
        private System.Windows.Forms.Label lblAmountOCR;
        private System.Windows.Forms.TextBox txtAmountOCR;
        private System.Windows.Forms.TextBox txtUpperOCR;
        private System.Windows.Forms.TextBox txtLowerOCR;
        private System.Windows.Forms.GroupBox grpValidation;
        private System.Windows.Forms.TextBox txtValSpecialChars;
        private System.Windows.Forms.TextBox txtValChequeAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValChequeDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValChequeNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValIBAN;
        private System.Windows.Forms.Label lblValidIBAN;
        //private System.Windows.Forms.Label lblValIBAN;
        private System.Windows.Forms.Label lblValidNumber;
        private System.Windows.Forms.Label lblValidDate;
        private System.Windows.Forms.Label lblValidAmount;
        private System.Windows.Forms.Label lblValidCharacters;
        private System.Windows.Forms.Label lblSpecialChars;
        private System.Windows.Forms.ToolStripMenuItem miFileSaveCurrent;
        private System.Windows.Forms.ToolStripMenuItem miOneClickProcessing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcessorCodelineOCRB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProcessorCodelineOmni;
        private System.Windows.Forms.ToolStripMenuItem miFileOpen;
    }
}