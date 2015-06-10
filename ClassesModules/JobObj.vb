Imports System.Data

Public Class JobObj
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.sqlConn.ConnectionString = cnSQL
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
    Friend WithEvents sqlConn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOLineByNJobID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daJobTaxByNJOBID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daSOLineByNJOBID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daAddressByNID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daJobBYnAddressID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daCustomerByLID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOHeaderByNAddressID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daSOHeaderByAddressID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daJobByAddress As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daVendorByNAddressID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daJobByNID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daCustomerBySName As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daAddressRecent As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daJobRecent As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daAddressByName As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand32 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daSOLineByNAddressID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand35 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOLineByNADDRESSID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand36 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOlinesRecent As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOHeaderRecent As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daVendorALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daCustomerALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOLineDDELnull As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPODDELnull As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daAddressALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOHeaderByDateRequired As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOLinesByDateRequired As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPaymentALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daSOLineALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daPOLineALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand26 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daSOHeaderALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPaymentsDISTINCT As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand34 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daDrawsALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daEmployeeALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daJobALLSortCustName As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daJobALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daPOHeaderSBackorderYES As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOLinesSBackorderYES As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daTaxRegionAll As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand25 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daTaxJOINALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daTaxDistrictALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daInstallerALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand28 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand29 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daJobTaxALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daJobDSimply1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daSOHeaderDSimply As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daSOLineDSimply As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand30 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand31 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daDepositStartEnd As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand32 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daDepositDistinctDates As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand33 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daSOLineNotDeposited As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand34 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daSOLineOneDeposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daSOLineBySOID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daSOHeaderBySOID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daSOLineBYsSalesperson As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand37 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daSOHeaderBYsSalesperson As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand39 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOLineBYsSalesperson As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand40 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOHeaderBYsSalesperson As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand43 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daJobBYsSalesperson As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand41 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand35 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand36 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand37 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInstallerDateByStartEnd As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand38 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daJobBysJOBNO As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand26 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand27 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInstallerDatesALL As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daInstallerDatesConflictByDateStartDateEnd As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand41 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand40 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOHeaderByBackorderYES As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daJOBByBackorderYES As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOByNID As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand42 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daPOHeaderALL1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand10 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JobObj))
        Me.sqlConn = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daSOLineByNJOBID = New System.Data.SqlClient.SqlDataAdapter()
        Me.daPOHeaderALL1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.daPOLineByNJobID = New System.Data.SqlClient.SqlDataAdapter()
        Me.daJobTaxByNJOBID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.daVendorByNAddressID = New System.Data.SqlClient.SqlDataAdapter()
        Me.daAddressByNID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.daJobBYnAddressID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.daCustomerByLID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand19 = New System.Data.SqlClient.SqlCommand()
        Me.daPOHeaderByNAddressID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand42 = New System.Data.SqlClient.SqlCommand()
        Me.daEmployeeALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand20 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.daSOHeaderByAddressID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand19 = New System.Data.SqlClient.SqlCommand()
        Me.daJobByAddress = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daAddressRecent = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.daJobByNID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.daCustomerBySName = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand16 = New System.Data.SqlClient.SqlCommand()
        Me.daJobRecent = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand22 = New System.Data.SqlClient.SqlCommand()
        Me.daAddressByName = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand32 = New System.Data.SqlClient.SqlCommand()
        Me.daSOLineByNAddressID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand35 = New System.Data.SqlClient.SqlCommand()
        Me.daPOLineByNADDRESSID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand36 = New System.Data.SqlClient.SqlCommand()
        Me.daPOHeaderRecent = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.daPOlinesRecent = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.daVendorALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.daCustomerALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.daPOLineDDELnull = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.daPODDELnull = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand16 = New System.Data.SqlClient.SqlCommand()
        Me.daJobALLSortCustName = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand17 = New System.Data.SqlClient.SqlCommand()
        Me.daAddressALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand18 = New System.Data.SqlClient.SqlCommand()
        Me.daPOHeaderByDateRequired = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.daPOLinesByDateRequired = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.daPaymentALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.daSOLineALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand35 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.daPOLineALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand26 = New System.Data.SqlClient.SqlCommand()
        Me.daSOHeaderALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand36 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.daPaymentsDISTINCT = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand34 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand21 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.daDrawsALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.daJobALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand23 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.daPOHeaderSBackorderYES = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand17 = New System.Data.SqlClient.SqlCommand()
        Me.daPOLinesSBackorderYES = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand18 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand24 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daTaxRegionAll = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand25 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.daTaxJOINALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daTaxDistrictALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.daInstallerALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand26 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.daInstallerDatesALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand27 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand28 = New System.Data.SqlClient.SqlCommand()
        Me.daInstallerDatesConflictByDateStartDateEnd = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand29 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.daJobTaxALL = New System.Data.SqlClient.SqlDataAdapter()
        Me.daJobDSimply1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand30 = New System.Data.SqlClient.SqlCommand()
        Me.daSOHeaderDSimply = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand21 = New System.Data.SqlClient.SqlCommand()
        Me.daSOLineDSimply = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand22 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand31 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.daDepositStartEnd = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand32 = New System.Data.SqlClient.SqlCommand()
        Me.daDepositDistinctDates = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand33 = New System.Data.SqlClient.SqlCommand()
        Me.daSOLineNotDeposited = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand34 = New System.Data.SqlClient.SqlCommand()
        Me.daSOLineOneDeposit = New System.Data.SqlClient.SqlDataAdapter()
        Me.daSOLineBySOID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand40 = New System.Data.SqlClient.SqlCommand()
        Me.daSOHeaderBySOID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand41 = New System.Data.SqlClient.SqlCommand()
        Me.daSOLineBYsSalesperson = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand37 = New System.Data.SqlClient.SqlCommand()
        Me.daSOHeaderBYsSalesperson = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand39 = New System.Data.SqlClient.SqlCommand()
        Me.daPOLineBYsSalesperson = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand40 = New System.Data.SqlClient.SqlCommand()
        Me.daPOHeaderBYsSalesperson = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand43 = New System.Data.SqlClient.SqlCommand()
        Me.daJobBYsSalesperson = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand41 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand37 = New System.Data.SqlClient.SqlCommand()
        Me.daInstallerDateByStartEnd = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand38 = New System.Data.SqlClient.SqlCommand()
        Me.daJobBysJOBNO = New System.Data.SqlClient.SqlDataAdapter()
        Me.daPOHeaderByBackorderYES = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.daJOBByBackorderYES = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.daPOByNID = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.SuspendLayout()
        '
        'sqlConn
        '
        Me.sqlConn.ConnectionString = "workstation id=TZ250;packet size=4096;user id=tksidatauser;data source=DELL-SERVE" & _
    "R;persist security info=True;initial catalog=TKSIJOBS;password=tksi"
        Me.sqlConn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.sqlConn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NJOBID", System.Data.SqlDbType.Int, 4, "nJobID")})
        '
        'daSOLineByNJOBID
        '
        Me.daSOLineByNJOBID.SelectCommand = Me.SqlSelectCommand1
        Me.daSOLineByNJOBID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("bTaxable", "bTaxable"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sHidden", "sHidden"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID")})})
        '
        'daPOHeaderALL1
        '
        Me.daPOHeaderALL1.DeleteCommand = Me.SqlDeleteCommand10
        Me.daPOHeaderALL1.InsertCommand = Me.SqlInsertCommand10
        Me.daPOHeaderALL1.SelectCommand = Me.SqlSelectCommand4
        Me.daPOHeaderALL1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        Me.daPOHeaderALL1.UpdateCommand = Me.SqlUpdateCommand10
        '
        'SqlDeleteCommand10
        '
        Me.SqlDeleteCommand10.CommandText = resources.GetString("SqlDeleteCommand10.CommandText")
        Me.SqlDeleteCommand10.Connection = Me.sqlConn
        Me.SqlDeleteCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DDEL", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDEL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DFAXED", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DFAXED", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DREC", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DREC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SDELNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDELNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SRECNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SRECNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_bSimply", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bSimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCreateRecord", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCreateRecord", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dPODate", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dPODate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dRequired", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dRequired", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dSimply", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dSimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAccount", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAdd", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAdd", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nBoxes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nBoxes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCheckNo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCheckNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nInvNo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nInvNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nJobID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nPOSort", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nPOSort", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nRetailFreight", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nRetailFreight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nRetailSale", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nRetailSale", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nSaleAccount", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSaleAccount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTruck", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTruck", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nVendorID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nVendorID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nsalesadjust", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nsalesadjust", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sAdjustReason", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sAdjustReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sBackOrder", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBackOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sConf", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sConf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCurActNote", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCurActNote", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sEnteredBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sEnteredBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFOB", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFOB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFilter", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFilter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sItemDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sItemDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sItems", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sItems", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPONum", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPONum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPOType", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPOType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToCity", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToState", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToState", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToZip", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToZip", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipto3", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipto3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShiptoCounty", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShiptoCounty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sTerms", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sVia", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sVia", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand10
        '
        Me.SqlInsertCommand10.CommandText = resources.GetString("SqlInsertCommand10.CommandText")
        Me.SqlInsertCommand10.Connection = Me.sqlConn
        Me.SqlInsertCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nJobID", System.Data.SqlDbType.Int, 4, "nJobID"), New System.Data.SqlClient.SqlParameter("@dCreateRecord", System.Data.SqlDbType.DateTime, 4, "dCreateRecord"), New System.Data.SqlClient.SqlParameter("@nVendorID", System.Data.SqlDbType.Int, 4, "nVendorID"), New System.Data.SqlClient.SqlParameter("@sPONum", System.Data.SqlDbType.VarChar, 50, "sPONum"), New System.Data.SqlClient.SqlParameter("@sShipTo1", System.Data.SqlDbType.VarChar, 50, "sShipTo1"), New System.Data.SqlClient.SqlParameter("@sShipTo2", System.Data.SqlDbType.VarChar, 50, "sShipTo2"), New System.Data.SqlClient.SqlParameter("@sShipto3", System.Data.SqlDbType.VarChar, 50, "sShipto3"), New System.Data.SqlClient.SqlParameter("@sShipToCity", System.Data.SqlDbType.VarChar, 50, "sShipToCity"), New System.Data.SqlClient.SqlParameter("@sShipToState", System.Data.SqlDbType.VarChar, 50, "sShipToState"), New System.Data.SqlClient.SqlParameter("@sShipToZip", System.Data.SqlDbType.VarChar, 50, "sShipToZip"), New System.Data.SqlClient.SqlParameter("@sShiptoCounty", System.Data.SqlDbType.VarChar, 50, "sShiptoCounty"), New System.Data.SqlClient.SqlParameter("@nBoxes", System.Data.SqlDbType.Int, 4, "nBoxes"), New System.Data.SqlClient.SqlParameter("@dPODate", System.Data.SqlDbType.DateTime, 4, "dPODate"), New System.Data.SqlClient.SqlParameter("@sTerms", System.Data.SqlDbType.VarChar, 50, "sTerms"), New System.Data.SqlClient.SqlParameter("@dRequired", System.Data.SqlDbType.DateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@sEnteredBy", System.Data.SqlDbType.VarChar, 50, "sEnteredBy"), New System.Data.SqlClient.SqlParameter("@nTotal", System.Data.SqlDbType.Float, 8, "nTotal"), New System.Data.SqlClient.SqlParameter("@sVia", System.Data.SqlDbType.VarChar, 50, "sVia"), New System.Data.SqlClient.SqlParameter("@sFOB", System.Data.SqlDbType.VarChar, 50, "sFOB"), New System.Data.SqlClient.SqlParameter("@nRetailSale", System.Data.SqlDbType.Float, 8, "nRetailSale"), New System.Data.SqlClient.SqlParameter("@nSaleAccount", System.Data.SqlDbType.Int, 4, "nSaleAccount"), New System.Data.SqlClient.SqlParameter("@nRetailFreight", System.Data.SqlDbType.Float, 8, "nRetailFreight"), New System.Data.SqlClient.SqlParameter("@sConf", System.Data.SqlDbType.VarChar, 50, "sConf"), New System.Data.SqlClient.SqlParameter("@nAdd", System.Data.SqlDbType.Float, 8, "nAdd"), New System.Data.SqlClient.SqlParameter("@DREC", System.Data.SqlDbType.DateTime, 4, "DREC"), New System.Data.SqlClient.SqlParameter("@DDEL", System.Data.SqlDbType.DateTime, 4, "DDEL"), New System.Data.SqlClient.SqlParameter("@SRECNOTES", System.Data.SqlDbType.VarChar, 255, "SRECNOTES"), New System.Data.SqlClient.SqlParameter("@SDELNOTES", System.Data.SqlDbType.VarChar, 255, "SDELNOTES"), New System.Data.SqlClient.SqlParameter("@DFAXED", System.Data.SqlDbType.DateTime, 4, "DFAXED"), New System.Data.SqlClient.SqlParameter("@nAccount", System.Data.SqlDbType.Int, 4, "nAccount"), New System.Data.SqlClient.SqlParameter("@nInvNo", System.Data.SqlDbType.VarChar, 50, "nInvNo"), New System.Data.SqlClient.SqlParameter("@nCheckNo", System.Data.SqlDbType.Int, 4, "nCheckNo"), New System.Data.SqlClient.SqlParameter("@dSimply", System.Data.SqlDbType.DateTime, 4, "dSimply"), New System.Data.SqlClient.SqlParameter("@bSimply", System.Data.SqlDbType.Bit, 1, "bSimply"), New System.Data.SqlClient.SqlParameter("@nTruck", System.Data.SqlDbType.Int, 4, "nTruck"), New System.Data.SqlClient.SqlParameter("@sFilter", System.Data.SqlDbType.VarChar, 50, "sFilter"), New System.Data.SqlClient.SqlParameter("@sBackOrder", System.Data.SqlDbType.VarChar, 50, "sBackOrder"), New System.Data.SqlClient.SqlParameter("@sItems", System.Data.SqlDbType.VarChar, 50, "sItems"), New System.Data.SqlClient.SqlParameter("@sItemDesc", System.Data.SqlDbType.VarChar, 50, "sItemDesc"), New System.Data.SqlClient.SqlParameter("@sPOType", System.Data.SqlDbType.VarChar, 50, "sPOType"), New System.Data.SqlClient.SqlParameter("@nsalesadjust", System.Data.SqlDbType.Money, 8, "nsalesadjust"), New System.Data.SqlClient.SqlParameter("@sAdjustReason", System.Data.SqlDbType.VarChar, 255, "sAdjustReason"), New System.Data.SqlClient.SqlParameter("@sCurActNote", System.Data.SqlDbType.VarChar, 255, "sCurActNote"), New System.Data.SqlClient.SqlParameter("@nPOSort", System.Data.SqlDbType.Int, 4, "nPOSort")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
        Me.SqlSelectCommand4.Connection = Me.sqlConn
        '
        'SqlUpdateCommand10
        '
        Me.SqlUpdateCommand10.CommandText = resources.GetString("SqlUpdateCommand10.CommandText")
        Me.SqlUpdateCommand10.Connection = Me.sqlConn
        Me.SqlUpdateCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nJobID", System.Data.SqlDbType.Int, 4, "nJobID"), New System.Data.SqlClient.SqlParameter("@dCreateRecord", System.Data.SqlDbType.DateTime, 4, "dCreateRecord"), New System.Data.SqlClient.SqlParameter("@nVendorID", System.Data.SqlDbType.Int, 4, "nVendorID"), New System.Data.SqlClient.SqlParameter("@sPONum", System.Data.SqlDbType.VarChar, 50, "sPONum"), New System.Data.SqlClient.SqlParameter("@sShipTo1", System.Data.SqlDbType.VarChar, 50, "sShipTo1"), New System.Data.SqlClient.SqlParameter("@sShipTo2", System.Data.SqlDbType.VarChar, 50, "sShipTo2"), New System.Data.SqlClient.SqlParameter("@sShipto3", System.Data.SqlDbType.VarChar, 50, "sShipto3"), New System.Data.SqlClient.SqlParameter("@sShipToCity", System.Data.SqlDbType.VarChar, 50, "sShipToCity"), New System.Data.SqlClient.SqlParameter("@sShipToState", System.Data.SqlDbType.VarChar, 50, "sShipToState"), New System.Data.SqlClient.SqlParameter("@sShipToZip", System.Data.SqlDbType.VarChar, 50, "sShipToZip"), New System.Data.SqlClient.SqlParameter("@sShiptoCounty", System.Data.SqlDbType.VarChar, 50, "sShiptoCounty"), New System.Data.SqlClient.SqlParameter("@nBoxes", System.Data.SqlDbType.Int, 4, "nBoxes"), New System.Data.SqlClient.SqlParameter("@dPODate", System.Data.SqlDbType.DateTime, 4, "dPODate"), New System.Data.SqlClient.SqlParameter("@sTerms", System.Data.SqlDbType.VarChar, 50, "sTerms"), New System.Data.SqlClient.SqlParameter("@dRequired", System.Data.SqlDbType.DateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@sEnteredBy", System.Data.SqlDbType.VarChar, 50, "sEnteredBy"), New System.Data.SqlClient.SqlParameter("@nTotal", System.Data.SqlDbType.Float, 8, "nTotal"), New System.Data.SqlClient.SqlParameter("@sVia", System.Data.SqlDbType.VarChar, 50, "sVia"), New System.Data.SqlClient.SqlParameter("@sFOB", System.Data.SqlDbType.VarChar, 50, "sFOB"), New System.Data.SqlClient.SqlParameter("@nRetailSale", System.Data.SqlDbType.Float, 8, "nRetailSale"), New System.Data.SqlClient.SqlParameter("@nSaleAccount", System.Data.SqlDbType.Int, 4, "nSaleAccount"), New System.Data.SqlClient.SqlParameter("@nRetailFreight", System.Data.SqlDbType.Float, 8, "nRetailFreight"), New System.Data.SqlClient.SqlParameter("@sConf", System.Data.SqlDbType.VarChar, 50, "sConf"), New System.Data.SqlClient.SqlParameter("@nAdd", System.Data.SqlDbType.Float, 8, "nAdd"), New System.Data.SqlClient.SqlParameter("@DREC", System.Data.SqlDbType.DateTime, 4, "DREC"), New System.Data.SqlClient.SqlParameter("@DDEL", System.Data.SqlDbType.DateTime, 4, "DDEL"), New System.Data.SqlClient.SqlParameter("@SRECNOTES", System.Data.SqlDbType.VarChar, 255, "SRECNOTES"), New System.Data.SqlClient.SqlParameter("@SDELNOTES", System.Data.SqlDbType.VarChar, 255, "SDELNOTES"), New System.Data.SqlClient.SqlParameter("@DFAXED", System.Data.SqlDbType.DateTime, 4, "DFAXED"), New System.Data.SqlClient.SqlParameter("@nAccount", System.Data.SqlDbType.Int, 4, "nAccount"), New System.Data.SqlClient.SqlParameter("@nInvNo", System.Data.SqlDbType.VarChar, 50, "nInvNo"), New System.Data.SqlClient.SqlParameter("@nCheckNo", System.Data.SqlDbType.Int, 4, "nCheckNo"), New System.Data.SqlClient.SqlParameter("@dSimply", System.Data.SqlDbType.DateTime, 4, "dSimply"), New System.Data.SqlClient.SqlParameter("@bSimply", System.Data.SqlDbType.Bit, 1, "bSimply"), New System.Data.SqlClient.SqlParameter("@nTruck", System.Data.SqlDbType.Int, 4, "nTruck"), New System.Data.SqlClient.SqlParameter("@sFilter", System.Data.SqlDbType.VarChar, 50, "sFilter"), New System.Data.SqlClient.SqlParameter("@sBackOrder", System.Data.SqlDbType.VarChar, 50, "sBackOrder"), New System.Data.SqlClient.SqlParameter("@sItems", System.Data.SqlDbType.VarChar, 50, "sItems"), New System.Data.SqlClient.SqlParameter("@sItemDesc", System.Data.SqlDbType.VarChar, 50, "sItemDesc"), New System.Data.SqlClient.SqlParameter("@sPOType", System.Data.SqlDbType.VarChar, 50, "sPOType"), New System.Data.SqlClient.SqlParameter("@nsalesadjust", System.Data.SqlDbType.Money, 8, "nsalesadjust"), New System.Data.SqlClient.SqlParameter("@sAdjustReason", System.Data.SqlDbType.VarChar, 255, "sAdjustReason"), New System.Data.SqlClient.SqlParameter("@sCurActNote", System.Data.SqlDbType.VarChar, 255, "sCurActNote"), New System.Data.SqlClient.SqlParameter("@nPOSort", System.Data.SqlDbType.Int, 4, "nPOSort"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DDEL", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDEL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DFAXED", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DFAXED", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DREC", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DREC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SDELNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDELNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SRECNOTES", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SRECNOTES", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_bSimply", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bSimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCreateRecord", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCreateRecord", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dPODate", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dPODate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dRequired", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dRequired", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dSimply", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dSimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAccount", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAdd", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAdd", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nBoxes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nBoxes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCheckNo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCheckNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nInvNo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nInvNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nJobID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nPOSort", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nPOSort", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nRetailFreight", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nRetailFreight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nRetailSale", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nRetailSale", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nSaleAccount", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSaleAccount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTruck", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTruck", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nVendorID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nVendorID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nsalesadjust", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nsalesadjust", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sAdjustReason", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sAdjustReason", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sBackOrder", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBackOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sConf", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sConf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCurActNote", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCurActNote", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sEnteredBy", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sEnteredBy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFOB", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFOB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFilter", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFilter", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sItemDesc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sItemDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sItems", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sItems", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPONum", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPONum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPOType", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPOType", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToCity", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToState", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToState", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToZip", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToZip", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipto3", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipto3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShiptoCounty", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShiptoCounty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sTerms", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sVia", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        Me.SqlSelectCommand3.Connection = Me.sqlConn
        Me.SqlSelectCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nJobID", System.Data.SqlDbType.Int, 4, "nJobID")})
        '
        'daPOLineByNJobID
        '
        Me.daPOLineByNJobID.SelectCommand = Me.SqlSelectCommand3
        Me.daPOLineByNJobID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nPOID", "nPOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("nCost", "nCost"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("sReceived", "sReceived")})})
        '
        'daJobTaxByNJOBID
        '
        Me.daJobTaxByNJOBID.SelectCommand = Me.SqlSelectCommand5
        Me.daJobTaxByNJOBID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTax", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("TaxName", "TaxName"), New System.Data.Common.DataColumnMapping("TaxPercent", "TaxPercent"), New System.Data.Common.DataColumnMapping("TaxCode", "TaxCode")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT ID, nJobID, TaxName, TaxPercent, TaxCode FROM tblJobTax WHERE (nJobID = @N" & _
    "JOBID)"
        Me.SqlSelectCommand5.Connection = Me.sqlConn
        Me.SqlSelectCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NJOBID", System.Data.SqlDbType.Int, 4, "nJobID")})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = resources.GetString("SqlSelectCommand6.CommandText")
        Me.SqlSelectCommand6.Connection = Me.sqlConn
        Me.SqlSelectCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nAddressID", System.Data.SqlDbType.Int, 4, "nAddressID")})
        '
        'daVendorByNAddressID
        '
        Me.daVendorByNAddressID.SelectCommand = Me.SqlSelectCommand6
        Me.daVendorByNAddressID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tVendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lid", "lid"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax")})})
        '
        'daAddressByNID
        '
        Me.daAddressByNID.SelectCommand = Me.SqlCommand8
        Me.daAddressByNID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tAddress", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sAddress1", "sAddress1"), New System.Data.Common.DataColumnMapping("sAddress2", "sAddress2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sState", "sState"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("sZip", "sZip"), New System.Data.Common.DataColumnMapping("sLocCode", "sLocCode")})})
        '
        'SqlCommand8
        '
        Me.SqlCommand8.CommandText = "SELECT nID, sAddress1, sAddress2, sCity, sState, sCounty, sZip, sLocCode FROM tAd" & _
    "dress WHERE (nID = @nid)"
        Me.SqlCommand8.Connection = Me.sqlConn
        Me.SqlCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nid", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'daJobBYnAddressID
        '
        Me.daJobBYnAddressID.SelectCommand = Me.SqlSelectCommand10
        Me.daJobBYnAddressID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = resources.GetString("SqlSelectCommand10.CommandText")
        Me.SqlSelectCommand10.Connection = Me.sqlConn
        Me.SqlSelectCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nAddressID", System.Data.SqlDbType.Int, 4, "nAddressID")})
        '
        'daCustomerByLID
        '
        Me.daCustomerByLID.SelectCommand = Me.SqlCommand19
        Me.daCustomerByLID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tCustomr", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lID", "lID"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD")})})
        '
        'SqlCommand19
        '
        Me.SqlCommand19.CommandText = "SELECT lID, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPostalZip, s" & _
    "Phone1, sPhone2, sFax, dCrLimit, dAmtYTD FROM tCustomr WHERE (lID = @LID)"
        Me.SqlCommand19.Connection = Me.sqlConn
        Me.SqlCommand19.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@LID", System.Data.SqlDbType.Int, 4, "lID")})
        '
        'daPOHeaderByNAddressID
        '
        Me.daPOHeaderByNAddressID.SelectCommand = Me.SqlSelectCommand42
        Me.daPOHeaderByNAddressID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlSelectCommand42
        '
        Me.SqlSelectCommand42.CommandText = resources.GetString("SqlSelectCommand42.CommandText")
        Me.SqlSelectCommand42.Connection = Me.sqlConn
        Me.SqlSelectCommand42.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nAddressID", System.Data.SqlDbType.Int, 4, "nAddressID")})
        '
        'daEmployeeALL
        '
        Me.daEmployeeALL.DeleteCommand = Me.SqlDeleteCommand12
        Me.daEmployeeALL.InsertCommand = Me.SqlInsertCommand12
        Me.daEmployeeALL.SelectCommand = Me.SqlSelectCommand20
        Me.daEmployeeALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tEmployee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("CityStateZip", "CityStateZip"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("SS", "SS"), New System.Data.Common.DataColumnMapping("Claims", "Claims"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("Insurance", "Insurance"), New System.Data.Common.DataColumnMapping("nickname", "nickname"), New System.Data.Common.DataColumnMapping("sequence", "sequence"), New System.Data.Common.DataColumnMapping("archive", "archive"), New System.Data.Common.DataColumnMapping("email", "email")})})
        Me.daEmployeeALL.UpdateCommand = Me.SqlUpdateCommand12
        '
        'SqlDeleteCommand12
        '
        Me.SqlDeleteCommand12.CommandText = "DELETE FROM tEmployee WHERE (sName = @Original_sName)"
        Me.SqlDeleteCommand12.Connection = Me.sqlConn
        Me.SqlDeleteCommand12.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_sName", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sName", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand12
        '
        Me.SqlInsertCommand12.CommandText = resources.GetString("SqlInsertCommand12.CommandText")
        Me.SqlInsertCommand12.Connection = Me.sqlConn
        Me.SqlInsertCommand12.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sName", System.Data.SqlDbType.VarChar, 50, "sName"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.VarChar, 50, "Address"), New System.Data.SqlClient.SqlParameter("@CityStateZip", System.Data.SqlDbType.VarChar, 50, "CityStateZip"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.VarChar, 50, "Phone"), New System.Data.SqlClient.SqlParameter("@SS", System.Data.SqlDbType.VarChar, 50, "SS"), New System.Data.SqlClient.SqlParameter("@Claims", System.Data.SqlDbType.VarChar, 50, "Claims"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.VarChar, 50, "Status"), New System.Data.SqlClient.SqlParameter("@Insurance", System.Data.SqlDbType.VarChar, 50, "Insurance"), New System.Data.SqlClient.SqlParameter("@nickname", System.Data.SqlDbType.VarChar, 50, "nickname"), New System.Data.SqlClient.SqlParameter("@sequence", System.Data.SqlDbType.Int, 4, "sequence"), New System.Data.SqlClient.SqlParameter("@archive", System.Data.SqlDbType.Bit, 1, "archive"), New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50, "email")})
        '
        'SqlSelectCommand20
        '
        Me.SqlSelectCommand20.CommandText = "SELECT sName, Address, CityStateZip, Phone, SS, Claims, Status, Insurance, nickna" & _
    "me, sequence, archive, email FROM tEmployee ORDER BY sequence"
        Me.SqlSelectCommand20.Connection = Me.sqlConn
        '
        'SqlUpdateCommand12
        '
        Me.SqlUpdateCommand12.CommandText = resources.GetString("SqlUpdateCommand12.CommandText")
        Me.SqlUpdateCommand12.Connection = Me.sqlConn
        Me.SqlUpdateCommand12.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sName", System.Data.SqlDbType.VarChar, 50, "sName"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.VarChar, 50, "Address"), New System.Data.SqlClient.SqlParameter("@CityStateZip", System.Data.SqlDbType.VarChar, 50, "CityStateZip"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.VarChar, 50, "Phone"), New System.Data.SqlClient.SqlParameter("@SS", System.Data.SqlDbType.VarChar, 50, "SS"), New System.Data.SqlClient.SqlParameter("@Claims", System.Data.SqlDbType.VarChar, 50, "Claims"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.VarChar, 50, "Status"), New System.Data.SqlClient.SqlParameter("@Insurance", System.Data.SqlDbType.VarChar, 50, "Insurance"), New System.Data.SqlClient.SqlParameter("@nickname", System.Data.SqlDbType.VarChar, 50, "nickname"), New System.Data.SqlClient.SqlParameter("@sequence", System.Data.SqlDbType.Int, 4, "sequence"), New System.Data.SqlClient.SqlParameter("@archive", System.Data.SqlDbType.Bit, 1, "archive"), New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50, "email"), New System.Data.SqlClient.SqlParameter("@Original_sName", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sName", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daSOHeaderByAddressID
        '
        Me.daSOHeaderByAddressID.SelectCommand = Me.SqlSelectCommand19
        Me.daSOHeaderByAddressID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sSONum", "sSONum"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("dShipped", "dShipped"), New System.Data.Common.DataColumnMapping("sVIA", "sVIA"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShipToCounty", "sShipToCounty"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("dinvoice", "dinvoice"), New System.Data.Common.DataColumnMapping("dsimply", "dsimply"), New System.Data.Common.DataColumnMapping("dmailed", "dmailed"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sOurOrder", "sOurOrder"), New System.Data.Common.DataColumnMapping("sYourOrder", "sYourOrder"), New System.Data.Common.DataColumnMapping("nSimplySequence", "nSimplySequence")})})
        '
        'SqlSelectCommand19
        '
        Me.SqlSelectCommand19.CommandText = resources.GetString("SqlSelectCommand19.CommandText")
        Me.SqlSelectCommand19.Connection = Me.sqlConn
        Me.SqlSelectCommand19.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nAddressid", System.Data.SqlDbType.Int, 4, "nAddressID")})
        '
        'daJobByAddress
        '
        Me.daJobByAddress.SelectCommand = Me.SqlSelectCommand2
        Me.daJobByAddress.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.sqlConn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sAddress1", System.Data.SqlDbType.VarChar, 50, "sAddress1"), New System.Data.SqlClient.SqlParameter("@sLocCode", System.Data.SqlDbType.VarChar, 50, "sLocCode")})
        '
        'daAddressRecent
        '
        Me.daAddressRecent.SelectCommand = Me.SqlCommand4
        Me.daAddressRecent.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tAddress", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sAddress1", "sAddress1"), New System.Data.Common.DataColumnMapping("sAddress2", "sAddress2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sState", "sState"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("sZip", "sZip"), New System.Data.Common.DataColumnMapping("sLocCode", "sLocCode")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = resources.GetString("SqlCommand4.CommandText")
        Me.SqlCommand4.Connection = Me.sqlConn
        '
        'daJobByNID
        '
        Me.daJobByNID.SelectCommand = Me.SqlSelectCommand9
        Me.daJobByNID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = resources.GetString("SqlSelectCommand9.CommandText")
        Me.SqlSelectCommand9.Connection = Me.sqlConn
        Me.SqlSelectCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'daCustomerBySName
        '
        Me.daCustomerBySName.SelectCommand = Me.SqlCommand16
        Me.daCustomerBySName.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tCustomr", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lID", "lID"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD")})})
        '
        'SqlCommand16
        '
        Me.SqlCommand16.CommandText = "SELECT lID, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPostalZip, s" & _
    "Phone1, sPhone2, sFax, dCrLimit, dAmtYTD FROM tCustomr WHERE (sName LIKE @sName)" & _
    ""
        Me.SqlCommand16.Connection = Me.sqlConn
        Me.SqlCommand16.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sName", System.Data.SqlDbType.VarChar, 50, "sName")})
        '
        'daJobRecent
        '
        Me.daJobRecent.SelectCommand = Me.SqlSelectCommand22
        Me.daJobRecent.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        '
        'SqlSelectCommand22
        '
        Me.SqlSelectCommand22.CommandText = resources.GetString("SqlSelectCommand22.CommandText")
        Me.SqlSelectCommand22.Connection = Me.sqlConn
        '
        'daAddressByName
        '
        Me.daAddressByName.SelectCommand = Me.SqlCommand32
        Me.daAddressByName.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tAddress", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sAddress1", "sAddress1"), New System.Data.Common.DataColumnMapping("sAddress2", "sAddress2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sState", "sState"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("sZip", "sZip"), New System.Data.Common.DataColumnMapping("sLocCode", "sLocCode")})})
        '
        'SqlCommand32
        '
        Me.SqlCommand32.CommandText = "SELECT DISTINCT nID, sAddress1, sAddress2, sCity, sState, sCounty, sZip, sLocCode" & _
    " FROM tAddress WHERE (sAddress1 LIKE @sAddress1) OR (sLocCode LIKE @sLocCode) OR" & _
    "DER BY sAddress1"
        Me.SqlCommand32.Connection = Me.sqlConn
        Me.SqlCommand32.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sAddress1", System.Data.SqlDbType.VarChar, 50, "sAddress1"), New System.Data.SqlClient.SqlParameter("@sLocCode", System.Data.SqlDbType.VarChar, 50, "sLocCode")})
        '
        'daSOLineByNAddressID
        '
        Me.daSOLineByNAddressID.SelectCommand = Me.SqlCommand35
        Me.daSOLineByNAddressID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("bTaxable", "bTaxable"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sHidden", "sHidden"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID")})})
        '
        'SqlCommand35
        '
        Me.SqlCommand35.CommandText = resources.GetString("SqlCommand35.CommandText")
        Me.SqlCommand35.Connection = Me.sqlConn
        Me.SqlCommand35.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NADDRESSID", System.Data.SqlDbType.Int, 4, "nAddressID")})
        '
        'daPOLineByNADDRESSID
        '
        Me.daPOLineByNADDRESSID.SelectCommand = Me.SqlCommand36
        Me.daPOLineByNADDRESSID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nPOID", "nPOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("nCost", "nCost"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("sReceived", "sReceived")})})
        '
        'SqlCommand36
        '
        Me.SqlCommand36.CommandText = resources.GetString("SqlCommand36.CommandText")
        Me.SqlCommand36.Connection = Me.sqlConn
        Me.SqlCommand36.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NADDRESSID", System.Data.SqlDbType.Int, 4, "nAddressID")})
        '
        'daPOHeaderRecent
        '
        Me.daPOHeaderRecent.SelectCommand = Me.SqlSelectCommand11
        Me.daPOHeaderRecent.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = resources.GetString("SqlSelectCommand11.CommandText")
        Me.SqlSelectCommand11.Connection = Me.sqlConn
        '
        'daPOlinesRecent
        '
        Me.daPOlinesRecent.SelectCommand = Me.SqlSelectCommand12
        Me.daPOlinesRecent.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nPOID", "nPOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("nCost", "nCost"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("sReceived", "sReceived")})})
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = resources.GetString("SqlSelectCommand12.CommandText")
        Me.SqlSelectCommand12.Connection = Me.sqlConn
        '
        'daVendorALL
        '
        Me.daVendorALL.SelectCommand = Me.SqlSelectCommand13
        Me.daVendorALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tVendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lid", "lid"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax")})})
        '
        'SqlSelectCommand13
        '
        Me.SqlSelectCommand13.CommandText = "SELECT DISTINCT lid, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPos" & _
    "talZip, sPhone1, sPhone2, sFax FROM tVendor ORDER BY sName"
        Me.SqlSelectCommand13.Connection = Me.sqlConn
        '
        'daCustomerALL
        '
        Me.daCustomerALL.SelectCommand = Me.SqlSelectCommand14
        Me.daCustomerALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tCustomr", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("lID", "lID"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sStreet1", "sStreet1"), New System.Data.Common.DataColumnMapping("sStreet2", "sStreet2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sProvState", "sProvState"), New System.Data.Common.DataColumnMapping("sCountry", "sCountry"), New System.Data.Common.DataColumnMapping("sPostalZip", "sPostalZip"), New System.Data.Common.DataColumnMapping("sPhone1", "sPhone1"), New System.Data.Common.DataColumnMapping("sPhone2", "sPhone2"), New System.Data.Common.DataColumnMapping("sFax", "sFax"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD")})})
        '
        'SqlSelectCommand14
        '
        Me.SqlSelectCommand14.CommandText = "SELECT lID, sName, sStreet1, sStreet2, sCity, sProvState, sCountry, sPostalZip, s" & _
    "Phone1, sPhone2, sFax, dCrLimit, dAmtYTD FROM tCustomr"
        Me.SqlSelectCommand14.Connection = Me.sqlConn
        '
        'daPOLineDDELnull
        '
        Me.daPOLineDDELnull.SelectCommand = Me.SqlSelectCommand15
        Me.daPOLineDDELnull.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nPOID", "nPOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("nCost", "nCost"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("sReceived", "sReceived")})})
        '
        'SqlSelectCommand15
        '
        Me.SqlSelectCommand15.CommandText = resources.GetString("SqlSelectCommand15.CommandText")
        Me.SqlSelectCommand15.Connection = Me.sqlConn
        '
        'daPODDELnull
        '
        Me.daPODDELnull.SelectCommand = Me.SqlSelectCommand16
        Me.daPODDELnull.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlSelectCommand16
        '
        Me.SqlSelectCommand16.CommandText = resources.GetString("SqlSelectCommand16.CommandText")
        Me.SqlSelectCommand16.Connection = Me.sqlConn
        '
        'daJobALLSortCustName
        '
        Me.daJobALLSortCustName.SelectCommand = Me.SqlSelectCommand17
        Me.daJobALLSortCustName.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        '
        'SqlSelectCommand17
        '
        Me.SqlSelectCommand17.CommandText = resources.GetString("SqlSelectCommand17.CommandText")
        Me.SqlSelectCommand17.Connection = Me.sqlConn
        '
        'daAddressALL
        '
        Me.daAddressALL.SelectCommand = Me.SqlSelectCommand18
        Me.daAddressALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tAddress", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sAddress1", "sAddress1"), New System.Data.Common.DataColumnMapping("sAddress2", "sAddress2"), New System.Data.Common.DataColumnMapping("sCity", "sCity"), New System.Data.Common.DataColumnMapping("sState", "sState"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("sZip", "sZip"), New System.Data.Common.DataColumnMapping("sLocCode", "sLocCode")})})
        '
        'SqlSelectCommand18
        '
        Me.SqlSelectCommand18.CommandText = "SELECT DISTINCT nID, sAddress1, sAddress2, sCity, sState, sCounty, sZip, sLocCode" & _
    " FROM tAddress"
        Me.SqlSelectCommand18.Connection = Me.sqlConn
        '
        'daPOHeaderByDateRequired
        '
        Me.daPOHeaderByDateRequired.SelectCommand = Me.SqlCommand5
        Me.daPOHeaderByDateRequired.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = resources.GetString("SqlCommand5.CommandText")
        Me.SqlCommand5.Connection = Me.sqlConn
        Me.SqlCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@STARTDATE", System.Data.SqlDbType.DateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@ENDDATE", System.Data.SqlDbType.DateTime, 4, "dRequired")})
        '
        'daPOLinesByDateRequired
        '
        Me.daPOLinesByDateRequired.SelectCommand = Me.SqlCommand6
        Me.daPOLinesByDateRequired.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = resources.GetString("SqlCommand6.CommandText")
        Me.SqlCommand6.Connection = Me.sqlConn
        Me.SqlCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@STARTDATE", System.Data.SqlDbType.DateTime, 4, "dRequired"), New System.Data.SqlClient.SqlParameter("@ENDDATE", System.Data.SqlDbType.DateTime, 4, "dRequired")})
        '
        'daPaymentALL
        '
        Me.daPaymentALL.DeleteCommand = Me.SqlCommand1
        Me.daPaymentALL.InsertCommand = Me.SqlCommand2
        Me.daPaymentALL.SelectCommand = Me.SqlCommand3
        Me.daPaymentALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPayments", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("JOBID", "JOBID"), New System.Data.Common.DataColumnMapping("dDate", "dDate"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount")})})
        Me.daPaymentALL.UpdateCommand = Me.SqlCommand7
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "DELETE FROM tPayments WHERE (nID = @Original_nID) AND (JOBID = @Original_JOBID) A" & _
    "ND (dDate = @Original_dDate) AND (nAmount = @Original_nAmount)"
        Me.SqlCommand1.Connection = Me.sqlConn
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_JOBID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JOBID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dDate", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAmount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "INSERT INTO tPayments(JOBID, dDate, nAmount) VALUES (@JOBID, @dDate, @nAmount); S" & _
    "ELECT nID, JOBID, dDate, nAmount FROM tPayments WHERE (nID = @@IDENTITY)"
        Me.SqlCommand2.Connection = Me.sqlConn
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@JOBID", System.Data.SqlDbType.Int, 4, "JOBID"), New System.Data.SqlClient.SqlParameter("@dDate", System.Data.SqlDbType.DateTime, 4, "dDate"), New System.Data.SqlClient.SqlParameter("@nAmount", System.Data.SqlDbType.Money, 8, "nAmount")})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT nID, JOBID, dDate, nAmount FROM tPayments ORDER BY dDate"
        Me.SqlCommand3.Connection = Me.sqlConn
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = resources.GetString("SqlCommand7.CommandText")
        Me.SqlCommand7.Connection = Me.sqlConn
        Me.SqlCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@JOBID", System.Data.SqlDbType.Int, 4, "JOBID"), New System.Data.SqlClient.SqlParameter("@dDate", System.Data.SqlDbType.DateTime, 4, "dDate"), New System.Data.SqlClient.SqlParameter("@nAmount", System.Data.SqlDbType.Money, 8, "nAmount"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_JOBID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "JOBID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dDate", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAmount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAmount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'daSOLineALL
        '
        Me.daSOLineALL.DeleteCommand = Me.SqlDeleteCommand11
        Me.daSOLineALL.InsertCommand = Me.SqlInsertCommand11
        Me.daSOLineALL.SelectCommand = Me.SqlSelectCommand35
        Me.daSOLineALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("bTaxable", "bTaxable"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sHidden", "sHidden"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID")})})
        Me.daSOLineALL.UpdateCommand = Me.SqlUpdateCommand11
        '
        'SqlDeleteCommand11
        '
        Me.SqlDeleteCommand11.CommandText = "DELETE FROM dbo.tSOLine WHERE (nLineNumber = @Original_nLineNumber) AND (nSOID = " & _
    "@Original_nSOID)"
        Me.SqlDeleteCommand11.Connection = Me.sqlConn
        Me.SqlDeleteCommand11.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nLineNumber", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nSOID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand11
        '
        Me.SqlInsertCommand11.CommandText = resources.GetString("SqlInsertCommand11.CommandText")
        Me.SqlInsertCommand11.Connection = Me.sqlConn
        Me.SqlInsertCommand11.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nSOID", System.Data.SqlDbType.Int, 4, "nSOID"), New System.Data.SqlClient.SqlParameter("@nLineNumber", System.Data.SqlDbType.Int, 4, "nLineNumber"), New System.Data.SqlClient.SqlParameter("@sDesc", System.Data.SqlDbType.NVarChar, 50, "sDesc"), New System.Data.SqlClient.SqlParameter("@bTaxable", System.Data.SqlDbType.Bit, 1, "bTaxable"), New System.Data.SqlClient.SqlParameter("@sType", System.Data.SqlDbType.NVarChar, 50, "sType"), New System.Data.SqlClient.SqlParameter("@sHidden", System.Data.SqlDbType.Bit, 1, "sHidden"), New System.Data.SqlClient.SqlParameter("@nAmount", System.Data.SqlDbType.Float, 8, "nAmount"), New System.Data.SqlClient.SqlParameter("@nAccountID", System.Data.SqlDbType.Int, 4, "nAccountID")})
        '
        'SqlSelectCommand35
        '
        Me.SqlSelectCommand35.CommandText = "SELECT nSOID, nLineNumber, sDesc, bTaxable, sType, sHidden, nAmount, nAccountID F" & _
    "ROM dbo.tSOLine ORDER BY nSOID, nLineNumber"
        Me.SqlSelectCommand35.Connection = Me.sqlConn
        '
        'SqlUpdateCommand11
        '
        Me.SqlUpdateCommand11.CommandText = resources.GetString("SqlUpdateCommand11.CommandText")
        Me.SqlUpdateCommand11.Connection = Me.sqlConn
        Me.SqlUpdateCommand11.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nSOID", System.Data.SqlDbType.Int, 4, "nSOID"), New System.Data.SqlClient.SqlParameter("@nLineNumber", System.Data.SqlDbType.Int, 4, "nLineNumber"), New System.Data.SqlClient.SqlParameter("@sDesc", System.Data.SqlDbType.NVarChar, 50, "sDesc"), New System.Data.SqlClient.SqlParameter("@bTaxable", System.Data.SqlDbType.Bit, 1, "bTaxable"), New System.Data.SqlClient.SqlParameter("@sType", System.Data.SqlDbType.NVarChar, 50, "sType"), New System.Data.SqlClient.SqlParameter("@sHidden", System.Data.SqlDbType.Bit, 1, "sHidden"), New System.Data.SqlClient.SqlParameter("@nAmount", System.Data.SqlDbType.Float, 8, "nAmount"), New System.Data.SqlClient.SqlParameter("@nAccountID", System.Data.SqlDbType.Int, 4, "nAccountID"), New System.Data.SqlClient.SqlParameter("@Original_nLineNumber", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nSOID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daPOLineALL
        '
        Me.daPOLineALL.DeleteCommand = Me.SqlCommand13
        Me.daPOLineALL.InsertCommand = Me.SqlCommand14
        Me.daPOLineALL.SelectCommand = Me.SqlCommand15
        Me.daPOLineALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nPOID", "nPOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("nCost", "nCost"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("sReceived", "sReceived")})})
        Me.daPOLineALL.UpdateCommand = Me.SqlCommand26
        '
        'SqlCommand13
        '
        Me.SqlCommand13.CommandText = resources.GetString("SqlCommand13.CommandText")
        Me.SqlCommand13.Connection = Me.sqlConn
        Me.SqlCommand13.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nLineNumber", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nPOID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nPOID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAccountID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCost", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCost", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sDesc", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sReceived", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sReceived", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sType", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlCommand14
        '
        Me.SqlCommand14.CommandText = resources.GetString("SqlCommand14.CommandText")
        Me.SqlCommand14.Connection = Me.sqlConn
        Me.SqlCommand14.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nPOID", System.Data.SqlDbType.Int, 4, "nPOID"), New System.Data.SqlClient.SqlParameter("@nLineNumber", System.Data.SqlDbType.Int, 4, "nLineNumber"), New System.Data.SqlClient.SqlParameter("@sType", System.Data.SqlDbType.NVarChar, 255, "sType"), New System.Data.SqlClient.SqlParameter("@sDesc", System.Data.SqlDbType.NVarChar, 255, "sDesc"), New System.Data.SqlClient.SqlParameter("@nCost", System.Data.SqlDbType.Float, 8, "nCost"), New System.Data.SqlClient.SqlParameter("@nAccountID", System.Data.SqlDbType.Int, 4, "nAccountID"), New System.Data.SqlClient.SqlParameter("@sReceived", System.Data.SqlDbType.Bit, 1, "sReceived")})
        '
        'SqlCommand15
        '
        Me.SqlCommand15.CommandText = "SELECT nPOID, nLineNumber, sType, sDesc, nCost, nAccountID, sReceived FROM tPOLin" & _
    "e ORDER BY nPOID, nLineNumber"
        Me.SqlCommand15.Connection = Me.sqlConn
        '
        'SqlCommand26
        '
        Me.SqlCommand26.CommandText = resources.GetString("SqlCommand26.CommandText")
        Me.SqlCommand26.Connection = Me.sqlConn
        Me.SqlCommand26.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nPOID", System.Data.SqlDbType.Int, 4, "nPOID"), New System.Data.SqlClient.SqlParameter("@nLineNumber", System.Data.SqlDbType.Int, 4, "nLineNumber"), New System.Data.SqlClient.SqlParameter("@sType", System.Data.SqlDbType.NVarChar, 255, "sType"), New System.Data.SqlClient.SqlParameter("@sDesc", System.Data.SqlDbType.NVarChar, 255, "sDesc"), New System.Data.SqlClient.SqlParameter("@nCost", System.Data.SqlDbType.Float, 8, "nCost"), New System.Data.SqlClient.SqlParameter("@nAccountID", System.Data.SqlDbType.Int, 4, "nAccountID"), New System.Data.SqlClient.SqlParameter("@sReceived", System.Data.SqlDbType.Bit, 1, "sReceived"), New System.Data.SqlClient.SqlParameter("@Original_nLineNumber", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nPOID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nPOID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAccountID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAccountID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCost", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCost", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sDesc", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sReceived", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sReceived", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sType", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sType", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daSOHeaderALL
        '
        Me.daSOHeaderALL.DeleteCommand = Me.SqlDeleteCommand14
        Me.daSOHeaderALL.InsertCommand = Me.SqlInsertCommand14
        Me.daSOHeaderALL.SelectCommand = Me.SqlSelectCommand36
        Me.daSOHeaderALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sSONum", "sSONum"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("dShipped", "dShipped"), New System.Data.Common.DataColumnMapping("sVIA", "sVIA"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShipToCounty", "sShipToCounty"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("dinvoice", "dinvoice"), New System.Data.Common.DataColumnMapping("dsimply", "dsimply"), New System.Data.Common.DataColumnMapping("dmailed", "dmailed"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sOurOrder", "sOurOrder"), New System.Data.Common.DataColumnMapping("sYourOrder", "sYourOrder"), New System.Data.Common.DataColumnMapping("nSimplySequence", "nSimplySequence")})})
        Me.daSOHeaderALL.UpdateCommand = Me.SqlUpdateCommand14
        '
        'SqlDeleteCommand14
        '
        Me.SqlDeleteCommand14.CommandText = resources.GetString("SqlDeleteCommand14.CommandText")
        Me.SqlDeleteCommand14.Connection = Me.sqlConn
        Me.SqlDeleteCommand14.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dShipped", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dShipped", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dinvoice", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dinvoice", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dmailed", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dmailed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dsimply", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dsimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCustID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nJobID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nSimplySequence", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSimplySequence", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTaxRate", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTotal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFOB", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFOB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sName", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sOurOrder", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOurOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sSONum", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSONum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToCity", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToCounty", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCounty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToState", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToState", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToZip", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToZip", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sTerms", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sVIA", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sVIA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sYourOrder", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sYourOrder", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand14
        '
        Me.SqlInsertCommand14.CommandText = resources.GetString("SqlInsertCommand14.CommandText")
        Me.SqlInsertCommand14.Connection = Me.sqlConn
        Me.SqlInsertCommand14.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sSONum", System.Data.SqlDbType.VarChar, 50, "sSONum"), New System.Data.SqlClient.SqlParameter("@nCustID", System.Data.SqlDbType.Int, 4, "nCustID"), New System.Data.SqlClient.SqlParameter("@nJobID", System.Data.SqlDbType.Int, 4, "nJobID"), New System.Data.SqlClient.SqlParameter("@sName", System.Data.SqlDbType.VarChar, 50, "sName"), New System.Data.SqlClient.SqlParameter("@sFOB", System.Data.SqlDbType.VarChar, 50, "sFOB"), New System.Data.SqlClient.SqlParameter("@dShipped", System.Data.SqlDbType.DateTime, 4, "dShipped"), New System.Data.SqlClient.SqlParameter("@sVIA", System.Data.SqlDbType.VarChar, 50, "sVIA"), New System.Data.SqlClient.SqlParameter("@sShipTo1", System.Data.SqlDbType.VarChar, 50, "sShipTo1"), New System.Data.SqlClient.SqlParameter("@sShipTo2", System.Data.SqlDbType.VarChar, 50, "sShipTo2"), New System.Data.SqlClient.SqlParameter("@sShipToCity", System.Data.SqlDbType.VarChar, 50, "sShipToCity"), New System.Data.SqlClient.SqlParameter("@sShipToState", System.Data.SqlDbType.VarChar, 50, "sShipToState"), New System.Data.SqlClient.SqlParameter("@sShipToZip", System.Data.SqlDbType.VarChar, 50, "sShipToZip"), New System.Data.SqlClient.SqlParameter("@sShipToCounty", System.Data.SqlDbType.VarChar, 50, "sShipToCounty"), New System.Data.SqlClient.SqlParameter("@sTerms", System.Data.SqlDbType.VarChar, 50, "sTerms"), New System.Data.SqlClient.SqlParameter("@nTaxRate", System.Data.SqlDbType.Int, 4, "nTaxRate"), New System.Data.SqlClient.SqlParameter("@dinvoice", System.Data.SqlDbType.DateTime, 4, "dinvoice"), New System.Data.SqlClient.SqlParameter("@dsimply", System.Data.SqlDbType.DateTime, 4, "dsimply"), New System.Data.SqlClient.SqlParameter("@dmailed", System.Data.SqlDbType.DateTime, 4, "dmailed"), New System.Data.SqlClient.SqlParameter("@nTotal", System.Data.SqlDbType.Int, 4, "nTotal"), New System.Data.SqlClient.SqlParameter("@sOurOrder", System.Data.SqlDbType.VarChar, 50, "sOurOrder"), New System.Data.SqlClient.SqlParameter("@sYourOrder", System.Data.SqlDbType.VarChar, 50, "sYourOrder"), New System.Data.SqlClient.SqlParameter("@nSimplySequence", System.Data.SqlDbType.Int, 4, "nSimplySequence")})
        '
        'SqlSelectCommand36
        '
        Me.SqlSelectCommand36.CommandText = resources.GetString("SqlSelectCommand36.CommandText")
        Me.SqlSelectCommand36.Connection = Me.sqlConn
        '
        'SqlUpdateCommand14
        '
        Me.SqlUpdateCommand14.CommandText = resources.GetString("SqlUpdateCommand14.CommandText")
        Me.SqlUpdateCommand14.Connection = Me.sqlConn
        Me.SqlUpdateCommand14.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sSONum", System.Data.SqlDbType.VarChar, 50, "sSONum"), New System.Data.SqlClient.SqlParameter("@nCustID", System.Data.SqlDbType.Int, 4, "nCustID"), New System.Data.SqlClient.SqlParameter("@nJobID", System.Data.SqlDbType.Int, 4, "nJobID"), New System.Data.SqlClient.SqlParameter("@sName", System.Data.SqlDbType.VarChar, 50, "sName"), New System.Data.SqlClient.SqlParameter("@sFOB", System.Data.SqlDbType.VarChar, 50, "sFOB"), New System.Data.SqlClient.SqlParameter("@dShipped", System.Data.SqlDbType.DateTime, 4, "dShipped"), New System.Data.SqlClient.SqlParameter("@sVIA", System.Data.SqlDbType.VarChar, 50, "sVIA"), New System.Data.SqlClient.SqlParameter("@sShipTo1", System.Data.SqlDbType.VarChar, 50, "sShipTo1"), New System.Data.SqlClient.SqlParameter("@sShipTo2", System.Data.SqlDbType.VarChar, 50, "sShipTo2"), New System.Data.SqlClient.SqlParameter("@sShipToCity", System.Data.SqlDbType.VarChar, 50, "sShipToCity"), New System.Data.SqlClient.SqlParameter("@sShipToState", System.Data.SqlDbType.VarChar, 50, "sShipToState"), New System.Data.SqlClient.SqlParameter("@sShipToZip", System.Data.SqlDbType.VarChar, 50, "sShipToZip"), New System.Data.SqlClient.SqlParameter("@sShipToCounty", System.Data.SqlDbType.VarChar, 50, "sShipToCounty"), New System.Data.SqlClient.SqlParameter("@sTerms", System.Data.SqlDbType.VarChar, 50, "sTerms"), New System.Data.SqlClient.SqlParameter("@nTaxRate", System.Data.SqlDbType.Int, 4, "nTaxRate"), New System.Data.SqlClient.SqlParameter("@dinvoice", System.Data.SqlDbType.DateTime, 4, "dinvoice"), New System.Data.SqlClient.SqlParameter("@dsimply", System.Data.SqlDbType.DateTime, 4, "dsimply"), New System.Data.SqlClient.SqlParameter("@dmailed", System.Data.SqlDbType.DateTime, 4, "dmailed"), New System.Data.SqlClient.SqlParameter("@nTotal", System.Data.SqlDbType.Int, 4, "nTotal"), New System.Data.SqlClient.SqlParameter("@sOurOrder", System.Data.SqlDbType.VarChar, 50, "sOurOrder"), New System.Data.SqlClient.SqlParameter("@sYourOrder", System.Data.SqlDbType.VarChar, 50, "sYourOrder"), New System.Data.SqlClient.SqlParameter("@nSimplySequence", System.Data.SqlDbType.Int, 4, "nSimplySequence"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dShipped", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dShipped", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dinvoice", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dinvoice", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dmailed", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dmailed", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dsimply", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dsimply", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCustID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nJobID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nSimplySequence", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSimplySequence", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTaxRate", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTotal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sFOB", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sFOB", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sName", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sOurOrder", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOurOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sSONum", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSONum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipTo2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipTo2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToCity", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToCounty", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToCounty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToState", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToState", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sShipToZip", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sShipToZip", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sTerms", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sVIA", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sVIA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sYourOrder", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sYourOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'daPaymentsDISTINCT
        '
        Me.daPaymentsDISTINCT.SelectCommand = Me.SqlCommand34
        Me.daPaymentsDISTINCT.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPayments", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("JOBID", "JOBID"), New System.Data.Common.DataColumnMapping("dDate", "dDate"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount")})})
        '
        'SqlCommand34
        '
        Me.SqlCommand34.CommandText = "SELECT DISTINCT dDate FROM tPayments ORDER BY dDate DESC"
        Me.SqlCommand34.Connection = Me.sqlConn
        '
        'SqlSelectCommand21
        '
        Me.SqlSelectCommand21.CommandText = "SELECT ID, DrawAmount, DrawDate, Salesperson FROM tDraws"
        Me.SqlSelectCommand21.Connection = Me.sqlConn
        '
        'SqlInsertCommand13
        '
        Me.SqlInsertCommand13.CommandText = "INSERT INTO tDraws(DrawAmount, DrawDate, Salesperson) VALUES (@DrawAmount, @DrawD" & _
    "ate, @Salesperson); SELECT ID, DrawAmount, DrawDate, Salesperson FROM tDraws WHE" & _
    "RE (ID = @@IDENTITY)"
        Me.SqlInsertCommand13.Connection = Me.sqlConn
        Me.SqlInsertCommand13.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DrawAmount", System.Data.SqlDbType.Money, 8, "DrawAmount"), New System.Data.SqlClient.SqlParameter("@DrawDate", System.Data.SqlDbType.DateTime, 4, "DrawDate"), New System.Data.SqlClient.SqlParameter("@Salesperson", System.Data.SqlDbType.VarChar, 50, "Salesperson")})
        '
        'SqlUpdateCommand13
        '
        Me.SqlUpdateCommand13.CommandText = resources.GetString("SqlUpdateCommand13.CommandText")
        Me.SqlUpdateCommand13.Connection = Me.sqlConn
        Me.SqlUpdateCommand13.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DrawAmount", System.Data.SqlDbType.Money, 8, "DrawAmount"), New System.Data.SqlClient.SqlParameter("@DrawDate", System.Data.SqlDbType.DateTime, 4, "DrawDate"), New System.Data.SqlClient.SqlParameter("@Salesperson", System.Data.SqlDbType.VarChar, 50, "Salesperson"), New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DrawAmount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawAmount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DrawDate", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Salesperson", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salesperson", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")})
        '
        'SqlDeleteCommand13
        '
        Me.SqlDeleteCommand13.CommandText = "DELETE FROM tDraws WHERE (ID = @Original_ID) AND (DrawAmount = @Original_DrawAmou" & _
    "nt) AND (DrawDate = @Original_DrawDate) AND (Salesperson = @Original_Salesperson" & _
    ")"
        Me.SqlDeleteCommand13.Connection = Me.sqlConn
        Me.SqlDeleteCommand13.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DrawAmount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawAmount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DrawDate", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DrawDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Salesperson", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salesperson", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daDrawsALL
        '
        Me.daDrawsALL.DeleteCommand = Me.SqlDeleteCommand13
        Me.daDrawsALL.InsertCommand = Me.SqlInsertCommand13
        Me.daDrawsALL.SelectCommand = Me.SqlSelectCommand21
        Me.daDrawsALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tDraws", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("DrawAmount", "DrawAmount"), New System.Data.Common.DataColumnMapping("DrawDate", "DrawDate"), New System.Data.Common.DataColumnMapping("Salesperson", "Salesperson")})})
        Me.daDrawsALL.UpdateCommand = Me.SqlUpdateCommand13
        '
        'daJobALL
        '
        Me.daJobALL.DeleteCommand = Me.SqlDeleteCommand3
        Me.daJobALL.InsertCommand = Me.SqlInsertCommand3
        Me.daJobALL.SelectCommand = Me.SqlSelectCommand23
        Me.daJobALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        Me.daJobALL.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.sqlConn
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dAmtYTD", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dAmtYTD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCommPaid", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCommPaid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCrLimit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCrLimit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCreated", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCreated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dDrawing", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDrawing", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dJobCreated", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dJobCreated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_lngCommissionStruct", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lngCommissionStruct", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAddressID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAddressID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCustID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nLaborCharge", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLaborCharge", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nMaterialsCharge", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nMaterialsCharge", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTaxRate", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTotalWholesale", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotalWholesale", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sBuildingPermit", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBuildingPermit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCommLocked", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCommLocked", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sComplete", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sContractSigned", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sContractSigned", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCounty", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCounty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sDisclaimerSigned", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDisclaimerSigned", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sDrawingsSigned", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDrawingsSigned", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sInvNotes", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sInvNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobContact", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobContact", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobDesc", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobNo", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sOtherNotes", System.Data.SqlDbType.VarChar, 3000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOtherNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPhone", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sSalesperson", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSalesperson", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sTerms", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.sqlConn
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nAddressID", System.Data.SqlDbType.Int, 4, "nAddressID"), New System.Data.SqlClient.SqlParameter("@sJobDesc", System.Data.SqlDbType.VarChar, 255, "sJobDesc"), New System.Data.SqlClient.SqlParameter("@dCreated", System.Data.SqlDbType.DateTime, 4, "dCreated"), New System.Data.SqlClient.SqlParameter("@dJobCreated", System.Data.SqlDbType.DateTime, 4, "dJobCreated"), New System.Data.SqlClient.SqlParameter("@sJobNo", System.Data.SqlDbType.VarChar, 255, "sJobNo"), New System.Data.SqlClient.SqlParameter("@nCustID", System.Data.SqlDbType.Int, 4, "nCustID"), New System.Data.SqlClient.SqlParameter("@sPhone", System.Data.SqlDbType.VarChar, 255, "sPhone"), New System.Data.SqlClient.SqlParameter("@sJobContact", System.Data.SqlDbType.VarChar, 255, "sJobContact"), New System.Data.SqlClient.SqlParameter("@sCounty", System.Data.SqlDbType.VarChar, 255, "sCounty"), New System.Data.SqlClient.SqlParameter("@nTotalWholesale", System.Data.SqlDbType.Float, 8, "nTotalWholesale"), New System.Data.SqlClient.SqlParameter("@sBuildingPermit", System.Data.SqlDbType.VarChar, 255, "sBuildingPermit"), New System.Data.SqlClient.SqlParameter("@sTerms", System.Data.SqlDbType.VarChar, 255, "sTerms"), New System.Data.SqlClient.SqlParameter("@dDrawing", System.Data.SqlDbType.VarChar, 255, "dDrawing"), New System.Data.SqlClient.SqlParameter("@nMaterialsCharge", System.Data.SqlDbType.Float, 8, "nMaterialsCharge"), New System.Data.SqlClient.SqlParameter("@nTaxRate", System.Data.SqlDbType.Float, 8, "nTaxRate"), New System.Data.SqlClient.SqlParameter("@nLaborCharge", System.Data.SqlDbType.Float, 8, "nLaborCharge"), New System.Data.SqlClient.SqlParameter("@sContractSigned", System.Data.SqlDbType.VarChar, 255, "sContractSigned"), New System.Data.SqlClient.SqlParameter("@sDisclaimerSigned", System.Data.SqlDbType.VarChar, 50, "sDisclaimerSigned"), New System.Data.SqlClient.SqlParameter("@sDrawingsSigned", System.Data.SqlDbType.VarChar, 255, "sDrawingsSigned"), New System.Data.SqlClient.SqlParameter("@sComplete", System.Data.SqlDbType.VarChar, 255, "sComplete"), New System.Data.SqlClient.SqlParameter("@sSalesperson", System.Data.SqlDbType.VarChar, 50, "sSalesperson"), New System.Data.SqlClient.SqlParameter("@sOtherNotes", System.Data.SqlDbType.VarChar, 3000, "sOtherNotes"), New System.Data.SqlClient.SqlParameter("@dCommPaid", System.Data.SqlDbType.DateTime, 4, "dCommPaid"), New System.Data.SqlClient.SqlParameter("@sCommLocked", System.Data.SqlDbType.VarChar, 50, "sCommLocked"), New System.Data.SqlClient.SqlParameter("@dCrLimit", System.Data.SqlDbType.Money, 8, "dCrLimit"), New System.Data.SqlClient.SqlParameter("@dAmtYTD", System.Data.SqlDbType.Money, 8, "dAmtYTD"), New System.Data.SqlClient.SqlParameter("@sInvNotes", System.Data.SqlDbType.VarChar, 255, "sInvNotes"), New System.Data.SqlClient.SqlParameter("@lngCommissionStruct", System.Data.SqlDbType.Int, 4, "lngCommissionStruct")})
        '
        'SqlSelectCommand23
        '
        Me.SqlSelectCommand23.CommandText = resources.GetString("SqlSelectCommand23.CommandText")
        Me.SqlSelectCommand23.Connection = Me.sqlConn
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.sqlConn
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nAddressID", System.Data.SqlDbType.Int, 4, "nAddressID"), New System.Data.SqlClient.SqlParameter("@sJobDesc", System.Data.SqlDbType.VarChar, 255, "sJobDesc"), New System.Data.SqlClient.SqlParameter("@dCreated", System.Data.SqlDbType.DateTime, 4, "dCreated"), New System.Data.SqlClient.SqlParameter("@dJobCreated", System.Data.SqlDbType.DateTime, 4, "dJobCreated"), New System.Data.SqlClient.SqlParameter("@sJobNo", System.Data.SqlDbType.VarChar, 255, "sJobNo"), New System.Data.SqlClient.SqlParameter("@nCustID", System.Data.SqlDbType.Int, 4, "nCustID"), New System.Data.SqlClient.SqlParameter("@sPhone", System.Data.SqlDbType.VarChar, 255, "sPhone"), New System.Data.SqlClient.SqlParameter("@sJobContact", System.Data.SqlDbType.VarChar, 255, "sJobContact"), New System.Data.SqlClient.SqlParameter("@sCounty", System.Data.SqlDbType.VarChar, 255, "sCounty"), New System.Data.SqlClient.SqlParameter("@nTotalWholesale", System.Data.SqlDbType.Float, 8, "nTotalWholesale"), New System.Data.SqlClient.SqlParameter("@sBuildingPermit", System.Data.SqlDbType.VarChar, 255, "sBuildingPermit"), New System.Data.SqlClient.SqlParameter("@sTerms", System.Data.SqlDbType.VarChar, 255, "sTerms"), New System.Data.SqlClient.SqlParameter("@dDrawing", System.Data.SqlDbType.VarChar, 255, "dDrawing"), New System.Data.SqlClient.SqlParameter("@nMaterialsCharge", System.Data.SqlDbType.Float, 8, "nMaterialsCharge"), New System.Data.SqlClient.SqlParameter("@nTaxRate", System.Data.SqlDbType.Float, 8, "nTaxRate"), New System.Data.SqlClient.SqlParameter("@nLaborCharge", System.Data.SqlDbType.Float, 8, "nLaborCharge"), New System.Data.SqlClient.SqlParameter("@sContractSigned", System.Data.SqlDbType.VarChar, 255, "sContractSigned"), New System.Data.SqlClient.SqlParameter("@sDisclaimerSigned", System.Data.SqlDbType.VarChar, 50, "sDisclaimerSigned"), New System.Data.SqlClient.SqlParameter("@sDrawingsSigned", System.Data.SqlDbType.VarChar, 255, "sDrawingsSigned"), New System.Data.SqlClient.SqlParameter("@sComplete", System.Data.SqlDbType.VarChar, 255, "sComplete"), New System.Data.SqlClient.SqlParameter("@sSalesperson", System.Data.SqlDbType.VarChar, 50, "sSalesperson"), New System.Data.SqlClient.SqlParameter("@sOtherNotes", System.Data.SqlDbType.VarChar, 3000, "sOtherNotes"), New System.Data.SqlClient.SqlParameter("@dCommPaid", System.Data.SqlDbType.DateTime, 4, "dCommPaid"), New System.Data.SqlClient.SqlParameter("@sCommLocked", System.Data.SqlDbType.VarChar, 50, "sCommLocked"), New System.Data.SqlClient.SqlParameter("@dCrLimit", System.Data.SqlDbType.Money, 8, "dCrLimit"), New System.Data.SqlClient.SqlParameter("@dAmtYTD", System.Data.SqlDbType.Money, 8, "dAmtYTD"), New System.Data.SqlClient.SqlParameter("@sInvNotes", System.Data.SqlDbType.VarChar, 255, "sInvNotes"), New System.Data.SqlClient.SqlParameter("@lngCommissionStruct", System.Data.SqlDbType.Int, 4, "lngCommissionStruct"), New System.Data.SqlClient.SqlParameter("@Original_nID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dAmtYTD", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dAmtYTD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCommPaid", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCommPaid", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCrLimit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCrLimit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dCreated", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dCreated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dDrawing", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDrawing", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dJobCreated", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dJobCreated", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_lngCommissionStruct", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lngCommissionStruct", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nAddressID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nAddressID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nCustID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nCustID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nLaborCharge", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLaborCharge", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nMaterialsCharge", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nMaterialsCharge", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTaxRate", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTaxRate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nTotalWholesale", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nTotalWholesale", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sBuildingPermit", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sBuildingPermit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCommLocked", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCommLocked", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sComplete", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sComplete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sContractSigned", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sContractSigned", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sCounty", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sCounty", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sDisclaimerSigned", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDisclaimerSigned", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sDrawingsSigned", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sDrawingsSigned", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sInvNotes", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sInvNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobContact", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobContact", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobDesc", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobNo", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobNo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sOtherNotes", System.Data.SqlDbType.VarChar, 3000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOtherNotes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sPhone", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sPhone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sSalesperson", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sSalesperson", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sTerms", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sTerms", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'daPOHeaderSBackorderYES
        '
        Me.daPOHeaderSBackorderYES.SelectCommand = Me.SqlCommand17
        Me.daPOHeaderSBackorderYES.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand17
        '
        Me.SqlCommand17.CommandText = resources.GetString("SqlCommand17.CommandText")
        Me.SqlCommand17.Connection = Me.sqlConn
        '
        'daPOLinesSBackorderYES
        '
        Me.daPOLinesSBackorderYES.SelectCommand = Me.SqlCommand18
        Me.daPOLinesSBackorderYES.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand18
        '
        Me.SqlCommand18.CommandText = "SELECT tPOLine.* FROM tPOLine INNER JOIN tPOHeader ON tPOLine.nPOID = tPOHeader.n" & _
    "ID WHERE (tPOHeader.sBackOrder = 'Yes') ORDER BY tPOHeader.nVendorID, tPOLine.nP" & _
    "OID, tPOLine.nLineNumber"
        Me.SqlCommand18.Connection = Me.sqlConn
        '
        'SqlSelectCommand24
        '
        Me.SqlSelectCommand24.CommandText = "SELECT ID, TaxRegionName, Notes, TotalRate FROM tblTaxRegion"
        Me.SqlSelectCommand24.Connection = Me.sqlConn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO tblTaxRegion(TaxRegionName, Notes, TotalRate) VALUES (@TaxRegionName," & _
    " @Notes, @TotalRate); SELECT ID, TaxRegionName, Notes, TotalRate FROM tblTaxRegi" & _
    "on WHERE (ID = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.sqlConn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@TaxRegionName", System.Data.SqlDbType.NVarChar, 255, "TaxRegionName"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 255, "Notes"), New System.Data.SqlClient.SqlParameter("@TotalRate", System.Data.SqlDbType.Float, 8, "TotalRate")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.sqlConn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@TaxRegionName", System.Data.SqlDbType.NVarChar, 255, "TaxRegionName"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 255, "Notes"), New System.Data.SqlClient.SqlParameter("@TotalRate", System.Data.SqlDbType.Float, 8, "TotalRate"), New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxRegionName", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxRegionName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalRate", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalRate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM tblTaxRegion WHERE (ID = @Original_ID) AND (Notes = @Original_Notes) " & _
    "AND (TaxRegionName = @Original_TaxRegionName) AND (TotalRate = @Original_TotalRa" & _
    "te)"
        Me.SqlDeleteCommand1.Connection = Me.sqlConn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Notes", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxRegionName", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxRegionName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalRate", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalRate", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daTaxRegionAll
        '
        Me.daTaxRegionAll.DeleteCommand = Me.SqlDeleteCommand1
        Me.daTaxRegionAll.InsertCommand = Me.SqlInsertCommand1
        Me.daTaxRegionAll.SelectCommand = Me.SqlSelectCommand24
        Me.daTaxRegionAll.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblTaxRegion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("TaxRegionName", "TaxRegionName"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("TotalRate", "TotalRate")})})
        Me.daTaxRegionAll.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand25
        '
        Me.SqlSelectCommand25.CommandText = "SELECT ID, TaxDistrictID, TaxRegionID FROM tblTaxJOIN"
        Me.SqlSelectCommand25.Connection = Me.sqlConn
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO tblTaxJOIN(ID, TaxDistrictID, TaxRegionID) VALUES (@ID, @TaxDistrictI" & _
    "D, @TaxRegionID); SELECT ID, TaxDistrictID, TaxRegionID FROM tblTaxJOIN WHERE (I" & _
    "D = @ID)"
        Me.SqlInsertCommand4.Connection = Me.sqlConn
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"), New System.Data.SqlClient.SqlParameter("@TaxDistrictID", System.Data.SqlDbType.Int, 4, "TaxDistrictID"), New System.Data.SqlClient.SqlParameter("@TaxRegionID", System.Data.SqlDbType.Int, 4, "TaxRegionID")})
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.sqlConn
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"), New System.Data.SqlClient.SqlParameter("@TaxDistrictID", System.Data.SqlDbType.Int, 4, "TaxDistrictID"), New System.Data.SqlClient.SqlParameter("@TaxRegionID", System.Data.SqlDbType.Int, 4, "TaxRegionID"), New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxDistrictID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxDistrictID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxRegionID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxRegionID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM tblTaxJOIN WHERE (ID = @Original_ID) AND (TaxDistrictID = @Original_T" & _
    "axDistrictID) AND (TaxRegionID = @Original_TaxRegionID)"
        Me.SqlDeleteCommand4.Connection = Me.sqlConn
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxDistrictID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxDistrictID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxRegionID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxRegionID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daTaxJOINALL
        '
        Me.daTaxJOINALL.DeleteCommand = Me.SqlDeleteCommand4
        Me.daTaxJOINALL.InsertCommand = Me.SqlInsertCommand4
        Me.daTaxJOINALL.SelectCommand = Me.SqlSelectCommand25
        Me.daTaxJOINALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblTaxJOIN", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("TaxDistrictID", "TaxDistrictID"), New System.Data.Common.DataColumnMapping("TaxRegionID", "TaxRegionID")})})
        Me.daTaxJOINALL.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT ID, TaxRate, RateName, AccountingCode, Note FROM tblTaxDistrict"
        Me.SqlSelectCommand7.Connection = Me.sqlConn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.sqlConn
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@TaxRate", System.Data.SqlDbType.Real, 4, "TaxRate"), New System.Data.SqlClient.SqlParameter("@RateName", System.Data.SqlDbType.NVarChar, 255, "RateName"), New System.Data.SqlClient.SqlParameter("@AccountingCode", System.Data.SqlDbType.Int, 4, "AccountingCode"), New System.Data.SqlClient.SqlParameter("@Note", System.Data.SqlDbType.NVarChar, 255, "Note")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.sqlConn
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@TaxRate", System.Data.SqlDbType.Real, 4, "TaxRate"), New System.Data.SqlClient.SqlParameter("@RateName", System.Data.SqlDbType.NVarChar, 255, "RateName"), New System.Data.SqlClient.SqlParameter("@AccountingCode", System.Data.SqlDbType.Int, 4, "AccountingCode"), New System.Data.SqlClient.SqlParameter("@Note", System.Data.SqlDbType.NVarChar, 255, "Note"), New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_AccountingCode", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Note", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RateName", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RateName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxRate", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxRate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM tblTaxDistrict WHERE (ID = @Original_ID) AND (AccountingCode = @Origi" & _
    "nal_AccountingCode) AND (Note = @Original_Note) AND (RateName = @Original_RateNa" & _
    "me) AND (TaxRate = @Original_TaxRate)"
        Me.SqlDeleteCommand2.Connection = Me.sqlConn
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_AccountingCode", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AccountingCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Note", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Note", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RateName", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RateName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxRate", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxRate", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daTaxDistrictALL
        '
        Me.daTaxDistrictALL.DeleteCommand = Me.SqlDeleteCommand2
        Me.daTaxDistrictALL.InsertCommand = Me.SqlInsertCommand2
        Me.daTaxDistrictALL.SelectCommand = Me.SqlSelectCommand7
        Me.daTaxDistrictALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblTaxDistrict", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("TaxRate", "TaxRate"), New System.Data.Common.DataColumnMapping("RateName", "RateName"), New System.Data.Common.DataColumnMapping("AccountingCode", "AccountingCode"), New System.Data.Common.DataColumnMapping("Note", "Note")})})
        Me.daTaxDistrictALL.UpdateCommand = Me.SqlUpdateCommand2
        '
        'daInstallerALL
        '
        Me.daInstallerALL.DeleteCommand = Me.SqlDeleteCommand5
        Me.daInstallerALL.InsertCommand = Me.SqlInsertCommand5
        Me.daInstallerALL.SelectCommand = Me.SqlSelectCommand26
        Me.daInstallerALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblInstaller", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Contact1", "Contact1"), New System.Data.Common.DataColumnMapping("Contact2", "Contact2"), New System.Data.Common.DataColumnMapping("Contact3", "Contact3"), New System.Data.Common.DataColumnMapping("Archive", "Archive"), New System.Data.Common.DataColumnMapping("username", "username"), New System.Data.Common.DataColumnMapping("password", "password"), New System.Data.Common.DataColumnMapping("color", "color")})})
        Me.daInstallerALL.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        Me.SqlDeleteCommand5.Connection = Me.sqlConn
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Archive", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Archive", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contact1", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contact1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contact2", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contact2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contact3", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contact3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_color", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "color", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_password", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "password", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "username", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.sqlConn
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50, "Name"), New System.Data.SqlClient.SqlParameter("@Contact1", System.Data.SqlDbType.NVarChar, 50, "Contact1"), New System.Data.SqlClient.SqlParameter("@Contact2", System.Data.SqlDbType.NVarChar, 50, "Contact2"), New System.Data.SqlClient.SqlParameter("@Contact3", System.Data.SqlDbType.NVarChar, 50, "Contact3"), New System.Data.SqlClient.SqlParameter("@Archive", System.Data.SqlDbType.NVarChar, 50, "Archive"), New System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.NVarChar, 50, "username"), New System.Data.SqlClient.SqlParameter("@password", System.Data.SqlDbType.NVarChar, 50, "password"), New System.Data.SqlClient.SqlParameter("@color", System.Data.SqlDbType.NVarChar, 50, "color")})
        '
        'SqlSelectCommand26
        '
        Me.SqlSelectCommand26.CommandText = "SELECT ID, Name, Contact1, Contact2, Contact3, Archive, username, password, color" & _
    " FROM dbo.tblInstaller"
        Me.SqlSelectCommand26.Connection = Me.sqlConn
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.sqlConn
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50, "Name"), New System.Data.SqlClient.SqlParameter("@Contact1", System.Data.SqlDbType.NVarChar, 50, "Contact1"), New System.Data.SqlClient.SqlParameter("@Contact2", System.Data.SqlDbType.NVarChar, 50, "Contact2"), New System.Data.SqlClient.SqlParameter("@Contact3", System.Data.SqlDbType.NVarChar, 50, "Contact3"), New System.Data.SqlClient.SqlParameter("@Archive", System.Data.SqlDbType.NVarChar, 50, "Archive"), New System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.NVarChar, 50, "username"), New System.Data.SqlClient.SqlParameter("@password", System.Data.SqlDbType.NVarChar, 50, "password"), New System.Data.SqlClient.SqlParameter("@color", System.Data.SqlDbType.NVarChar, 50, "color"), New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Archive", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Archive", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contact1", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contact1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contact2", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contact2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contact3", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contact3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_color", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "color", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_password", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "password", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "username", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")})
        '
        'daInstallerDatesALL
        '
        Me.daInstallerDatesALL.DeleteCommand = Me.SqlDeleteCommand7
        Me.daInstallerDatesALL.InsertCommand = Me.SqlInsertCommand7
        Me.daInstallerDatesALL.SelectCommand = Me.SqlSelectCommand27
        Me.daInstallerDatesALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblInstallerDates", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("InstallerID", "InstallerID"), New System.Data.Common.DataColumnMapping("DateStart", "DateStart"), New System.Data.Common.DataColumnMapping("DateEnd", "DateEnd"), New System.Data.Common.DataColumnMapping("sJobNum", "sJobNum"), New System.Data.Common.DataColumnMapping("jobaddress", "jobaddress"), New System.Data.Common.DataColumnMapping("Customer", "Customer"), New System.Data.Common.DataColumnMapping("sales", "sales"), New System.Data.Common.DataColumnMapping("other", "other")})})
        Me.daInstallerDatesALL.UpdateCommand = Me.SqlUpdateCommand7
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = resources.GetString("SqlDeleteCommand7.CommandText")
        Me.SqlDeleteCommand7.Connection = Me.sqlConn
        Me.SqlDeleteCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Customer", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Customer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateEnd", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateEnd", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateStart", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateStart", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_InstallerID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InstallerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_jobaddress", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "jobaddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_other", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "other", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobNum", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sales", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sales", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = resources.GetString("SqlInsertCommand7.CommandText")
        Me.SqlInsertCommand7.Connection = Me.sqlConn
        Me.SqlInsertCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@InstallerID", System.Data.SqlDbType.Int, 4, "InstallerID"), New System.Data.SqlClient.SqlParameter("@DateStart", System.Data.SqlDbType.DateTime, 4, "DateStart"), New System.Data.SqlClient.SqlParameter("@DateEnd", System.Data.SqlDbType.DateTime, 4, "DateEnd"), New System.Data.SqlClient.SqlParameter("@sJobNum", System.Data.SqlDbType.VarChar, 50, "sJobNum"), New System.Data.SqlClient.SqlParameter("@jobaddress", System.Data.SqlDbType.VarChar, 255, "jobaddress"), New System.Data.SqlClient.SqlParameter("@Customer", System.Data.SqlDbType.VarChar, 50, "Customer"), New System.Data.SqlClient.SqlParameter("@sales", System.Data.SqlDbType.VarChar, 50, "sales"), New System.Data.SqlClient.SqlParameter("@other", System.Data.SqlDbType.VarChar, 50, "other")})
        '
        'SqlSelectCommand27
        '
        Me.SqlSelectCommand27.CommandText = "SELECT ID, InstallerID, DateStart, DateEnd, sJobNum, jobaddress, Customer, sales," & _
    " other FROM dbo.tblInstallerDates ORDER BY InstallerID, DateStart, DateEnd"
        Me.SqlSelectCommand27.Connection = Me.sqlConn
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = resources.GetString("SqlUpdateCommand7.CommandText")
        Me.SqlUpdateCommand7.Connection = Me.sqlConn
        Me.SqlUpdateCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@InstallerID", System.Data.SqlDbType.Int, 4, "InstallerID"), New System.Data.SqlClient.SqlParameter("@DateStart", System.Data.SqlDbType.DateTime, 4, "DateStart"), New System.Data.SqlClient.SqlParameter("@DateEnd", System.Data.SqlDbType.DateTime, 4, "DateEnd"), New System.Data.SqlClient.SqlParameter("@sJobNum", System.Data.SqlDbType.VarChar, 50, "sJobNum"), New System.Data.SqlClient.SqlParameter("@jobaddress", System.Data.SqlDbType.VarChar, 255, "jobaddress"), New System.Data.SqlClient.SqlParameter("@Customer", System.Data.SqlDbType.VarChar, 50, "Customer"), New System.Data.SqlClient.SqlParameter("@sales", System.Data.SqlDbType.VarChar, 50, "sales"), New System.Data.SqlClient.SqlParameter("@other", System.Data.SqlDbType.VarChar, 50, "other"), New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Customer", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Customer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateEnd", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateEnd", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DateStart", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateStart", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_InstallerID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InstallerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_jobaddress", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "jobaddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_other", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "other", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sJobNum", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sJobNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sales", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sales", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")})
        '
        'SqlSelectCommand28
        '
        Me.SqlSelectCommand28.CommandText = "SELECT Customer, DateEnd, DateStart, ID, InstallerID, jobaddress, other, sales, s" & _
    "JobNum FROM dbo.tblInstallerDates WHERE (DateStart <= @DateEnd) AND (DateEnd >= " & _
    "@DateStart)"
        Me.SqlSelectCommand28.Connection = Me.sqlConn
        Me.SqlSelectCommand28.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DateEnd", System.Data.SqlDbType.DateTime, 4, "DateStart"), New System.Data.SqlClient.SqlParameter("@DateStart", System.Data.SqlDbType.DateTime, 4, "DateEnd")})
        '
        'daInstallerDatesConflictByDateStartDateEnd
        '
        Me.daInstallerDatesConflictByDateStartDateEnd.SelectCommand = Me.SqlSelectCommand28
        Me.daInstallerDatesConflictByDateStartDateEnd.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblInstallerDates", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("InstallerID", "InstallerID"), New System.Data.Common.DataColumnMapping("DateStart", "DateStart"), New System.Data.Common.DataColumnMapping("DateEnd", "DateEnd"), New System.Data.Common.DataColumnMapping("sJobNum", "sJobNum"), New System.Data.Common.DataColumnMapping("jobaddress", "jobaddress"), New System.Data.Common.DataColumnMapping("Customer", "Customer"), New System.Data.Common.DataColumnMapping("sales", "sales"), New System.Data.Common.DataColumnMapping("other", "other")})})
        '
        'SqlSelectCommand29
        '
        Me.SqlSelectCommand29.CommandText = "SELECT ID, nJobID, TaxName, TaxPercent, TaxCode FROM tblJobTax"
        Me.SqlSelectCommand29.Connection = Me.sqlConn
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO tblJobTax(nJobID, TaxName, TaxPercent, TaxCode) VALUES (@nJobID, @Tax" & _
    "Name, @TaxPercent, @TaxCode); SELECT ID, nJobID, TaxName, TaxPercent, TaxCode FR" & _
    "OM tblJobTax WHERE (ID = @@IDENTITY)"
        Me.SqlInsertCommand8.Connection = Me.sqlConn
        Me.SqlInsertCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nJobID", System.Data.SqlDbType.Int, 4, "nJobID"), New System.Data.SqlClient.SqlParameter("@TaxName", System.Data.SqlDbType.NVarChar, 50, "TaxName"), New System.Data.SqlClient.SqlParameter("@TaxPercent", System.Data.SqlDbType.Float, 8, "TaxPercent"), New System.Data.SqlClient.SqlParameter("@TaxCode", System.Data.SqlDbType.Int, 4, "TaxCode")})
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = resources.GetString("SqlUpdateCommand8.CommandText")
        Me.SqlUpdateCommand8.Connection = Me.sqlConn
        Me.SqlUpdateCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nJobID", System.Data.SqlDbType.Int, 4, "nJobID"), New System.Data.SqlClient.SqlParameter("@TaxName", System.Data.SqlDbType.NVarChar, 50, "TaxName"), New System.Data.SqlClient.SqlParameter("@TaxPercent", System.Data.SqlDbType.Float, 8, "TaxPercent"), New System.Data.SqlClient.SqlParameter("@TaxCode", System.Data.SqlDbType.Int, 4, "TaxCode"), New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxCode", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxName", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxPercent", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxPercent", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nJobID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")})
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = "DELETE FROM tblJobTax WHERE (ID = @Original_ID) AND (TaxCode = @Original_TaxCode)" & _
    " AND (TaxName = @Original_TaxName) AND (TaxPercent = @Original_TaxPercent) AND (" & _
    "nJobID = @Original_nJobID)"
        Me.SqlDeleteCommand8.Connection = Me.sqlConn
        Me.SqlDeleteCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxCode", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxName", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TaxPercent", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TaxPercent", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nJobID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nJobID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daJobTaxALL
        '
        Me.daJobTaxALL.DeleteCommand = Me.SqlDeleteCommand8
        Me.daJobTaxALL.InsertCommand = Me.SqlInsertCommand8
        Me.daJobTaxALL.SelectCommand = Me.SqlSelectCommand29
        Me.daJobTaxALL.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblJobTax", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("TaxName", "TaxName"), New System.Data.Common.DataColumnMapping("TaxPercent", "TaxPercent"), New System.Data.Common.DataColumnMapping("TaxCode", "TaxCode")})})
        Me.daJobTaxALL.UpdateCommand = Me.SqlUpdateCommand8
        '
        'daJobDSimply1
        '
        Me.daJobDSimply1.SelectCommand = Me.SqlSelectCommand30
        Me.daJobDSimply1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        '
        'SqlSelectCommand30
        '
        Me.SqlSelectCommand30.CommandText = resources.GetString("SqlSelectCommand30.CommandText")
        Me.SqlSelectCommand30.Connection = Me.sqlConn
        Me.SqlSelectCommand30.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@dSimplyStart", System.Data.SqlDbType.SmallDateTime, 4, "dsimply"), New System.Data.SqlClient.SqlParameter("@dSimplyEnd", System.Data.SqlDbType.SmallDateTime, 4, "dsimply")})
        '
        'daSOHeaderDSimply
        '
        Me.daSOHeaderDSimply.SelectCommand = Me.SqlCommand21
        Me.daSOHeaderDSimply.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sSONum", "sSONum"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("dShipped", "dShipped"), New System.Data.Common.DataColumnMapping("sVIA", "sVIA"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShipToCounty", "sShipToCounty"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("dinvoice", "dinvoice"), New System.Data.Common.DataColumnMapping("dsimply", "dsimply"), New System.Data.Common.DataColumnMapping("dmailed", "dmailed"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sOurOrder", "sOurOrder"), New System.Data.Common.DataColumnMapping("sYourOrder", "sYourOrder"), New System.Data.Common.DataColumnMapping("nSimplySequence", "nSimplySequence")})})
        '
        'SqlCommand21
        '
        Me.SqlCommand21.CommandText = resources.GetString("SqlCommand21.CommandText")
        Me.SqlCommand21.Connection = Me.sqlConn
        Me.SqlCommand21.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@dSimplyStart", System.Data.SqlDbType.DateTime, 4, "dsimply"), New System.Data.SqlClient.SqlParameter("@dSimplyEnd", System.Data.SqlDbType.DateTime, 4, "dsimply")})
        '
        'daSOLineDSimply
        '
        Me.daSOLineDSimply.SelectCommand = Me.SqlCommand22
        Me.daSOLineDSimply.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("bTaxable", "bTaxable"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sHidden", "sHidden"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID")})})
        '
        'SqlCommand22
        '
        Me.SqlCommand22.CommandText = resources.GetString("SqlCommand22.CommandText")
        Me.SqlCommand22.Connection = Me.sqlConn
        Me.SqlCommand22.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@dSimplyStart", System.Data.SqlDbType.DateTime, 4, "dsimply"), New System.Data.SqlClient.SqlParameter("@dSimplyEnd", System.Data.SqlDbType.DateTime, 4, "dsimply")})
        '
        'SqlSelectCommand31
        '
        Me.SqlSelectCommand31.CommandText = "SELECT ID, nSOID, nLineNumber, dDateDeposit, sOther FROM tDeposits WHERE (dDateDe" & _
    "posit >= @StartDate) AND (dDateDeposit <= @EndDate) ORDER BY dDateDeposit, nSOID" & _
    ", nLineNumber"
        Me.SqlSelectCommand31.Connection = Me.sqlConn
        Me.SqlSelectCommand31.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@StartDate", System.Data.SqlDbType.DateTime, 4, "dDateDeposit"), New System.Data.SqlClient.SqlParameter("@EndDate", System.Data.SqlDbType.DateTime, 4, "dDateDeposit")})
        '
        'SqlInsertCommand9
        '
        Me.SqlInsertCommand9.CommandText = resources.GetString("SqlInsertCommand9.CommandText")
        Me.SqlInsertCommand9.Connection = Me.sqlConn
        Me.SqlInsertCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nSOID", System.Data.SqlDbType.Int, 4, "nSOID"), New System.Data.SqlClient.SqlParameter("@nLineNumber", System.Data.SqlDbType.Int, 4, "nLineNumber"), New System.Data.SqlClient.SqlParameter("@dDateDeposit", System.Data.SqlDbType.DateTime, 4, "dDateDeposit"), New System.Data.SqlClient.SqlParameter("@sOther", System.Data.SqlDbType.NVarChar, 50, "sOther")})
        '
        'SqlUpdateCommand9
        '
        Me.SqlUpdateCommand9.CommandText = resources.GetString("SqlUpdateCommand9.CommandText")
        Me.SqlUpdateCommand9.Connection = Me.sqlConn
        Me.SqlUpdateCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nSOID", System.Data.SqlDbType.Int, 4, "nSOID"), New System.Data.SqlClient.SqlParameter("@nLineNumber", System.Data.SqlDbType.Int, 4, "nLineNumber"), New System.Data.SqlClient.SqlParameter("@dDateDeposit", System.Data.SqlDbType.DateTime, 4, "dDateDeposit"), New System.Data.SqlClient.SqlParameter("@sOther", System.Data.SqlDbType.NVarChar, 50, "sOther"), New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dDateDeposit", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDateDeposit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nLineNumber", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nSOID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sOther", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOther", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")})
        '
        'SqlDeleteCommand9
        '
        Me.SqlDeleteCommand9.CommandText = "DELETE FROM tDeposits WHERE (ID = @Original_ID) AND (dDateDeposit = @Original_dDa" & _
    "teDeposit) AND (nLineNumber = @Original_nLineNumber) AND (nSOID = @Original_nSOI" & _
    "D) AND (sOther = @Original_sOther)"
        Me.SqlDeleteCommand9.Connection = Me.sqlConn
        Me.SqlDeleteCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_dDateDeposit", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dDateDeposit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nLineNumber", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nLineNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nSOID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nSOID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sOther", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sOther", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daDepositStartEnd
        '
        Me.daDepositStartEnd.DeleteCommand = Me.SqlDeleteCommand9
        Me.daDepositStartEnd.InsertCommand = Me.SqlInsertCommand9
        Me.daDepositStartEnd.SelectCommand = Me.SqlSelectCommand31
        Me.daDepositStartEnd.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tDeposits", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("dDateDeposit", "dDateDeposit"), New System.Data.Common.DataColumnMapping("sOther", "sOther")})})
        Me.daDepositStartEnd.UpdateCommand = Me.SqlUpdateCommand9
        '
        'SqlSelectCommand32
        '
        Me.SqlSelectCommand32.CommandText = "SELECT DISTINCT dDateDeposit FROM tDeposits ORDER BY dDateDeposit DESC"
        Me.SqlSelectCommand32.Connection = Me.sqlConn
        '
        'daDepositDistinctDates
        '
        Me.daDepositDistinctDates.SelectCommand = Me.SqlSelectCommand32
        Me.daDepositDistinctDates.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tDeposits", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("dDateDeposit", "dDateDeposit"), New System.Data.Common.DataColumnMapping("sOther", "sOther")})})
        '
        'SqlSelectCommand33
        '
        Me.SqlSelectCommand33.CommandText = resources.GetString("SqlSelectCommand33.CommandText")
        Me.SqlSelectCommand33.Connection = Me.sqlConn
        '
        'daSOLineNotDeposited
        '
        Me.daSOLineNotDeposited.SelectCommand = Me.SqlSelectCommand33
        Me.daSOLineNotDeposited.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("bTaxable", "bTaxable"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sHidden", "sHidden"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID")})})
        '
        'SqlSelectCommand34
        '
        Me.SqlSelectCommand34.CommandText = resources.GetString("SqlSelectCommand34.CommandText")
        Me.SqlSelectCommand34.Connection = Me.sqlConn
        Me.SqlSelectCommand34.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DateDeposit", System.Data.SqlDbType.DateTime, 4, "dDateDeposit")})
        '
        'daSOLineOneDeposit
        '
        Me.daSOLineOneDeposit.SelectCommand = Me.SqlSelectCommand34
        Me.daSOLineOneDeposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("bTaxable", "bTaxable"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sHidden", "sHidden"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID")})})
        '
        'daSOLineBySOID
        '
        Me.daSOLineBySOID.SelectCommand = Me.SqlSelectCommand40
        Me.daSOLineBySOID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("bTaxable", "bTaxable"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sHidden", "sHidden"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID")})})
        '
        'SqlSelectCommand40
        '
        Me.SqlSelectCommand40.CommandText = "SELECT nSOID, nLineNumber, sDesc, bTaxable, sType, sHidden, nAmount, nAccountID F" & _
    "ROM tSOLine WHERE (nSOID = @SOID) ORDER BY nSOID, nLineNumber"
        Me.SqlSelectCommand40.Connection = Me.sqlConn
        Me.SqlSelectCommand40.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SOID", System.Data.SqlDbType.Int, 4, "nSOID")})
        '
        'daSOHeaderBySOID
        '
        Me.daSOHeaderBySOID.SelectCommand = Me.SqlSelectCommand41
        Me.daSOHeaderBySOID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sSONum", "sSONum"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("dShipped", "dShipped"), New System.Data.Common.DataColumnMapping("sVIA", "sVIA"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShipToCounty", "sShipToCounty"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("dinvoice", "dinvoice"), New System.Data.Common.DataColumnMapping("dsimply", "dsimply"), New System.Data.Common.DataColumnMapping("dmailed", "dmailed"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sOurOrder", "sOurOrder"), New System.Data.Common.DataColumnMapping("sYourOrder", "sYourOrder"), New System.Data.Common.DataColumnMapping("nSimplySequence", "nSimplySequence")})})
        '
        'SqlSelectCommand41
        '
        Me.SqlSelectCommand41.CommandText = resources.GetString("SqlSelectCommand41.CommandText")
        Me.SqlSelectCommand41.Connection = Me.sqlConn
        Me.SqlSelectCommand41.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SOID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'daSOLineBYsSalesperson
        '
        Me.daSOLineBYsSalesperson.SelectCommand = Me.SqlCommand37
        Me.daSOLineBYsSalesperson.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nSOID", "nSOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("bTaxable", "bTaxable"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sHidden", "sHidden"), New System.Data.Common.DataColumnMapping("nAmount", "nAmount"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID")})})
        '
        'SqlCommand37
        '
        Me.SqlCommand37.CommandText = resources.GetString("SqlCommand37.CommandText")
        Me.SqlCommand37.Connection = Me.sqlConn
        Me.SqlCommand37.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sSalesperson", System.Data.SqlDbType.VarChar, 50, "sSalesperson")})
        '
        'daSOHeaderBYsSalesperson
        '
        Me.daSOHeaderBYsSalesperson.SelectCommand = Me.SqlCommand39
        Me.daSOHeaderBYsSalesperson.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tSOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("sSONum", "sSONum"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("sName", "sName"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("dShipped", "dShipped"), New System.Data.Common.DataColumnMapping("sVIA", "sVIA"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShipToCounty", "sShipToCounty"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("dinvoice", "dinvoice"), New System.Data.Common.DataColumnMapping("dsimply", "dsimply"), New System.Data.Common.DataColumnMapping("dmailed", "dmailed"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sOurOrder", "sOurOrder"), New System.Data.Common.DataColumnMapping("sYourOrder", "sYourOrder"), New System.Data.Common.DataColumnMapping("nSimplySequence", "nSimplySequence")})})
        '
        'SqlCommand39
        '
        Me.SqlCommand39.CommandText = resources.GetString("SqlCommand39.CommandText")
        Me.SqlCommand39.Connection = Me.sqlConn
        Me.SqlCommand39.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sSalesperson", System.Data.SqlDbType.VarChar, 50, "sSalesperson")})
        '
        'daPOLineBYsSalesperson
        '
        Me.daPOLineBYsSalesperson.SelectCommand = Me.SqlCommand40
        Me.daPOLineBYsSalesperson.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOLine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nPOID", "nPOID"), New System.Data.Common.DataColumnMapping("nLineNumber", "nLineNumber"), New System.Data.Common.DataColumnMapping("sType", "sType"), New System.Data.Common.DataColumnMapping("sDesc", "sDesc"), New System.Data.Common.DataColumnMapping("nCost", "nCost"), New System.Data.Common.DataColumnMapping("nAccountID", "nAccountID"), New System.Data.Common.DataColumnMapping("sReceived", "sReceived")})})
        '
        'SqlCommand40
        '
        Me.SqlCommand40.CommandText = resources.GetString("SqlCommand40.CommandText")
        Me.SqlCommand40.Connection = Me.sqlConn
        Me.SqlCommand40.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sSalesperson", System.Data.SqlDbType.VarChar, 50, "sSalesperson")})
        '
        'daPOHeaderBYsSalesperson
        '
        Me.daPOHeaderBYsSalesperson.SelectCommand = Me.SqlCommand43
        Me.daPOHeaderBYsSalesperson.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand43
        '
        Me.SqlCommand43.CommandText = resources.GetString("SqlCommand43.CommandText")
        Me.SqlCommand43.Connection = Me.sqlConn
        Me.SqlCommand43.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sSalesperson", System.Data.SqlDbType.VarChar, 50, "sSalesperson")})
        '
        'daJobBYsSalesperson
        '
        Me.daJobBYsSalesperson.SelectCommand = Me.SqlCommand41
        Me.daJobBYsSalesperson.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        '
        'SqlCommand41
        '
        Me.SqlCommand41.CommandText = resources.GetString("SqlCommand41.CommandText")
        Me.SqlCommand41.Connection = Me.sqlConn
        Me.SqlCommand41.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sSalesperson", System.Data.SqlDbType.VarChar, 50, "sSalesperson")})
        '
        'SqlSelectCommand37
        '
        Me.SqlSelectCommand37.CommandText = resources.GetString("SqlSelectCommand37.CommandText")
        Me.SqlSelectCommand37.Connection = Me.sqlConn
        Me.SqlSelectCommand37.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@dateEnd", System.Data.SqlDbType.DateTime, 4, "DateStart"), New System.Data.SqlClient.SqlParameter("@dateStart", System.Data.SqlDbType.DateTime, 4, "DateEnd")})
        '
        'daInstallerDateByStartEnd
        '
        Me.daInstallerDateByStartEnd.SelectCommand = Me.SqlSelectCommand37
        Me.daInstallerDateByStartEnd.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblInstallerDates", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("InstallerID", "InstallerID"), New System.Data.Common.DataColumnMapping("DateStart", "DateStart"), New System.Data.Common.DataColumnMapping("DateEnd", "DateEnd"), New System.Data.Common.DataColumnMapping("sJobNum", "sJobNum"), New System.Data.Common.DataColumnMapping("jobaddress", "jobaddress"), New System.Data.Common.DataColumnMapping("Customer", "Customer"), New System.Data.Common.DataColumnMapping("sales", "sales"), New System.Data.Common.DataColumnMapping("other", "other")})})
        '
        'SqlSelectCommand38
        '
        Me.SqlSelectCommand38.CommandText = resources.GetString("SqlSelectCommand38.CommandText")
        Me.SqlSelectCommand38.Connection = Me.sqlConn
        Me.SqlSelectCommand38.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@sJOBNO", System.Data.SqlDbType.VarChar, 255, "sJobNo")})
        '
        'daJobBysJOBNO
        '
        Me.daJobBysJOBNO.SelectCommand = Me.SqlSelectCommand38
        Me.daJobBysJOBNO.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        '
        'daPOHeaderByBackorderYES
        '
        Me.daPOHeaderByBackorderYES.SelectCommand = Me.SqlCommand9
        Me.daPOHeaderByBackorderYES.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = resources.GetString("SqlCommand9.CommandText")
        Me.SqlCommand9.Connection = Me.sqlConn
        '
        'daJOBByBackorderYES
        '
        Me.daJOBByBackorderYES.SelectCommand = Me.SqlCommand10
        Me.daJOBByBackorderYES.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tJob", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nAddressID", "nAddressID"), New System.Data.Common.DataColumnMapping("sJobDesc", "sJobDesc"), New System.Data.Common.DataColumnMapping("dCreated", "dCreated"), New System.Data.Common.DataColumnMapping("dJobCreated", "dJobCreated"), New System.Data.Common.DataColumnMapping("sJobNo", "sJobNo"), New System.Data.Common.DataColumnMapping("nCustID", "nCustID"), New System.Data.Common.DataColumnMapping("sPhone", "sPhone"), New System.Data.Common.DataColumnMapping("sJobContact", "sJobContact"), New System.Data.Common.DataColumnMapping("sCounty", "sCounty"), New System.Data.Common.DataColumnMapping("nTotalWholesale", "nTotalWholesale"), New System.Data.Common.DataColumnMapping("sBuildingPermit", "sBuildingPermit"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dDrawing", "dDrawing"), New System.Data.Common.DataColumnMapping("nMaterialsCharge", "nMaterialsCharge"), New System.Data.Common.DataColumnMapping("nTaxRate", "nTaxRate"), New System.Data.Common.DataColumnMapping("nLaborCharge", "nLaborCharge"), New System.Data.Common.DataColumnMapping("sContractSigned", "sContractSigned"), New System.Data.Common.DataColumnMapping("sDisclaimerSigned", "sDisclaimerSigned"), New System.Data.Common.DataColumnMapping("sDrawingsSigned", "sDrawingsSigned"), New System.Data.Common.DataColumnMapping("sComplete", "sComplete"), New System.Data.Common.DataColumnMapping("sSalesperson", "sSalesperson"), New System.Data.Common.DataColumnMapping("sOtherNotes", "sOtherNotes"), New System.Data.Common.DataColumnMapping("dCommPaid", "dCommPaid"), New System.Data.Common.DataColumnMapping("sCommLocked", "sCommLocked"), New System.Data.Common.DataColumnMapping("dCrLimit", "dCrLimit"), New System.Data.Common.DataColumnMapping("dAmtYTD", "dAmtYTD"), New System.Data.Common.DataColumnMapping("sInvNotes", "sInvNotes"), New System.Data.Common.DataColumnMapping("lngCommissionStruct", "lngCommissionStruct")})})
        '
        'SqlCommand10
        '
        Me.SqlCommand10.CommandText = resources.GetString("SqlCommand10.CommandText")
        Me.SqlCommand10.Connection = Me.sqlConn
        '
        'daPOByNID
        '
        Me.daPOByNID.SelectCommand = Me.SqlCommand11
        Me.daPOByNID.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tPOHeader", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nID", "nID"), New System.Data.Common.DataColumnMapping("nJobID", "nJobID"), New System.Data.Common.DataColumnMapping("dCreateRecord", "dCreateRecord"), New System.Data.Common.DataColumnMapping("nVendorID", "nVendorID"), New System.Data.Common.DataColumnMapping("sPONum", "sPONum"), New System.Data.Common.DataColumnMapping("sShipTo1", "sShipTo1"), New System.Data.Common.DataColumnMapping("sShipTo2", "sShipTo2"), New System.Data.Common.DataColumnMapping("sShipto3", "sShipto3"), New System.Data.Common.DataColumnMapping("sShipToCity", "sShipToCity"), New System.Data.Common.DataColumnMapping("sShipToState", "sShipToState"), New System.Data.Common.DataColumnMapping("sShipToZip", "sShipToZip"), New System.Data.Common.DataColumnMapping("sShiptoCounty", "sShiptoCounty"), New System.Data.Common.DataColumnMapping("nBoxes", "nBoxes"), New System.Data.Common.DataColumnMapping("dPODate", "dPODate"), New System.Data.Common.DataColumnMapping("sTerms", "sTerms"), New System.Data.Common.DataColumnMapping("dRequired", "dRequired"), New System.Data.Common.DataColumnMapping("sEnteredBy", "sEnteredBy"), New System.Data.Common.DataColumnMapping("nTotal", "nTotal"), New System.Data.Common.DataColumnMapping("sVia", "sVia"), New System.Data.Common.DataColumnMapping("sFOB", "sFOB"), New System.Data.Common.DataColumnMapping("nRetailSale", "nRetailSale"), New System.Data.Common.DataColumnMapping("nSaleAccount", "nSaleAccount"), New System.Data.Common.DataColumnMapping("nRetailFreight", "nRetailFreight"), New System.Data.Common.DataColumnMapping("sConf", "sConf"), New System.Data.Common.DataColumnMapping("nAdd", "nAdd"), New System.Data.Common.DataColumnMapping("DREC", "DREC"), New System.Data.Common.DataColumnMapping("DDEL", "DDEL"), New System.Data.Common.DataColumnMapping("SRECNOTES", "SRECNOTES"), New System.Data.Common.DataColumnMapping("SDELNOTES", "SDELNOTES"), New System.Data.Common.DataColumnMapping("DFAXED", "DFAXED"), New System.Data.Common.DataColumnMapping("nAccount", "nAccount"), New System.Data.Common.DataColumnMapping("nInvNo", "nInvNo"), New System.Data.Common.DataColumnMapping("nCheckNo", "nCheckNo"), New System.Data.Common.DataColumnMapping("dSimply", "dSimply"), New System.Data.Common.DataColumnMapping("bSimply", "bSimply"), New System.Data.Common.DataColumnMapping("nTruck", "nTruck"), New System.Data.Common.DataColumnMapping("sFilter", "sFilter"), New System.Data.Common.DataColumnMapping("sBackOrder", "sBackOrder"), New System.Data.Common.DataColumnMapping("sItems", "sItems"), New System.Data.Common.DataColumnMapping("sItemDesc", "sItemDesc"), New System.Data.Common.DataColumnMapping("sPOType", "sPOType"), New System.Data.Common.DataColumnMapping("nsalesadjust", "nsalesadjust"), New System.Data.Common.DataColumnMapping("sAdjustReason", "sAdjustReason"), New System.Data.Common.DataColumnMapping("sCurActNote", "sCurActNote"), New System.Data.Common.DataColumnMapping("nPOSort", "nPOSort")})})
        '
        'SqlCommand11
        '
        Me.SqlCommand11.CommandText = resources.GetString("SqlCommand11.CommandText")
        Me.SqlCommand11.Connection = Me.sqlConn
        Me.SqlCommand11.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NID", System.Data.SqlDbType.Int, 4, "nID")})
        '
        'JobObj
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(376, 13)
        Me.Name = "JobObj"
        Me.Text = "JobObj"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public PO4040, PO4020, PO4010, PO4030, PO4070 As Decimal
    Public SO4040, SO4020, SO4010, SO4030, SO4070 As Decimal
    Public SOALLITEMS As Decimal

    Friend Function SelectPOByNID(ByVal ds1 As dsTKSI, ByVal NID As Long) As Boolean
        Try

            With ds1
                .tPOHeader.Clear()
                Me.daPOByNID.SelectCommand.Parameters("@NID").Value = NID
                Me.daPOByNID.Fill(.tPOHeader)

            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Friend Function UpdateDepositStartEnd(ByVal ds1 As dsTKSI) As Boolean
        Try
            Me.daDepositStartEnd.Update(ds1.tDeposits)
            ds1.tDeposits.AcceptChanges()
            Return True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
            Return False
        End Try
    End Function

    Friend Sub SelectPaymentDateDistinct(ByVal dt As DataTable)
        dt.Clear()
        Me.daPaymentsDISTINCT.Fill(dt)
    End Sub

    Friend Sub SelectDepositDateDistinct(ByVal dt As DataTable)
        dt.Clear()
        Me.daDepositDistinctDates.Fill(dt)
    End Sub

    Friend Function SelectSOLinesNotDeposited(ByVal ds1 As dsTKSI) As Boolean
        ds1.tSOLine.Clear()
        Me.daSOLineNotDeposited.Fill(ds1.tSOLine)

    End Function

    Friend Function SelectSOLinesOneDeposit(ByVal ds1 As dsTKSI, ByVal dateDeposit As Date) As Boolean
        ds1.tSOLine.Clear()
        Me.daSOLineOneDeposit.SelectCommand.Parameters("@DateDeposit").Value = dateDeposit
        Me.daSOLineOneDeposit.Fill(ds1.tSOLine)

    End Function

    Friend Function UpdateDraw(ByVal ds1 As dsTKSI) As Boolean
        Try
            Me.daDrawsALL.Update(ds1.tDraws)
            ds1.tDraws.AcceptChanges()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
            Return False
        End Try
    End Function

    Friend Function SelectALLData(ByVal ds1 As dsTKSI) As Boolean
        Try
            With ds1
                .tEmployee.Clear()
                Me.daEmployeeALL.Fill(.tEmployee)

                .tDraws.Clear()
                Me.daDrawsALL.Fill(.tDraws)

                '.tblCommissionStructure.Clear()
                'Me.daCommisionStructALL.Fill(.tblCommissionStructure)

                .tAddress.Clear()
                Me.daAddressALL.Fill(.tAddress)

                .tJob.Clear()
                Me.daJobALL.Fill(.tJob)

                .tPOHeader.Clear()
                Me.daPOHeaderALL1.Fill(.tPOHeader)

                .tPOLine.Clear()
                Me.daPOLineALL.Fill(.tPOLine)

                .tSOHeader.Clear()
                Me.daSOHeaderALL.Fill(.tSOHeader)

                .tSOLine.Clear()
                Me.daSOLineALL.Fill(.tSOLine)

                .tVendor.Clear()
                Me.daVendorALL.Fill(.tVendor)

                .tCustomr.Clear()
                Me.daCustomerALL.Fill(.tCustomr)

                .tPayments.Clear()
                Me.daPaymentALL.Fill(.tPayments)
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectBackorderInfo(ByVal ds1 As dsTKSI) As Boolean
        Try
            With ds1

                .tVendor.Clear()
                Me.daVendorALL.Fill(.tVendor)

                .tEmployee.Clear()
                Me.daEmployeeALL.Fill(.tEmployee)

                .tPOHeader.Clear()
                Me.daPOHeaderByBackorderYES.Fill(.tPOHeader)

                .tJob.Clear()
                Me.daJOBByBackorderYES.Fill(.tJob)
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Friend Function SelectCommissionDataNOTJobPOSO(ByVal ds1 As dsTKSI) As Boolean
        Try
            With ds1
                .tEmployee.Clear()
                Me.daEmployeeALL.Fill(.tEmployee)

                .tDraws.Clear()
                Me.daDrawsALL.Fill(.tDraws)

                '.tblCommissionStructure.Clear()
                'Me.daCommisionStructALL.Fill(.tblCommissionStructure)

                .tAddress.Clear()
                Me.daAddressALL.Fill(.tAddress)

                .tVendor.Clear()
                Me.daVendorALL.Fill(.tVendor)

                .tCustomr.Clear()
                Me.daCustomerALL.Fill(.tCustomr)

                .tPayments.Clear()
                Me.daPaymentALL.Fill(.tPayments)
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectALLSOHeaders(ByVal ds1 As dsTKSI) As Boolean
        Try
            With ds1
                .tSOHeader.Clear()
                Me.daSOHeaderALL.Fill(.tSOHeader)
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Friend Function SelectDSIMPLYRangeALLData(ByVal ds1 As dsTKSI, ByVal simplyStart As Date, ByVal simplyEnd As Date) As Boolean
        Try
            With ds1

                .tAddress.Clear()
                Me.daAddressALL.Fill(.tAddress)

                .tJob.Clear()
                Me.daJobDSimply1.SelectCommand.Parameters("@dSimplyStart").Value = simplyStart
                Me.daJobDSimply1.SelectCommand.Parameters("@dSimplyEnd").Value = simplyEnd
                Me.daJobDSimply1.Fill(.tJob)

                .tSOLine.Clear()
                Me.daSOLineDSimply.SelectCommand.Parameters("@dSimplyStart").Value = simplyStart
                Me.daSOLineDSimply.SelectCommand.Parameters("@dSimplyEnd").Value = simplyEnd
                Me.daSOLineDSimply.Fill(.tSOLine)

                .tSOHeader.Clear()
                Me.daSOHeaderDSimply.SelectCommand.Parameters("@dSimplyStart").Value = simplyStart
                Me.daSOHeaderDSimply.SelectCommand.Parameters("@dSimplyEnd").Value = simplyEnd
                Me.daSOHeaderDSimply.Fill(.tSOHeader)

                .tPOHeader.Clear()
                Me.daPOHeaderALL1.Fill(.tPOHeader)

                .tPOLine.Clear()
                Me.daPOLineALL.Fill(.tPOLine)

                .tVendor.Clear()
                Me.daVendorALL.Fill(.tVendor)

                .tCustomr.Clear()
                Me.daCustomerALL.Fill(.tCustomr)

            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectDepositsByDSimply(ByVal ds1 As dsTKSI, ByVal startDate As Date, ByVal endDate As Date) As Boolean
        Try
            ds1.tDeposits.Clear()
            Me.daDepositStartEnd.SelectCommand.Parameters("@StartDate").Value = startDate
            Me.daDepositStartEnd.SelectCommand.Parameters("@EndDate").Value = endDate
            Me.daDepositStartEnd.Fill(ds1.tDeposits)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Friend Function SelectCommissionStruct(ByVal ds1 As dsTKSI) As Boolean
    '    Try
    '        With ds1
    '            .tblCommissionStructure.Clear()
    '            Me.daCommisionStructALL.Fill(.tblCommissionStructure)
    '        End With
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    Friend Function SelectCustomerByName(ByVal ds1 As dsTKSI, ByVal sCust As String) As Boolean
        Try
            With ds1
                .tCustomr.Clear()
                Me.daCustomerBySName.SelectCommand.Parameters("@sname").Value = sCust & "%"
                Me.daCustomerBySName.Fill(.tCustomr)
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Friend Function SelectJobWithSaleDREC2Year(ByVal ds1 As dsTKSI) As Boolean
    '    Try
    '        With ds1
    '            .tJob.Clear()
    '            Me.daJobBySaleDREC2Years.Fill(.tJob)
    '        End With
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    Friend Function UpdatePOandLines1(ByVal DsTKSI1 As dsTKSI) As Boolean
        Try
            With DsTKSI1
                Me.daPOLineALL.Update(.tPOLine)
                .tPOLine.AcceptChanges()
                Me.daPOHeaderALL1.Update(.tPOHeader)
                .tPOHeader.AcceptChanges()
            End With
            Return True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
            Return False
        End Try

    End Function

    Friend Function SelectAddressAndJobByRecentJobs(ByVal DsTKSI1 As dsTKSI) As Boolean
        DsTKSI1.tAddress.Clear()
        Me.daAddressRecent.Fill(DsTKSI1.tAddress)

        DsTKSI1.tJob.Clear()
        Me.daJobRecent.Fill(DsTKSI1.tJob)
    End Function

    Friend Function SelectAllJobAddressCustomerVendor(ByVal ds1 As dsTKSI) As Boolean
        Try
            With ds1
                .tAddress.Clear()
                Me.daAddressALL.Fill(.tAddress)
                .tJob.Clear()
                Me.daJobALLSortCustName.Fill(.tJob)
                .tVendor.Clear()
                Me.daVendorALL.Fill(.tVendor)
                .tCustomr.Clear()
                Me.daCustomerALL.Fill(.tCustomr)
            End With

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Friend Function UpdateShipping(ByVal drPO As dsTKSI.tPOHeaderRow, ByRef dblShip As Double) As Boolean
    '    Try
    '        Dim drPOline As dsTKSI.tPOLineRow
    '        For Each drPOline In drPO.GettPOLineRows
    '            If UCase(drPOline.sType) = "ITEM" And drPOline.nAccountID = 5070 Then
    '                drPOline.nCost = System.Math.Round(dblShip, 2)
    '            End If
    '        Next
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function


    Friend Function SelectJOBPOSOLinesBYsSalesperson(ByVal DsTKSI1 As dsTKSI, ByVal salesperson As String) As Boolean
        Try
            With DsTKSI1
                .tJob.Clear()
                Me.daJobBYsSalesperson.SelectCommand.Parameters("@sSalesperson").Value = salesperson
                Me.daJobBYsSalesperson.SelectCommand.Parameters("@sSalesperson").Value = salesperson
                Me.daJobBYsSalesperson.Fill(.tJob)

                .tSOLine.Clear()
                Me.daSOLineBYsSalesperson.SelectCommand.Parameters("@sSalesperson").Value = salesperson
                Me.daSOLineBYsSalesperson.SelectCommand.Parameters("@sSalesperson").Value = salesperson
                Me.daSOLineBYsSalesperson.Fill(.tSOLine)

                .tSOHeader.Clear()
                Me.daSOHeaderBYsSalesperson.SelectCommand.Parameters("@sSalesperson").Value = salesperson
                Me.daSOHeaderBYsSalesperson.SelectCommand.Parameters("@sSalesperson").Value = salesperson
                Me.daSOHeaderBYsSalesperson.Fill(.tSOHeader)

                .tPOHeader.Clear()
                Me.daPOHeaderBYsSalesperson.SelectCommand.Parameters("@sSalesperson").Value = salesperson
                Me.daPOHeaderBYsSalesperson.SelectCommand.Parameters("@sSalesperson").Value = salesperson
                Me.daPOHeaderBYsSalesperson.Fill(.tPOHeader)

                .tPOLine.Clear()
                Me.daPOLineBYsSalesperson.SelectCommand.Parameters("@sSalesperson").Value = salesperson
                Me.daPOLineBYsSalesperson.SelectCommand.Parameters("@sSalesperson").Value = salesperson
                Me.daPOLineBYsSalesperson.Fill(.tPOLine)

            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectPOandLinesByDateRequiredRange(ByVal DsTKSI1 As dsTKSI, ByVal startdate As Date, ByVal enddate As Date) As Boolean
        Try
            With DsTKSI1
                .tPOHeader.Clear()
                Me.daPOHeaderByDateRequired.SelectCommand.Parameters("@STARTDATE").Value = startdate
                Me.daPOHeaderByDateRequired.SelectCommand.Parameters("@ENDDATE").Value = enddate
                Me.daPOHeaderByDateRequired.Fill(.tPOHeader)

                .tPOLine.Clear()
                Me.daPOLinesByDateRequired.SelectCommand.Parameters("@STARTDATE").Value = startdate
                Me.daPOLinesByDateRequired.SelectCommand.Parameters("@ENDDATE").Value = enddate
                Me.daPOLinesByDateRequired.Fill(.tPOLine)

            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectPOandLinesByBackorderYES(ByVal DsTKSI1 As dsTKSI) As Boolean
        Try
            With DsTKSI1
                .tPOHeader.Clear()
                Me.daPOHeaderSBackorderYES.Fill(.tPOHeader)

                .tPOLine.Clear()
                Me.daPOLinesSBackorderYES.Fill(.tPOLine)
                'fixed from header to line 7/1/10
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectAddressAndJobsAndPOsRECENT(ByVal DsTKSI1 As dsTKSI) As Boolean
        Try
            With DsTKSI1
                .tAddress.Clear()
                Me.daAddressALL.Fill(.tAddress)

                .tJob.Clear()
                Me.daJobALLSortCustName.Fill(.tJob)

                .tPOHeader.Clear()
                Me.daPOHeaderRecent.Fill(.tPOHeader)

                .tPOLine.Clear()
                Me.daPOlinesRecent.Fill(.tPOLine)

                .tVendor.Clear()
                Me.daVendorALL.Fill(.tVendor)

                .tCustomr.Clear()
                Me.daCustomerALL.Fill(.tCustomr)
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectAddressAndJobsAndPOsByDDELNULL(ByVal DsTKSI1 As dsTKSI) As Boolean
        Try
            With DsTKSI1
                .tAddress.Clear()
                Me.daAddressRecent.Fill(.tAddress)

                .tJob.Clear()
                Me.daJobALLSortCustName.Fill(.tJob)

                .tPOHeader.Clear()
                Me.daPODDELnull.Fill(.tPOHeader)

                .tPOLine.Clear()
                Me.daPOLineDDELnull.Fill(.tPOLine)

                .tVendor.Clear()
                Me.daVendorALL.Fill(.tVendor)

                .tCustomr.Clear()
                Me.daCustomerALL.Fill(.tCustomr)
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectAddressAndJobByString(ByVal DsTKSI1 As dsTKSI, ByVal sJobLoc As String) As Boolean
        DsTKSI1.tAddress.Clear()
        With Me.daAddressByName.SelectCommand
            .Parameters("@sLocCode").Value = sJobLoc & "%"
            .Parameters("@sAddress1").Value = sJobLoc & "%"
        End With
        Me.daAddressByName.Fill(DsTKSI1.tAddress)

        DsTKSI1.tJob.Clear()
        With Me.daJobByAddress.SelectCommand
            .Parameters("@sLocCode").Value = sJobLoc & "%"
            .Parameters("@sAddress1").Value = sJobLoc & "%"
        End With
        Me.daJobByAddress.Fill(DsTKSI1.tJob)
    End Function

    Friend Function SelectAddressJobPOSOByAddressID(ByVal dstksi1 As dsTKSI, ByVal AddressID As Long) As Boolean
        Try
            With dstksi1

                '.tblCommissionStructure.Clear()
                'Me.daCommisionStructALL.Fill(.tblCommissionStructure)

                .tAddress.Clear()
                Me.daAddressByNID.SelectCommand.Parameters("@nid").Value = AddressID
                Me.daAddressByNID.Fill(.tAddress)

                .tJob.Clear()
                Me.daJobBYnAddressID.SelectCommand.Parameters("@naddressid").Value = AddressID
                Me.daJobBYnAddressID.Fill(.tJob)

                .tPOHeader.Clear()
                Me.daPOHeaderByNAddressID.SelectCommand.Parameters("@naddressid").Value = AddressID
                Me.daPOHeaderByNAddressID.Fill(.tPOHeader)

                .tSOHeader.Clear()
                Me.daSOHeaderByAddressID.SelectCommand.Parameters("@naddressid").Value = AddressID
                Me.daSOHeaderByAddressID.Fill(.tSOHeader)

                .tVendor.Clear()
                'Me.daVendorALL.SelectCommand.Parameters("@nAddressID").Value = AddressID
                Me.daVendorALL.Fill(.tVendor)

                .tSOLine.Clear()
                Me.daSOLineByNAddressID.SelectCommand.Parameters("@nAddressID").Value = AddressID
                Me.daSOLineByNAddressID.Fill(.tSOLine)

                .tPOLine.Clear()
                Me.daPOLineByNADDRESSID.SelectCommand.Parameters("@nAddressID").Value = AddressID
                Me.daPOLineByNADDRESSID.Fill(.tPOLine)
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    'Friend Function SelectPOSOHeaderByJobID(ByVal dstksi1 As dsTKSI, ByVal JOBID As Long) As Boolean
    '    Try
    '        With dstksi1
    '            .tPOHeader.Clear()
    '            Me.daPOHeaderByNJOBID.SelectCommand.Parameters("@NJOBID").Value = JOBID
    '            Me.daPOHeaderByNJOBID.Fill(.tPOHeader)

    '            .tSOHeader.Clear()
    '            Me.daSOHeaderByNJOBID.SelectCommand.Parameters("@NJOBID").Value = JOBID
    '            Me.daSOHeaderByNJOBID.Fill(.tSOHeader)

    '        End With
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try

    'End Function

    'Friend Function SelectPOSOByDRecNotNullDDelNULL(ByVal dstksi1 As dsTKSI) As Boolean
    '    Try
    '        With dstksi1
    '            .tPOHeader.Clear()
    '            Me.daPOheaderDRECnotNULLDDELnull.Fill(.tPOHeader)

    '            .tSOHeader.Clear()
    '            Me.daSOHeaderDRECnotNULLDDELnull.Fill(.tSOHeader)

    '            .tSOLine.Clear()
    '            Me.daSOLineDRECnotNULLDDELnull.Fill(.tSOLine)

    '            .tPOLine.Clear()
    '            Me.daPOLineDRECnotNULLDDELnull.Fill(.tPOLine)
    '        End With
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    Friend Sub SelectCustomerByJob(ByVal dsTKSI1 As dsTKSI, ByVal CustID As Long)
        dsTKSI1.tCustomr.Clear()
        Me.daCustomerByLID.SelectCommand.Parameters("@LID").Value = CustID
        Me.daCustomerByLID.Fill(dsTKSI1.tCustomr)
    End Sub

    Friend Sub UpdateJobTable(ByVal ds1 As dsTKSI)
        Try
            Me.daPaymentALL.Update(ds1.tPayments)
            ds1.tPayments.AcceptChanges()

            Me.daJobALL.Update(ds1.tJob)
            ds1.tJob.AcceptChanges()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Friend Sub SelectEmployeeTable(ByVal ds1 As dsTKSI)
        ds1.tEmployee.Clear()
        Me.daEmployeeALL.Fill(ds1.tEmployee)
    End Sub

    Friend Function POsByCode(ByRef code As Integer, Optional ByRef requery As Boolean = False) As Decimal
        ' If requery Then InitTotals()
        Select Case code
            Case 4010
                POsByCode = PO4010
            Case 4020
                POsByCode = PO4020
            Case 4030
                POsByCode = PO4030
            Case 4040
                POsByCode = PO4040
            Case 4070
                POsByCode = PO4070
        End Select
    End Function

    Friend Function POCostTotal(ByVal drJob As dsTKSI.tJobRow) As Decimal
        'add all costs for all POs on this job
        Dim tempcost As Decimal = 0
        Dim drPO As dsTKSI.tPOHeaderRow
        For Each drPO In drJob.GettPOHeaderRows
            tempcost += Me.GetPOCost(drPO)
        Next
        Return tempcost
    End Function

    Friend Function POsSalesTotal(ByVal drJob As dsTKSI.tJobRow) As Decimal
        'add all sales for all POs on this job
        Dim tempcost As Decimal = 0
        Dim drPO As dsTKSI.tPOHeaderRow
        For Each drPO In drJob.GettPOHeaderRows
            tempcost += drPO.nRetailSale + drPO.nRetailFreight + drPO.nAdd
        Next
        Return tempcost
    End Function

    Friend Function POsSalesTotal(ByVal drJob As tJob) As Decimal
        'add all sales for all POs on this job
        Dim tempcost As Decimal = 0
        '  Dim drPO As dsTKSI.tPOHeaderRow
        For Each drPO In drJob.tPOHeaders
            tempcost += drPO.nRetailSale + drPO.nRetailFreight + drPO.nAdd
        Next
        Return tempcost
    End Function

    Friend Function AddPO(ByVal drJob As dsTKSI.tJobRow, ByVal ds1 As dsTKSI) As Boolean
        Try
            Dim tempVendor As Integer = 477
            If drJob.GettPOHeaderRows.Length > 0 Then
                tempVendor = drJob.GettPOHeaderRows(0).nVendorID
            End If

            Dim drPO As dsTKSI.tPOHeaderRow
            drPO = ds1.tPOHeader.NewtPOHeaderRow
            With drPO

                .nJobID = drJob.nID
                .nCheckNo = 0
                .nAccount = 4010
                .nAdd = 0
                .nBoxes = 0
                .nInvNo = 0
                .nPOSort = 0
                .nRetailFreight = 0
                .nRetailSale = 0
                .nSaleAccount = 0
                .nsalesadjust = 0
                .nTotal = 0
                .nTruck = 1
                .nVendorID = tempVendor
                .sAdjustReason = ""
                .sBackOrder = ""
                .sTerms = "Net 30"
                .dPODate = Today
                .dRequired = Today.Date
                .sConf = ""
                .sPONum = drJob.sJobNo & "-"
                .sPOType = "PO"
                .SRECNOTES = ""
                .SDELNOTES = ""
                .sFilter = ""
                .sFOB = ""
                .sItemDesc = ""
                .sItems = ""
                .sVia = ""
                .sShipTo1 = ""
                .sShipTo2 = ""
                .sShipToCity = ""
                .sShiptoCounty = ""
                .sShipToState = ""
                .sShipToZip = ""
                .bSimply = False
                .sEnteredBy = ""
                .sCurActNote = ""

                If Not drJob.tAddressRow Is Nothing Then
                    With drJob.tAddressRow
                        drPO.sShipTo1 = .sAddress1 & " " & .sAddress2
                        drPO.sShipTo2 = ""
                        drPO.sShipToCity = .sCity
                        drPO.sShiptoCounty = .sCounty
                        drPO.sShipToState = .sState
                        drPO.sShipToZip = .sZip

                    End With
                End If
                If Not drJob.tCustomrRow Is Nothing Then
                    .sShipto3 = drJob.tCustomrRow.sName
                End If

                ds1.tPOHeader.Rows.Add(drPO)
                Me.daPOHeaderALL1.Update(ds1.tPOHeader)
                ds1.tPOHeader.AcceptChanges()

            End With

            Return True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
            Return False
        End Try
    End Function

    Friend Function AddSO(ByRef sTAXID As String, ByVal drjob As dsTKSI.tJobRow, ByVal ds1 As dsTKSI) As Boolean
        Try
            Dim taxable As Decimal
            'Dim tempVendor, tempSOID As Integer

            Dim drSo As dsTKSI.tSOHeaderRow
            drSo = ds1.tSOHeader.NewtSOHeaderRow
            With drSo
                .nJobID = drjob.nID
                If Not drjob.IsdCreatedNull Then
                    .dinvoice = drjob.dCreated
                Else
                    .dinvoice = Date.Today
                End If
                .nSimplySequence = 0
                .sTerms = drjob.sTerms

                If Not drjob.tAddressRow Is Nothing Then
                    .sShipTo1 = drjob.tAddressRow.sAddress1
                    .sShipTo2 = drjob.tAddressRow.sAddress2
                    .sShipToCity = drjob.tAddressRow.sCity
                    .sShipToCounty = drjob.tAddressRow.sCounty
                    .sShipToState = drjob.tAddressRow.sState
                    .sShipToZip = drjob.tAddressRow.sZip
                End If
                If Not drjob.tCustomrRow Is Nothing Then .sName = drjob.tCustomrRow.sName

                .nCustID = drjob.nCustID
                .sSONum = drjob.sJobNo
                .sFOB = ""
                .sOurOrder = ""
                .sVIA = ""
                .sYourOrder = ""

                .nTotal = 0
                .nTaxRate = 0

            End With
            ds1.tSOHeader.Rows.Add(drSo)
            Me.daSOHeaderALL.Update(ds1.tSOHeader)
            ds1.tSOHeader.AcceptChanges()


            Dim l4010 As Integer
            Dim l4020 As Integer
            Dim l4030 As Integer
            Dim l4040 As Integer
            Dim l4070 As Integer

            If Len(sTAXID) > 3 Then
                l4010 = 4210
                l4020 = 4220
                l4030 = 4230
                l4040 = 4240
                l4070 = 4270
            Else
                l4010 = 4010
                l4020 = 4020
                l4030 = 4030
                l4040 = 4040
                l4070 = 4070
            End If

            Me.InitAccountTotals(drjob)

            AddSOLine(ds1, drSo, "Comment", "Description of Invoice Goes Here")
            AddSOLine(ds1, drSo, "Comment", "")

            If (PO4010) > 0 Or PO4070 > 0 Or PO4030 > 0 Then
                AddSOLine(ds1, drSo, "Item", "Cabinetry", l4010, (PO4010))
                AddSOLine(ds1, drSo, "Comment", "Cabinetry", , (PO4010 + PO4070 + PO4030))
                taxable = taxable + (PO4010)
            End If
            If (PO4020) > 0 Then
                AddSOLine(ds1, drSo, "Item", "Tops", l4020, (PO4020))
                AddSOLine(ds1, drSo, "Comment", "Tops", , (PO4020))
                taxable = taxable + (PO4020)
            End If
            If (PO4030) > 0 Then
                AddSOLine(ds1, drSo, "Item", "Hardware", l4030, (PO4030))
                '    Inv.AddLine "Comment", "Hardware", , (PO4030)
                taxable = taxable + (PO4030)
            End If

            If (PO4070) > 0 Then
                AddSOLine(ds1, drSo, "Item", "Freight", l4070, (PO4070))
                taxable = taxable + (PO4070)
            End If

            If (PO4040) > 0 Then
                AddSOLine(ds1, drSo, "Item", "Labor", l4040, (PO4040))
                AddSOLine(ds1, drSo, "Comment", "Labor", , (PO4040))
            End If

            If taxable > 0 Then
                If Len(sTAXID) > 3 Then
                    AddSOLine(ds1, drSo, "Comment", sTAXID, , 0)
                Else
                    AddTaxItemLinesPerAccountCode(ds1, taxable, drSo)
                    AddSOLine(ds1, drSo, "Comment", "SALES TAX @ " & (Decimal.Round(CDec(drjob.nTaxRate), 2)) & "%", , Decimal.Round(CDec(drjob.nTaxRate * taxable) / 100, 2))
                    AddSOLine(ds1, drSo, "Comment", "")
                    AddSOLine(ds1, drSo, "Balance", "TOTAL", , PO4040 + taxable + Decimal.Round(CDec(drjob.nTaxRate * taxable) / 100, 2))
                End If
            Else
                AddSOLine(ds1, drSo, "Comment", "")
                AddSOLine(ds1, drSo, "Balance", "TOTAL", , PO4040)
            End If

            Return True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
            Return False
        End Try
    End Function

    Public Function SOsByCode(Optional ByRef code As Integer = 9999, Optional ByRef requery As Boolean = False) As Decimal
        '9999 code will give all items with codes in all SOs
        Select Case code
            Case 4010
                SOsByCode = SO4010
            Case 4020
                SOsByCode = SO4020
            Case 4030
                SOsByCode = SO4030
            Case 4040
                SOsByCode = SO4040
            Case 4070
                SOsByCode = SO4070
            Case 9999
                SOsByCode = SOALLITEMS
        End Select
    End Function

    Private Sub AddTaxItemLinesPerAccountCode(ByVal ds1 As dsTKSI, ByVal taxable As Single, ByVal drSO As dsTKSI.tSOHeaderRow)
        ds1.tblJobTax.Clear()
        Me.daJobTaxByNJOBID.SelectCommand.Parameters("@NJOBID").Value = drSO.nJobID
        Me.daJobTaxByNJOBID.Fill(ds1.tblJobTax)
        Dim drJTax As dsTKSI.tblJobTaxRow
        For Each drJTax In ds1.tblJobTax
            AddSOLine(ds1, drSO, "Item", drJTax.TaxName, drJTax.TaxCode, System.Math.Round((drJTax.TaxPercent * taxable) / 100, 2))
        Next
    End Sub

    Private Sub DeleteJobTaxRecord(ByVal ds1 As dsTKSI, ByRef jobid As Integer)
        ds1.tblJobTax.Clear()
        Me.daJobTaxByNJOBID.SelectCommand.Parameters("@NJOBID").Value = jobid
        Me.daJobTaxByNJOBID.Fill(ds1.tblJobTax)
        Dim drJTax As dsTKSI.tblJobTaxRow
        For Each drJTax In ds1.tblJobTax
            drJTax.Delete()
        Next
        Me.daJobTaxByNJOBID.Update(ds1.tblJobTax)
        ds1.tblJobTax.AcceptChanges()
    End Sub

    Friend Sub DeleteJob(ByVal ds1 As dsTKSI, ByVal jobid As Integer)
        Dim drjob As dsTKSI.tJobRow
        drjob = ds1.tJob.FindBynID(jobid)
        If Not drjob Is Nothing Then
            Me.DeleteJobTaxRecord(ds1, jobid)
            drjob.Delete()
        End If
        Me.daJobALL.Update(ds1.tJob)
        ds1.tJob.AcceptChanges()
    End Sub

    Public Sub InitAccountTotals(ByVal drJob As dsTKSI.tJobRow)
        Dim drPO As dsTKSI.tPOHeaderRow
        PO4010 = 0
        PO4020 = 0
        PO4030 = 0
        PO4040 = 0
        PO4070 = 0
        For Each drPO In drJob.GettPOHeaderRows

            Select Case drPO.nAccount
                Case 4010
                    PO4010 = PO4010 + drPO.nRetailSale + drPO.nAdd
                Case 4020
                    PO4020 = PO4020 + drPO.nRetailSale + drPO.nAdd
                Case 4030
                    PO4030 = PO4030 + drPO.nRetailSale + drPO.nAdd
                Case 4040
                    PO4040 = PO4040 + drPO.nRetailSale + drPO.nAdd
            End Select
            PO4070 = PO4070 + drPO.nRetailFreight
        Next

        Dim drSOLine As dsTKSI.tSOLineRow

        SO4010 = 0
        SO4020 = 0
        SO4030 = 0
        SO4040 = 0
        SO4070 = 0
        SOALLITEMS = 0

        Dim drSO As dsTKSI.tSOHeaderRow
        For Each drSO In drJob.GettSOHeaderRows
            For Each drSOLine In drSO.GettSOLineRows
                Select Case drSOLine.nAccountID
                    Case Is > 0
                        SOALLITEMS += drSOLine.nAmount
                    Case 4010
                        SO4010 += drSOLine.nAmount
                    Case 4020
                        SO4020 += drSOLine.nAmount
                    Case 4030
                        SO4030 += drSOLine.nAmount
                    Case 4040
                        SO4040 += drSOLine.nAmount
                    Case 4070
                        SO4070 += drSOLine.nAmount
                End Select
            Next
        Next
    End Sub

    Public Sub InitAccountTotals(ByVal drJob As tJob) ' dsTKSI.tJobRow)
        '   Dim drPO As dsTKSI.tPOHeaderRow
        PO4010 = 0
        PO4020 = 0
        PO4030 = 0
        PO4040 = 0
        PO4070 = 0
        For Each drPO In drJob.tPOHeaders '.GettPOHeaderRows

            Select Case drPO.nAccount
                Case 4010
                    PO4010 = PO4010 + drPO.nRetailSale + drPO.nAdd
                Case 4020
                    PO4020 = PO4020 + drPO.nRetailSale + drPO.nAdd
                Case 4030
                    PO4030 = PO4030 + drPO.nRetailSale + drPO.nAdd
                Case 4040
                    PO4040 = PO4040 + drPO.nRetailSale + drPO.nAdd
            End Select
            PO4070 = PO4070 + drPO.nRetailFreight
        Next

        '    Dim drSOLine As dsTKSI.tSOLineRow

        SO4010 = 0
        SO4020 = 0
        SO4030 = 0
        SO4040 = 0
        SO4070 = 0
        SOALLITEMS = 0

        '  Dim drSO As dsTKSI.tSOHeaderRow
        For Each drSO In drJob.tSOHeaders ' .GettSOHeaderRows
            For Each drSOLine In drSO.tSOLines '.GettSOLineRows
                Select Case drSOLine.nAccountID
                    Case Is > 0
                        SOALLITEMS += drSOLine.nAmount
                    Case 4010
                        SO4010 += drSOLine.nAmount
                    Case 4020
                        SO4020 += drSOLine.nAmount
                    Case 4030
                        SO4030 += drSOLine.nAmount
                    Case 4040
                        SO4040 += drSOLine.nAmount
                    Case 4070
                        SO4070 += drSOLine.nAmount
                End Select
            Next
        Next
    End Sub

    Friend Function GetSOCostByCode(ByVal drSO As dsTKSI.tSOHeaderRow, ByVal vCode As Integer) As Decimal
        Dim temp As Decimal 'temp for total of all Inv lines that have Freight Account Code
        Dim drLine As dsTKSI.tSOLineRow
        For Each drLine In drSO.GettSOLineRows
            If drLine.nAccountID = vCode Then
                temp += drLine.nAmount
            End If
        Next
        Return temp
    End Function

    Friend Function AddSOLine(ByVal ds1 As dsTKSI, ByVal drSO As dsTKSI.tSOHeaderRow, Optional ByVal stype As String = "Comment", Optional ByVal sDesc As String = "", Optional ByVal Account As Integer = 0, Optional ByVal Amount As Decimal = 0) As dsTKSI.tSOLineRow
        Try
            Dim lastLineNo As Integer
            If drSO.GettSOLineRows.Length > 0 Then
                lastLineNo = drSO.GettSOLineRows(drSO.GettSOLineRows.Length - 1).nLineNumber
            Else
                lastLineNo = 0
            End If

            Dim drLine As dsTKSI.tSOLineRow
            drLine = ds1.tSOLine.NewtSOLineRow
            With drLine
                .nSOID = drSO.nID
                .nLineNumber = lastLineNo + 1
                .sDesc = sDesc
                .sType = stype
                .nAmount = Amount
                .nAccountID = Account
                .bTaxable = False
                .sHidden = False
            End With
            ds1.tSOLine.Rows.Add(drLine)
            Me.daSOLineALL.Update(ds1.tSOLine)
            ds1.tSOLine.AcceptChanges()

            Return drLine
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Function

    Friend Sub UpdateSOLine(ByVal ds1 As dsTKSI, ByVal SOid As Integer, ByVal lLinenumber As Integer, Optional ByVal stype As String = "", Optional ByVal sDesc As String = "", Optional ByVal nAccountID As Object = Nothing, Optional ByVal curcost As Object = Nothing)
        Try
            Dim drSOline As dsTKSI.tSOLineRow
            drSOline = ds1.tSOLine.FindBynSOIDnLineNumber(SOid, lLinenumber)
            If Not drSOline Is Nothing Then
                With drSOline
                    .sType = stype
                    .sDesc = sDesc
                    .nAmount = 0
                    If Not curcost Is Nothing Then
                        If IsNumeric(curcost) Then
                            .nAmount = curcost
                        End If
                    End If
                    .nAccountID = nAccountID
                End With
            End If
            Me.daSOLineALL.Update(ds1.tSOLine)
            ds1.tSOLine.AcceptChanges()

        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub UpdateFinanceChargeLineToPO(ByVal nJobID As Integer)
        Dim ds As New dsTKSI
        ds.EnforceConstraints = False

        Dim daSOH As New dsTKSITableAdapters.tSOHeaderTableAdapter
        Dim daSOLine As New dsTKSITableAdapters.tSOLineTableAdapter

        Dim daPOH As New dsTKSITableAdapters.tPOHeaderTableAdapter
        Dim daPOLine As New dsTKSITableAdapters.tPOLineTableAdapter

        Dim dblTotalFinanceChargeNeeded As Decimal = 0
        Dim drSOH As dsTKSI.tSOHeaderRow

        If daSOH.FillByNJobID(ds.tSOHeader, nJobID) > 0 Then
            drSOH = ds.tSOHeader(0)
            Dim drSOLine As dsTKSI.tSOLineRow
            If daSOLine.FillByNSOID(ds.tSOLine, drSOH.nID) > 0 Then
                For Each drSOLine In ds.tSOLine
                    Dim sDescCC As String = drSOLine.sDesc.ToUpper.Replace(" ", "")
                    If sDescCC.Contains("VISA") Or sDescCC.Contains("CREDITCARD") Or sDescCC.Contains("DISCOVER") Or sDescCC.Contains("MASTERCARD") Or sDescCC.Contains("AMEX") Then
                        dblTotalFinanceChargeNeeded += drSOLine.nAmount
                    End If
                Next
            End If
        End If


        If daPOH.FillByNJobID(ds.tPOHeader, nJobID) > 0 Then
            Dim drPO As dsTKSI.tPOHeaderRow
            Dim drPOLine As dsTKSI.tPOLineRow
            For Each drPO In ds.tPOHeader
                daPOLine.FillByNPOID(ds.tPOLine, drPO.nID)
                For Each drPOLine In ds.tPOLine
                    If drPOLine.sType.ToUpper.Contains("ITEM") Then
                        Dim sDescCC As String = drPOLine.sDesc.ToUpper.Replace(" ", "")
                        If sDescCC.Contains("FINANCECHARGE") Or drPOLine.nAccountID = 5570 Then
                            drPOLine.Delete()
                        End If
                    Else
                        'comment line dont bother
                    End If
                Next
                daPOLine.Update(ds.tPOLine)
            Next



            If dblTotalFinanceChargeNeeded <> 0 Then
                drPO = ds.tPOHeader(0)  'if needed add fresh finance charge line to PO
                daPOLine.FillByNPOID(ds.tPOLine, drPO.nID)
                AddPOLine(ds, drPO, "Item", "Finance Charge 3%", Math.Abs(dblTotalFinanceChargeNeeded) * 0.03, 5570)
            End If

        End If

    End Sub

    Friend Sub DeleteSOLine(ByVal ds1 As dsTKSI, ByVal SOid As Integer, ByVal lLinenumber As Integer)
        Dim drSOline As dsTKSI.tSOLineRow
        drSOline = ds1.tSOLine.FindBynSOIDnLineNumber(SOid, lLinenumber)
        If Not drSOline Is Nothing Then
            drSOline.Delete()
        End If
        Me.daSOLineALL.Update(ds1.tSOLine)
        ds1.tSOLine.AcceptChanges()
    End Sub

    Friend Function DeleteSO(ByVal ds1 As dsTKSI, ByVal SOID As Integer) As Boolean
        Try
            Dim drSO As dsTKSI.tSOHeaderRow
            Dim drSOLine As dsTKSI.tSOLineRow
            drSO = ds1.tSOHeader.FindBynID(SOID)
            If Not drSO Is Nothing Then
                For Each drSOLine In drSO.GettSOLineRows
                    drSOLine.Delete()
                Next
                drSO.Delete()
            End If
            Me.daSOLineALL.Update(ds1.tSOLine)
            ds1.tSOLine.AcceptChanges()

            Me.daSOHeaderALL.Update(ds1.tSOHeader)
            ds1.tSOHeader.AcceptChanges()
            Return True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
            Return False
        End Try
    End Function

    Friend Function GetPOCost(ByVal drPO As tPOHeader, Optional ByRef isFactor As String = "") As Decimal
        Dim temp As Decimal = 0
        Dim drPOline As tPOLine
        For Each drPOline In drPO.tPOLines
            If IsNumeric(drPOline.nCost) Then
                If UCase(isFactor) = "YES" Then
                    If drPOline.nAccountID <> 5070 Then
                        temp += drPOline.nCost
                    End If
                Else
                    temp += drPOline.nCost
                End If
            End If
        Next
        Return System.Math.Round(temp, 2)

    End Function

    Friend Function GetPOCostByCode(ByVal drpo As tPOHeader, ByVal vCode As Long) As Decimal

        Dim temp As Decimal = 0
        Dim drPOline As tPOLine
        For Each drPOline In drpo.tPOLines
            If IsNumeric(drPOline.nCost) Then
                If drPOline.nAccountID = vCode Then
                    temp += drPOline.nCost
                End If
            End If
        Next
        Return System.Math.Round(temp, 2)
    End Function

    Friend Function GetPOCost(ByVal drPO As dsTKSI.tPOHeaderRow, Optional ByRef isFactor As String = "") As Decimal
        Dim temp As Decimal = 0
        Dim drPOline As dsTKSI.tPOLineRow
        For Each drPOline In drPO.GettPOLineRows
            If IsNumeric(drPOline.nCost) Then
                If UCase(isFactor) = "YES" Then
                    If drPOline.nAccountID <> 5070 Then
                        temp += drPOline.nCost
                    End If
                Else
                    temp += drPOline.nCost
                End If
            End If
        Next
        Return System.Math.Round(temp, 2)

    End Function

    Friend Function GetPOCostByCode(ByVal drpo As dsTKSI.tPOHeaderRow, ByVal vCode As Long) As Decimal

        Dim temp As Decimal = 0
        Dim drPOline As dsTKSI.tPOLineRow
        For Each drPOline In drpo.GettPOLineRows
            If IsNumeric(drPOline.nCost) Then
                If drPOline.nAccountID = vCode Then
                    temp += drPOline.nCost
                End If
            End If
        Next
        Return System.Math.Round(temp, 2)
    End Function

    'Friend Function posale(ByVal drPO As dsTKSI.tPOHeaderRow, Optional ByRef isFactor As String = "") As Double
    '    Try
    '        posale = drPO.nRetailSale + drPO.nRetailFreight + drPO.nAdd
    '        If UCase(isFactor) = "YES" Then
    '            posale = drPO.nRetailSale + drPO.nAdd
    '        End If
    '    Catch ex As Exception
    '        Return 0
    '    End Try
    'End Function

    Friend Function AddPOLine(ByVal ds1 As dsTKSI, ByVal drPO As dsTKSI.tPOHeaderRow, Optional ByRef stype As String = "", Optional ByRef sDesc As String = "", Optional ByVal nAmount As Decimal = 0, Optional ByVal nAccount As Integer = 0) As dsTKSI.tPOLineRow
        Try
            Dim lastLineNo As Integer
            If drPO.GettPOLineRows.Length > 0 Then
                lastLineNo = drPO.GettPOLineRows(drPO.GettPOLineRows.Length - 1).nLineNumber
            Else
                lastLineNo = 0
            End If

            Dim drLine As dsTKSI.tPOLineRow
            drLine = ds1.tPOLine.NewtPOLineRow
            With drLine
                .nPOID = drPO.nID
                .nLineNumber = lastLineNo + 1
                .sDesc = sDesc
                .sReceived = False
                .sType = stype
                .nAccountID = nAccount
                .nCost = nAmount

            End With
            ds1.tPOLine.Rows.Add(drLine)
            Me.daPOLineALL.Update(ds1.tPOLine)
            ds1.tPOLine.AcceptChanges()
            Return drLine
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("error adding po line. " & ex.Message)
            Return Nothing
        End Try
    End Function

    Friend Sub UpdateShipping(ByVal ds1 As dsTKSI, ByVal drPO As dsTKSI.tPOHeaderRow, ByVal sngShip As Single)
        Try
            Dim drLine As dsTKSI.tPOLineRow
            For Each drLine In drPO.GettPOLineRows
                If UCase(drLine.sType) = "ITEM" And drLine.nAccountID = 5070 Then
                    drLine.nCost = Format(System.Math.Round(sngShip, 2) * drPO.nBoxes, "currency")
                End If
            Next
            Me.daPOLineALL.Update(ds1.tPOLine)
            ds1.tPOLine.AcceptChanges()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Friend Sub UpdatePOLine(ByVal ds1 As dsTKSI, ByRef POID As Integer, ByRef lLinenumber As Integer, ByRef stype As String, ByRef sDesc As String, ByRef curcost As Object, ByRef nAccountID As Object)
        Try
            Dim drLine As dsTKSI.tPOLineRow
            drLine = ds1.tPOLine.FindBynPOIDnLineNumber(POID, lLinenumber)
            If Not drLine Is Nothing Then
                With drLine
                    .sType = stype
                    .sDesc = sDesc
                    .nCost = 0
                    If Not curcost Is Nothing Then
                        If IsNumeric(curcost) Then
                            .nCost = curcost
                        End If
                    End If
                    .nAccountID = nAccountID
                End With
            End If
            Me.daPOLineALL.Update(ds1.tPOLine)
            ds1.tPOLine.AcceptChanges()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
        End Try

    End Sub

    Friend Sub DeletePOLine(ByVal ds1 As dsTKSI, ByRef POID As Integer, ByRef lLinenumber As Integer)
        Dim drline As dsTKSI.tPOLineRow
        drline = ds1.tPOLine.FindBynPOIDnLineNumber(POID, lLinenumber)
        If Not drline Is Nothing Then
            drline.Delete()
        End If
        Me.daPOLineALL.Update(ds1.tPOLine)
        ds1.tPOLine.AcceptChanges()
    End Sub

    Friend Function Factor(ByVal drPO As dsTKSI.tPOHeaderRow) As Decimal

        Dim cost As Decimal
        Dim sale As Decimal
        cost = GetPOCost(drPO, "yes")
        sale = drPO.nRetailSale + drPO.nAdd 'posale(drPO, "yes")
        If sale < cost Or cost = 0 Then
            Factor = 0
        Else
            Factor = System.Math.Round(1 + (sale - cost) / cost, 2)
        End If

    End Function

    Friend Function DeletePO(ByVal ds1 As dsTKSI, ByVal POID As Integer) As Boolean
        Try
            Dim drPO As dsTKSI.tPOHeaderRow
            Dim drPOLine As dsTKSI.tPOLineRow
            drPO = ds1.tPOHeader.FindBynID(POID)
            If Not drPO Is Nothing Then
                For Each drPOLine In drPO.GettPOLineRows
                    drPOLine.Delete()
                Next
                drPO.Delete()
            End If
            Me.daPOLineALL.Update(ds1.tPOLine)
            ds1.tPOLine.AcceptChanges()

            Me.daPOHeaderALL1.Update(ds1.tPOHeader)
            ds1.tPOHeader.AcceptChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function UpdateSO(ByVal ds1 As dsTKSI) As Boolean
        Try
            Me.daSOHeaderALL.Update(ds1.tSOHeader)
            ds1.tSOHeader.AcceptChanges()
            Return True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
            Return False
        End Try
    End Function

    'Friend Function SelectSOPOLinesByJobID(ByVal ds1 As dsTKSI, ByVal JobID As Long) As Boolean
    '    Try
    '        ds1.tSOLine.Clear()
    '        Me.daSOLineByNJOBID.SelectCommand.Parameters("@NJOBID").Value = JobID
    '        Me.daSOLineByNJOBID.Fill(ds1.tSOLine)

    '        ds1.tPOLine.Clear()
    '        Me.daPOLineByNJobID.SelectCommand.Parameters("@NJOBID").Value = JobID
    '        Me.daPOLineByNJobID.Fill(ds1.tPOLine)
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    'Friend Function SelectSOPOHeaderByJobID(ByVal ds1 As dsTKSI, ByVal JobID As Long) As Boolean
    '    Try
    '        ds1.tPOHeader.Clear()
    '        Me.daPOheaderByNJobID.SelectCommand.Parameters("@NJOBID").Value = JobID
    '        Me.daPOheaderByNJobID.Fill(ds1.tPOHeader)

    '        ds1.tSOHeader.Clear()
    '        Me.daSOHeaderByNJOBID.SelectCommand.Parameters("@NJOBID").Value = JobID
    '        Me.daSOHeaderByNJOBID.Fill(ds1.tSOHeader)
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    Friend Function SelectSOandLinesBySOID(ByVal ds1 As dsTKSI, ByVal SOID As Long) As Boolean
        Try
            ds1.tSOLine.Clear()
            Me.daSOLineBySOID.SelectCommand.Parameters("@SOID").Value = SOID
            Me.daSOLineBySOID.Fill(ds1.tSOLine)

            ds1.tSOHeader.Clear()
            Me.daSOHeaderBySOID.SelectCommand.Parameters("@SOID").Value = SOID
            Me.daSOHeaderBySOID.Fill(ds1.tSOHeader)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function updateTaxTables(ByVal dstksi1 As dsTKSI) As Boolean
        Try
            With dstksi1
                Me.daJobALL.Update(.tJob)
                .tJob.AcceptChanges()

                Me.daJobTaxALL.Update(.tblJobTax)
                .tblJobTax.AcceptChanges()

                Me.daTaxDistrictALL.Update(.tblTaxDistrict)
                .tblTaxDistrict.AcceptChanges()

                Me.daTaxRegionAll.Update(.tblTaxRegion)
                .tblTaxRegion.AcceptChanges()

                Me.daTaxJOINALL.Update(.tblTaxJOIN)
                .tblTaxJOIN.AcceptChanges()

            End With
            Return True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
            Return False
        End Try

    End Function

    Friend Function SelectJobAndTaxInfo(ByVal dsTKSI1 As dsTKSI, ByVal JOBID As Long) As Boolean
        Try
            With dsTKSI1
                .tJob.Clear()
                Me.daJobByNID.SelectCommand.Parameters("@nid").Value = JOBID
                Me.daJobByNID.Fill(.tJob)

                .tblTaxDistrict.Clear()
                Me.daTaxDistrictALL.Fill(.tblTaxDistrict)

                .tblJobTax.Clear()
                Me.daJobTaxByNJOBID.SelectCommand.Parameters("@NJOBID").Value = JOBID
                Me.daJobTaxByNJOBID.Fill(.tblJobTax)
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectAllTaxInfo(ByVal dsTKSI1 As dsTKSI) As Boolean
        Try
            With dsTKSI1
                .tblTaxRegion.Clear()
                Me.daTaxRegionAll.Fill(.tblTaxRegion)

                .tblTaxDistrict.Clear()
                Me.daTaxDistrictALL.Fill(.tblTaxDistrict)

                .tblTaxJOIN.Clear()
                Me.daTaxJOINALL.Fill(.tblTaxJOIN)

                .tblJobTax.Clear()
                Me.daJobTaxALL.Fill(.tblJobTax)

            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectCustomersVendors(ByVal ds1 As dsTKSI) As Boolean
        Try
            With ds1
                .tVendor.Clear()
                Me.daVendorALL.Fill(.tVendor)

                .tCustomr.Clear()
                Me.daCustomerALL.Fill(.tCustomr)
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Friend Function SelectJobBySJOBNO(ByVal ds1 As dsTKSI, ByVal sJobNo As String) As Boolean
        Try
            ds1.tJob.Clear()
            Me.daJobBysJOBNO.SelectCommand.Parameters("@SJOBNO").Value = sJobNo
            Me.daJobBysJOBNO.Fill(ds1.tJob)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Friend Function SelectInstallersOnly(ByVal dsTKSI1 As dsTKSI) As Boolean
        Try
            With dsTKSI1
                .tblInstaller.Clear()
                Me.daInstallerALL.Fill(.tblInstaller)

            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectAllInstallerData(ByVal dsTKSI1 As dsTKSI) As Boolean
        Try
            With dsTKSI1
                .tblInstaller.Clear()
                Me.daInstallerALL.Fill(.tblInstaller)

                .tblInstallerDates.Clear()
                Me.daInstallerDatesALL.Fill(.tblInstallerDates)

            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectInstallerDataStartEnd(ByVal dsTKSI1 As dsTKSI, ByVal dateStart As Date) As Boolean

        Try
            Dim dateEnd As Date
            dateEnd = dateStart.AddDays(6)

            With dsTKSI1
                .tblInstaller.Clear()
                Me.daInstallerALL.Fill(.tblInstaller)

                .tblInstallerDates.Clear()
                Me.daInstallerDateByStartEnd.SelectCommand.Parameters("@dateStart").Value = dateStart
                Me.daInstallerDateByStartEnd.SelectCommand.Parameters("@dateEnd").Value = dateEnd
                Me.daInstallerDateByStartEnd.Fill(.tblInstallerDates)

            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function SelectInstallerconflictStartEnd(ByVal dsTKSI1 As dsTKSI, ByVal dateStart As Date, ByVal dateEnd As Date) As Boolean

        Try

            With dsTKSI1
                .tblInstaller.Clear()
                Me.daInstallerALL.Fill(.tblInstaller)

                .tblInstallerDates.Clear()
                Me.daInstallerDatesConflictByDateStartDateEnd.SelectCommand.Parameters("@dateStart").Value = dateStart
                Me.daInstallerDatesConflictByDateStartDateEnd.SelectCommand.Parameters("@dateEnd").Value = dateEnd
                Me.daInstallerDatesConflictByDateStartDateEnd.Fill(.tblInstallerDates)

            End With
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Friend Function UpdateInstallerInfo(ByVal dstksi1 As dsTKSI) As Boolean
        Try
            With dstksi1
                Me.daInstallerDatesALL.Update(.tblInstallerDates)
                .tblInstallerDates.AcceptChanges()

                Me.daInstallerALL.Update(.tblInstaller)
                .tblInstaller.AcceptChanges()

            End With
            Return True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error saving info. " & ex.Message)
            Return False
        End Try

    End Function
End Class
