Imports System.Drawing
Imports System.Windows.Forms

Public Class frmSWO1

    Private alSWOImages As New List(Of String) ' ArrayList
    Private drSWO As TKSIJOBSDataSet.tblSWOPendingRow
    Private alJobImages As New List(Of String) ' ArrayList
    Public blnCreatedPO As Boolean = False

    Public Function CreateSWO(ByVal JOBID As Integer, ByVal AddressID As Integer, ByVal CustID As Integer, ByVal Salesperson As String, ByVal sPOType As String, ByVal sTerms As String) As Guid

        Dim tblJob As New TKSIJOBSDataSet.tJobDataTable
        Me.TJobTableAdapter1.FillByNID(tblJob, JOBID)
        Dim drJob As TKSIJOBSDataSet.tJobRow

        If tblJob.Rows.Count > 0 Then
            drJob = tblJob(0)
            Dim dr As TKSIJOBSDataSet.tblSWOPendingRow
            dr = Me.TksijobsDataSet1.tblSWOPending.AddtblSWOPendingRow(Guid.NewGuid, drJob.nAddressID, drJob.nID, drJob.nCustID, Now.Date, drJob.sSalesperson, 3, 0, 0, 0, 0, sPOType, "", Now.Date, "", "", "", "", "", "", sTerms, CDate("1/1/1900"), "sales", "", "", "", "", "", "", "", drJob.sPhone, Mid(drJob.sJobContact, 1, 50))
            Me.TblSWOPendingTableAdapter1.Update(Me.TksijobsDataSet1.tblSWOPending)

            Me.drSWO = dr  'save in local in case this form is to be displayed

            Return dr.gid
        End If

    End Function

    Public Function DeleteSWO(ByVal gid As Guid)

        Dim dr As TKSIJOBSDataSet.tblSWOPendingRow
        Me.TblSWOPendingTableAdapter1.FillByGID(Me.TksijobsDataSet1.tblSWOPending, gid)
        dr = Me.TksijobsDataSet1.tblSWOPending(0)
        dr.Delete()
        Me.TblSWOPendingTableAdapter1.Update(Me.TksijobsDataSet1.tblSWOPending)

    End Function

    Private Sub SaveSWO()
        Try
            If sUserlevel = UserRights.Sales Then
                'sales people cannot save 
                If Me.drSWO.sStatus = "po" Or Me.drSWO.sStatus = "approved" Then
                    Exit Sub
                End If
            End If

            If Not Me.drSWO Is Nothing Then
                With Me.drSWO

                    '.MaterialCharge = Me.txtMaterials.Text
                    .JobContact = Me.txtJobContact.Text

                    If .sPOType = "PO" Then
                        'parts orders dont need this data
                        .dateOrderBy = Today.Date
                        .DateOfOrder = Today.Date

                    Else

                        Try
                            .LaborCharge = Me.txtLabor.Text.Trim
                            .TripCharge = Me.txtTripCharge.Text.Trim
                        Catch
                        End Try

                        If Me.chkJobcost.Checked Then
                            .sPOType = "SWO-Jobcost"
                        ElseIf Me.chkSWO.Checked Then
                            .sPOType = "SWO-PO"
                        ElseIf Me.chkWarranty.Checked Then
                            .sPOType = "SWO-Warranty"
                        End If

                        Try
                            If Me.txtDateReq.Text.Trim.Length > 0 Then
                                Try
                                    .dateOrderBy = Me.txtDateReq.Text
                                Catch
                                    .dateOrderBy = CDate("1/1/1900")
                                End Try
                            Else
                                .dateOrderBy = CDate("1/1/1900")
                            End If

                            If Me.txtDateofOrder.Text.Trim.Length > 0 Then
                                Try
                                    .DateOfOrder = Me.txtDateofOrder.Text
                                Catch
                                    .DateOfOrder = CDate("1/1/1900")
                                End Try
                            Else
                                .DateOfOrder = CDate("1/1/1900")
                            End If

                        Catch
                        End Try

                        If Me.cmbTerms.Enabled = True Then
                            .PaymentTerms = Me.cmbTerms.Text
                        Else
                            .PaymentTerms = ""
                        End If

                        .detail1 = Me.txtDetails1.Rtf
                        .detail2 = Me.txtDetails2.Rtf
                        .detail3 = Me.txtDetails3.Rtf
                        .detail4 = Me.txtDetails4.Rtf
                        .detail5 = Me.txtDetails5.Rtf
                        .detail6 = Me.txtDetails6.Rtf
                        .detail7 = Me.txtDetails7.Rtf
                        .detail8 = Me.txtDetails8.Rtf
                        .detail9 = Me.txtDetails9.Rtf
                        .detail10 = Me.txtDetails10.Rtf
                        .detail11 = Me.txtDetails11.Rtf
                        .detail12 = Me.txtDetails12.Rtf
                        .PONum = Me.txtPONum.Text
                    End If

                    .Phone = Me.txtPhone.Text.Trim

                End With

                Me.TblSWOPendingTableAdapter1.Update(Me.TksijobsDataSet1.tblSWOPending)

                RefreshPartsOrders()

                If Me.drSWO.sStatus = "approved" Or Me.drSWO.sStatus = "po" Then
                    Me.BackColor = Color.LightGreen
                End If
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error " & ex.Message)
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Close()
    End Sub

    Public Sub LoadSWO(ByVal gid As Guid, ByVal alImages As List(Of String))

        Try
            Select Case sUserlevel
                Case UserRights.Sales
                    Me.pnlAdmin.Visible = False
            End Select
        Catch ex As Exception
        End Try

        'store paths of images for entire job in arraylist for use if user wants to add images to this SWO
        For Each img1 In (From row In alImages Where Not row.ToUpper.EndsWith(".PDF"))
            Me.alJobImages.Add(img1) ' = alImages
        Next

        Me.TVendorTableAdapter1.Fill(Me.TksijobsDataSet1.tVendor)

        Me.TblSWOPendingTableAdapter1.FillByGID(Me.TksijobsDataSet1.tblSWOPending, gid)

        If Not Me.TksijobsDataSet1.tblSWOPending.Rows.Count = 0 Then

            Me.drSWO = Me.TksijobsDataSet1.tblSWOPending(0)

            Me.LoadImageBoxesFromList(Me.drSWO.gid)

            Me.TAddressTableAdapter.Fill(Me.TksijobsDataSet1.tAddress, Me.drSWO.AddressID)
            Dim drAddress As TKSIJOBSDataSet.tAddressRow
            drAddress = Me.TksijobsDataSet1.tAddress.Rows(0)

            Me.TCustomrTableAdapter1.FillByLID(Me.TksijobsDataSet1.tCustomr, Me.drSWO.CustID)
            Dim drCust As TKSIJOBSDataSet.tCustomrRow
            Dim sCustInfo As String = ""
            If Me.TksijobsDataSet1.tCustomr.Rows.Count > 0 Then
                drCust = Me.TksijobsDataSet1.tCustomr(0)
                sCustInfo = drCust.sName & vbCrLf & drCust.sStreet1 & vbCrLf & drCust.sStreet2 & vbCrLf & drCust.sCity & ", " & drCust.sProvState & " " & drCust.sPostalZip
            End If
            If Me.drSWO.NewCustomerInfo.Trim.Length > 1 Then
                sCustInfo = Me.drSWO.NewCustomerInfo
            End If

            With Me.drSWO
                If Not drAddress Is Nothing Then
                    Me.txtJobLocation.Text = drAddress.sAddress1 & vbCrLf & drAddress.sAddress2 & vbCrLf & drAddress.sCity & ", " & drAddress.sState & " " & drAddress.sZip
                    Me.txtNameAddress.Text = sCustInfo
                    Me.txtJobNum.Text = drAddress.sLocCode

                    'If Me.drSWO.PONum.Trim.Length > 0 Then
                    Me.txtPONum.Text = Me.drSWO.PONum
                    'End If
                Else
                    'no address
                End If
                If .DateOfOrder > CDate("1/1/2001") Then
                    Me.txtDateofOrder.Text = .DateOfOrder.ToShortDateString
                End If
                If .dateOrderBy > CDate("1/1/2001") Then
                    Me.txtDateReq.Text = .dateOrderBy.ToShortDateString
                End If

                Me.txtJobContact.Text = .JobContact
                Me.txtLabor.Text = Format(.LaborCharge, "currency")
                'Me.txtMaterials.Text = Format(.MaterialCharge, "currency")
                'Me.txtTax.Text = Format(.TaxCharge, "currency")
                Me.txtTripCharge.Text = Format(.TripCharge, "currency")

                Me.txtDetails1.Rtf = .detail1
                Me.txtDetails2.Rtf = .detail2
                Me.txtDetails3.Rtf = .detail3
                Me.txtDetails4.Rtf = .detail4
                Me.txtDetails5.Rtf = .detail5
                Me.txtDetails6.Rtf = .detail6
                Me.txtDetails7.Rtf = .detail7
                Me.txtDetails8.Rtf = .detail8
                Me.txtDetails9.Rtf = .detail9
                Me.txtDetails10.Rtf = .detail10
                Me.txtDetails11.Rtf = .detail11
                Me.txtDetails12.Rtf = .detail12

                Me.txtPhone.Text = .Phone

                Select Case .sPOType
                    Case "SWO-Jobcost"
                        Me.chkJobcost.Checked = True
                    Case "SWO-PO", "SWO"
                        Me.chkSWO.Checked = True
                    Case "SWO-Warranty"
                        Me.chkWarranty.Checked = True
                End Select

                Me.cmbTerms.Text = .PaymentTerms

                Me.txtSWOHeader.Text = Me.txtSWOHeader.Text.Trim & vbCrLf & .Sales

                If .sStatus = "approved" Then
                    Me.txtSWOHeader.Text = Me.txtSWOHeader.Text & vbCrLf & "*** Approved ***"
                    Me.BackColor = Color.LightGreen
                ElseIf .sStatus = "po" Then
                    Me.txtSWOHeader.Text = "PO Already Created (do not make changes)"
                    Me.BackColor = Color.LightGreen
                End If


                RefreshPartsOrders()

            End With
        End If
    End Sub

    Private Sub RefreshPartsOrders()

        Dim sngTotal As Decimal = 0
        Dim sngTax As Decimal = 0

        Me.lvPartsOrders.Items.Clear()
        Me.TblSWOOrderTableAdapter1.FillByGSWOID(Me.TksijobsDataSet1.tblSWOOrder, Me.drSWO.gid)

        Dim drOrder As TKSIJOBSDataSet.tblSWOOrderRow
        Dim item1 As ListViewItem
        For Each drOrder In Me.TksijobsDataSet1.tblSWOOrder

            item1 = Me.lvPartsOrders.Items.Add(drOrder.gid.ToString)
            Try
                If drOrder.nVendorID > 0 Then
                    item1.SubItems.Add(Me.TksijobsDataSet1.tVendor.FindBylid(drOrder.nVendorID).sName)
                Else
                    item1.SubItems.Add("")
                End If
                If drOrder.ShipWeekOf > CDate("1/1/2001") Then
                    item1.SubItems.Add(drOrder.ShipWeekOf)
                End If

            Catch
            End Try

            Me.TblSWOOrderDetailTableAdapter1.FillByGSWOOrderID(Me.TksijobsDataSet1.tblSWOOrderDetail, drOrder.gid)

            Dim drDetail As TKSIJOBSDataSet.tblSWOOrderDetailRow
            Dim sngSubTotal As Decimal = 0
            For Each drDetail In Me.TksijobsDataSet1.tblSWOOrderDetail
                sngSubTotal += (drDetail.Retail * drDetail.Quantity) '* drOrder.RetailFactor))
            Next

            sngSubTotal = sngSubTotal + (sngSubTotal * drOrder.Upcharge1)
            sngSubTotal = sngSubTotal + (sngSubTotal * drOrder.Upcharge2)
            sngSubTotal = sngSubTotal + (sngSubTotal * drOrder.Upcharge3)

            sngSubTotal = sngSubTotal * drOrder.RetailFactor

            sngSubTotal += drOrder.RetailShipping

            sngTax += (drOrder.SalesTax / 100) * sngSubTotal

            sngSubTotal += drOrder.retailADD

            sngTotal += sngSubTotal

        Next
        Me.txtMaterials.Text = Format(sngTotal, "currency")
        Me.txtTax.Text = Format(sngTax, "currency")

        Me.txtTotal.Text = Format(Me.drSWO.LaborCharge + Me.drSWO.TripCharge + sngTax + sngTotal, "currency")
    End Sub

    Private Sub btnAddParts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddParts.Click

        Me.SaveSWO()

        Dim drOrder As TKSIJOBSDataSet.tblSWOOrderRow
        Dim sngTaxRate As Decimal = 0
        Me.TJobTableAdapter1.FillByNID(Me.TksijobsDataSet1.tJob, Me.drSWO.JOBID)
        If Me.TksijobsDataSet1.tJob.Rows.Count > 0 Then
            sngTaxRate = Me.TksijobsDataSet1.tJob(0).nTaxRate
        End If

        drOrder = Me.TksijobsDataSet1.tblSWOOrder.AddtblSWOOrderRow(Guid.NewGuid, Me.drSWO.gid _
        , 1, Me.drSWO.Sales, Today.Date, CDate("1/1/1900"), "Truck", sngTaxRate, Me.cmbTerms.Text, Me.alSWOImages.Count _
        , Replace(Me.txtNameAddress.Text, vbCrLf & vbCrLf, vbCrLf), "The Kitchen Showcase Warehouse", 0, 0, 0, 0, 0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", Me.drSWO.CustID, Me.drSWO.NewCustomerInfo, Me.drSWO.JobContact, "", "", 0, 0, 0, "", "", "")
        Me.TblSWOOrderTableAdapter1.Update(Me.TksijobsDataSet1.tblSWOOrder)

        Dim i As Integer = 0
        For i = 1 To 20
            Dim drDetail As TKSIJOBSDataSet.tblSWOOrderDetailRow
            drDetail = Me.TksijobsDataSet1.tblSWOOrderDetail.AddtblSWOOrderDetailRow(Guid.NewGuid _
            , drOrder.gid, i, 0, "", "", "", "", "", "", "", 0, 0)
        Next

        Me.TblSWOOrderDetailTableAdapter1.Update(Me.TksijobsDataSet1.tblSWOOrderDetail)

        Me.ShowSWOParts(drOrder.gid)

    End Sub

    Private Sub ShowSWOParts(ByVal gid As Guid)
        Dim frm1 As New frmSWOParts
        frm1.LoadSWOOrder(gid, Me.drSWO.JOBID)
        frm1.txtPO.Text = Me.txtPONum.Text
        frm1.ShowDialog()
        RefreshPartsOrders()
    End Sub

    Private Sub btnAddImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddImages.Click
        Dim frm1 As New frmImageSelect
        Dim sJob5 As String = Mid(Me.txtJobNum.Text.Trim, 1, 5)
        If IsNumeric(sJob5) Then
            'leave as 5 digit for folder/file creation
        Else
            sJob5 = Mid(sJob5, 1, 4)
        End If

        frm1.LoadImageList(Me.alJobImages, Me.drSWO.gid, sJob5)
        frm1.ShowDialog()
        LoadImageBoxesFromList(Me.drSWO.gid)
        'If frm1.ImageToAdd.Length > 0 Then
        '    Me.alSWOImages.Add(frm1.ImageToAdd)
        'End If
    End Sub

    Private Sub LoadImageBoxesFromList(ByVal gid As Guid)

        Me.alSWOImages = New List(Of String) ' ArrayList
        Me.TblSWOImagesTableAdapter1.FillByGSWOID(Me.TksijobsDataSet1.tblSWOImages, gid)
        Dim drImage As TKSIJOBSDataSet.tblSWOImagesRow
        For Each drImage In Me.TksijobsDataSet1.tblSWOImages
            If IO.File.Exists(drImage.ImagePath) Then
                Me.alSWOImages.Add(drImage.ImagePath)
            End If

        Next

        Try
            Me.DisposeExistingPictureBoxes()
            Dim path1 As String
            Dim iCount As Integer = 1
            For Each path1 In Me.alSWOImages

                Dim thumbPath As String = Replace(path1, "\SWO\", "\SWO\thumbs\")
                thumbPath = Replace(thumbPath, ".TIF", ".JPG")

                Select Case iCount
                    Case 1
                        If IO.File.Exists(thumbPath) Then
                            iCount += 1
                            Me.PictureBox1.Image = Image.FromFile(thumbPath)
                        End If

                    Case 2
                        If IO.File.Exists(thumbPath) Then
                            iCount += 1
                            Me.PictureBox2.Image = Image.FromFile(thumbPath)
                        End If

                    Case 3
                        If IO.File.Exists(thumbPath) Then
                            iCount += 1
                            Me.PictureBox3.Image = Image.FromFile(thumbPath)
                        End If

                    Case 4
                        If IO.File.Exists(thumbPath) Then
                            iCount += 1
                            Me.PictureBox4.Image = Image.FromFile(thumbPath)
                        End If
                    Case 5
                        If IO.File.Exists(thumbPath) Then
                            iCount += 1
                            Me.PictureBox5.Image = Image.FromFile(thumbPath)
                        End If
                    Case 6
                        If IO.File.Exists(thumbPath) Then
                            iCount += 1
                            Me.PictureBox6.Image = Image.FromFile(thumbPath)
                        End If
                    Case 7
                        If IO.File.Exists(thumbPath) Then
                            iCount += 1
                            Me.PictureBox7.Image = Image.FromFile(thumbPath)
                        End If
                    Case 8
                        If IO.File.Exists(thumbPath) Then
                            iCount += 1
                            Me.PictureBox8.Image = Image.FromFile(thumbPath)
                        End If
                    Case 9
                        If IO.File.Exists(thumbPath) Then
                            iCount += 1
                            Me.PictureBox9.Image = Image.FromFile(thumbPath)
                        End If
                    Case 10
                        Windows.Forms.MessageBox.Show("This SWO has more than 9 images.  To view all of them use the 'Edit Images' button.")
                    Case Else
                        'nomore picture boxes on this screen
                End Select
            Next
        Catch

        End Try

    End Sub

    Private Sub frmSWO1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveSWO()

        Me.DisposeExistingPictureBoxes()

    End Sub

    Private Sub lvPartsOrders_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPartsOrders.DoubleClick
        Try
            Dim gid As String = ""
            If Me.lvPartsOrders.SelectedItems.Count > 0 Then
                gid = Me.lvPartsOrders.SelectedItems(0).Text
                Me.ShowSWOParts(New Guid(gid))
            End If
        Catch
        End Try
    End Sub

    Private Sub txtTripCharge_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTripCharge.Leave
        If IsNumeric(Me.txtTripCharge.Text) Then
            Me.drSWO.TripCharge = Me.txtTripCharge.Text
            RefreshPartsOrders()
        End If
    End Sub

    Private Sub txtLabor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLabor.Leave
        If IsNumeric(Me.txtLabor.Text) Then
            Me.drSWO.LaborCharge = Me.txtLabor.Text
            RefreshPartsOrders()
        End If
    End Sub

    Private Sub btnDeleteParts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteParts.Click
        Try
            Dim gid As String = ""
            If Me.lvPartsOrders.SelectedItems.Count > 0 Then
                gid = Me.lvPartsOrders.SelectedItems(0).Text
                If Windows.Forms.MessageBox.Show("Are you sure you want to delete a parts order?", "Delete Parts?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    Dim drParts As TKSIJOBSDataSet.tblSWOOrderRow
                    drParts = Me.TksijobsDataSet1.tblSWOOrder.FindBygid(New Guid(gid))
                    If Not drParts Is Nothing Then
                        drParts.Delete()
                    End If

                    Me.TblSWOOrderTableAdapter1.Update(Me.TksijobsDataSet1.tblSWOOrder)
                    Me.RefreshPartsOrders()
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub DisposeExistingPictureBoxes()
        Try
            If Not Me.PictureBox1.Image Is Nothing Then
                Me.PictureBox1.Image = New Bitmap(1, 1, Imaging.PixelFormat.Format32bppRgb)
            End If
        Catch
        End Try

        Try
            If Not Me.PictureBox2.Image Is Nothing Then
                Me.PictureBox2.Image = New Bitmap(1, 1, Imaging.PixelFormat.Format32bppRgb)
            End If
        Catch
        End Try

        Try
            If Not Me.PictureBox3.Image Is Nothing Then
                Me.PictureBox3.Image = New Bitmap(1, 1, Imaging.PixelFormat.Format32bppRgb)
            End If
        Catch
        End Try

        Try
            If Not Me.PictureBox4.Image Is Nothing Then
                Me.PictureBox4.Image = New Bitmap(1, 1, Imaging.PixelFormat.Format32bppRgb)
            End If
        Catch
        End Try

        Try
            If Not Me.PictureBox5.Image Is Nothing Then
                Me.PictureBox5.Image = New Bitmap(1, 1, Imaging.PixelFormat.Format32bppRgb)
            End If
        Catch
        End Try

        Try
            If Not Me.PictureBox6.Image Is Nothing Then
                Me.PictureBox6.Image = New Bitmap(1, 1, Imaging.PixelFormat.Format32bppRgb)
            End If
        Catch
        End Try

        Try
            If Not Me.PictureBox7.Image Is Nothing Then
                Me.PictureBox7.Image = New Bitmap(1, 1, Imaging.PixelFormat.Format32bppRgb)
            End If
        Catch
        End Try

        Try
            If Not Me.PictureBox8.Image Is Nothing Then
                Me.PictureBox8.Image = New Bitmap(1, 1, Imaging.PixelFormat.Format32bppRgb)
            End If
        Catch
        End Try

        Try
            If Not Me.PictureBox9.Image Is Nothing Then
                Me.PictureBox9.Image = New Bitmap(1, 1, Imaging.PixelFormat.Format32bppRgb)
            End If
        Catch
        End Try

    End Sub

    Private Sub btnEditExistingImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditExistingImages.Click

        DisposeExistingPictureBoxes()

        Try
            Dim frm1 As New frmImageSelect
            frm1.blnEditExisting = True

            Dim sJob5 As String = Mid(Me.txtJobNum.Text.Trim, 1, 5)
            If IsNumeric(sJob5) Then
                'leave as 5 digit for folder/file creation
            Else
                sJob5 = Mid(sJob5, 1, 4)
            End If

            frm1.LoadImageList(Me.alSWOImages, Me.drSWO.gid, sJob5)
            frm1.ShowDialog()

        Catch
        End Try

        LoadImageBoxesFromList(Me.drSWO.gid)

    End Sub

    Private Sub btnSubmitToSupervisor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitToSupervisor.Click
        If Me.drSWO.sStatus <> "po" And Me.drSWO.sStatus <> "approved" And Me.drSWO.sStatus <> "supervisor" Then
            Me.drSWO.sStatus = "supervisor"
            Me.Close()
        Else
            Windows.Forms.MessageBox.Show("You cannot make changes or re-submit this SWO, it has already been submitted.")
        End If
    End Sub

    Private Sub btnCreateJobPo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateJobPo.Click

        Try
            Select Case Me.drSWO.sStatus
                Case "supervisor"
                    Windows.Forms.MessageBox.Show("Still waiting on Supervisor approval, cannot create PO.")
                Case "po"
                    Windows.Forms.MessageBox.Show("A PO has already been created, nothing can be done with this SWO.")
                Case "approved"

                    Dim sPOtoUse As String = ""
                    Dim newJobID As Integer = 0
                    sPOtoUse = GetNextPO(Me.drSWO.JOBID, True)
                    Me.drSWO.PONum = sPOtoUse
                    Me.txtPONum.Text = sPOtoUse
                    Me.SaveSWO()

                    newJobID = CreatePO(sPOtoUse, Me.drSWO.JOBID)

                    If newJobID > 0 And Me.TksijobsDataSet1.tblSWOOrder.Rows.Count > 0 Then
                        sPOtoUse = GetNextPO(Me.drSWO.JOBID, False)
                        CreateAdditionalPartsPO(sPOtoUse, newJobID, Me.TksijobsDataSet1.tblSWOOrder(0))
                    End If

                    If newJobID > 0 And Me.TksijobsDataSet1.tblSWOOrder.Rows.Count > 1 Then
                        sPOtoUse = GetNextPO(Me.drSWO.JOBID, False)
                        CreateAdditionalPartsPO(sPOtoUse, newJobID, Me.TksijobsDataSet1.tblSWOOrder(1))
                    End If

                    If newJobID > 0 And Me.TksijobsDataSet1.tblSWOOrder.Rows.Count > 2 Then
                        sPOtoUse = GetNextPO(Me.drSWO.JOBID, False)
                        CreateAdditionalPartsPO(sPOtoUse, newJobID, Me.TksijobsDataSet1.tblSWOOrder(2))
                    End If

                    If newJobID > 0 And Me.TksijobsDataSet1.tblSWOOrder.Rows.Count > 3 Then
                        sPOtoUse = GetNextPO(Me.drSWO.JOBID, False)
                        CreateAdditionalPartsPO(sPOtoUse, newJobID, Me.TksijobsDataSet1.tblSWOOrder(3))
                    End If

                    If newJobID > 0 And Me.TksijobsDataSet1.tblSWOOrder.Rows.Count > 4 Then
                        sPOtoUse = GetNextPO(Me.drSWO.JOBID, False)
                        CreateAdditionalPartsPO(sPOtoUse, newJobID, Me.TksijobsDataSet1.tblSWOOrder(4))
                    End If

                    Me.drSWO.sStatus = "po"
                    Me.Close()

                Case Else

                    Windows.Forms.MessageBox.Show("Salesperson is still working on this PO, it has not been submitted for approval yet.")

            End Select

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function CreateAdditionalPartsPO(ByVal sPONum As String, ByVal jobid As Integer, ByVal drOrder As TKSIJOBSDataSet.tblSWOOrderRow) As Integer

        Dim drJob As TKSIJOBSDataSet.tJobRow  'this is the newly created job
        Dim iResult As Integer = 0
        iResult = Me.TJobTableAdapter1.FillByNID(Me.TksijobsDataSet1.tJob, jobid)

        If iResult > 0 Then
            drJob = Me.TksijobsDataSet1.tJob(0)
            Me.TCustomrTableAdapter1.FillByLID(Me.TksijobsDataSet1.tCustomr, drJob.nCustID)

            Dim drCust As TKSIJOBSDataSet.tCustomrRow
            drCust = Me.TksijobsDataSet1.tCustomr(0)

            Dim drVendor As TKSIJOBSDataSet.tVendorRow
            drVendor = Me.TksijobsDataSet1.tVendor.FindBylid(drOrder.nVendorID)

            If (Not drVendor Is Nothing) And (Not drJob Is Nothing) Then

                Dim newPO As Integer = 0
                Dim dDate As Date = CDate("1/1/1900")
                Dim account As Integer = 4010
                Dim drPO As TKSIJOBSDataSet.tPOHeaderRow

                drPO = Me.TksijobsDataSet1.tPOHeader.AddtPOHeaderRow(drJob, Now.Date, drVendor, sPONum, drCust.sStreet1, drCust.sStreet2, drCust.sName, drCust.sCity, drCust.sProvState, drCust.sPostalZip, "", 0, Now.Date, drOrder.Terms, dDate, global_Username, 0, "TKSI", "Job Site", 0, account, 0, "", 0, dDate, dDate, "", "", dDate, account, "", 0, dDate, False, 1, "", "", "", "", drSWO.sPOType, 0, "", "", 1)

                With drPO
                    .dRequired = drSWO.dateOrderBy
                    .SetdSimplyNull()
                    .SetDFAXEDNull()
                    If drVendor.sName.ToUpper.Trim = "PULL FROM STOCK" Then
                        .DREC = Now.Date  'auto receive all 
                    Else
                        .SetDRECNull()
                    End If

                    .SetDDELNull()
                End With

                Me.TPOHeaderTableAdapter1.Update(Me.TksijobsDataSet1.tPOHeader)

                Dim linecount As Integer = 1
                Dim dr As TKSIJOBSDataSet.tblSWOOrderDetailRow
                Me.TblSWOOrderDetailTableAdapter1.FillByGSWOOrderID(Me.TksijobsDataSet1.tblSWOOrderDetail, drOrder.gid)
                Dim retailTotal As Decimal = 0
                For Each dr In Me.TksijobsDataSet1.tblSWOOrderDetail
                    If dr.ItemDesc.Trim.Length = 0 And dr.Cost = 0 And dr.Retail = 0 Then
                        'ignore
                    Else
                        Dim upcharges As Decimal = 0
                        Dim lineTotal As Decimal = 0
                        upcharges = drOrder.Upcharge1 + drOrder.Upcharge2 + drOrder.Upcharge3
                        lineTotal = CDec((dr.Retail * dr.Quantity) + (dr.Retail * dr.Quantity * upcharges)) * drOrder.CostFactor

                        retailTotal += CDec((dr.Retail * dr.Quantity) + (dr.Retail * dr.Quantity * upcharges)) * drOrder.RetailFactor
                        Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, dr.LineNum, "Item", Mid(dr.ItemDesc, 1, 250), 5010, False, lineTotal)
                        linecount += 1
                    End If
                Next

                If drOrder.CostShipping > 0 Then
                    Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Item", "Shipping", 5070, False, drOrder.CostShipping)
                End If

                drPO.nRetailSale = Decimal.Round(retailTotal, 2)
                drPO.nRetailFreight = Decimal.Round(drOrder.RetailShipping, 2)
                drPO.nAdd = Decimal.Round(drOrder.retailADD, 2)
                drPO.nTotal = Decimal.Round(retailTotal, 2)

                Try
                    drJob.nMaterialsCharge = drJob.nMaterialsCharge + drPO.nRetailSale + drPO.nRetailFreight + drOrder.retailADD
                    drJob.nTaxRate = drOrder.SalesTax
                    Me.TJobTableAdapter1.Update(Me.TksijobsDataSet1.tJob)
                Catch
                End Try

                Me.TPOHeaderTableAdapter1.Update(Me.TksijobsDataSet1.tPOHeader)
                Me.TPOLineTableAdapter1.Update(Me.TksijobsDataSet1.tPOLine)
            End If
        End If

    End Function

    Private Sub btnApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprove.Click
        Dim dReq As Date
        If Date.TryParse(Me.txtDateReq.Text, dReq) Then
            Select Case Me.drSWO.sStatus
                Case "supervisor"
                    Me.drSWO.sStatus = "approved"
                    Me.Close()
                Case "po"
                    Windows.Forms.MessageBox.Show("A PO has already been created, nothing can be done with this SWO.")
                Case "approved"
                    Windows.Forms.MessageBox.Show("This PO has already been approved.")
                Case Else
                    Windows.Forms.MessageBox.Show("Salesperson is still working on this PO, it has not been submitted for approval yet.")
            End Select

        Else
            Windows.Forms.MessageBox.Show("Date Required is not complete.  Cannot approve.")
        End If

    End Sub

    Private Function GetNextPO(ByVal nJOBID As Integer, ByVal blnIncrementLetter As Boolean) As String
        Dim drJob As TKSIJOBSDataSet.tJobRow
        Dim iResult As Integer = 0
        Dim dsTksi2 As New TKSIJOBSDataSet

        dsTksi2.EnforceConstraints = False

        iResult = Me.TJobTableAdapter1.FillByNID(dsTksi2.tJob, nJOBID)

        If iResult > 0 Then
            Dim addressID As Integer = 0
            drJob = dsTksi2.tJob(0)
            addressID = drJob.nAddressID
            iResult = Me.TJobTableAdapter1.FillByAddressID(Me.TksijobsDataSet1.tJob, addressID) 'fill is sorted by sjobNo
            If iResult > 0 Then
                Dim MaxLetterValue As Integer = 0
                'examine all of the job number strings associated with this address
                'the fifth character in the string should be a letter
                'if A B and C are used, then we want to find D as the next available letter
                'its also possible for the 6th char in the string to be a letter
                'like AA AB etc...  so account for that also
                Dim i As Integer = 0
                Dim HighestCharValueInUse As Integer = 0
                Dim CharToUseForNewPO As String = ""
                Dim newPO As String = ""
                Dim HighestNumberAfterDash As Integer = 0

                For i = 0 To Me.TksijobsDataSet1.tJob.Rows.Count - 1
                    Dim sLetter As String = ""
                    Dim bln5DigitJob As Boolean = False

                    If IsNumeric(Mid(Me.TksijobsDataSet1.tJob(i).sJobNo, 1, 6)) Then
                        bln5DigitJob = True
                        sLetter = Mid(Me.TksijobsDataSet1.tJob(i).sJobNo, 7, 1)
                    ElseIf IsNumeric(Mid(Me.TksijobsDataSet1.tJob(i).sJobNo, 1, 5)) Then
                        'new 5 digit job
                        bln5DigitJob = True
                        sLetter = Mid(Me.TksijobsDataSet1.tJob(i).sJobNo, 6, 1)
                    ElseIf IsNumeric(Mid(Me.TksijobsDataSet1.tJob(i).sJobNo, 1, 4)) Then
                        '4 digit job
                        bln5DigitJob = False
                        sLetter = Mid(Me.TksijobsDataSet1.tJob(i).sJobNo, 5, 1)
                    ElseIf IsNumeric(Mid(Me.TksijobsDataSet1.tJob(i).sJobNo, 1, 3)) Then
                        '3 digit job
                        bln5DigitJob = False
                        sLetter = Mid(Me.TksijobsDataSet1.tJob(i).sJobNo, 4, 1)
                    Else
                        'normal 4 digit job
                        bln5DigitJob = False
                        sLetter = Mid(Me.TksijobsDataSet1.tJob(i).sJobNo, 5, 1)
                    End If

                    If sLetter.Trim.Length > 0 Then
                        If Char.IsLetter(sLetter, 0) Then
                            'okay choose the next letter available for this new PO
                            If Char.ConvertToUtf32(sLetter, 0) > HighestCharValueInUse Then
                                HighestCharValueInUse = Char.ConvertToUtf32(sLetter, 0)
                            End If
                            ' End If
                        End If
                    End If

                    Dim drPO As TKSIJOBSDataSet.tPOHeaderRow
                    Me.TPOHeaderTableAdapter1.FillByNJOBID(Me.TksijobsDataSet1.tPOHeader, Me.TksijobsDataSet1.tJob(i).nID)
                    For Each drPO In Me.TksijobsDataSet1.tJob(i).GettPOHeaderRows
                        'after the dash, there is usually a number, that number continues to increment
                        'even when a new job letter is created, the number after the dash does not reset to 1
                        'so find the next number to use after the dash
                        Dim sNumber As String = ""    'example 5000A-12    12 is the 7th and 8th digits (there could be a letter immediately after the 12
                        If bln5DigitJob Then
                            Dim sTempNumber As String = Mid(drPO.sPONum, 8, 3).Trim

                            If IsNumeric(sTempNumber) Then
                                sNumber = Mid(drPO.sPONum, 8, 3).Trim
                            ElseIf IsNumeric(Mid(sTempNumber, 1, 2).Trim) Then
                                sNumber = Mid(sTempNumber, 1, 2).Trim
                            Else
                                sNumber = Mid(sTempNumber, 1, 1).Trim
                            End If


                        Else
                            Dim sTempNumber As String = Mid(drPO.sPONum, 7, 3).Trim

                            If IsNumeric(sTempNumber) Then
                                sNumber = sTempNumber
                            ElseIf IsNumeric(Mid(sTempNumber, 1, 2).Trim) Then
                                sNumber = Mid(sTempNumber, 1, 2).Trim
                            Else
                                sNumber = Mid(sTempNumber, 1, 1).Trim
                            End If

                            ' sNumber = Mid(drPO.sPONum, 7, 3).Trim  '-999 is highest, if there is more digits, they would be letters for sure after that
                        End If

                        If sNumber.Trim.Length > 2 Then 'make sure we have 3 digits before checking the third digit
                            If Char.IsNumber(sNumber, 2) Then
                                'all 3 digits are numbers, has to be over 99 POs!
                            ElseIf Char.IsNumber(sNumber, 1) Then
                                sNumber = Mid(sNumber, 1, 2).Trim
                            ElseIf Char.IsNumber(sNumber, 0) Then
                                sNumber = Mid(sNumber, 1, 1).Trim
                            End If
                        ElseIf sNumber.Trim.Length > 1 Then
                            'two digit check
                            If Char.IsNumber(sNumber, 1) Then
                                sNumber = Mid(sNumber, 1, 2).Trim
                            ElseIf Char.IsNumber(sNumber, 0) Then
                                sNumber = Mid(sNumber, 1, 1).Trim
                            End If
                        Else
                            sNumber = Mid(sNumber, 1, 1)
                        End If

                        If IsNumeric(sNumber) Then
                            If CInt(sNumber) > HighestNumberAfterDash Then
                                HighestNumberAfterDash = CInt(sNumber)
                            End If
                        Else
                            'doesnt seem to be a number after the dash, or the dash is perhaps in the wrong place? so abort
                            Windows.Forms.MessageBox.Show("The other PO's in this Job don't a standard number system, please create these PO's manually.")
                            Return ""
                        End If
                    Next
                Next

                If HighestCharValueInUse > 0 And HighestNumberAfterDash > 0 Then
                    If blnIncrementLetter Then
                        CharToUseForNewPO = Char.ConvertFromUtf32(HighestCharValueInUse + 1)
                        If HighestCharValueInUse > 90 Then
                            MessageBox.Show("Cannot create a PO because past Z")
                            'past Z so use AA?
                            'to do
                        End If
                    Else
                        CharToUseForNewPO = Char.ConvertFromUtf32(HighestCharValueInUse)
                    End If

                    If Char.IsLetter(CharToUseForNewPO) Then

                        Dim sJob5 As String = Mid(Me.txtJobNum.Text.Trim, 1, 5)
                        If IsNumeric(sJob5) Then
                            'leave as 5 digit for folder/file creation
                        Else
                            sJob5 = Mid(sJob5, 1, 4)
                        End If

                        If blnIncrementLetter Then
                            newPO = sJob5 & CharToUseForNewPO & "-" & (HighestNumberAfterDash + 1) & "SWO"

                        Else
                            newPO = sJob5 & CharToUseForNewPO & "-" & (HighestNumberAfterDash + 1)

                        End If
                        Return newPO
                    End If
                Else
                    Windows.Forms.MessageBox.Show("Please create these PO's manually, there was a problem trying to generate a new PO number for this Job.")
                    Return ""
                End If
            Else
                Windows.Forms.MessageBox.Show("Please create these PO's manually, there was a problem trying to generate a new PO number for this Job..")
                Return ""
            End If
        Else
            Windows.Forms.MessageBox.Show("Please create these PO's manually, there was a problem trying locating the previuos Jobs to generate a new PO number.")
            Return ""
        End If
    End Function

    Private Function CreatePO(ByVal sPONum As String, ByVal jobid As Integer) As Integer

        Me.SaveSWO()

        If Me.drSWO.NewCustomerInfo.Trim.Length > 0 Then
            Throw New Exception("This SWO has new customer info.  Please create the new customer, and save this SWO after selecting the newly created customer.")
        End If

        If Me.drSWO.dateOrderBy > CDate("1/1/1900") Then
        Else
            Throw New Exception("Date Required is not completed, cannot convert to PO.")
        End If

        Dim drJob As TKSIJOBSDataSet.tJobRow
        Dim iResult As Integer = 0
        iResult = Me.TJobTableAdapter1.FillByNID(Me.TksijobsDataSet1.tJob, jobid)

        If iResult > 0 Then
            drJob = Me.TksijobsDataSet1.tJob(0)
            Me.TCustomrTableAdapter1.FillByLID(Me.TksijobsDataSet1.tCustomr, Me.drSWO.CustID)
            Dim drCust As TKSIJOBSDataSet.tCustomrRow
            drCust = Me.TksijobsDataSet1.tCustomr(0)

            Dim sPOnum5Digit As String = Mid(sPONum, 1, 5)
            If IsNumeric(sPOnum5Digit) Then
                'use 6 digits, 5 for number 1 for letter needed also in this case
                sPOnum5Digit = Mid(sPONum, 1, 6)
            Else
                'leave 5 digit which includes 4 digit number and 1 digit letter
            End If
            sPONum = sPONum.TrimEnd("-")  ' a 4 digit would have a dash still hanging around
            Dim strSWOContactInfo As String = ""
            Try
                strSWOContactInfo = drSWO.JobContact
            Catch
            End Try

            Dim drJobNew As TKSIJOBSDataSet.tJobRow
            drJobNew = Me.TksijobsDataSet1.tJob.AddtJobRow(drJob.tAddressRow, ConvertRtfToText(drSWO.detail1), drSWO.dateCreated, Now.Date, sPOnum5Digit, drCust, drSWO.Phone, drSWO.JobContact, drJob.sCounty, 0, "", drSWO.PaymentTerms, "", drSWO.MaterialCharge, 0.0, drSWO.LaborCharge + drSWO.TripCharge, "", "", "", "", drSWO.Sales, "", CDate("1/1/1900"), "", drJob.dCrLimit, drJob.dAmtYTD, "", 0)
            drJobNew.SetdCommPaidNull()
            Me.TJobTableAdapter1.Update(Me.TksijobsDataSet1.tJob)

            Dim draVendor As TKSIJOBSDataSet.tVendorRow()
            draVendor = Me.TksijobsDataSet1.tVendor.Select("sName = 'Service Work Order'")

            If draVendor.Length > 0 Then

                Dim newPO As Integer = 0
                Dim dDate As Date = CDate("1/1/1900")
                Dim account As Integer = 4040
                Dim nSalePrice As Decimal = 0
                Dim nCost As Decimal = 0
                If drSWO.sPOType = "SWO-PO" Or drSWO.sPOType = "SWO" Then
                    nSalePrice = drSWO.TripCharge + drSWO.LaborCharge
                ElseIf drSWO.sPOType = "SWO-Jobcost" Then
                    nSalePrice = 0
                    nCost = drSWO.TripCharge + drSWO.LaborCharge
                Else
                    nCost = 0
                End If

                Dim sJobAddress As String = ""
                Dim sJobAdd2 As String = ""
                Dim sJobCity As String = ""
                Dim sJobState As String = ""
                Dim sJobZip As String = ""
                Try
                    If Not drJobNew.tAddressRow Is Nothing Then
                        sJobAddress = drJobNew.tAddressRow.sAddress1
                        sJobAdd2 = drJobNew.tAddressRow.sAddress2
                        sJobCity = drJobNew.tAddressRow.sCity
                        sJobState = drJobNew.tAddressRow.sState
                        sJobZip = drJobNew.tAddressRow.sZip
                    Else
                        sJobAddress = drCust.sStreet1
                        sJobAdd2 = drCust.sStreet2
                        sJobCity = drCust.sCity
                        sJobState = drCust.sProvState
                        sJobZip = drCust.sPostalZip
                    End If
                Catch
                End Try

                Dim drPO As TKSIJOBSDataSet.tPOHeaderRow
                drPO = Me.TksijobsDataSet1.tPOHeader.AddtPOHeaderRow(drJobNew, Now.Date, draVendor(0), sPONum, sJobAddress, sJobAdd2, drCust.sName, sJobCity, sJobState, sJobZip, "", 0, Now.Date, drSWO.PaymentTerms, dDate, global_Username, 0, "TKSI", "Job Site", nSalePrice, account, 0, "", 0, dDate, dDate, "", "", dDate, account, "", 0, dDate, False, 1, "", "", "", "", drSWO.sPOType, 0, "", "", 1)

                With drPO
                    .dRequired = drSWO.dateOrderBy
                    .SetdSimplyNull()
                    .SetDFAXEDNull()
                    .SetDRECNull()
                    .SetDDELNull()
                End With

                Me.TPOHeaderTableAdapter1.Update(Me.TksijobsDataSet1.tPOHeader)

                Dim drPOLine As TKSIJOBSDataSet.tPOLineRow
                With Me.drSWO
                    If Me.TksijobsDataSet1.tPOHeader.Rows.Count > 0 Then
                        Dim linecount As Integer = 1

                        If .detail1.Trim.Length > 0 Then
                            Dim strLineData As String = Mid(ConvertRtfToText(Me.drSWO.detail1), 1, 250)
                            If strLineData.Trim.Length > 0 Then
                                Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Comment", Mid(ConvertRtfToText(Me.drSWO.detail1), 1, 250), 0, False, 0)
                                linecount += 1
                            End If
                        End If

                        If .detail2.Trim.Length > 0 Then
                            Dim strLineData As String = Mid(ConvertRtfToText(Me.drSWO.detail2), 1, 250)
                            If strLineData.Trim.Length > 0 Then
                                Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Comment", Mid(ConvertRtfToText(Me.drSWO.detail2), 1, 250), 0, False, 0)
                                linecount += 1
                            End If
                        End If

                        If .detail3.Trim.Length > 0 Then
                            Dim strLineData As String = Mid(ConvertRtfToText(Me.drSWO.detail3), 1, 250)
                            If strLineData.Trim.Length > 0 Then
                                Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Comment", Mid(ConvertRtfToText(Me.drSWO.detail3), 1, 250), 0, False, 0)
                                linecount += 1
                            End If
                        End If

                        If .detail4.Trim.Length > 0 Then
                            Dim strLineData As String = Mid(ConvertRtfToText(Me.drSWO.detail4), 1, 250)
                            If strLineData.Trim.Length > 0 Then
                                Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Comment", Mid(ConvertRtfToText(Me.drSWO.detail4), 1, 250), 0, False, 0)
                                linecount += 1
                            End If
                        End If

                        If .detail5.Trim.Length > 0 Then
                            Dim strLineData As String = Mid(ConvertRtfToText(Me.drSWO.detail5), 1, 250)
                            If strLineData.Trim.Length > 0 Then
                                Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Comment", Mid(ConvertRtfToText(Me.drSWO.detail5), 1, 250), 0, False, 0)
                                linecount += 1
                            End If
                        End If

                        If .detail6.Trim.Length > 0 Then
                            Dim strLineData As String = Mid(ConvertRtfToText(Me.drSWO.detail6), 1, 250)
                            If strLineData.Trim.Length > 0 Then
                                Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Comment", Mid(ConvertRtfToText(Me.drSWO.detail6), 1, 250), 0, False, 0)
                                linecount += 1
                            End If
                        End If

                        If .detail7.Trim.Length > 0 Then
                            Dim strLineData As String = Mid(ConvertRtfToText(Me.drSWO.detail7), 1, 250)
                            If strLineData.Trim.Length > 0 Then
                                Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Comment", Mid(ConvertRtfToText(Me.drSWO.detail7), 1, 250), 0, False, 0)
                                linecount += 1
                            End If
                        End If

                        If .detail8.Trim.Length > 0 Then
                            Dim strLineData As String = Mid(ConvertRtfToText(Me.drSWO.detail8), 1, 250)
                            If strLineData.Trim.Length > 0 Then
                                Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Comment", Mid(ConvertRtfToText(Me.drSWO.detail8), 1, 250), 0, False, 0)
                                linecount += 1
                            End If
                        End If

                        If .detail9.Trim.Length > 0 Then
                            Dim strLineData As String = Mid(ConvertRtfToText(Me.drSWO.detail9), 1, 250)
                            If strLineData.Trim.Length > 0 Then
                                Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Comment", Mid(ConvertRtfToText(Me.drSWO.detail9), 1, 250), 0, False, 0)
                                linecount += 1
                            End If
                        End If

                        If .detail10.Trim.Length > 0 Then
                            Dim strLineData As String = Mid(ConvertRtfToText(Me.drSWO.detail10), 1, 250)
                            If strLineData.Trim.Length > 0 Then
                                Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Comment", Mid(ConvertRtfToText(Me.drSWO.detail10), 1, 250), 0, False, 0)
                                linecount += 1
                            End If
                        End If

                        If .detail11.Trim.Length > 0 Then
                            Dim strLineData As String = Mid(ConvertRtfToText(Me.drSWO.detail11), 1, 250)
                            If strLineData.Trim.Length > 0 Then
                                Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Comment", Mid(ConvertRtfToText(Me.drSWO.detail11), 1, 250), 0, False, 0)
                                linecount += 1
                            End If
                        End If

                        If .detail12.Trim.Length > 0 Then
                            Dim strLineData As String = Mid(ConvertRtfToText(Me.drSWO.detail12), 1, 250)
                            If strLineData.Trim.Length > 0 Then
                                Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Comment", Mid(ConvertRtfToText(Me.drSWO.detail12), 1, 250), 0, False, 0)
                                linecount += 1
                            End If
                        End If

                        If nCost > 0 Then
                            Me.TksijobsDataSet1.tPOLine.AddtPOLineRow(drPO, linecount, "Item", "Labor", 5040, False, nCost)
                            linecount += 1
                        End If

                        Me.TPOLineTableAdapter1.Update(Me.TksijobsDataSet1.tPOLine)
                    End If
                End With

                Dim sJobWithLetter As String = drJobNew.sJobNo
                Dim sJobNumeric As String = Mid(sJobWithLetter, 1, 6)
                If IsNumeric(sJobNumeric) Then
                    'leave as 6 digit for folder/file creation
                ElseIf IsNumeric(Mid(sJobWithLetter, 1, 5)) Then
                    sJobNumeric = Mid(sJobWithLetter, 1, 5)
                Else
                    sJobNumeric = Mid(sJobWithLetter, 1, 4)
                End If

                Dim jobImagePath As String = sImagesPath & sJobNumeric & "\" & sJobWithLetter & "\"
                Dim swoImagePath As String = ""
                swoImagePath = jobImagePath & GetNextImageNumber(sJobNumeric, sJobWithLetter) & ".JPG"
                Try
                    If Not IO.Directory.Exists(jobImagePath) Then
                        IO.Directory.CreateDirectory(jobImagePath)
                    End If

                    'the main SWO form gets created as an image JPG type from form output
                    Dim img1 As Image
                    img1 = Me.BuildSWOImage
                    Dim destPath As String = ""
                    If Not img1 Is Nothing Then
                        destPath = jobImagePath & GetNextImageNumber(sJobNumeric, sJobWithLetter) & ".JPG"
                        img1.Save(destPath, Imaging.ImageFormat.Jpeg)
                    End If


                    'the main SWO form gets created as an image JPG type from form output
                    Dim imgParts As Image
                    imgParts = Me.BuildSWOPartsImage

                    If Not imgParts Is Nothing Then
                        destPath = jobImagePath & GetNextImageNumber(sJobNumeric, sJobWithLetter) & ".JPG"
                        imgParts.Save(destPath, Imaging.ImageFormat.Jpeg)
                    End If

                    Try
                        Dim drImage As TKSIJOBSDataSet.tblSWOImagesRow
                        For Each drImage In Me.TksijobsDataSet1.tblSWOImages
                            If IO.File.Exists(drImage.ImagePath) Then
                                Dim sNextImgNum As String = GetNextImageNumber(sJobNumeric, sJobWithLetter)
                                destPath = jobImagePath & GetNextImageNumber(sJobNumeric, sJobWithLetter) & ".TIF"

                                Dim dir1 As String = Replace(destPath, ".TIF", "")
                                If Not IO.Directory.Exists(jobImagePath) Then
                                    IO.Directory.CreateDirectory(jobImagePath)
                                End If
                                IO.File.Copy(drImage.ImagePath, destPath, True)
                            End If
                        Next
                    Catch ex As Exception
                        Windows.Forms.MessageBox.Show("Error setting up new job images... " & ex.Message)
                    End Try

                Catch ex1 As Exception
                    MessageBox.Show("error creating image directory for job, check permissions on server folder. " & ex1.Message)
                End Try
                Me.blnCreatedPO = True

                Return drJobNew.nID

            End If
        Else
            Windows.Forms.MessageBox.Show("Could not create PO, job was not located.")
        End If


    End Function

    Private Sub btnRejectSWO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRejectSWO.Click
        Select Case Me.drSWO.sStatus
            Case "supervisor"
                If Windows.Forms.MessageBox.Show("Are you sure you want to reject this SWO?", "Reject SWO?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.Yes Then
                    Me.drSWO.sStatus = "sales"
                    Me.Close()
                End If

            Case "po"
                Windows.Forms.MessageBox.Show("A PO has already been created, nothing can be done with this SWO.")
            Case "approved"
                If Windows.Forms.MessageBox.Show("Are you sure you want to reject this SWO, even though you previuosly approved it?", "Reject Approved SWO?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.Yes Then
                    Me.drSWO.sStatus = "sales"
                    Me.Close()
                End If

            Case Else
                Windows.Forms.MessageBox.Show("Salesperson is still working on this PO, it has not been submitted for approval yet.")
        End Select
    End Sub

    Private Sub chkJobcost_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkJobcost.Click
        If Me.chkJobcost.Checked Then
            Me.cmbTerms.Text = ""
            Me.cmbTerms.Enabled = False
        End If
    End Sub

    Private Sub chkWarranty_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkWarranty.Click
        If Me.chkWarranty.Checked Then
            Me.cmbTerms.Text = ""
            Me.cmbTerms.Enabled = False
        End If
    End Sub

    Private Sub chkSWO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSWO.Click
        If Me.chkSWO.Checked Then
            If Me.cmbTerms.Text.Trim = "" Then
                Me.cmbTerms.Text = "Net 30"
            End If
            Me.cmbTerms.Enabled = True
        End If
    End Sub

    Private Sub btnChangeCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeCustomer.Click
        Try
            Dim frmCust As New frmSWOCustomer
            frmCust.ShowDialog()
            If frmCust.OK Then
                If frmCust.blnNewCustomer Then
                    Me.txtNameAddress.Text = frmCust.strNewCustomer
                    Me.drSWO.NewCustomerInfo = frmCust.strNewCustomer.Trim
                    Me.TblSWOPendingTableAdapter1.Update(Me.TksijobsDataSet1.tblSWOPending)
                Else
                    Me.drSWO.CustID = frmCust.nCustID
                    Me.drSWO.NewCustomerInfo = ""
                    Me.TblSWOPendingTableAdapter1.Update(Me.TksijobsDataSet1.tblSWOPending)
                    Me.TCustomrTableAdapter1.FillByLID(Me.TksijobsDataSet1.tCustomr, Me.drSWO.CustID)

                    Dim sCustInfo As String = ""
                    If Me.TksijobsDataSet1.tCustomr.Rows.Count > 0 Then
                        Dim drCust As TKSIJOBSDataSet.tCustomrRow
                        drCust = Me.TksijobsDataSet1.tCustomr(0)
                        sCustInfo = drCust.sName & vbCrLf & drCust.sStreet1 & vbCrLf & drCust.sStreet2 & vbCrLf & drCust.sCity & ", " & drCust.sProvState & " " & drCust.sPostalZip
                        Me.txtNameAddress.Text = sCustInfo.Trim
                    End If
                End If

            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error changing customer.  " & ex.Message)
        End Try
    End Sub

    Private Sub btnBold1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold1.Click
        Me.BoldRTFBox(Me.txtDetails1)
    End Sub

    Private Sub btnBold2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold2.Click
        Me.BoldRTFBox(Me.txtDetails2)
    End Sub

    Private Sub BoldRTFBox(ByVal rtfBox As RichTextBox)
        If rtfBox.SelectionFont Is Nothing Then
            rtfBox.SelectionFont = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        End If
        If rtfBox.SelectionLength > 0 Then
            If Not rtfBox.SelectionFont.Bold Then
                rtfBox.SelectionFont = New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point)
            Else
                rtfBox.SelectionFont = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
            End If
        Else
            rtfBox.SelectAll()
            If Not rtfBox.SelectionFont.Bold Then
                rtfBox.SelectionFont = New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point)
            Else
                rtfBox.SelectionFont = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
            End If
        End If
    End Sub

    Private Sub btnBold3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold3.Click
        Me.BoldRTFBox(Me.txtDetails3)
    End Sub

    Private Sub btnBold4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold4.Click
        Me.BoldRTFBox(Me.txtDetails4)
    End Sub

    Private Sub btnBold5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold5.Click
        Me.BoldRTFBox(Me.txtDetails5)
    End Sub

    Private Sub btnBold6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold6.Click
        Me.BoldRTFBox(Me.txtDetails6)
    End Sub

    Private Sub btnBold7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold7.Click
        Me.BoldRTFBox(Me.txtDetails7)
    End Sub

    Private Sub btnBold8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold8.Click
        Me.BoldRTFBox(Me.txtDetails8)
    End Sub

    Private Sub btnBold9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold9.Click
        Me.BoldRTFBox(Me.txtDetails9)
    End Sub

    Public Function BuildSWOImage() As Image

        Dim img1 As Bitmap
        Dim iVertical As Integer = 0
        Dim iHorz As Integer = 0

        If Not Me.drSWO Is Nothing Then
            img1 = New Bitmap(1700, 2200)
            Dim fontMD As New Font("Arial", 28, FontStyle.Regular)
            Dim fontBG As New Font("Arial", 36, FontStyle.Bold)
            Dim fontSM As New Font("Arial", 18, FontStyle.Regular)
            Dim e As Graphics
            e = Graphics.FromImage(img1)

            e.FillRectangle(Brushes.White, New Rectangle(0, 0, 1700, 2200))

            Dim iScale As Integer = 2

            With Me.drSWO
                Me.DrawBoxData(Me.txtSWOHeader, fontBG, iScale, e)
                Me.DrawBoxData(Me.txtTKSIData, fontSM, iScale, e)

                Dim strCustJob As String = Me.txtNameAddress.Text.Trim
                Try
                    Dim iCR As Integer = 0
                    iCR = InStr(strCustJob, vbCrLf)
                    If iCR > 1 Then
                        strCustJob = Mid(Me.txtNameAddress.Text, 1, iCR - 1)
                    End If
                    strCustJob = strCustJob & vbCrLf & Me.txtJobLocation.Text
                    Me.txtNameAddress.Text = strCustJob
                Catch
                End Try

                e.DrawString(.sPOType, fontMD, Brushes.Black, (Me.lblSWOType.Location.X - 90) * iScale, Me.lblSWOType.Location.Y * iScale)

                Me.DrawBoxData(Me.lblNameAddress, fontSM, iScale, e)
                Me.DrawBoxData(Me.txtNameAddress, fontSM, iScale, e)

                Me.DrawBoxData(Me.lblDateOfOrder, fontSM, iScale, e)
                Me.DrawBoxData(Me.txtDateofOrder, fontMD, iScale, e)

                Me.DrawBoxData(Me.lblDateReq, fontSM, iScale, e)
                Me.DrawBoxData(Me.txtDateReq, fontMD, iScale, e)

                Me.DrawBoxData(Me.lblPhone, fontSM, iScale, e)
                Me.DrawBoxData(Me.txtPhone, fontMD, iScale, e)

                Me.DrawBoxData(Me.lblJobNum, fontSM, iScale, e)
                Me.DrawBoxData(Me.txtJobNum, fontMD, iScale, e)

                Me.DrawBoxData(Me.txtPONum, fontMD, iScale, e)

                Me.DrawBoxData(Me.lblTerms, fontSM, iScale, e)
                Me.DrawBoxData(Me.cmbTerms, fontMD, iScale, e)

                Me.DrawBoxData(Me.lblJobContact, fontSM, iScale, e)
                Me.DrawBoxData(Me.txtJobContact, fontMD, iScale, e)

                Me.DrawBoxData(Me.lblSWODetails, fontSM, 620, e)

                If Me.txtDetails1.Text.Trim.Length > 0 Then
                    e.DrawString("1:  " & Me.txtDetails1.Text, fontSM, Brushes.Black, 50, 600)
                End If
                If Me.txtDetails2.Text.Trim.Length > 0 Then
                    e.DrawString("2:  " & Me.txtDetails2.Text, fontSM, Brushes.Black, 50, 650)
                End If
                If Me.txtDetails3.Text.Trim.Length > 0 Then
                    e.DrawString("3:  " & Me.txtDetails3.Text, fontSM, Brushes.Black, 50, 700)
                End If
                If Me.txtDetails4.Text.Trim.Length > 0 Then
                    e.DrawString("4:  " & Me.txtDetails4.Text, fontSM, Brushes.Black, 50, 750)
                End If
                If Me.txtDetails5.Text.Trim.Length > 0 Then
                    e.DrawString("5:  " & Me.txtDetails5.Text, fontSM, Brushes.Black, 50, 800)
                End If
                If Me.txtDetails6.Text.Trim.Length > 0 Then
                    e.DrawString("6:  " & Me.txtDetails6.Text, fontSM, Brushes.Black, 50, 850)
                End If
                If Me.txtDetails7.Text.Trim.Length > 0 Then
                    e.DrawString("7:  " & Me.txtDetails7.Text, fontSM, Brushes.Black, 50, 900)
                End If
                If Me.txtDetails8.Text.Trim.Length > 0 Then
                    e.DrawString("8:  " & Me.txtDetails8.Text, fontSM, Brushes.Black, 50, 950)
                End If
                If Me.txtDetails9.Text.Trim.Length > 0 Then
                    e.DrawString("9:  " & Me.txtDetails9.Text, fontSM, Brushes.Black, 50, 1000)
                End If
                If Me.txtDetails10.Text.Trim.Length > 0 Then
                    e.DrawString("10:  " & Me.txtDetails10.Text, fontSM, Brushes.Black, 50, 1050)
                End If
                If Me.txtDetails11.Text.Trim.Length > 0 Then
                    e.DrawString("11:  " & Me.txtDetails11.Text, fontSM, Brushes.Black, 50, 1100)
                End If
                If Me.txtDetails12.Text.Trim.Length > 0 Then
                    e.DrawString("12:  " & Me.txtDetails12.Text, fontSM, Brushes.Black, 50, 1150)
                End If

                Me.DrawBoxData(Me.lblMaterial, fontSM, iScale + 0.7, e)
                Me.DrawBoxData(Me.txtMaterials, fontSM, iScale + 0.7, e)

                Me.DrawBoxData(Me.lbltax, fontSM, iScale + 0.7, e)
                Me.DrawBoxData(Me.txtTax, fontSM, iScale + 0.7, e)

                Me.DrawBoxData(Me.lbltripCharge, fontSM, iScale + 0.7, e)
                Me.DrawBoxData(Me.txtTripCharge, fontSM, iScale + 0.7, e)

                Me.DrawBoxData(Me.lblLabor, fontSM, iScale + 0.7, e)
                Me.DrawBoxData(Me.txtLabor, fontSM, iScale + 0.7, e)

                Me.DrawBoxData(Me.lblTotal, fontSM, iScale + 0.7, e)
                Me.DrawBoxData(Me.txtTotal, fontSM, iScale + 0.7, e)

                Dim iEmptyBoxY As Integer = (Me.txtTotal.Location.Y * (iScale + 0.7)) + 50

                Dim rect2 As New Rectangle
                rect2.X = 15 * iScale
                rect2.Y = (iEmptyBoxY)
                rect2.Width = 780 * iScale
                rect2.Height = 50 * (iScale)
                e.DrawRectangle(Pens.Black, rect2)
                e.DrawString("Date Completed:                             Technician Signature:", fontSM, Brushes.Black, 35 * iScale, iEmptyBoxY + 10)

                Dim rect3 As New Rectangle
                rect3.X = 15 * iScale
                rect3.Y = (iEmptyBoxY + (50 * (iScale + 0.7)))
                rect3.Width = 780 * iScale
                rect3.Height = 50 * (iScale)
                e.DrawRectangle(Pens.Black, rect3)
                e.DrawString("Time Started:                          Time Finished:                            Hours:", fontSM, Brushes.Black, 35 * iScale, iEmptyBoxY + (50 * (iScale + 0.7)) + 10)

                Dim rect4 As New Rectangle
                rect4.X = 15 * iScale
                rect4.Y = (iEmptyBoxY + (100 * (iScale + 0.7)))
                rect4.Width = 780 * iScale
                rect4.Height = 50 * (iScale)
                e.DrawRectangle(Pens.Black, rect4)
                e.DrawString("Customer's Signature (I hereby accept above performed service and charges as being satisfactory and completed.)", fontSM, Brushes.Black, 35 * iScale, iEmptyBoxY + (100 * (iScale + 0.7)) + 10)

                Dim rect1 As New Rectangle
                rect1.X = (Me.txtPartsOrders.Location.X - 5) * iScale
                rect1.Y = (Me.txtPartsOrders.Location.Y - 5) * (iScale + 0.7)
                rect1.Width = 350 * iScale
                rect1.Height = 130 * (iScale)
                e.DrawRectangle(Pens.Black, rect1)
                Me.DrawBoxData(Me.txtPartsOrders, fontSM, (iScale + 0.7), e)

                Dim lvi As ListViewItem
                Dim iXLoc As Integer = Me.lvPartsOrders.Location.X
                Dim iYloc As Integer = Me.lvPartsOrders.Location.Y
                For Each lvi In Me.lvPartsOrders.Items
                    iYloc += 1
                    If lvi.Text.Trim.Length > 0 Then
                        Dim strLV As String = ""
                        Try
                            strLV = lvi.SubItems(1).Text
                            If lvi.SubItems.Count > 2 Then
                                strLV = strLV & "  " & lvi.SubItems(2).Text
                            End If
                        Catch
                        End Try

                        e.DrawString(strLV, fontMD, Brushes.Black, iXLoc * iScale, iYloc * (iScale + 0.7))
                    End If
                Next

            End With

            Return img1
        Else
            Return Nothing
        End If
    End Function

    Private Sub DrawBoxData(ByVal ctrl As Control, ByVal font1 As Font, ByVal ScaleFactor As Decimal, ByVal e As Graphics)
        Dim iVert As Integer = 0
        Dim iHorz As Integer = 0
        iVert = ctrl.Location.Y * ScaleFactor
        iHorz = ctrl.Location.X * ScaleFactor

        Dim str As String = ctrl.Text.Trim
        str = Replace(str, vbCrLf & vbCrLf, vbCrLf) 'remove  CR/LF
        e.DrawString(str, font1, Brushes.Black, iHorz, iVert)
    End Sub

    Private Sub DrawStringData(ByVal iBullet As Integer, ByVal oRTF As RichTextBox, ByVal font1 As Font, ByVal ScaleFactor As Decimal, ByVal e As Graphics)
        Dim iVert As Integer = 0
        Dim iHorz As Integer = 0
        iHorz = oRTF.Location.X * ScaleFactor
        iVert = oRTF.Location.Y * ScaleFactor
        If oRTF.Text.Trim.Length > 0 Then
            e.DrawString(iBullet.ToString & ":  " & oRTF.Text, font1, Brushes.Black, iHorz, iVert)
        End If

        'Dim rtf1 As New RichTextUtil
        'rtf1.Rtf = oRTF.Rtf
        'rtf1.Draw(1, rtf1.Text.Length, e, iHorz, iVert, iHorz + 300, iVert + 50, 1)

    End Sub

    Public Function BuildSWOPartsImage() As Image

        Dim frmP As frmSWOParts
        Dim gid As String = ""
        If Me.lvPartsOrders.Items.Count > 0 Then
            gid = Me.lvPartsOrders.Items(0).Text
            frmP = New frmSWOParts
            frmP.LoadSWOOrder(New Guid(gid), Me.drSWO.JOBID)
            frmP.Show()
            frmP.Refresh()
        Else
            Return Nothing
        End If

        Dim img1 As Bitmap
        Dim iVertical As Integer = 0
        Dim iHorz As Integer = 0

        img1 = frmP.BuildSWOPartsImage()

        Try
            If Not frmP Is Nothing Then
                frmP.Close()
            End If

        Catch
        End Try
        Return img1

    End Function

    Private Sub btnPrintSWO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSWO.Click
        Dim img1 As Image
        img1 = Me.BuildSWOImage
        Dim frmImg As New frmFullpage
        frmImg.PictureBox1.Image = img1
        frmImg.Show()
    End Sub

End Class