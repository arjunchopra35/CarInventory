<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.lbMakeDisplay = New System.Windows.Forms.Label()
        Me.lbModelDisplay = New System.Windows.Forms.Label()
        Me.lbYearDisplay = New System.Windows.Forms.Label()
        Me.lbPriceDisplay = New System.Windows.Forms.Label()
        Me.tbModelInput = New System.Windows.Forms.TextBox()
        Me.tbPriceInput = New System.Windows.Forms.TextBox()
        Me.cmbCarMake = New System.Windows.Forms.ComboBox()
        Me.cmbCarYear = New System.Windows.Forms.ComboBox()
        Me.chkNewCar = New System.Windows.Forms.CheckBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbOutput = New System.Windows.Forms.Label()
        Me.lvwCarInformation = New System.Windows.Forms.ListView()
        Me.colNewCar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCarMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCarModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCarYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCarPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CarInventoryToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbMakeDisplay
        '
        Me.lbMakeDisplay.Location = New System.Drawing.Point(43, 18)
        Me.lbMakeDisplay.Name = "lbMakeDisplay"
        Me.lbMakeDisplay.Size = New System.Drawing.Size(46, 18)
        Me.lbMakeDisplay.TabIndex = 0
        Me.lbMakeDisplay.Text = "&Make:"
        Me.lbMakeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbModelDisplay
        '
        Me.lbModelDisplay.Location = New System.Drawing.Point(43, 42)
        Me.lbModelDisplay.Name = "lbModelDisplay"
        Me.lbModelDisplay.Size = New System.Drawing.Size(46, 23)
        Me.lbModelDisplay.TabIndex = 1
        Me.lbModelDisplay.Text = "M&odel:"
        Me.lbModelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbYearDisplay
        '
        Me.lbYearDisplay.Location = New System.Drawing.Point(43, 68)
        Me.lbYearDisplay.Name = "lbYearDisplay"
        Me.lbYearDisplay.Size = New System.Drawing.Size(46, 23)
        Me.lbYearDisplay.TabIndex = 2
        Me.lbYearDisplay.Text = "&Year:"
        Me.lbYearDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbPriceDisplay
        '
        Me.lbPriceDisplay.Location = New System.Drawing.Point(43, 97)
        Me.lbPriceDisplay.Name = "lbPriceDisplay"
        Me.lbPriceDisplay.Size = New System.Drawing.Size(46, 23)
        Me.lbPriceDisplay.TabIndex = 3
        Me.lbPriceDisplay.Text = "&Price:"
        Me.lbPriceDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbModelInput
        '
        Me.tbModelInput.Location = New System.Drawing.Point(95, 42)
        Me.tbModelInput.Name = "tbModelInput"
        Me.tbModelInput.Size = New System.Drawing.Size(121, 20)
        Me.tbModelInput.TabIndex = 5
        Me.CarInventoryToolTip.SetToolTip(Me.tbModelInput, "Input the Model of the car.")
        '
        'tbPriceInput
        '
        Me.tbPriceInput.Location = New System.Drawing.Point(95, 97)
        Me.tbPriceInput.Name = "tbPriceInput"
        Me.tbPriceInput.Size = New System.Drawing.Size(121, 20)
        Me.tbPriceInput.TabIndex = 7
        Me.CarInventoryToolTip.SetToolTip(Me.tbPriceInput, "Input the price of the car.")
        '
        'cmbCarMake
        '
        Me.cmbCarMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarMake.FormattingEnabled = True
        Me.cmbCarMake.Items.AddRange(New Object() {"Kia", "Honda", "BMW", "Mercedes-Benz", "Volvo", "Lexus", "Dodge", "Porsche", "Corvette", "Nissan", "Chevrolet", "Toyota", "Acura", "Buick", "Mazda"})
        Me.cmbCarMake.Location = New System.Drawing.Point(95, 15)
        Me.cmbCarMake.Name = "cmbCarMake"
        Me.cmbCarMake.Size = New System.Drawing.Size(121, 21)
        Me.cmbCarMake.TabIndex = 4
        Me.CarInventoryToolTip.SetToolTip(Me.cmbCarMake, "Choose the make of the car from this list.")
        '
        'cmbCarYear
        '
        Me.cmbCarYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarYear.FormattingEnabled = True
        Me.cmbCarYear.Items.AddRange(New Object() {"1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.cmbCarYear.Location = New System.Drawing.Point(95, 68)
        Me.cmbCarYear.Name = "cmbCarYear"
        Me.cmbCarYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbCarYear.TabIndex = 6
        Me.CarInventoryToolTip.SetToolTip(Me.cmbCarYear, "Choose the year of the car from this list.")
        '
        'chkNewCar
        '
        Me.chkNewCar.AutoSize = True
        Me.chkNewCar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNewCar.Location = New System.Drawing.Point(59, 123)
        Me.chkNewCar.Name = "chkNewCar"
        Me.chkNewCar.Size = New System.Drawing.Size(51, 17)
        Me.chkNewCar.TabIndex = 8
        Me.chkNewCar.Text = "&New:"
        Me.chkNewCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryToolTip.SetToolTip(Me.chkNewCar, "Check this box if the car is new.")
        Me.chkNewCar.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(87, 394)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.CarInventoryToolTip.SetToolTip(Me.btnEnter, "Click this button to enter car information." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(168, 394)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.CarInventoryToolTip.SetToolTip(Me.btnReset, "Click this button to clear currently entered data on the form.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(250, 394)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.CarInventoryToolTip.SetToolTip(Me.btnExit, "Click this button to exit the form.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbOutput
        '
        Me.lbOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOutput.Location = New System.Drawing.Point(12, 322)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(361, 69)
        Me.lbOutput.TabIndex = 10
        Me.CarInventoryToolTip.SetToolTip(Me.lbOutput, "Outputs any error messages.")
        '
        'lvwCarInformation
        '
        Me.lvwCarInformation.CheckBoxes = True
        Me.lvwCarInformation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNewCar, Me.colID, Me.colCarMake, Me.colCarModel, Me.colCarYear, Me.colCarPrice})
        Me.lvwCarInformation.FullRowSelect = True
        Me.lvwCarInformation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        ListViewItem1.StateImageIndex = 0
        Me.lvwCarInformation.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvwCarInformation.Location = New System.Drawing.Point(12, 146)
        Me.lvwCarInformation.MultiSelect = False
        Me.lvwCarInformation.Name = "lvwCarInformation"
        Me.lvwCarInformation.Size = New System.Drawing.Size(361, 173)
        Me.lvwCarInformation.TabIndex = 9
        Me.CarInventoryToolTip.SetToolTip(Me.lvwCarInformation, "Displays the information of each car.")
        Me.lvwCarInformation.UseCompatibleStateImageBehavior = False
        Me.lvwCarInformation.View = System.Windows.Forms.View.Details
        '
        'colNewCar
        '
        Me.colNewCar.Text = "New"
        Me.colNewCar.Width = 34
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 28
        '
        'colCarMake
        '
        Me.colCarMake.Text = "Make"
        Me.colCarMake.Width = 59
        '
        'colCarModel
        '
        Me.colCarModel.Text = "Model"
        Me.colCarModel.Width = 70
        '
        'colCarYear
        '
        Me.colCarYear.Text = "Year"
        '
        'colCarPrice
        '
        Me.colCarPrice.Text = "Price"
        Me.colCarPrice.Width = 75
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(384, 426)
        Me.Controls.Add(Me.lvwCarInformation)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.chkNewCar)
        Me.Controls.Add(Me.cmbCarYear)
        Me.Controls.Add(Me.cmbCarMake)
        Me.Controls.Add(Me.tbPriceInput)
        Me.Controls.Add(Me.tbModelInput)
        Me.Controls.Add(Me.lbPriceDisplay)
        Me.Controls.Add(Me.lbYearDisplay)
        Me.Controls.Add(Me.lbModelDisplay)
        Me.Controls.Add(Me.lbMakeDisplay)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 465)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 465)
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbMakeDisplay As Label
    Friend WithEvents lbModelDisplay As Label
    Friend WithEvents lbYearDisplay As Label
    Friend WithEvents lbPriceDisplay As Label
    Friend WithEvents tbModelInput As TextBox
    Friend WithEvents tbPriceInput As TextBox
    Friend WithEvents cmbCarMake As ComboBox
    Friend WithEvents cmbCarYear As ComboBox
    Friend WithEvents chkNewCar As CheckBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbOutput As Label
    Friend WithEvents lvwCarInformation As ListView
    Friend WithEvents CarInventoryToolTip As ToolTip
    Friend WithEvents colNewCar As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colCarMake As ColumnHeader
    Friend WithEvents colCarModel As ColumnHeader
    Friend WithEvents colCarYear As ColumnHeader
    Friend WithEvents colCarPrice As ColumnHeader
End Class
