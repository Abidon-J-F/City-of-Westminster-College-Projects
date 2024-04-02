Public Class FlightClass
    Private Airline As String
    Private TakeOff As String
    Private Land As String
    Private FlightNumber As String
    Private Cost As Decimal
    Public Function returnCost()
        Return Cost
    End Function
End Class
Public Class PlaceClass
    Private Country As String
    Private Destination As String
    Private Hotel As String
    Private Cost As Decimal
    Public Function returnCost()
        Return Cost
    End Function
End Class
Public Class CustomerClass
    Private Surname As String
    Private Forename As String
    Private Street As String
    Private Town As String
    Private PostCode As String
    Private PeopleInGroup As Integer
    Public Sub setSurname(ByVal value As String)
        Surname = value
    End Sub
End Class
Public Class HolidayClass
    Public Flight As New FlightClass
    Public Place As New PlaceClass
    Public Customer As New CustomerClass
    Public Overridable Function CalculateCost()
        Return (Flight.returnCost + Place.returnCost)
    End Function
End Class
'Flight, place and customer could be attributes, but they each exist as separate entities and so are defined as separate classes.
'
Public Class WinterHoliday
    Inherits HolidayClass
    Private SkiPass As Decimal
    Private SkiTuition As Decimal
    Public Overrides Function CalculateCost()
        Return (MyBase.CalculateCost() + SkiPass + SkiTuition)
    End Function
End Class
Public Class SummerHoliday
    Inherits HolidayClass
    Private GuideCost As Decimal
    Private equipment As Decimal
    Private ClimbingTuition As Decimal
    Public Overrides Function CalculateCost()
        Return (MyBase.CalculateCost() + equipment + GuideCost + ClimbingTuition)
    End Function
End Class