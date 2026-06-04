<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productdetails_a202713
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
        Me.lst_productid = New System.Windows.Forms.ListBox()
        Me.txt_name = New System.Windows.Forms.MaskedTextBox()
        Me.picproduct = New System.Windows.Forms.PictureBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_category = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_condition = New System.Windows.Forms.TextBox()
        Me.txt_manufacturer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.back_button = New System.Windows.Forms.Button()
        CType(Me.picproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(326, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(304, 51)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Product Details"
        '
        'lst_productid
        '
        Me.lst_productid.FormattingEnabled = True
        Me.lst_productid.ItemHeight = 16
        Me.lst_productid.Location = New System.Drawing.Point(36, 83)
        Me.lst_productid.Name = "lst_productid"
        Me.lst_productid.Size = New System.Drawing.Size(207, 356)
        Me.lst_productid.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(576, 144)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(375, 22)
        Me.txt_name.TabIndex = 2
        '
        'picproduct
        '
        Me.picproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picproduct.Location = New System.Drawing.Point(249, 144)
        Me.picproduct.Name = "picproduct"
        Me.picproduct.Size = New System.Drawing.Size(180, 214)
        Me.picproduct.TabIndex = 3
        Me.picproduct.TabStop = False
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(576, 178)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(104, 22)
        Me.txt_price.TabIndex = 4
        '
        'txt_category
        '
        Me.txt_category.Location = New System.Drawing.Point(576, 214)
        Me.txt_category.Name = "txt_category"
        Me.txt_category.Size = New System.Drawing.Size(155, 22)
        Me.txt_category.TabIndex = 5
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(576, 277)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(155, 22)
        Me.txt_brand.TabIndex = 6
        '
        'txt_condition
        '
        Me.txt_condition.Location = New System.Drawing.Point(576, 247)
        Me.txt_condition.Name = "txt_condition"
        Me.txt_condition.Size = New System.Drawing.Size(100, 22)
        Me.txt_condition.TabIndex = 7
        '
        'txt_manufacturer
        '
        Me.txt_manufacturer.Location = New System.Drawing.Point(576, 318)
        Me.txt_manufacturer.Name = "txt_manufacturer"
        Me.txt_manufacturer.Size = New System.Drawing.Size(260, 22)
        Me.txt_manufacturer.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(437, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(437, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "PRICE (RM):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(435, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "CATEGORY:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(435, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "BRAND:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(435, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "CONDITION:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(435, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "MANUFACTURER:"
        '
        'back_button
        '
        Me.back_button.Location = New System.Drawing.Point(13, 9)
        Me.back_button.Name = "back_button"
        Me.back_button.Size = New System.Drawing.Size(92, 31)
        Me.back_button.TabIndex = 15
        Me.back_button.Text = "BACK"
        Me.back_button.UseVisualStyleBackColor = True
        '
        'frm_productdetails_a202713
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_hero_svaultshop_a202713.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(963, 466)
        Me.Controls.Add(Me.back_button)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_manufacturer)
        Me.Controls.Add(Me.txt_condition)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_category)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.picproduct)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lst_productid)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_productdetails_a202713"
        Me.Text = "frm_productdetails_a202713"
        CType(Me.picproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lst_productid As ListBox
    Friend WithEvents txt_name As MaskedTextBox
    Friend WithEvents picproduct As PictureBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_category As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_condition As TextBox
    Friend WithEvents txt_manufacturer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents back_button As Button
End Class
