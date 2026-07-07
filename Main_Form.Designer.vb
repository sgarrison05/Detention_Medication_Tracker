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
        lblWarning = New Label()
        Label1 = New Label()
        Label2 = New Label()
        lblDateToday = New Label()
        lblTodayID = New Label()
        SuspendLayout()
        ' 
        ' lblListing
        ' 
        lblListing.BackColor = SystemColors.ActiveCaptionText
        lblListing.BorderStyle = BorderStyle.FixedSingle
        lblListing.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblListing.ForeColor = SystemColors.Info
        lblListing.Location = New Point(25, 108)
        lblListing.Name = "lblListing"
        lblListing.Size = New Size(813, 130)
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
        btnAdd.Location = New Point(438, 315)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(80, 38)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Orange
        btnUpdate.Location = New Point(545, 315)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(80, 38)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Yellow
        btnSearch.Location = New Point(651, 315)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(80, 38)
        btnSearch.TabIndex = 8
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Tomato
        btnClose.Location = New Point(758, 315)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(80, 38)
        btnClose.TabIndex = 9
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.DodgerBlue
        btnRefresh.Location = New Point(331, 315)
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
        lblDateDetained.Location = New Point(389, 42)
        lblDateDetained.Name = "lblDateDetained"
        lblDateDetained.Size = New Size(100, 23)
        lblDateDetained.TabIndex = 13
        lblDateDetained.Text = "dteDetained"
        lblDateDetained.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDateDetID
        ' 
        lblDateDetID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDateDetID.Location = New Point(364, 22)
        lblDateDetID.Name = "lblDateDetID"
        lblDateDetID.Size = New Size(154, 15)
        lblDateDetID.TabIndex = 12
        lblDateDetID.Text = "Date Detained/Start Med:"
        ' 
        ' lblWarning
        ' 
        lblWarning.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWarning.ForeColor = Color.Red
        lblWarning.Location = New Point(331, 251)
        lblWarning.Name = "lblWarning"
        lblWarning.Size = New Size(507, 38)
        lblWarning.TabIndex = 18
        lblWarning.Text = "Warning"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(590, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 23)
        Label1.TabIndex = 20
        Label1.Text = "No. of Days"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(590, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 15)
        Label2.TabIndex = 19
        Label2.Text = "Length of Stay"
        ' 
        ' lblDateToday
        ' 
        lblDateToday.Font = New Font("Segoe UI", 12F)
        lblDateToday.Location = New Point(738, 40)
        lblDateToday.Name = "lblDateToday"
        lblDateToday.Size = New Size(100, 23)
        lblDateToday.TabIndex = 22
        lblDateToday.Text = "dteToday"
        lblDateToday.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTodayID
        ' 
        lblTodayID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTodayID.Location = New Point(746, 22)
        lblTodayID.Name = "lblTodayID"
        lblTodayID.Size = New Size(85, 15)
        lblTodayID.TabIndex = 21
        lblTodayID.Text = "Today's Date:"
        lblTodayID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmMain
        ' 
        AcceptButton = btnAdd
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnClose
        ClientSize = New Size(866, 365)
        Controls.Add(lblDateToday)
        Controls.Add(lblTodayID)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(lblWarning)
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
        Text = "Detention Medication Tracker"
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
    Friend WithEvents lblWarning As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDateToday As Label
    Friend WithEvents lblTodayID As Label

End Class
