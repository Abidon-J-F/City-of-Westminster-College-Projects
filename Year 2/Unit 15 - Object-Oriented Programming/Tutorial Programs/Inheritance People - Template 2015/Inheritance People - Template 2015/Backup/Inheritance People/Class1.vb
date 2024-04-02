Public Class PersonClass
    Private personName As String
    Private address As String
    Private phone As String
    Public Sub setName(ByVal pName As String)
        personName = pName
    End Sub
    Public Sub setAddress(ByVal pAddress As String)
        address = pAddress
    End Sub
    Public Sub setPhone(ByVal pPhone As String)
        phone = pPhone
    End Sub


    Public Function getName() As String
        Return personName
    End Function
    Public Function getAddress() As String
        Return address
    End Function
    Public Function getPhone() As String
        Return phone
    End Function

End Class
Public Class teacherClass
    Inherits PersonClass
    Private department As String
    Private position As String
    Private status As Decimal  'Full time is 1,Part time is fraction e.g. 0.5
    Private salary As Decimal
    Private nationalInsurance As String

    Public Sub setDepartment(ByVal pDepartment As String)
        department = pDepartment
    End Sub

    Public Function getDepartment() As String
        Return department
    End Function
End Class

Public Class studentClass
    Inherits PersonClass
    Private tutor As String
    Private year As Integer  ' 1, 2  or 3

End Class