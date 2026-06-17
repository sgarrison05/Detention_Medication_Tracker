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

        'TODO: Pull Date Detained and Date Runout from text file and assign to dteDetained and dteRunout variables


    End Sub

    Public Sub PullData()

    End Sub

    Public Function RefreshFile(filepath As String) As String

    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub
End Class
