<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frontpage4
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.classtextbx = New System.Windows.Forms.TextBox()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.insertbtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.blockcombo = New System.Windows.Forms.ComboBox()
        Me.benchcombo = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BenchesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HallinformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamcellbdDataSet1 = New examcellvb.examcellbdDataSet1()
        Me.ExamcellbdDataSet = New examcellvb.examcellbdDataSet()
        Me.ExamcellbdDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hall_informationTableAdapter = New examcellvb.examcellbdDataSet1TableAdapters.hall_informationTableAdapter()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HallinformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamcellbdDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamcellbdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamcellbdDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 26.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(320, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hall Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(84, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Classes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label3.Location = New System.Drawing.Point(99, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Block"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(97, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HALL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label6.Location = New System.Drawing.Point(3, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(295, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Tag = "add"
        Me.Label6.Text = "Number of Bench's per classroom"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 410)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 6
        '
        'classtextbx
        '
        Me.classtextbx.Location = New System.Drawing.Point(304, 140)
        Me.classtextbx.Name = "classtextbx"
        Me.classtextbx.Size = New System.Drawing.Size(273, 20)
        Me.classtextbx.TabIndex = 7
        '
        'updatebtn
        '
        Me.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updatebtn.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.updatebtn.Location = New System.Drawing.Point(138, 410)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(75, 33)
        Me.updatebtn.TabIndex = 10
        Me.updatebtn.Text = "Update"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'cancelbtn
        '
        Me.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelbtn.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.cancelbtn.Location = New System.Drawing.Point(368, 410)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(75, 33)
        Me.cancelbtn.TabIndex = 11
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'deletebtn
        '
        Me.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deletebtn.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.deletebtn.Location = New System.Drawing.Point(249, 410)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(75, 33)
        Me.deletebtn.TabIndex = 12
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'insertbtn
        '
        Me.insertbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.insertbtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertbtn.Location = New System.Drawing.Point(25, 410)
        Me.insertbtn.Name = "insertbtn"
        Me.insertbtn.Size = New System.Drawing.Size(75, 33)
        Me.insertbtn.TabIndex = 13
        Me.insertbtn.Text = "Insert"
        Me.insertbtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(882, 504)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "powered by YOGA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(925, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "X"
        '
        'blockcombo
        '
        Me.blockcombo.FormattingEnabled = True
        Me.blockcombo.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.blockcombo.Location = New System.Drawing.Point(304, 239)
        Me.blockcombo.Name = "blockcombo"
        Me.blockcombo.Size = New System.Drawing.Size(273, 21)
        Me.blockcombo.TabIndex = 17
        '
        'benchcombo
        '
        Me.benchcombo.FormattingEnabled = True
        Me.benchcombo.Items.AddRange(New Object() {"25", "27", "31", "33", "35"})
        Me.benchcombo.Location = New System.Drawing.Point(304, 358)
        Me.benchcombo.Name = "benchcombo"
        Me.benchcombo.Size = New System.Drawing.Size(273, 21)
        Me.benchcombo.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClassDataGridViewTextBoxColumn, Me.BlockDataGridViewTextBoxColumn, Me.BenchesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HallinformationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(634, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(305, 246)
        Me.DataGridView1.TabIndex = 19
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        Me.ClassDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BlockDataGridViewTextBoxColumn
        '
        Me.BlockDataGridViewTextBoxColumn.DataPropertyName = "block"
        Me.BlockDataGridViewTextBoxColumn.HeaderText = "block"
        Me.BlockDataGridViewTextBoxColumn.Name = "BlockDataGridViewTextBoxColumn"
        Me.BlockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BenchesDataGridViewTextBoxColumn
        '
        Me.BenchesDataGridViewTextBoxColumn.DataPropertyName = "benches"
        Me.BenchesDataGridViewTextBoxColumn.HeaderText = "benches"
        Me.BenchesDataGridViewTextBoxColumn.Name = "BenchesDataGridViewTextBoxColumn"
        Me.BenchesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HallinformationBindingSource
        '
        Me.HallinformationBindingSource.DataMember = "hall_information"
        Me.HallinformationBindingSource.DataSource = Me.ExamcellbdDataSet1
        '
        'ExamcellbdDataSet1
        '
        Me.ExamcellbdDataSet1.DataSetName = "examcellbdDataSet1"
        Me.ExamcellbdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExamcellbdDataSet
        '
        Me.ExamcellbdDataSet.DataSetName = "examcellbdDataSet"
        Me.ExamcellbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExamcellbdDataSetBindingSource
        '
        Me.ExamcellbdDataSetBindingSource.DataSource = Me.ExamcellbdDataSet
        Me.ExamcellbdDataSetBindingSource.Position = 0
        '
        'Hall_informationTableAdapter
        '
        Me.Hall_informationTableAdapter.ClearBeforeFill = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label10.Location = New System.Drawing.Point(84, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 23)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Strength"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label11.Location = New System.Drawing.Point(84, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 23)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Class"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(304, 190)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(273, 20)
        Me.TextBox1.TabIndex = 22
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(304, 293)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(273, 20)
        Me.TextBox2.TabIndex = 23
        '
        'frontpage4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 521)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.benchcombo)
        Me.Controls.Add(Me.blockcombo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.insertbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.classtextbx)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frontpage4"
        Me.ShowIcon = False
        Me.Text = "hall information"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HallinformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamcellbdDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamcellbdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamcellbdDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents classtextbx As TextBox
    Friend WithEvents updatebtn As Button
    Friend WithEvents cancelbtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents insertbtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents blockcombo As ComboBox
    Friend WithEvents benchcombo As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ExamcellbdDataSetBindingSource As BindingSource
    Friend WithEvents ExamcellbdDataSet As examcellbdDataSet
    Friend WithEvents ExamcellbdDataSet1 As examcellbdDataSet1
    Friend WithEvents HallinformationBindingSource As BindingSource
    Friend WithEvents Hall_informationTableAdapter As examcellbdDataSet1TableAdapters.hall_informationTableAdapter
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BlockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BenchesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
