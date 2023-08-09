<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        radioButtonYearlyLicense = New RadioButton()
        radioButtonOneTime = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        lblSoftwareLicensingCost = New Label()
        lblOptional = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnClose = New Button()
        GroupBox1 = New GroupBox()
        GroupBox3 = New GroupBox()
        checkBoxLevel3 = New CheckBox()
        checkBoxOnSite = New CheckBox()
        checkBoxCloud = New CheckBox()
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' radioButtonYearlyLicense
        ' 
        radioButtonYearlyLicense.AutoSize = True
        radioButtonYearlyLicense.Location = New Point(22, 34)
        radioButtonYearlyLicense.Name = "radioButtonYearlyLicense"
        radioButtonYearlyLicense.Size = New Size(121, 24)
        radioButtonYearlyLicense.TabIndex = 0
        radioButtonYearlyLicense.TabStop = True
        radioButtonYearlyLicense.Text = "Yearly License"
        radioButtonYearlyLicense.UseVisualStyleBackColor = True
        ' 
        ' radioButtonOneTime
        ' 
        radioButtonOneTime.AutoSize = True
        radioButtonOneTime.Location = New Point(22, 96)
        radioButtonOneTime.Name = "radioButtonOneTime"
        radioButtonOneTime.Size = New Size(158, 24)
        radioButtonOneTime.TabIndex = 1
        radioButtonOneTime.TabStop = True
        radioButtonOneTime.Text = "One-Time Purchase"
        radioButtonOneTime.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(4, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 20)
        Label1.TabIndex = 5
        Label1.Text = "Cost of Software Licensing:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(4, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 20)
        Label2.TabIndex = 6
        Label2.Text = "Cost of optional features:"
        ' 
        ' lblSoftwareLicensingCost
        ' 
        lblSoftwareLicensingCost.AutoEllipsis = True
        lblSoftwareLicensingCost.BorderStyle = BorderStyle.Fixed3D
        lblSoftwareLicensingCost.Location = New Point(238, 38)
        lblSoftwareLicensingCost.Name = "lblSoftwareLicensingCost"
        lblSoftwareLicensingCost.Size = New Size(185, 25)
        lblSoftwareLicensingCost.TabIndex = 7
        ' 
        ' lblOptional
        ' 
        lblOptional.AutoEllipsis = True
        lblOptional.BorderStyle = BorderStyle.Fixed3D
        lblOptional.Location = New Point(238, 86)
        lblOptional.Name = "lblOptional"
        lblOptional.Size = New Size(185, 25)
        lblOptional.TabIndex = 8
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(160, 446)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 9
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(408, 446)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(641, 446)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 11
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(radioButtonOneTime)
        GroupBox1.Controls.Add(radioButtonYearlyLicense)
        GroupBox1.Location = New Point(71, 52)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(218, 162)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Licensing Options"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(lblOptional)
        GroupBox3.Controls.Add(lblSoftwareLicensingCost)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Location = New Point(170, 263)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(505, 145)
        GroupBox3.TabIndex = 14
        GroupBox3.TabStop = False
        ' 
        ' checkBoxLevel3
        ' 
        checkBoxLevel3.AutoSize = True
        checkBoxLevel3.Location = New Point(58, 34)
        checkBoxLevel3.Name = "checkBoxLevel3"
        checkBoxLevel3.Size = New Size(201, 24)
        checkBoxLevel3.TabIndex = 15
        checkBoxLevel3.Text = "Level-3 Technical Support"
        checkBoxLevel3.UseVisualStyleBackColor = True
        ' 
        ' checkBoxOnSite
        ' 
        checkBoxOnSite.AutoSize = True
        checkBoxOnSite.Location = New Point(58, 66)
        checkBoxOnSite.Name = "checkBoxOnSite"
        checkBoxOnSite.Size = New Size(128, 24)
        checkBoxOnSite.TabIndex = 16
        checkBoxOnSite.Text = "On-site Trainig"
        checkBoxOnSite.UseVisualStyleBackColor = True
        ' 
        ' checkBoxCloud
        ' 
        checkBoxCloud.AutoSize = True
        checkBoxCloud.Location = New Point(58, 96)
        checkBoxCloud.Name = "checkBoxCloud"
        checkBoxCloud.Size = New Size(122, 24)
        checkBoxCloud.TabIndex = 17
        checkBoxCloud.Text = "Cloud Backup"
        checkBoxCloud.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonFace
        GroupBox2.Controls.Add(checkBoxCloud)
        GroupBox2.Controls.Add(checkBoxOnSite)
        GroupBox2.Controls.Add(checkBoxLevel3)
        GroupBox2.Location = New Point(407, 52)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(370, 158)
        GroupBox2.TabIndex = 18
        GroupBox2.TabStop = False
        GroupBox2.Text = "Optional features (Yearly)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 508)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(btnClose)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Name = "Form1"
        Text = "Software Sales"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents radioButtonYearlyLicense As RadioButton
    Friend WithEvents radioButtonOneTime As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSoftwareLicensingCost As Label
    Friend WithEvents lblOptional As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents checkBoxLevel3 As CheckBox
    Friend WithEvents checkBoxOnSite As CheckBox
    Friend WithEvents checkBoxCloud As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
