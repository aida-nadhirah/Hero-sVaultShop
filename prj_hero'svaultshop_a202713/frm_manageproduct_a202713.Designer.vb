<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manageproduct_a202713
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_cat = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_cond = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_manu = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_cat = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_condition = New System.Windows.Forms.Label()
        Me.lbl_man = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_pict = New System.Windows.Forms.Label()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(526, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(381, 46)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Product Management"
        '
        'grd_product
        '
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(31, 58)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.RowHeadersWidth = 51
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(903, 477)
        Me.grd_product.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(1138, 282)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(216, 22)
        Me.txt_name.TabIndex = 2
        '
        'txt_cat
        '
        Me.txt_cat.Location = New System.Drawing.Point(1138, 341)
        Me.txt_cat.Name = "txt_cat"
        Me.txt_cat.Size = New System.Drawing.Size(216, 22)
        Me.txt_cat.TabIndex = 3
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(1138, 254)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(216, 22)
        Me.txt_id.TabIndex = 4
        '
        'txt_cond
        '
        Me.txt_cond.Location = New System.Drawing.Point(1138, 401)
        Me.txt_cond.Name = "txt_cond"
        Me.txt_cond.Size = New System.Drawing.Size(216, 22)
        Me.txt_cond.TabIndex = 5
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(1138, 312)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(216, 22)
        Me.txt_price.TabIndex = 6
        '
        'txt_manu
        '
        Me.txt_manu.Location = New System.Drawing.Point(1138, 429)
        Me.txt_manu.Name = "txt_manu"
        Me.txt_manu.Size = New System.Drawing.Size(216, 22)
        Me.txt_manu.TabIndex = 7
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(1138, 373)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(216, 22)
        Me.txt_brand.TabIndex = 8
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.White
        Me.btn_insert.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(991, 496)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(96, 39)
        Me.btn_insert.TabIndex = 9
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(963, 286)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(99, 17)
        Me.lbl_name.TabIndex = 10
        Me.lbl_name.Text = "Product Name:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(963, 254)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(80, 17)
        Me.lbl_id.TabIndex = 11
        Me.lbl_id.Text = "Product ID:"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(963, 317)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(99, 17)
        Me.lbl_price.TabIndex = 12
        Me.lbl_price.Text = "Product Price: "
        '
        'lbl_cat
        '
        Me.lbl_cat.AutoSize = True
        Me.lbl_cat.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cat.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cat.Location = New System.Drawing.Point(963, 345)
        Me.lbl_cat.Name = "lbl_cat"
        Me.lbl_cat.Size = New System.Drawing.Size(120, 17)
        Me.lbl_cat.TabIndex = 13
        Me.lbl_cat.Text = "Product Category:"
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(963, 373)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(101, 17)
        Me.lbl_brand.TabIndex = 14
        Me.lbl_brand.Text = "Product Brand:"
        '
        'lbl_condition
        '
        Me.lbl_condition.AutoSize = True
        Me.lbl_condition.BackColor = System.Drawing.Color.Transparent
        Me.lbl_condition.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_condition.Location = New System.Drawing.Point(963, 405)
        Me.lbl_condition.Name = "lbl_condition"
        Me.lbl_condition.Size = New System.Drawing.Size(124, 17)
        Me.lbl_condition.TabIndex = 15
        Me.lbl_condition.Text = "Product Condition:"
        '
        'lbl_man
        '
        Me.lbl_man.AutoSize = True
        Me.lbl_man.BackColor = System.Drawing.Color.Transparent
        Me.lbl_man.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_man.Location = New System.Drawing.Point(963, 433)
        Me.lbl_man.Name = "lbl_man"
        Me.lbl_man.Size = New System.Drawing.Size(149, 17)
        Me.lbl_man.TabIndex = 16
        Me.lbl_man.Text = "Product Manufacturer:"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(1159, 38)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(154, 171)
        Me.pic_product.TabIndex = 17
        Me.pic_product.TabStop = False
        '
        'lbl_pict
        '
        Me.lbl_pict.AutoSize = True
        Me.lbl_pict.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pict.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pict.Location = New System.Drawing.Point(963, 136)
        Me.lbl_pict.Name = "lbl_pict"
        Me.lbl_pict.Size = New System.Drawing.Size(108, 17)
        Me.lbl_pict.TabIndex = 18
        Me.lbl_pict.Text = "Product Picture:"
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(962, 156)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(191, 22)
        Me.txt_picture.TabIndex = 19
        '
        'btn_picture
        '
        Me.btn_picture.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_picture.Location = New System.Drawing.Point(1184, 215)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(105, 23)
        Me.btn_picture.TabIndex = 20
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.White
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(1240, 495)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(96, 40)
        Me.btn_delete.TabIndex = 21
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.White
        Me.btn_update.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(1118, 496)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(96, 39)
        Me.btn_update.TabIndex = 22
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'back_btn
        '
        Me.back_btn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.Location = New System.Drawing.Point(13, 13)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(84, 26)
        Me.back_btn.TabIndex = 23
        Me.back_btn.Text = "BACK"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'frm_manageproduct_a202713
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.prj_hero_svaultshop_a202713.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 579)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.lbl_pict)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lbl_man)
        Me.Controls.Add(Me.lbl_condition)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.lbl_cat)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_manu)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_cond)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_cat)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_title)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "frm_manageproduct_a202713"
        Me.Text = "frm_insertproduct_a202713"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_cat As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_cond As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_manu As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_cat As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_condition As Label
    Friend WithEvents lbl_man As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_pict As Label
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents back_btn As Button
End Class
