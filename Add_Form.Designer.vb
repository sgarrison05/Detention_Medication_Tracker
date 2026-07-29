<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
        txbChildName = New TextBox()
        lblChildNameID = New Label()
        cmbDetFacility = New ComboBox()
        lblDetentionID = New Label()
        dtpDetStart = New DateTimePicker()
        lblDateDetainedID = New Label()
        lblMedID1 = New Label()
        txbMed1 = New TextBox()
        lblMedID2 = New Label()
        txbMed2 = New TextBox()
        lblMedID3 = New Label()
        txbMed3 = New TextBox()
        lblMedID4 = New Label()
        txbMed4 = New TextBox()
        Label5 = New Label()
        txbStart1 = New TextBox()
        txbStart2 = New TextBox()
        txbStart3 = New TextBox()
        txbStart4 = New TextBox()
        txbDosage4 = New TextBox()
        txbDosage3 = New TextBox()
        txbDosage2 = New TextBox()
        Label6 = New Label()
        txbDosage1 = New TextBox()
        Label7 = New Label()
        lblRemain1 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        lblDaysRemain1 = New Label()
        Label16 = New Label()
        txbRefill4 = New TextBox()
        txbRefill3 = New TextBox()
        txbRefill2 = New TextBox()
        Label17 = New Label()
        txbRefill1 = New TextBox()
        btnClose = New Button()
        btnClear = New Button()
        btnSave = New Button()
        txbNotes = New TextBox()
        lblNotesID = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txbChildName
        ' 
        txbChildName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbChildName.Location = New Point(218, 34)
        txbChildName.Name = "txbChildName"
        txbChildName.Size = New Size(268, 29)
        txbChildName.TabIndex = 0
        ' 
        ' lblChildNameID
        ' 
        lblChildNameID.AutoSize = True
        lblChildNameID.Location = New Point(218, 16)
        lblChildNameID.Name = "lblChildNameID"
        lblChildNameID.Size = New Size(133, 15)
        lblChildNameID.TabIndex = 1
        lblChildNameID.Text = "Child Name (Last, First):"
        ' 
        ' cmbDetFacility
        ' 
        cmbDetFacility.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbDetFacility.FormattingEnabled = True
        cmbDetFacility.Location = New Point(548, 37)
        cmbDetFacility.Name = "cmbDetFacility"
        cmbDetFacility.Size = New Size(250, 29)
        cmbDetFacility.TabIndex = 2
        ' 
        ' lblDetentionID
        ' 
        lblDetentionID.AutoSize = True
        lblDetentionID.Location = New Point(548, 19)
        lblDetentionID.Name = "lblDetentionID"
        lblDetentionID.Size = New Size(102, 15)
        lblDetentionID.TabIndex = 3
        lblDetentionID.Text = "Detention Facility:"
        ' 
        ' dtpDetStart
        ' 
        dtpDetStart.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDetStart.Format = DateTimePickerFormat.Short
        dtpDetStart.Location = New Point(21, 34)
        dtpDetStart.Name = "dtpDetStart"
        dtpDetStart.Size = New Size(159, 29)
        dtpDetStart.TabIndex = 4
        ' 
        ' lblDateDetainedID
        ' 
        lblDateDetainedID.AutoSize = True
        lblDateDetainedID.Location = New Point(21, 16)
        lblDateDetainedID.Name = "lblDateDetainedID"
        lblDateDetainedID.Size = New Size(159, 15)
        lblDateDetainedID.TabIndex = 5
        lblDateDetainedID.Text = "Date Detained / Med Started:"
        ' 
        ' lblMedID1
        ' 
        lblMedID1.AutoSize = True
        lblMedID1.Location = New Point(23, 102)
        lblMedID1.Name = "lblMedID1"
        lblMedID1.Size = New Size(128, 15)
        lblMedID1.TabIndex = 7
        lblMedID1.Text = "Name of Medication 1:"
        ' 
        ' txbMed1
        ' 
        txbMed1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbMed1.Location = New Point(23, 120)
        txbMed1.Name = "txbMed1"
        txbMed1.Size = New Size(268, 29)
        txbMed1.TabIndex = 6
        ' 
        ' lblMedID2
        ' 
        lblMedID2.AutoSize = True
        lblMedID2.Location = New Point(23, 169)
        lblMedID2.Name = "lblMedID2"
        lblMedID2.Size = New Size(128, 15)
        lblMedID2.TabIndex = 9
        lblMedID2.Text = "Name of Medication 2:"
        ' 
        ' txbMed2
        ' 
        txbMed2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbMed2.Location = New Point(23, 187)
        txbMed2.Name = "txbMed2"
        txbMed2.Size = New Size(268, 29)
        txbMed2.TabIndex = 8
        ' 
        ' lblMedID3
        ' 
        lblMedID3.AutoSize = True
        lblMedID3.Location = New Point(23, 242)
        lblMedID3.Name = "lblMedID3"
        lblMedID3.Size = New Size(128, 15)
        lblMedID3.TabIndex = 11
        lblMedID3.Text = "Name of Medication 3:"
        ' 
        ' txbMed3
        ' 
        txbMed3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbMed3.Location = New Point(23, 260)
        txbMed3.Name = "txbMed3"
        txbMed3.Size = New Size(268, 29)
        txbMed3.TabIndex = 10
        ' 
        ' lblMedID4
        ' 
        lblMedID4.AutoSize = True
        lblMedID4.Location = New Point(23, 314)
        lblMedID4.Name = "lblMedID4"
        lblMedID4.Size = New Size(128, 15)
        lblMedID4.TabIndex = 13
        lblMedID4.Text = "Name of Medication 4:"
        ' 
        ' txbMed4
        ' 
        txbMed4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbMed4.Location = New Point(23, 332)
        txbMed4.Name = "txbMed4"
        txbMed4.Size = New Size(268, 29)
        txbMed4.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(299, 87)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 30)
        Label5.TabIndex = 15
        Label5.Text = "Number of Pills " & vbCrLf & "Started with or Added:"
        ' 
        ' txbStart1
        ' 
        txbStart1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbStart1.Location = New Point(331, 120)
        txbStart1.Name = "txbStart1"
        txbStart1.Size = New Size(47, 29)
        txbStart1.TabIndex = 14
        ' 
        ' txbStart2
        ' 
        txbStart2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbStart2.Location = New Point(331, 187)
        txbStart2.Name = "txbStart2"
        txbStart2.Size = New Size(47, 29)
        txbStart2.TabIndex = 16
        ' 
        ' txbStart3
        ' 
        txbStart3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbStart3.Location = New Point(331, 260)
        txbStart3.Name = "txbStart3"
        txbStart3.Size = New Size(47, 29)
        txbStart3.TabIndex = 17
        ' 
        ' txbStart4
        ' 
        txbStart4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbStart4.Location = New Point(331, 332)
        txbStart4.Name = "txbStart4"
        txbStart4.Size = New Size(47, 29)
        txbStart4.TabIndex = 18
        ' 
        ' txbDosage4
        ' 
        txbDosage4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbDosage4.Location = New Point(439, 332)
        txbDosage4.Name = "txbDosage4"
        txbDosage4.Size = New Size(47, 29)
        txbDosage4.TabIndex = 23
        ' 
        ' txbDosage3
        ' 
        txbDosage3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbDosage3.Location = New Point(439, 260)
        txbDosage3.Name = "txbDosage3"
        txbDosage3.Size = New Size(47, 29)
        txbDosage3.TabIndex = 22
        ' 
        ' txbDosage2
        ' 
        txbDosage2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbDosage2.Location = New Point(439, 187)
        txbDosage2.Name = "txbDosage2"
        txbDosage2.Size = New Size(47, 29)
        txbDosage2.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(437, 87)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 30)
        Label6.TabIndex = 20
        Label6.Text = "Daily " & vbCrLf & "Dosage:"
        ' 
        ' txbDosage1
        ' 
        txbDosage1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbDosage1.Location = New Point(439, 120)
        txbDosage1.Name = "txbDosage1"
        txbDosage1.Size = New Size(47, 29)
        txbDosage1.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(544, 87)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 30)
        Label7.TabIndex = 24
        Label7.Text = "Pills " & vbCrLf & "Remaining:"
        ' 
        ' lblRemain1
        ' 
        lblRemain1.BorderStyle = BorderStyle.FixedSingle
        lblRemain1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRemain1.Location = New Point(548, 126)
        lblRemain1.Name = "lblRemain1"
        lblRemain1.Size = New Size(59, 23)
        lblRemain1.TabIndex = 25
        lblRemain1.Text = "#"
        ' 
        ' Label9
        ' 
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(548, 193)
        Label9.Name = "Label9"
        Label9.Size = New Size(59, 23)
        Label9.TabIndex = 26
        Label9.Text = "#"
        ' 
        ' Label10
        ' 
        Label10.BorderStyle = BorderStyle.FixedSingle
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(548, 266)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 23)
        Label10.TabIndex = 27
        Label10.Text = "#"
        ' 
        ' Label11
        ' 
        Label11.BorderStyle = BorderStyle.FixedSingle
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(548, 338)
        Label11.Name = "Label11"
        Label11.Size = New Size(59, 23)
        Label11.TabIndex = 28
        Label11.Text = "#"
        ' 
        ' Label12
        ' 
        Label12.BorderStyle = BorderStyle.FixedSingle
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(649, 338)
        Label12.Name = "Label12"
        Label12.Size = New Size(59, 23)
        Label12.TabIndex = 33
        Label12.Text = "#"
        ' 
        ' Label13
        ' 
        Label13.BorderStyle = BorderStyle.FixedSingle
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(649, 266)
        Label13.Name = "Label13"
        Label13.Size = New Size(59, 23)
        Label13.TabIndex = 32
        Label13.Text = "#"
        ' 
        ' Label14
        ' 
        Label14.BorderStyle = BorderStyle.FixedSingle
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(649, 193)
        Label14.Name = "Label14"
        Label14.Size = New Size(59, 23)
        Label14.TabIndex = 31
        Label14.Text = "#"
        ' 
        ' lblDaysRemain1
        ' 
        lblDaysRemain1.BorderStyle = BorderStyle.FixedSingle
        lblDaysRemain1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDaysRemain1.Location = New Point(649, 126)
        lblDaysRemain1.Name = "lblDaysRemain1"
        lblDaysRemain1.Size = New Size(59, 23)
        lblDaysRemain1.TabIndex = 30
        lblDaysRemain1.Text = "#"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(636, 87)
        Label16.Name = "Label16"
        Label16.Size = New Size(85, 30)
        Label16.TabIndex = 29
        Label16.Text = "Days Remaing " & vbCrLf & "with Meds:"
        ' 
        ' txbRefill4
        ' 
        txbRefill4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbRefill4.Location = New Point(751, 332)
        txbRefill4.Name = "txbRefill4"
        txbRefill4.Size = New Size(47, 29)
        txbRefill4.TabIndex = 38
        ' 
        ' txbRefill3
        ' 
        txbRefill3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbRefill3.Location = New Point(751, 260)
        txbRefill3.Name = "txbRefill3"
        txbRefill3.Size = New Size(47, 29)
        txbRefill3.TabIndex = 37
        ' 
        ' txbRefill2
        ' 
        txbRefill2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbRefill2.Location = New Point(751, 187)
        txbRefill2.Name = "txbRefill2"
        txbRefill2.Size = New Size(47, 29)
        txbRefill2.TabIndex = 36
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(744, 87)
        Label17.Name = "Label17"
        Label17.Size = New Size(65, 30)
        Label17.TabIndex = 35
        Label17.Text = "Number of" & vbCrLf & "Refills:"
        ' 
        ' txbRefill1
        ' 
        txbRefill1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbRefill1.Location = New Point(751, 120)
        txbRefill1.Name = "txbRefill1"
        txbRefill1.Size = New Size(47, 29)
        txbRefill1.TabIndex = 34
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Tomato
        btnClose.Location = New Point(734, 399)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 34)
        btnClose.TabIndex = 39
        btnClose.Text = "Return"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.DeepSkyBlue
        btnClear.Location = New Point(636, 399)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 34)
        btnClear.TabIndex = 40
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.LawnGreen
        btnSave.Location = New Point(536, 399)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 34)
        btnSave.TabIndex = 41
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txbNotes
        ' 
        txbNotes.Location = New Point(23, 390)
        txbNotes.Multiline = True
        txbNotes.Name = "txbNotes"
        txbNotes.Size = New Size(463, 43)
        txbNotes.TabIndex = 42
        ' 
        ' lblNotesID
        ' 
        lblNotesID.AutoSize = True
        lblNotesID.Location = New Point(23, 372)
        lblNotesID.Name = "lblNotesID"
        lblNotesID.Size = New Size(41, 15)
        lblNotesID.TabIndex = 43
        lblNotesID.Text = "Notes:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(23, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 15)
        Label1.TabIndex = 44
        Label1.Text = "* Must contain dosage ""mg"""
        ' 
        ' frmAdd
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(823, 450)
        Controls.Add(Label1)
        Controls.Add(lblNotesID)
        Controls.Add(txbNotes)
        Controls.Add(btnSave)
        Controls.Add(btnClear)
        Controls.Add(btnClose)
        Controls.Add(txbRefill4)
        Controls.Add(txbRefill3)
        Controls.Add(txbRefill2)
        Controls.Add(Label17)
        Controls.Add(txbRefill1)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Controls.Add(lblDaysRemain1)
        Controls.Add(Label16)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(lblRemain1)
        Controls.Add(Label7)
        Controls.Add(txbDosage4)
        Controls.Add(txbDosage3)
        Controls.Add(txbDosage2)
        Controls.Add(Label6)
        Controls.Add(txbDosage1)
        Controls.Add(txbStart4)
        Controls.Add(txbStart3)
        Controls.Add(txbStart2)
        Controls.Add(Label5)
        Controls.Add(txbStart1)
        Controls.Add(lblMedID4)
        Controls.Add(txbMed4)
        Controls.Add(lblMedID3)
        Controls.Add(txbMed3)
        Controls.Add(lblMedID2)
        Controls.Add(txbMed2)
        Controls.Add(lblMedID1)
        Controls.Add(txbMed1)
        Controls.Add(lblDateDetainedID)
        Controls.Add(dtpDetStart)
        Controls.Add(lblDetentionID)
        Controls.Add(cmbDetFacility)
        Controls.Add(lblChildNameID)
        Controls.Add(txbChildName)
        Name = "frmAdd"
        Text = "Add / Update Child"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txbChildName As TextBox
    Friend WithEvents lblChildNameID As Label
    Friend WithEvents cmbDetFacility As ComboBox
    Friend WithEvents lblDetentionID As Label
    Friend WithEvents dtpDetStart As DateTimePicker
    Friend WithEvents lblDateDetainedID As Label
    Friend WithEvents lblMedID1 As Label
    Friend WithEvents txbMed1 As TextBox
    Friend WithEvents lblMedID2 As Label
    Friend WithEvents txbMed2 As TextBox
    Friend WithEvents lblMedID3 As Label
    Friend WithEvents txbMed3 As TextBox
    Friend WithEvents lblMedID4 As Label
    Friend WithEvents txbMed4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txbStart1 As TextBox
    Friend WithEvents txbStart2 As TextBox
    Friend WithEvents txbStart3 As TextBox
    Friend WithEvents txbStart4 As TextBox
    Friend WithEvents txbDosage4 As TextBox
    Friend WithEvents txbDosage3 As TextBox
    Friend WithEvents txbDosage2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txbDosage1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblRemain1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblDaysRemain1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txbRefill4 As TextBox
    Friend WithEvents txbRefill3 As TextBox
    Friend WithEvents txbRefill2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txbRefill1 As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txbNotes As TextBox
    Friend WithEvents lblNotesID As Label
    Friend WithEvents Label1 As Label
End Class
