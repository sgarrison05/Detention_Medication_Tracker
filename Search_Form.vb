Public Class frmSearch

    'TODO: Continue to refine and check for errors in import from another project.

    Dim display As String
    Private foundWords As String() = Nothing
    Private facility As String

#Region "===== Form Events ====="

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblDisplay.Text = "Ready"
        txbCLastName.Focus()

    End Sub

#End Region

#Region "===== Functions and Subroutines ====="

    Private Function SafeWord(words() As String, index As Integer) As String

        ' Save array accessor - prevents out-of-bounds on short or Pending records
        If index >= 0 AndAlso index < words.Length Then
            Return words(index).TrimEnd()
        End If
        Return String.Empty

    End Function

    Private Sub PopulateEditForm(f As frmAdd, words() As String)

        f.isEditMode = True

        f.IncomingOriginalName = SafeWord(words, 0)

        f.IncomingChildName = SafeWord(words, 0)
        f.IncomingFacility = SafeWord(words, 1)
        f.IncomingDateDetained = SafeWord(words, 2)
        f.IncomingMedication = SafeWord(words, 3)

        DetermineAndSetDate(f, words, StartIdx:=4, endIdx:=5)

    End Sub

    Private Sub DetermineAndSetDate(f As frmAdd, words() As String, StartIdx As Integer, endIdx As Integer)

        ' Handle start date — may be "Pending" or blank
        Dim startVal As String = SafeWord(words, StartIdx)
        Dim parsedStart As DateTime

        f.IncomingStartDate = DateTime.Today
        f.IncomingEndDate = Date.Today.AddDays(10)

    End Sub

    Private Sub FillLabel()

        ' Validate before searching — empty search would match every line
        If String.IsNullOrWhiteSpace(txbCLastName.Text) Then
            MessageBox.Show("Please enter a last name to search.",
                            "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txbCLastName.Focus()
            Return
        End If

        ' Reset display before search
        display = String.Empty
        foundWords = Nothing

        Dim targetFile As String = frmMain.mfile

        ' Check file exists before attempting to read
        If Not My.Computer.FileSystem.FileExists(targetFile) Then
            MessageBox.Show("No detention medication records file found.",
                            "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim myText As String = My.Computer.FileSystem.ReadAllText(targetFile)
            Dim mySentence() As String = Split(myText, vbCrLf)

            For Each sentence As String In mySentence

                'skip blank lines
                If String.IsNullOrWhiteSpace(sentence) Then Continue For

                Dim words() As String = Split(sentence, vbTab)

                ' Skip lines that don't start with a plausible name (header lines start with "Child Name:" etc.)
                ' A data line's first word should not contain a colon
                If words(0).Contains(":"c) OrElse words(0).Trim().StartsWith("-"c) Then Continue For

                ' Must have at least 3 columns to be a valid data line (Child Name, Receiving Co, Sending Co)
                If words.Length < 3 Then Continue For

                If SafeWord(words, 0).IndexOf(txbCLastName.Text, StringComparison.OrdinalIgnoreCase) >= 0 Then

                    foundWords = words ' Store for potential use in edit form

                    'Put the words back together with padding for display on form
                    display = String.Join(" ".PadRight(5), SafeWord(words, 0), SafeWord(words, 1),
                                                              SafeWord(words, 2), SafeWord(words, 3))

                    Exit For
                End If
            Next

            ' Prefix result with record type for context
            Dim recordType As String = "[" & facility & "]" & Strings.Space(5)

            If String.IsNullOrEmpty(display) Then
                lblDisplay.Text = "Name not found."
            Else
                lblDisplay.Text = recordType & display
            End If

        Catch ex As Exception
            MessageBox.Show("Error during search: " & ex.Message,
                            "Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CleanForm()

        txbCLastName.Clear()
        lblDisplay.Text = String.Empty
        foundWords = Nothing
        txbCLastName.Focus()

    End Sub

#End Region

#Region "====== Button Events ====="

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        CleanForm()
        txbCLastName.Focus()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        FillLabel()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        CleanForm()
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Using f As New frmAdd()
            f.isEditMode = False
            f.ShowDialog()
        End Using

        CleanForm()

    End Sub



#End Region

End Class