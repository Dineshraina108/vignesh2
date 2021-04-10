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
        Dim CartesianArea1 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtgst = New System.Windows.Forms.TextBox()
        Me.btnview = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.btnext = New System.Windows.Forms.Button()
        Me.Cbobox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TOTAL = New System.Windows.Forms.Label()
        Me.txttot = New System.Windows.Forms.TextBox()
        Me.RadChartView1 = New Telerik.WinControls.UI.RadChartView()
        Me.txtGstP_Amount = New System.Windows.Forms.TextBox()
        Me.GV1 = New Telerik.WinControls.UI.RadGridView()
        Me.Cboid = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BTNMDY = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        CType(Me.RadChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(69, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRODUCT ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(69, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PRODUCT NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(69, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "QTY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(69, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PRICE"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(196, 88)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 4
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(196, 137)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(121, 20)
        Me.txtname.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(69, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "GST(%)"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(196, 221)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(121, 20)
        Me.txtprice.TabIndex = 7
        '
        'txtgst
        '
        Me.txtgst.Location = New System.Drawing.Point(196, 267)
        Me.txtgst.Name = "txtgst"
        Me.txtgst.Size = New System.Drawing.Size(49, 20)
        Me.txtgst.TabIndex = 8
        '
        'btnview
        '
        Me.btnview.Location = New System.Drawing.Point(699, 327)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(75, 23)
        Me.btnview.TabIndex = 9
        Me.btnview.Text = "VIEW"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(186, 381)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnclr
        '
        Me.btnclr.Location = New System.Drawing.Point(493, 381)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(75, 23)
        Me.btnclr.TabIndex = 11
        Me.btnclr.Text = "CLEAR"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'btnext
        '
        Me.btnext.Location = New System.Drawing.Point(593, 381)
        Me.btnext.Name = "btnext"
        Me.btnext.Size = New System.Drawing.Size(75, 23)
        Me.btnext.TabIndex = 12
        Me.btnext.Text = "EXIT"
        Me.btnext.UseVisualStyleBackColor = True
        '
        'Cbobox
        '
        Me.Cbobox.FormattingEnabled = True
        Me.Cbobox.Location = New System.Drawing.Point(196, 179)
        Me.Cbobox.Name = "Cbobox"
        Me.Cbobox.Size = New System.Drawing.Size(121, 21)
        Me.Cbobox.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(275, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(266, 29)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "STORE ITEM DETAILS"
        '
        'TOTAL
        '
        Me.TOTAL.AutoSize = True
        Me.TOTAL.Location = New System.Drawing.Point(70, 308)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(42, 13)
        Me.TOTAL.TabIndex = 16
        Me.TOTAL.Text = "TOTAL"
        '
        'txttot
        '
        Me.txttot.Location = New System.Drawing.Point(196, 308)
        Me.txttot.Name = "txttot"
        Me.txttot.Size = New System.Drawing.Size(121, 20)
        Me.txttot.TabIndex = 17
        '
        'RadChartView1
        '
        Me.RadChartView1.AreaDesign = CartesianArea1
        Me.RadChartView1.Location = New System.Drawing.Point(90, 20)
        Me.RadChartView1.Name = "RadChartView1"
        Me.RadChartView1.ShowGrid = False
        Me.RadChartView1.Size = New System.Drawing.Size(8, 34)
        Me.RadChartView1.TabIndex = 1
        '
        'txtGstP_Amount
        '
        Me.txtGstP_Amount.Location = New System.Drawing.Point(251, 267)
        Me.txtGstP_Amount.Name = "txtGstP_Amount"
        Me.txtGstP_Amount.Size = New System.Drawing.Size(66, 20)
        Me.txtGstP_Amount.TabIndex = 19
        '
        'GV1
        '
        Me.GV1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GV1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GV1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GV1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GV1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GV1.Location = New System.Drawing.Point(371, 87)
        '
        '
        '
        Me.GV1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "PRODUCTID"
        GridViewTextBoxColumn1.HeaderText = "PRODUCTID"
        GridViewTextBoxColumn1.Name = "PRODUCTID"
        GridViewTextBoxColumn1.Width = 74
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "PRODUCTNAME"
        GridViewTextBoxColumn2.HeaderText = "PRODUCTNAME"
        GridViewTextBoxColumn2.Name = "PRODUCTNAME"
        GridViewTextBoxColumn2.Width = 127
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "QTY"
        GridViewTextBoxColumn3.HeaderText = "QTY"
        GridViewTextBoxColumn3.Name = "QTY"
        GridViewTextBoxColumn3.Width = 80
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "PRICE"
        GridViewTextBoxColumn4.HeaderText = "PRICE"
        GridViewTextBoxColumn4.Name = "PRICE"
        GridViewTextBoxColumn4.Width = 65
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "GST"
        GridViewTextBoxColumn5.HeaderText = "GST"
        GridViewTextBoxColumn5.Name = "GST"
        GridViewTextBoxColumn5.Width = 40
        Me.GV1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5})
        Me.GV1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GV1.Name = "GV1"
        Me.GV1.ReadOnly = True
        Me.GV1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GV1.Size = New System.Drawing.Size(403, 234)
        Me.GV1.TabIndex = 20
        '
        'Cboid
        '
        Me.Cboid.FormattingEnabled = True
        Me.Cboid.Location = New System.Drawing.Point(196, 87)
        Me.Cboid.Name = "Cboid"
        Me.Cboid.Size = New System.Drawing.Size(121, 21)
        Me.Cboid.TabIndex = 21
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(73, 381)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "NEW"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BTNMDY
        '
        Me.BTNMDY.Location = New System.Drawing.Point(294, 381)
        Me.BTNMDY.Name = "BTNMDY"
        Me.BTNMDY.Size = New System.Drawing.Size(75, 23)
        Me.BTNMDY.TabIndex = 23
        Me.BTNMDY.Text = "MODIFY"
        Me.BTNMDY.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(394, 381)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(75, 23)
        Me.delete.TabIndex = 24
        Me.delete.Text = "DELETE"
        Me.delete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(849, 451)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.BTNMDY)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Cboid)
        Me.Controls.Add(Me.GV1)
        Me.Controls.Add(Me.txtGstP_Amount)
        Me.Controls.Add(Me.txttot)
        Me.Controls.Add(Me.TOTAL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cbobox)
        Me.Controls.Add(Me.btnext)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.txtgst)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "STORE ITEMS"
        CType(Me.RadChartView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents txtgst As TextBox
    Friend WithEvents btnview As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnclr As Button
    Friend WithEvents btnext As Button
    Friend WithEvents Cbobox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TOTAL As Label
    Friend WithEvents txttot As TextBox
    Friend WithEvents RadChartView1 As Telerik.WinControls.UI.RadChartView
    Friend WithEvents txtGstP_Amount As TextBox
    Friend WithEvents GV1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Cboid As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents BTNMDY As Button
    Friend WithEvents delete As Button
End Class
