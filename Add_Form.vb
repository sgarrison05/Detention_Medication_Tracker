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

    Public ChildName As String
    Public Facility As String
    Public Medication As String
    Private dteStart As Date
    Private dteEnd As Date
#Region "=============== Main Form Events ================"

    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles Me.Load

        RefillCombo()
        FillData()

    End Sub

#End Region

#Region "============== Functions and Subroutines =============="

    ' TODO: Create FillData(), Create Entry(), WriteDataLine(), and WriteHeader() Subroutines
    ' to fill form fields with data

    Private Sub FillData()

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
        My.Computer.FileSystem.WriteAllText(filepath,
                                            ChildName.PadRight(20) & vbTab &
                                            Facility.PadRight(18) & vbTab &
                                            dteStart.ToShortDateString().PadRight(18) & vbTab &
                                            Medication.PadRight(20) & vbTab &
                                            txbStart1.Text.PadRight(10) & vbTab &
                                            txbDosage1.Text.PadRight(10) & vbTab &
                                            lblRemain1.Text.PadRight(10) & vbTab &
                                            lblDaysRemain1.Text.PadRight(10) & vbTab &
                                            dtpReminderDate.PadRight(10) & vbTab &
                                            dtpRunoutDate.PadRight(10) & vbTab &
                                            txbNotes.Text & ControlChars.NewLine, True)
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