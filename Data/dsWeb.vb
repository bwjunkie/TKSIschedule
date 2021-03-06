﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class dsWeb
    Inherits DataSet
    
    Private tableJobs As JobsDataTable
    
    Private tableInstaller As InstallerDataTable
    
    Private relationInstallerJobs As DataRelation
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Jobs")) Is Nothing) Then
                Me.Tables.Add(New JobsDataTable(ds.Tables("Jobs")))
            End If
            If (Not (ds.Tables("Installer")) Is Nothing) Then
                Me.Tables.Add(New InstallerDataTable(ds.Tables("Installer")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Jobs As JobsDataTable
        Get
            Return Me.tableJobs
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Installer As InstallerDataTable
        Get
            Return Me.tableInstaller
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsWeb = CType(MyBase.Clone,dsWeb)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Jobs")) Is Nothing) Then
            Me.Tables.Add(New JobsDataTable(ds.Tables("Jobs")))
        End If
        If (Not (ds.Tables("Installer")) Is Nothing) Then
            Me.Tables.Add(New InstallerDataTable(ds.Tables("Installer")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableJobs = CType(Me.Tables("Jobs"),JobsDataTable)
        If (Not (Me.tableJobs) Is Nothing) Then
            Me.tableJobs.InitVars
        End If
        Me.tableInstaller = CType(Me.Tables("Installer"),InstallerDataTable)
        If (Not (Me.tableInstaller) Is Nothing) Then
            Me.tableInstaller.InitVars
        End If
        Me.relationInstallerJobs = Me.Relations("InstallerJobs")
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsWeb"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/dsWeb.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableJobs = New JobsDataTable
        Me.Tables.Add(Me.tableJobs)
        Me.tableInstaller = New InstallerDataTable
        Me.Tables.Add(Me.tableInstaller)
        Dim fkc As ForeignKeyConstraint
        fkc = New ForeignKeyConstraint("InstallerJobs", New DataColumn() {Me.tableInstaller.IDColumn}, New DataColumn() {Me.tableJobs.InstallerIDColumn})
        Me.tableJobs.Constraints.Add(fkc)
        fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None
        fkc.DeleteRule = System.Data.Rule.Cascade
        fkc.UpdateRule = System.Data.Rule.Cascade
        Me.relationInstallerJobs = New DataRelation("InstallerJobs", New DataColumn() {Me.tableInstaller.IDColumn}, New DataColumn() {Me.tableJobs.InstallerIDColumn}, false)
        Me.Relations.Add(Me.relationInstallerJobs)
    End Sub
    
    Private Function ShouldSerializeJobs() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeInstaller() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub JobsRowChangeEventHandler(ByVal sender As Object, ByVal e As JobsRowChangeEvent)
    
    Public Delegate Sub InstallerRowChangeEventHandler(ByVal sender As Object, ByVal e As InstallerRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class JobsDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columngID As DataColumn
        
        Private columnInstallerID As DataColumn
        
        Private columnJobDate As DataColumn
        
        Private columnDetail1 As DataColumn
        
        Private columnDetail2 As DataColumn
        
        Private columnDetail3 As DataColumn
        
        Private columnDetail4 As DataColumn
        
        Private columnDetail5 As DataColumn
        
        Private columnjobEnd As DataColumn
        
        Friend Sub New()
            MyBase.New("Jobs")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property gIDColumn As DataColumn
            Get
                Return Me.columngID
            End Get
        End Property
        
        Friend ReadOnly Property InstallerIDColumn As DataColumn
            Get
                Return Me.columnInstallerID
            End Get
        End Property
        
        Friend ReadOnly Property JobDateColumn As DataColumn
            Get
                Return Me.columnJobDate
            End Get
        End Property
        
        Friend ReadOnly Property Detail1Column As DataColumn
            Get
                Return Me.columnDetail1
            End Get
        End Property
        
        Friend ReadOnly Property Detail2Column As DataColumn
            Get
                Return Me.columnDetail2
            End Get
        End Property
        
        Friend ReadOnly Property Detail3Column As DataColumn
            Get
                Return Me.columnDetail3
            End Get
        End Property
        
        Friend ReadOnly Property Detail4Column As DataColumn
            Get
                Return Me.columnDetail4
            End Get
        End Property
        
        Friend ReadOnly Property Detail5Column As DataColumn
            Get
                Return Me.columnDetail5
            End Get
        End Property
        
        Friend ReadOnly Property jobEndColumn As DataColumn
            Get
                Return Me.columnjobEnd
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As JobsRow
            Get
                Return CType(Me.Rows(index),JobsRow)
            End Get
        End Property
        
        Public Event JobsRowChanged As JobsRowChangeEventHandler
        
        Public Event JobsRowChanging As JobsRowChangeEventHandler
        
        Public Event JobsRowDeleted As JobsRowChangeEventHandler
        
        Public Event JobsRowDeleting As JobsRowChangeEventHandler
        
        Public Overloads Sub AddJobsRow(ByVal row As JobsRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddJobsRow(ByVal gID As System.Guid, ByVal parentInstallerRowByInstallerJobs As InstallerRow, ByVal JobDate As Date, ByVal Detail1 As String, ByVal Detail2 As String, ByVal Detail3 As String, ByVal Detail4 As String, ByVal Detail5 As String, ByVal jobEnd As Date) As JobsRow
            Dim rowJobsRow As JobsRow = CType(Me.NewRow,JobsRow)
            rowJobsRow.ItemArray = New Object() {gID, parentInstallerRowByInstallerJobs(0), JobDate, Detail1, Detail2, Detail3, Detail4, Detail5, jobEnd}
            Me.Rows.Add(rowJobsRow)
            Return rowJobsRow
        End Function
        
        Public Function FindBygID(ByVal gID As System.Guid) As JobsRow
            Return CType(Me.Rows.Find(New Object() {gID}),JobsRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As JobsDataTable = CType(MyBase.Clone,JobsDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New JobsDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columngID = Me.Columns("gID")
            Me.columnInstallerID = Me.Columns("InstallerID")
            Me.columnJobDate = Me.Columns("JobDate")
            Me.columnDetail1 = Me.Columns("Detail1")
            Me.columnDetail2 = Me.Columns("Detail2")
            Me.columnDetail3 = Me.Columns("Detail3")
            Me.columnDetail4 = Me.Columns("Detail4")
            Me.columnDetail5 = Me.Columns("Detail5")
            Me.columnjobEnd = Me.Columns("jobEnd")
        End Sub
        
        Private Sub InitClass()
            Me.columngID = New DataColumn("gID", GetType(System.Guid), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columngID)
            Me.columnInstallerID = New DataColumn("InstallerID", GetType(System.Int64), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnInstallerID)
            Me.columnJobDate = New DataColumn("JobDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnJobDate)
            Me.columnDetail1 = New DataColumn("Detail1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDetail1)
            Me.columnDetail2 = New DataColumn("Detail2", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDetail2)
            Me.columnDetail3 = New DataColumn("Detail3", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDetail3)
            Me.columnDetail4 = New DataColumn("Detail4", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDetail4)
            Me.columnDetail5 = New DataColumn("Detail5", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDetail5)
            Me.columnjobEnd = New DataColumn("jobEnd", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnjobEnd)
            Me.Constraints.Add(New UniqueConstraint("dsTKSIinstallerKey1", New DataColumn() {Me.columngID}, true))
            Me.columngID.AllowDBNull = false
            Me.columngID.Unique = true
        End Sub
        
        Public Function NewJobsRow() As JobsRow
            Return CType(Me.NewRow,JobsRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New JobsRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(JobsRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.JobsRowChangedEvent) Is Nothing) Then
                RaiseEvent JobsRowChanged(Me, New JobsRowChangeEvent(CType(e.Row,JobsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.JobsRowChangingEvent) Is Nothing) Then
                RaiseEvent JobsRowChanging(Me, New JobsRowChangeEvent(CType(e.Row,JobsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.JobsRowDeletedEvent) Is Nothing) Then
                RaiseEvent JobsRowDeleted(Me, New JobsRowChangeEvent(CType(e.Row,JobsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.JobsRowDeletingEvent) Is Nothing) Then
                RaiseEvent JobsRowDeleting(Me, New JobsRowChangeEvent(CType(e.Row,JobsRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveJobsRow(ByVal row As JobsRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class JobsRow
        Inherits DataRow
        
        Private tableJobs As JobsDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableJobs = CType(Me.Table,JobsDataTable)
        End Sub
        
        Public Property gID As System.Guid
            Get
                Return CType(Me(Me.tableJobs.gIDColumn),System.Guid)
            End Get
            Set
                Me(Me.tableJobs.gIDColumn) = value
            End Set
        End Property
        
        Public Property InstallerID As Long
            Get
                Try 
                    Return CType(Me(Me.tableJobs.InstallerIDColumn),Long)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableJobs.InstallerIDColumn) = value
            End Set
        End Property
        
        Public Property JobDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableJobs.JobDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableJobs.JobDateColumn) = value
            End Set
        End Property
        
        Public Property Detail1 As String
            Get
                Try 
                    Return CType(Me(Me.tableJobs.Detail1Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableJobs.Detail1Column) = value
            End Set
        End Property
        
        Public Property Detail2 As String
            Get
                Try 
                    Return CType(Me(Me.tableJobs.Detail2Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableJobs.Detail2Column) = value
            End Set
        End Property
        
        Public Property Detail3 As String
            Get
                Try 
                    Return CType(Me(Me.tableJobs.Detail3Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableJobs.Detail3Column) = value
            End Set
        End Property
        
        Public Property Detail4 As String
            Get
                Try 
                    Return CType(Me(Me.tableJobs.Detail4Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableJobs.Detail4Column) = value
            End Set
        End Property
        
        Public Property Detail5 As String
            Get
                Try 
                    Return CType(Me(Me.tableJobs.Detail5Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableJobs.Detail5Column) = value
            End Set
        End Property
        
        Public Property jobEnd As Date
            Get
                Try 
                    Return CType(Me(Me.tableJobs.jobEndColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableJobs.jobEndColumn) = value
            End Set
        End Property
        
        Public Property InstallerRow As InstallerRow
            Get
                Return CType(Me.GetParentRow(Me.Table.ParentRelations("InstallerJobs")),InstallerRow)
            End Get
            Set
                Me.SetParentRow(value, Me.Table.ParentRelations("InstallerJobs"))
            End Set
        End Property
        
        Public Function IsInstallerIDNull() As Boolean
            Return Me.IsNull(Me.tableJobs.InstallerIDColumn)
        End Function
        
        Public Sub SetInstallerIDNull()
            Me(Me.tableJobs.InstallerIDColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsJobDateNull() As Boolean
            Return Me.IsNull(Me.tableJobs.JobDateColumn)
        End Function
        
        Public Sub SetJobDateNull()
            Me(Me.tableJobs.JobDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDetail1Null() As Boolean
            Return Me.IsNull(Me.tableJobs.Detail1Column)
        End Function
        
        Public Sub SetDetail1Null()
            Me(Me.tableJobs.Detail1Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsDetail2Null() As Boolean
            Return Me.IsNull(Me.tableJobs.Detail2Column)
        End Function
        
        Public Sub SetDetail2Null()
            Me(Me.tableJobs.Detail2Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsDetail3Null() As Boolean
            Return Me.IsNull(Me.tableJobs.Detail3Column)
        End Function
        
        Public Sub SetDetail3Null()
            Me(Me.tableJobs.Detail3Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsDetail4Null() As Boolean
            Return Me.IsNull(Me.tableJobs.Detail4Column)
        End Function
        
        Public Sub SetDetail4Null()
            Me(Me.tableJobs.Detail4Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsDetail5Null() As Boolean
            Return Me.IsNull(Me.tableJobs.Detail5Column)
        End Function
        
        Public Sub SetDetail5Null()
            Me(Me.tableJobs.Detail5Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsjobEndNull() As Boolean
            Return Me.IsNull(Me.tableJobs.jobEndColumn)
        End Function
        
        Public Sub SetjobEndNull()
            Me(Me.tableJobs.jobEndColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class JobsRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As JobsRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As JobsRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As JobsRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class InstallerDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnID As DataColumn
        
        Private columnName As DataColumn
        
        Private columnusername As DataColumn
        
        Private columnpassword As DataColumn
        
        Friend Sub New()
            MyBase.New("Installer")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property IDColumn As DataColumn
            Get
                Return Me.columnID
            End Get
        End Property
        
        Friend ReadOnly Property NameColumn As DataColumn
            Get
                Return Me.columnName
            End Get
        End Property
        
        Friend ReadOnly Property usernameColumn As DataColumn
            Get
                Return Me.columnusername
            End Get
        End Property
        
        Friend ReadOnly Property passwordColumn As DataColumn
            Get
                Return Me.columnpassword
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As InstallerRow
            Get
                Return CType(Me.Rows(index),InstallerRow)
            End Get
        End Property
        
        Public Event InstallerRowChanged As InstallerRowChangeEventHandler
        
        Public Event InstallerRowChanging As InstallerRowChangeEventHandler
        
        Public Event InstallerRowDeleted As InstallerRowChangeEventHandler
        
        Public Event InstallerRowDeleting As InstallerRowChangeEventHandler
        
        Public Overloads Sub AddInstallerRow(ByVal row As InstallerRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddInstallerRow(ByVal ID As Long, ByVal Name As String, ByVal username As String, ByVal password As String) As InstallerRow
            Dim rowInstallerRow As InstallerRow = CType(Me.NewRow,InstallerRow)
            rowInstallerRow.ItemArray = New Object() {ID, Name, username, password}
            Me.Rows.Add(rowInstallerRow)
            Return rowInstallerRow
        End Function
        
        Public Function FindByID(ByVal ID As Long) As InstallerRow
            Return CType(Me.Rows.Find(New Object() {ID}),InstallerRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As InstallerDataTable = CType(MyBase.Clone,InstallerDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New InstallerDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnID = Me.Columns("ID")
            Me.columnName = Me.Columns("Name")
            Me.columnusername = Me.Columns("username")
            Me.columnpassword = Me.Columns("password")
        End Sub
        
        Private Sub InitClass()
            Me.columnID = New DataColumn("ID", GetType(System.Int64), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnID)
            Me.columnName = New DataColumn("Name", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnName)
            Me.columnusername = New DataColumn("username", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnusername)
            Me.columnpassword = New DataColumn("password", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpassword)
            Me.Constraints.Add(New UniqueConstraint("dsTKSIinstallerKey2", New DataColumn() {Me.columnID}, true))
            Me.columnID.AllowDBNull = false
            Me.columnID.Unique = true
        End Sub
        
        Public Function NewInstallerRow() As InstallerRow
            Return CType(Me.NewRow,InstallerRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New InstallerRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(InstallerRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.InstallerRowChangedEvent) Is Nothing) Then
                RaiseEvent InstallerRowChanged(Me, New InstallerRowChangeEvent(CType(e.Row,InstallerRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.InstallerRowChangingEvent) Is Nothing) Then
                RaiseEvent InstallerRowChanging(Me, New InstallerRowChangeEvent(CType(e.Row,InstallerRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.InstallerRowDeletedEvent) Is Nothing) Then
                RaiseEvent InstallerRowDeleted(Me, New InstallerRowChangeEvent(CType(e.Row,InstallerRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.InstallerRowDeletingEvent) Is Nothing) Then
                RaiseEvent InstallerRowDeleting(Me, New InstallerRowChangeEvent(CType(e.Row,InstallerRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveInstallerRow(ByVal row As InstallerRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class InstallerRow
        Inherits DataRow
        
        Private tableInstaller As InstallerDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableInstaller = CType(Me.Table,InstallerDataTable)
        End Sub
        
        Public Property ID As Long
            Get
                Return CType(Me(Me.tableInstaller.IDColumn),Long)
            End Get
            Set
                Me(Me.tableInstaller.IDColumn) = value
            End Set
        End Property
        
        Public Property Name As String
            Get
                Try 
                    Return CType(Me(Me.tableInstaller.NameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableInstaller.NameColumn) = value
            End Set
        End Property
        
        Public Property username As String
            Get
                Try 
                    Return CType(Me(Me.tableInstaller.usernameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableInstaller.usernameColumn) = value
            End Set
        End Property
        
        Public Property password As String
            Get
                Try 
                    Return CType(Me(Me.tableInstaller.passwordColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableInstaller.passwordColumn) = value
            End Set
        End Property
        
        Public Function IsNameNull() As Boolean
            Return Me.IsNull(Me.tableInstaller.NameColumn)
        End Function
        
        Public Sub SetNameNull()
            Me(Me.tableInstaller.NameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsusernameNull() As Boolean
            Return Me.IsNull(Me.tableInstaller.usernameColumn)
        End Function
        
        Public Sub SetusernameNull()
            Me(Me.tableInstaller.usernameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IspasswordNull() As Boolean
            Return Me.IsNull(Me.tableInstaller.passwordColumn)
        End Function
        
        Public Sub SetpasswordNull()
            Me(Me.tableInstaller.passwordColumn) = System.Convert.DBNull
        End Sub
        
        Public Function GetJobsRows() As JobsRow()
            Return CType(Me.GetChildRows(Me.Table.ChildRelations("InstallerJobs")),JobsRow())
        End Function
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class InstallerRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As InstallerRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As InstallerRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As InstallerRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
