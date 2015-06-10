Imports GalaSoft.MvvmLight
Imports GalaSoft.MvvmLight.Command
Imports System.Data.Linq


Partial Class tblTaxDistrict
    Public Property isSelected As Boolean
End Class

Partial Class tblJobTax

End Class

Partial Class tEmployee

    Public ReadOnly Property SalesTotalByTimeSpan(_job As tJob, _from As Date, _to As Date) As Decimal
        Get
            Dim sales As Decimal = -1
            Dim q = (From row In _job.tPOHeaders Where _job.sSalesperson.ToUpper = Me.nickname.ToUpper And row.dPODate >= _from And row.dPODate <= _to Select row.nRetailSale, row.nAdd, row.nsalesadjust)
            If q.Count > 0 Then
                Dim decRetailSale As Decimal = q.Sum(Function(v) v.nRetailSale)
                Dim decRetailAdd As Decimal = q.Sum(Function(v) v.nAdd)
                Dim decRetailAdjust As Decimal = q.Sum(Function(v) v.nsalesadjust)
                sales = sales + decRetailSale
                sales = sales + decRetailAdd
                sales = sales + decRetailAdjust
            End If
            Return sales
        End Get

    End Property

End Class

Partial Class tCustomr

    'Public ReadOnly Property TermsRecentlyUsed As String
    '    Get

    '        Dim sTermsDefault As String = "50-50"

    '        If Me.tJobs.Count > 0 Then

    '            Dim q = (From row In Me.tJobs Select row.sTerms)

    '            sTermsDefault = q.First

    '        Else
    '            If Me.dCrLimit > 1 Then
    '                sTermsDefault = "Net 30"
    '            End If
    '        End If
    '        Return sTermsDefault
    '    End Get
    'End Property

    Public ReadOnly Property CreditLimitUsed As Decimal
        Get


            Dim totalBalanceDue As Decimal = 0
            For Each job In Me.tJobs

                For Each inv In job.tSOHeaders
                    Dim minBalanceDue As Decimal = 9999999
                    For Each drLine In inv.tSOLines
                        If drLine.sType = "Comment" Then
                            'find the smallest balance figure for this invoice , some invoices have multiple balance lines
                            totalBalanceDue += drLine.nAmount
                        End If
                    Next
                Next
            Next
            Return totalBalanceDue
        End Get
    End Property
End Class

Partial Class tblSWOPending
    Public ReadOnly Property rtfdetail As String
        Get
            Return ConvertRtfToText(Me.detail1)
        End Get
    End Property
End Class

Partial Class tblTasklist
    Public Overloads Property metatags1 As String
        Get
            Return _metatags
        End Get
        Set(value As String)
            metatags = value
            Me.datemodified = Now
        End Set
    End Property
    Public Overloads Property description1 As String
        Get
            Return _description
        End Get
        Set(value As String)
            description = value
            Me.datemodified = Now
        End Set
    End Property
End Class

Partial Class tPOLine

    Public Function IsItem() As Boolean
        If Me.sType.ToUpper.Trim = POLineTypes.ITEM Then
            Return True
        End If
        Return False
    End Function

    Public Function IsComment() As Boolean
        If Me.sType.ToUpper.Trim = POLineTypes.COMMENT Then
            Return True
        End If
        Return False
    End Function
End Class

