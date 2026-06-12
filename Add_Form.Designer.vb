<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Form
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
        Label1 = New Label()
        txbMed1 = New TextBox()
        Label2 = New Label()
        txbMed2 = New TextBox()
        Label3 = New Label()
        txbMed3 = New TextBox()
        Label4 = New Label()
        txbMed4 = New TextBox()
        Label5 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        Label6 = New Label()
        TextBox12 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        TextBox13 = New TextBox()
        TextBox14 = New TextBox()
        TextBox15 = New TextBox()
        Label17 = New Label()
        TextBox16 = New TextBox()
        btnClose = New Button()
        btnClear = New Button()
        btnSave = New Button()
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
        lblChildNameID.Size = New Size(73, 15)
        lblChildNameID.TabIndex = 1
        lblChildNameID.Text = "Child Name:"
        ' 
        ' cmbDetFacility
        ' 
        cmbDetFacility.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbDetFacility.FormattingEnabled = True
        cmbDetFacility.Location = New Point(529, 34)
        cmbDetFacility.Name = "cmbDetFacility"
        cmbDetFacility.Size = New Size(192, 29)
        cmbDetFacility.TabIndex = 2
        ' 
        ' lblDetentionID
        ' 
        lblDetentionID.AutoSize = True
        lblDetentionID.Location = New Point(529, 16)
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 15)
        Label1.TabIndex = 7
        Label1.Text = "Name of Medication 1:"
        ' 
        ' txbMed1
        ' 
        txbMed1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbMed1.Location = New Point(23, 120)
        txbMed1.Name = "txbMed1"
        txbMed1.Size = New Size(268, 29)
        txbMed1.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 15)
        Label2.TabIndex = 9
        Label2.Text = "Name of Medication 2:"
        ' 
        ' txbMed2
        ' 
        txbMed2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbMed2.Location = New Point(23, 187)
        txbMed2.Name = "txbMed2"
        txbMed2.Size = New Size(268, 29)
        txbMed2.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 15)
        Label3.TabIndex = 11
        Label3.Text = "Name of Medication 3:"
        ' 
        ' txbMed3
        ' 
        txbMed3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbMed3.Location = New Point(23, 260)
        txbMed3.Name = "txbMed3"
        txbMed3.Size = New Size(268, 29)
        txbMed3.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 314)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 15)
        Label4.TabIndex = 13
        Label4.Text = "Name of Medication 4:"
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
        Label5.Location = New Point(308, 87)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 30)
        Label5.TabIndex = 15
        Label5.Text = "Number of Pills " & vbCrLf & "Started or Added:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(331, 120)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(47, 29)
        TextBox5.TabIndex = 14
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(331, 187)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(47, 29)
        TextBox6.TabIndex = 16
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(331, 260)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(47, 29)
        TextBox7.TabIndex = 17
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(331, 332)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(47, 29)
        TextBox8.TabIndex = 18
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox9.Location = New Point(439, 332)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(47, 29)
        TextBox9.TabIndex = 23
        ' 
        ' TextBox10
        ' 
        TextBox10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox10.Location = New Point(439, 260)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(47, 29)
        TextBox10.TabIndex = 22
        ' 
        ' TextBox11
        ' 
        TextBox11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox11.Location = New Point(439, 187)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(47, 29)
        TextBox11.TabIndex = 21
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
        ' TextBox12
        ' 
        TextBox12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox12.Location = New Point(439, 120)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(47, 29)
        TextBox12.TabIndex = 19
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
        ' Label8
        ' 
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(548, 126)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 23)
        Label8.TabIndex = 25
        Label8.Text = "#"
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
        ' Label15
        ' 
        Label15.BorderStyle = BorderStyle.FixedSingle
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(649, 126)
        Label15.Name = "Label15"
        Label15.Size = New Size(59, 23)
        Label15.TabIndex = 30
        Label15.Text = "#"
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
        ' TextBox13
        ' 
        TextBox13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox13.Location = New Point(751, 332)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(47, 29)
        TextBox13.TabIndex = 38
        ' 
        ' TextBox14
        ' 
        TextBox14.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox14.Location = New Point(751, 260)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(47, 29)
        TextBox14.TabIndex = 37
        ' 
        ' TextBox15
        ' 
        TextBox15.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox15.Location = New Point(751, 187)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(47, 29)
        TextBox15.TabIndex = 36
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
        ' TextBox16
        ' 
        TextBox16.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox16.Location = New Point(751, 120)
        TextBox16.Name = "TextBox16"
        TextBox16.Size = New Size(47, 29)
        TextBox16.TabIndex = 34
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(723, 395)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 34)
        btnClose.TabIndex = 39
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(633, 395)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 34)
        btnClear.TabIndex = 40
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(529, 395)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 34)
        btnSave.TabIndex = 41
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Add_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(823, 450)
        Controls.Add(btnSave)
        Controls.Add(btnClear)
        Controls.Add(btnClose)
        Controls.Add(TextBox13)
        Controls.Add(TextBox14)
        Controls.Add(TextBox15)
        Controls.Add(Label17)
        Controls.Add(TextBox16)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Controls.Add(Label15)
        Controls.Add(Label16)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(TextBox9)
        Controls.Add(TextBox10)
        Controls.Add(TextBox11)
        Controls.Add(Label6)
        Controls.Add(TextBox12)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(Label5)
        Controls.Add(TextBox5)
        Controls.Add(Label4)
        Controls.Add(txbMed4)
        Controls.Add(Label3)
        Controls.Add(txbMed3)
        Controls.Add(Label2)
        Controls.Add(txbMed2)
        Controls.Add(Label1)
        Controls.Add(txbMed1)
        Controls.Add(lblDateDetainedID)
        Controls.Add(dtpDetStart)
        Controls.Add(lblDetentionID)
        Controls.Add(cmbDetFacility)
        Controls.Add(lblChildNameID)
        Controls.Add(txbChildName)
        Name = "Add_Form"
        Text = "Add Child"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txbChildName As TextBox
    Friend WithEvents lblChildNameID As Label
    Friend WithEvents cmbDetFacility As ComboBox
    Friend WithEvents lblDetentionID As Label
    Friend WithEvents dtpDetStart As DateTimePicker
    Friend WithEvents lblDateDetainedID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txbMed1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbMed2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txbMed3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txbMed4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
End Class
