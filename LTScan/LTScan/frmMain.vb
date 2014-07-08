Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Leadtools.WinForms
Imports Leadtools.Codecs
Imports Leadtools.Forms.Ocr
Imports Leadtools.Twain
Imports System.Globalization
Imports System.Threading
Imports System.Resources
Imports LTScan.Common
Imports LTScan.Processors
Imports LTScan.Processors.Image

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _codecs As New RasterCodecs
        Dim _viewer As New RasterImageViewer
        Dim _ocrEngine As IOcrEngine

        Dim _twainSession As New TwainSession
        Dim _transferMode As TwainCapabilityValue = TwainCapabilityValue.TransferMechanismNative
        Static _twainAvailable As Boolean = False

        Dim _ocrProcessor As OCRProcessor

    End Sub
End Class