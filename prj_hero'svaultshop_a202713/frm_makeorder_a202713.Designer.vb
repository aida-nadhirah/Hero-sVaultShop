<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeorder_a202713
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.tb_qty = New System.Windows.Forms.TextBox()
        Me.cb_cust = New System.Windows.Forms.ComboBox()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.lbl_prod = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_cust = New System.Windows.Forms.Label()
        Me.lbl_qty = New System.Windows.Forms.Label()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.tb_order = New System.Windows.Forms.TextBox()
        Me.DateInput = New System.Windows.Forms.DateTimePicker()
        Me.cb_staff = New System.Windows.Forms.ComboBox()
        Me.cb_prod = New System.Windows.Forms.ComboBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.grd_orderdetails = New System.Windows.Forms.DataGridView()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(359, 22)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(220, 46)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Place Order"
        '
        'tb_qty
        '
        Me.tb_qty.Location = New System.Drawing.Point(656, 198)
        Me.tb_qty.Name = "tb_qty"
        Me.tb_qty.Size = New System.Drawing.Size(100, 22)
        Me.tb_qty.TabIndex = 3
        '
        'cb_cust
        '
        Me.cb_cust.FormattingEnabled = True
        Me.cb_cust.Location = New System.Drawing.Point(656, 106)
        Me.cb_cust.Name = "cb_cust"
        Me.cb_cust.Size = New System.Drawing.Size(121, 24)
        Me.cb_cust.TabIndex = 4
        '
        'lbl_orderid
        '
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.ForeColor = System.Drawing.Color.White
        Me.lbl_orderid.Location = New System.Drawing.Point(77, 110)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(80, 20)
        Me.lbl_orderid.TabIndex = 5
        Me.lbl_orderid.Text = "Order ID:"
        '
        'lbl_prod
        '
        Me.lbl_prod.AutoSize = True
        Me.lbl_prod.BackColor = System.Drawing.Color.Transparent
        Me.lbl_prod.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prod.ForeColor = System.Drawing.Color.White
        Me.lbl_prod.Location = New System.Drawing.Point(12, 202)
        Me.lbl_prod.Name = "lbl_prod"
        Me.lbl_prod.Size = New System.Drawing.Size(117, 20)
        Me.lbl_prod.TabIndex = 6
        Me.lbl_prod.Text = "Product Name:"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.Location = New System.Drawing.Point(76, 159)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(49, 20)
        Me.lbl_date.TabIndex = 7
        Me.lbl_date.Text = "Date:"
        '
        'lbl_cust
        '
        Me.lbl_cust.AutoSize = True
        Me.lbl_cust.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cust.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cust.ForeColor = System.Drawing.Color.White
        Me.lbl_cust.Location = New System.Drawing.Point(548, 109)
        Me.lbl_cust.Name = "lbl_cust"
        Me.lbl_cust.Size = New System.Drawing.Size(107, 20)
        Me.lbl_cust.TabIndex = 8
        Me.lbl_cust.Text = "Customer No:"
        '
        'lbl_qty
        '
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_qty.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qty.ForeColor = System.Drawing.Color.White
        Me.lbl_qty.Location = New System.Drawing.Point(548, 200)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(76, 20)
        Me.lbl_qty.TabIndex = 9
        Me.lbl_qty.Text = "Quantity:"
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.ForeColor = System.Drawing.Color.White
        Me.lbl_staff.Location = New System.Drawing.Point(548, 153)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(72, 20)
        Me.lbl_staff.TabIndex = 10
        Me.lbl_staff.Text = "Staff ID:"
        '
        'tb_order
        '
        Me.tb_order.Location = New System.Drawing.Point(174, 110)
        Me.tb_order.Name = "tb_order"
        Me.tb_order.Size = New System.Drawing.Size(100, 22)
        Me.tb_order.TabIndex = 11
        '
        'DateInput
        '
        Me.DateInput.Location = New System.Drawing.Point(174, 156)
        Me.DateInput.Name = "DateInput"
        Me.DateInput.Size = New System.Drawing.Size(243, 22)
        Me.DateInput.TabIndex = 13
        '
        'cb_staff
        '
        Me.cb_staff.FormattingEnabled = True
        Me.cb_staff.Location = New System.Drawing.Point(656, 149)
        Me.cb_staff.Name = "cb_staff"
        Me.cb_staff.Size = New System.Drawing.Size(121, 24)
        Me.cb_staff.TabIndex = 14
        '
        'cb_prod
        '
        Me.cb_prod.FormattingEnabled = True
        Me.cb_prod.Location = New System.Drawing.Point(174, 198)
        Me.cb_prod.Name = "cb_prod"
        Me.cb_prod.Size = New System.Drawing.Size(364, 24)
        Me.cb_prod.TabIndex = 15
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(724, 257)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 26)
        Me.btn_save.TabIndex = 18
        Me.btn_save.Text = "Add"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(12, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(93, 33)
        Me.btn_back.TabIndex = 20
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_order
        '
        Me.btn_order.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.Location = New System.Drawing.Point(787, 491)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(131, 45)
        Me.btn_order.TabIndex = 21
        Me.btn_order.Text = "Place Order"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'grd_orderdetails
        '
        Me.grd_orderdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_orderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderdetails.Location = New System.Drawing.Point(80, 295)
        Me.grd_orderdetails.Name = "grd_orderdetails"
        Me.grd_orderdetails.RowHeadersWidth = 51
        Me.grd_orderdetails.RowTemplate.Height = 24
        Me.grd_orderdetails.Size = New System.Drawing.Size(838, 190)
        Me.grd_orderdetails.TabIndex = 22
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(824, 257)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(94, 26)
        Me.btn_delete.TabIndex = 19
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(787, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 149)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'frm_makeorder_a202713
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_hero_svaultshop_a202713.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(1006, 579)
        Me.Controls.Add(Me.grd_orderdetails)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cb_prod)
        Me.Controls.Add(Me.cb_staff)
        Me.Controls.Add(Me.DateInput)
        Me.Controls.Add(Me.tb_order)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.lbl_qty)
        Me.Controls.Add(Me.lbl_cust)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_prod)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.cb_cust)
        Me.Controls.Add(Me.tb_qty)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_makeorder_a202713"
        Me.Text = "frm_makeorder_a202713"
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As Label
    Friend WithEvents tb_qty As TextBox
    Friend WithEvents cb_cust As ComboBox
    Friend WithEvents lbl_orderid As Label
    Friend WithEvents lbl_prod As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_cust As Label
    Friend WithEvents lbl_qty As Label
    Friend WithEvents lbl_staff As Label
    Friend WithEvents tb_order As TextBox
    Friend WithEvents DateInput As DateTimePicker
    Friend WithEvents cb_staff As ComboBox
    Friend WithEvents cb_prod As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents grd_orderdetails As DataGridView
End Class
