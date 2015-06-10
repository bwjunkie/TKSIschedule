Imports Sage.Peachtree.API

Public Class clsSageAccountingTools
    Implements IDisposable

    Dim sageSession As Sage.Peachtree.API.PeachtreeSession
    Dim company1 As Company
    Dim comp1 As Sage.Peachtree.API.CompanyIdentifier

    Dim accountList1 As AccountList
    Private Function GetAccount(_strAccountID As String) As EntityReference(Of Account)
        If accountList1 Is Nothing Then
            accountList1 = company1.Factories.AccountFactory.List
            accountList1.Load()
        End If
        For Each acc In accountList1
            If acc.ID = _strAccountID Then
                Return acc.Key
            End If
        Next
        Return accountList1.First.Key
    End Function

    Public Function CompanyLoaded() As Boolean
        If company1 Is Nothing Then
            Return False
        End If
        Return True
    End Function

    Dim vendorList1 As VendorList
    Private Function GetVendor(_strVenName As String) As Vendor
        If vendorList1 Is Nothing Then
            vendorList1 = company1.Factories.VendorFactory.List
            vendorList1.Load()
        End If
        For Each ven In vendorList1
            If ven.Name.ToUpper.Trim = _strVenName.ToUpper.Trim Then
                Return ven
            End If
        Next
        For Each ven In vendorList1
            If ven.Name.ToUpper.Trim.StartsWith("THE KITCHEN SHOWCASE") Then
                Return ven
            End If
        Next
        Return vendorList1.First
    End Function

    Dim custList1 As CustomerList
    Private Function GetCustomer(_strCustName As String) As EntityReference(Of Customer)
        If custList1 Is Nothing Then
            custList1 = company1.Factories.CustomerFactory.List
            custList1.Load()
        End If
        For Each cust In custList1
            If Mid(cust.Name.ToUpper.Trim.Replace(" ", ""), 1, 28) = Mid(_strCustName.ToUpper.Trim.Replace(" ", ""), 1, 28) Then
                Return cust.Key
            End If
        Next

        Throw New Exception("Customer not found, you may need to manually add/edit this customer in Sage, with the name spelled the same: " & custList1.First.Name & ", then retry sending.")

    End Function

    Public Function NewPO(ByVal _poTK As tPOHeader, ByVal _discount As Decimal) As Boolean
        Dim ven1 As Vendor = GetVendor(_poTK.tVendor.sName)
        Dim po As PurchaseOrder = company1.Factories.PurchaseOrderFactory.Create
        With po

            .Date = _poTK.dPODate

            .GoodThroughDate = Now.AddMonths(6)
            .TermsDescription = _poTK.sTerms
            .ReferenceNumber = _poTK.sPONum
            .VendorReference = ven1.Key 'GetVendor(poTK.tVendorRow.sName)
            .AccountReference = GetAccount(2050)
            Try
                .ShipToAddress.Address = ven1.MailToContact.Address
            Catch ex As Exception
                .ShipToAddress.Address = ven1.Contacts.First.Address
            End Try
        End With

        Dim TotalForDiscount As Decimal = 0

        For Each poLineTK In (From row In _poTK.tPOLines Order By row.nLineNumber Where row.nAccountID > 0 And row.sType.ToUpper.Trim = "ITEM")
            Dim poline As PurchaseOrderLine = po.AddLine
            With poline

                .Quantity = 1
                .UnitPrice = poLineTK.nCost
                .Amount = Decimal.Round(CDec(poLineTK.nCost), 2) ' .CalculateAmount(1, 1.3)
                .Amount = .CalculateAmount(1, Decimal.Round(CDec(poLineTK.nCost), 2))
                .Description = poLineTK.sDesc
                .AccountReference = GetAccount(poLineTK.nAccountID)
                If .Validate Then
                Else
                    MessageBox.Show("did not validate?")
                End If

                If poLineTK.nAccountID = 5010 Or poLineTK.nAccountID = 5020 Or poLineTK.nAccountID = 5270 Or poLineTK.nAccountID = 5260 Then
                    TotalForDiscount = TotalForDiscount + poLineTK.nCost
                End If

            End With
        Next

        If TotalForDiscount > 0 And _discount > 0 Then

            Dim dicountAmount As Decimal = -(System.Math.Round((TotalForDiscount * _discount) / 100, 2))
            Dim poline As PurchaseOrderLine = po.AddLine
            With poline

                .Quantity = 1
                .UnitPrice = dicountAmount
                .Amount = dicountAmount

                .Description = "Net 10 Discount"
                .AccountReference = GetAccount(4700)

                If .Validate Then
                Else
                    Throw New Exception("did not validate?")
                End If
            End With

        End If

        If po.PurchaseOrderLines.Count > 0 Then
            If po.Validate Then
            Else
                Throw New Exception("did not validate in Sage")
            End If

            po.Save()
            Return True
        Else
            Throw New Exception("no PO lines to send to Sage")
        End If

        Return False

    End Function

    Public Function NewPO(ByVal poTK As dsTKSI.tPOHeaderRow, ByVal discount As Decimal) As Boolean

        Dim ven1 As Vendor = GetVendor(poTK.tVendorRow.sName)
        Dim po As PurchaseOrder = company1.Factories.PurchaseOrderFactory.Create
        With po

            .Date = poTK.dPODate

            .GoodThroughDate = Now.AddMonths(6)
            .TermsDescription = poTK.sTerms
            .ReferenceNumber = poTK.sPONum
            .VendorReference = ven1.Key 'GetVendor(poTK.tVendorRow.sName)
            .AccountReference = GetAccount(2050)
            Try
                .ShipToAddress.Address = ven1.MailToContact.Address
            Catch ex As Exception
                .ShipToAddress.Address = ven1.Contacts.First.Address
            End Try
        End With

        Dim TotalForDiscount As Decimal = 0

        For Each poLineTK In (From row In poTK.GettPOLineRows Order By row.nLineNumber Where row.nAccountID > 0 And row.sType.ToUpper.Trim = "ITEM")
            Dim poline As PurchaseOrderLine = po.AddLine
            With poline

                .Quantity = 1
                .UnitPrice = poLineTK.nCost
                .Amount = Decimal.Round(CDec(poLineTK.nCost), 2) ' .CalculateAmount(1, 1.3)
                .Amount = .CalculateAmount(1, Decimal.Round(CDec(poLineTK.nCost), 2))
                .Description = poLineTK.sDesc
                .AccountReference = GetAccount(poLineTK.nAccountID)
                If .Validate Then
                Else
                    MessageBox.Show("did not validate?")
                End If

                If poLineTK.nAccountID = 5010 Or poLineTK.nAccountID = 5020 Or poLineTK.nAccountID = 5270 Or poLineTK.nAccountID = 5260 Then
                    TotalForDiscount = TotalForDiscount + poLineTK.nCost
                End If

            End With
        Next

        If TotalForDiscount > 0 And discount > 0 Then

            Dim dicountAmount As Decimal = -(System.Math.Round((TotalForDiscount * discount) / 100, 2))
            Dim poline As PurchaseOrderLine = po.AddLine
            With poline

                .Quantity = 1
                .UnitPrice = dicountAmount
                .Amount = dicountAmount

                .Description = "Net 10 Discount"
                .AccountReference = GetAccount(4700)

                If .Validate Then
                Else
                    Throw New Exception("did not validate?")
                End If
            End With

        End If

        If po.PurchaseOrderLines.Count > 0 Then
            If po.Validate Then
            Else
                Throw New Exception("did not validate in Sage")
            End If

            po.Save()
            Return True
        Else
            Throw New Exception("no PO lines to send to Sage")
        End If

        Return False

    End Function

    Public Sub New()
        StartSageSession()
    End Sub

    Public Function NewInvoice(soTK As tSOHeader) As Boolean
     
            Dim si As SalesOrder = company1.Factories.SalesOrderFactory.Create
        With si
            Dim invoicedate As Date = Now
            If soTK.dShipped IsNot Nothing Then
                invoicedate = soTK.dShipped
            Else
                invoicedate = soTK.dinvoice
            End If
            .Date = invoicedate
            .TermsDescription = soTK.sTerms
            .CustomerReference = GetCustomer(soTK.tCustomr.sName)
            .ReferenceNumber = soTK.sSONum
            Try
                .ShipToAddress.Address = .CustomerReference.Load(company1).ShipToContact.Address
            Catch ex As Exception
            End Try
        End With

            For Each soTKline In (From row In soTK.tSOLines Order By row.nLineNumber Where row.nAccountID > 0 And row.sType.ToUpper.Trim = "ITEM")
                Dim siline As SalesOrderLine = si.AddLine
                With siline

                    .Quantity = 1
                    .UnitPrice = Decimal.Round(soTKline.nAmount, 2)
                '   .Amount = Decimal.Round(soTKline.nAmount, 2) ' .CalculateAmount(1, 1.3)
                    .Description = soTKline.sDesc
                .AccountReference = GetAccount(soTKline.nAccountID)
                .Amount = .CalculateAmount(.Quantity, .UnitPrice)
                    If .Validate Then
                    Else
                        MessageBox.Show("did not validate?")
                    End If
                End With
            Next

            If si.SalesOrderLines.Count > 0 Then
                Try
                    If Not si.Validate Then
                        MessageBox.Show("did not validate?")
                    End If
                    si.Save()
                    Return True
                Catch ex As Exception
                    Throw New Exception("in Sage Validate " & ex.Message)
                End Try

            End If

    End Function

    Public Structure POtoSageVendorInvoice
        Public spo As String
        Public sinv As String
    End Structure

    Private purlist As PurchaseOrderList
    Private purInvlist As PurchaseInvoiceList

    Public Function GetInvFromPO(_spo As String) As String

        Try
            If purlist Is Nothing Then
                purlist = company1.Factories.PurchaseOrderFactory.List
                purlist.Load()
            End If

            Dim qpo = (From row In purlist Where row.ReferenceNumber = _spo)
            If qpo.Count > 0 Then

                Dim purFound = qpo.First

                If purInvlist Is Nothing Then
                    purInvlist = company1.Factories.PurchaseInvoiceFactory.List
                    purInvlist.Load()
                End If


                Dim qpurInvlist = From row In purInvlist Where row.Date > Now.AddDays(-15)

                For Each pil1 In qpurInvlist ' purInvlist
                    If pil1.ApplyToOrderLines.Count > 0 Then

                        Dim purch = pil1.ApplyToOrderLines.First
                        Dim posage = purch.Description
                        Dim blnFound As Boolean = False

                        For Each poactualline In purFound.PurchaseOrderLines
                            If poactualline.Key.Guid.Equals(purch.PurchaseOrderLineReference.Guid) Then
                                Return pil1.ReferenceNumber
                                blnFound = True
                                Exit For
                            End If
                        Next
                    End If
                Next
            End If
            Return ""
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        If sageSession IsNot Nothing Then
            If sageSession.SessionActive Then
                sageSession.End()
            End If
        End If
    End Sub

    Public Shared Sub NewCust(_id As Integer)
        CreateSageFileWithThisName("NEWCUSTOMER_" & _id.ToString & "_")
    End Sub

    Public Shared Sub NewVendor(_id As Integer)
        CreateSageFileWithThisName("NEWVENDOR_" & _id.ToString & "_")
    End Sub

    Private Shared Sub CreateSageFileWithThisName(_file As String)
        Dim strDest As String = My.Settings.SageSyncDirectory & "\" & _file & ".XML"
        If Not IO.File.Exists(strDest) Then
            Dim sw As New IO.StreamWriter(strDest)
            sw.Flush()
            sw.Close()
        End If
    End Sub

    Public Function NewVendor(_name As String, _address As String, _address2 As String, _state As String, _city As String, _zip As String, _country As String, _phone As String, _phone2 As String, _fax As String) As Boolean
        Dim venlist As VendorList = company1.Factories.VendorFactory.List
        venlist.Load()

        If (From row In venlist Where row.Name = _name).Count > 0 Then
            For Each ventemp In (From row In venlist Where row.Name.Trim.ToUpper = _name.Trim.ToUpper)
                Throw New Exception("customer already exists in Sage: " & _name)
            Next
        End If

        Dim newven As Vendor = company1.Factories.VendorFactory.Create
        With newven

            .ID = (Mid(_name, 1, 20)).ToUpper
            .Name = _name
            .IsInactive = False
            .AccountNumber = .ID
      
            If .PhoneNumbers.Count > 0 Then
                .PhoneNumbers(0).Number = _phone
            End If
            If .PhoneNumbers.Count > 1 Then
                .PhoneNumbers(1).Number = _phone2
            End If
            Dim firstname As String = ""
            Dim lastname As String = ""
            If _name.Contains(",") Then
                Dim icomma As Integer = InStr(_name, ",")
                If Mid(_name.Replace(".", ""), icomma, 10).Length > 5 Then
                    lastname = Mid(_name, 1, InStr(_name, ",") - 1)
                    firstname = Mid(_name, InStr(_name, ",") + 1, 20)
                Else
                    lastname = _name
                End If

            Else
                lastname = _name
            End If

            .MailToContact.FirstName = Mid(firstname, 1, 15)
            .MailToContact.MiddleInitial = ""
            .MailToContact.CompanyName = _name
            .MailToContact.Address.Address1 = Mid(_address.Trim, 1, 30)
            .MailToContact.Address.Address2 = _address2.Trim
            .MailToContact.Address.City = _city.Trim
            .MailToContact.Address.State = Mid(_state.Trim, 1, 2)
            .MailToContact.Address.Zip = _zip.Trim
            .MailToContact.Address.Country = _country.Trim
            .MailToContact.PhoneNumbers(0).Number = _phone
            .MailToContact.PhoneNumbers(0).Number = _phone2
            .MailToContact.PhoneNumbers(0).Number = _fax
            If .MailToContact.Address.Country.Length = 0 Then
                .MailToContact.Address.Country = "USA"
            End If
            .MailToContact.Gender = Gender.NotSpecified


        End With
        If newven.Validate Then
            Try
                newven.Save()
                Return True
            Catch ex As Exception
                If ex.Message.Contains("duplicate") Then
                    Throw New Exception("Sage error: duplicate ID: " & newven.ID)
                End If
            End Try
        End If
    End Function

    Private Function StartSageSession() As Boolean
        Try
            Dim strSageServer As String = My.Settings.SageServerName ' "dell-server"

            If sageSession Is Nothing Then
                sageSession = New Sage.Peachtree.API.PeachtreeSession
            End If

            If Not sageSession.SessionActive Then
                sageSession.Begin("+1JXY4QHM0hcd0hWdTZhdRLO8XqW0P3tA9SPUS9lqH47XvT+UGN4UA==p84KKi0musmAviu1nuZL4pgdt2rOE0kbXDjHZ19W7BoGdesg9bqN4HHuLXZsiyQ0lzDMqvlP+nZLgroEFtPMz0GABjDOl1fZXkER1X94QKDAFLkbvJqR4YZSMineMLo0M06oLRl5nbFE4ENPly2GIZEE2OQtjuyG5/Q0zz4iCr+DJl4gnQCVVeKLpJDSgc8l0GaphCwPnfqgVpYwXZFU59hYQmOMp8CY1xbebUWKXsAbZyRNXCq3VoIbE1/tpzHO")
            End If

            Dim list1 As CompanyIdentifierList
            list1 = sageSession.CompanyList(strSageServer)
            If list1.Count = 0 Then
                Throw New Exception("No Sage company found")  'may mean you are not connected to the \\dell-server\accounting share with correct privilages
            Else
                comp1 = list1.First
            End If

            Dim authorizationResult As AuthorizationResult = sageSession.RequestAccess(comp1)
            If authorizationResult = Sage.Peachtree.API.AuthorizationResult.Granted Then
                company1 = sageSession.Open(comp1)
                Return True
            ElseIf authorizationResult = Sage.Peachtree.API.AuthorizationResult.Pending Then
                Try
                    sageSession.End()
                Catch 
                End Try

                Throw New Exception("Sage is waiting for authorization to allow SDK access, re-open Sage to choose 'Allow Access', then try again")

                Return False

            Else
                Throw New Exception("Unknown failure to communicate with Sage Accounting")
            End If
            Return False
        Catch ex As Exception
            Windows.MessageBox.Show(ex.Message)
            Return False
        End Try


    End Function

    Private Sub EndSageSession()
        If sageSession.SessionActive Then
            sageSession.End()
        End If
    End Sub

    Private Sub EditCustomer(iCustID As Integer)
        Dim dc As linqTKSIDataContext = GetLinqDataContext()
        Dim q = (From row In dc.tCustomrs Where row.lID = iCustID)
        If q.Count > 0 Then
            Dim cust1 As tCustomr = q.First
            EditCustomer(cust1.sName, cust1.sStreet1, cust1.sStreet2, cust1.sProvState, cust1.sCity, cust1.sPostalZip, cust1.sCountry, cust1.sPhone1, cust1.sPhone2)
        End If
    End Sub

    Public Shared Sub NewCustomer(_iCustID As Integer)
        Dim dc As linqTKSIDataContext = GetLinqDataContext()
        Dim q = (From row In dc.tCustomrs Where row.lID = _iCustID)
        If q.Count > 0 Then
            '  Dim cust1 As tCustomr = q.First
            NewCust(_iCustID)
            '   NewCustomer(cust1.sName, cust1.sStreet1, cust1.sStreet2, cust1.sProvState, cust1.sCity, cust1.sPostalZip, cust1.sCountry, cust1.sPhone1, cust1.sPhone2, cust1.dCrLimit)
        End If
    End Sub

    Private Function NewCustomer(_name As String, _address As String, _address2 As String, _state As String, _city As String, _zip As String, _country As String, _phone As String, _phone2 As String, _creditlimit As Decimal) As Boolean
        ' StartSageSession()  'happens in constructor

        Dim sCustname As String = Mid(_name, 1, 38)

        Dim custlist As CustomerList = company1.Factories.CustomerFactory.List
        custlist.Load()

        If (From row In custlist Where row.Name = sCustname).Count > 0 Then
            For Each custtemp In (From row In custlist Where row.Name.Trim.Replace(",", "").Replace(" ", "").ToUpper = sCustname.Trim.Replace(",", "").Replace(" ", "").ToUpper)
                Throw New Exception("customer already exists in Sage: " & custtemp.Name)
            Next
        End If

        Dim newCust As Customer = company1.Factories.CustomerFactory.Create
        With newCust

            ' .ID = (Mid((sCustname).Replace(" ", "").Replace("-", "").Replace(",", ""), 1, 4)).ToUpper

            .ID = (Mid(sCustname, 1, 20))

            .Name = sCustname
            .IsInactive = False
            .AccountNumber = .ID
            .CreditStatus = CustomerCreditStatus.NotifyOverLimit

            Dim term1 As PaymentTerms = company1.Factories.PaymentTermsFactory.Create(PaymentTimeFrame.COD, 30, False, 0, 0, _creditlimit, False)

            If .PhoneNumbers.Count > 0 Then
                .PhoneNumbers(0).Number = _phone
            End If
            If .PhoneNumbers.Count > 1 Then
                .PhoneNumbers(1).Number = _phone2
            End If
            Dim firstname As String = ""
            Dim lastname As String = ""
            If _name.Contains(",") Then
                Dim icomma As Integer = InStr(_name, ",")
                If Mid(_name.Replace(".", ""), icomma, 10).Length > 5 Then
                    lastname = Mid(_name, 1, InStr(_name, ",") - 1)
                    firstname = Mid(_name, InStr(_name, ",") + 1, 20)
                Else
                    lastname = _name
                End If

            Else
                lastname = _name
            End If
            .BillToContact.FirstName = Mid(firstname, 1, 15)
            .BillToContact.MiddleInitial = ""
            .BillToContact.LastName = Mid(lastname, 1, 20)
            .BillToContact.CompanyName = sCustname
            .BillToContact.Address.Address1 = Mid(_address.Trim, 1, 30)
            .BillToContact.Address.Address2 = _address2.Trim
            .BillToContact.Address.City = _city.Trim
            .BillToContact.Address.State = Mid(_state.Trim, 1, 2)
            .BillToContact.Address.Zip = _zip.Trim
            .BillToContact.Address.Country = _country.Trim

            If .BillToContact.Address.Country.Length = 0 Then
                .BillToContact.Address.Country = "USA"
            End If
            .BillToContact.Gender = Gender.NotSpecified

            .CustomerSince = Now
        End With
        If newCust.Validate Then
            Try
                newCust.Save()
                Return True
            Catch ex As Exception
                If ex.Message.Contains("duplicate") Then
                    Throw New Exception("Sage error: duplicate ID: " & newCust.ID)
                End If
            End Try
        End If
    End Function

    Public Function EditCustomer(_name As String, _address As String, _address2 As String, _state As String, _city As String, _zip As String, _country As String, _phone As String, _phone2 As String) As Boolean
        ' StartSageSession()  'happens in constructor

        Dim sCustname As String = Mid(_name, 1, 38)

        Dim custlist As CustomerList = company1.Factories.CustomerFactory.List
        custlist.Load()

        If (From row In custlist Where row.Name = sCustname).Count > 0 Then
            Dim q = (From row In custlist Where row.Name.Trim.Replace(",", "").Replace(" ", "").ToUpper = sCustname.Trim.Replace(",", "").Replace(" ", "").ToUpper)
            If q.Count > 0 Then
                Dim newCust As Customer = q.First
                With newCust


                    .Name = sCustname
                    ' .IsInactive = False
                    ' .AccountNumber = .ID
                    ' .CreditStatus = CustomerCreditStatus.NotifyOverLimit
                    '   Dim term1 As PaymentTerms = company1.Factories.PaymentTermsFactory.Create(PaymentTimeFrame.COD, 30, False, 0, 0, _creditlimit, False)

                    If .PhoneNumbers.Count > 0 Then
                        .PhoneNumbers(0).Number = _phone
                    End If
                    If .PhoneNumbers.Count > 1 Then
                        .PhoneNumbers(1).Number = _phone2
                    End If
                    Dim firstname As String = ""
                    Dim lastname As String = ""
                    If _name.Contains(",") Then
                        Dim icomma As Integer = InStr(_name, ",")
                        If Mid(_name.Replace(".", ""), icomma, 10).Length > 5 Then
                            lastname = Mid(_name, 1, InStr(_name, ",") - 1)
                            firstname = Mid(_name, InStr(_name, ",") + 1, 20)
                        Else
                            lastname = _name
                        End If

                    Else
                        lastname = _name
                    End If
                    .BillToContact.FirstName = Mid(firstname, 1, 15)
                    .BillToContact.MiddleInitial = ""
                    .BillToContact.LastName = Mid(lastname, 1, 20)
                    .BillToContact.CompanyName = sCustname
                    .BillToContact.Address.Address1 = Mid(_address.Trim, 1, 30)
                    .BillToContact.Address.Address2 = _address2.Trim
                    .BillToContact.Address.City = _city.Trim
                    .BillToContact.Address.State = Mid(_state.Trim, 1, 2)
                    .BillToContact.Address.Zip = _zip.Trim
                    .BillToContact.Address.Country = _country.Trim

                    If .BillToContact.Address.Country.Length = 0 Then
                        .BillToContact.Address.Country = "USA"
                    End If
                    .BillToContact.Gender = Gender.NotSpecified

                    .CustomerSince = Now
                End With

                If newCust.Validate Then
                    Try
                        newCust.Save()
                        Return True
                    Catch ex As Exception
                        If ex.Message.Contains("duplicate") Then
                            Throw New Exception("Sage error: duplicate ID: " & newCust.ID)
                        End If
                    End Try
                End If
            End If
        End If

    End Function

End Class
