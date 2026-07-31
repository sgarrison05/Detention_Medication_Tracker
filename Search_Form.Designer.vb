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
        btnClear = New Button()
        btnReturn = New Button()
        btnAdd = New Button()
        lblDetentionID = New Label()
        TextBox1 = New TextBox()
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
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.ActiveBorder
        btnClear.Location = New Point(206, 182)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 40)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.Gold
        btnReturn.Location = New Point(307, 182)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(75, 40)
        btnReturn.TabIndex = 6
        btnReturn.Text = "Main"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Orange
        btnAdd.Location = New Point(106, 182)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 40)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' lblDetentionID
        ' 
        lblDetentionID.AutoSize = True
        lblDetentionID.Location = New Point(351, 11)
        lblDetentionID.Name = "lblDetentionID"
        lblDetentionID.Size = New Size(102, 15)
        lblDetentionID.TabIndex = 8
        lblDetentionID.Text = "Detention Facility:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(351, 29)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(234, 29)
        TextBox1.TabIndex = 9
        ' 
        ' frmSearch
        ' 
        AcceptButton = btnEnter
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnClear
        ClientSize = New Size(597, 246)
        Controls.Add(TextBox1)
        Controls.Add(lblDetentionID)
        Controls.Add(btnAdd)
        Controls.Add(btnReturn)
        Controls.Add(btnClear)
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
    Friend WithEvents btnClear As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblDetentionID As Label
    Friend WithEvents TextBox1 As TextBox
End Class
