<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertUser
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
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.usn_Field = New System.Windows.Forms.TextBox()
        Me.invalid_usn = New System.Windows.Forms.Label()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.pass_Field = New System.Windows.Forms.Label()
        Me.password_Field = New System.Windows.Forms.TextBox()
        Me.Invalid_pass = New System.Windows.Forms.Label()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.field = New System.Windows.Forms.Label()
        Me.section_Field = New System.Windows.Forms.TextBox()
        Me.invalid_section = New System.Windows.Forms.Label()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.publisher_Label = New System.Windows.Forms.Label()
        Me.name_Field = New System.Windows.Forms.TextBox()
        Me.invalid_name = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.update_Btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.added_Label = New System.Windows.Forms.Label()
        Me.Panel16.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Panel27)
        Me.Panel16.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel16.Size = New System.Drawing.Size(551, 314)
        Me.Panel16.TabIndex = 2
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Panel27.Controls.Add(Me.Label2)
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel27.Location = New System.Drawing.Point(10, 10)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(531, 58)
        Me.Panel27.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(231, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Add"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel18)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel22)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel25)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel26)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(10, 69)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(531, 235)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.Label4)
        Me.Panel18.Controls.Add(Me.usn_Field)
        Me.Panel18.Controls.Add(Me.invalid_usn)
        Me.Panel18.Location = New System.Drawing.Point(3, 3)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(3, 3, 20, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(249, 64)
        Me.Panel18.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "USN"
        '
        'usn_Field
        '
        Me.usn_Field.BackColor = System.Drawing.Color.White
        Me.usn_Field.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.usn_Field.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usn_Field.Location = New System.Drawing.Point(0, 21)
        Me.usn_Field.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.usn_Field.Name = "usn_Field"
        Me.usn_Field.Size = New System.Drawing.Size(249, 26)
        Me.usn_Field.TabIndex = 2
        '
        'invalid_usn
        '
        Me.invalid_usn.AutoSize = True
        Me.invalid_usn.BackColor = System.Drawing.Color.Transparent
        Me.invalid_usn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.invalid_usn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invalid_usn.ForeColor = System.Drawing.Color.Firebrick
        Me.invalid_usn.Location = New System.Drawing.Point(0, 47)
        Me.invalid_usn.Name = "invalid_usn"
        Me.invalid_usn.Size = New System.Drawing.Size(0, 17)
        Me.invalid_usn.TabIndex = 12
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.pass_Field)
        Me.Panel22.Controls.Add(Me.password_Field)
        Me.Panel22.Controls.Add(Me.Invalid_pass)
        Me.Panel22.Location = New System.Drawing.Point(275, 3)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(248, 64)
        Me.Panel22.TabIndex = 1
        '
        'pass_Field
        '
        Me.pass_Field.AutoSize = True
        Me.pass_Field.Dock = System.Windows.Forms.DockStyle.Left
        Me.pass_Field.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass_Field.Location = New System.Drawing.Point(0, 0)
        Me.pass_Field.Name = "pass_Field"
        Me.pass_Field.Size = New System.Drawing.Size(77, 18)
        Me.pass_Field.TabIndex = 3
        Me.pass_Field.Text = "Password"
        '
        'password_Field
        '
        Me.password_Field.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.password_Field.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_Field.Location = New System.Drawing.Point(0, 21)
        Me.password_Field.Name = "password_Field"
        Me.password_Field.Size = New System.Drawing.Size(248, 26)
        Me.password_Field.TabIndex = 2
        '
        'Invalid_pass
        '
        Me.Invalid_pass.AutoSize = True
        Me.Invalid_pass.BackColor = System.Drawing.Color.Transparent
        Me.Invalid_pass.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Invalid_pass.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invalid_pass.ForeColor = System.Drawing.Color.Firebrick
        Me.Invalid_pass.Location = New System.Drawing.Point(0, 47)
        Me.Invalid_pass.Name = "Invalid_pass"
        Me.Invalid_pass.Size = New System.Drawing.Size(0, 17)
        Me.Invalid_pass.TabIndex = 13
        '
        'Panel25
        '
        Me.Panel25.Controls.Add(Me.field)
        Me.Panel25.Controls.Add(Me.section_Field)
        Me.Panel25.Controls.Add(Me.invalid_section)
        Me.Panel25.Location = New System.Drawing.Point(3, 73)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(3, 3, 20, 3)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(249, 64)
        Me.Panel25.TabIndex = 4
        '
        'field
        '
        Me.field.AutoSize = True
        Me.field.Dock = System.Windows.Forms.DockStyle.Left
        Me.field.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.field.Location = New System.Drawing.Point(0, 0)
        Me.field.Name = "field"
        Me.field.Size = New System.Drawing.Size(62, 18)
        Me.field.TabIndex = 3
        Me.field.Text = "Section"
        '
        'section_Field
        '
        Me.section_Field.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.section_Field.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.section_Field.Location = New System.Drawing.Point(0, 21)
        Me.section_Field.Name = "section_Field"
        Me.section_Field.Size = New System.Drawing.Size(249, 26)
        Me.section_Field.TabIndex = 2
        '
        'invalid_section
        '
        Me.invalid_section.AutoSize = True
        Me.invalid_section.BackColor = System.Drawing.Color.Transparent
        Me.invalid_section.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.invalid_section.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invalid_section.ForeColor = System.Drawing.Color.Firebrick
        Me.invalid_section.Location = New System.Drawing.Point(0, 47)
        Me.invalid_section.Name = "invalid_section"
        Me.invalid_section.Size = New System.Drawing.Size(0, 17)
        Me.invalid_section.TabIndex = 14
        '
        'Panel26
        '
        Me.Panel26.Controls.Add(Me.publisher_Label)
        Me.Panel26.Controls.Add(Me.name_Field)
        Me.Panel26.Controls.Add(Me.invalid_name)
        Me.Panel26.Location = New System.Drawing.Point(275, 73)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(248, 64)
        Me.Panel26.TabIndex = 5
        '
        'publisher_Label
        '
        Me.publisher_Label.AutoSize = True
        Me.publisher_Label.Dock = System.Windows.Forms.DockStyle.Left
        Me.publisher_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisher_Label.Location = New System.Drawing.Point(0, 0)
        Me.publisher_Label.Name = "publisher_Label"
        Me.publisher_Label.Size = New System.Drawing.Size(48, 18)
        Me.publisher_Label.TabIndex = 4
        Me.publisher_Label.Text = "Name"
        '
        'name_Field
        '
        Me.name_Field.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.name_Field.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_Field.Location = New System.Drawing.Point(0, 21)
        Me.name_Field.Name = "name_Field"
        Me.name_Field.Size = New System.Drawing.Size(248, 26)
        Me.name_Field.TabIndex = 3
        '
        'invalid_name
        '
        Me.invalid_name.AutoSize = True
        Me.invalid_name.BackColor = System.Drawing.Color.Transparent
        Me.invalid_name.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.invalid_name.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invalid_name.ForeColor = System.Drawing.Color.Firebrick
        Me.invalid_name.Location = New System.Drawing.Point(0, 47)
        Me.invalid_name.Name = "invalid_name"
        Me.invalid_name.Size = New System.Drawing.Size(0, 17)
        Me.invalid_name.TabIndex = 14
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.update_Btn)
        Me.Panel6.Location = New System.Drawing.Point(3, 143)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 3, 20, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(249, 48)
        Me.Panel6.TabIndex = 10
        '
        'update_Btn
        '
        Me.update_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.update_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.update_Btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.update_Btn.FlatAppearance.BorderSize = 0
        Me.update_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_Btn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_Btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.update_Btn.Location = New System.Drawing.Point(0, 0)
        Me.update_Btn.Name = "update_Btn"
        Me.update_Btn.Size = New System.Drawing.Size(249, 48)
        Me.update_Btn.TabIndex = 0
        Me.update_Btn.Text = "Add User"
        Me.update_Btn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(275, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 48)
        Me.Panel2.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.added_Label)
        Me.Panel3.Location = New System.Drawing.Point(3, 197)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(520, 23)
        Me.Panel3.TabIndex = 12
        '
        'added_Label
        '
        Me.added_Label.AutoSize = True
        Me.added_Label.BackColor = System.Drawing.Color.Honeydew
        Me.added_Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.added_Label.ForeColor = System.Drawing.Color.DarkGreen
        Me.added_Label.Location = New System.Drawing.Point(231, 5)
        Me.added_Label.Name = "added_Label"
        Me.added_Label.Size = New System.Drawing.Size(0, 18)
        Me.added_Label.TabIndex = 0
        '
        'insertUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 314)
        Me.Controls.Add(Me.Panel16)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "insertUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "insertUser"
        Me.Panel16.ResumeLayout(False)
        Me.Panel27.ResumeLayout(False)
        Me.Panel27.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel16 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents usn_Field As TextBox
    Friend WithEvents invalid_usn As Label
    Friend WithEvents Panel22 As Panel
    Friend WithEvents pass_Field As Label
    Friend WithEvents password_Field As TextBox
    Friend WithEvents Invalid_pass As Label
    Friend WithEvents Panel25 As Panel
    Friend WithEvents field As Label
    Friend WithEvents section_Field As TextBox
    Friend WithEvents invalid_section As Label
    Friend WithEvents Panel26 As Panel
    Friend WithEvents publisher_Label As Label
    Friend WithEvents name_Field As TextBox
    Friend WithEvents invalid_name As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents update_Btn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents added_Label As Label
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Label2 As Label
End Class
