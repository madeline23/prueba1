<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_prueba2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_n1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_num1 = New System.Windows.Forms.TextBox()
        Me.txt_n2 = New System.Windows.Forms.Label()
        Me.txt_num2 = New System.Windows.Forms.TextBox()
        Me.txt_Total = New System.Windows.Forms.Label()
        Me.btn_Total = New System.Windows.Forms.Button()
        Me.bln_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_n1
        '
        Me.txt_n1.AutoSize = True
        Me.txt_n1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_n1.Location = New System.Drawing.Point(28, 64)
        Me.txt_n1.Name = "txt_n1"
        Me.txt_n1.Size = New System.Drawing.Size(139, 15)
        Me.txt_n1.TabIndex = 0
        Me.txt_n1.Text = "Ingrese Primer Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Aqua
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(141, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Suma"
        '
        'txt_num1
        '
        Me.txt_num1.Location = New System.Drawing.Point(42, 89)
        Me.txt_num1.Name = "txt_num1"
        Me.txt_num1.Size = New System.Drawing.Size(112, 20)
        Me.txt_num1.TabIndex = 2
        '
        'txt_n2
        '
        Me.txt_n2.AutoSize = True
        Me.txt_n2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_n2.Location = New System.Drawing.Point(212, 64)
        Me.txt_n2.Name = "txt_n2"
        Me.txt_n2.Size = New System.Drawing.Size(146, 15)
        Me.txt_n2.TabIndex = 3
        Me.txt_n2.Text = "Ingrese Segundo Numero"
        '
        'txt_num2
        '
        Me.txt_num2.Location = New System.Drawing.Point(232, 89)
        Me.txt_num2.Name = "txt_num2"
        Me.txt_num2.Size = New System.Drawing.Size(108, 20)
        Me.txt_num2.TabIndex = 4
        '
        'txt_Total
        '
        Me.txt_Total.AutoSize = True
        Me.txt_Total.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(160, 147)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(62, 22)
        Me.txt_Total.TabIndex = 5
        Me.txt_Total.Text = "Total: "
        '
        'btn_Total
        '
        Me.btn_Total.Location = New System.Drawing.Point(47, 136)
        Me.btn_Total.Name = "btn_Total"
        Me.btn_Total.Size = New System.Drawing.Size(99, 33)
        Me.btn_Total.TabIndex = 6
        Me.btn_Total.Text = "Resultado"
        Me.btn_Total.UseVisualStyleBackColor = True
        '
        'bln_salir
        '
        Me.bln_salir.Location = New System.Drawing.Point(47, 183)
        Me.bln_salir.Name = "bln_salir"
        Me.bln_salir.Size = New System.Drawing.Size(99, 31)
        Me.bln_salir.TabIndex = 7
        Me.bln_salir.Text = "Salir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bln_salir.UseVisualStyleBackColor = True
        '
        'frm_prueba2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(367, 290)
        Me.Controls.Add(Me.bln_salir)
        Me.Controls.Add(Me.btn_Total)
        Me.Controls.Add(Me.txt_Total)
        Me.Controls.Add(Me.txt_num2)
        Me.Controls.Add(Me.txt_n2)
        Me.Controls.Add(Me.txt_num1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_n1)
        Me.Name = "frm_prueba2"
        Me.Text = "frm_prueba2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_n1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_num1 As TextBox
    Friend WithEvents txt_n2 As Label
    Friend WithEvents txt_num2 As TextBox
    Friend WithEvents txt_Total As Label
    Friend WithEvents btn_Total As Button
    Friend WithEvents bln_salir As Button
End Class
