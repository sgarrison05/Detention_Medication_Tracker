Option Strict On
Option Explicit On
Option Infer On

Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class frmMain

#Region "Constants and fields"

    Private Const APP_TITLE As String = "Detention Medication Tracker"

    Private Const DATA_FOLDER As String = "C:\DetentionMedicationTracker"
    Private Const DATA_FILE As String = DATA_FOLDER & "\MedicationTracker.txt"

    Private Const DATE_FORMAT As String = "MM-dd-yyyy"
    Private Const ID_PREFIX As String = "JV-"
    Private Const MED_COUNT As Integer = 4
    Private Const REMINDER_DAYS As Integer = 7          ' Reminder falls this many days before the run-out date
    Private Const GAP_TEXT As String = "  "              ' Two spaces between file columns

    ' ----- Data file column layout (one line per child) -----
    ' Columns 0-4 are case information. Columns 5-16 are four groups of three (medication name, pills started,
    ' daily dose). Column 17 is the notes column, which runs to the end of the line.
    Private Const C_ID As Integer = 0
    Private Const C_NAME As Integer = 1
    Private Const C_FACILITY As Integer = 2
    Private Const C_START As Integer = 3
    Private Const C_REFILLS As Integer = 4
    Private Const C_MED_FIRST As Integer = 5
    Private Const C_NOTES As Integer = 17

    Private Shared ReadOnly COL_TITLES As String() = New String() {
        "ID", "CHILD NAME", "FACILITY", "START DATE", "REFILLS",
        "M1 NAME", "M1 PILLS", "M1 DOSE",
        "M2 NAME", "M2 PILLS", "M2 DOSE",
        "M3 NAME", "M3 PILLS", "M3 DOSE",
        "M4 NAME", "M4 PILLS", "M4 DOSE",
        "NOTES"}

    ' Widths of columns 0-16 (the notes column has no fixed width).
    Private Shared ReadOnly COL_WIDTHS As Integer() = New Integer() {
        9, 25, 25, 10, 7,
        20, 8, 7,
        20, 8, 7,
        20, 8, 7,
        20, 8, 7}

    ' ----- Data classes -----
    Private Class MedEntry
        Public Property Name As String = ""
        Public Property PillsStarted As Decimal
        Public Property DailyDose As Decimal
    End Class

    Private Class MedicationRecord
        Public Property Id As String = ""
        Public Property ChildName As String = ""
        Public Property Facility As String = ""
        Public Property StartDate As Date
        Public Property Refills As String = ""      ' Stored only; never used in a calculation
        Public Property Notes As String = ""
        Public Property Meds As MedEntry()

        Public Sub New()
            Meds = New MedEntry(MED_COUNT - 1) {}
            For i As Integer = 0 To MED_COUNT - 1
                Meds(i) = New MedEntry()
            Next
        End Sub
    End Class

    ' Calculated values for one medication.
    Private Structure MedResult
        Public InUse As Boolean
        Public NotStarted As Boolean
        Public PillsRemaining As Decimal
        Public DaysRemaining As Integer
        Public ReminderDate As Date
        Public RunoutDate As Date
    End Structure

    ' Calculated values for a whole record: one result per medication plus the earliest dates and a status.
    Private Class MedEvaluation
        Public Results As MedResult() = New MedResult(MED_COUNT - 1) {}
        Public HasMeds As Boolean
        Public EarliestName As String = ""
        Public EarliestReminder As Date
        Public EarliestRunout As Date
        Public DaysRemaining As Integer
        Public StatusText As String = ""
        Public StatusColor As Color
        Public IsOut As Boolean
        Public ReminderDue As Boolean
    End Class

    Private ReadOnly _records As New List(Of MedicationRecord)()
    Private ReadOnly _rng As New Random()

    Private _currentId As String = ""      ' Id of the saved record loaded in the form ("" = new record)
    Private _loading As Boolean = False    ' Suppresses event handlers while the form is populated in code
    Private _lastRefreshDate As Date = Date.Today

    ' The four medication rows, as arrays so they can be processed in loops.
    Private _medName As TextBox()
    Private _medPills As NumericUpDown()
    Private _medDose As NumericUpDown()
    Private _lblPills As Label()
    Private _lblDays As Label()
    Private _lblReminder As Label()
    Private _lblRunout As Label()

#End Region

