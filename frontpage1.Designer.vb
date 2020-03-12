<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frontpage1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.usernametextBox = New System.Windows.Forms.TextBox()
        Me.passwordtextBox = New System.Windows.Forms.TextBox()
        Me.Cmblogin = New System.Windows.Forms.ComboBox()
        Me.Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1030, 179)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(931, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(271, 148)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(399, 403)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.examcellvb.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(356, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 229)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'usernametextBox
        '
        Me.usernametextBox.Font = New System.Drawing.Font("Segoe Print", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.usernametextBox.Location = New System.Drawing.Point(356, 296)
        Me.usernametextBox.Name = "usernametextBox"
        Me.usernametextBox.Size = New System.Drawing.Size(225, 36)
        Me.usernametextBox.TabIndex = 0
        Me.usernametextBox.Text = "yoga"
        Me.usernametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'passwordtextBox
        '
        Me.passwordtextBox.Font = New System.Drawing.Font("Segoe Print", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtextBox.Location = New System.Drawing.Point(356, 359)
        Me.passwordtextBox.Name = "passwordtextBox"
        Me.passwordtextBox.Size = New System.Drawing.Size(225, 36)
        Me.passwordtextBox.TabIndex = 1
        Me.passwordtextBox.Text = "yoga"
        Me.passwordtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.passwordtextBox.UseSystemPasswordChar = True
        '
        'Cmblogin
        '
        Me.Cmblogin.AllowDrop = True
        Me.Cmblogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmblogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmblogin.FormattingEnabled = True
        Me.Cmblogin.Items.AddRange(New Object() {"admin", "user"})
        Me.Cmblogin.Location = New System.Drawing.Point(356, 401)
        Me.Cmblogin.MaxLength = 14
        Me.Cmblogin.Name = "Cmblogin"
        Me.Cmblogin.Size = New System.Drawing.Size(121, 21)
        Me.Cmblogin.Sorted = True
        Me.Cmblogin.TabIndex = 3
        '
        'Button
        '
        Me.Button.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button.Location = New System.Drawing.Point(396, 440)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(147, 49)
        Me.Button.TabIndex = 3
        Me.Button.Text = "Log In"
        Me.Button.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(870, 534)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "powered by YOGA"
        '
        'frontpage1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 554)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.Cmblogin)
        Me.Controls.Add(Me.passwordtextBox)
        Me.Controls.Add(Me.usernametextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frontpage1"
        Me.Text = "log in"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents usernametextBox As TextBox
    Friend WithEvents passwordtextBox As TextBox
    Friend WithEvents Cmblogin As ComboBox
    Friend WithEvents Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
