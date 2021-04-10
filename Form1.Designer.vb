<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RG1 = New Telerik.WinControls.UI.RadGridView()
        Me.RG2 = New Telerik.WinControls.UI.RadGridView()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnconfrm = New System.Windows.Forms.Button()
        Me.BtnReport = New System.Windows.Forms.Button()
        CType(Me.RG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RG1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RG2.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RG1
        '
        Me.RG1.BackColor = System.Drawing.SystemColors.Control
        Me.RG1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RG1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RG1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RG1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RG1.Location = New System.Drawing.Point(183, 70)
        '
        '
        '
        Me.RG1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "STUDENT_NAME"
        GridViewTextBoxColumn1.HeaderText = "STUDENT_NAME"
        GridViewTextBoxColumn1.Name = "STUDENT_NAME"
        GridViewTextBoxColumn1.Width = 216
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "DEPARTMENT"
        GridViewTextBoxColumn2.HeaderText = "DEPARTMENT"
        GridViewTextBoxColumn2.Name = "DEPARTMENT"
        GridViewTextBoxColumn2.Width = 215
        Me.RG1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2})
        Me.RG1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RG1.Name = "RG1"
        Me.RG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RG1.Size = New System.Drawing.Size(451, 171)
        Me.RG1.TabIndex = 0
        '
        'RG2
        '
        Me.RG2.BackColor = System.Drawing.SystemColors.Control
        Me.RG2.Cursor = System.Windows.Forms.Cursors.Default
        Me.RG2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RG2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RG2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RG2.Location = New System.Drawing.Point(88, 260)
        '
        '
        '
        Me.RG2.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "STUDENT_ID"
        GridViewTextBoxColumn3.HeaderText = "STUDENT_ID"
        GridViewTextBoxColumn3.Name = "STUDENT_ID"
        GridViewTextBoxColumn3.Width = 124
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "STUDENT_NAME"
        GridViewTextBoxColumn4.HeaderText = "STUDENT_NAME"
        GridViewTextBoxColumn4.Name = "STUDENT_NAME"
        GridViewTextBoxColumn4.Width = 89
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "DEPARTMENT"
        GridViewTextBoxColumn5.HeaderText = "DEPARTMENT"
        GridViewTextBoxColumn5.Name = "DEPARTMENT"
        GridViewTextBoxColumn5.Width = 174
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "ADDRESS"
        GridViewTextBoxColumn6.HeaderText = "ADDRESS"
        GridViewTextBoxColumn6.Name = "ADDRESS"
        GridViewTextBoxColumn6.Width = 95
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "MOBILENO"
        GridViewTextBoxColumn7.HeaderText = "MOBILENO"
        GridViewTextBoxColumn7.Name = "MOBILENO"
        GridViewTextBoxColumn7.Width = 141
        Me.RG2.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7})
        Me.RG2.MasterTemplate.EnableFiltering = True
        Me.RG2.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RG2.Name = "RG2"
        Me.RG2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RG2.Size = New System.Drawing.Size(640, 197)
        Me.RG2.TabIndex = 1
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(707, 218)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 2
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnconfrm
        '
        Me.btnconfrm.Location = New System.Drawing.Point(754, 405)
        Me.btnconfrm.Name = "btnconfrm"
        Me.btnconfrm.Size = New System.Drawing.Size(75, 23)
        Me.btnconfrm.TabIndex = 3
        Me.btnconfrm.Text = "CONFIRM"
        Me.btnconfrm.UseVisualStyleBackColor = True
        '
        'BtnReport
        '
        Me.BtnReport.Location = New System.Drawing.Point(754, 452)
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(75, 23)
        Me.BtnReport.TabIndex = 4
        Me.BtnReport.Text = "REPORT"
        Me.BtnReport.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 499)
        Me.Controls.Add(Me.BtnReport)
        Me.Controls.Add(Me.btnconfrm)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.RG2)
        Me.Controls.Add(Me.RG1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RG1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RG2.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RG2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RG1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RG2 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnsave As Button
    Friend WithEvents btnconfrm As Button
    Friend WithEvents BtnReport As Button
End Class
