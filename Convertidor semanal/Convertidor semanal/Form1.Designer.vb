<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnCajero = New System.Windows.Forms.Button()
        Me.btnPrimo = New System.Windows.Forms.Button()
        Me.lblnum = New System.Windows.Forms.Label()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.btnParImpar = New System.Windows.Forms.Button()
        Me.lstEjercicios = New System.Windows.Forms.ListBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCajero
        '
        Me.btnCajero.BackColor = System.Drawing.Color.RosyBrown
        Me.btnCajero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCajero.Location = New System.Drawing.Point(233, 193)
        Me.btnCajero.Name = "btnCajero"
        Me.btnCajero.Size = New System.Drawing.Size(85, 73)
        Me.btnCajero.TabIndex = 13
        Me.btnCajero.Text = "Cajero"
        Me.btnCajero.UseVisualStyleBackColor = False
        '
        'btnPrimo
        '
        Me.btnPrimo.BackColor = System.Drawing.Color.OliveDrab
        Me.btnPrimo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimo.Location = New System.Drawing.Point(142, 193)
        Me.btnPrimo.Name = "btnPrimo"
        Me.btnPrimo.Size = New System.Drawing.Size(85, 73)
        Me.btnPrimo.TabIndex = 12
        Me.btnPrimo.Text = "Primo?"
        Me.btnPrimo.UseVisualStyleBackColor = False
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnum.Location = New System.Drawing.Point(95, 105)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(54, 13)
        Me.lblnum.TabIndex = 11
        Me.lblnum.Text = "Numero:"
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(155, 102)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(79, 20)
        Me.txtnum.TabIndex = 10
        '
        'btnParImpar
        '
        Me.btnParImpar.BackColor = System.Drawing.Color.CadetBlue
        Me.btnParImpar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParImpar.Location = New System.Drawing.Point(61, 193)
        Me.btnParImpar.Name = "btnParImpar"
        Me.btnParImpar.Size = New System.Drawing.Size(75, 73)
        Me.btnParImpar.TabIndex = 9
        Me.btnParImpar.Text = "Par o Impar?"
        Me.btnParImpar.UseVisualStyleBackColor = False
        '
        'lstEjercicios
        '
        Me.lstEjercicios.FormattingEnabled = True
        Me.lstEjercicios.Location = New System.Drawing.Point(324, 44)
        Me.lstEjercicios.Name = "lstEjercicios"
        Me.lstEjercicios.Size = New System.Drawing.Size(168, 199)
        Me.lstEjercicios.TabIndex = 8
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Location = New System.Drawing.Point(324, 249)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(168, 44)
        Me.btnProcesar.TabIndex = 7
        Me.btnProcesar.Text = "Mostrar Pares e impares"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Salmon
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(67, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 50)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(556, 381)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCajero)
        Me.Controls.Add(Me.btnPrimo)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.btnParImpar)
        Me.Controls.Add(Me.lstEjercicios)
        Me.Controls.Add(Me.btnProcesar)
        Me.Name = "Form1"
        Me.Text = "NUM Par e impares"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCajero As Button
    Friend WithEvents btnPrimo As Button
    Friend WithEvents lblnum As Label
    Friend WithEvents txtnum As TextBox
    Friend WithEvents btnParImpar As Button
    Friend WithEvents lstEjercicios As ListBox
    Friend WithEvents btnProcesar As Button
    Friend WithEvents Button1 As Button
End Class
