<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblListing = New Label()
        lblListingID = New Label()
        txbChildName = New TextBox()
        lblChildNameID = New Label()
        lblNKIDID = New Label()
        lblNKID = New Label()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnSearch = New Button()
        btnClose = New Button()
        btnRefresh = New Button()
        btnData = New Button()
        lblDateDetained = New Label()
        lblDateDetID = New Label()
        lblDateReminder = New Label()
        lblDateRemindID = New Label()
        Label1 = New Label()
        lblDateRunoutID = New Label()
        SuspendLayout()
        ' 
        ' lblListing
        ' 
        lblListing.BackColor = SystemColors.ActiveCaptionText
        lblListing.BorderStyle = BorderStyle.FixedSingle
        lblListing.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblListing.ForeColor = SystemColors.Info
        lblListing.Location = New Point(25, 113)
        lblListing.Name = "lblListing"
        lblListing.Size = New Size(700, 130)
        lblListing.TabIndex = 0
        ' 
        ' lblListingID
        ' 
        lblListingID.AutoSize = True
        lblListingID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblListingID.Location = New Point(25, 93)
        lblListingID.Name = "lblListingID"
        lblListingID.Size = New Size(122, 15)
        lblListingID.TabIndex = 1
        lblListingID.Text = "Current Child Listing:" & vbCrLf
        ' 
        ' txbChildName
        ' 
        txbChildName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbChildName.Location = New Point(25, 40)
        txbChildName.Name = "txbChildName"
        txbChildName.Size = New Size(300, 29)
        txbChildName.TabIndex = 2
        ' 
        ' lblChildNameID
        ' 
        lblChildNameID.AutoSize = True
        lblChildNameID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblChildNameID.Location = New Point(25, 22)
        lblChildNameID.Name = "lblChildNameID"
        lblChildNameID.Size = New Size(73, 15)
        lblChildNameID.TabIndex = 3
        lblChildNameID.Text = "Child Name:"
        ' 
        ' lblNKIDID
        ' 
        lblNKIDID.AutoSize = True
        lblNKIDID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNKIDID.Location = New Point(25, 251)
        lblNKIDID.Name = "lblNKIDID"
        lblNKIDID.Size = New Size(136, 15)
        lblNKIDID.TabIndex = 4
        lblNKIDID.Text = "Total Kids in Detention:" & vbCrLf
        ' 
        ' lblNKID
        ' 
        lblNKID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNKID.Location = New Point(37, 266)
        lblNKID.Name = "lblNKID"
        lblNKID.Size = New Size(100, 23)
        lblNKID.TabIndex = 5
        lblNKID.Text = "# Kids"
        lblNKID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Green
        btnAdd.Location = New Point(325, 315)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(80, 38)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Orange
        btnUpdate.Location = New Point(432, 315)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(80, 38)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Yellow
        btnSearch.Location = New Point(538, 315)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(80, 38)
        btnSearch.TabIndex = 8
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Tomato
        btnClose.Location = New Point(645, 315)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(80, 38)
        btnClose.TabIndex = 9
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.DodgerBlue
        btnRefresh.Location = New Point(218, 315)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(80, 38)
        btnRefresh.TabIndex = 10
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnData
        ' 
        btnData.BackColor = Color.MediumPurple
        btnData.Location = New Point(12, 315)
        btnData.Name = "btnData"
        btnData.Size = New Size(80, 38)
        btnData.TabIndex = 11
        btnData.Text = "Data File"
        btnData.UseVisualStyleBackColor = False
        ' 
        ' lblDateDetained
        ' 
        lblDateDetained.Font = New Font("Segoe UI", 12F)
        lblDateDetained.Location = New Point(358, 44)
        lblDateDetained.Name = "lblDateDetained"
        lblDateDetained.Size = New Size(100, 23)
        lblDateDetained.TabIndex = 13
        lblDateDetained.Text = "dteDetained"
        lblDateDetained.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDateDetID
        ' 
        lblDateDetID.AutoSize = True
        lblDateDetID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDateDetID.Location = New Point(364, 22)
        lblDateDetID.Name = "lblDateDetID"
        lblDateDetID.Size = New Size(91, 15)
        lblDateDetID.TabIndex = 12
        lblDateDetID.Text = "Date Detained:"
        ' 
        ' lblDateReminder
        ' 
        lblDateReminder.Font = New Font("Segoe UI", 12F)
        lblDateReminder.Location = New Point(510, 44)
        lblDateReminder.Name = "lblDateReminder"
        lblDateReminder.Size = New Size(100, 23)
        lblDateReminder.TabIndex = 15
        lblDateReminder.Text = "dteReminder"
        lblDateReminder.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDateRemindID
        ' 
        lblDateRemindID.AutoSize = True
        lblDateRemindID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDateRemindID.Location = New Point(506, 22)
        lblDateRemindID.Name = "lblDateRemindID"
        lblDateRemindID.Size = New Size(110, 15)
        lblDateRemindID.TabIndex = 14
        lblDateRemindID.Text = "Date of Reminder:"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(625, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 17
        Label1.Text = "dteRunout"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDateRunoutID
        ' 
        lblDateRunoutID.AutoSize = True
        lblDateRunoutID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDateRunoutID.Location = New Point(627, 22)
        lblDateRunoutID.Name = "lblDateRunoutID"
        lblDateRunoutID.Size = New Size(96, 15)
        lblDateRunoutID.TabIndex = 16
        lblDateRunoutID.Text = "Date of Runout:" & vbCrLf
        ' 
        ' frmMain
        ' 
        AcceptButton = btnAdd
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnClose
        ClientSize = New Size(748, 365)
        Controls.Add(Label1)
        Controls.Add(lblDateRunoutID)
        Controls.Add(lblDateReminder)
        Controls.Add(lblDateRemindID)
        Controls.Add(lblDateDetained)
        Controls.Add(lblDateDetID)
        Controls.Add(btnData)
        Controls.Add(btnRefresh)
        Controls.Add(btnClose)
        Controls.Add(btnSearch)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(lblNKID)
        Controls.Add(lblNKIDID)
        Controls.Add(lblChildNameID)
        Controls.Add(txbChildName)
        Controls.Add(lblListingID)
        Controls.Add(lblListing)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblListing As Label
    Friend WithEvents lblListingID As Label
    Friend WithEvents txbChildName As TextBox
    Friend WithEvents lblChildNameID As Label
    Friend WithEvents lblNKIDID As Label
    Friend WithEvents lblNKID As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnData As Button
    Friend WithEvents lblDateDetained As Label
    Friend WithEvents lblDateDetID As Label
    Friend WithEvents lblDateReminder As Label
    Friend WithEvents lblDateRemindID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDateRunoutID As Label

End Class
