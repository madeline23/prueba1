<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmr_prueba
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
        Me.mensaje01 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lblmensaje2 = New System.Windows.Forms.Label()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mensaje01
        '
        Me.mensaje01.BackColor = System.Drawing.Color.Transparent
        Me.mensaje01.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje01.ForeColor = System.Drawing.Color.Blue
        Me.mensaje01.Location = New System.Drawing.Point(85, 9)
        Me.mensaje01.Name = "mensaje01"
        Me.mensaje01.Size = New System.Drawing.Size(126, 41)
        Me.mensaje01.TabIndex = 1
        Me.mensaje01.Text = "U.E C.S.B"
        Me.mensaje01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_nombre.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(12, 70)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_apellido
        '
        Me.txt_apellido.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_apellido.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellido.Location = New System.Drawing.Point(183, 70)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(100, 20)
        Me.txt_apellido.TabIndex = 3
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(37, 50)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(52, 13)
        Me.lbl_nombre.TabIndex = 4
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellido.Location = New System.Drawing.Point(203, 50)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(55, 13)
        Me.lbl_apellido.TabIndex = 5
        Me.lbl_apellido.Text = "Apellido:"
        '
        'lblmensaje2
        '
        Me.lblmensaje2.AutoSize = True
        Me.lblmensaje2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensaje2.Location = New System.Drawing.Point(102, 118)
        Me.lblmensaje2.Name = "lblmensaje2"
        Me.lblmensaje2.Size = New System.Drawing.Size(103, 13)
        Me.lblmensaje2.TabIndex = 6
        Me.lblmensaje2.Text = "Genera tu nombre"
        Me.lblmensaje2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(105, 134)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(100, 23)
        Me.btngenerar.TabIndex = 7
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'fmr_prueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 185)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.lblmensaje2)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.mensaje01)
        Me.Name = "fmr_prueba"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mensaje01 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents lblmensaje2 As Label
    Friend WithEvents btngenerar As Button
End Class
