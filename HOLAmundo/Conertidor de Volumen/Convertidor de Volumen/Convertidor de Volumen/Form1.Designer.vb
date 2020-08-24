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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdnuevo = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblr = New System.Windows.Forms.TextBox()
        Me.cbxsalidad = New System.Windows.Forms.ComboBox()
        Me.cbxentrada = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(310, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "CONVERTIDOR DE VOLUMEN"
        '
        'cmdnuevo
        '
        Me.cmdnuevo.BackColor = System.Drawing.Color.Cyan
        Me.cmdnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnuevo.Location = New System.Drawing.Point(21, 226)
        Me.cmdnuevo.Name = "cmdnuevo"
        Me.cmdnuevo.Size = New System.Drawing.Size(127, 35)
        Me.cmdnuevo.TabIndex = 23
        Me.cmdnuevo.Text = "Borrador"
        Me.cmdnuevo.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SeaGreen
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(149, 226)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 35)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Terminar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'lblr
        '
        Me.lblr.BackColor = System.Drawing.Color.Salmon
        Me.lblr.Location = New System.Drawing.Point(409, 326)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(100, 20)
        Me.lblr.TabIndex = 21
        '
        'cbxsalidad
        '
        Me.cbxsalidad.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cbxsalidad.FormattingEnabled = True
        Me.cbxsalidad.Items.AddRange(New Object() {"Metro cubico", "Litro", "Mililitro", "Galon imperial", "Cuarto imperial", "Pinta imperial", "Taza imperial", "Onza liquida imperial", "Cucharada imperial", "Pie cubico"})
        Me.cbxsalidad.Location = New System.Drawing.Point(613, 236)
        Me.cbxsalidad.Name = "cbxsalidad"
        Me.cbxsalidad.Size = New System.Drawing.Size(121, 21)
        Me.cbxsalidad.TabIndex = 20
        '
        'cbxentrada
        '
        Me.cbxentrada.BackColor = System.Drawing.Color.Fuchsia
        Me.cbxentrada.FormattingEnabled = True
        Me.cbxentrada.Items.AddRange(New Object() {"Metro cubico", "Litro", "Mililitro", "Galon imperial", "Cuarto imperial", "Pinta imperial", "Taza imperial", "Onza liquida imperial", "Cucharada imperial", "Pie cubico"})
        Me.cbxentrada.Location = New System.Drawing.Point(613, 152)
        Me.cbxentrada.Name = "cbxentrada"
        Me.cbxentrada.Size = New System.Drawing.Size(121, 21)
        Me.cbxentrada.TabIndex = 19
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtValor.Location = New System.Drawing.Point(98, 153)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(320, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Resultado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(585, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(576, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "De:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ingresar un valor"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumOrchid
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(21, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(256, 37)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Convertir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdnuevo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.cbxsalidad)
        Me.Controls.Add(Me.cbxentrada)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Convertidor "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents cmdnuevo As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblr As TextBox
    Friend WithEvents cbxsalidad As ComboBox
    Friend WithEvents cbxentrada As ComboBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
