'Project:   Detention Medication Tracker
'By:        Shon Garison
'Purpose:   To track medications prescribed to detainees in a detention center.
'Created:   06/03/2026
'Updated:   June 2026
'Version:   1.0.0

Option Explicit On
Imports System.Globalization

Imports System.IO
Imports System.Text
Imports System.Windows

Public Class frmMain

    Private ReadOnly title As String = "Detention Medication Tracker"
    Private dteToday As Date = Date.Today
    Public Shared ReadOnly mdirectoy As String = Path.Combine("C:\", "DetaineeMedicationTracker")
    Public Shared ReadOnly mfile As String = Path.Combine(mdirectoy, "med_tracker.txt")

    '--------------------------------- Form Events ---------------------------------

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim dteDetained As Date
        Dim dteRunout As Date
        Dim dteReminder As Date = dteRunout.AddDays(-7)

        Dim button As DialogResult

        ' --- Tracker File Check ---  

        If Not My.Computer.FileSystem.FileExists(mfile) Then

            button = MessageBox.Show("Med Tracker File not found." & vbCrLf &
                                     "Would you like to Create it?",
                                     title, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                     MessageBoxDefaultButton.Button1)

            If button = DialogResult.Yes Then
                Directory.CreateDirectory(mdirectoy)
                Me.Hide()
                Using f As New frmAdd()
                    f.ShowDialog()
                End Using
            Else
                Me.Close()
            End If

        Else
            If RefreshFile(mfile) Then
                PullData()
            End If
        End If



    End Sub

    Public Sub PullData()

        Try
            Dim myText As String = My.Computer.FileSystem.ReadAllText(mfile)
            Dim mySentence() As String = Split(myText, vbCrLf)
            Dim listing As Integer = 0  ' Counter for each record
            Dim recieve As Integer = 0  ' Counter for receiving County
            Dim sent As Integer = 0     ' Counter for sending County
            Dim dteICTThresh As Date
            Dim dteProgRptThresh As Date
            Dim display As String

            For Each sentence As String In mySentence

                If sentence.Contains("Pending") Then
                    Dim words() = Split(sentence, vbTab)

                    display = String.Join(" ".PadRight(5), words)

                    'Compute numbers of sending/receiving counties for summary at bottom of form
                    If words(1).TrimEnd = "Orange" Then
                        recieve += 1
                    End If

                    If words(2).TrimEnd = "Orange" Then
                        sent += 1
                    End If

                    lblICTListing.Text &= (listing + 1).ToString & ".)  " & display & vbCrLf
                    listing += 1

                ElseIf sentence.Contains("/"c) Then

                    Dim words() = Split(sentence, vbTab)

                    'Extract two dates to compute refresh on data pull
                    dteICTThresh = CDate(words(6).TrimEnd)
                    dteProgRptThresh = CDate(words(7).TrimEnd)

                    'get updated days remaining in progress report and program
                    Dim progRptDaysRefresh As Integer = dteProgRptThresh.Subtract(Date.Now).Days
                    Dim ictDaysRefresh As Integer = dteICTThresh.Subtract(Date.Now).Days

                    'inject refreshed days remaining into the appropriate array index for display on form
                    words(8) = progRptDaysRefresh.ToString.PadLeft(3) & " days"
                    words(9) = ictDaysRefresh.ToString.PadLeft(3) & " days"

                    'Put the words back together with padding for display on form
                    display = String.Join(" ".PadRight(5), words)

                    'Compute numbers of sending/receiving counties for summary at bottom of form
                    If words(1).TrimEnd = "Orange" Then
                        recieve += 1
                    End If

                    If words(2).TrimEnd = "Orange" Then
                        sent += 1
                    End If

                    lblICTListing.Text &= (listing + 1).ToString & ".)  " & display & vbCrLf
                    listing += 1

                End If
            Next

            lblTotICTChildren.Text = listing.ToString
            lblTotICTReceived.Text = recieve.ToString
            lblTotICTSent.Text = sent.ToString

        Catch ex As Exception
            MessageBox.Show("An error occurred while pulling data: " &
                            ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function RefreshFile(filepath As String) As String

        Dim tempPath As String = Path.Combine(Path.GetDirectoryName(filepath),
                                              Path.GetFileNameWithoutExtension(filepath) & ".tmp" &
                                              Path.GetExtension(filepath))



        Dim idxThreshold As Integer
        Dim idxProgRpt As Integer
        Dim idxProgDays As Integer
        Dim idxThreshDays As Integer

        Try

            Dim readtxt As String = File.ReadAllText(filepath)
            Dim lines() As String = Split(readtxt, vbCrLf)

            ' Remove temp file if one already exists from a previous failed run
            If File.Exists(tempPath) Then
                File.Delete(tempPath)
            End If

            For Each line As String In lines

                If line.Contains("/"c) Then

                    ' This is a data line — parse and refresh days remaining
                    Dim words() As String = Split(line, vbTab)

                    ' Parse both threshold dates — abort with error if either is malformed
                    Dim dteICTThresh As Date
                    Dim dteProgRptThresh As Date

                    If Not Date.TryParse(words(idxThreshold).TrimEnd, dteICTThresh) Then

                        MessageBox.Show("Invalid Reminder date found in record: " & words(0).Trim & vbCrLf &
                                            "Value: " & words(idxThreshold).TrimEnd & vbCrLf & vbCrLf &
                                            "File refresh has been aborted. Please correct the record and try again.",
                                            title, MessageBoxButtons.OK, MessageBoxIcon.Error)

                        ' Clean up temp file if partially written
                        If File.Exists(tempPath) Then File.Delete(tempPath)
                        Return False

                    End If

                    If Not Date.TryParse(words(idxProgRpt).TrimEnd, dteProgRptThresh) Then

                        MessageBox.Show("Invalid Runout date found in record: " & words(0).Trim & vbCrLf &
                                            "Value: " & words(idxProgRpt).TrimEnd & vbCrLf & vbCrLf &
                                            "File refresh has been aborted. Please correct the record and try again.",
                                            title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ' Clean up temp file if partially written
                        If File.Exists(tempPath) Then File.Delete(tempPath)
                        Return False

                    End If

                    ' Recalculate both days remaining values
                    Dim progRptDaysRefresh As Integer = dteProgRptThresh.Subtract(Date.Now).Days
                    Dim ictDaysRefresh As Integer = dteICTThresh.Subtract(Date.Now).Days

                    ' Inject refreshed values back into the word array
                    words(idxProgDays) = progRptDaysRefresh.ToString.PadLeft(3) & " days"
                    words(idxThreshDays) = ictDaysRefresh.ToString.PadLeft(3) & " days"

                    ' Rebuild the updated line and write to temp file
                    Dim updatedLine As String = String.Join(vbTab, words)
                    My.Computer.FileSystem.WriteAllText(tempPath, updatedLine & vbCrLf, True)

                ElseIf line.Length > 0 Then

                    ' This is a header or separator line — write as-is
                    My.Computer.FileSystem.WriteAllText(tempPath, line & vbCrLf, True)

                End If
            Next

            ' Replace original file with updated temp file
            File.Delete(filepath)
            File.Move(tempPath, filepath)
            Return True


        Catch ex As Exception

            MessageBox.Show("Error refreshing file: " & ex.Message,
                            title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Clean up temp file if partially written
            If File.Exists(tempPath) Then File.Delete(tempPath)
            Return False

        End Try

    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'TODO: Pull Date Detained and Date Runout from text file and assign to dteDetained
        'and dteRunout variables once a child is named and exists.

    End Sub
End Class