#Region "Form events"

    Public Sub New()
        InitializeComponent()
        InitControlArrays()
    End Sub

    Private Sub InitControlArrays()
        _medName = New TextBox() {txtMed1, txtMed2, txtMed3, txtMed4}
        _medPills = New NumericUpDown() {nudPills1, nudPills2, nudPills3, nudPills4}
        _medDose = New NumericUpDown() {nudDose1, nudDose2, nudDose3, nudDose4}
        _lblPills = New Label() {lblPillsLeft1, lblPillsLeft2, lblPillsLeft3, lblPillsLeft4}
        _lblDays = New Label() {lblDaysLeft1, lblDaysLeft2, lblDaysLeft3, lblDaysLeft4}
        _lblReminder = New Label() {lblReminder1, lblReminder2, lblReminder3, lblReminder4}
        _lblRunout = New Label() {lblRunout1, lblRunout2, lblRunout3, lblRunout4}

        For i As Integer = 0 To MED_COUNT - 1
            _medName(i).MaxLength = COL_WIDTHS(C_MED_FIRST)
            AddHandler _medName(i).TextChanged, AddressOf InputsChanged
            AddHandler _medPills(i).ValueChanged, AddressOf InputsChanged
            AddHandler _medDose(i).ValueChanged, AddressOf InputsChanged
        Next
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Entries cannot be longer than their file columns, so nothing is ever truncated.
        txtName.MaxLength = COL_WIDTHS(C_NAME)
        txtFacility.MaxLength = COL_WIDTHS(C_FACILITY)
        txtRefills.MaxLength = 3

        Try
            If Not Directory.Exists(DATA_FOLDER) Then Directory.CreateDirectory(DATA_FOLDER)
        Catch ex As Exception
            MessageBox.Show("Could not create the data folder " & DATA_FOLDER & "." & vbCrLf & vbCrLf & ex.Message,
                            APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        LoadRecords()
        ClearForm()
        RefreshList()
    End Sub

    ' If the app was left open overnight, bring the day counts up to date.
    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If _lastRefreshDate <> Date.Today Then
            RefreshList()
            If _currentId <> "" Then
                Dim meds As MedEntry() = Nothing
                If TryReadMeds(False, meds) Then ShowResults(Evaluate(dtpStart.Value.Date, meds, Date.Today))
            End If
        End If
    End Sub

    ' Any change to an input that drives the calculation makes the displayed results stale.
    Private Sub InputsChanged(sender As Object, e As EventArgs) Handles dtpStart.ValueChanged
        If _loading Then Return
        ResetResults()
    End Sub

    ' The refills box accepts digits only.
    Private Sub txtRefills_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRefills.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub lvRecords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvRecords.SelectedIndexChanged
        If _loading Then Return
        If lvRecords.SelectedItems.Count = 0 Then Return

        Dim id As String = CStr(lvRecords.SelectedItems(0).Tag)
        Dim rec As MedicationRecord = _records.FirstOrDefault(Function(r) r.Id = id)
        If rec IsNot Nothing Then LoadRecordIntoForm(rec)
    End Sub

#End Region

#Region "Button handlers"

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim meds As MedEntry() = Nothing
        If Not TryReadMeds(True, meds) Then Return
        ShowResults(Evaluate(dtpStart.Value.Date, meds, Date.Today))
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim childName As String = txtName.Text.Trim()
        Dim facility As String = txtFacility.Text.Trim()

        If childName = "" Then
            MessageBox.Show("Please enter the child's name.", APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtName.Focus()
            Return
        End If
        If facility = "" Then
            MessageBox.Show("Please enter the detention facility.", APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFacility.Focus()
            Return
        End If

        Dim meds As MedEntry() = Nothing
        If Not TryReadMeds(True, meds) Then Return
        ShowResults(Evaluate(dtpStart.Value.Date, meds, Date.Today))

        ' Update the loaded record if there is one; otherwise create a new one.
        Dim rec As MedicationRecord = Nothing
        If _currentId <> "" Then
            Dim id As String = _currentId
            rec = _records.FirstOrDefault(Function(r) r.Id = id)
        End If
        If rec Is Nothing Then
            rec = New MedicationRecord()
            rec.Id = GenerateId()
            _records.Add(rec)
        End If

        rec.ChildName = childName
        rec.Facility = facility
        rec.StartDate = dtpStart.Value.Date
        rec.Refills = Regex.Replace(txtRefills.Text, "[^0-9]", "")
        rec.Meds = meds
        rec.Notes = txtNotes.Text

        If Not WriteAllRecords() Then
            LoadRecords()   ' Resynchronize memory with what is actually on disk
            RefreshList()
            Return
        End If

        _currentId = rec.Id
        RefreshList()
        UpdateButtons()
        MessageBox.Show("Record saved.", APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearForm()
        txtName.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
        txtName.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If _currentId = "" Then
            MessageBox.Show("Click a saved record in the list first, then press Delete.",
                            APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim id As String = _currentId
        Dim rec As MedicationRecord = _records.FirstOrDefault(Function(r) r.Id = id)
        If rec Is Nothing Then
            ClearForm()
            Return
        End If

        Dim answer As DialogResult = MessageBox.Show(
            "Delete the record for " & rec.ChildName & " (" & rec.Facility & ")?" & vbCrLf & vbCrLf & "This cannot be undone.",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If answer <> DialogResult.Yes Then Return

        _records.Remove(rec)

        If Not WriteAllRecords() Then
            LoadRecords()
            RefreshList()
            Return
        End If

        ClearForm()
        RefreshList()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

#Region "Calculation"

    ' Reads and validates the four medication rows. A row with a blank name is ignored.
    Private Function TryReadMeds(showMessages As Boolean, ByRef meds As MedEntry()) As Boolean
        meds = New MedEntry(MED_COUNT - 1) {}
        Dim anyUsed As Boolean = False

        For i As Integer = 0 To MED_COUNT - 1
            Dim m As New MedEntry()
            m.Name = _medName(i).Text.Trim()
            m.PillsStarted = _medPills(i).Value
            m.DailyDose = _medDose(i).Value
            meds(i) = m

            Dim rowNumber As String = (i + 1).ToString(CultureInfo.InvariantCulture)

            If m.Name = "" Then
                If m.PillsStarted > 0D OrElse m.DailyDose > 0D Then
                    Return Fail(showMessages, "Medication " & rowNumber & " has a pill count or dosage but no name." & vbCrLf &
                                "Enter the medication name, or set both numbers back to 0.", _medName(i))
                End If
            Else
                If m.PillsStarted <= 0D Then
                    Return Fail(showMessages, "Enter the number of pills started for " & m.Name & ".", _medPills(i))
                End If
                If m.DailyDose <= 0D Then
                    Return Fail(showMessages, "Enter the daily dosage (pills per day) for " & m.Name & ".", _medDose(i))
                End If
                anyUsed = True
            End If
        Next

        If Not anyUsed Then
            Return Fail(showMessages, "Enter at least one medication with its pills started and daily dosage.", _medName(0))
        End If
        Return True
    End Function

    Private Function Fail(showMessages As Boolean, message As String, target As Control) As Boolean
        If showMessages Then
            MessageBox.Show(message, APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information)
            target.Focus()
        End If
        Return False
    End Function

    ' Calculates every medication and the earliest reminder/run-out across the ones in use.
    Private Shared Function Evaluate(startDate As Date, meds As MedEntry(), today As Date) As MedEvaluation
        Dim ev As New MedEvaluation()

        For i As Integer = 0 To MED_COUNT - 1
            Dim m As MedEntry = meds(i)
            If m.Name = "" OrElse m.PillsStarted <= 0D OrElse m.DailyDose <= 0D Then Continue For

            Dim r As MedResult = ComputeMed(startDate, m.PillsStarted, m.DailyDose, today)
            ev.Results(i) = r

            If Not ev.HasMeds OrElse r.RunoutDate < ev.EarliestRunout Then
                ev.HasMeds = True
                ev.EarliestName = m.Name
                ev.EarliestReminder = r.ReminderDate
                ev.EarliestRunout = r.RunoutDate
                ev.DaysRemaining = r.DaysRemaining
            End If
        Next

        If ev.HasMeds Then
            ev.IsOut = (ev.EarliestRunout < today)
            ev.ReminderDue = (today >= ev.EarliestReminder)

            If ev.IsOut Then
                ev.StatusText = "OUT OF MEDICATION - " & ev.EarliestName
                ev.StatusColor = Color.Firebrick
            ElseIf ev.ReminderDue Then
                ev.StatusText = "REFILL REMINDER - " & ev.EarliestName
                ev.StatusColor = Color.DarkOrange
            Else
                ev.StatusText = "OK"
                ev.StatusColor = Color.ForestGreen
            End If
        End If

        Return ev
    End Function

    ' The start date is day 1 and the child takes the daily dose every day from then on.
    ' Pills remaining is the count at the start of today (before today's dose).
    Private Shared Function ComputeMed(startDate As Date, pillsStarted As Decimal, dailyDose As Decimal, today As Date) As MedResult
        Dim r As New MedResult()
        r.InUse = True

        ' Days the supply lasts (a final partial day counts); the last of them is the run-out date.
        Dim totalDays As Integer = CInt(Math.Ceiling(pillsStarted / dailyDose))
        r.RunoutDate = startDate.Date.AddDays(totalDays - 1)
        r.ReminderDate = r.RunoutDate.AddDays(-REMINDER_DAYS)

        Dim elapsed As Integer = CInt((today.Date - startDate.Date).TotalDays)
        If elapsed < 0 Then
            r.NotStarted = True      ' Refill/start date is still in the future: nothing used yet
            elapsed = 0
        End If

        r.PillsRemaining = Math.Max(0D, pillsStarted - dailyDose * elapsed)
        If r.PillsRemaining <= 0D Then
            r.DaysRemaining = 0
        Else
            r.DaysRemaining = CInt(Math.Ceiling(r.PillsRemaining / dailyDose))
        End If

        Return r
    End Function

    Private Sub ShowResults(ev As MedEvaluation)
        Dim today As Date = Date.Today

        For i As Integer = 0 To MED_COUNT - 1
            Dim r As MedResult = ev.Results(i)

            If Not r.InUse Then
                _lblPills(i).Text = ""
                _lblDays(i).Text = ""
                _lblReminder(i).Text = ""
                _lblRunout(i).Text = ""
                Continue For
            End If

            _lblPills(i).Text = r.PillsRemaining.ToString("0.##", CultureInfo.CurrentCulture)
            _lblDays(i).Text = r.DaysRemaining.ToString(CultureInfo.CurrentCulture)
            _lblReminder(i).Text = r.ReminderDate.ToString(DATE_FORMAT, CultureInfo.InvariantCulture)
            _lblRunout(i).Text = r.RunoutDate.ToString(DATE_FORMAT, CultureInfo.InvariantCulture)

            Dim isOut As Boolean = (r.RunoutDate < today)
            Dim reminderDue As Boolean = (today >= r.ReminderDate)

            _lblPills(i).ForeColor = If(isOut, Color.Firebrick, SystemColors.ControlText)
            _lblDays(i).ForeColor = If(isOut, Color.Firebrick, SystemColors.ControlText)
            _lblRunout(i).ForeColor = If(isOut, Color.Firebrick, SystemColors.ControlText)
            _lblReminder(i).ForeColor = If(isOut, Color.Firebrick, If(reminderDue, Color.DarkOrange, SystemColors.ControlText))
        Next

        If ev.HasMeds Then
            lblEarlyRemValue.Text = ev.EarliestReminder.ToString(DATE_FORMAT, CultureInfo.InvariantCulture) & "  (" & ev.EarliestName & ")"
            lblEarlyRunValue.Text = ev.EarliestRunout.ToString(DATE_FORMAT, CultureInfo.InvariantCulture) & "  (" & ev.EarliestName & ")"
            lblStatusValue.Text = ev.StatusText
            lblStatusValue.ForeColor = ev.StatusColor
        End If
    End Sub

    Private Sub ResetResults()
        For i As Integer = 0 To MED_COUNT - 1
            _lblPills(i).Text = ""
            _lblDays(i).Text = ""
            _lblReminder(i).Text = ""
            _lblRunout(i).Text = ""
            _lblPills(i).ForeColor = SystemColors.ControlText
            _lblDays(i).ForeColor = SystemColors.ControlText
            _lblReminder(i).ForeColor = SystemColors.ControlText
            _lblRunout(i).ForeColor = SystemColors.ControlText
        Next
        lblEarlyRemValue.Text = ""
        lblEarlyRunValue.Text = ""
        lblStatusValue.Text = ""
        lblStatusValue.ForeColor = SystemColors.ControlText
    End Sub

#End Region

#Region "Form helpers"

    Private Sub ClearForm()
        _loading = True
        Try
            txtName.Clear()
            txtFacility.Clear()
            txtRefills.Clear()
            txtNotes.Clear()
            dtpStart.Value = Date.Today
            For i As Integer = 0 To MED_COUNT - 1
                _medName(i).Clear()
                _medPills(i).Value = 0D
                _medDose(i).Value = 0D
            Next
            ResetResults()
            _currentId = ""
            lvRecords.SelectedItems.Clear()
        Finally
            _loading = False
        End Try
        UpdateButtons()
    End Sub

    Private Sub LoadRecordIntoForm(rec As MedicationRecord)
        _loading = True
        Try
            txtName.Text = rec.ChildName
            txtFacility.Text = rec.Facility
            txtRefills.Text = rec.Refills
            txtNotes.Text = rec.Notes
            dtpStart.Value = rec.StartDate
            For i As Integer = 0 To MED_COUNT - 1
                _medName(i).Text = rec.Meds(i).Name
                SetNud(_medPills(i), rec.Meds(i).PillsStarted)
                SetNud(_medDose(i), rec.Meds(i).DailyDose)
            Next
            ResetResults()
            _currentId = rec.Id
        Finally
            _loading = False
        End Try

        ShowResults(Evaluate(rec.StartDate, rec.Meds, Date.Today))
        UpdateButtons()
    End Sub

    Private Shared Sub SetNud(box As NumericUpDown, value As Decimal)
        box.Value = Math.Max(box.Minimum, Math.Min(box.Maximum, value))
    End Sub

    Private Sub UpdateButtons()
        btnDelete.Enabled = (_currentId <> "")
    End Sub

    Private Sub RefreshList()
        _lastRefreshDate = Date.Today
        Dim today As Date = Date.Today

        Dim rows = _records.Select(Function(r) New With {.Rec = r, .Ev = Evaluate(r.StartDate, r.Meds, today)}).ToList()
        rows = rows.OrderBy(Function(x) If(x.Ev.HasMeds, x.Ev.EarliestRunout, Date.MaxValue)).ThenBy(Function(x) x.Rec.ChildName).ToList()

        _loading = True
        Try
            lvRecords.BeginUpdate()
            lvRecords.Items.Clear()

            For Each row In rows
                Dim item As New ListViewItem(row.Rec.ChildName)
                item.SubItems.Add(row.Rec.Facility)

                If row.Ev.HasMeds Then
                    item.SubItems.Add(row.Ev.EarliestReminder.ToString(DATE_FORMAT, CultureInfo.InvariantCulture))
                    item.SubItems.Add(row.Ev.EarliestRunout.ToString(DATE_FORMAT, CultureInfo.InvariantCulture))
                    item.SubItems.Add(row.Ev.DaysRemaining.ToString(CultureInfo.CurrentCulture))
                    If row.Ev.IsOut Then
                        item.ForeColor = Color.Firebrick
                    ElseIf row.Ev.ReminderDue Then
                        item.ForeColor = Color.DarkOrange
                    End If
                Else
                    item.SubItems.Add("")
                    item.SubItems.Add("")
                    item.SubItems.Add("")
                End If

                item.Tag = row.Rec.Id
                lvRecords.Items.Add(item)
                If row.Rec.Id = _currentId Then item.Selected = True
            Next
        Finally
            lvRecords.EndUpdate()
            _loading = False
        End Try
    End Sub

#End Region

#Region "Persistence (sequential fixed-width text file)"

    Private Sub LoadRecords()
        _records.Clear()
        If Not File.Exists(DATA_FILE) Then Return

        Try
            ' Column start positions are read from the file's own header row, so a file written with
            ' different column widths still loads correctly (it is rewritten in the current layout on the next save).
            Dim starts As Integer() = DefaultColumnStarts()

            For Each line As String In File.ReadAllLines(DATA_FILE, Encoding.UTF8)
                If line.Trim() = "" Then Continue For
                If line.StartsWith("--") Then Continue For   ' Dashed separator row

                If line.StartsWith("ID") Then                ' Header row
                    Dim headerStarts As Integer() = ReadColumnStarts(line)
                    If headerStarts IsNot Nothing Then starts = headerStarts
                    Continue For
                End If

                Dim rec As MedicationRecord = ParseLine(line, starts)
                If rec IsNot Nothing Then _records.Add(rec)
            Next
        Catch ex As Exception
            MessageBox.Show("Could not read the data file " & DATA_FILE & "." & vbCrLf & vbCrLf & ex.Message,
                            APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Shared Function DefaultColumnStarts() As Integer()
        Dim starts(C_NOTES) As Integer
        starts(0) = 0
        For i As Integer = 1 To C_NOTES
            starts(i) = starts(i - 1) + COL_WIDTHS(i - 1) + GAP_TEXT.Length
        Next
        Return starts
    End Function

    ' Finds where each column begins by locating its title in the header row. Returns Nothing if a title is missing.
    Private Shared Function ReadColumnStarts(header As String) As Integer()
        Dim starts(C_NOTES) As Integer
        starts(0) = 0

        For i As Integer = 1 To C_NOTES
            Dim searchFrom As Integer = starts(i - 1) + COL_TITLES(i - 1).Length
            Dim idx As Integer = header.IndexOf(COL_TITLES(i), searchFrom, StringComparison.Ordinal)
            If idx < 0 Then Return Nothing
            starts(i) = idx
        Next
        Return starts
    End Function

    Private Function ParseLine(line As String, starts As Integer()) As MedicationRecord
        If line.Length <= starts(C_START) Then Return Nothing

        Dim v(C_NOTES - 1) As String
        For i As Integer = 0 To C_NOTES - 1
            v(i) = Field(line, starts(i), starts(i + 1) - starts(i))
        Next

        Dim notesText As String = ""
        If line.Length > starts(C_NOTES) Then notesText = line.Substring(starts(C_NOTES))

        Return BuildRecord(v, Unescape(notesText))
    End Function

    ' Builds a record from the raw column text, or returns Nothing if the line is unusable.
    Private Function BuildRecord(v As String(), notes As String) As MedicationRecord
        Dim startDate As Date
        If Not Date.TryParseExact(v(C_START), DATE_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, startDate) Then Return Nothing

        Dim rec As New MedicationRecord()
        ' Keep a valid, unused JV- id; anything else gets a new JV- id.
        rec.Id = If(IsValidId(v(C_ID)) AndAlso Not IdExists(v(C_ID)), v(C_ID), GenerateId())
        rec.ChildName = v(C_NAME)
        rec.Facility = v(C_FACILITY)
        rec.StartDate = startDate
        rec.Refills = v(C_REFILLS)
        rec.Notes = notes

        For k As Integer = 0 To MED_COUNT - 1
            Dim first As Integer = C_MED_FIRST + 3 * k
            rec.Meds(k).Name = v(first)
            rec.Meds(k).PillsStarted = ParseDecimal(v(first + 1))
            rec.Meds(k).DailyDose = ParseDecimal(v(first + 2))
        Next

        Return rec
    End Function

    Private Shared Function ParseDecimal(text As String) As Decimal
        Dim d As Decimal
        If Decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, d) Then Return d
        Return 0D
    End Function

    ' New record id: "JV-" followed by a random 6-digit number that no other record is using.
    Private Function GenerateId() As String
        Dim id As String
        Do
            id = ID_PREFIX & _rng.Next(100000, 1000000).ToString(CultureInfo.InvariantCulture)
        Loop While IdExists(id)
        Return id
    End Function

    Private Function IdExists(id As String) As Boolean
        Return _records.Any(Function(r) r.Id = id)
    End Function

    Private Shared Function IsValidId(id As String) As Boolean
        Return Regex.IsMatch(id, "^JV-\d{6}$")
    End Function

    ' Reads one fixed-width column, tolerating lines that were shortened by an editor trimming trailing spaces.
    Private Shared Function Field(line As String, start As Integer, width As Integer) As String
        If start >= line.Length Then Return ""
        Dim length As Integer = Math.Min(width, line.Length - start)
        Return line.Substring(start, length).Trim()
    End Function

    ' Pads (or truncates) text to an exact column width. Tabs and line breaks become spaces.
    Private Shared Function PadField(text As String, width As Integer, rightAlign As Boolean) As String
        If text Is Nothing Then text = ""
        text = text.Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbTab, " ")
        If text.Length > width Then text = text.Substring(0, width)
        If rightAlign Then Return text.PadLeft(width)
        Return text.PadRight(width)
    End Function

    ' Pill counts and doses are right-aligned so the digits line up.
    Private Shared Function IsRightAligned(column As Integer) As Boolean
        Return column >= C_MED_FIRST AndAlso (column - C_MED_FIRST) Mod 3 <> 0
    End Function

    Private Shared Function HeaderLine() As String
        Dim sb As New StringBuilder()
        For i As Integer = 0 To C_NOTES - 1
            sb.Append(PadField(COL_TITLES(i), COL_WIDTHS(i), False)).Append(GAP_TEXT)
        Next
        sb.Append(COL_TITLES(C_NOTES))
        Return sb.ToString()
    End Function

    Private Shared Function SeparatorLine() As String
        Dim sb As New StringBuilder()
        For i As Integer = 0 To C_NOTES - 1
            sb.Append(New String("-"c, COL_WIDTHS(i))).Append(GAP_TEXT)
        Next
        sb.Append(New String("-"c, 5))
        Return sb.ToString()
    End Function

    Private Shared Function BuildLine(rec As MedicationRecord) As String
        Dim v(C_NOTES - 1) As String
        v(C_ID) = rec.Id
        v(C_NAME) = rec.ChildName
        v(C_FACILITY) = rec.Facility
        v(C_START) = rec.StartDate.ToString(DATE_FORMAT, CultureInfo.InvariantCulture)
        v(C_REFILLS) = rec.Refills

        For k As Integer = 0 To MED_COUNT - 1
            Dim first As Integer = C_MED_FIRST + 3 * k
            Dim m As MedEntry = rec.Meds(k)
            If m.Name <> "" Then
                v(first) = m.Name
                v(first + 1) = m.PillsStarted.ToString("0.##", CultureInfo.InvariantCulture)
                v(first + 2) = m.DailyDose.ToString("0.##", CultureInfo.InvariantCulture)
            Else
                v(first) = ""
                v(first + 1) = ""
                v(first + 2) = ""
            End If
        Next

        Dim sb As New StringBuilder()
        For i As Integer = 0 To C_NOTES - 1
            sb.Append(PadField(v(i), COL_WIDTHS(i), IsRightAligned(i))).Append(GAP_TEXT)
        Next
        sb.Append(Escape(rec.Notes))
        Return sb.ToString()
    End Function

    ' Rewrites the whole file (required for sequential storage) via a temp file so a failed write cannot corrupt it.
    Private Function WriteAllRecords() As Boolean
        Dim tempFile As String = DATA_FILE & ".tmp"
        Try
            If Not Directory.Exists(DATA_FOLDER) Then Directory.CreateDirectory(DATA_FOLDER)

            Dim lines As New List(Of String)()
            lines.Add(HeaderLine())
            lines.Add(SeparatorLine())
            For Each rec As MedicationRecord In _records
                lines.Add(BuildLine(rec))
            Next

            File.WriteAllLines(tempFile, lines, Encoding.UTF8)
            File.Copy(tempFile, DATA_FILE, True)
            File.Delete(tempFile)
            Return True

        Catch ex As Exception
            MessageBox.Show("Could not write the data file " & DATA_FILE & "." & vbCrLf & vbCrLf & ex.Message,
                            APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Used for the notes column: keeps each record on exactly one line.
    Private Shared Function Escape(text As String) As String
        If text Is Nothing Then Return ""
        Dim result As String = text.Replace("\", "\\")
        result = result.Replace(vbCrLf, "\n")
        result = result.Replace(vbCr, "\n")
        result = result.Replace(vbLf, "\n")
        result = result.Replace(vbTab, "\t")
        Return result
    End Function

    Private Shared Function Unescape(text As String) As String
        Dim sb As New StringBuilder()
        Dim i As Integer = 0
        Do While i < text.Length
            Dim c As Char = text(i)
            If c = "\"c AndAlso i + 1 < text.Length Then
                Dim nextChar As Char = text(i + 1)
                Select Case nextChar
                    Case "n"c
                        sb.Append(vbCrLf)
                    Case "t"c
                        sb.Append(vbTab)
                    Case "\"c
                        sb.Append("\"c)
                    Case Else
                        sb.Append(c).Append(nextChar)
                End Select
                i += 2
            Else
                sb.Append(c)
                i += 1
            End If
        Loop
        Return sb.ToString()
    End Function

#End Region

End Class
