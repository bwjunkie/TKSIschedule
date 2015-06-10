Public Class DataFunctions
    Public Shared Function SaveJob(_job As tJob) As Boolean
        Dim dc As linqTKSIDataContext = GetLinqDataContext()
        Dim q = (From row In dc.tJobs Where row.nID = _job.nID)
        Dim job = q.Single
        With job
            .nAddressID = _job.nAddressID
            .lngCommissionStruct = _job.lngCommissionStruct
            .blnSplitCommission = _job.blnSplitCommission
            .dAmtYTD = _job.dAmtYTD
            .dCommPaid = _job.dCommPaid
            '.dCreated = only setup on create new job
            'djocreated = only in new job
            .dCrLimit = _job.dCrLimit
            .dDrawing = _job.dDrawing
            .nCustID = _job.nCustID
            .nLaborCharge = _job.nLaborCharge
            .nMaterialsCharge = _job.nMaterialsCharge
            .nTaxRate = _job.nTaxRate
            .nTotalWholesale = _job.nTotalWholesale
            .sBuildingPermit = _job.sBuildingPermit
            .sCommLocked = _job.sCommLocked
            .sComplete = _job.sComplete
            .sContractSigned = _job.sContractSigned
            .sCounty = _job.sCounty
            .sDisclaimerSigned = _job.sDisclaimerSigned
            .sDrawingsSigned = _job.sDrawingsSigned
            .sEmail = _job.sEmail
            .sInvNotes = _job.sInvNotes
            .sJobContact = _job.sJobContact
            .sJobDesc = _job.sJobDesc
            .sJobNo = _job.sJobNo
            .sOtherNotes = _job.sOtherNotes
            .sPhone = _job.sPhone
            If _job.sSalesperson Is Nothing Then
                .sSalesperson = ""
            Else
                .sSalesperson = _job.sSalesperson
            End If

            .sSalesperson2 = _job.sSalesperson2
            .sTerms = _job.sTerms

            dc.SubmitChanges()

            Try
                If (_job.tAddress.sAddress1 <> .tAddress.sAddress1) Or (_job.tAddress.sAddress2 <> .tAddress.sAddress2) Or (_job.tAddress.sState <> .tAddress.sState) Or (_job.tAddress.sCity <> .tAddress.sCity) Or (_job.tAddress.sZip <> .tAddress.sZip) Then
                    Dim sNewAddress1 = _job.tAddress.sAddress1
                    Dim sNewAddress2 = _job.tAddress.sAddress2
                    Dim sNewCity = _job.tAddress.sCity
                    Dim sNewState = _job.tAddress.sState
                    Dim sNewZip = _job.tAddress.sZip
                    Dim sNewCounty = _job.tAddress.sCounty

                    .tAddress.sAddress1 = sNewAddress1
                    .tAddress.sAddress2 = sNewAddress2
                    .tAddress.sCity = sNewCity
                    .tAddress.sState = sNewState
                    .tAddress.sZip = sNewZip
                    .tAddress.sCounty = sNewCounty
                    dc.SubmitChanges()

                    Dim dCutoffDate = Now.AddYears(-1)

                    For Each job1 In (From row In .tAddress.tJobs Where row.dJobCreated > dCutoffDate)
                        Try
                            For Each inv In job1.tSOHeaders
                                If inv.dinvoice > dCutoffDate Then
                                    If inv.dsimply Is Nothing Then
                                        inv.sShipTo1 = sNewAddress1
                                        inv.sShipTo2 = sNewAddress2
                                        inv.sShipToCity = sNewCity
                                        inv.sShipToState = sNewState
                                        inv.sShipToZip = sNewZip
                                        inv.sShipToCounty = sNewCounty
                                        dc.SubmitChanges()
                                        If inv.dmailed IsNot Nothing Then
                                            MessageBox.Show("Invoice was already mailed but not sent to Sage, please recheck if the invoice was mailed to the correct address.")
                                        End If
                                    End If
                                End If
                            Next
                        Catch ex As Exception
                            MessageBox.Show("error updating invoice ship to address for one or more invoices, please recheck all invoices for this job address: " & ex.Message)
                        End Try

                        Try
                            For Each po In job1.tPOHeaders
                                If po.dPODate > dCutoffDate Then
                                    If po.DREC Is Nothing And po.DDEL Is Nothing Then
                                        With po
                                            .sShipTo1 = sNewAddress1
                                            .sShipTo2 = sNewAddress2
                                            .sShipToCity = sNewCity
                                            .sShipToState = sNewState
                                            .sShipToZip = sNewZip
                                            .sShiptoCounty = sNewCounty
                                            dc.SubmitChanges()
                                        End With
                                    ElseIf po.DDEL Is Nothing And po.DREC Is Nothing Then  'if only received then alert the user to udpate this one manually, delivered POs don't matter, they are done
                                        MessageBox.Show("PO: " & po.sPONum & " needs manual update since it is already received")
                                    End If
                                End If
                            Next
                        Catch ex As Exception
                            MessageBox.Show("error updating PO ship to address for one or more POs, please recheck all POs for this job address: " & ex.Message)
                        End Try
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show("Jobsite Address could not be changed. Error: " & ex.Message)
            End Try

        End With

        Return True
    End Function

    Public Shared Function NewJob(_address As tAddress, _cust As tCustomr) As tJob

        Dim sNextJobNum As String = "NEW JOB"
        '  Dim sTermsDefault As String = "50-50"
        Try
            'try to get better defaults for starting job# and TERMS
            If _address.tJobs.Count = 0 Then
                sNextJobNum = _address.sLocCode.ToString & "A"
            Else
                Dim ichrHighestSoFar As Integer = 0
                For Each job In _address.tJobs
                    Dim jobletter As String = job.sJobNo.Replace(job.jobNoNumericPrefix, "")
                    If jobletter.Length = 1 Then
                        Dim ichar = Asc(jobletter)
                        If ichar > ichrHighestSoFar Then
                            ichrHighestSoFar = ichar
                        End If
                    End If
                Next
                sNextJobNum = _address.sLocCode & Chr(ichrHighestSoFar + 1)
            End If
        Catch
        End Try
        'Try
        '    sTermsDefault = _cust.TermsRecentlyUsed
        'Catch 
        'End Try

        Dim newjob1 As New tJob
        With newjob1
            .tAddress = _address
            .nMaterialsCharge = 0
            .nLaborCharge = 0
            .sJobContact = ""
            .sCounty = ""
            .tCustomr = _cust
            .sTerms = ""
            .dJobCreated = Today.Date
            .dCreated = Today.Date
            .nTaxRate = 0
            .nTotalWholesale = 0
            .nMaterialsCharge = 0
            .nLaborCharge = 0
            .lngCommissionStruct = GetDefaultPriorityCommStructureID()
            .sJobNo = sNextJobNum
            .sInvNotes = ""
            .sJobContact = ""
            .sJobDesc = ""
            .sOtherNotes = ""
            .sPhone = ""
            .sSalesperson = ""
            .sCounty = ""
            .sBuildingPermit = ""
            .sCommLocked = ""
            .sComplete = ""
            .sContractSigned = ""
            .sDisclaimerSigned = ""
            .sDrawingsSigned = ""
            .dAmtYTD = 0
            .dCrLimit = 0
            .dDrawing = ""
            .sSalesperson2 = ""
            .sEmail = ""
        End With
        Return newjob1
    End Function

    Public Shared Function GetDefaultPriorityCommStructureID() As Integer
        Dim db As linqTKSIDataContext = GetLinqDataContext()
        Return GetDefaultPriorityCommStructureID(db)
    End Function
    Public Shared Function GetDefaultPriorityCommStructureID(db As linqTKSIDataContext) As Integer
        Dim q As tblCommissionStructure = (From row In db.tblCommissionStructures Where row.lngPriority = 1).First
        If q IsNot Nothing Then
            Return q.lngID
        End If
        Return 17
    End Function

    Public Shared Function SaveJobActivity(_nJobID As Integer, _act As String) As Boolean
        Dim dc As linqTKSIDataContext = GetLinqDataContext()

        Dim act As New tblJobActivity
        With act
            .gID = Guid.NewGuid
            .ActivityDetail = _act
            .ActivityType = "MISC"
            .dateEntered = Now
            .nJobID = _nJobID
            .Other = "entered by " & global_Username
        End With
        dc.tblJobActivities.InsertOnSubmit(act)
        dc.SubmitChanges()

        Return True
    End Function

    Public Shared Function DeleteSWO(_gid As Guid) As Boolean
        Dim dc As linqTKSIDataContext = GetLinqDataContext()
        Dim q = (From row In dc.tblSWOPendings Where row.gid = _gid)
        If q.Count > 0 Then
            dc.tblSWOPendings.DeleteOnSubmit(q.Single)
            dc.SubmitChanges()
            Return True
        End If
        Return False
    End Function

    'Public Shared Function NewSO(_tjob As tJob) As Integer
    '    Try
    '        Dim dc As linqTKSIDataContext = GetLinqDataContext()
    '        Dim drSo As New tSOHeader
    '        With drSo
    '            '.tJob = Me.tjob
    '            .dinvoice = _tjob.dJobCreated
    '            .nJobID = _tjob.nID
    '            .nSimplySequence = 0
    '            .sTerms = _tjob.sTerms

    '            If Not _tjob.tAddress Is Nothing Then
    '                .sShipTo1 = _tjob.tAddress.sAddress1
    '                .sShipTo2 = _tjob.tAddress.sAddress2
    '                .sShipToCity = _tjob.tAddress.sCity
    '                .sShipToCounty = _tjob.tAddress.sCounty
    '                .sShipToState = _tjob.tAddress.sState
    '                .sShipToZip = _tjob.tAddress.sZip
    '            End If

    '            If Not _tjob.tCustomr Is Nothing Then
    '                .sName = _tjob.tCustomr.sName
    '            End If

    '            .nCustID = _tjob.nCustID
    '            ' .tCustomr = tJob.tCustomr

    '            .sSONum = _tjob.sJobNo
    '            .sFOB = ""
    '            .sOurOrder = ""
    '            .sVIA = ""
    '            .sYourOrder = ""

    '            .nTotal = 0
    '            .nTaxRate = 0

    '        End With
    '        dc.tSOHeaders.InsertOnSubmit(drSo)
    '        dc.SubmitChanges()

    '        Return drSo.nID

    '    Catch ex As Exception
    '        Return False
    '    End Try


    'End Function
End Class
