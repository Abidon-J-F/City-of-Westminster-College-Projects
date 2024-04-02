Public Class PersonClass
    Private surname As String
    Private forename As String

    Public Sub setSurname(ByVal value As String)
        surname = value
    End Sub
    Public Sub setForename(ByVal value As String)
        forename = value
    End Sub
    Public Function getForename() As String
        Return forename
    End Function
    Public Function getSurname() As String
        Return surname
    End Function
    Public personAddress As New addressClass ' instantiates an object of class addressClass
End Class
Public Class addressClass
    Private number As String
    Private street As String
    Private PostCode As String
    Public Sub setNumber(ByVal value As String)
        number = value
    End Sub
    Public Sub setStreet(ByVal value As String)
        street = value
    End Sub
    Public Sub setPostCode(ByVal value As String)
        PostCode = value

    End Sub
    Public Function getDetails(ByVal value As Integer) As String
        Select Case value
            Case 1
                Return number
            Case 2
                Return street
            Case 3
                Return PostCode
            Case Else
                Return ("Invalid code")
        End Select
    End Function
End Class

