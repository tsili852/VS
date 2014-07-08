<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuScanner = New System.Windows.Forms.ToolStripMenuItem()
        Me.miScannerSelectDevice = New System.Windows.Forms.ToolStripMenuItem()
        Me.miScannerAcquireFull = New System.Windows.Forms.ToolStripMenuItem()
        Me.miScannerAcquireQuick = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbImage = New System.Windows.Forms.GroupBox()
        Me.panelImage = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.richtxtProcessorCodelineOCRB = New System.Windows.Forms.RichTextBox()
        Me.menuImageProcess = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProcAutoFix = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProcBinarize = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProcAutoCrop = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProcDeskew = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProcRemoveBorders = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProcRotate = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProcRotateCW = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProcRotateCCW = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProcRemoveDots = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProcRemoveLines = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOCR = New System.Windows.Forms.ToolStripMenuItem()
        Me.miOCRCurrent = New System.Windows.Forms.ToolStripMenuItem()
        Me.miOCRAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.miAboutInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupValidation = New System.Windows.Forms.GroupBox()
        Me.groupIBAN = New System.Windows.Forms.GroupBox()
        Me.txtIBANAccountNumber = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtIBANBranchCode = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtIBANBankCode = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtIBANCheckDigits = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtIBANCountryCode = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.lblValidationIBAN = New System.Windows.Forms.Label()
        Me.lblValidationChequeNumber = New System.Windows.Forms.Label()
        Me.lblValidationChequeAmount = New System.Windows.Forms.Label()
        Me.lblValidationChequeDate = New System.Windows.Forms.Label()
        Me.lblValidationSpecialCharacters = New System.Windows.Forms.Label()
        Me.lblValidIBAN = New System.Windows.Forms.Label()
        Me.lblValidNumber = New System.Windows.Forms.Label()
        Me.lblValidDate = New System.Windows.Forms.Label()
        Me.lblValidAmount = New System.Windows.Forms.Label()
        Me.lblValidCharacters = New System.Windows.Forms.Label()
        Me.txtValChequeAmount = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtValChequeDate = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtValChequeNumber = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtValIBAN = New System.Windows.Forms.TextBox()
        Me.lblValIBAN = New System.Windows.Forms.Label()
        Me.txtValSpecialChars = New System.Windows.Forms.TextBox()
        Me.lblSpecialChars = New System.Windows.Forms.Label()
        Me.groupRotation = New System.Windows.Forms.GroupBox()
        Me.groupZoom = New System.Windows.Forms.GroupBox()
        Me.groupNavigation = New System.Windows.Forms.GroupBox()
        Me.lblCurrentPage = New System.Windows.Forms.Label()
        Me.btnRotateCCW = New System.Windows.Forms.Button()
        Me.btnRotateCW = New System.Windows.Forms.Button()
        Me.btnZoomOut = New System.Windows.Forms.Button()
        Me.btnZoomIn = New System.Windows.Forms.Button()
        Me.btnPreviousPage = New System.Windows.Forms.Button()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.gbImage.SuspendLayout()
        Me.groupValidation.SuspendLayout()
        Me.groupIBAN.SuspendLayout()
        Me.groupRotation.SuspendLayout()
        Me.groupZoom.SuspendLayout()
        Me.groupNavigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuScanner, Me.menuImageProcess, Me.menuOCR, Me.menuAbout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(935, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuScanner
        '
        Me.menuScanner.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miScannerSelectDevice, Me.miScannerAcquireFull, Me.miScannerAcquireQuick})
        Me.menuScanner.Name = "menuScanner"
        Me.menuScanner.Size = New System.Drawing.Size(61, 20)
        Me.menuScanner.Text = "Scanner"
        '
        'miScannerSelectDevice
        '
        Me.miScannerSelectDevice.Name = "miScannerSelectDevice"
        Me.miScannerSelectDevice.Size = New System.Drawing.Size(235, 22)
        Me.miScannerSelectDevice.Text = "Select Device"
        '
        'miScannerAcquireFull
        '
        Me.miScannerAcquireFull.Name = "miScannerAcquireFull"
        Me.miScannerAcquireFull.Size = New System.Drawing.Size(235, 22)
        Me.miScannerAcquireFull.Text = "Acquire Image (Show settings)"
        '
        'miScannerAcquireQuick
        '
        Me.miScannerAcquireQuick.Name = "miScannerAcquireQuick"
        Me.miScannerAcquireQuick.Size = New System.Drawing.Size(235, 22)
        Me.miScannerAcquireQuick.Text = "Acquire Image (Hide settings)"
        '
        'gbImage
        '
        Me.gbImage.Controls.Add(Me.panelImage)
        Me.gbImage.Location = New System.Drawing.Point(12, 27)
        Me.gbImage.Name = "gbImage"
        Me.gbImage.Size = New System.Drawing.Size(587, 285)
        Me.gbImage.TabIndex = 1
        Me.gbImage.TabStop = False
        Me.gbImage.Text = "Image"
        '
        'panelImage
        '
        Me.panelImage.Location = New System.Drawing.Point(6, 19)
        Me.panelImage.Name = "panelImage"
        Me.panelImage.Size = New System.Drawing.Size(575, 260)
        Me.panelImage.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codeline :"
        '
        'richtxtProcessorCodelineOCRB
        '
        Me.richtxtProcessorCodelineOCRB.Location = New System.Drawing.Point(12, 331)
        Me.richtxtProcessorCodelineOCRB.Name = "richtxtProcessorCodelineOCRB"
        Me.richtxtProcessorCodelineOCRB.Size = New System.Drawing.Size(587, 23)
        Me.richtxtProcessorCodelineOCRB.TabIndex = 3
        Me.richtxtProcessorCodelineOCRB.Text = ""
        '
        'menuImageProcess
        '
        Me.menuImageProcess.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miProcAutoFix, Me.miProcBinarize, Me.miProcAutoCrop, Me.miProcDeskew, Me.miProcRemoveBorders, Me.miProcRotate, Me.miProcRemoveDots, Me.miProcRemoveLines})
        Me.menuImageProcess.Name = "menuImageProcess"
        Me.menuImageProcess.Size = New System.Drawing.Size(95, 20)
        Me.menuImageProcess.Text = "Image Process"
        '
        'miProcAutoFix
        '
        Me.miProcAutoFix.Name = "miProcAutoFix"
        Me.miProcAutoFix.Size = New System.Drawing.Size(160, 22)
        Me.miProcAutoFix.Text = "Auto Fix"
        '
        'miProcBinarize
        '
        Me.miProcBinarize.Name = "miProcBinarize"
        Me.miProcBinarize.Size = New System.Drawing.Size(160, 22)
        Me.miProcBinarize.Text = "Binarize"
        '
        'miProcAutoCrop
        '
        Me.miProcAutoCrop.Name = "miProcAutoCrop"
        Me.miProcAutoCrop.Size = New System.Drawing.Size(160, 22)
        Me.miProcAutoCrop.Text = "Auto Crop"
        '
        'miProcDeskew
        '
        Me.miProcDeskew.Name = "miProcDeskew"
        Me.miProcDeskew.Size = New System.Drawing.Size(160, 22)
        Me.miProcDeskew.Text = "Deskew"
        '
        'miProcRemoveBorders
        '
        Me.miProcRemoveBorders.Name = "miProcRemoveBorders"
        Me.miProcRemoveBorders.Size = New System.Drawing.Size(160, 22)
        Me.miProcRemoveBorders.Text = "Remove Borders"
        '
        'miProcRotate
        '
        Me.miProcRotate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miProcRotateCW, Me.miProcRotateCCW})
        Me.miProcRotate.Name = "miProcRotate"
        Me.miProcRotate.Size = New System.Drawing.Size(160, 22)
        Me.miProcRotate.Text = "Rotate"
        '
        'miProcRotateCW
        '
        Me.miProcRotateCW.Name = "miProcRotateCW"
        Me.miProcRotateCW.Size = New System.Drawing.Size(171, 22)
        Me.miProcRotateCW.Text = "Clockwise"
        '
        'miProcRotateCCW
        '
        Me.miProcRotateCCW.Name = "miProcRotateCCW"
        Me.miProcRotateCCW.Size = New System.Drawing.Size(171, 22)
        Me.miProcRotateCCW.Text = "Counter clockwise"
        '
        'miProcRemoveDots
        '
        Me.miProcRemoveDots.Name = "miProcRemoveDots"
        Me.miProcRemoveDots.Size = New System.Drawing.Size(160, 22)
        Me.miProcRemoveDots.Text = "Remove Dots"
        '
        'miProcRemoveLines
        '
        Me.miProcRemoveLines.Name = "miProcRemoveLines"
        Me.miProcRemoveLines.Size = New System.Drawing.Size(160, 22)
        Me.miProcRemoveLines.Text = "Remove Lines"
        '
        'menuOCR
        '
        Me.menuOCR.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miOCRCurrent, Me.miOCRAll})
        Me.menuOCR.Name = "menuOCR"
        Me.menuOCR.Size = New System.Drawing.Size(43, 20)
        Me.menuOCR.Text = "OCR"
        '
        'miOCRCurrent
        '
        Me.miOCRCurrent.Name = "miOCRCurrent"
        Me.miOCRCurrent.Size = New System.Drawing.Size(141, 22)
        Me.miOCRCurrent.Text = "OCR Current"
        '
        'miOCRAll
        '
        Me.miOCRAll.Name = "miOCRAll"
        Me.miOCRAll.Size = New System.Drawing.Size(141, 22)
        Me.miOCRAll.Text = "OCR All"
        '
        'menuAbout
        '
        Me.menuAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miAboutInfo})
        Me.menuAbout.Name = "menuAbout"
        Me.menuAbout.Size = New System.Drawing.Size(52, 20)
        Me.menuAbout.Text = "About"
        '
        'miAboutInfo
        '
        Me.miAboutInfo.Name = "miAboutInfo"
        Me.miAboutInfo.Size = New System.Drawing.Size(95, 22)
        Me.miAboutInfo.Text = "Info"
        '
        'groupValidation
        '
        Me.groupValidation.Controls.Add(Me.groupIBAN)
        Me.groupValidation.Controls.Add(Me.lblValidationIBAN)
        Me.groupValidation.Controls.Add(Me.lblValidationChequeNumber)
        Me.groupValidation.Controls.Add(Me.lblValidationChequeAmount)
        Me.groupValidation.Controls.Add(Me.lblValidationChequeDate)
        Me.groupValidation.Controls.Add(Me.lblValidationSpecialCharacters)
        Me.groupValidation.Controls.Add(Me.lblValidIBAN)
        Me.groupValidation.Controls.Add(Me.lblValidNumber)
        Me.groupValidation.Controls.Add(Me.lblValidDate)
        Me.groupValidation.Controls.Add(Me.lblValidAmount)
        Me.groupValidation.Controls.Add(Me.lblValidCharacters)
        Me.groupValidation.Controls.Add(Me.txtValChequeAmount)
        Me.groupValidation.Controls.Add(Me.label5)
        Me.groupValidation.Controls.Add(Me.txtValChequeDate)
        Me.groupValidation.Controls.Add(Me.label4)
        Me.groupValidation.Controls.Add(Me.txtValChequeNumber)
        Me.groupValidation.Controls.Add(Me.label3)
        Me.groupValidation.Controls.Add(Me.txtValIBAN)
        Me.groupValidation.Controls.Add(Me.lblValIBAN)
        Me.groupValidation.Controls.Add(Me.txtValSpecialChars)
        Me.groupValidation.Controls.Add(Me.lblSpecialChars)
        Me.groupValidation.Location = New System.Drawing.Point(616, 12)
        Me.groupValidation.Name = "groupValidation"
        Me.groupValidation.Size = New System.Drawing.Size(307, 485)
        Me.groupValidation.TabIndex = 4
        Me.groupValidation.TabStop = False
        Me.groupValidation.Text = "Validation"
        '
        'groupIBAN
        '
        Me.groupIBAN.Controls.Add(Me.txtIBANAccountNumber)
        Me.groupIBAN.Controls.Add(Me.label10)
        Me.groupIBAN.Controls.Add(Me.txtIBANBranchCode)
        Me.groupIBAN.Controls.Add(Me.label9)
        Me.groupIBAN.Controls.Add(Me.txtIBANBankCode)
        Me.groupIBAN.Controls.Add(Me.label8)
        Me.groupIBAN.Controls.Add(Me.txtIBANCheckDigits)
        Me.groupIBAN.Controls.Add(Me.label7)
        Me.groupIBAN.Controls.Add(Me.txtIBANCountryCode)
        Me.groupIBAN.Controls.Add(Me.label6)
        Me.groupIBAN.Location = New System.Drawing.Point(13, 276)
        Me.groupIBAN.Name = "groupIBAN"
        Me.groupIBAN.Size = New System.Drawing.Size(288, 201)
        Me.groupIBAN.TabIndex = 30
        Me.groupIBAN.TabStop = False
        Me.groupIBAN.Text = "IBAN Analysis"
        '
        'txtIBANAccountNumber
        '
        Me.txtIBANAccountNumber.Location = New System.Drawing.Point(96, 159)
        Me.txtIBANAccountNumber.Name = "txtIBANAccountNumber"
        Me.txtIBANAccountNumber.ReadOnly = True
        Me.txtIBANAccountNumber.Size = New System.Drawing.Size(186, 20)
        Me.txtIBANAccountNumber.TabIndex = 9
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label10.Location = New System.Drawing.Point(2, 162)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(90, 13)
        Me.label10.TabIndex = 8
        Me.label10.Text = "Account Number:"
        '
        'txtIBANBranchCode
        '
        Me.txtIBANBranchCode.Location = New System.Drawing.Point(96, 126)
        Me.txtIBANBranchCode.Name = "txtIBANBranchCode"
        Me.txtIBANBranchCode.ReadOnly = True
        Me.txtIBANBranchCode.Size = New System.Drawing.Size(186, 20)
        Me.txtIBANBranchCode.TabIndex = 7
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label9.Location = New System.Drawing.Point(20, 129)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(72, 13)
        Me.label9.TabIndex = 6
        Me.label9.Text = "Branch Code:"
        '
        'txtIBANBankCode
        '
        Me.txtIBANBankCode.Location = New System.Drawing.Point(96, 93)
        Me.txtIBANBankCode.Name = "txtIBANBankCode"
        Me.txtIBANBankCode.ReadOnly = True
        Me.txtIBANBankCode.Size = New System.Drawing.Size(186, 20)
        Me.txtIBANBankCode.TabIndex = 5
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label8.Location = New System.Drawing.Point(29, 96)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(63, 13)
        Me.label8.TabIndex = 4
        Me.label8.Text = "Bank Code:"
        '
        'txtIBANCheckDigits
        '
        Me.txtIBANCheckDigits.Location = New System.Drawing.Point(96, 60)
        Me.txtIBANCheckDigits.Name = "txtIBANCheckDigits"
        Me.txtIBANCheckDigits.ReadOnly = True
        Me.txtIBANCheckDigits.Size = New System.Drawing.Size(186, 20)
        Me.txtIBANCheckDigits.TabIndex = 3
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label7.Location = New System.Drawing.Point(22, 63)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(70, 13)
        Me.label7.TabIndex = 2
        Me.label7.Text = "Check Digits:"
        '
        'txtIBANCountryCode
        '
        Me.txtIBANCountryCode.Location = New System.Drawing.Point(96, 27)
        Me.txtIBANCountryCode.Name = "txtIBANCountryCode"
        Me.txtIBANCountryCode.ReadOnly = True
        Me.txtIBANCountryCode.Size = New System.Drawing.Size(186, 20)
        Me.txtIBANCountryCode.TabIndex = 1
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label6.Location = New System.Drawing.Point(18, 30)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(74, 13)
        Me.label6.TabIndex = 0
        Me.label6.Text = "Country Code:"
        '
        'lblValidationIBAN
        '
        Me.lblValidationIBAN.AutoSize = True
        Me.lblValidationIBAN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValidationIBAN.Location = New System.Drawing.Point(205, 88)
        Me.lblValidationIBAN.Name = "lblValidationIBAN"
        Me.lblValidationIBAN.Size = New System.Drawing.Size(0, 13)
        Me.lblValidationIBAN.TabIndex = 29
        '
        'lblValidationChequeNumber
        '
        Me.lblValidationChequeNumber.AutoSize = True
        Me.lblValidationChequeNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValidationChequeNumber.Location = New System.Drawing.Point(205, 139)
        Me.lblValidationChequeNumber.Name = "lblValidationChequeNumber"
        Me.lblValidationChequeNumber.Size = New System.Drawing.Size(0, 13)
        Me.lblValidationChequeNumber.TabIndex = 28
        '
        'lblValidationChequeAmount
        '
        Me.lblValidationChequeAmount.AutoSize = True
        Me.lblValidationChequeAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValidationChequeAmount.Location = New System.Drawing.Point(205, 239)
        Me.lblValidationChequeAmount.Name = "lblValidationChequeAmount"
        Me.lblValidationChequeAmount.Size = New System.Drawing.Size(0, 13)
        Me.lblValidationChequeAmount.TabIndex = 27
        '
        'lblValidationChequeDate
        '
        Me.lblValidationChequeDate.AutoSize = True
        Me.lblValidationChequeDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValidationChequeDate.Location = New System.Drawing.Point(205, 189)
        Me.lblValidationChequeDate.Name = "lblValidationChequeDate"
        Me.lblValidationChequeDate.Size = New System.Drawing.Size(0, 13)
        Me.lblValidationChequeDate.TabIndex = 26
        '
        'lblValidationSpecialCharacters
        '
        Me.lblValidationSpecialCharacters.AutoSize = True
        Me.lblValidationSpecialCharacters.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValidationSpecialCharacters.Location = New System.Drawing.Point(205, 39)
        Me.lblValidationSpecialCharacters.Name = "lblValidationSpecialCharacters"
        Me.lblValidationSpecialCharacters.Size = New System.Drawing.Size(0, 13)
        Me.lblValidationSpecialCharacters.TabIndex = 25
        '
        'lblValidIBAN
        '
        Me.lblValidIBAN.AutoSize = True
        Me.lblValidIBAN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValidIBAN.Location = New System.Drawing.Point(153, 141)
        Me.lblValidIBAN.Name = "lblValidIBAN"
        Me.lblValidIBAN.Size = New System.Drawing.Size(0, 13)
        Me.lblValidIBAN.TabIndex = 24
        '
        'lblValidNumber
        '
        Me.lblValidNumber.AutoSize = True
        Me.lblValidNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValidNumber.Location = New System.Drawing.Point(153, 167)
        Me.lblValidNumber.Name = "lblValidNumber"
        Me.lblValidNumber.Size = New System.Drawing.Size(0, 13)
        Me.lblValidNumber.TabIndex = 23
        '
        'lblValidDate
        '
        Me.lblValidDate.AutoSize = True
        Me.lblValidDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValidDate.Location = New System.Drawing.Point(153, 193)
        Me.lblValidDate.Name = "lblValidDate"
        Me.lblValidDate.Size = New System.Drawing.Size(0, 13)
        Me.lblValidDate.TabIndex = 22
        '
        'lblValidAmount
        '
        Me.lblValidAmount.AutoSize = True
        Me.lblValidAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValidAmount.Location = New System.Drawing.Point(153, 219)
        Me.lblValidAmount.Name = "lblValidAmount"
        Me.lblValidAmount.Size = New System.Drawing.Size(0, 13)
        Me.lblValidAmount.TabIndex = 21
        '
        'lblValidCharacters
        '
        Me.lblValidCharacters.AutoSize = True
        Me.lblValidCharacters.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValidCharacters.Location = New System.Drawing.Point(153, 115)
        Me.lblValidCharacters.Name = "lblValidCharacters"
        Me.lblValidCharacters.Size = New System.Drawing.Size(0, 13)
        Me.lblValidCharacters.TabIndex = 20
        '
        'txtValChequeAmount
        '
        Me.txtValChequeAmount.Location = New System.Drawing.Point(13, 236)
        Me.txtValChequeAmount.Name = "txtValChequeAmount"
        Me.txtValChequeAmount.Size = New System.Drawing.Size(186, 20)
        Me.txtValChequeAmount.TabIndex = 19
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label5.Location = New System.Drawing.Point(10, 220)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(46, 13)
        Me.label5.TabIndex = 18
        Me.label5.Text = "Amount:"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtValChequeDate
        '
        Me.txtValChequeDate.Location = New System.Drawing.Point(13, 186)
        Me.txtValChequeDate.Name = "txtValChequeDate"
        Me.txtValChequeDate.Size = New System.Drawing.Size(186, 20)
        Me.txtValChequeDate.TabIndex = 17
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label4.Location = New System.Drawing.Point(10, 170)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(73, 13)
        Me.label4.TabIndex = 16
        Me.label4.Text = "Cheque Date:"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtValChequeNumber
        '
        Me.txtValChequeNumber.Location = New System.Drawing.Point(13, 136)
        Me.txtValChequeNumber.Name = "txtValChequeNumber"
        Me.txtValChequeNumber.Size = New System.Drawing.Size(186, 20)
        Me.txtValChequeNumber.TabIndex = 15
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label3.Location = New System.Drawing.Point(10, 120)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(87, 13)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Cheque Number:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtValIBAN
        '
        Me.txtValIBAN.Location = New System.Drawing.Point(13, 85)
        Me.txtValIBAN.Name = "txtValIBAN"
        Me.txtValIBAN.Size = New System.Drawing.Size(186, 20)
        Me.txtValIBAN.TabIndex = 13
        '
        'lblValIBAN
        '
        Me.lblValIBAN.AutoSize = True
        Me.lblValIBAN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValIBAN.Location = New System.Drawing.Point(10, 70)
        Me.lblValIBAN.Name = "lblValIBAN"
        Me.lblValIBAN.Size = New System.Drawing.Size(35, 13)
        Me.lblValIBAN.TabIndex = 12
        Me.lblValIBAN.Text = "IBAN:"
        Me.lblValIBAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtValSpecialChars
        '
        Me.txtValSpecialChars.Location = New System.Drawing.Point(13, 36)
        Me.txtValSpecialChars.Name = "txtValSpecialChars"
        Me.txtValSpecialChars.Size = New System.Drawing.Size(186, 20)
        Me.txtValSpecialChars.TabIndex = 11
        '
        'lblSpecialChars
        '
        Me.lblSpecialChars.AutoSize = True
        Me.lblSpecialChars.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSpecialChars.Location = New System.Drawing.Point(10, 20)
        Me.lblSpecialChars.Name = "lblSpecialChars"
        Me.lblSpecialChars.Size = New System.Drawing.Size(99, 13)
        Me.lblSpecialChars.TabIndex = 10
        Me.lblSpecialChars.Text = "Special Characters:"
        Me.lblSpecialChars.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'groupRotation
        '
        Me.groupRotation.Controls.Add(Me.btnRotateCCW)
        Me.groupRotation.Controls.Add(Me.btnRotateCW)
        Me.groupRotation.Location = New System.Drawing.Point(322, 367)
        Me.groupRotation.Name = "groupRotation"
        Me.groupRotation.Size = New System.Drawing.Size(149, 100)
        Me.groupRotation.TabIndex = 18
        Me.groupRotation.TabStop = False
        Me.groupRotation.Text = "Rotation"
        '
        'groupZoom
        '
        Me.groupZoom.Controls.Add(Me.btnZoomOut)
        Me.groupZoom.Controls.Add(Me.btnZoomIn)
        Me.groupZoom.Location = New System.Drawing.Point(167, 367)
        Me.groupZoom.Name = "groupZoom"
        Me.groupZoom.Size = New System.Drawing.Size(149, 100)
        Me.groupZoom.TabIndex = 17
        Me.groupZoom.TabStop = False
        Me.groupZoom.Text = "Zoom"
        '
        'groupNavigation
        '
        Me.groupNavigation.Controls.Add(Me.lblCurrentPage)
        Me.groupNavigation.Controls.Add(Me.btnPreviousPage)
        Me.groupNavigation.Controls.Add(Me.btnNextPage)
        Me.groupNavigation.Location = New System.Drawing.Point(12, 367)
        Me.groupNavigation.Name = "groupNavigation"
        Me.groupNavigation.Size = New System.Drawing.Size(149, 100)
        Me.groupNavigation.TabIndex = 16
        Me.groupNavigation.TabStop = False
        Me.groupNavigation.Text = "Navigation"
        '
        'lblCurrentPage
        '
        Me.lblCurrentPage.AutoSize = True
        Me.lblCurrentPage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCurrentPage.Location = New System.Drawing.Point(6, 84)
        Me.lblCurrentPage.Name = "lblCurrentPage"
        Me.lblCurrentPage.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrentPage.TabIndex = 16
        '
        'btnRotateCCW
        '
        Me.btnRotateCCW.Image = Global.LTScan.My.Resources.Resources.rotate_ccw_icon
        Me.btnRotateCCW.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRotateCCW.Location = New System.Drawing.Point(6, 19)
        Me.btnRotateCCW.Name = "btnRotateCCW"
        Me.btnRotateCCW.Size = New System.Drawing.Size(35, 35)
        Me.btnRotateCCW.TabIndex = 11
        Me.btnRotateCCW.UseVisualStyleBackColor = True
        '
        'btnRotateCW
        '
        Me.btnRotateCW.Image = Global.LTScan.My.Resources.Resources.rotate_cw_icon
        Me.btnRotateCW.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRotateCW.Location = New System.Drawing.Point(47, 19)
        Me.btnRotateCW.Name = "btnRotateCW"
        Me.btnRotateCW.Size = New System.Drawing.Size(35, 35)
        Me.btnRotateCW.TabIndex = 12
        Me.btnRotateCW.UseVisualStyleBackColor = True
        '
        'btnZoomOut
        '
        Me.btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnZoomOut.Image = Global.LTScan.My.Resources.Resources.Zoom_Out_icon
        Me.btnZoomOut.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnZoomOut.Location = New System.Drawing.Point(6, 19)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(35, 35)
        Me.btnZoomOut.TabIndex = 10
        Me.btnZoomOut.UseVisualStyleBackColor = True
        '
        'btnZoomIn
        '
        Me.btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnZoomIn.Image = Global.LTScan.My.Resources.Resources.Zoom_In_icon
        Me.btnZoomIn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnZoomIn.Location = New System.Drawing.Point(47, 19)
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(35, 35)
        Me.btnZoomIn.TabIndex = 9
        Me.btnZoomIn.UseVisualStyleBackColor = True
        '
        'btnPreviousPage
        '
        Me.btnPreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPreviousPage.Image = Global.LTScan.My.Resources.Resources.Previous_icon
        Me.btnPreviousPage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPreviousPage.Location = New System.Drawing.Point(6, 19)
        Me.btnPreviousPage.Name = "btnPreviousPage"
        Me.btnPreviousPage.Size = New System.Drawing.Size(35, 35)
        Me.btnPreviousPage.TabIndex = 7
        Me.btnPreviousPage.UseVisualStyleBackColor = True
        '
        'btnNextPage
        '
        Me.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNextPage.Image = Global.LTScan.My.Resources.Resources.Next_icon
        Me.btnNextPage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNextPage.Location = New System.Drawing.Point(47, 19)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(35, 35)
        Me.btnNextPage.TabIndex = 8
        Me.btnNextPage.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 500)
        Me.Controls.Add(Me.groupRotation)
        Me.Controls.Add(Me.groupZoom)
        Me.Controls.Add(Me.groupNavigation)
        Me.Controls.Add(Me.groupValidation)
        Me.Controls.Add(Me.richtxtProcessorCodelineOCRB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbImage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Unisystems Cheque Processing"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbImage.ResumeLayout(False)
        Me.groupValidation.ResumeLayout(False)
        Me.groupValidation.PerformLayout()
        Me.groupIBAN.ResumeLayout(False)
        Me.groupIBAN.PerformLayout()
        Me.groupRotation.ResumeLayout(False)
        Me.groupZoom.ResumeLayout(False)
        Me.groupNavigation.ResumeLayout(False)
        Me.groupNavigation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuScanner As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miScannerSelectDevice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miScannerAcquireFull As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miScannerAcquireQuick As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuImageProcess As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProcAutoFix As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProcBinarize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProcAutoCrop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProcDeskew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProcRemoveBorders As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProcRotate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProcRotateCW As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProcRotateCCW As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbImage As System.Windows.Forms.GroupBox
    Friend WithEvents panelImage As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents richtxtProcessorCodelineOCRB As System.Windows.Forms.RichTextBox
    Friend WithEvents miProcRemoveDots As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProcRemoveLines As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOCR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miOCRCurrent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miOCRAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miAboutInfo As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents groupValidation As System.Windows.Forms.GroupBox
    Private WithEvents groupIBAN As System.Windows.Forms.GroupBox
    Private WithEvents txtIBANAccountNumber As System.Windows.Forms.TextBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents txtIBANBranchCode As System.Windows.Forms.TextBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents txtIBANBankCode As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents txtIBANCheckDigits As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txtIBANCountryCode As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents lblValidationIBAN As System.Windows.Forms.Label
    Private WithEvents lblValidationChequeNumber As System.Windows.Forms.Label
    Private WithEvents lblValidationChequeAmount As System.Windows.Forms.Label
    Private WithEvents lblValidationChequeDate As System.Windows.Forms.Label
    Private WithEvents lblValidationSpecialCharacters As System.Windows.Forms.Label
    Private WithEvents lblValidIBAN As System.Windows.Forms.Label
    Private WithEvents lblValidNumber As System.Windows.Forms.Label
    Private WithEvents lblValidDate As System.Windows.Forms.Label
    Private WithEvents lblValidAmount As System.Windows.Forms.Label
    Private WithEvents lblValidCharacters As System.Windows.Forms.Label
    Private WithEvents txtValChequeAmount As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txtValChequeDate As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtValChequeNumber As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txtValIBAN As System.Windows.Forms.TextBox
    Private WithEvents lblValIBAN As System.Windows.Forms.Label
    Private WithEvents txtValSpecialChars As System.Windows.Forms.TextBox
    Private WithEvents lblSpecialChars As System.Windows.Forms.Label
    Private WithEvents groupRotation As System.Windows.Forms.GroupBox
    Private WithEvents btnRotateCCW As System.Windows.Forms.Button
    Private WithEvents btnRotateCW As System.Windows.Forms.Button
    Private WithEvents groupZoom As System.Windows.Forms.GroupBox
    Private WithEvents btnZoomOut As System.Windows.Forms.Button
    Private WithEvents btnZoomIn As System.Windows.Forms.Button
    Private WithEvents groupNavigation As System.Windows.Forms.GroupBox
    Private WithEvents lblCurrentPage As System.Windows.Forms.Label
    Private WithEvents btnPreviousPage As System.Windows.Forms.Button
    Private WithEvents btnNextPage As System.Windows.Forms.Button
End Class
