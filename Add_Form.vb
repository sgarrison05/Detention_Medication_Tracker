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

#End Region

#Region "============== Functions and Subroutines =============="

    ' TODO: Create FillData(), Create Entry(), WriteDataLine(), and WriteHeader() Subroutines
    ' to fill form fields with data

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