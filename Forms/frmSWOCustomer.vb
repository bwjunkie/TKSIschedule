Imports System.Windows.Forms

Public Class frmSWOCustomer

    Public blnNewCustomer As Boolean = False
    Public OK As Boolean = False
    Public nCustID As Integer = 0
    Public strNewCustomer As String = ""
    '   Private tblCustomer As New TKSIJOBSDataSet.tCustomrDataTable

    Private Sub btnSaveCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCustomer.Click
        Try
            If Me.txtNewCustomerInfo.Text.Trim.Length > 1 Then
                OK = True
                Me.blnNewCustomer = True
                Me.strNewCustomer = Me.txtNewCustomerInfo.Text.Trim
            ElseIf Me.lvSelectCustomer.SelectedItems.Count > 0 Then
                Me.nCustID = CInt(Me.lvSelectCustomer.SelectedItems(0).Text)
                OK = True
                Me.blnNewCustomer = False
            End If
            Me.Close()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error selecting customer, please close and try again.")
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        OK = False
        Me.Close()
    End Sub

    Private Sub frmSWOCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dc As linqTKSIDataContext = GetLinqDataContext()

        Dim q = (From row In dc.tCustomrs Where row.sName.Length > 0 Order By row.sName)

        ' tblCustomer.DataSet.EnforceConstraints = False
        ' Me.TCustomrTableAdapter1.Fill(Me.tblCustomer)
        ' Dim drCust As TKSIJOBSDataSet.tCustomrRow

        Dim lv As ListViewItem
        For Each drCust In q ' Me.tblCustomer
            lv = Me.lvSelectCustomer.Items.Add(drCust.lID)
            lv.SubItems.Add(drCust.sName)
            lv.SubItems.Add(drCust.sStreet1 & " " & drCust.sStreet2 & " " & drCust.sPostalZip)
        Next
    End Sub

End Class