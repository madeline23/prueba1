<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_nproducto = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.lbl_factura = New System.Windows.Forms.Label()
        Me.lbl_npr = New System.Windows.Forms.Label()
        Me.lbl_cod = New System.Windows.Forms.Label()
        Me.lbl_catid = New System.Windows.Forms.Label()
        Me.lbl_prec = New System.Windows.Forms.Label()
        Me.btn_tot = New System.Windows.Forms.Button()
        Me.lbl_st = New System.Windows.Forms.Label()
        Me.lbl_iva = New System.Windows.Forms.Label()
        Me.lbl_tot = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_nproducto
        '
        Me.txt_nproducto.Location = New System.Drawing.Point(12, 77)
        Me.txt_nproducto.Name = "txt_nproducto"
        Me.txt_nproducto.Size = New System.Drawing.Size(230, 20)
        Me.txt_nproducto.TabIndex = 0
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(12, 120)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 1
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(12, 214)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 2
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(12, 169)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 20)
        Me.txt_precio.TabIndex = 3
        '
        'lbl_factura
        '
        Me.lbl_factura.AutoSize = True
        Me.lbl_factura.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_factura.Location = New System.Drawing.Point(95, 9)
        Me.lbl_factura.Name = "lbl_factura"
        Me.lbl_factura.Size = New System.Drawing.Size(198, 42)
        Me.lbl_factura.TabIndex = 4
        Me.lbl_factura.Text = "FACTURA"
        '
        'lbl_npr
        '
        Me.lbl_npr.AutoSize = True
        Me.lbl_npr.Location = New System.Drawing.Point(9, 61)
        Me.lbl_npr.Name = "lbl_npr"
        Me.lbl_npr.Size = New System.Drawing.Size(142, 13)
        Me.lbl_npr.TabIndex = 5
        Me.lbl_npr.Text = "NOMBRE DEL PRODUCTO"
        '
        'lbl_cod
        '
        Me.lbl_cod.AutoSize = True
        Me.lbl_cod.Location = New System.Drawing.Point(12, 104)
        Me.lbl_cod.Name = "lbl_cod"
        Me.lbl_cod.Size = New System.Drawing.Size(52, 13)
        Me.lbl_cod.TabIndex = 6
        Me.lbl_cod.Text = "CODIGO "
        '
        'lbl_catid
        '
        Me.lbl_catid.AutoSize = True
        Me.lbl_catid.Location = New System.Drawing.Point(9, 198)
        Me.lbl_catid.Name = "lbl_catid"
        Me.lbl_catid.Size = New System.Drawing.Size(65, 13)
        Me.lbl_catid.TabIndex = 7
        Me.lbl_catid.Text = "CANTIDAD "
        '
        'lbl_prec
        '
        Me.lbl_prec.AutoSize = True
        Me.lbl_prec.Location = New System.Drawing.Point(12, 153)
        Me.lbl_prec.Name = "lbl_prec"
        Me.lbl_prec.Size = New System.Drawing.Size(47, 13)
        Me.lbl_prec.TabIndex = 8
        Me.lbl_prec.Text = "PRECIO"
        '
        'btn_tot
        '
        Me.btn_tot.Location = New System.Drawing.Point(236, 263)
        Me.btn_tot.Name = "btn_tot"
        Me.btn_tot.Size = New System.Drawing.Size(87, 45)
        Me.btn_tot.TabIndex = 9
        Me.btn_tot.Text = "TOTAL"
        Me.btn_tot.UseVisualStyleBackColor = True
        '
        'lbl_st
        '
        Me.lbl_st.AutoSize = True
        Me.lbl_st.Location = New System.Drawing.Point(12, 256)
        Me.lbl_st.Name = "lbl_st"
        Me.lbl_st.Size = New System.Drawing.Size(70, 13)
        Me.lbl_st.TabIndex = 10
        Me.lbl_st.Text = "SUBTOTAL: "
        '
        'lbl_iva
        '
        Me.lbl_iva.AutoSize = True
        Me.lbl_iva.Location = New System.Drawing.Point(12, 283)
        Me.lbl_iva.Name = "lbl_iva"
        Me.lbl_iva.Size = New System.Drawing.Size(30, 13)
        Me.lbl_iva.TabIndex = 11
        Me.lbl_iva.Text = "IVA: "
        '
        'lbl_tot
        '
        Me.lbl_tot.AutoSize = True
        Me.lbl_tot.Location = New System.Drawing.Point(9, 310)
        Me.lbl_tot.Name = "lbl_tot"
        Me.lbl_tot.Size = New System.Drawing.Size(48, 13)
        Me.lbl_tot.TabIndex = 12
        Me.lbl_tot.Text = "TOTAL: "
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Location = New System.Drawing.Point(102, 249)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(100, 20)
        Me.txt_subtotal.TabIndex = 13
        '
        'txt_iva
        '
        Me.txt_iva.Enabled = False
        Me.txt_iva.Location = New System.Drawing.Point(102, 276)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(100, 20)
        Me.txt_iva.TabIndex = 14
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Location = New System.Drawing.Point(102, 303)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_total.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 357)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.txt_subtotal)
        Me.Controls.Add(Me.lbl_tot)
        Me.Controls.Add(Me.lbl_iva)
        Me.Controls.Add(Me.lbl_st)
        Me.Controls.Add(Me.btn_tot)
        Me.Controls.Add(Me.lbl_prec)
        Me.Controls.Add(Me.lbl_catid)
        Me.Controls.Add(Me.lbl_cod)
        Me.Controls.Add(Me.lbl_npr)
        Me.Controls.Add(Me.lbl_factura)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.txt_nproducto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nproducto As TextBox
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents lbl_factura As Label
    Friend WithEvents lbl_npr As Label
    Friend WithEvents lbl_cod As Label
    Friend WithEvents lbl_catid As Label
    Friend WithEvents lbl_prec As Label
    Friend WithEvents btn_tot As Button
    Friend WithEvents lbl_st As Label
    Friend WithEvents lbl_iva As Label
    Friend WithEvents lbl_tot As Label
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents txt_iva As TextBox
    Friend WithEvents txt_total As TextBox
End Class