Partial Class tPOHeader

    Private dc As linqTKSIDataContext

    Public ReadOnly Property sPONumSortable As String
        Get
            Return global_POSortable(Me.sPONum)
        End Get
    End Property

    Private _resendtosage As Boolean
    Public Property resendtosage As String
        Get
            If _resendtosage Then
                Return "YES"
            Else
                Return "NO"
            End If
        End Get
        Set(value As String)
            If value.ToUpper.Trim = "YES" Then
                _resendtosage = True
            Else
                _resendtosage = False
            End If
        End Set
    End Property

    Public ReadOnly Property warehousebin As String
        Get
            If Me.tJob.dc Is Nothing Then
                Me.tJob.dc = GetLinqDataContext()
            End If

            Dim q = (From row In Me.tJob.dc.tblLocationLabelJOINs Where row.TrailerlLabelID.StartsWith(Me.sPONum))
            If q.Count > 0 Then
                If q.First.tblLocationBin IsNot Nothing Then
                    Return q.First.tblLocationBin.LabelID
                Else
                    Return "*Error*"
                End If
            Else

            End If
            Return ""
        End Get
    End Property


    Public ReadOnly Property tosage As String
        Get
            If Me.dSimply Is Nothing Then
                Return ""
            Else
                Return "P"
            End If
        End Get
    End Property

    Public ReadOnly Property receivedbrush As Brush
        Get
            If Me.DREC Is Nothing Then
                Return Brushes.Transparent
            Else

                Return Brushes.Yellow
            End If
        End Get
    End Property

    Public ReadOnly Property received As String
        Get
            If Me.DREC Is Nothing Then
                Return ""
            Else
                Return "R"
            End If
        End Get
    End Property

    Public ReadOnly Property deliveredbrush As Brush
        Get
            If Me.DDEL Is Nothing Then
                Return Brushes.Transparent
            Else
                Return Brushes.PaleGreen
            End If
        End Get
    End Property

    Public ReadOnly Property delivered As String
        Get
            If Me.DDEL Is Nothing Then
                Return ""
            Else
                Return "D"
            End If
        End Get
    End Property
    Public ReadOnly Property Sale As Decimal
        Get
            Return Me.nRetailSale + Me.nAdd + Me.nRetailFreight
        End Get
    End Property

    Public ReadOnly Property SaleWithoutFreight As Decimal
        Get
            Return Me.nRetailSale + Me.nAdd
        End Get
    End Property

    Public ReadOnly Property FactorWithoutFreight As Decimal
        Get
            Dim cost As Decimal = Me.CostWithoutFreight
            Dim sale As Decimal = Me.SaleWithoutFreight
            If sale < cost Or cost = 0 Then
                Return 0
            Else
                Return Decimal.Round(1 + ((sale - cost) / cost), 2)
            End If
        End Get
    End Property

    Public ReadOnly Property CostWithoutFreight As Decimal
        Get
            Dim q As Decimal = (From row In Me.tPOLines Where row.nAccountID <> 5070 Select row.nCost).Sum
            Return q
        End Get
    End Property

    Public ReadOnly Property Cost As Decimal
        Get
            Dim q As Decimal = (From row In Me.tPOLines Select row.nCost).Sum
            Return q
        End Get
    End Property

End Class

Partial Class tJob

    Public Enum Jobtype
        SWOPO
        PO
        SWOJOBCOST
        JOBCOST
        SWOWARRANTY
    End Enum

    Public ReadOnly Property HasSWO_PO As Boolean
        Get
            For Each po1 In Me.tPOHeaders
                Select Case po1.sPOType.ToUpper.Trim
                    Case "SWO-PO"
                        Return True
                    Case Else

                End Select
            Next
            Return False
        End Get
    End Property

    Public dc As linqTKSIDataContext

    Private Sub UpdateComputedVaules()
        SendPropertyChanged("JobMarkupWithoutFreight")
        SendPropertyChanged("jobtotal")
        SendPropertyChanged("InvJobBalance")
        SendPropertyChanged("POJobBalance")
    End Sub

    Private Sub OnnMaterialsChargeChanged()
        UpdateComputedVaules()
    End Sub

    Private Sub OnnLaborChargeChanged()
        UpdateComputedVaules()
    End Sub

    Private Sub OnnTaxRateChanged()
        UpdateComputedVaules()
    End Sub

    Private _isSelected As Boolean = False
    Public Property isSelected As Boolean
        Get
            Return _isSelected
        End Get
        Set(value As Boolean)
            _isSelected = value
            SendPropertyChanged("isSelected")
        End Set
    End Property

    Public ReadOnly Property InvJobBalance As Decimal
        Get
            Return InvTotal - jobtotal
        End Get
    End Property

    Public ReadOnly Property POJobBalance As Decimal
        Get
            Return (nMaterialsCharge + nLaborCharge - POSALETOTAL)
        End Get
    End Property

    Public ReadOnly Property InvBalanceRemaining As Decimal
        Get
            Dim decSaleTotal1 As Decimal = 0
            For Each header1 In Me.tSOHeaders
                decSaleTotal1 += (From line1 In header1.tSOLines Where line1.sType.ToUpper = "COMMENT" Select line1.nAmount).Sum
            Next

            Return decSaleTotal1
        End Get

    End Property

    Public ReadOnly Property InvTotal As Decimal
        Get
            Dim decSaleTotal1 As Decimal = 0
            For Each header1 In Me.tSOHeaders
                decSaleTotal1 += (From line1 In header1.tSOLines Where line1.nAccountID > 0 Select line1.nAmount).Sum
                'For Each lin1 In header1.tSOLines
                '    decSaleTotal1 += lin1.nAmount
                'Next
            Next

            Return decSaleTotal1
        End Get
    End Property

    Public ReadOnly Property POSALETOTAL As Decimal
        Get
            Dim decSaleTotal1 As Decimal = (From header1 In Me.tPOHeaders Select header1.Sale).Sum
            Return decSaleTotal1
        End Get
    End Property

    Public ReadOnly Property POCOSTTOTAL As Decimal
        Get
            Dim decCost As Decimal = (From header1 In Me.tPOHeaders Select header1.Cost).Sum
            Return decCost
        End Get
    End Property

    Public ReadOnly Property JobMarkupWithoutFreight As Decimal
        Get
            Dim cost As Decimal = (From head1 In Me.tPOHeaders Select head1.CostWithoutFreight).Sum
            Dim sale As Decimal = (From head1 In Me.tPOHeaders Select head1.SaleWithoutFreight).Sum
            If sale < cost Or cost = 0 Then
                Return 0
            ElseIf cost = 0 And sale > 0 Then
                Return 99
            Else
                Return Decimal.Round(1 + ((sale - cost) / cost), 2)
            End If
        End Get
    End Property

    Public ReadOnly Property JobNoAndAddress As String
        Get
            Return Me.sJobNo & " - " & Me.tAddress.sAddress1
        End Get
    End Property

    Public ReadOnly Property jobtotal As Decimal
        Get
            Dim total = (Me.nMaterialsCharge * (Me.nTaxRate / 100)) + Me.nMaterialsCharge + Me.nLaborCharge
            Return Decimal.Round(total, 2)
        End Get
    End Property

    Public ReadOnly Property jobNoNumericPrefix
        Get
            Dim sJob6 As String = Mid(Me.sJobNo, 1, 7)
            If IsNumeric(sJob6) Then
                'leave as 7 digit for folder/file creation

            ElseIf IsNumeric(Mid(sJob6, 1, 6)) Then
                sJob6 = Mid(sJob6, 1, 6)
            ElseIf IsNumeric(Mid(sJob6, 1, 5)) Then
                sJob6 = Mid(sJob6, 1, 5)
            ElseIf IsNumeric(Mid(sJob6, 1, 4)) Then
                sJob6 = Mid(sJob6, 1, 4)
            ElseIf IsNumeric(Mid(sJob6, 1, 3)) Then
                sJob6 = Mid(sJob6, 1, 2)
            End If
            sJob6 = sJob6.Trim
            Return sJob6.Trim
        End Get
    End Property

    Private Sub OnsSalespersonChanged()
        If Me.sSalesperson Is Nothing Then

        End If
    End Sub
