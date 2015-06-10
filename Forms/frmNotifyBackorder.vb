Imports System.Web.Mail
Imports System.Web.Services
Imports System.Net.Mail

Public Class frmNotifyBackorder
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents DsTKSI1 As dsTKSI
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DsTKSI1 = New dsTKSI
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'DsTKSI1
        '
        Me.DsTKSI1.DataSetName = "dsTKSI"
        Me.DsTKSI1.EnforceConstraints = False
        Me.DsTKSI1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'frmNotifyBackorder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 0)
        Me.Name = "frmNotifyBackorder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sending applicable email..."
        CType(Me.DsTKSI1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private oJob As New JobObj
    Public sPOfilter As String = ""

    Friend Sub SendBackorderPOEmailToSales()
        Try
            oJob.SelectBackorderInfo(Me.DsTKSI1)

            'Dim drJob As dsTKSI.tJobRow
            Dim drPO As dsTKSI.tPOHeaderRow
            Dim drSales As dsTKSI.tEmployeeRow

            For Each drPO In Me.DsTKSI1.tPOHeader
                If Not drPO.IsDDELNull Then
                    If drPO.DDEL >= Today.Date.AddDays(-1) Then
                        If UCase(drPO.sPONum.Trim) = UCase(sPOfilter.Trim) Then
                            For Each drSales In Me.DsTKSI1.tEmployee
                                If drSales.nickname = drPO.tJobRow.sSalesperson Then
                                    SendEmailBackorder(drPO.sPONum, drPO.tVendorRow.sName & vbCrLf & drPO.SRECNOTES & vbCrLf & drPO.sShipto3 & vbCrLf & drPO.sShipTo1, drSales.email)
                                    Exit For
                                End If
                            Next
                        End If
                    End If
                End If
            Next

        Catch ex As Exception
            Windows.Forms.MessageBox.Show("An error occured while running the email notify program.  " & ex.Message)
        End Try
    End Sub

    Private Sub SendEmailBackorder(ByVal sPO As String, ByVal sNotes As String, ByVal sSalesperson As String)
        Try


            Dim address As New MailAddressCollection
            address.Add(New MailAddress("jason@thekitchenshowcase.com"))
            address.Add(New MailAddress(sSalesperson))
            address.Add(New MailAddress("josh@coolbluewater.org"))

            Dim mail1 As New MailMessage
            Dim add As MailAddress
            For Each add In address
                mail1.To.Add(add)
            Next

            mail1.From = New MailAddress("Server <josh@coolbluewater.org>")
            mail1.Subject = "PO Backorder"
            mail1.Body = "PO: " & sPO & " - TKSI Backorder (Salesperson: " & sSalesperson & ") " & _
                "PO: " & sPO & " - TKSI Backorder (Salesperson: " & sSalesperson & ")" & vbCrLf & sNotes

            Dim smtp As New SmtpClient()
            smtp.Host = "smtpout.secureserver.net"
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New System.Net.NetworkCredential("josh@coolbluewater.org", "scarlet")
            smtp.Port = 25
            smtp.Send(mail1)


        Catch ex As Exception
            ' Windows.Forms.MessageBox.Show("error sending email to: " & sSalesperson & " " & ex.Message)
        End Try
    End Sub

    Private Sub frmNotifyBackorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SendBackorderPOEmailToSales()
    End Sub
End Class
