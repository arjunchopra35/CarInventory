Public Class Car


    Private Shared carCount As Integer                 ' static or shared private variable to hold the number of cars
    Private carIdentificationNumber As Integer = 0     ' private variable to hold the car's identification number
    Private carMake As String = "" ' private variable to hold the car's make
    Private carYear As String = "" ' private variable to hold the car's year
    Private carModel As String = ""     ' private variable to hold the car's model
    Private carPrice As String = ""  ' private variable to hold the car's Price
    Private isCarNew As Boolean = False      ' private variable to hold the car's status of either a new or used car


    Public Sub New()

        carCount += 1      ' increment the shared/static variable counter by 1
        carIdentificationNumber = carCount ' assign the cars id

    End Sub


    Public Sub New(make As String, year As String, model As String, price As String, newCar As Boolean)

        ' call the other constructor 
        ' to set the car count and
        ' to set the car id
        Me.New()


        carMake = make          ' set the car's make
        carYear = year          ' set the car's year
        carModel = model        ' set the car's model
        carPrice = price        ' set the car's price
        isCarNew = newCar       ' set the car's status as a new or used car

    End Sub



    ' Gets the number of cars that have been instantiated/created
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ' Gets a specific cars identification number
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ' Gets and Sets the Is New Car status of a car
    Public Property NewCar() As Boolean
        Get
            Return isCarNew
        End Get
        Set(ByVal value As Boolean)
            isCarNew = value
        End Set
    End Property


    'Gets and Sets the make of the car
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    'Gets and Sets the year of the car
    Public Property Year() As String
        Get
            Return carYear
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    ' Gets and Sets the the model of the car
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    ' Gets and Sets the the price of the car
    Public Property Price() As String
        Get
            Return "$" + carPrice
        End Get
        Set(ByVal value As String)
            carPrice = value
        End Set
    End Property



End Class
