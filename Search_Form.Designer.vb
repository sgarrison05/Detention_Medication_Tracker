<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        lblCLastNamID = New Label()
        txbCLastName = New TextBox()
        lblDisplay = New Label()
        btnEnter = New Button()
        btnUpdate = New Button()
        btnClear = New Button()
        btnReturn = New Button()
        SuspendLayout()
        ' 
        ' lblCLastNamID
        ' 
        lblCLastNamID.AutoSize = True
        lblCLastNamID.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCLastNamID.Location = New Point(12, 9)
        lblCLastNamID.Name = "lblCLastNamID"
        lblCLastNamID.Size = New Size(106, 17)
        lblCLastNamID.TabIndex = 0
        lblCLastNamID.Text = "Child Last Name:"
        ' 
        ' txbCLastName
        ' 
        txbCLastName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbCLastName.Location = New Point(12, 29)
        txbCLastName.Name = "txbCLastName"
        txbCLastName.Size = New Size(301, 29)
        txbCLastName.TabIndex = 1
        ' 
        ' lblDisplay
        ' 
        lblDisplay.BackColor = SystemColors.ActiveCaptionText
        lblDisplay.ForeColor = SystemColors.ControlLightLight
        lblDisplay.Location = New Point(12, 81)
        lblDisplay.Name = "lblDisplay"
        lblDisplay.Size = New Size(573, 75)
        lblDisplay.TabIndex = 2
        lblDisplay.Text = "[Facility] [Child Full Name] [Initial Date Detained]"
        ' 
        ' btnEnter
        ' 
        btnEnter.BackColor = Color.LimeGreen
        btnEnter.Location = New Point(10, 182)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(75, 40)
        btnEnter.TabIndex = 3
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Orange
        btnUpdate.Location = New Point(107, 182)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 40)
        btnUpdate.TabIndex = 4
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.ActiveBorder
        btnClear.Location = New Point(205, 182)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 40)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.Gold
        btnReturn.Location = New Point(306, 182)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(75, 40)
        btnReturn.TabIndex = 6
        btnReturn.Text = "Rtn Main"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' frmSearch
        ' 
        AcceptButton = btnEnter
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnClear
        ClientSize = New Size(597, 246)
        Controls.Add(btnReturn)
        Controls.Add(btnClear)
        Controls.Add(btnUpdate)
        Controls.Add(btnEnter)
        Controls.Add(lblDisplay)
        Controls.Add(txbCLastName)
        Controls.Add(lblCLastNamID)
        Name = "frmSearch"
        Text = "Search for Child"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCLastNamID As Label
    Friend WithEvents txbCLastName As TextBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnReturn As Button
End Class
