<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblName = New System.Windows.Forms.Label()
        txtName = New System.Windows.Forms.TextBox()
        lblFacility = New System.Windows.Forms.Label()
        txtFacility = New System.Windows.Forms.TextBox()
        lblStart = New System.Windows.Forms.Label()
        dtpStart = New System.Windows.Forms.DateTimePicker()
        grpCase = New System.Windows.Forms.GroupBox()
        lblHdrMed = New System.Windows.Forms.Label()
        lblHdrPills = New System.Windows.Forms.Label()
        lblHdrDose = New System.Windows.Forms.Label()
        lblHdrRefills = New System.Windows.Forms.Label()
        lblHdrLeft = New System.Windows.Forms.Label()
        lblHdrDays = New System.Windows.Forms.Label()
        lblHdrRem = New System.Windows.Forms.Label()
        lblHdrRun = New System.Windows.Forms.Label()
        txtMed1 = New System.Windows.Forms.TextBox()
        nudPills1 = New System.Windows.Forms.NumericUpDown()
        nudDose1 = New System.Windows.Forms.NumericUpDown()
        txtRefills1 = New System.Windows.Forms.TextBox()
        lblPillsLeft1 = New System.Windows.Forms.Label()
        lblDaysLeft1 = New System.Windows.Forms.Label()
        lblReminder1 = New System.Windows.Forms.Label()
        lblRunout1 = New System.Windows.Forms.Label()
        txtMed2 = New System.Windows.Forms.TextBox()
        nudPills2 = New System.Windows.Forms.NumericUpDown()
        nudDose2 = New System.Windows.Forms.NumericUpDown()
        txtRefills2 = New System.Windows.Forms.TextBox()
        lblPillsLeft2 = New System.Windows.Forms.Label()
        lblDaysLeft2 = New System.Windows.Forms.Label()
        lblReminder2 = New System.Windows.Forms.Label()
        lblRunout2 = New System.Windows.Forms.Label()
        txtMed3 = New System.Windows.Forms.TextBox()
        nudPills3 = New System.Windows.Forms.NumericUpDown()
        nudDose3 = New System.Windows.Forms.NumericUpDown()
        txtRefills3 = New System.Windows.Forms.TextBox()
        lblPillsLeft3 = New System.Windows.Forms.Label()
        lblDaysLeft3 = New System.Windows.Forms.Label()
        lblReminder3 = New System.Windows.Forms.Label()
        lblRunout3 = New System.Windows.Forms.Label()
        txtMed4 = New System.Windows.Forms.TextBox()
        nudPills4 = New System.Windows.Forms.NumericUpDown()
        nudDose4 = New System.Windows.Forms.NumericUpDown()
        txtRefills4 = New System.Windows.Forms.TextBox()
        lblPillsLeft4 = New System.Windows.Forms.Label()
        lblDaysLeft4 = New System.Windows.Forms.Label()
        lblReminder4 = New System.Windows.Forms.Label()
        lblRunout4 = New System.Windows.Forms.Label()
        grpMeds = New System.Windows.Forms.GroupBox()
        lblEarlyRemCaption = New System.Windows.Forms.Label()
        lblEarlyRemValue = New System.Windows.Forms.Label()
        lblEarlyRunCaption = New System.Windows.Forms.Label()
        lblEarlyRunValue = New System.Windows.Forms.Label()
        lblStatusCaption = New System.Windows.Forms.Label()
        lblStatusValue = New System.Windows.Forms.Label()
        grpResults = New System.Windows.Forms.GroupBox()
        txtNotes = New System.Windows.Forms.TextBox()
        grpNotes = New System.Windows.Forms.GroupBox()
        btnCalculate = New System.Windows.Forms.Button()
        btnSave = New System.Windows.Forms.Button()
        btnClear = New System.Windows.Forms.Button()
        btnDelete = New System.Windows.Forms.Button()
        btnClose = New System.Windows.Forms.Button()
        lblRecords = New System.Windows.Forms.Label()
        lvRecords = New System.Windows.Forms.ListView()
        colName = New System.Windows.Forms.ColumnHeader()
        colFacility = New System.Windows.Forms.ColumnHeader()
        colReminder = New System.Windows.Forms.ColumnHeader()
        colRunout = New System.Windows.Forms.ColumnHeader()
        colDays = New System.Windows.Forms.ColumnHeader()
        grpCase.SuspendLayout()
        CType(nudPills1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudDose1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPills2, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudDose2, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPills3, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudDose3, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPills4, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudDose4, ComponentModel.ISupportInitialize).BeginInit()
        grpMeds.SuspendLayout()
        grpResults.SuspendLayout()
        grpNotes.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New System.Drawing.Point(12, 31)
        lblName.Name = "lblName"
        lblName.Size = New System.Drawing.Size(81, 15)
        lblName.TabIndex = 0
        lblName.Text = "Child's Name:"
        ' 
        ' txtName
        ' 
        txtName.Location = New System.Drawing.Point(150, 28)
        txtName.MaxLength = 25
        txtName.Name = "txtName"
        txtName.Size = New System.Drawing.Size(190, 23)
        txtName.TabIndex = 1
        ' 
        ' lblFacility
        ' 
        lblFacility.AutoSize = True
        lblFacility.Location = New System.Drawing.Point(370, 31)
        lblFacility.Name = "lblFacility"
        lblFacility.Size = New System.Drawing.Size(102, 15)
        lblFacility.TabIndex = 2
        lblFacility.Text = "Detention Facility:"
        ' 
        ' txtFacility
        ' 
        txtFacility.Location = New System.Drawing.Point(480, 28)
        txtFacility.MaxLength = 25
        txtFacility.Name = "txtFacility"
        txtFacility.Size = New System.Drawing.Size(200, 23)
        txtFacility.TabIndex = 3
        ' 
        ' lblStart
        ' 
        lblStart.AutoSize = True
        lblStart.Location = New System.Drawing.Point(12, 65)
        lblStart.Name = "lblStart"
        lblStart.Size = New System.Drawing.Size(98, 15)
        lblStart.TabIndex = 4
        lblStart.Text = "Start / Refill Date:"
        ' 
        ' dtpStart
        ' 
        dtpStart.CustomFormat = "MM-dd-yyyy"
        dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpStart.Location = New System.Drawing.Point(150, 62)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New System.Drawing.Size(120, 23)
        dtpStart.TabIndex = 5
        ' 
        ' grpCase
        ' 
        grpCase.Controls.Add(lblName)
        grpCase.Controls.Add(txtName)
        grpCase.Controls.Add(lblFacility)
        grpCase.Controls.Add(txtFacility)
        grpCase.Controls.Add(lblStart)
        grpCase.Controls.Add(dtpStart)
        grpCase.Location = New System.Drawing.Point(12, 12)
        grpCase.Name = "grpCase"
        grpCase.Size = New System.Drawing.Size(720, 100)
        grpCase.TabIndex = 0
        grpCase.TabStop = False
        grpCase.Text = "Case Information"
        ' 
        ' lblHdrMed
        ' 
        lblHdrMed.Location = New System.Drawing.Point(12, 22)
        lblHdrMed.Name = "lblHdrMed"
        lblHdrMed.Size = New System.Drawing.Size(150, 30)
        lblHdrMed.TabIndex = 0
        lblHdrMed.Text = "Medication"
        lblHdrMed.TextAlign = Drawing.ContentAlignment.BottomLeft
        ' 
        ' lblHdrPills
        ' 
        lblHdrPills.Location = New System.Drawing.Point(168, 22)
        lblHdrPills.Name = "lblHdrPills"
        lblHdrPills.Size = New System.Drawing.Size(66, 30)
        lblHdrPills.TabIndex = 1
        lblHdrPills.Text = "Pills" & vbCrLf & "Started"
        lblHdrPills.TextAlign = Drawing.ContentAlignment.BottomCenter
        ' 
        ' lblHdrDose
        ' 
        lblHdrDose.Location = New System.Drawing.Point(240, 22)
        lblHdrDose.Name = "lblHdrDose"
        lblHdrDose.Size = New System.Drawing.Size(66, 30)
        lblHdrDose.TabIndex = 2
        lblHdrDose.Text = "Daily" & vbCrLf & "Dosage"
        lblHdrDose.TextAlign = Drawing.ContentAlignment.BottomCenter
        ' 
        ' lblHdrRefills
        ' 
        lblHdrRefills.Location = New System.Drawing.Point(658, 22)
        lblHdrRefills.Name = "lblHdrRefills"
        lblHdrRefills.Size = New System.Drawing.Size(50, 30)
        lblHdrRefills.TabIndex = 3
        lblHdrRefills.Text = "Refills"
        lblHdrRefills.TextAlign = Drawing.ContentAlignment.BottomCenter
        ' 
        ' lblHdrLeft
        ' 
        lblHdrLeft.Location = New System.Drawing.Point(322, 22)
        lblHdrLeft.Name = "lblHdrLeft"
        lblHdrLeft.Size = New System.Drawing.Size(66, 30)
        lblHdrLeft.TabIndex = 4
        lblHdrLeft.Text = "Pills" & vbCrLf & "Remaining"
        lblHdrLeft.TextAlign = Drawing.ContentAlignment.BottomCenter
        ' 
        ' lblHdrDays
        ' 
        lblHdrDays.Location = New System.Drawing.Point(394, 22)
        lblHdrDays.Name = "lblHdrDays"
        lblHdrDays.Size = New System.Drawing.Size(58, 30)
        lblHdrDays.TabIndex = 5
        lblHdrDays.Text = "Days" & vbCrLf & "Remaining"
        lblHdrDays.TextAlign = Drawing.ContentAlignment.BottomCenter
        ' 
        ' lblHdrRem
        ' 
        lblHdrRem.Location = New System.Drawing.Point(458, 22)
        lblHdrRem.Name = "lblHdrRem"
        lblHdrRem.Size = New System.Drawing.Size(92, 30)
        lblHdrRem.TabIndex = 6
        lblHdrRem.Text = "Reminder" & vbCrLf & "Date"
        lblHdrRem.TextAlign = Drawing.ContentAlignment.BottomCenter
        ' 
        ' lblHdrRun
        ' 
        lblHdrRun.Location = New System.Drawing.Point(556, 22)
        lblHdrRun.Name = "lblHdrRun"
        lblHdrRun.Size = New System.Drawing.Size(92, 30)
        lblHdrRun.TabIndex = 7
        lblHdrRun.Text = "Run-out" & vbCrLf & "Date"
        lblHdrRun.TextAlign = Drawing.ContentAlignment.BottomCenter
        ' 
        ' txtMed1
        ' 
        txtMed1.Location = New System.Drawing.Point(12, 58)
        txtMed1.MaxLength = 20
        txtMed1.Name = "txtMed1"
        txtMed1.Size = New System.Drawing.Size(150, 23)
        txtMed1.TabIndex = 8
        ' 
        ' nudPills1
        ' 
        nudPills1.Location = New System.Drawing.Point(168, 58)
        nudPills1.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        nudPills1.Name = "nudPills1"
        nudPills1.Size = New System.Drawing.Size(66, 23)
        nudPills1.TabIndex = 9
        ' 
        ' nudDose1
        ' 
        nudDose1.DecimalPlaces = 2
        nudDose1.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        nudDose1.Location = New System.Drawing.Point(240, 58)
        nudDose1.Maximum = New Decimal(New Integer() {9999, 0, 0, 131072})
        nudDose1.Name = "nudDose1"
        nudDose1.Size = New System.Drawing.Size(66, 23)
        nudDose1.TabIndex = 10
        ' 
        ' txtRefills1
        ' 
        txtRefills1.Location = New System.Drawing.Point(658, 58)
        txtRefills1.MaxLength = 3
        txtRefills1.Name = "txtRefills1"
        txtRefills1.Size = New System.Drawing.Size(50, 23)
        txtRefills1.TabIndex = 11
        ' 
        ' lblPillsLeft1
        ' 
        lblPillsLeft1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblPillsLeft1.Location = New System.Drawing.Point(322, 58)
        lblPillsLeft1.Name = "lblPillsLeft1"
        lblPillsLeft1.Size = New System.Drawing.Size(66, 23)
        lblPillsLeft1.TabIndex = 12
        lblPillsLeft1.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblDaysLeft1
        ' 
        lblDaysLeft1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblDaysLeft1.Location = New System.Drawing.Point(394, 58)
        lblDaysLeft1.Name = "lblDaysLeft1"
        lblDaysLeft1.Size = New System.Drawing.Size(58, 23)
        lblDaysLeft1.TabIndex = 13
        lblDaysLeft1.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblReminder1
        ' 
        lblReminder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblReminder1.Location = New System.Drawing.Point(458, 58)
        lblReminder1.Name = "lblReminder1"
        lblReminder1.Size = New System.Drawing.Size(92, 23)
        lblReminder1.TabIndex = 14
        lblReminder1.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblRunout1
        ' 
        lblRunout1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblRunout1.Location = New System.Drawing.Point(556, 58)
        lblRunout1.Name = "lblRunout1"
        lblRunout1.Size = New System.Drawing.Size(92, 23)
        lblRunout1.TabIndex = 15
        lblRunout1.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' txtMed2
        ' 
        txtMed2.Location = New System.Drawing.Point(12, 92)
        txtMed2.MaxLength = 20
        txtMed2.Name = "txtMed2"
        txtMed2.Size = New System.Drawing.Size(150, 23)
        txtMed2.TabIndex = 16
        ' 
        ' nudPills2
        ' 
        nudPills2.Location = New System.Drawing.Point(168, 92)
        nudPills2.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        nudPills2.Name = "nudPills2"
        nudPills2.Size = New System.Drawing.Size(66, 23)
        nudPills2.TabIndex = 17
        ' 
        ' nudDose2
        ' 
        nudDose2.DecimalPlaces = 2
        nudDose2.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        nudDose2.Location = New System.Drawing.Point(240, 92)
        nudDose2.Maximum = New Decimal(New Integer() {9999, 0, 0, 131072})
        nudDose2.Name = "nudDose2"
        nudDose2.Size = New System.Drawing.Size(66, 23)
        nudDose2.TabIndex = 18
        ' 
        ' txtRefills2
        ' 
        txtRefills2.Location = New System.Drawing.Point(658, 92)
        txtRefills2.MaxLength = 3
        txtRefills2.Name = "txtRefills2"
        txtRefills2.Size = New System.Drawing.Size(50, 23)
        txtRefills2.TabIndex = 19
        ' 
        ' lblPillsLeft2
        ' 
        lblPillsLeft2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblPillsLeft2.Location = New System.Drawing.Point(322, 92)
        lblPillsLeft2.Name = "lblPillsLeft2"
        lblPillsLeft2.Size = New System.Drawing.Size(66, 23)
        lblPillsLeft2.TabIndex = 20
        lblPillsLeft2.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblDaysLeft2
        ' 
        lblDaysLeft2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblDaysLeft2.Location = New System.Drawing.Point(394, 92)
        lblDaysLeft2.Name = "lblDaysLeft2"
        lblDaysLeft2.Size = New System.Drawing.Size(58, 23)
        lblDaysLeft2.TabIndex = 21
        lblDaysLeft2.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblReminder2
        ' 
        lblReminder2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblReminder2.Location = New System.Drawing.Point(458, 92)
        lblReminder2.Name = "lblReminder2"
        lblReminder2.Size = New System.Drawing.Size(92, 23)
        lblReminder2.TabIndex = 22
        lblReminder2.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblRunout2
        ' 
        lblRunout2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblRunout2.Location = New System.Drawing.Point(556, 92)
        lblRunout2.Name = "lblRunout2"
        lblRunout2.Size = New System.Drawing.Size(92, 23)
        lblRunout2.TabIndex = 23
        lblRunout2.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' txtMed3
        ' 
        txtMed3.Location = New System.Drawing.Point(12, 126)
        txtMed3.MaxLength = 20
        txtMed3.Name = "txtMed3"
        txtMed3.Size = New System.Drawing.Size(150, 23)
        txtMed3.TabIndex = 24
        ' 
        ' nudPills3
        ' 
        nudPills3.Location = New System.Drawing.Point(168, 126)
        nudPills3.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        nudPills3.Name = "nudPills3"
        nudPills3.Size = New System.Drawing.Size(66, 23)
        nudPills3.TabIndex = 25
        ' 
        ' nudDose3
        ' 
        nudDose3.DecimalPlaces = 2
        nudDose3.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        nudDose3.Location = New System.Drawing.Point(240, 126)
        nudDose3.Maximum = New Decimal(New Integer() {9999, 0, 0, 131072})
        nudDose3.Name = "nudDose3"
        nudDose3.Size = New System.Drawing.Size(66, 23)
        nudDose3.TabIndex = 26
        ' 
        ' txtRefills3
        ' 
        txtRefills3.Location = New System.Drawing.Point(658, 126)
        txtRefills3.MaxLength = 3
        txtRefills3.Name = "txtRefills3"
        txtRefills3.Size = New System.Drawing.Size(50, 23)
        txtRefills3.TabIndex = 27
        ' 
        ' lblPillsLeft3
        ' 
        lblPillsLeft3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblPillsLeft3.Location = New System.Drawing.Point(322, 126)
        lblPillsLeft3.Name = "lblPillsLeft3"
        lblPillsLeft3.Size = New System.Drawing.Size(66, 23)
        lblPillsLeft3.TabIndex = 28
        lblPillsLeft3.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblDaysLeft3
        ' 
        lblDaysLeft3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblDaysLeft3.Location = New System.Drawing.Point(394, 126)
        lblDaysLeft3.Name = "lblDaysLeft3"
        lblDaysLeft3.Size = New System.Drawing.Size(58, 23)
        lblDaysLeft3.TabIndex = 29
        lblDaysLeft3.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblReminder3
        ' 
        lblReminder3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblReminder3.Location = New System.Drawing.Point(458, 126)
        lblReminder3.Name = "lblReminder3"
        lblReminder3.Size = New System.Drawing.Size(92, 23)
        lblReminder3.TabIndex = 30
        lblReminder3.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblRunout3
        ' 
        lblRunout3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblRunout3.Location = New System.Drawing.Point(556, 126)
        lblRunout3.Name = "lblRunout3"
        lblRunout3.Size = New System.Drawing.Size(92, 23)
        lblRunout3.TabIndex = 31
        lblRunout3.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' txtMed4
        ' 
        txtMed4.Location = New System.Drawing.Point(12, 160)
        txtMed4.MaxLength = 20
        txtMed4.Name = "txtMed4"
        txtMed4.Size = New System.Drawing.Size(150, 23)
        txtMed4.TabIndex = 32
        ' 
        ' nudPills4
        ' 
        nudPills4.Location = New System.Drawing.Point(168, 160)
        nudPills4.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        nudPills4.Name = "nudPills4"
        nudPills4.Size = New System.Drawing.Size(66, 23)
        nudPills4.TabIndex = 33
        ' 
        ' nudDose4
        ' 
        nudDose4.DecimalPlaces = 2
        nudDose4.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        nudDose4.Location = New System.Drawing.Point(240, 160)
        nudDose4.Maximum = New Decimal(New Integer() {9999, 0, 0, 131072})
        nudDose4.Name = "nudDose4"
        nudDose4.Size = New System.Drawing.Size(66, 23)
        nudDose4.TabIndex = 34
        ' 
        ' txtRefills4
        ' 
        txtRefills4.Location = New System.Drawing.Point(658, 160)
        txtRefills4.MaxLength = 3
        txtRefills4.Name = "txtRefills4"
        txtRefills4.Size = New System.Drawing.Size(50, 23)
        txtRefills4.TabIndex = 35
        ' 
        ' lblPillsLeft4
        ' 
        lblPillsLeft4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblPillsLeft4.Location = New System.Drawing.Point(322, 160)
        lblPillsLeft4.Name = "lblPillsLeft4"
        lblPillsLeft4.Size = New System.Drawing.Size(66, 23)
        lblPillsLeft4.TabIndex = 36
        lblPillsLeft4.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblDaysLeft4
        ' 
        lblDaysLeft4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblDaysLeft4.Location = New System.Drawing.Point(394, 160)
        lblDaysLeft4.Name = "lblDaysLeft4"
        lblDaysLeft4.Size = New System.Drawing.Size(58, 23)
        lblDaysLeft4.TabIndex = 37
        lblDaysLeft4.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblReminder4
        ' 
        lblReminder4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblReminder4.Location = New System.Drawing.Point(458, 160)
        lblReminder4.Name = "lblReminder4"
        lblReminder4.Size = New System.Drawing.Size(92, 23)
        lblReminder4.TabIndex = 38
        lblReminder4.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblRunout4
        ' 
        lblRunout4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblRunout4.Location = New System.Drawing.Point(556, 160)
        lblRunout4.Name = "lblRunout4"
        lblRunout4.Size = New System.Drawing.Size(92, 23)
        lblRunout4.TabIndex = 39
        lblRunout4.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' grpMeds
        ' 
        grpMeds.Controls.Add(lblHdrMed)
        grpMeds.Controls.Add(lblHdrPills)
        grpMeds.Controls.Add(lblHdrDose)
        grpMeds.Controls.Add(lblHdrRefills)
        grpMeds.Controls.Add(lblHdrLeft)
        grpMeds.Controls.Add(lblHdrDays)
        grpMeds.Controls.Add(lblHdrRem)
        grpMeds.Controls.Add(lblHdrRun)
        grpMeds.Controls.Add(txtMed1)
        grpMeds.Controls.Add(nudPills1)
        grpMeds.Controls.Add(nudDose1)
        grpMeds.Controls.Add(txtRefills1)
        grpMeds.Controls.Add(lblPillsLeft1)
        grpMeds.Controls.Add(lblDaysLeft1)
        grpMeds.Controls.Add(lblReminder1)
        grpMeds.Controls.Add(lblRunout1)
        grpMeds.Controls.Add(txtMed2)
        grpMeds.Controls.Add(nudPills2)
        grpMeds.Controls.Add(nudDose2)
        grpMeds.Controls.Add(txtRefills2)
        grpMeds.Controls.Add(lblPillsLeft2)
        grpMeds.Controls.Add(lblDaysLeft2)
        grpMeds.Controls.Add(lblReminder2)
        grpMeds.Controls.Add(lblRunout2)
        grpMeds.Controls.Add(txtMed3)
        grpMeds.Controls.Add(nudPills3)
        grpMeds.Controls.Add(nudDose3)
        grpMeds.Controls.Add(txtRefills3)
        grpMeds.Controls.Add(lblPillsLeft3)
        grpMeds.Controls.Add(lblDaysLeft3)
        grpMeds.Controls.Add(lblReminder3)
        grpMeds.Controls.Add(lblRunout3)
        grpMeds.Controls.Add(txtMed4)
        grpMeds.Controls.Add(nudPills4)
        grpMeds.Controls.Add(nudDose4)
        grpMeds.Controls.Add(txtRefills4)
        grpMeds.Controls.Add(lblPillsLeft4)
        grpMeds.Controls.Add(lblDaysLeft4)
        grpMeds.Controls.Add(lblReminder4)
        grpMeds.Controls.Add(lblRunout4)
        grpMeds.Location = New System.Drawing.Point(12, 120)
        grpMeds.Name = "grpMeds"
        grpMeds.Size = New System.Drawing.Size(720, 205)
        grpMeds.TabIndex = 1
        grpMeds.TabStop = False
        grpMeds.Text = "Medications"
        ' 
        ' lblEarlyRemCaption
        ' 
        lblEarlyRemCaption.AutoSize = True
        lblEarlyRemCaption.Location = New System.Drawing.Point(12, 28)
        lblEarlyRemCaption.Name = "lblEarlyRemCaption"
        lblEarlyRemCaption.Size = New System.Drawing.Size(102, 15)
        lblEarlyRemCaption.TabIndex = 0
        lblEarlyRemCaption.Text = "Date of Reminder:"
        ' 
        ' lblEarlyRemValue
        ' 
        lblEarlyRemValue.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold)
        lblEarlyRemValue.Location = New System.Drawing.Point(200, 26)
        lblEarlyRemValue.Name = "lblEarlyRemValue"
        lblEarlyRemValue.Size = New System.Drawing.Size(480, 20)
        lblEarlyRemValue.TabIndex = 1
        ' 
        ' lblEarlyRunCaption
        ' 
        lblEarlyRunCaption.AutoSize = True
        lblEarlyRunCaption.Location = New System.Drawing.Point(12, 58)
        lblEarlyRunCaption.Name = "lblEarlyRunCaption"
        lblEarlyRunCaption.Size = New System.Drawing.Size(90, 15)
        lblEarlyRunCaption.TabIndex = 2
        lblEarlyRunCaption.Text = "Date of Runout:"
        ' 
        ' lblEarlyRunValue
        ' 
        lblEarlyRunValue.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold)
        lblEarlyRunValue.Location = New System.Drawing.Point(200, 56)
        lblEarlyRunValue.Name = "lblEarlyRunValue"
        lblEarlyRunValue.Size = New System.Drawing.Size(480, 20)
        lblEarlyRunValue.TabIndex = 3
        ' 
        ' lblStatusCaption
        ' 
        lblStatusCaption.AutoSize = True
        lblStatusCaption.Location = New System.Drawing.Point(12, 88)
        lblStatusCaption.Name = "lblStatusCaption"
        lblStatusCaption.Size = New System.Drawing.Size(42, 15)
        lblStatusCaption.TabIndex = 4
        lblStatusCaption.Text = "Status:"
        ' 
        ' lblStatusValue
        ' 
        lblStatusValue.Font = New System.Drawing.Font("Segoe UI", 10F, Drawing.FontStyle.Bold)
        lblStatusValue.Location = New System.Drawing.Point(200, 86)
        lblStatusValue.Name = "lblStatusValue"
        lblStatusValue.Size = New System.Drawing.Size(480, 20)
        lblStatusValue.TabIndex = 5
        ' 
        ' grpResults
        ' 
        grpResults.Controls.Add(lblEarlyRemCaption)
        grpResults.Controls.Add(lblEarlyRemValue)
        grpResults.Controls.Add(lblEarlyRunCaption)
        grpResults.Controls.Add(lblEarlyRunValue)
        grpResults.Controls.Add(lblStatusCaption)
        grpResults.Controls.Add(lblStatusValue)
        grpResults.Location = New System.Drawing.Point(12, 333)
        grpResults.Name = "grpResults"
        grpResults.Size = New System.Drawing.Size(720, 118)
        grpResults.TabIndex = 2
        grpResults.TabStop = False
        grpResults.Text = "Results"
        ' 
        ' txtNotes
        ' 
        txtNotes.AcceptsReturn = True
        txtNotes.Location = New System.Drawing.Point(12, 24)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        txtNotes.Size = New System.Drawing.Size(696, 184)
        txtNotes.TabIndex = 0
        ' 
        ' grpNotes
        ' 
        grpNotes.Controls.Add(txtNotes)
        grpNotes.Location = New System.Drawing.Point(12, 459)
        grpNotes.Name = "grpNotes"
        grpNotes.Size = New System.Drawing.Size(720, 220)
        grpNotes.TabIndex = 3
        grpNotes.TabStop = False
        grpNotes.Text = "Notes"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New System.Drawing.Point(744, 12)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New System.Drawing.Size(88, 32)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New System.Drawing.Point(838, 12)
        btnSave.Name = "btnSave"
        btnSave.Size = New System.Drawing.Size(88, 32)
        btnSave.TabIndex = 5
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New System.Drawing.Point(932, 12)
        btnClear.Name = "btnClear"
        btnClear.Size = New System.Drawing.Size(88, 32)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New System.Drawing.Point(1026, 12)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New System.Drawing.Size(88, 32)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New System.Drawing.Point(1120, 12)
        btnClose.Name = "btnClose"
        btnClose.Size = New System.Drawing.Size(88, 32)
        btnClose.TabIndex = 8
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' lblRecords
        ' 
        lblRecords.AutoSize = True
        lblRecords.Location = New System.Drawing.Point(744, 58)
        lblRecords.Name = "lblRecords"
        lblRecords.Size = New System.Drawing.Size(203, 15)
        lblRecords.TabIndex = 9
        lblRecords.Text = "Saved Records (click a row to load it):"
        ' 
        ' lvRecords
        ' 
        lvRecords.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {colName, colFacility, colReminder, colRunout, colDays})
        lvRecords.FullRowSelect = True
        lvRecords.GridLines = True
        lvRecords.Location = New System.Drawing.Point(744, 78)
        lvRecords.MultiSelect = False
        lvRecords.Name = "lvRecords"
        lvRecords.Size = New System.Drawing.Size(464, 601)
        lvRecords.TabIndex = 10
        lvRecords.UseCompatibleStateImageBehavior = False
        lvRecords.View = System.Windows.Forms.View.Details
        ' 
        ' colName
        ' 
        colName.Text = "Child Name"
        colName.Width = 110
        ' 
        ' colFacility
        ' 
        colFacility.Text = "Facility"
        colFacility.Width = 110
        ' 
        ' colReminder
        ' 
        colReminder.Text = "Reminder"
        colReminder.Width = 80
        ' 
        ' colRunout
        ' 
        colRunout.Text = "Run-out"
        colRunout.Width = 80
        ' 
        ' colDays
        ' 
        colDays.Text = "Days Left"
        ' 
        ' frmMain
        ' 
        AcceptButton = btnCalculate
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(1220, 692)
        Controls.Add(lvRecords)
        Controls.Add(lblRecords)
        Controls.Add(btnClose)
        Controls.Add(btnDelete)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(btnCalculate)
        Controls.Add(grpNotes)
        Controls.Add(grpResults)
        Controls.Add(grpMeds)
        Controls.Add(grpCase)
        Font = New System.Drawing.Font("Segoe UI", 9F)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmMain"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Detention Medication Tracker"
        grpCase.ResumeLayout(False)
        grpCase.PerformLayout()
        CType(nudPills1, ComponentModel.ISupportInitialize).EndInit()
        CType(nudDose1, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPills2, ComponentModel.ISupportInitialize).EndInit()
        CType(nudDose2, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPills3, ComponentModel.ISupportInitialize).EndInit()
        CType(nudDose3, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPills4, ComponentModel.ISupportInitialize).EndInit()
        CType(nudDose4, ComponentModel.ISupportInitialize).EndInit()
        grpMeds.ResumeLayout(False)
        grpMeds.PerformLayout()
        grpResults.ResumeLayout(False)
        grpResults.PerformLayout()
        grpNotes.ResumeLayout(False)
        grpNotes.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblFacility As System.Windows.Forms.Label
    Friend WithEvents txtFacility As System.Windows.Forms.TextBox
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpCase As System.Windows.Forms.GroupBox
    Friend WithEvents lblHdrMed As System.Windows.Forms.Label
    Friend WithEvents lblHdrPills As System.Windows.Forms.Label
    Friend WithEvents lblHdrDose As System.Windows.Forms.Label
    Friend WithEvents lblHdrRefills As System.Windows.Forms.Label
    Friend WithEvents lblHdrLeft As System.Windows.Forms.Label
    Friend WithEvents lblHdrDays As System.Windows.Forms.Label
    Friend WithEvents lblHdrRem As System.Windows.Forms.Label
    Friend WithEvents lblHdrRun As System.Windows.Forms.Label
    Friend WithEvents txtMed1 As System.Windows.Forms.TextBox
    Friend WithEvents nudPills1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudDose1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtRefills1 As System.Windows.Forms.TextBox
    Friend WithEvents lblPillsLeft1 As System.Windows.Forms.Label
    Friend WithEvents lblDaysLeft1 As System.Windows.Forms.Label
    Friend WithEvents lblReminder1 As System.Windows.Forms.Label
    Friend WithEvents lblRunout1 As System.Windows.Forms.Label
    Friend WithEvents txtMed2 As System.Windows.Forms.TextBox
    Friend WithEvents nudPills2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudDose2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtRefills2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPillsLeft2 As System.Windows.Forms.Label
    Friend WithEvents lblDaysLeft2 As System.Windows.Forms.Label
    Friend WithEvents lblReminder2 As System.Windows.Forms.Label
    Friend WithEvents lblRunout2 As System.Windows.Forms.Label
    Friend WithEvents txtMed3 As System.Windows.Forms.TextBox
    Friend WithEvents nudPills3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudDose3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtRefills3 As System.Windows.Forms.TextBox
    Friend WithEvents lblPillsLeft3 As System.Windows.Forms.Label
    Friend WithEvents lblDaysLeft3 As System.Windows.Forms.Label
    Friend WithEvents lblReminder3 As System.Windows.Forms.Label
    Friend WithEvents lblRunout3 As System.Windows.Forms.Label
    Friend WithEvents txtMed4 As System.Windows.Forms.TextBox
    Friend WithEvents nudPills4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudDose4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtRefills4 As System.Windows.Forms.TextBox
    Friend WithEvents lblPillsLeft4 As System.Windows.Forms.Label
    Friend WithEvents lblDaysLeft4 As System.Windows.Forms.Label
    Friend WithEvents lblReminder4 As System.Windows.Forms.Label
    Friend WithEvents lblRunout4 As System.Windows.Forms.Label
    Friend WithEvents grpMeds As System.Windows.Forms.GroupBox
    Friend WithEvents lblEarlyRemCaption As System.Windows.Forms.Label
    Friend WithEvents lblEarlyRemValue As System.Windows.Forms.Label
    Friend WithEvents lblEarlyRunCaption As System.Windows.Forms.Label
    Friend WithEvents lblEarlyRunValue As System.Windows.Forms.Label
    Friend WithEvents lblStatusCaption As System.Windows.Forms.Label
    Friend WithEvents lblStatusValue As System.Windows.Forms.Label
    Friend WithEvents grpResults As System.Windows.Forms.GroupBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents grpNotes As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents lvRecords As System.Windows.Forms.ListView
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFacility As System.Windows.Forms.ColumnHeader
    Friend WithEvents colReminder As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRunout As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDays As System.Windows.Forms.ColumnHeader

End Class
