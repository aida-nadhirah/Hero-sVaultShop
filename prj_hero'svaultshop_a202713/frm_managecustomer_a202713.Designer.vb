<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_managecustomer_a202713
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
        Me.grd_cust = New System.Windows.Forms.DataGridView()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_no = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        CType(Me.grd_cust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.White
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(347, 25)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(526, 45)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Customer Management Form"
        '
        'grd_cust
        '
        Me.grd_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_cust.Location = New System.Drawing.Point(136, 104)
        Me.grd_cust.Name = "grd_cust"
        Me.grd_cust.RowHeadersWidth = 51
        Me.grd_cust.RowTemplate.Height = 24
        Me.grd_cust.Size = New System.Drawing.Size(864, 210)
        Me.grd_cust.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(540, 375)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(174, 22)
        Me.txt_name.TabIndex = 2
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(851, 376)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(127, 22)
        Me.txt_no.TabIndex = 3
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(270, 375)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 22)
        Me.txt_id.TabIndex = 4
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.White
        Me.lbl_id.Location = New System.Drawing.Point(150, 379)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(114, 19)
        Me.lbl_id.TabIndex = 5
        Me.lbl_id.Text = "Customer ID :"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(385, 379)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(138, 19)
        Me.lbl_name.TabIndex = 6
        Me.lbl_name.Text = "Customer Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(755, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Phone No :"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.White
        Me.btn_insert.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(355, 492)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(101, 33)
        Me.btn_insert.TabIndex = 8
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.White
        Me.btn_update.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(550, 492)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(101, 33)
        Me.btn_update.TabIndex = 9
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.White
        Me.btn_del.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Location = New System.Drawing.Point(734, 492)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(101, 33)
        Me.btn_del.TabIndex = 10
        Me.btn_del.Text = "DELETE"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(12, 12)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(84, 29)
        Me.back_btn.TabIndex = 11
        Me.back_btn.Text = "BACK"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'frm_managecustomer_a202713
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_hero_svaultshop_a202713.My.Resources.Resources.bg5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1157, 579)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_no)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.grd_cust)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_managecustomer_a202713"
        Me.Text = "frm_insertcustomer_a202713"
        CType(Me.grd_cust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_cust As DataGridView
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_no As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents back_btn As Button
End Class
