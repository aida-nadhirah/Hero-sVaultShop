<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cust_a202713
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_mng = New System.Windows.Forms.Button()
        CType(Me.grd_cust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(478, 28)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(183, 46)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Customer"
        '
        'grd_cust
        '
        Me.grd_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_cust.Location = New System.Drawing.Point(62, 89)
        Me.grd_cust.Name = "grd_cust"
        Me.grd_cust.RowHeadersWidth = 51
        Me.grd_cust.RowTemplate.Height = 24
        Me.grd_cust.Size = New System.Drawing.Size(795, 421)
        Me.grd_cust.TabIndex = 1
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(62, 13)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(89, 37)
        Me.btn_back.TabIndex = 2
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_mng
        '
        Me.btn_mng.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mng.Location = New System.Drawing.Point(905, 516)
        Me.btn_mng.Name = "btn_mng"
        Me.btn_mng.Size = New System.Drawing.Size(195, 51)
        Me.btn_mng.TabIndex = 3
        Me.btn_mng.Text = "Manage Customer"
        Me.btn_mng.UseVisualStyleBackColor = True
        '
        'frm_cust_a202713
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_hero_svaultshop_a202713.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1157, 579)
        Me.Controls.Add(Me.btn_mng)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_cust)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_cust_a202713"
        Me.Text = "frm_cust_a202713"
        CType(Me.grd_cust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_cust As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_mng As Button
End Class
