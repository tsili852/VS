﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckScanningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdinaryChecksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PostdatedChecksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckMaintenancToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodaysChecksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PostdatedChecksToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PostdatedOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForTodayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RejectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΟδηγίεςΕφαρμογήςToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΈλεγχοςΓιαΕνημερώσειςToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdinaryChecksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PostdatedChecksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodaysScansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΡυθμήσειςToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuditLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΓλώσσαToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΕλληνικάToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΑγγλικάToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonPnl = New System.Windows.Forms.Panel()
        Me.helpBtn = New System.Windows.Forms.Button()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.endOfDayBtn = New System.Windows.Forms.Button()
        Me.quitBtn = New System.Windows.Forms.Button()
        Me.scanBtn = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ButtonPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.HelpMenu, Me.SearchToolStripMenuItem, Me.StatisticsToolStripMenuItem, Me.ΡυθμήσειςToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(885, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckScanningToolStripMenuItem, Me.CheckMaintenancToolStripMenuItem, Me.PostdatedOperationsToolStripMenuItem, Me.ToolStripSeparator2, Me.HubToolStripMenuItem, Me.UserActionsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileMenu.Image = Global.ChScan.My.Resources.Resources.work
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(93, 20)
        Me.FileMenu.Text = "&Operations"
        '
        'CheckScanningToolStripMenuItem
        '
        Me.CheckScanningToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdinaryChecksToolStripMenuItem1, Me.PostdatedChecksToolStripMenuItem1})
        Me.CheckScanningToolStripMenuItem.Image = CType(resources.GetObject("CheckScanningToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CheckScanningToolStripMenuItem.Name = "CheckScanningToolStripMenuItem"
        Me.CheckScanningToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CheckScanningToolStripMenuItem.Text = "Check Scanning"
        '
        'OrdinaryChecksToolStripMenuItem1
        '
        Me.OrdinaryChecksToolStripMenuItem1.Name = "OrdinaryChecksToolStripMenuItem1"
        Me.OrdinaryChecksToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.OrdinaryChecksToolStripMenuItem1.Text = "Ordinary Checks"
        '
        'PostdatedChecksToolStripMenuItem1
        '
        Me.PostdatedChecksToolStripMenuItem1.Name = "PostdatedChecksToolStripMenuItem1"
        Me.PostdatedChecksToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.PostdatedChecksToolStripMenuItem1.Text = "Postdated Checks"
        '
        'CheckMaintenancToolStripMenuItem
        '
        Me.CheckMaintenancToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodaysChecksToolStripMenuItem, Me.PostdatedChecksToolStripMenuItem2})
        Me.CheckMaintenancToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.maintenance
        Me.CheckMaintenancToolStripMenuItem.Name = "CheckMaintenancToolStripMenuItem"
        Me.CheckMaintenancToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CheckMaintenancToolStripMenuItem.Text = "Check Maintenance"
        '
        'TodaysChecksToolStripMenuItem
        '
        Me.TodaysChecksToolStripMenuItem.Name = "TodaysChecksToolStripMenuItem"
        Me.TodaysChecksToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.TodaysChecksToolStripMenuItem.Text = "Today's Checks"
        '
        'PostdatedChecksToolStripMenuItem2
        '
        Me.PostdatedChecksToolStripMenuItem2.Name = "PostdatedChecksToolStripMenuItem2"
        Me.PostdatedChecksToolStripMenuItem2.Size = New System.Drawing.Size(168, 22)
        Me.PostdatedChecksToolStripMenuItem2.Text = "Postdated Checks"
        '
        'PostdatedOperationsToolStripMenuItem
        '
        Me.PostdatedOperationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForTodayToolStripMenuItem})
        Me.PostdatedOperationsToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.postdated
        Me.PostdatedOperationsToolStripMenuItem.Name = "PostdatedOperationsToolStripMenuItem"
        Me.PostdatedOperationsToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PostdatedOperationsToolStripMenuItem.Text = "Postdated Operations"
        '
        'CheckForTodayToolStripMenuItem
        '
        Me.CheckForTodayToolStripMenuItem.Name = "CheckForTodayToolStripMenuItem"
        Me.CheckForTodayToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CheckForTodayToolStripMenuItem.Text = "Today's pending checks"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(185, 6)
        '
        'HubToolStripMenuItem
        '
        Me.HubToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendToolStripMenuItem, Me.ReturnsToolStripMenuItem, Me.RejectionsToolStripMenuItem})
        Me.HubToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.hub
        Me.HubToolStripMenuItem.Name = "HubToolStripMenuItem"
        Me.HubToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.HubToolStripMenuItem.Text = "Hub Actions"
        '
        'SendToolStripMenuItem
        '
        Me.SendToolStripMenuItem.Name = "SendToolStripMenuItem"
        Me.SendToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.SendToolStripMenuItem.Text = "Send"
        '
        'ReturnsToolStripMenuItem
        '
        Me.ReturnsToolStripMenuItem.Name = "ReturnsToolStripMenuItem"
        Me.ReturnsToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ReturnsToolStripMenuItem.Text = "Returns"
        '
        'RejectionsToolStripMenuItem
        '
        Me.RejectionsToolStripMenuItem.Name = "RejectionsToolStripMenuItem"
        Me.RejectionsToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.RejectionsToolStripMenuItem.Text = "Rejections"
        '
        'UserActionsToolStripMenuItem
        '
        Me.UserActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOffToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.UserActionsToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources._me
        Me.UserActionsToolStripMenuItem.Name = "UserActionsToolStripMenuItem"
        Me.UserActionsToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.UserActionsToolStripMenuItem.Text = "User Actions"
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.logoff
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogOffToolStripMenuItem.Text = "Log off"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.key
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(185, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.quit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpMenu
        '
        Me.HelpMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ΟδηγίεςΕφαρμογήςToolStripMenuItem, Me.ΈλεγχοςΓιαΕνημερώσειςToolStripMenuItem})
        Me.HelpMenu.Image = Global.ChScan.My.Resources.Resources.help
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(60, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.about
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'ΟδηγίεςΕφαρμογήςToolStripMenuItem
        '
        Me.ΟδηγίεςΕφαρμογήςToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.manual
        Me.ΟδηγίεςΕφαρμογήςToolStripMenuItem.Name = "ΟδηγίεςΕφαρμογήςToolStripMenuItem"
        Me.ΟδηγίεςΕφαρμογήςToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ΟδηγίεςΕφαρμογήςToolStripMenuItem.Text = "User Manual"
        '
        'ΈλεγχοςΓιαΕνημερώσειςToolStripMenuItem
        '
        Me.ΈλεγχοςΓιαΕνημερώσειςToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.download
        Me.ΈλεγχοςΓιαΕνημερώσειςToolStripMenuItem.Name = "ΈλεγχοςΓιαΕνημερώσειςToolStripMenuItem"
        Me.ΈλεγχοςΓιαΕνημερώσειςToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ΈλεγχοςΓιαΕνημερώσειςToolStripMenuItem.Text = "Check for Updates"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdinaryChecksToolStripMenuItem, Me.PostdatedChecksToolStripMenuItem})
        Me.SearchToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.search
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'OrdinaryChecksToolStripMenuItem
        '
        Me.OrdinaryChecksToolStripMenuItem.Name = "OrdinaryChecksToolStripMenuItem"
        Me.OrdinaryChecksToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.OrdinaryChecksToolStripMenuItem.Text = "Ordinary Checks"
        '
        'PostdatedChecksToolStripMenuItem
        '
        Me.PostdatedChecksToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.postdated
        Me.PostdatedChecksToolStripMenuItem.Name = "PostdatedChecksToolStripMenuItem"
        Me.PostdatedChecksToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.PostdatedChecksToolStripMenuItem.Text = "Postdated Checks"
        '
        'StatisticsToolStripMenuItem
        '
        Me.StatisticsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodaysScansToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.StatisticsToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.chart
        Me.StatisticsToolStripMenuItem.Name = "StatisticsToolStripMenuItem"
        Me.StatisticsToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.StatisticsToolStripMenuItem.Text = "Statistics"
        '
        'TodaysScansToolStripMenuItem
        '
        Me.TodaysScansToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.today
        Me.TodaysScansToolStripMenuItem.Name = "TodaysScansToolStripMenuItem"
        Me.TodaysScansToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.TodaysScansToolStripMenuItem.Text = "Today's Scans"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.report
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ΡυθμήσειςToolStripMenuItem
        '
        Me.ΡυθμήσειςToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.AdministrationToolStripMenuItem, Me.ΓλώσσαToolStripMenuItem})
        Me.ΡυθμήσειςToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.tool
        Me.ΡυθμήσειςToolStripMenuItem.Name = "ΡυθμήσειςToolStripMenuItem"
        Me.ΡυθμήσειςToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ΡυθμήσειςToolStripMenuItem.Text = "Tools"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.settings
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMainToolStripMenuItem, Me.SystemSettingsToolStripMenuItem, Me.AuditLogToolStripMenuItem})
        Me.AdministrationToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.admin
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AdministrationToolStripMenuItem.Text = "Administration"
        '
        'UserMainToolStripMenuItem
        '
        Me.UserMainToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.user
        Me.UserMainToolStripMenuItem.Name = "UserMainToolStripMenuItem"
        Me.UserMainToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.UserMainToolStripMenuItem.Text = "User Maintenance"
        '
        'SystemSettingsToolStripMenuItem
        '
        Me.SystemSettingsToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.system
        Me.SystemSettingsToolStripMenuItem.Name = "SystemSettingsToolStripMenuItem"
        Me.SystemSettingsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SystemSettingsToolStripMenuItem.Text = "System Settings"
        '
        'AuditLogToolStripMenuItem
        '
        Me.AuditLogToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.audit
        Me.AuditLogToolStripMenuItem.Name = "AuditLogToolStripMenuItem"
        Me.AuditLogToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AuditLogToolStripMenuItem.Text = "Audit Log"
        '
        'ΓλώσσαToolStripMenuItem
        '
        Me.ΓλώσσαToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ΕλληνικάToolStripMenuItem, Me.ΑγγλικάToolStripMenuItem})
        Me.ΓλώσσαToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.language
        Me.ΓλώσσαToolStripMenuItem.Name = "ΓλώσσαToolStripMenuItem"
        Me.ΓλώσσαToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ΓλώσσαToolStripMenuItem.Text = "Language"
        '
        'ΕλληνικάToolStripMenuItem
        '
        Me.ΕλληνικάToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.elFlag
        Me.ΕλληνικάToolStripMenuItem.Name = "ΕλληνικάToolStripMenuItem"
        Me.ΕλληνικάToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ΕλληνικάToolStripMenuItem.Text = "Greek"
        '
        'ΑγγλικάToolStripMenuItem
        '
        Me.ΑγγλικάToolStripMenuItem.Image = Global.ChScan.My.Resources.Resources.enFlag
        Me.ΑγγλικάToolStripMenuItem.Name = "ΑγγλικάToolStripMenuItem"
        Me.ΑγγλικάToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ΑγγλικάToolStripMenuItem.Text = "English"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 461)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(885, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'ButtonPnl
        '
        Me.ButtonPnl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPnl.BackColor = System.Drawing.Color.White
        Me.ButtonPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ButtonPnl.Controls.Add(Me.helpBtn)
        Me.ButtonPnl.Controls.Add(Me.searchBtn)
        Me.ButtonPnl.Controls.Add(Me.endOfDayBtn)
        Me.ButtonPnl.Controls.Add(Me.quitBtn)
        Me.ButtonPnl.Controls.Add(Me.scanBtn)
        Me.ButtonPnl.Location = New System.Drawing.Point(12, 35)
        Me.ButtonPnl.Name = "ButtonPnl"
        Me.ButtonPnl.Size = New System.Drawing.Size(861, 52)
        Me.ButtonPnl.TabIndex = 9
        '
        'helpBtn
        '
        Me.helpBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.helpBtn.Image = Global.ChScan.My.Resources.Resources.manual
        Me.helpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.helpBtn.Location = New System.Drawing.Point(813, 3)
        Me.helpBtn.Name = "helpBtn"
        Me.helpBtn.Size = New System.Drawing.Size(41, 42)
        Me.helpBtn.TabIndex = 4
        Me.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.helpBtn.UseVisualStyleBackColor = True
        '
        'searchBtn
        '
        Me.searchBtn.Image = Global.ChScan.My.Resources.Resources.search
        Me.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.searchBtn.Location = New System.Drawing.Point(85, 3)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(79, 42)
        Me.searchBtn.TabIndex = 3
        Me.searchBtn.Text = "Search"
        Me.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'endOfDayBtn
        '
        Me.endOfDayBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.endOfDayBtn.Image = Global.ChScan.My.Resources.Resources.calendar
        Me.endOfDayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.endOfDayBtn.Location = New System.Drawing.Point(637, 3)
        Me.endOfDayBtn.Name = "endOfDayBtn"
        Me.endOfDayBtn.Size = New System.Drawing.Size(101, 42)
        Me.endOfDayBtn.TabIndex = 2
        Me.endOfDayBtn.Text = "End of Day"
        Me.endOfDayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.endOfDayBtn.UseVisualStyleBackColor = True
        '
        'quitBtn
        '
        Me.quitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quitBtn.Image = Global.ChScan.My.Resources.Resources.quit
        Me.quitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.quitBtn.Location = New System.Drawing.Point(744, 3)
        Me.quitBtn.Name = "quitBtn"
        Me.quitBtn.Size = New System.Drawing.Size(63, 42)
        Me.quitBtn.TabIndex = 1
        Me.quitBtn.Text = "Exit"
        Me.quitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.quitBtn.UseVisualStyleBackColor = True
        '
        'scanBtn
        '
        Me.scanBtn.Image = CType(resources.GetObject("scanBtn.Image"), System.Drawing.Image)
        Me.scanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.scanBtn.Location = New System.Drawing.Point(3, 3)
        Me.scanBtn.Name = "scanBtn"
        Me.scanBtn.Size = New System.Drawing.Size(76, 42)
        Me.scanBtn.TabIndex = 0
        Me.scanBtn.Text = "Scan"
        Me.scanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.scanBtn.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ChScan.My.Resources.Resources.wallpaper
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(885, 483)
        Me.Controls.Add(Me.ButtonPnl)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Main"
        Me.Text = "Ch Scan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ButtonPnl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ΟδηγίεςΕφαρμογήςToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ΈλεγχοςΓιαΕνημερώσειςToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ΡυθμήσειςToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ΓλώσσαToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ΕλληνικάToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ΑγγλικάToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonPnl As System.Windows.Forms.Panel
    Friend WithEvents scanBtn As System.Windows.Forms.Button
    Friend WithEvents quitBtn As System.Windows.Forms.Button
    Friend WithEvents HubToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RejectionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckMaintenancToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodaysChecksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckScanningToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdinaryChecksToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostdatedChecksToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdinaryChecksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostdatedChecksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostdatedChecksToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostdatedOperationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForTodayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserMainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuditLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatisticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodaysScansToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents endOfDayBtn As System.Windows.Forms.Button
    Friend WithEvents searchBtn As System.Windows.Forms.Button
    Friend WithEvents helpBtn As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
