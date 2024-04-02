Public Class AccountClass
    ' attributes which cannot be accessed directly
    Private customerName As String
    Private customerAddress As String
    Private accountNo As Integer
    Private balance As Decimal
    Private overdraftLimit As Decimal


    'methods are used to access the private attributes(properties)
    'procedures (subroutines in VBasic) set values of privte data
    Public Sub setname(ByVal pname As String)
        customerName = pname
    End Sub
    Public Sub setAddress(ByVal pAddress As String)
        customerAddress = pAddress
    End Sub
    Public Sub setAccountNo(ByVal pAccountNo As String)
        accountNo = pAccountNo
    End Sub
    Public Sub setBalance(ByVal pTransaction As String)
        balance = balance + pTransaction
    End Sub
    Public Sub setlimit(ByVal plimit As String)
        overdraftLimit = plimit
    End Sub


    'function return values of private data
    Public Function getname() As String
        Return customerName
    End Function
    Public Function getAddress() As String
        Return customerAddress
    End Function
    Public Function getAccountNo() As Integer
        Return accountNo
    End Function
    Public Function getBalance() As Decimal
        Return balance
    End Function
    Public Function getOverdraftLimit() As Decimal
        Return overdraftLimit
    End Function
End Class
