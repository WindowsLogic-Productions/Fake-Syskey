<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Syskey1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Syskey1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(-334, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This tool will allow you to configure the Accounts Database to enable additional " & _
            "encryption, further protecting the database from compromise"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(83, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "This tool will allow you to configure the Accounts Database to enable addition en" & _
            "cryption, further protecting the database from compromise."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Fake_Syskey.My.Resources.Resources.Syskey_Picture
        Me.PictureBox1.Location = New System.Drawing.Point(20, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(83, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Once enabled, This encryption cannot be disabled."
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(86, 114)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(128, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.Text = "Encryption Disabled"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(86, 137)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(120, 17)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Encrption Enabled"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKButton.Location = New System.Drawing.Point(54, 169)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelButton.Location = New System.Drawing.Point(135, 169)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 1
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.UpdateButton.Location = New System.Drawing.Point(216, 169)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 2
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'Syskey1
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 198)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Syskey1"
        Me.ShowIcon = False
        Me.Text = "Securing the Windows Account Database"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button

End Class
