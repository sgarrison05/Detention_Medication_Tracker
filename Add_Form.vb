Public Class frmAdd

    Public Property IncomingOriginalName As String
    Public Property IncomingChildName As String
    Public Property IncomingFacility As String
    Public Property IncomingDateDetained As DateTime = DateTime.Today()
    Public Property IncomingStartDate As DateTime = DateTime.Today()
    Public Property IncomingEndDate As DateTime = DateTime.Today().AddDays(10)
    Public Property IncomingMedication As String
    Public Property IncomingPills As Integer = 0
    Public Property isEditMode As Boolean = False 'False = Add Mode, True = Edit Mode

    Private childName As String
    Private dteStart As Date = dtpDetStart.Value
    Private dteEnd As Date
    Private medication(4) As String
    Private pillsStarted(4) As Integer
    Private dailyDosage(4) As Integer
    Private reminderDate As Date
    Private reminderDate2 As Date
    Private reminderDate3 As Date
    Private reminderDate4 As Date
    Private runoutDate As Date
    Private runoutDate2 As Date
    Private runoutDate3 As Date
    Private runoutDate4 As Date

#Region "=============== Main Form Events ================"

    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles Me.Load

        RefillCombo()
        FillData()

    End Sub

#End Region

#Region "============== Functions and Subroutines =============="

    ' TODO: Create Calculations for Date Runout and Reminder based on Start Date and # of Pills

    Private Sub FillData()

        If isEditMode Then
            txbChildName.Text = IncomingChildName
            cmbDetFacility.SelectedItem = IncomingFacility
            dtpDetStart.Value = IncomingDateDetained
            txbMed1.Text = IncomingMedication
            txbMed2.Text = Nothing
            txbMed3.Text = Nothing
            txbMed4.Text = Nothing
            txbStart1.Text = IncomingPills.ToString()
            txbStart2.Text = Nothing
            txbStart3.Text = Nothing
            txbStart4.Text = Nothing
            txbDosage1.Text = "1"
            txbDosage2.Text = "1"
            txbDosage3.Text = "1"
            txbDosage4.Text = "1"
            txbRefill1.Text = "0"
            txbRefill2.Text = "0"
            txbRefill3.Text = "0"
            txbRefill4.Text = "0"
            txbNotes.Text = Nothing

        Else
            ClearForm()
            txbChildName.Text = IncomingChildName
        End If

        dteStart = CDate(dtpDetStart.Value)
        dteEnd = dteStart.AddDays(10)

    End Sub

    Private Sub RefillCombo()

        cmbDetFacility.Items.Add("[Select/Enter Facility]")
        cmbDetFacility.Items.Add("Minnie Rogers")
        cmbDetFacility.Items.Add("Hardin County")
        cmbDetFacility.Items.Add("Montgomery County")
        cmbDetFacility.Items.Add("Galveston County")
        cmbDetFacility.Items.Add("Ft. Bend County")
        cmbDetFacility.Items.Add("Angelina County")
        cmbDetFacility.Items.Add("Gregg County")
        cmbDetFacility.Items.Add("Victoria County")
        cmbDetFacility.Items.Add("Nueches County")
        cmbDetFacility.SelectedIndex = 0

    End Sub

    Private Sub WriteHeader(filepath As String)

        My.Computer.FileSystem.WriteAllText(filepath,
                                            "Child Name:".PadRight(20) & vbTab &
                                            "Detention Facility:" & vbTab &
                                            "Date Detained:" & vbTab &
                                            "Medication:" & vbTab &
                                            "# Pills Started:" & vbTab &
                                            "Daily Dosage:" & vbTab &
                                            "# Pills Remaining:" & vbTab &
                                            "# Days Remaining:" & vbTab &
                                            "Reminder Date:" & vbTab &
                                            "Runout Date:" & vbTab &
                                            "Notes:" & vbCrLf &
                                            "-----------".PadRight(20) & vbTab &
                                            "---------------".PadRight(18) & vbTab &
                                            "------------".PadRight(18) & vbTab &
                                            "--------------".PadRight(20) & vbTab &
                                            "----------" & vbTab &
                                            "----------" & vbTab &
                                            "----------" & vbTab &
                                            "----------" & vbTab &
                                            "----------".PadRight(14) & vbTab &
                                            "----------" & vbTab &
                                            "----------" & ControlChars.NewLine, True)

    End Sub

    Private Sub WriteDataLine(filepath As String)

        CalculateRunoutAndReminder()

        Dim Facility As String = cmbDetFacility.SelectedItem.ToString()

        My.Computer.FileSystem.WriteAllText(filepath,
                                            childName.PadRight(20) & vbTab &
                                            Facility.PadRight(18) & vbTab &
                                            dteStart.ToShortDateString().PadRight(18) & vbTab &
                                            txbMed1.Text.PadRight(20) & vbTab &
                                            txbStart1.Text.PadRight(10) & vbTab &
                                            txbDosage1.Text.PadRight(10) & vbTab &
                                            lblRemain1.Text.PadRight(10) & vbTab &
                                            lblDaysRemain1.Text.PadRight(10) & vbTab &
                                            reminderDate.ToString.PadRight(10) & vbTab &
                                            runoutDate.ToString.PadRight(10) & vbTab &
                                            txbNotes.Text & ControlChars.NewLine &
                                            txbMed2.Text.PadRight(20) & vbTab &
                                            txbStart2.Text.PadRight(10) & vbTab &
                                            txbDosage2.Text.PadRight(10) & vbTab &
                                            lblRemain2.Text.PadRight(10) & vbTab &
                                            lblDaysRemain2.Text.PadRight(10) & vbTab &
                                            reminderDate2.ToString.PadRight(10) & vbTab &
                                            runoutDate2.ToString.PadRight(10) & ControlChars.NewLine &
                                            txbMed3.Text.PadRight(20) & vbTab &
                                            txbStart3.Text.PadRight(10) & vbTab &
                                            txbDosage3.Text.PadRight(10) & vbTab &
                                            lblRemain2.Text.PadRight(10) & vbTab &
                                            lblDaysRemain3.Text.PadRight(10) & vbTab &
                                            reminderDate3.ToString.PadRight(10) & vbTab &
                                            runoutDate3.ToString.PadRight(10) & ControlChars.NewLine &
                                            txbMed4.Text.PadRight(20) & vbTab &
                                            txbStart4.Text.PadRight(10) & vbTab &
                                            txbDosage4.Text.PadRight(10) & vbTab &
                                            lblRemain4.Text.PadRight(10) & vbTab &
                                            lblDaysRemain4.Text.PadRight(10) & vbTab &
                                            reminderDate4.ToString.PadRight(10) & vbTab &
                                            runoutDate4.ToString.PadRight(10) & ControlChars.NewLine, True)
    End Sub

    Private Sub CreateEntry()

        If String.IsNullOrWhiteSpace(txbChildName.Text) Then
            MessageBox.Show("Please enter a child name.",
                    "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txbChildName.Focus()
            Return
        End If

        ' Assign field values to variables
        ChildName = txbChildName.Text

        Dim targetFile As String = frmMain.mfile

        Try

            If My.Computer.FileSystem.FileExists(targetFile) Then

                WriteDataLine(targetFile)

            Else

                'Creates the Directory/File and writes the header and first line of data
                My.Computer.FileSystem.CreateDirectory(frmMain.mdirectory)
                WriteHeader(targetFile)
                WriteDataLine(targetFile)

            End If

            ' Confirm successful save to user
            MessageBox.Show("Record for " & ChildName & " has been saved.",
                            "Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearForm()


        Catch ex As Exception

            MessageBox.Show("Error Saving Record: " & ex.Message,
                            "Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub ClearForm()

        txbChildName.Clear()
        cmbDetFacility.SelectedIndex = 0
        dtpDetStart.Value = DateTime.Today()
        txbMed1.Clear()
        txbMed2.Clear()
        txbMed3.Clear()
        txbMed4.Clear()
        txbStart1.Clear()
        txbStart2.Clear()
        txbStart3.Clear()
        txbStart4.Clear()
        txbDosage1.Clear()
        txbDosage2.Clear()
        txbDosage3.Clear()
        txbDosage4.Clear()
        lblRemain1.Text = String.Empty
        lblRemain2.Text = String.Empty
        lblRemain3.Text = String.Empty
        lblRemain4.Text = String.Empty
        lblDaysRemain1.Text = String.Empty
        lblDaysRemain2.Text = String.Empty
        lblDaysRemain3.Text = String.Empty
        lblDaysRemain4.Text = String.Empty
        txbNotes.Clear()

    End Sub

    Private Sub CalculateRunoutAndReminder()

        'TODO: calculations for each medication

    End Sub

#End Region

#Region "==============  Button Click Events  =============="

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Warn user if fields have data before closing
        If Not String.IsNullOrWhiteSpace(txbChildName.Text) Then
            Dim confirm As DialogResult = MessageBox.Show(
                "You have unsaved data. Are you sure you want to return?",
                "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2)
            If confirm = DialogResult.No Then Return
        End If

        frmSearch.Show()
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ' TODO: CreateEntry() function to save data to file

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' TODO: ClearForm() function to clear all input fields

    End Sub


#End Region


End Class