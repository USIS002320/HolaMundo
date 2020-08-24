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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbxsalidad = New System.Windows.Forms.ComboBox()
        Me.cbxentrada = New System.Windows.Forms.ComboBox()
        Me.lblr = New System.Windows.Forms.TextBox()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(298, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "CONVERTIDOR DE TIEMPO"
        '
        'cmdnuevo
        '
        Me.cmdnuevo.BackColor = System.Drawing.Color.SlateBlue
        Me.cmdnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnuevo.Location = New System.Drawing.Point(38, 273)
        Me.cmdnuevo.Name = "cmdnuevo"
        Me.cmdnuevo.Size = New System.Drawing.Size(125, 124)
        Me.cmdnuevo.TabIndex = 20
        Me.cmdnuevo.Text = "Borrador"
        Me.cmdnuevo.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Pink
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(179, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 124)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Terminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CadetBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(38, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(255, 53)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Convertir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbxsalidad
        '
        Me.cbxsalidad.BackColor = System.Drawing.Color.IndianRed
        Me.cbxsalidad.FormattingEnabled = True
        Me.cbxsalidad.Items.AddRange(New Object() {"Milisegundo", "Segundo", "Minuto", "Hora", "Dia", "Semana", "Mes", "Año", "Decada", "Siglo"})
        Me.cbxsalidad.Location = New System.Drawing.Point(620, 246)
        Me.cbxsalidad.Name = "cbxsalidad"
        Me.cbxsalidad.Size = New System.Drawing.Size(121, 21)
        Me.cbxsalidad.TabIndex = 17
        '
        'cbxentrada
        '
        Me.cbxentrada.BackColor = System.Drawing.Color.SandyBrown
        Me.cbxentrada.FormattingEnabled = True
        Me.cbxentrada.Items.AddRange(New Object() {"Milisegundo", "Segundo", "Minuto", "Hora", "Dia", "Semana", "Mes", "Año", "Decada", "Siglo"})
        Me.cbxentrada.Location = New System.Drawing.Point(620, 181)
        Me.cbxentrada.Name = "cbxentrada"
        Me.cbxentrada.Size = New System.Drawing.Size(121, 21)
        Me.cbxentrada.TabIndex = 16
        '
        'lblr
        '
        Me.lblr.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblr.Location = New System.Drawing.Point(407, 366)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(122, 20)
        Me.lblr.TabIndex = 15
        '
        'txtvalor
        '
        Me.txtvalor.BackColor = System.Drawing.Color.DarkGray
        Me.txtvalor.Location = New System.Drawing.Point(351, 116)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(426, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Resultado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(348, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ingrese valor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(592, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(585, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "De:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdnuevo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbxsalidad)
        Me.Controls.Add(Me.cbxentrada)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents cmdnuevo As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cbxsalidad As ComboBox
    Friend WithEvents cbxentrada As ComboBox
    Friend WithEvents lblr As TextBox
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
