Private Class SalaryClass
    Private employeeName As String
    Private wage As Double

    Public Sub setName(value As String)
        employeeName = value
    End Sub

    Public Function getName() As String
        Return employeeName
    End Function

    Public Sub setWage(value As Double)
        wage = value
    End Sub

    Public Overriable Function getMonthlyWage() As Double
        Return wage / 12
    End Function


End Class

Public Class bonusClass
    Inherits SalaryClass
    Private bonus As Double

    Public Sub setBonus(Value As Double)
        bonus = Value
    End Sub

    Public Overrides Function getMonthlyWage() As Double
        Return MyBase.getMonth() + bonus
    End Function
End Class

Public Class hourlyPaidClass
    Inherits SalaryClass
    Private hours As Integer
    Public Sub setHours(Value As Double)
        hours = Value
    End Sub

    Public Overrides Function getMonthlyWages() As Double
End Class
