Imports System.Drawing

Public Class frmSWOParts

    Public drOrder As TKSIJOBSDataSet.tblSWOOrderRow

    Public Sub LoadSWOOrder(ByVal gidSWOOrder As Guid, ByVal nJobID As Integer)

        Me.TEmployeeTableAdapter1.Fill(Me.TksijobsDataSet1.tEmployee)
        Me.TVendorTableAdapter1.Fill(Me.TksijobsDataSet1.tVendor)
        LoadManufactureCombo()
        LoadSalesCombo()

        Me.TblSWOOrderTableAdapter1.FillByGID(Me.TksijobsDataSet1.tblSWOOrder, gidSWOOrder)

        Me.TblSWOOrderDetailTableAdapter1.FillByGSWOOrderID(Me.TksijobsDataSet1.tblSWOOrderDetail, gidSWOOrder)

        If Me.TksijobsDataSet1.tblSWOOrder.Rows.Count > 0 Then
            Me.drOrder = Me.TksijobsDataSet1.tblSWOOrder(0)

            With Me.drOrder

                Me.txtBillTo.Text = .BillTo
                Me.txtShipto.Text = .ShipTo
                Me.txtRetailFactor.Text = .RetailFactor.ToString.TrimEnd("0")
                Me.txtRetailShipping.Text = Format(.RetailShipping, "currency")
                Me.txtCostFactor.Text = .CostFactor.ToString.TrimEnd("0")
                Me.txtCostShipping.Text = Format(.CostShipping, "currency")
                Me.txtShipVia.Text = Me.drOrder.ShipVia
                Me.txtSalesTax.Text = .SalesTax
                Me.txtADD.Text = Format(.retailADD, "currency")
                Me.txtTerms.Text = Me.drOrder.Terms
                Me.txtSDA.Text = Me.drOrder.SDANum
                Me.txtCompletionDate.Text = Me.drOrder.CompletionDate

                Try
                    If Me.drOrder.ShipWeekOf > CDate("1/1/2001") Then
                        Me.txtShipWeek.Text = Me.drOrder.ShipWeekOf.ToShortDateString
                    End If
                    If Me.drOrder.OrderDate > CDate("1/1/2001") Then
                        Me.txtOrderDate.Text = .OrderDate.ToShortDateString
                    End If
                Catch
                End Try

                Try
                    If .nVendorID > 0 Then
                        Me.cmbManufacture.Text = Me.TksijobsDataSet1.tVendor.FindBylid(.nVendorID).sName
                    End If
                    Me.cmbSales.Text = .sSalesName
                    Me.txtJobContact.Text = .JobContact
                Catch
                End Try

                Try

                    If .Upcharge1 > 0 Then
                        Me.txtUpcharge1.Visible = True
                        Me.txtUpcharge1.Text = .Upcharge1.ToString.TrimEnd("0")
                    End If


                    If .Upcharge2 > 0 Then
                        Me.txtUpcharge2.Visible = True
                        Me.txtUpcharge2.Text = .Upcharge2.ToString.TrimEnd("0")
                    End If


                    If .Upcharge3 > 0 Then
                        Me.txtUpcharge3.Text = .Upcharge3.ToString.TrimEnd("0")
                        Me.txtUpcharge3.Visible = True
                    End If

                    Me.lblUpcharge1.Text = .Upcharge1Label
                    Me.lblUpcharge2.Text = .Upcharge2Label
                    Me.lblUpcharge3.Text = .Upcharge3Label
                Catch
                End Try

                Try
                    With Me.drOrder

                        Me.txtDescription.Text = .Description
                        Me.txtDoorStyleBase.Text = .DoorStyleBase
                        Me.txtDoorStyleWall.Text = .DoorStyleWall
                        Me.txtFinishMod.Text = .FinishMod
                        Me.txtHinge.Text = .Hinge
                        Me.txtLaminate.Text = .Laminate
                        Me.txtWood.Text = .wood
                        Me.txtPO.Text = .PONum

                        If .MapleMelInt = "true" Then
                            Me.chkMapleMelamIntDwr.Checked = True
                        End If
                        If .MapleMelIntDoveDwr = "true" Then
                            Me.chkMapleMelDoveDwr.Checked = True
                        End If
                        If .WhiteMelInt = "true" Then
                            Me.chkWhiteMelInt.Checked = True
                        End If
                        If .WoodDoveDwr = "true" Then
                            Me.chkWoodDoveDwr.Checked = True
                        End If
                    End With

                Catch

                End Try

            End With
            UpdateDetailTotals()

            ReCalculateTotals()
        End If

    End Sub

    Private Sub LoadManufactureCombo()

        Me.cmbManufacture.Items.Clear()
        Me.cmbManufacture.ValueMember = "lid"
        Me.cmbManufacture.DisplayMember = "sName"

        Dim drVen As TKSIJOBSDataSet.tVendorRow
        For Each drVen In Me.TksijobsDataSet1.tVendor
            If drVen.IsIgnoreSchedulingNull Then
                Me.cmbManufacture.Items.Add(drVen)
            ElseIf Not drVen.IgnoreScheduling Then
                Me.cmbManufacture.Items.Add(drVen)
            Else
                'dont add

            End If
        Next
    End Sub

    Private Sub LoadSalesCombo()

        Me.cmbSales.Items.Clear()
        Me.cmbSales.ValueMember = "nickname"
        Me.cmbSales.DisplayMember = "nickname"

        Dim drEmp As TKSIJOBSDataSet.tEmployeeRow
        For Each drEmp In Me.TksijobsDataSet1.tEmployee
            If Not drEmp.archive Then
                Me.cmbSales.Items.Add(drEmp)
            End If
        Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Close()
    End Sub

    Private Sub SaveSWOParts()

        Try
            Me.Validate()
            Me.TblSWOOrderDetailBindingSource.EndEdit()
            Me.TblSWOOrderDetailTableAdapter1.Update(Me.TksijobsDataSet1.tblSWOOrderDetail)
        Catch
        End Try

        With Me.drOrder
            Try
                .nVendorID = Me.cmbManufacture.SelectedValue
            Catch
                Windows.Forms.MessageBox.Show("Error saving Vendor")
            End Try
            Try
                .sSalesName = Me.cmbSales.Text
                If IsNumeric(Me.txtRetailFactor.Text) Then
                    .RetailFactor = Me.txtRetailFactor.Text
                End If
                If IsNumeric(Me.txtCostFactor.Text) Then
                    .CostFactor = Me.txtCostFactor.Text
                End If

                If IsNumeric(Me.txtRetailShipping.Text) Then
                    .RetailShipping = Me.txtRetailShipping.Text
                End If

                If IsNumeric(Me.txtCostShipping.Text) Then
                    .CostShipping = Me.txtCostShipping.Text
                End If
                If IsNumeric(Me.txtADD.Text) Then
                    .retailADD = CSng(Me.txtADD.Text)
                End If

            Catch
                Windows.Forms.MessageBox.Show("Error saving factor/shipping amounts.")
            End Try

            Try
                If IsNumeric(Me.txtSalesTax.Text) Then
                    .SalesTax = Me.txtSalesTax.Text
                Else
                    .SalesTax = 0
                End If
            Catch
            End Try

            Try
                .nVendorID = CType(Me.cmbManufacture.SelectedItem, TKSIJOBSDataSet.tVendorRow).lid
            Catch
                .nVendorID = 0
            End Try

            Try
                .ShipVia = Me.txtShipVia.Text
                .BillTo = Me.txtBillTo.Text
                .ShipTo = Me.txtShipto.Text
                .Terms = Me.txtTerms.Text
            Catch
                Windows.Forms.MessageBox.Show("Error saving ShipVia/BillTo/ShipTo/Terms")
            End Try

            Try
                .JobContact = Me.txtJobContact.Text.Trim
                .SDANum = Me.txtSDA.Text.Trim
                .CompletionDate = Me.txtCompletionDate.Text.Trim
            Catch ex As Exception
            End Try

            Try
                If Me.txtShipWeek.Text.Trim.Length > 0 Then
                    If IsDate(Me.txtShipWeek.Text) Then
                        .ShipWeekOf = CDate(Me.txtShipWeek.Text)
                    End If
                End If
            Catch
                Windows.Forms.MessageBox.Show("Error saving ship week.")
            End Try

            Try
                If Me.txtOrderDate.Text.Trim.Length > 0 Then
                    If IsDate(Me.txtOrderDate.Text) Then
                        .OrderDate = CDate(Me.txtOrderDate.Text)
                    End If
                End If
            Catch
                Windows.Forms.MessageBox.Show("Error saving Order Date.")
            End Try

            Try

                .Description = Me.txtDescription.Text.Trim
                .DoorStyleBase = Me.txtDoorStyleBase.Text.Trim
                .DoorStyleWall = Me.txtDoorStyleWall.Text.Trim
                .FinishMod = Me.txtFinishMod.Text.Trim
                .Hinge = Me.txtHinge.Text.Trim
                .Laminate = Me.txtLaminate.Text.Trim
                .wood = Me.txtWood.Text.Trim
                .PONum = Me.txtPO.Text

                If Me.chkMapleMelamIntDwr.Checked Then
                    .MapleMelInt = "true"
                End If
                If Me.chkMapleMelDoveDwr.Checked Then
                    .MapleMelIntDoveDwr = "true"
                End If
                If Me.chkWhiteMelInt.Checked = True Then
                    .WhiteMelInt = "true"
                End If
                If Me.chkWoodDoveDwr.Checked = True Then
                    .WoodDoveDwr = "true"
                End If

            Catch
            End Try

            Try
                If IsNumeric(Me.txtUpcharge1.Text) Then
                    .Upcharge1 = Me.txtUpcharge1.Text
                    .Upcharge1Label = Me.lblUpcharge1.Text
                End If
                If IsNumeric(Me.txtUpcharge2.Text) Then
                    .Upcharge2 = Me.txtUpcharge2.Text
                    .Upcharge2Label = Me.lblUpcharge2.Text
                End If
                If IsNumeric(Me.txtUpcharge3.Text) Then
                    .Upcharge3 = Me.txtUpcharge3.Text
                    .Upcharge3Label = Me.txtUpcharge3.Text
                End If
            Catch exupcharge As Exception
                Windows.Forms.MessageBox.Show("Error calculating upcharge. " & exupcharge.Message)
            End Try

            Me.TblSWOOrderTableAdapter1.Update(Me.TksijobsDataSet1.tblSWOOrder)

        End With
    End Sub

    Private Sub txtRetailFactor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetailFactor.Leave
        If IsNumeric(Me.txtRetailFactor.Text) Then
            ReCalculateTotals()
        End If
    End Sub

    Private Sub txtRetailShipping_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetailShipping.Leave
        If IsNumeric(Me.txtRetailShipping.Text) Then
            ReCalculateTotals()
        End If
    End Sub

    Private Sub ReCalculateTotals()
        Dim drDetail As TKSIJOBSDataSet.tblSWOOrderDetailRow

        Dim sngRetail As Decimal = 0
        Dim sngCost As Decimal = 0
        Dim sngRetailExtended As Decimal = 0

        Dim i As Integer
        For i = 0 To Me.TblSWOOrderDetailDataGridView.Rows.Count - 1
            Dim sQuantity As String = Me.TblSWOOrderDetailDataGridView.Rows(i).Cells(3).Value
            Dim sRetail As String = Me.TblSWOOrderDetailDataGridView.Rows(i).Cells(11).Value
            Dim sExtended As String = Me.TblSWOOrderDetailDataGridView.Rows(i).Cells(12).Value
            If IsNumeric(sExtended) Then
                sngRetail += CSng(sExtended)
            End If
        Next

        If IsNumeric(Me.txtUpcharge1.Text) Then
            sngRetail = sngRetail + (CSng(Me.txtUpcharge1.Text) * sngRetail)
        End If
        If IsNumeric(Me.txtUpcharge2.Text) Then
            sngRetail = sngRetail + (CSng(Me.txtUpcharge2.Text) * sngRetail)
        End If
        If IsNumeric(Me.txtUpcharge3.Text) Then
            sngRetail = sngRetail + (CSng(Me.txtUpcharge3.Text) * sngRetail)
        End If

        If IsNumeric(Me.txtCostFactor.Text) Then
            sngCost = sngRetail * CSng(Me.txtCostFactor.Text)
        End If

        If IsNumeric(Me.txtRetailFactor.Text) Then
            sngRetail = sngRetail * Me.txtRetailFactor.Text
        End If

        If IsNumeric(Me.txtRetailShipping.Text) Then
            sngRetail += CSng(Me.txtRetailShipping.Text)
        End If

        If IsNumeric(Me.txtADD.Text) Then
            sngRetail += CSng(Me.txtADD.Text)
        End If

        If IsNumeric(Me.txtSalesTax.Text) Then
            If CSng(Me.txtSalesTax.Text) > 0.2 Then
                Me.txtTAX.Text = Format(sngRetail * CSng(Me.txtSalesTax.Text) / 100, "currency")
                sngRetail += sngRetail * CSng(Me.txtSalesTax.Text) / 100
            End If

        End If

        If IsNumeric(Me.txtCostShipping.Text) Then
            sngCost += CSng(Me.txtCostShipping.Text)
        End If

        If IsNumeric(Me.txtRetailFactor.Text) Then
            Me.txtRetailTotal.Text = Format(sngRetail, "currency")
        End If

        If IsNumeric(Me.txtRetailFactor.Text) Then
            'dont calculate cost total at all if there is no factor typed in
            Me.txtCostTotal.Text = Format(sngCost, "currency")
        End If

    End Sub

    Private Sub txtCostFactor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostFactor.Leave
        If IsNumeric(Me.txtCostFactor.Text) Then
            ReCalculateTotals()
        End If
    End Sub

    Private Sub txtCostShipping_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostShipping.Leave
        If IsNumeric(Me.txtCostShipping.Text) Then
            ReCalculateTotals()
        End If
    End Sub

    Private Sub TblSWOOrderDetailDataGridView_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblSWOOrderDetailDataGridView.CellLeave
        Dim iRow As Integer = e.RowIndex
        Dim iCol As Integer = e.ColumnIndex

        If iCol = 3 Or iCol = 11 Then
            Dim sQuantity As String = Me.TblSWOOrderDetailDataGridView.Rows(iRow).Cells(3).Value
            Dim sRetail As String = Me.TblSWOOrderDetailDataGridView.Rows(iRow).Cells(11).Value
            If IsNumeric(sQuantity) And IsNumeric(sRetail) Then
                Me.TblSWOOrderDetailDataGridView.Rows(iRow).Cells(12).Value = Format(CSng(sRetail) * CSng(sQuantity), "currency")
                ReCalculateTotals()
            End If
        End If

    End Sub

    Private Sub UpdateDetailTotals()

        Dim i As Integer
        For i = 0 To Me.TblSWOOrderDetailDataGridView.Rows.Count - 1
            Dim sQuantity As String = Me.TblSWOOrderDetailDataGridView.Rows(i).Cells(3).Value
            Dim sRetail As String = Me.TblSWOOrderDetailDataGridView.Rows(i).Cells(11).Value
            If IsNumeric(sQuantity) And IsNumeric(sRetail) Then
                Me.TblSWOOrderDetailDataGridView.Rows(i).Cells(12).Value = Format(CSng(sRetail) * CSng(sQuantity), "currency")

            End If
        Next
        If i > 0 Then
            ReCalculateTotals()
        End If


    End Sub

    Private Sub TblSWOOrderDetailDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblSWOOrderDetailDataGridView.CellValueChanged
        If e.ColumnIndex = 3 Or e.ColumnIndex = 11 Then
            UpdateDetailTotals()
        End If

    End Sub

    Private Sub TblSWOOrderDetailBindingSource_BindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles TblSWOOrderDetailBindingSource.BindingComplete
        UpdateDetailTotals()
    End Sub

    Private Sub frmSWOParts_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.SaveSWOParts()
    End Sub

    Private Sub frmSWO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateDetailTotals()
    End Sub

    Private Sub txtADD_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtADD.Leave
        ReCalculateTotals()
    End Sub

    Private Sub txtSalesTax_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalesTax.Leave
        ReCalculateTotals()
    End Sub

    Private Sub btnPrintPartsForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPartsForm.Click
        Me.SaveSWOParts()
        Dim img1 As Image
        img1 = Me.BuildSWOPartsImage
        Dim frmImg As New frmFullpage
        frmImg.PictureBox1.Image = img1
        frmImg.Show()
    End Sub

    Public Function BuildSWOPartsImage() As Image

        Dim img1 As Bitmap
        Dim iVertical As Integer = 0
        Dim iHorz As Integer = 0

        img1 = New Bitmap(1700, 2200)
        Dim e As Graphics
        e = Graphics.FromImage(img1)

        e.FillRectangle(Brushes.White, New Rectangle(0, 0, 1700, 2200))

        Dim iScale As Integer = 2
        Dim yScale As Integer = 100
        Dim xScale As Integer = 100

        With Me

            Dim fontMD As New Font("Arial", 22, FontStyle.Regular)
            Dim fontBG As New Font("Arial", 36, FontStyle.Bold)
            Dim fontSM As New Font("Arial", 16, FontStyle.Regular)
            Dim fontSMb As New Font("Arial", 16, FontStyle.Bold)
            Dim fontXSM As New Font("Arial", 12, FontStyle.Regular)

            e.FillRectangle(Brushes.White, New Rectangle(0, 0, 1700, 2200))

            e.DrawString("ORDER FORM", fontBG, Brushes.Black, 7 * xScale, 1 * yScale)

            e.DrawString("The Kitchen Showcase, Inc.", fontMD, Brushes.Black, 1 * xScale, 1 * yScale)
            e.DrawString("6528 S. Racine Circle", fontMD, Brushes.Black, 1 * xScale, 1.4 * yScale)
            e.DrawString("Centennial, CO. 80111", fontMD, Brushes.Black, 1 * xScale, 1.8 * yScale)
            e.DrawString("(303) 799-9200", fontMD, Brushes.Black, 1 * xScale, 2.2 * yScale)
            e.DrawString("FAX (303) 799-1234", fontMD, Brushes.Black, 1 * xScale, 2.6 * yScale)
            e.DrawString("www.thekitchenshowcase.com", fontMD, Brushes.Black, 1 * xScale, 3 * yScale)

            e.DrawLine(Pens.Black, CInt(6.8 * xScale), CInt(1.98 * yScale), CInt(15.5 * xScale), CInt(1.98 * yScale))
            e.DrawLine(Pens.Black, CInt(6.8 * xScale), CInt(2.48 * yScale), CInt(15.5 * xScale), CInt(2.48 * yScale))
            e.DrawLine(Pens.Black, CInt(6.8 * xScale), CInt(3.08 * yScale), CInt(15.5 * xScale), CInt(3.08 * yScale))
            e.DrawLine(Pens.Black, CInt(6.8 * xScale), CInt(3.58 * yScale), CInt(15.5 * xScale), CInt(3.58 * yScale))

            e.DrawLine(Pens.Black, CInt(6.8 * xScale), CInt(1.98 * yScale), CInt(6.8 * xScale), CInt(3.58 * yScale))
            e.DrawLine(Pens.Black, CInt(8.98 * xScale), CInt(2.48 * yScale), CInt(8.98 * xScale), CInt(3.58 * yScale))
            e.DrawLine(Pens.Black, CInt(10.98 * xScale), CInt(1.98 * yScale), CInt(10.98 * xScale), CInt(3.58 * yScale))
            e.DrawLine(Pens.Black, CInt(13.98 * xScale), CInt(2.48 * yScale), CInt(13.98 * xScale), CInt(3.58 * yScale))
            e.DrawLine(Pens.Black, CInt(15.5 * xScale), CInt(1.98 * yScale), CInt(15.5 * xScale), CInt(3.58 * yScale))

            e.DrawString("Manufacturer", fontXSM, Brushes.Black, 7 * xScale, 2 * yScale)
            e.DrawString(.cmbManufacture.Text.Trim, fontMD, Brushes.Black, 7.15 * xScale, 2.15 * yScale)

            e.DrawString("PO#", fontXSM, Brushes.Black, 11 * xScale, 2 * yScale)
            e.DrawString(.txtPO.Text.Trim, fontMD, Brushes.Black, 11.15 * xScale, 2.15 * yScale)

            e.DrawString("Salesperson", fontXSM, Brushes.Black, 7 * xScale, 2.5 * yScale)
            e.DrawString(.cmbSales.Text.Trim, fontMD, Brushes.Black, 7.15 * xScale, 2.65 * yScale)

            e.DrawString("Order Date", fontXSM, Brushes.Black, 9 * xScale, 2.5 * yScale)
            e.DrawString(.txtOrderDate.Text.Trim, fontMD, Brushes.Black, 9.15 * xScale, 2.65 * yScale)

            e.DrawString("Ship Week Of", fontXSM, Brushes.Black, 11 * xScale, 2.5 * yScale)
            e.DrawString(.txtShipWeek.Text.Trim, fontMD, Brushes.Black, 11.15 * xScale, 2.65 * yScale)

            e.DrawString("Ship Via", fontXSM, Brushes.Black, 14 * xScale, 2.5 * yScale)
            e.DrawString(.txtShipVia.Text.Trim, fontMD, Brushes.Black, 14.15 * xScale, 2.65 * yScale)

            e.DrawString("Sales Tax", fontXSM, Brushes.Black, 7 * xScale, 3.1 * yScale)
            e.DrawString(.txtSalesTax.Text.Trim, fontMD, Brushes.Black, 7.15 * xScale, 3.25 * yScale)

            e.DrawString("Terms for TKSI Customers", fontXSM, Brushes.Black, 9 * xScale, 3.1 * yScale)
            e.DrawString(.txtTerms.Text.Trim, fontMD, Brushes.Black, 9.15 * xScale, 3.25 * yScale)

            e.DrawString("Layouts Via", fontXSM, Brushes.Black, 14 * xScale, 3.1 * yScale)

            e.DrawString("BILL TO:", fontSMb, Brushes.Black, 1 * xScale, 4.2 * yScale)
            e.DrawString(.txtBillTo.Text.Trim, fontMD, Brushes.Black, 2.5 * xScale, 4.2 * yScale)

            e.DrawString("CONTACT:", fontSM, Brushes.Black, 1 * xScale, 5.2 * yScale)
            e.DrawString(Me.txtJobContact.Text.Trim, fontMD, Brushes.Black, 2.5 * xScale, 5.2 * yScale)

            e.DrawString("SHIP TO:", fontSMb, Brushes.Black, 9 * xScale, 4.2 * yScale)
            e.DrawString(.txtShipto.Text.Trim, fontMD, Brushes.Black, 10.5 * xScale, 4.2 * yScale)

            e.DrawString("Door Style - Wall", fontXSM, Brushes.Black, 1 * xScale, 6 * yScale)
            e.DrawString(.txtDoorStyleWall.Text.Trim, fontMD, Brushes.Black, 1.15 * xScale, 6.15 * yScale)

            e.DrawString("Wood", fontXSM, Brushes.Black, 8 * xScale, 6 * yScale)
            e.DrawString(.txtWood.Text, fontMD, Brushes.Black, 7.8 * xScale, 6.15 * yScale)

            e.DrawString("Finish", fontXSM, Brushes.Black, 11.5 * xScale, 6 * yScale)
            e.DrawString(.txtFinishMod.Text.Trim, fontMD, Brushes.Black, 10.8 * xScale, 6.15 * yScale)

            e.DrawString("Laminate", fontXSM, Brushes.Black, 14 * xScale, 6 * yScale)
            e.DrawString(.txtLaminate.Text.Trim, fontMD, Brushes.Black, 14.15 * xScale, 6.15 * yScale)

            e.DrawString("Door Style - Base", fontXSM, Brushes.Black, 1 * xScale, 6.6 * yScale)
            e.DrawString(.txtDoorStyleBase.Text, fontMD, Brushes.Black, 1.15 * xScale, 6.75 * yScale)

            e.DrawString("Hinge", fontXSM, Brushes.Black, 8 * xScale, 6.6 * yScale)
            e.DrawString(.txtHinge.Text.Trim, fontMD, Brushes.Black, 7.8 * xScale, 6.75 * yScale)

            e.DrawString("Completion Date", fontXSM, Brushes.Black, 1 * xScale, 7.2 * yScale)
            e.DrawString(.txtCompletionDate.Text.Trim, fontMD, Brushes.Black, 1 * xScale, 7.35 * yScale)

            e.DrawString("Description", fontXSM, Brushes.Black, 3 * xScale, 7.2 * yScale)
            e.DrawString(.txtDescription.Text.Trim, fontMD, Brushes.Black, 3.15 * xScale, 7.35 * yScale)

            e.DrawString("SDA#", fontXSM, Brushes.Black, 8 * xScale, 7.2 * yScale)
            e.DrawString(.txtSDA.Text.Trim, fontMD, Brushes.Black, 7.8 * xScale, 7.35 * yScale)

            e.DrawString("Maple Melamine Int w/Wood Dovetail Soft Close Dwrs", fontXSM, Brushes.Black, 10.3 * xScale, 6.6 * yScale)
            e.DrawString("White Melamine Interior", fontXSM, Brushes.Black, 10.3 * xScale, 6.9 * yScale)
            e.DrawString("Maple Melamine Interior w/ Melamine Drawers", fontXSM, Brushes.Black, 10.3 * xScale, 7.2 * yScale)
            e.DrawString("Wood Dovetail Soft Close Drawersmine Interior", fontXSM, Brushes.Black, 10.3 * xScale, 7.5 * yScale)

            e.DrawLine(Pens.Black, CInt(0.98 * xScale), CInt(5.98 * yScale), CInt(15.5 * xScale), CInt(5.98 * yScale))
            e.DrawLine(Pens.Black, CInt(0.98 * xScale), CInt(6.58 * yScale), CInt(15.5 * xScale), CInt(6.58 * yScale))
            e.DrawLine(Pens.Black, CInt(0.98 * xScale), CInt(7.18 * yScale), CInt(15.5 * xScale), CInt(7.18 * yScale))
            e.DrawLine(Pens.Black, CInt(0.98 * xScale), CInt(7.7 * yScale), CInt(15.5 * xScale), CInt(7.7 * yScale))

            e.DrawLine(Pens.Black, CInt(0.98 * xScale), CInt(5.98 * yScale), CInt(0.98 * xScale), CInt(7.7 * yScale))
            e.DrawLine(Pens.Black, CInt(7 * xScale), CInt(5.98 * yScale), CInt(7 * xScale), CInt(7.7 * yScale))

            e.DrawLine(Pens.Black, CInt(9.5 * xScale), CInt(5.98 * yScale), CInt(9.5 * xScale), CInt(7.7 * yScale))
            e.DrawLine(Pens.Black, CInt(10.28 * xScale), CInt(6.58 * yScale), CInt(10.28 * xScale), CInt(7.7 * yScale))

            'little horizontal lines near maple
            e.DrawLine(Pens.Black, CInt(9.5 * xScale), CInt(6.85 * yScale), CInt(10.28 * xScale), CInt(6.85 * yScale))
            e.DrawLine(Pens.Black, CInt(9.5 * xScale), CInt(7.43 * yScale), CInt(10.28 * xScale), CInt(7.43 * yScale))
            e.DrawLine(Pens.Black, CInt(13.5 * xScale), CInt(5.98 * yScale), CInt(13.5 * xScale), CInt(6.58 * yScale))
            e.DrawLine(Pens.Black, CInt(15.5 * xScale), CInt(5.98 * yScale), CInt(15.5 * xScale), CInt(7.7 * yScale))

            e.DrawLine(Pens.Black, CInt(0.98 * xScale), CInt(8.48 * yScale), CInt(15.5 * xScale), CInt(8.48 * yScale))

            e.DrawLine(Pens.Black, CInt(0.98 * xScale), CInt(8.48 * yScale), CInt(0.98 * xScale), CInt(20.4 * yScale))
            e.DrawLine(Pens.Black, CInt(15.5 * xScale), CInt(8.48 * yScale), CInt(15.5 * xScale), CInt(20.4 * yScale))

            e.DrawLine(Pens.Black, CInt(1.98 * xScale), CInt(8.48 * yScale), CInt(1.98 * xScale), CInt(20.4 * yScale))
            e.DrawLine(Pens.Black, CInt(2.98 * xScale), CInt(8.48 * yScale), CInt(2.98 * xScale), CInt(20.4 * yScale))

            e.DrawLine(Pens.Black, CInt(6.5 * xScale), CInt(8.48 * yScale), CInt(6.5 * xScale), CInt(20.4 * yScale))
            e.DrawLine(Pens.Black, CInt(7.3 * xScale), CInt(8.9 * yScale), CInt(7.3 * xScale), CInt(20.4 * yScale))
            e.DrawLine(Pens.Black, CInt(8.1 * xScale), CInt(8.48 * yScale), CInt(8.1 * xScale), CInt(20.4 * yScale))
            e.DrawLine(Pens.Black, CInt(8.9 * xScale), CInt(8.9 * yScale), CInt(8.9 * xScale), CInt(20.4 * yScale))
            e.DrawLine(Pens.Black, CInt(9.7 * xScale), CInt(8.48 * yScale), CInt(9.7 * xScale), CInt(20.4 * yScale))

            e.DrawLine(Pens.Black, CInt(13.98 * xScale), CInt(8.48 * yScale), CInt(13.98 * xScale), CInt(20.4 * yScale))

            e.DrawString("Line #", fontSMb, Brushes.Black, 1 * xScale, 8.5 * yScale)
            e.DrawString("Qty", fontSMb, Brushes.Black, 2 * xScale, 8.5 * yScale)
            e.DrawString("Item / Product", fontSMb, Brushes.Black, 4 * xScale, 8.5 * yScale)
            e.DrawString("Hinge", fontSMb, Brushes.Black, 6.9 * xScale, 8.5 * yScale)
            e.DrawString("Finish", fontSMb, Brushes.Black, 8.3 * xScale, 8.5 * yScale)
            e.DrawString("End", fontSMb, Brushes.Black, 9.1 * xScale, 8.5 * yScale)

            e.DrawString("Remarks", fontSMb, Brushes.Black, 11 * xScale, 8.5 * yScale)
            e.DrawString("Price", fontSMb, Brushes.Black, 14 * xScale, 8.5 * yScale)

            Dim sngDetailLinesVertical As Decimal = 8.9
            Dim i As Integer = 0

            For i = 1 To 24
                e.DrawLine(Pens.Black, CInt(0.98 * xScale), CInt(sngDetailLinesVertical * yScale), CInt(15.5 * xScale), CInt(sngDetailLinesVertical * yScale))
                sngDetailLinesVertical += 0.5
            Next

            sngDetailLinesVertical = 8.5
            Dim dr As TKSIJOBSDataSet.tblSWOOrderDetailRow
            Dim sngSubTotal As Decimal = 0

            For Each dr In Me.TksijobsDataSet1.tblSWOOrderDetail

                If dr.Quantity > 0 Then
                    sngDetailLinesVertical += 0.5

                    e.DrawString(dr.LineNum, fontMD, Brushes.Black, 1 * xScale, sngDetailLinesVertical * yScale)
                    e.DrawString(dr.Quantity, fontMD, Brushes.Black, 2 * xScale, sngDetailLinesVertical * yScale)

                    e.DrawString(dr.ItemDesc, fontMD, Brushes.Black, 3 * xScale, sngDetailLinesVertical * yScale)

                    e.DrawString(dr.Hinge, fontMD, Brushes.Black, 6.8 * xScale, sngDetailLinesVertical * yScale)
                    e.DrawString(dr.Fin, fontMD, Brushes.Black, 8.6 * xScale, sngDetailLinesVertical * yScale)
                    e.DrawString(dr.End1, fontMD, Brushes.Black, 9.3 * xScale, sngDetailLinesVertical * yScale)

                    e.DrawString(dr.Remarks, fontMD, Brushes.Black, 10.5 * xScale, sngDetailLinesVertical * yScale)
                    e.DrawString(Format(dr.Retail * dr.Quantity, "currency"), fontMD, Brushes.Black, 14 * xScale, sngDetailLinesVertical * yScale)

                    sngSubTotal += (dr.Retail * dr.Quantity)
                End If

            Next

            Dim strListTotalTitle As String = "List Total"
            If IsNumeric(Me.txtUpcharge1.Text) Then
                If CSng(Me.txtUpcharge1.Text) > 0 Then
                    strListTotalTitle = "List Total + Upcharges"
                    sngSubTotal = sngSubTotal + (sngSubTotal * CSng(Me.txtUpcharge1.Text))
                End If
            End If
            If IsNumeric(Me.txtUpcharge2.Text) Then
                If CSng(Me.txtUpcharge2.Text) > 0 Then
                    strListTotalTitle = "List Total + Upcharges"
                    sngSubTotal = sngSubTotal + (sngSubTotal * CSng(Me.txtUpcharge2.Text))
                End If
            End If
            If IsNumeric(Me.txtUpcharge3.Text) Then
                If CSng(Me.txtUpcharge3.Text) > 0 Then
                    strListTotalTitle = "List Total + Upcharges"
                    sngSubTotal = sngSubTotal + (sngSubTotal * CSng(Me.txtUpcharge3.Text))
                End If
            End If

            e.DrawString(strListTotalTitle, fontSMb, Brushes.Black, 10 * xScale, 17.5 * yScale)
            e.DrawString(Format(sngSubTotal, "currency"), fontMD, Brushes.Black, 14 * xScale, 17.5 * yScale)

            e.DrawString("Sale Price", fontSMb, Brushes.Black, 10 * xScale, 18 * yScale)
            If IsNumeric(Me.txtRetailFactor.Text) Then
                e.DrawString(Format(sngSubTotal * CSng(Me.txtRetailFactor.Text), "currency"), fontMD, Brushes.Black, 14 * xScale, 18 * yScale)
            End If

            e.DrawString("Shipping", fontSMb, Brushes.Black, 10 * xScale, 18.5 * yScale)
            e.DrawString(.txtRetailShipping.Text.Trim, fontMD, Brushes.Black, 14 * xScale, 18.5 * yScale)

            If drOrder.retailADD > 0 Then
                e.DrawString("Add", fontSMb, Brushes.Black, 10 * xScale, 19 * yScale)
                e.DrawString(.txtRetailShipping.Text.Trim, fontMD, Brushes.Black, 14 * xScale, 19 * yScale)
            End If

            e.DrawString("Tax", fontSMb, Brushes.Black, 10 * xScale, 19.5 * yScale)
            e.DrawString(.txtTAX.Text, fontMD, Brushes.Black, 14 * xScale, 19.5 * yScale)

            e.DrawString("Total", fontSMb, Brushes.Black, 10 * xScale, 20 * yScale)
            e.DrawString(.txtRetailTotal.Text, fontMD, Brushes.Black, 14 * xScale, 20 * yScale)

        End With

        Return img1

    End Function

    Private Sub txtTerms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTerms.SelectedIndexChanged
        If Me.txtTerms.Text.Trim = "Warranty" Or Me.txtTerms.Text.Trim = "Jobcost" Then
            Me.txtSalesTax.Text = 0
            Me.ReCalculateTotals()
        End If
    End Sub

    Private Sub txtRetailFactor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetailFactor.TextChanged
        If IsNumeric(Me.txtRetailFactor.Text) Then
            ReCalculateTotals()
        End If
    End Sub

    Private Sub txtCostFactor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostFactor.TextChanged
        If IsNumeric(Me.txtCostFactor.Text) Then
            ReCalculateTotals()
        End If
    End Sub

    Private Sub txtCostShipping_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostShipping.TextChanged
        If IsNumeric(Me.txtCostShipping.Text) Then
            ReCalculateTotals()
        End If
    End Sub

    Private Sub txtSalesTax_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalesTax.TextChanged
        If IsNumeric(Me.txtSalesTax.Text) Then
            ReCalculateTotals()
        End If
    End Sub

    Private Sub txtADD_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtADD.TextChanged
        If IsNumeric(Me.txtADD.Text) Then
            ReCalculateTotals()
        End If
    End Sub

    Private Sub txtUpcharge1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUpcharge1.Leave
        If Me.txtUpcharge1.Text.Trim = "" Then
            Me.txtUpcharge1.Text = "0"
        Else
            If IsNumeric(Me.txtUpcharge1.Text) Then
                If CDec(Me.txtUpcharge1.Text) > 1 Then
                    Me.txtUpcharge1.Text = Decimal.Round(CDec(Me.txtUpcharge1.Text) / 100, 2)
                End If
            End If
        End If
    End Sub

    Private Sub txtUpcharge1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUpcharge1.TextChanged
        If IsNumeric(Me.txtUpcharge1.Text) Then
            ReCalculateTotals()
        End If
    End Sub

    Private Sub txtUpcharge2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUpcharge2.Leave
        If Me.txtUpcharge2.Text.Trim = "" Then
            Me.txtUpcharge2.Text = "0"
        Else
            If IsNumeric(Me.txtUpcharge2.Text) Then
                If CDec(Me.txtUpcharge2.Text) > 1 Then
                    Me.txtUpcharge2.Text = Decimal.Round(CDec(Me.txtUpcharge2.Text) / 100, 2)
                End If
            End If
        End If
    End Sub

    Private Sub txtUpcharge2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUpcharge2.TextChanged
        If IsNumeric(Me.txtUpcharge2.Text) Then
            ReCalculateTotals()
        End If
    End Sub

    Private Sub txtUpcharge3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUpcharge3.Leave
        If Me.txtUpcharge3.Text.Trim = "" Then
            Me.txtUpcharge3.Text = "0"
        Else
            If IsNumeric(Me.txtUpcharge3.Text) Then
                If CDec(Me.txtUpcharge3.Text) > 1 Then
                    Me.txtUpcharge3.Text = Decimal.Round(CDec(Me.txtUpcharge3.Text) / 100, 2)
                End If
            End If
        End If
    End Sub

    Private Sub txtUpcharge3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUpcharge3.TextChanged
        If IsNumeric(Me.txtUpcharge3.Text) Then
            ReCalculateTotals()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click, ToolStripMenuItem2.Click, ToolStripMenuItem3.Click, ToolStripMenuItem4.Click, ToolStripMenuItem5.Click, ToolStripMenuItem6.Click
        Me.lblUpcharge1.Text = sender.text
        Me.txtUpcharge1.Visible = True
        Me.txtUpcharge1.Focus()
        Me.txtUpcharge1.SelectAll()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click, ToolStripMenuItem8.Click, ToolStripMenuItem9.Click, ToolStripMenuItem10.Click, ToolStripMenuItem11.Click, ToolStripMenuItem12.Click
        Me.lblUpcharge2.Text = sender.text
        Me.txtUpcharge2.Visible = True
        Me.txtUpcharge2.Focus()
        Me.txtUpcharge2.SelectAll()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click, ToolStripMenuItem14.Click, ToolStripMenuItem15.Click, ToolStripMenuItem16.Click, ToolStripMenuItem17.Click, ToolStripMenuItem18.Click
        Me.lblUpcharge3.Text = sender.text
        Me.txtUpcharge3.Visible = True
        Me.txtUpcharge3.Focus()
        Me.txtUpcharge3.SelectAll()
    End Sub

End Class