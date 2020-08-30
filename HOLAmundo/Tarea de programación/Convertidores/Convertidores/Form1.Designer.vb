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
        Me.lblnum = New System.Windows.Forms.Label()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.btnparimpar = New System.Windows.Forms.Button()
        Me.btnprimo = New System.Windows.Forms.Button()
        Me.btncajero = New System.Windows.Forms.Button()
        Me.lstEjercicios = New System.Windows.Forms.ListBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnsalida = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(100, 145)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(47, 13)
        Me.lblnum.TabIndex = 0
        Me.lblnum.Text = "Numero:"
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(154, 142)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(153, 20)
        Me.txtnum.TabIndex = 3
        '
        'btnparimpar
        '
        Me.btnparimpar.BackColor = System.Drawing.Color.LightBlue
        Me.btnparimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnparimpar.Location = New System.Drawing.Point(44, 218)
        Me.btnparimpar.Name = "btnparimpar"
        Me.btnparimpar.Size = New System.Drawing.Size(95, 30)
        Me.btnparimpar.TabIndex = 4
        Me.btnparimpar.Text = "Par o Impar"
        Me.btnparimpar.UseVisualStyleBackColor = False
        '
        'btnprimo
        '
        Me.btnprimo.BackColor = System.Drawing.Color.LightBlue
        Me.btnprimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprimo.Location = New System.Drawing.Point(137, 218)
        Me.btnprimo.Name = "btnprimo"
        Me.btnprimo.Size = New System.Drawing.Size(95, 30)
        Me.btnprimo.TabIndex = 5
        Me.btnprimo.Text = "Primo"
        Me.btnprimo.UseVisualStyleBackColor = False
        '
        'btncajero
        '
        Me.btncajero.BackColor = System.Drawing.Color.LightBlue
        Me.btncajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncajero.Location = New System.Drawing.Point(230, 218)
        Me.btncajero.Name = "btncajero"
        Me.btncajero.Size = New System.Drawing.Size(95, 30)
        Me.btncajero.TabIndex = 6
        Me.btncajero.Text = "Cajero"
        Me.btncajero.UseVisualStyleBackColor = False
        '
        'lstEjercicios
        '
        Me.lstEjercicios.FormattingEnabled = True
        Me.lstEjercicios.Location = New System.Drawing.Point(342, 60)
        Me.lstEjercicios.Name = "lstEjercicios"
        Me.lstEjercicios.Size = New System.Drawing.Size(156, 199)
        Me.lstEjercicios.TabIndex = 7
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.Color.LightGreen
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Location = New System.Drawing.Point(342, 265)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(156, 46)
        Me.btnProcesar.TabIndex = 8
        Me.btnProcesar.Text = "Mostrar Pares e Impares"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'btnsalida
        '
        Me.btnsalida.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnsalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalida.Location = New System.Drawing.Point(44, 265)
        Me.btnsalida.Name = "btnsalida"
        Me.btnsalida.Size = New System.Drawing.Size(118, 46)
        Me.btnsalida.TabIndex = 9
        Me.btnsalida.Text = "Salir"
        Me.btnsalida.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aquamarine
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(168, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 46)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Borrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(535, 369)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnsalida)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.lstEjercicios)
        Me.Controls.Add(Me.btncajero)
        Me.Controls.Add(Me.btnprimo)
        Me.Controls.Add(Me.btnparimpar)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.lblnum)
        Me.Name = "Form1"
        Me.Text = "Par e Impar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnum As Label
    Friend WithEvents txtnum As TextBox
    Friend WithEvents btnparimpar As Button
    Friend WithEvents btnprimo As Button
    Friend WithEvents btncajero As Button
    Friend WithEvents lstEjercicios As ListBox
    Friend WithEvents btnProcesar As Button
    Friend WithEvents btnsalida As Button
    Friend WithEvents Button1 As Button
End Class
