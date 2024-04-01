Public Class CustomerDetailsClass
    Private CustomerID As String
    Private CustomerName As String
    Private CustomerAddress As String
    Private ProofofAddress As String
    Private DateofHire As Date
    Private NumberofDays As Integer
    Private MethodofPayments As String
    Private FullCost As Decimal
    Private Receipt As String

    Public Sub setCustomerID(ByVal value As String)
        CustomerID = value
    End Sub

    Public Sub setCustomerName(ByVal value As String)
        CustomerName = value
    End Sub

    Public Sub setCustomerAddress(ByVal value As String)
        CustomerAddress = value
    End Sub

    Public Sub setProofofAddress(ByVal value As String)
        ProofofAddress = value
    End Sub

    Public Sub setDateofHire(ByVal value As Date)
        DateofHire = value
    End Sub

    Public Sub setNumberofDays(ByVal value As Integer)
        NumberofDays = value
    End Sub

    Public Sub setMethodofPayments(ByVal value As String)
        MethodofPayments = value
    End Sub

    Public Sub setFullCost(ByVal value As String)
        FullCost = value
    End Sub
    Public Sub setReceipt(ByVal value As String)
        Receipt = value
    End Sub

    Public Function returnCustomerID() As String
        Return CustomerID
    End Function

    Public Function returnCustomerName() As String
        Return CustomerName
    End Function

    Public Function returnCustomerAddress() As String
        Return CustomerAddress
    End Function

    Public Function returnProofofAddress() As String
        Return ProofofAddress
    End Function

    Public Function returnDateofHire()
        Return DateofHire
    End Function

    Public Function returnNumberofDays()
        Return NumberofDays
    End Function

    Public Function returnMethodofPayments()
        Return MethodofPayments
    End Function
    Public Function returnFullCost()
        Return FullCost
    End Function

    Public Function returnReceipt()
        Return Receipt
    End Function
End Class

Public Class BicycleHireClass
    Inherits CustomerDetailsClass

    Private NumberofAdultBikesHired As Integer
    Private NumberofChildrenBikesHired As Integer

    Public Sub setNumberofAdultBikesHired(ByVal value As Integer)
        NumberofAdultBikesHired = value
    End Sub

    Public Sub setNumberofChildrenBikesHired(ByVal value As Integer)
        NumberofChildrenBikesHired = value
    End Sub

    Public Function ReturnNumberofAdultBikesHired() As Integer
        Return NumberofAdultBikesHired
    End Function

    Public Function ReturnNumberofChildrenBikesHired() As Integer
        Return NumberofChildrenBikesHired
    End Function
End Class

Public Class CarHireClass
    Inherits CustomerDetailsClass

    Private CarRegistration As String
    Private CarModel As String
    Private AdditionalInsurance As Boolean

    Public Sub setCarRegistration(ByVal value As String)
        CarRegistration = value
    End Sub

    Public Sub setCarModel(ByVal value As String)
        CarModel = value
    End Sub

    Public Sub setAdditionalInsurance(ByVal value As Boolean)
        AdditionalInsurance = value
    End Sub

    Public Function ReturnCarRegistration() As String
        Return CarRegistration
    End Function

    Public Function ReturnCarModel() As String
        Return CarModel
    End Function

    Public Function ReturnAdditionalInsurance() As Boolean
        Return AdditionalInsurance
    End Function
End Class

Public Class CalculatingCost
    Public iCustomerDetails As New CustomerDetailsClass
    Public iCarHire As New CarHireClass
    Public iBicycleHire As New BicycleHireClass

    Public Overridable Function TotalCost()
        Return (iCustomerDetails.returnCustomerName)
    End Function
End Class
