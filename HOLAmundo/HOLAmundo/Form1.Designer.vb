<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.txtnumero1 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.txtnumero2 = New System.Windows.Forms.TextBox()
        Me.optDividir = New System.Windows.Forms.RadioButton()
        Me.optMultiplicar = New System.Windows.Forms.RadioButton()
        Me.optModulo = New System.Windows.Forms.RadioButton()
        Me.optRestar = New System.Windows.Forms.RadioButton()
        Me.optSumar = New System.Windows.Forms.RadioButton()
        Me.optExponenciacion = New System.Windows.Forms.RadioButton()
        Me.optPorcentaje = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(103, 61)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(35, 13)
        Me.lblnum1.TabIndex = 0
        Me.lblnum1.Text = "Num1"
        '
        'txtnumero1
        '
        Me.txtnumero1.Location = New System.Drawing.Point(75, 77)
        Me.txtnumero1.Name = "txtnumero1"
        Me.txtnumero1.Size = New System.Drawing.Size(90, 20)
        Me.txtnumero1.TabIndex = 1
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(196, 219)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(139, 51)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(342, 61)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(35, 13)
        Me.lblnum2.TabIndex = 3
        Me.lblnum2.Text = "Num2"
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(597, 68)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(90, 20)
        Me.txtnum2.TabIndex = 4
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(437, 80)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(64, 13)
        Me.lblrespuesta.TabIndex = 5
        Me.lblrespuesta.Text = "Respuesta?"
        '
        'txtnumero2
        '
        Me.txtnumero2.Location = New System.Drawing.Point(314, 77)
        Me.txtnumero2.Name = "txtnumero2"
        Me.txtnumero2.Size = New System.Drawing.Size(99, 20)
        Me.txtnumero2.TabIndex = 12
        '
        'optDividir
        '
        Me.optDividir.AutoSize = True
        Me.optDividir.Location = New System.Drawing.Point(228, 126)
        Me.optDividir.Name = "optDividir"
        Me.optDividir.Size = New System.Drawing.Size(30, 17)
        Me.optDividir.TabIndex = 13
        Me.optDividir.TabStop = True
        Me.optDividir.Text = "/"
        Me.optDividir.UseVisualStyleBackColor = True
        '
        'optMultiplicar
        '
        Me.optMultiplicar.AutoSize = True
        Me.optMultiplicar.Location = New System.Drawing.Point(226, 103)
        Me.optMultiplicar.Name = "optMultiplicar"
        Me.optMultiplicar.Size = New System.Drawing.Size(29, 17)
        Me.optMultiplicar.TabIndex = 14
        Me.optMultiplicar.TabStop = True
        Me.optMultiplicar.Text = "*"
        Me.optMultiplicar.UseVisualStyleBackColor = True
        '
        'optModulo
        '
        Me.optModulo.AutoSize = True
        Me.optModulo.Location = New System.Drawing.Point(228, 195)
        Me.optModulo.Name = "optModulo"
        Me.optModulo.Size = New System.Drawing.Size(46, 17)
        Me.optModulo.TabIndex = 15
        Me.optModulo.TabStop = True
        Me.optModulo.Text = "Mod"
        Me.optModulo.UseVisualStyleBackColor = True
        '
        'optRestar
        '
        Me.optRestar.AutoSize = True
        Me.optRestar.Location = New System.Drawing.Point(227, 80)
        Me.optRestar.Name = "optRestar"
        Me.optRestar.Size = New System.Drawing.Size(28, 17)
        Me.optRestar.TabIndex = 16
        Me.optRestar.TabStop = True
        Me.optRestar.Text = "-"
        Me.optRestar.UseVisualStyleBackColor = True
        '
        'optSumar
        '
        Me.optSumar.AutoSize = True
        Me.optSumar.Location = New System.Drawing.Point(226, 57)
        Me.optSumar.Name = "optSumar"
        Me.optSumar.Size = New System.Drawing.Size(31, 17)
        Me.optSumar.TabIndex = 17
        Me.optSumar.TabStop = True
        Me.optSumar.Text = "+"
        Me.optSumar.UseVisualStyleBackColor = True
        '
        'optExponenciacion
        '
        Me.optExponenciacion.AutoSize = True
        Me.optExponenciacion.Location = New System.Drawing.Point(228, 149)
        Me.optExponenciacion.Name = "optExponenciacion"
        Me.optExponenciacion.Size = New System.Drawing.Size(31, 17)
        Me.optExponenciacion.TabIndex = 18
        Me.optExponenciacion.TabStop = True
        Me.optExponenciacion.Text = "^"
        Me.optExponenciacion.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Location = New System.Drawing.Point(228, 172)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(33, 17)
        Me.optPorcentaje.TabIndex = 19
        Me.optPorcentaje.TabStop = True
        Me.optPorcentaje.Text = "%"
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 323)
        Me.Controls.Add(Me.optPorcentaje)
        Me.Controls.Add(Me.optExponenciacion)
        Me.Controls.Add(Me.optSumar)
        Me.Controls.Add(Me.optRestar)
        Me.Controls.Add(Me.optModulo)
        Me.Controls.Add(Me.optMultiplicar)
        Me.Controls.Add(Me.optDividir)
        Me.Controls.Add(Me.txtnumero2)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtnumero1)
        Me.Controls.Add(Me.lblnum1)
        Me.Name = "Form7"
        Me.Text = "Calcuradora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnum1 As Label
    Friend WithEvents txtnumero1 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblnum2 As Label
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents txtnumero2 As TextBox
    Friend WithEvents optDividir As RadioButton
    Friend WithEvents optMultiplicar As RadioButton
    Friend WithEvents optModulo As RadioButton
    Friend WithEvents optRestar As RadioButton
    Friend WithEvents optSumar As RadioButton
    Friend WithEvents optExponenciacion As RadioButton
    Friend WithEvents optPorcentaje As RadioButton
End Class
