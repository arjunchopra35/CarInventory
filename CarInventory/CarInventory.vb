

' Author Name:    Arjun Chopra
' Project    :    CarInventory
' Date:           March 14, 2019
' Description     This program keeps a list of Car information

Option Strict On

Public Class frmCarInventory

    Private carList As New SortedList                                 ' collection of all the carList in the list
    Private currentCarIdentificationNumber As String = "" ' current selected car identification number
    Private editMode As Boolean = False
    Private priceInput As Double = 0.00


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Car   ' declare a Car class
        Dim carItem As ListViewItem   ' declare a ListViewItem class

        ' validate the data in the form
        If ValidUserInput() = True Then

            ' set the edit var to true if the input is valid
            editMode = True

            ' 
            lbOutput.Text = "It worked!"

            ' if the current car identification number has a no value
            If currentCarIdentificationNumber.Trim.Length = 0 Then

                ' create a new car object using the parameterized constructor
                car = New Car(cmbCarMake.Text, cmbCarYear.Text, tbModelInput.Text, tbPriceInput.Text, chkNewCar.Checked)

                ' add the car to the carList collection

                carList.Add(car.IdentificationNumber.ToString(), car)

            Else
                ' if the current car identification number has a value
                ' then the user has selected something from the list view

                car = CType(carList.Item(currentCarIdentificationNumber), Car)

                ' update the data in the specific object

                car.Make = cmbCarMake.Text
                car.Year = cmbCarYear.Text
                car.Model = tbModelInput.Text
                car.Price = tbPriceInput.Text
                car.NewCar = chkNewCar.Checked
            End If

            ' clear the items from the listview control
            lvwCarInformation.Items.Clear()



            For Each carEntry As DictionaryEntry In carList

                ' instantiate a new ListViewItem
                carItem = New ListViewItem()

                ' get the car from the list
                car = CType(carEntry.Value, Car)

                ' assign the values to the ckecked control
                ' and the subitems
                carItem.Checked = car.NewCar
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year)
                carItem.SubItems.Add(car.Price)


                ' add the new instantiated and populated ListViewItem
                ' to the listview control
                lvwCarInformation.Items.Add(carItem)

            Next carEntry

            ' clear the controls
            Reset()

            ' set the edit flag to false
            editMode = False

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close() ' Closes the program

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Reset()

    End Sub

    Private Sub Reset() 'Reset subroutine


        tbModelInput.Text = ""  ' Clears all selected or inputted data into the controls of the form
        tbPriceInput.Text = ""
        chkNewCar.Checked = False
        cmbCarMake.SelectedIndex = -1
        cmbCarYear.SelectedIndex = -1
        lbOutput.Text = ""
        currentCarIdentificationNumber = ""

    End Sub

    Private Function ValidUserInput() As Boolean 'Function to validate user input

        Dim returnValue As Boolean = True 'Return Boolean Variable
        Dim outputMessage As String = String.Empty 'Empty string for output messages


        If (Double.TryParse(tbPriceInput.Text, priceInput)) = False Then 'Tries to parse the user input as a integer 


            outputMessage += "Please enter a number for the car's price." & vbCrLf 'Outputs this message if its not an integer
            tbPriceInput.Focus()

            returnValue = False ' Returns a false value which the program will use for an error message

        End If

        If priceInput <= 0 Then ' if the number is a integer it then checks if its greater than zero

            outputMessage += "Please enter a number for the car's price that is greater then 0." & vbCrLf 'Outputs an error message if the number isnt below zero
            tbPriceInput.Focus()

            returnValue = False ' Returns a false value which the program will use for an error message

        End If

        ' check if the title has been selected
        If cmbCarYear.SelectedIndex = -1 Then

            ' If not this error message will be outputted
            outputMessage += "Please select the car year." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the title has been selected
        If cmbCarMake.SelectedIndex = -1 Then

            ' If not this error message will be ouputted
            outputMessage += "Please select the car's make." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If tbModelInput.Text.Trim.Length = 0 Then

            ' If not this error message will be outputted
            outputMessage += "Please enter the car model." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If tbPriceInput.Text.Trim.Length = 0 Then

            ' If not this error message will be outputted
            outputMessage += "Please enter the car's price." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lbOutput.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value

        Return returnValue

    End Function

    Private Sub lvwCarInformation_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCarInformation.ItemCheck

        ' if it is not in edit mode
        If editMode = False Then

            ' set the new value to the current value
            ' so it cannot be set in the listview by the user
            e.NewValue = e.CurrentValue

        End If

    End Sub

    Private Sub lvwCarInformation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCarInformation.SelectedIndexChanged

        ' constant variable for the index of the subitem in the list that
        ' holds the car identification number 
        Const identificationSubItemIndex As Integer = 1

        ' Gets the car identification number 
        currentCarIdentificationNumber = lvwCarInformation.Items(lvwCarInformation.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        ' Use the car identification number to get the car from the collection object
        Dim car As Car = CType(carList.Item(currentCarIdentificationNumber), Car)

        ' set the controls on the form
        cmbCarMake.Text = car.Make                 ' get the Car's make 
        tbModelInput.Text = car.Model              ' get the Car's Model 
        cmbCarYear.Text = car.Year                 ' get the Car's year 
        tbPriceInput.Text = car.Price              ' get the Car's price 
        chkNewCar.Checked = car.NewCar             ' get the new car 

    End Sub
End Class
