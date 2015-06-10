Public Class clsJob

    Protected drSO As tSOHeader ' dsTKSI.tSOHeaderRow
    Protected drCust As tCustomr ' dsTKSI.tCustomrRow
    Protected drJob As tJob ' dsTKSI.tJobRow

    'Public Property strDateReq As String = ""
    'Public Property strJobCustDesc As String = ""
    'Public Property blnHighlighted As Boolean = False
    'Public Property colorHighlighted As Windows.Media.Brush = Windows.Media.Brushes.White
    'Public Property strCustPayment As String = "CustPayment$: "
    'Public Property strContract As String = "Contract$: "
    'Public Property visjob As Windows.Visibility = Windows.Visibility.Hidden

    Public ReadOnly Property listpotype As List(Of String)
        Get
            Dim listStr As New List(Of String)
            For Each drPO In Me.drJob.tPOHeaders '.GettPOHeaderRows
                listStr.Add(drPO.sPOType)
            Next
            Return listStr
        End Get
    End Property

    Public ReadOnly Property Salesperson As String
        Get
            If Not drJob Is Nothing Then
                Return drJob.sSalesperson
            Else
                Return "error no job populated"
            End If

        End Get
    End Property

    Private Sub LoadCustRow()
        drCust = drJob.tCustomr
        'Dim daCust As New dsTKSITableAdapters.tCustomrTableAdapter
        'Dim dtCust As New dsTKSI.tCustomrDataTable
        'If daCust.FillByLID(dtCust, drJob.nCustID) > 0 Then
        '    drCust = dtCust(0)
        'End If
    End Sub

    Public ReadOnly Property JobID As Integer
        Get
            If Not drJob Is Nothing Then
                Return drJob.nID
            Else
                Return -1
            End If

        End Get
    End Property

    Public ReadOnly Property AddressID As Integer
        Get
            If Not drJob Is Nothing Then
                Return drJob.nAddressID
            Else
                Return -1
            End If

        End Get
    End Property

    Public ReadOnly Property CustName As String
        Get
            If drCust Is Nothing Then LoadCustRow()
            Return drCust.sName
        End Get
    End Property

    Public ReadOnly Property CustFirstName As String
        Get
            If drCust Is Nothing Then LoadCustRow()
            Dim strReturn As String = ""
            Dim strNameParse As String()
            With drCust.sName
                If .Contains(",") And (Not .ToUpper.Contains("INC")) And (Not .ToUpper.Contains("LLC")) And (Not .ToUpper.Contains("INC")) Then
                    strNameParse = drCust.sName.Split(",")
                    If strNameParse.Length > 1 Then
                        strReturn = strNameParse(1)
                    Else
                        strReturn = drCust.sName
                    End If
                Else
                    strReturn = drCust.sName

                End If
            End With


            Return strReturn.Replace(",", "")
        End Get
    End Property

    Public ReadOnly Property CustAddress As String
        Get
            If drCust Is Nothing Then LoadCustRow()
            Return (drCust.sStreet1 & " " & drCust.sStreet2).Trim
        End Get
    End Property

    Public ReadOnly Property CustCityStateZip As String
        Get
            If drCust Is Nothing Then LoadCustRow()
            Return (drCust.sCity & ", " & drCust.sProvState & " " & drCust.sPostalZip).Trim
        End Get
    End Property

    Protected Sub LoadSORow(nJobID As Integer)
        Me.drSO = drJob.tSOHeaders.First

        'Dim daSOH As New dsTKSITableAdapters.tSOHeaderTableAdapter
        'Dim daSOD As New dsTKSITableAdapters.tSOLineTableAdapter
        'Dim dsTKSISO As New dsTKSI
        'If daSOH.FillByNJobID(dsTKSISO.tSOHeader, nJobID) > 0 Then
        '    Me.drSO = dsTKSISO.tSOHeader(0)
        '    daSOD.FillByNSOID(dsTKSISO.tSOLine, Me.drSO.nID)
        'End If
    End Sub

    Public Sub New()

    End Sub

    Private dc As linqTKSIDataContext = GetLinqDataContext()

    Public Sub New(_nJobID As Integer)
        Try
            Dim q = (From row In dc.tJobs Where row.nID = _nJobID)
            Me.drJob = q.Single
        Catch ex As Exception
            MessageBox.Show("error finding job id " & ex.Message)
        End Try


        'Dim ds As New dsTKSI
        'Dim daJob As New dsTKSITableAdapters.tJobTableAdapter
        'If daJob.FillByNID(ds.tJob, nJobID) > 0 Then
        '    Me.drJob = ds.tJob(0)
        'End If

    End Sub

    Public Sub New(_sJobNo As String)
        Try
            Dim q = (From row In dc.tJobs Where row.sJobNo = _sJobNo)
            Me.drJob = q.First
        Catch ex As Exception
            MessageBox.Show("error finding job id " & ex.Message)
        End Try
        'Dim ds As New dsTKSI
        'Dim daJob As New dsTKSITableAdapters.tJobTableAdapter
        'If daJob.FillBysJobNo(ds.tJob, sJobNo) > 0 Then
        '    Me.drJob = ds.tJob(0)
        'End If

    End Sub

    'Public ReadOnly Property ContractBalance As Decimal
    '    Get
    '        Dim itemBalance As Decimal = 0
    '        Dim commentBalance As Decimal = 0
    '        If Me.drSO Is Nothing Then LoadSORow(Me.drJob.nID)
    '        If Not Me.drSO Is Nothing Then

    '            Dim drLine As dsTKSI.tSOLineRow
    '            For Each drLine In Me.drSO.GettSOLineRows
    '                If UCase(drLine.sType) = "ITEM" Then
    '                    itemBalance = itemBalance + drLine.nAmount
    '                ElseIf UCase(drLine.sType) = "COMMENT" Then
    '                    commentBalance = commentBalance + drLine.nAmount
    '                ElseIf UCase(drLine.sType) = "BALANCE" Then

    '                End If
    '            Next
    '            Return commentBalance
    '        Else
    '            Return -1
    '        End If
    '    End Get
    'End Property

    'Sub New(_drJob As dsTKSI.tJobRow, drPO As dsTKSI.tPOHeaderRow, decPayments As Decimal)

    ' Me.drJob = _drJob
    'If Not drPO.IsdRequiredNull Then
    '    Me.strDateReq = drPO.dRequired.ToShortDateString

    '    Dim dMonday As Integer = Weekday(Today, FirstDayOfWeek.Monday)
    '    If drPO.dRequired >= DateAdd(Microsoft.VisualBasic.DateInterval.Day, 14 - dMonday, Today) Then
    '        If drPO.dRequired <= DateAdd(Microsoft.VisualBasic.DateInterval.Day, 21 - dMonday, Today) Then
    '            colorHighlighted = Windows.Media.Brushes.LightBlue 'global_ColorFromHex(&HCC, &HDD, &HEE)
    '            visjob = Windows.Visibility.Visible
    '        End If
    '    End If
    'Else
    '    Me.strDateReq = "NONE"
    'End If

    'If Not drJob.tCustomrRow Is Nothing Then
    '    Me.strJobCustDesc = "Job: " & drJob.sJobNo & " - " & drJob.tCustomrRow.sName & ", " & drJob.sJobDesc & " (" & drJob.sTerms & ")"
    'End If

    'Me.strCustPayment = "CustPayment: " & Format(-(decPayments), "currency")
    'Me.strContract = "Contract: " & Format((drJob.nMaterialsCharge + (drJob.nMaterialsCharge * drJob.nTaxRate / 100) + drJob.nLaborCharge).ToString, "currency")

    ' End Sub

End Class