End Class

Partial Class tAddress

    Public ReadOnly Property LocAndAddress As String
        Get
            Return Me.sLocCode & " - " & Me.sAddress1
        End Get
    End Property

    Private Sub OnsAddress1Changed()
        VerifySOPOShipToUpdated()
    End Sub

    Private Sub OnsAddress2Changed()
        VerifySOPOShipToUpdated()
    End Sub

    Private Sub OnsCityChanged()
        VerifySOPOShipToUpdated()
    End Sub

    Private Sub OnsStateChanged()
        VerifySOPOShipToUpdated()
    End Sub

    Private Sub OnsZipChanged()
        VerifySOPOShipToUpdated()
    End Sub

    Private Sub VerifySOPOShipToUpdated()
        'update ship to address on any recent invoices that are not yet sent to the accounting system
        For Each job1 In (From row In Me.tJobs Where row.dJobCreated > Now.AddYears(-1))
            Try
                For Each inv1 In job1.tSOHeaders
                    If inv1.dsimply Is Nothing Then
                        With inv1
                            .sShipTo1 = Me.sAddress1
                            .sShipTo2 = Me.sAddress2
                            .sShipToCity = Me.sCity
                            .sShipToCounty = Me.sCounty
                            .sShipToState = Me.sState
                            .sShipToZip = Me.sZip
                            .sShipToCounty = Me.sCounty
                        End With
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("error updating invoice ship to address: " & ex.Message)
            End Try

            Try
                For Each po In job1.tPOHeaders

                    If po.DREC Is Nothing And po.DDEL Is Nothing Then
                        With po
                            .sShipTo1 = Me.sAddress1
                            .sShipTo2 = Me.sAddress2
                            .sShipToCity = Me.sCity
                            .sShiptoCounty = Me.sCounty
                            .sShipToState = Me.sState
                            .sShipToZip = Me.sZip
                            .sShiptoCounty = Me.sCounty
                        End With
                    ElseIf po.DDEL Is Nothing And po.DREC Is Nothing Then  'if only received then alert the user to udpate this one manually, delivered POs don't matter, they are done
                        MessageBox.Show("PO: " & po.sPONum & " is already received, check SHIP TO: address manually.")
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("error updating PO ship to address for one or more POs, please recheck all POs for this job address: " & ex.Message)
            End Try
        Next
    End Sub
End Class

