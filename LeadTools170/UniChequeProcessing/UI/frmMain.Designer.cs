namespace Unisystems.Cheques.UniChequeProcessing.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSaveTIFF = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSaveJPG = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScanner = new System.Windows.Forms.ToolStripMenuItem();
            this.miScannerSelectDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.miScannerAcquireFull = new System.Windows.Forms.ToolStripMenuItem();
            this.miScannerAcquireQuick = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.miProcAutoFix = new System.Windows.Forms.ToolStripMenuItem();
            this.miProcBinarize = new System.Windows.Forms.ToolStripMenuItem();
            this.miProcAutoCrop = new System.Windows.Forms.ToolStripMenuItem();
            this.miProcDeskew = new System.Windows.Forms.ToolStripMenuItem();
            this.miProcDespeckle = new System.Windows.Forms.ToolStripMenuItem();
            this.miProcRemoveBorders = new System.Windows.Forms.ToolStripMenuItem();
            this.miProcRotate = new System.Windows.Forms.ToolStripMenuItem();
            this.miProcRotateCW = new System.Windows.Forms.ToolStripMenuItem();
            this.miProcRotateCCW = new System.Windows.Forms.ToolStripMenuItem();
            this.miProcRemoveDots = new System.Windows.Forms.ToolStripMenuItem();
            this.miProcRemoveLines = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOCR = new System.Windows.Forms.ToolStripMenuItem();
            this.miOCRCurrentPage = new System.Windows.Forms.ToolStripMenuItem();
            this.miOCRAllPages = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupImage = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextRubberBand = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupRotation = new System.Windows.Forms.GroupBox();
            this.btnRotateCCW = new System.Windows.Forms.Button();
            this.btnRotateCW = new System.Windows.Forms.Button();
            this.groupZoom = new System.Windows.Forms.GroupBox();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.groupNavigation = new System.Windows.Forms.GroupBox();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.richtxtProcessorCodelineOCRB = new System.Windows.Forms.RichTextBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupValidation = new System.Windows.Forms.GroupBox();
            this.groupIBAN = new System.Windows.Forms.GroupBox();
            this.txtIBANAccountNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIBANBranchCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIBANBankCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIBANCheckDigits = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIBANCountryCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblValidationIBAN = new System.Windows.Forms.Label();
            this.lblValidationChequeNumber = new System.Windows.Forms.Label();
            this.lblValidationChequeAmount = new System.Windows.Forms.Label();
            this.lblValidationChequeDate = new System.Windows.Forms.Label();
            this.lblValidationSpecialCharacters = new System.Windows.Forms.Label();
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
            this.txtValIBAN = new System.Windows.Forms.TextBox();
            this.lblValIBAN = new System.Windows.Forms.Label();
            this.txtValSpecialChars = new System.Windows.Forms.TextBox();
            this.lblSpecialChars = new System.Windows.Forms.Label();
            this.pbUniLogo = new System.Windows.Forms.PictureBox();
            this.menuMain.SuspendLayout();
            this.groupImage.SuspendLayout();
            this.groupRotation.SuspendLayout();
            this.groupZoom.SuspendLayout();
            this.groupNavigation.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.groupValidation.SuspendLayout();
            this.groupIBAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUniLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            resources.ApplyResources(this.menuMain, "menuMain");
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuScanner,
            this.menuImageProcess,
            this.menuOCR,
            this.menuDatabase,
            this.menuAboutInfo});
            this.menuMain.Name = "menuMain";
            // 
            // menuFile
            // 
            resources.ApplyResources(this.menuFile, "menuFile");
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileOpen,
            this.miFileSaveTIFF,
            this.miFileSaveJPG,
            this.miFileExit});
            this.menuFile.Name = "menuFile";
            // 
            // miFileOpen
            // 
            resources.ApplyResources(this.miFileOpen, "miFileOpen");
            this.miFileOpen.Name = "miFileOpen";
            this.miFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
            // 
            // miFileSaveTIFF
            // 
            resources.ApplyResources(this.miFileSaveTIFF, "miFileSaveTIFF");
            this.miFileSaveTIFF.Name = "miFileSaveTIFF";
            this.miFileSaveTIFF.Click += new System.EventHandler(this.miFileSaveTIFF_Click);
            // 
            // miFileSaveJPG
            // 
            resources.ApplyResources(this.miFileSaveJPG, "miFileSaveJPG");
            this.miFileSaveJPG.Name = "miFileSaveJPG";
            this.miFileSaveJPG.Click += new System.EventHandler(this.miFileSaveJPG_Click);
            // 
            // miFileExit
            // 
            resources.ApplyResources(this.miFileExit, "miFileExit");
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.Click += new System.EventHandler(this.miFileExit_Click);
            // 
            // menuScanner
            // 
            resources.ApplyResources(this.menuScanner, "menuScanner");
            this.menuScanner.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miScannerSelectDevice,
            this.miScannerAcquireFull,
            this.miScannerAcquireQuick});
            this.menuScanner.Name = "menuScanner";
            // 
            // miScannerSelectDevice
            // 
            resources.ApplyResources(this.miScannerSelectDevice, "miScannerSelectDevice");
            this.miScannerSelectDevice.Name = "miScannerSelectDevice";
            this.miScannerSelectDevice.Click += new System.EventHandler(this.miScannerSelectDevice_Click);
            // 
            // miScannerAcquireFull
            // 
            resources.ApplyResources(this.miScannerAcquireFull, "miScannerAcquireFull");
            this.miScannerAcquireFull.Name = "miScannerAcquireFull";
            this.miScannerAcquireFull.Click += new System.EventHandler(this.miScannerAcquireFull_Click);
            // 
            // miScannerAcquireQuick
            // 
            resources.ApplyResources(this.miScannerAcquireQuick, "miScannerAcquireQuick");
            this.miScannerAcquireQuick.Name = "miScannerAcquireQuick";
            this.miScannerAcquireQuick.Click += new System.EventHandler(this.miScannerAcquireQuick_Click);
            // 
            // menuImageProcess
            // 
            resources.ApplyResources(this.menuImageProcess, "menuImageProcess");
            this.menuImageProcess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProcAutoFix,
            this.miProcBinarize,
            this.miProcAutoCrop,
            this.miProcDeskew,
            this.miProcDespeckle,
            this.miProcRemoveBorders,
            this.miProcRotate,
            this.miProcRemoveDots,
            this.miProcRemoveLines});
            this.menuImageProcess.Name = "menuImageProcess";
            // 
            // miProcAutoFix
            // 
            resources.ApplyResources(this.miProcAutoFix, "miProcAutoFix");
            this.miProcAutoFix.Name = "miProcAutoFix";
            this.miProcAutoFix.Click += new System.EventHandler(this.miProcAutoFix_Click);
            // 
            // miProcBinarize
            // 
            resources.ApplyResources(this.miProcBinarize, "miProcBinarize");
            this.miProcBinarize.Name = "miProcBinarize";
            this.miProcBinarize.Click += new System.EventHandler(this.miProcBinarize_Click);
            // 
            // miProcAutoCrop
            // 
            resources.ApplyResources(this.miProcAutoCrop, "miProcAutoCrop");
            this.miProcAutoCrop.Name = "miProcAutoCrop";
            this.miProcAutoCrop.Click += new System.EventHandler(this.miProcAutoCrop_Click);
            // 
            // miProcDeskew
            // 
            resources.ApplyResources(this.miProcDeskew, "miProcDeskew");
            this.miProcDeskew.Name = "miProcDeskew";
            this.miProcDeskew.Click += new System.EventHandler(this.miProcDeskew_Click);
            // 
            // miProcDespeckle
            // 
            resources.ApplyResources(this.miProcDespeckle, "miProcDespeckle");
            this.miProcDespeckle.Name = "miProcDespeckle";
            this.miProcDespeckle.Click += new System.EventHandler(this.miProcDespeckle_Click);
            // 
            // miProcRemoveBorders
            // 
            resources.ApplyResources(this.miProcRemoveBorders, "miProcRemoveBorders");
            this.miProcRemoveBorders.Name = "miProcRemoveBorders";
            this.miProcRemoveBorders.Click += new System.EventHandler(this.miProcRemoveBorders_Click);
            // 
            // miProcRotate
            // 
            resources.ApplyResources(this.miProcRotate, "miProcRotate");
            this.miProcRotate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProcRotateCW,
            this.miProcRotateCCW});
            this.miProcRotate.Name = "miProcRotate";
            // 
            // miProcRotateCW
            // 
            resources.ApplyResources(this.miProcRotateCW, "miProcRotateCW");
            this.miProcRotateCW.Name = "miProcRotateCW";
            this.miProcRotateCW.Click += new System.EventHandler(this.miProcRotateCW_Click);
            // 
            // miProcRotateCCW
            // 
            resources.ApplyResources(this.miProcRotateCCW, "miProcRotateCCW");
            this.miProcRotateCCW.Name = "miProcRotateCCW";
            this.miProcRotateCCW.Click += new System.EventHandler(this.miProcRotateCCW_Click);
            // 
            // miProcRemoveDots
            // 
            resources.ApplyResources(this.miProcRemoveDots, "miProcRemoveDots");
            this.miProcRemoveDots.Name = "miProcRemoveDots";
            this.miProcRemoveDots.Click += new System.EventHandler(this.miProcRemoveDots_Click);
            // 
            // miProcRemoveLines
            // 
            resources.ApplyResources(this.miProcRemoveLines, "miProcRemoveLines");
            this.miProcRemoveLines.Name = "miProcRemoveLines";
            this.miProcRemoveLines.Click += new System.EventHandler(this.miProcRemoveLines_Click);
            // 
            // menuOCR
            // 
            resources.ApplyResources(this.menuOCR, "menuOCR");
            this.menuOCR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOCRCurrentPage,
            this.miOCRAllPages});
            this.menuOCR.Name = "menuOCR";
            // 
            // miOCRCurrentPage
            // 
            resources.ApplyResources(this.miOCRCurrentPage, "miOCRCurrentPage");
            this.miOCRCurrentPage.Name = "miOCRCurrentPage";
            this.miOCRCurrentPage.Click += new System.EventHandler(this.miOCRCurrentPage_Click);
            // 
            // miOCRAllPages
            // 
            resources.ApplyResources(this.miOCRAllPages, "miOCRAllPages");
            this.miOCRAllPages.Name = "miOCRAllPages";
            this.miOCRAllPages.Click += new System.EventHandler(this.miOCRAllPages_Click);
            // 
            // menuDatabase
            // 
            resources.ApplyResources(this.menuDatabase, "menuDatabase");
            this.menuDatabase.Name = "menuDatabase";
            // 
            // menuAboutInfo
            // 
            resources.ApplyResources(this.menuAboutInfo, "menuAboutInfo");
            this.menuAboutInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.menuAboutInfo.Name = "menuAboutInfo";
            // 
            // miAbout
            // 
            resources.ApplyResources(this.miAbout, "miAbout");
            this.miAbout.Name = "miAbout";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // groupImage
            // 
            resources.ApplyResources(this.groupImage, "groupImage");
            this.groupImage.Controls.Add(this.label2);
            this.groupImage.Controls.Add(this.richTextRubberBand);
            this.groupImage.Controls.Add(this.label1);
            this.groupImage.Controls.Add(this.groupRotation);
            this.groupImage.Controls.Add(this.groupZoom);
            this.groupImage.Controls.Add(this.groupNavigation);
            this.groupImage.Controls.Add(this.richtxtProcessorCodelineOCRB);
            this.groupImage.Controls.Add(this.panelImage);
            this.groupImage.Name = "groupImage";
            this.groupImage.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // richTextRubberBand
            // 
            resources.ApplyResources(this.richTextRubberBand, "richTextRubberBand");
            this.richTextRubberBand.Name = "richTextRubberBand";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupRotation
            // 
            resources.ApplyResources(this.groupRotation, "groupRotation");
            this.groupRotation.Controls.Add(this.btnRotateCCW);
            this.groupRotation.Controls.Add(this.btnRotateCW);
            this.groupRotation.Name = "groupRotation";
            this.groupRotation.TabStop = false;
            // 
            // btnRotateCCW
            // 
            resources.ApplyResources(this.btnRotateCCW, "btnRotateCCW");
            this.btnRotateCCW.BackgroundImage = global::Unisystems.Cheques.UniChequeProcessing.Properties.Resources.rotate_ccw_icon;
            this.btnRotateCCW.Name = "btnRotateCCW";
            this.btnRotateCCW.UseVisualStyleBackColor = true;
            this.btnRotateCCW.Click += new System.EventHandler(this.pageRotation_Click);
            // 
            // btnRotateCW
            // 
            resources.ApplyResources(this.btnRotateCW, "btnRotateCW");
            this.btnRotateCW.BackgroundImage = global::Unisystems.Cheques.UniChequeProcessing.Properties.Resources.rotate_cw_icon;
            this.btnRotateCW.Name = "btnRotateCW";
            this.btnRotateCW.UseVisualStyleBackColor = true;
            this.btnRotateCW.Click += new System.EventHandler(this.pageRotation_Click);
            // 
            // groupZoom
            // 
            resources.ApplyResources(this.groupZoom, "groupZoom");
            this.groupZoom.Controls.Add(this.btnZoomOut);
            this.groupZoom.Controls.Add(this.btnZoomIn);
            this.groupZoom.Name = "groupZoom";
            this.groupZoom.TabStop = false;
            // 
            // btnZoomOut
            // 
            resources.ApplyResources(this.btnZoomOut, "btnZoomOut");
            this.btnZoomOut.BackgroundImage = global::Unisystems.Cheques.UniChequeProcessing.Properties.Resources.Zoom_Out_icon;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.imageZoom_Click);
            // 
            // btnZoomIn
            // 
            resources.ApplyResources(this.btnZoomIn, "btnZoomIn");
            this.btnZoomIn.BackgroundImage = global::Unisystems.Cheques.UniChequeProcessing.Properties.Resources.Zoom_In_icon;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.imageZoom_Click);
            // 
            // groupNavigation
            // 
            resources.ApplyResources(this.groupNavigation, "groupNavigation");
            this.groupNavigation.Controls.Add(this.lblCurrentPage);
            this.groupNavigation.Controls.Add(this.btnPreviousPage);
            this.groupNavigation.Controls.Add(this.btnNextPage);
            this.groupNavigation.Name = "groupNavigation";
            this.groupNavigation.TabStop = false;
            // 
            // lblCurrentPage
            // 
            resources.ApplyResources(this.lblCurrentPage, "lblCurrentPage");
            this.lblCurrentPage.Name = "lblCurrentPage";
            // 
            // btnPreviousPage
            // 
            resources.ApplyResources(this.btnPreviousPage, "btnPreviousPage");
            this.btnPreviousPage.BackgroundImage = global::Unisystems.Cheques.UniChequeProcessing.Properties.Resources.Previous_icon;
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.pageNavigation_Click);
            // 
            // btnNextPage
            // 
            resources.ApplyResources(this.btnNextPage, "btnNextPage");
            this.btnNextPage.BackgroundImage = global::Unisystems.Cheques.UniChequeProcessing.Properties.Resources.Next_icon;
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.pageNavigation_Click);
            // 
            // richtxtProcessorCodelineOCRB
            // 
            resources.ApplyResources(this.richtxtProcessorCodelineOCRB, "richtxtProcessorCodelineOCRB");
            this.richtxtProcessorCodelineOCRB.Name = "richtxtProcessorCodelineOCRB";
            // 
            // panelImage
            // 
            resources.ApplyResources(this.panelImage, "panelImage");
            this.panelImage.Controls.Add(this.panel1);
            this.panelImage.Name = "panelImage";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // groupValidation
            // 
            resources.ApplyResources(this.groupValidation, "groupValidation");
            this.groupValidation.Controls.Add(this.groupIBAN);
            this.groupValidation.Controls.Add(this.lblValidationIBAN);
            this.groupValidation.Controls.Add(this.lblValidationChequeNumber);
            this.groupValidation.Controls.Add(this.lblValidationChequeAmount);
            this.groupValidation.Controls.Add(this.lblValidationChequeDate);
            this.groupValidation.Controls.Add(this.lblValidationSpecialCharacters);
            this.groupValidation.Controls.Add(this.lblValidIBAN);
            this.groupValidation.Controls.Add(this.lblValidNumber);
            this.groupValidation.Controls.Add(this.lblValidDate);
            this.groupValidation.Controls.Add(this.lblValidAmount);
            this.groupValidation.Controls.Add(this.lblValidCharacters);
            this.groupValidation.Controls.Add(this.txtValChequeAmount);
            this.groupValidation.Controls.Add(this.label5);
            this.groupValidation.Controls.Add(this.txtValChequeDate);
            this.groupValidation.Controls.Add(this.label4);
            this.groupValidation.Controls.Add(this.txtValChequeNumber);
            this.groupValidation.Controls.Add(this.label3);
            this.groupValidation.Controls.Add(this.txtValIBAN);
            this.groupValidation.Controls.Add(this.lblValIBAN);
            this.groupValidation.Controls.Add(this.txtValSpecialChars);
            this.groupValidation.Controls.Add(this.lblSpecialChars);
            this.groupValidation.Name = "groupValidation";
            this.groupValidation.TabStop = false;
            // 
            // groupIBAN
            // 
            resources.ApplyResources(this.groupIBAN, "groupIBAN");
            this.groupIBAN.Controls.Add(this.txtIBANAccountNumber);
            this.groupIBAN.Controls.Add(this.label10);
            this.groupIBAN.Controls.Add(this.txtIBANBranchCode);
            this.groupIBAN.Controls.Add(this.label9);
            this.groupIBAN.Controls.Add(this.txtIBANBankCode);
            this.groupIBAN.Controls.Add(this.label8);
            this.groupIBAN.Controls.Add(this.txtIBANCheckDigits);
            this.groupIBAN.Controls.Add(this.label7);
            this.groupIBAN.Controls.Add(this.txtIBANCountryCode);
            this.groupIBAN.Controls.Add(this.label6);
            this.groupIBAN.Name = "groupIBAN";
            this.groupIBAN.TabStop = false;
            // 
            // txtIBANAccountNumber
            // 
            resources.ApplyResources(this.txtIBANAccountNumber, "txtIBANAccountNumber");
            this.txtIBANAccountNumber.Name = "txtIBANAccountNumber";
            this.txtIBANAccountNumber.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtIBANBranchCode
            // 
            resources.ApplyResources(this.txtIBANBranchCode, "txtIBANBranchCode");
            this.txtIBANBranchCode.Name = "txtIBANBranchCode";
            this.txtIBANBranchCode.ReadOnly = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtIBANBankCode
            // 
            resources.ApplyResources(this.txtIBANBankCode, "txtIBANBankCode");
            this.txtIBANBankCode.Name = "txtIBANBankCode";
            this.txtIBANBankCode.ReadOnly = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtIBANCheckDigits
            // 
            resources.ApplyResources(this.txtIBANCheckDigits, "txtIBANCheckDigits");
            this.txtIBANCheckDigits.Name = "txtIBANCheckDigits";
            this.txtIBANCheckDigits.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtIBANCountryCode
            // 
            resources.ApplyResources(this.txtIBANCountryCode, "txtIBANCountryCode");
            this.txtIBANCountryCode.Name = "txtIBANCountryCode";
            this.txtIBANCountryCode.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lblValidationIBAN
            // 
            resources.ApplyResources(this.lblValidationIBAN, "lblValidationIBAN");
            this.lblValidationIBAN.Name = "lblValidationIBAN";
            // 
            // lblValidationChequeNumber
            // 
            resources.ApplyResources(this.lblValidationChequeNumber, "lblValidationChequeNumber");
            this.lblValidationChequeNumber.Name = "lblValidationChequeNumber";
            // 
            // lblValidationChequeAmount
            // 
            resources.ApplyResources(this.lblValidationChequeAmount, "lblValidationChequeAmount");
            this.lblValidationChequeAmount.Name = "lblValidationChequeAmount";
            // 
            // lblValidationChequeDate
            // 
            resources.ApplyResources(this.lblValidationChequeDate, "lblValidationChequeDate");
            this.lblValidationChequeDate.Name = "lblValidationChequeDate";
            // 
            // lblValidationSpecialCharacters
            // 
            resources.ApplyResources(this.lblValidationSpecialCharacters, "lblValidationSpecialCharacters");
            this.lblValidationSpecialCharacters.Name = "lblValidationSpecialCharacters";
            // 
            // lblValidIBAN
            // 
            resources.ApplyResources(this.lblValidIBAN, "lblValidIBAN");
            this.lblValidIBAN.Name = "lblValidIBAN";
            // 
            // lblValidNumber
            // 
            resources.ApplyResources(this.lblValidNumber, "lblValidNumber");
            this.lblValidNumber.Name = "lblValidNumber";
            // 
            // lblValidDate
            // 
            resources.ApplyResources(this.lblValidDate, "lblValidDate");
            this.lblValidDate.Name = "lblValidDate";
            // 
            // lblValidAmount
            // 
            resources.ApplyResources(this.lblValidAmount, "lblValidAmount");
            this.lblValidAmount.Name = "lblValidAmount";
            // 
            // lblValidCharacters
            // 
            resources.ApplyResources(this.lblValidCharacters, "lblValidCharacters");
            this.lblValidCharacters.Name = "lblValidCharacters";
            // 
            // txtValChequeAmount
            // 
            resources.ApplyResources(this.txtValChequeAmount, "txtValChequeAmount");
            this.txtValChequeAmount.Name = "txtValChequeAmount";
            this.txtValChequeAmount.Validating += new System.ComponentModel.CancelEventHandler(this.validatingGroup_Validating);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtValChequeDate
            // 
            resources.ApplyResources(this.txtValChequeDate, "txtValChequeDate");
            this.txtValChequeDate.Name = "txtValChequeDate";
            this.txtValChequeDate.Validating += new System.ComponentModel.CancelEventHandler(this.validatingGroup_Validating);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtValChequeNumber
            // 
            resources.ApplyResources(this.txtValChequeNumber, "txtValChequeNumber");
            this.txtValChequeNumber.Name = "txtValChequeNumber";
            this.txtValChequeNumber.Validating += new System.ComponentModel.CancelEventHandler(this.validatingGroup_Validating);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtValIBAN
            // 
            resources.ApplyResources(this.txtValIBAN, "txtValIBAN");
            this.txtValIBAN.Name = "txtValIBAN";
            this.txtValIBAN.Validating += new System.ComponentModel.CancelEventHandler(this.validatingGroup_Validating);
            // 
            // lblValIBAN
            // 
            resources.ApplyResources(this.lblValIBAN, "lblValIBAN");
            this.lblValIBAN.Name = "lblValIBAN";
            // 
            // txtValSpecialChars
            // 
            resources.ApplyResources(this.txtValSpecialChars, "txtValSpecialChars");
            this.txtValSpecialChars.Name = "txtValSpecialChars";
            this.txtValSpecialChars.Validating += new System.ComponentModel.CancelEventHandler(this.validatingGroup_Validating);
            // 
            // lblSpecialChars
            // 
            resources.ApplyResources(this.lblSpecialChars, "lblSpecialChars");
            this.lblSpecialChars.Name = "lblSpecialChars";
            // 
            // pbUniLogo
            // 
            resources.ApplyResources(this.pbUniLogo, "pbUniLogo");
            this.pbUniLogo.BackgroundImage = global::Unisystems.Cheques.UniChequeProcessing.Properties.Resources.logo_new_unisystems;
            this.pbUniLogo.Name = "pbUniLogo";
            this.pbUniLogo.TabStop = false;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbUniLogo);
            this.Controls.Add(this.groupValidation);
            this.Controls.Add(this.groupImage);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.groupImage.ResumeLayout(false);
            this.groupImage.PerformLayout();
            this.groupRotation.ResumeLayout(false);
            this.groupZoom.ResumeLayout(false);
            this.groupNavigation.ResumeLayout(false);
            this.groupNavigation.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.groupValidation.ResumeLayout(false);
            this.groupValidation.PerformLayout();
            this.groupIBAN.ResumeLayout(false);
            this.groupIBAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUniLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuScanner;
        private System.Windows.Forms.ToolStripMenuItem menuImageProcess;
        private System.Windows.Forms.ToolStripMenuItem menuOCR;
        private System.Windows.Forms.ToolStripMenuItem menuDatabase;
        private System.Windows.Forms.ToolStripMenuItem miFileOpen;
        private System.Windows.Forms.ToolStripMenuItem miFileSaveTIFF;
        private System.Windows.Forms.ToolStripMenuItem miFileSaveJPG;
        private System.Windows.Forms.ToolStripMenuItem miFileExit;
        private System.Windows.Forms.ToolStripMenuItem miScannerSelectDevice;
        private System.Windows.Forms.ToolStripMenuItem miScannerAcquireFull;
        private System.Windows.Forms.ToolStripMenuItem miScannerAcquireQuick;
        private System.Windows.Forms.ToolStripMenuItem miProcBinarize;
        private System.Windows.Forms.ToolStripMenuItem miProcAutoCrop;
        private System.Windows.Forms.ToolStripMenuItem miProcDeskew;
        private System.Windows.Forms.ToolStripMenuItem miProcDespeckle;
        private System.Windows.Forms.ToolStripMenuItem miProcRemoveBorders;
        private System.Windows.Forms.ToolStripMenuItem miProcAutoFix;
        private System.Windows.Forms.ToolStripMenuItem miProcRotate;
        private System.Windows.Forms.ToolStripMenuItem miProcRotateCW;
        private System.Windows.Forms.ToolStripMenuItem miProcRotateCCW;
        private System.Windows.Forms.ToolStripMenuItem miOCRCurrentPage;
        private System.Windows.Forms.ToolStripMenuItem miOCRAllPages;
        private System.Windows.Forms.GroupBox groupImage;
        private System.Windows.Forms.GroupBox groupValidation;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtValChequeAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValChequeDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValChequeNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValIBAN;
        private System.Windows.Forms.Label lblValIBAN;
        private System.Windows.Forms.TextBox txtValSpecialChars;
        private System.Windows.Forms.Label lblSpecialChars;
        private System.Windows.Forms.Label lblValidationIBAN;
        private System.Windows.Forms.Label lblValidationChequeNumber;
        private System.Windows.Forms.Label lblValidationChequeAmount;
        private System.Windows.Forms.Label lblValidationChequeDate;
        private System.Windows.Forms.Label lblValidationSpecialCharacters;
        private System.Windows.Forms.Label lblValidIBAN;
        private System.Windows.Forms.Label lblValidNumber;
        private System.Windows.Forms.Label lblValidDate;
        private System.Windows.Forms.Label lblValidAmount;
        private System.Windows.Forms.Label lblValidCharacters;
        private System.Windows.Forms.RichTextBox richtxtProcessorCodelineOCRB;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.GroupBox groupRotation;
        private System.Windows.Forms.Button btnRotateCCW;
        private System.Windows.Forms.Button btnRotateCW;
        private System.Windows.Forms.GroupBox groupZoom;
        private System.Windows.Forms.GroupBox groupNavigation;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.ToolStripMenuItem miProcRemoveDots;
        private System.Windows.Forms.ToolStripMenuItem miProcRemoveLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextRubberBand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupIBAN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIBANAccountNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIBANBranchCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIBANBankCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIBANCheckDigits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIBANCountryCode;
        private System.Windows.Forms.PictureBox pbUniLogo;
        private System.Windows.Forms.ToolStripMenuItem menuAboutInfo;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
    }
}