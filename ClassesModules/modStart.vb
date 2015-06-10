Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports System.Drawing
Imports Sage.Peachtree.API
Imports System.Net.Mail

Module modStart
    Public Login As String
    Public Password As String
    Public cnJob As String
    Public cnSQL As String
    Public strDatabasePath As String
    Public strWorkgroupPath As String
    Public user1 As tUser ' sUsername As String

    Public sPassword As String
    Public sUserlevel As UserRights
    Public sImagesPath As String
    Public global_sCreditPathImagesPath As String
    Public cWhite As Color = Color.White
    Public cYellow As Color = Color.Yellow
    Public global_ScreenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
    Public global_ScreenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
    Public global_largerFontsInUse As Boolean = False
    Public global_OldGridNewGridRation As Integer = 14
    Public ISDebugMachine As Boolean = False

    Public global_TempReportFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)

    Public ReadOnly Property global_Username As String
        Get
            Return user1.Username.ToUpper
        End Get
    End Property

    Private _usernickname As String
    Public ReadOnly Property global_Nickname As String
        Get
            Dim criteria = global_Username
            If criteria = "JOSH" Then
                '  criteria = "JEREMY PFAFF"
            End If
            If _usernickname IsNot Nothing AndAlso _usernickname.Length > 0 Then

            Else
                Dim dc As linqTKSIDataContext = GetLinqDataContext()

                Dim q = (From row In dc.tEmployees Where row.nickname.ToUpper.Contains(criteria))
                If q.Count = 1 Then
                    _usernickname = q.Single.nickname
                Else
                    Dim usersplit = criteria.Split(" ")
                    If usersplit.Length > 1 Then
                        Dim qLastname = (From row In dc.tEmployees Where row.sName.ToUpper.EndsWith(usersplit.Last.ToUpper))
                        If qLastname.Count = 1 Then
                            _usernickname = qLastname.Single.nickname
                        End If
                    End If
                End If
            End If

            Return _usernickname

        End Get
    End Property

    Public Function global_TestNetworkConnectionFAILED() As Boolean
        Try
            Dim linqTest = GetLinqDataContext()
            linqTest.CommandTimeout = 1
            Dim q = (From row In linqTest.tJobs Where row.nID = 0)
            If q.Count > 0 Then

            End If
            Return False

        Catch ex As Exception
            Return True
        End Try

    End Function

    Public Structure POLineTypes
        Const ITEM As String = "ITEM"
        Const COMMENT As String = "COMMENT"
    End Structure

    Public Structure POTypes
        Const SWO_JOBCOST = "SWO-JOBCOST"
        Const PO = "PO"
        Const JOBCOST = "JOBCOST"
    End Structure

    Public Structure JobActivityTypes
        Const WaitingOnSalesperson = "WAITING ON SALESPERSON"
    End Structure

    Sub SetupImagePathsAndConnectionStrings()
        Try
            '   sUserlevel = UserRights.Admin
            If Environment.MachineName.ToUpper.Contains("JOSH-14") Or Environment.MachineName.ToUpper.Contains("DELL-SERVER") Then
                '  ISDebugMachine = True
            End If

            cnSQL = My.Settings.TKSIJOBSConnectionString
            cnJob = "provider=sqloledb;" & My.Settings.TKSIJOBSConnectionString

            sImagesPath = "\\192.168.10.8\ACCOUNTING\PO\images\"
            global_sCreditPathImagesPath = "\\192.168.10.8\ACCOUNTING\PO\CREDIT\"

            If Not IO.Directory.Exists(sImagesPath) Then
                global_EmailErrorLog("image path not available " & sImagesPath)
            End If
        Catch ex As Exception
            MessageBox.Show("error setting up Image Paths " & ex.Message)
        End Try



    End Sub

    Public Sub global_EmailErrorLog(_msg As String)

        Try
            Dim machine = " Unknown machine name "
            Try
                machine = Environment.MachineName
                If machine.ToUpper = "JOSH-14" Then
                    Exit Sub
                End If
            Catch
            End Try

            Dim address As New MailAddressCollection
            ' address.Add(New MailAddress("jason@thekitchenshowcase.com"))
            ' address.Add(New MailAddress("mark@thekitchenshowcase.com"))
            address.Add(New MailAddress("josh@coolbluewater.org"))

            Dim mail1 As New MailMessage
            Dim add As MailAddress
            For Each add In address
                mail1.To.Add(add)
            Next

            mail1.From = New MailAddress("Server <josh@coolbluewater.org>")
            mail1.Subject = Mid(_msg, 1, 30)
            mail1.Body = machine & Environment.NewLine & _msg

            Dim smtp As New SmtpClient()
            smtp.Host = "smtpout.secureserver.net"
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New System.Net.NetworkCredential("josh@coolbluewater.org", "valeskascarlet")
            smtp.Port = 25
            smtp.Send(mail1)

            Try
                smtp.Dispose()
            Catch
            End Try

        Catch ex As Exception
        End Try

    End Sub

    Public Enum UserRights
        Payroll = 1
        Admin = 2
        AdminAsst = 3
        Shipping = 4
        Sales = 5
    End Enum

    Public Function IsDate2(ByVal str As String) As Boolean
        Try
            If str.Trim.Length > 4 Then
                If IsDate(str) Then
                    Return True
                End If
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function TwoDecimal(ByVal str As Double) As String
        Return Replace(Format(str, "currency"), "$", "")
    End Function

    Public Function TwoDecimal(ByVal str As Decimal) As String
        Return Replace(Format(str, "currency"), "$", "").Replace("(", "-").Replace(")", "")
    End Function

    Public Function TwoDecimal(ByVal str As String) As String
        If IsNumeric(str) Then
            Return Replace(Format(str, "currency"), "$", "")
        Else
            Return "-0"
        End If
    End Function

    Public Function UpdateSimply(ByVal drPO As tPOHeader, discount As Decimal) As Boolean
        Dim SageTools As New clsSageAccountingTools
        Try
            Return SageTools.NewPO(drPO, discount)
        Catch ex As Exception
            MessageBox.Show("sage error: " & ex.Message)
        Finally
            SageTools.Dispose()
        End Try
    End Function

    Public Function UpdateSimply(ByVal drPO As dsTKSI.tPOHeaderRow, discount As Decimal) As Boolean
        Dim SageTools As New clsSageAccountingTools
        Try
            Return SageTools.NewPO(drPO, discount)
        Catch ex As Exception
            MessageBox.Show("sage error: " & ex.Message)
        Finally
            SageTools.Dispose()
        End Try
    End Function

    Public Function Get15thOr30thWhicheverIsCloserToToday() As Date
        Dim thisMonth15th As Date = Date.Parse(Now.Month & "/15/" & Now.Year)
        Dim thisMonth30th As Date = Date.Parse(Now.Month & "/" & Date.DaysInMonth(Now.Year, Now.Month) & "/" & Now.Year)
        Dim iDateDiff15th As Integer = DateDiff(DateInterval.Day, thisMonth15th, Now)
        Dim iDateDiff30th As Integer = DateDiff(DateInterval.Day, thisMonth30th, Now)

        If iDateDiff15th > iDateDiff30th Then
            Return thisMonth30th
        Else
            Return thisMonth15th
        End If
    End Function

    Public Function global_POSortable(_PO As String) As String
        Try
            Dim dashPO As String() = _PO.Split("-")
            If dashPO.Count > 1 Then
                Dim beforeDash As String = dashPO(0)
                Dim afterDash As String = dashPO(1)
                If IsNumeric(afterDash) Then

                Else
                    afterDash = afterDash.Replace("SWO", "").Replace("BO", "").Replace("A", "").Replace("B", "").Replace("E", "").Replace("W", "")
                End If
                Return beforeDash.PadLeft(8, "0") & afterDash.PadLeft(5, "0")
            Else
                Return _PO
            End If
        Catch ex As Exception
            Return _PO
        End Try


    End Function

    Public Function global_DefaultPrinter() As String
        Try
            Dim settings1 As New Printing.PrinterSettings
            Return settings1.PrinterName
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function GetLetterPaperEnum(ByVal print1 As System.Drawing.Printing.PageSettings, Optional ByVal sizeName As String = "Letter") As Integer
        Try
            Dim i As Integer
            For i = 0 To print1.PrinterSettings.PaperSizes.Count - 1
                If InStr(print1.PrinterSettings.PaperSizes(i).PaperName, sizeName) > 0 Then
                    Return i
                End If
            Next
            Return -1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function LocationToShortName(ByVal strLoc As String) As String
        Try
            Dim strAppenToLine As String
            strAppenToLine = Mid(strLoc, 1, 1)
            strAppenToLine = strAppenToLine & Replace(Mid(strLoc, strLoc.Length - 1, 3), "-", "")
            Return strAppenToLine
        Catch ex As Exception
            Return "ERR"
        End Try

    End Function

    Public Function ConvertRtfToText(ByVal input As String) As String

        Dim returnValue As String = String.Empty
        Dim converter As New System.Windows.Forms.RichTextBox()
        converter.Rtf = input
        returnValue = converter.Text
        Return returnValue

    End Function

    Public Function GetNextImageNumber(ByVal NumericJobNum As String, NumbericJobWithLetter As String) As String
        'If ISDebugMachine Then
        '    sImagesPath = "C:\tksi\images\"
        'End If
        Dim i As Integer = 1
        For i = 1 To 100
            Dim strFullImagePath As String = sImagesPath & NumericJobNum & "\" & NumbericJobWithLetter & "\"
            If IO.Directory.Exists(strFullImagePath) Then
                If File.Exists(strFullImagePath & i & ".TIF") Or File.Exists(strFullImagePath & i & ".JPG") Then
                    'allow loop to continue testing next file number for existence
                Else
                    Return i
                End If
            Else
                'no directory exists, so the first image number will be 1, users of this function should create their own directories as needed
                Return 1
            End If
        Next

    End Function

    Public Function global_ColorFromHex(b1 As Byte, b2 As Byte, b3 As Byte) As Color
        Return Color.FromArgb(Convert.ToInt32(b1), Convert.ToInt32(b2), Convert.ToInt32(b3))

    End Function

    Public Function HasWordInstalled() As Boolean
        Try
            Dim oWord As New Word.Application
            Try
                oWord = Nothing
            Catch
            End Try
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub getPOTotals(ByRef drJob As TKSIJOBSDataSet.tJobRow, ByRef SALE4010 As Decimal, ByRef SALE4030 As Decimal, ByRef SALE4040 As Decimal, ByRef SALE4070 As Decimal, ByRef SALETOTAL As Decimal, ByRef COST5010 As Decimal, ByRef COST5030 As Decimal, ByRef COST5040 As Decimal, ByRef COST5070 As Decimal, ByRef COST5490 As Decimal, ByRef COSTTOTAL As Decimal)

        Dim drPO As TKSIJOBSDataSet.tPOHeaderRow
        For Each drPO In drJob.GettPOHeaderRows

            If UCase(drPO.sPOType) = "PO" Or UCase(drPO.sPOType) = "SWO-JOBCOST" Or UCase(drPO.sPOType) = "JOBCOST" Then
                Select Case drPO.nAccount
                    Case 4010
                        SALE4010 += +drPO.nRetailSale + drPO.nAdd
                    Case 4020 'TOPS AND CABINETRY GO TOGETHER ON THIS SUMMARY 4010 and 4020
                        SALE4010 += drPO.nRetailSale + drPO.nAdd
                    Case 4030
                        SALE4030 += +drPO.nRetailSale + drPO.nAdd
                    Case 4040
                        SALE4040 += +drPO.nRetailSale + drPO.nAdd
                End Select
                SALETOTAL = SALETOTAL + drPO.nRetailSale + drPO.nAdd
                SALE4070 = SALE4070 + drPO.nRetailFreight

                Dim drPOLine As TKSIJOBSDataSet.tPOLineRow

                For Each drPOLine In drPO.GettPOLineRows
                    If UCase(drPOLine.sType) = "ITEM" Then

                        Select Case drPOLine.nAccountID
                            Case 5010
                                COST5010 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5270
                                COST5010 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5020
                                COST5010 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5030
                                COST5030 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5040
                                COST5040 += drPOLine.nCost
                                COSTTOTAL += drPOLine.nCost

                            Case 5070
                                COST5070 += drPOLine.nCost
                                'somehow only include cost for shipping on PO that is a jobcost
                                'for jobs starting 2006 and newer
                                'does sale need to be included?
                                If drJob.dJobCreated > CDate("1/1/2006") Then
                                    If UCase(drPO.sPOType) = "SWO-JOBCOST" Or UCase(drPO.sPOType) = "JOBCOST" Then
                                        COSTTOTAL += drPOLine.nCost
                                    End If
                                End If
                            Case 5490
                                If drPO.dPODate > CDate("11/1/2012") Then
                                    COST5490 += drPOLine.nCost
                                End If
                                COSTTOTAL += drPOLine.nCost
                            Case Else
                                COST5010 += drPOLine.nCost
                                COSTTOTAL += +drPOLine.nCost

                        End Select
                    End If
                Next
            End If
        Next
    End Sub

    Public Function GetLinqDataContext() As linqTKSIDataContext
        Try

            Dim dc As New linqTKSIDataContext(cnSQL)
            Return dc
        Catch
            Try
                System.Threading.Thread.Sleep(1000)
                Dim dc As New linqTKSIDataContext(cnSQL)
                Return dc
            Catch
                MessageBox.Show("Cannot connect to server, wait a few seconds and try again.")
            End Try

        End Try

    End Function

    Public Function GetDateRequired(sPO As String) As String
        Try
            Dim dc As linqTKSIDataContext = GetLinqDataContext()
            Dim q = (From row In dc.tPOHeaders Where row.sPONum.StartsWith(sPO.Trim))
            If q.Count > 0 Then
                If q.First.dRequired IsNot Nothing Then
                    Return q.First.dRequired
                End If
            End If
            Return "not found"
        Catch ex As Exception
            Return "not found"
        End Try

    End Function

    Public Sub OpenJobScreen(_naddressID As Integer, _njobID As Integer, _blnModal As Boolean)
        Try
            Dim job1 As New winJob
            job1.LoadJob(_naddressID, _njobID)
            If _blnModal Then
                job1.ShowDialog()
            Else
                job1.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("error opening new job screen" & ex.Message)

        End Try

    End Sub

    Public Sub OpenPOScreen(_poid As Integer, _blnModal As Boolean)

        Dim po As New winPO
        po.LoadPO(_poid)
        If _blnModal Then
            po.ShowDialog()
        Else
            po.Show()
        End If

    End Sub

    Private TimerStart As Date = Now.AddYears(10)  'means there is no start time and no timer has been started, since it will be greater than the end time
    Public Sub StartTimer()
        TimerStart = Now  'now we have a valid start time, so the end timer will recognize a usable start value
    End Sub

    Public Sub EndTimer(_TimeLimitSeconds As Integer, _msg As String)
        Dim now2 As Date = Now
        If now2 > TimerStart Then
            Dim elapsed1 As TimeSpan = now2 - TimerStart
            TimerStart = Now.AddYears(10)
            If elapsed1 > New TimeSpan(0, 0, _TimeLimitSeconds) Then
                global_EmailErrorLog(_msg & " " & elapsed1.TotalSeconds & " mill: " & elapsed1.TotalMilliseconds)
            End If
        Else
            'no timer has been started yet so no need to compare anything
        End If
    End Sub

End Module
