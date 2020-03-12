<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frontpage3
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Btninsert = New System.Windows.Forms.Button()
        Me.Btnupdate = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SdeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SyearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentdetailsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamcellbdDataSet4 = New examcellvb.examcellbdDataSet4()
        Me.StudentdetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamcellbdDataSet2 = New examcellvb.examcellbdDataSet2()
        Me.StudentdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamcellbdDataSet = New examcellvb.examcellbdDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StudentdetailsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamcellbdDataSet3 = New examcellvb.examcellbdDataSet3()
        Me.Student_detailsTableAdapter2 = New examcellvb.examcellbdDataSet3TableAdapters.student_detailsTableAdapter()
        Me.Student_detailsTableAdapter = New examcellvb.examcellbdDataSet4TableAdapters.student_detailsTableAdapter()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentdetailsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamcellbdDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentdetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamcellbdDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamcellbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentdetailsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamcellbdDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(22, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(169, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label3.Location = New System.Drawing.Point(22, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label4.Location = New System.Drawing.Point(22, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Course"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label5.Location = New System.Drawing.Point(22, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label6.Location = New System.Drawing.Point(22, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Year"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(169, 125)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(220, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(169, 212)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(220, 20)
        Me.TextBox4.TabIndex = 9
        '
        'Btninsert
        '
        Me.Btninsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btninsert.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Btninsert.Location = New System.Drawing.Point(26, 324)
        Me.Btninsert.Name = "Btninsert"
        Me.Btninsert.Size = New System.Drawing.Size(75, 33)
        Me.Btninsert.TabIndex = 12
        Me.Btninsert.Text = "Insert"
        Me.Btninsert.UseVisualStyleBackColor = True
        '
        'Btnupdate
        '
        Me.Btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnupdate.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Btnupdate.Location = New System.Drawing.Point(130, 324)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(75, 33)
        Me.Btnupdate.TabIndex = 13
        Me.Btnupdate.Text = "Update"
        Me.Btnupdate.UseVisualStyleBackColor = True
        '
        'Btndelete
        '
        Me.Btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btndelete.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Btndelete.Location = New System.Drawing.Point(230, 324)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(75, 33)
        Me.Btndelete.TabIndex = 15
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(832, 442)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "powered by YOGA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(881, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "X"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SIDDataGridViewTextBoxColumn, Me.SnameDataGridViewTextBoxColumn, Me.ScourceDataGridViewTextBoxColumn, Me.SdeptDataGridViewTextBoxColumn, Me.SyearDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentdetailsBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(416, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(503, 351)
        Me.DataGridView1.TabIndex = 18
        '
        'SIDDataGridViewTextBoxColumn
        '
        Me.SIDDataGridViewTextBoxColumn.DataPropertyName = "S_ID"
        Me.SIDDataGridViewTextBoxColumn.HeaderText = "S_ID"
        Me.SIDDataGridViewTextBoxColumn.Name = "SIDDataGridViewTextBoxColumn"
        Me.SIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "S_name"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "S_name"
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        Me.SnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ScourceDataGridViewTextBoxColumn
        '
        Me.ScourceDataGridViewTextBoxColumn.DataPropertyName = "S_cource"
        Me.ScourceDataGridViewTextBoxColumn.HeaderText = "S_cource"
        Me.ScourceDataGridViewTextBoxColumn.Name = "ScourceDataGridViewTextBoxColumn"
        Me.ScourceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SdeptDataGridViewTextBoxColumn
        '
        Me.SdeptDataGridViewTextBoxColumn.DataPropertyName = "S_dept"
        Me.SdeptDataGridViewTextBoxColumn.HeaderText = "S_dept"
        Me.SdeptDataGridViewTextBoxColumn.Name = "SdeptDataGridViewTextBoxColumn"
        Me.SdeptDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SyearDataGridViewTextBoxColumn
        '
        Me.SyearDataGridViewTextBoxColumn.DataPropertyName = "S_year"
        Me.SyearDataGridViewTextBoxColumn.HeaderText = "S_year"
        Me.SyearDataGridViewTextBoxColumn.Name = "SyearDataGridViewTextBoxColumn"
        Me.SyearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentdetailsBindingSource3
        '
        Me.StudentdetailsBindingSource3.DataMember = "student_details"
        Me.StudentdetailsBindingSource3.DataSource = Me.ExamcellbdDataSet4
        '
        'ExamcellbdDataSet4
        '
        Me.ExamcellbdDataSet4.DataSetName = "examcellbdDataSet4"
        Me.ExamcellbdDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentdetailsBindingSource1
        '
        Me.StudentdetailsBindingSource1.DataMember = "student_details"
        Me.StudentdetailsBindingSource1.DataSource = Me.ExamcellbdDataSet2
        '
        'ExamcellbdDataSet2
        '
        Me.ExamcellbdDataSet2.DataSetName = "examcellbdDataSet2"
        Me.ExamcellbdDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentdetailsBindingSource
        '
        Me.StudentdetailsBindingSource.DataMember = "student_details"
        Me.StudentdetailsBindingSource.DataSource = Me.ExamcellbdDataSet
        '
        'ExamcellbdDataSet
        '
        Me.ExamcellbdDataSet.DataSetName = "examcellbdDataSet"
        Me.ExamcellbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(335, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StudentdetailsBindingSource2
        '
        Me.StudentdetailsBindingSource2.DataMember = "student_details"
        Me.StudentdetailsBindingSource2.DataSource = Me.ExamcellbdDataSet3
        '
        'ExamcellbdDataSet3
        '
        Me.ExamcellbdDataSet3.DataSetName = "examcellbdDataSet3"
        Me.ExamcellbdDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_detailsTableAdapter2
        '
        Me.Student_detailsTableAdapter2.ClearBeforeFill = True
        '
        'Student_detailsTableAdapter
        '
        Me.Student_detailsTableAdapter.ClearBeforeFill = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(169, 170)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(220, 20)
        Me.TextBox3.TabIndex = 22
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(169, 261)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(220, 20)
        Me.TextBox5.TabIndex = 23
        '
        'Frontpage3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 459)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Btndelete)
        Me.Controls.Add(Me.Btnupdate)
        Me.Controls.Add(Me.Btninsert)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frontpage3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "student information"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentdetailsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamcellbdDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentdetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamcellbdDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamcellbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentdetailsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamcellbdDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Btninsert As Button
    Friend WithEvents Btnupdate As Button
    Friend WithEvents Btndelete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ExamcellbdDataSet As examcellbdDataSet
    Friend WithEvents StudentdetailsBindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents ExamcellbdDataSet2 As examcellbdDataSet2
    Friend WithEvents StudentdetailsBindingSource1 As BindingSource
    Friend WithEvents ExamcellbdDataSet3 As examcellbdDataSet3
    Friend WithEvents StudentdetailsBindingSource2 As BindingSource
    Friend WithEvents Student_detailsTableAdapter2 As examcellbdDataSet3TableAdapters.student_detailsTableAdapter
    Friend WithEvents ExamcellbdDataSet4 As examcellbdDataSet4
    Friend WithEvents StudentdetailsBindingSource3 As BindingSource
    Friend WithEvents Student_detailsTableAdapter As examcellbdDataSet4TableAdapters.student_detailsTableAdapter
    Friend WithEvents SIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SdeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SyearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
