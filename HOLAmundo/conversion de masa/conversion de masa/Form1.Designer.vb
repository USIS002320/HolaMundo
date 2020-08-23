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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblum = New System.Windows.Forms.Label()
        Me.lblr = New System.Windows.Forms.Label()
        Me.cmdconvertir = New System.Windows.Forms.Button()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.cbxentrada = New System.Windows.Forms.ComboBox()
        Me.cbxsalida = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdnuevo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Convertidor de Unidades"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Escriba el valor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(410, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(350, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "seleccione las unidades a convertir "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(441, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "De:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(441, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "A:"
        '
        'lblum
        '
        Me.lblum.AutoSize = True
        Me.lblum.Location = New System.Drawing.Point(144, 22)
        Me.lblum.Name = "lblum"
        Me.lblum.Size = New System.Drawing.Size(0, 20)
        Me.lblum.TabIndex = 5
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Location = New System.Drawing.Point(144, 54)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(19, 20)
        Me.lblr.TabIndex = 6
        Me.lblr.Text = "0"
        '
        'cmdconvertir
        '
        Me.cmdconvertir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdconvertir.Location = New System.Drawing.Point(50, 164)
        Me.cmdconvertir.Name = "cmdconvertir"
        Me.cmdconvertir.Size = New System.Drawing.Size(144, 47)
        Me.cmdconvertir.TabIndex = 7
        Me.cmdconvertir.Text = "Convertidor"
        Me.cmdconvertir.UseVisualStyleBackColor = False
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(41, 138)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(169, 20)
        Me.txtvalor.TabIndex = 10
        '
        'cbxentrada
        '
        Me.cbxentrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxentrada.FormattingEnabled = True
        Me.cbxentrada.Items.AddRange(New Object() {"===PESO===", "", "Miligramos", "Gramos", "Kilogramos", "Toneladas", "Microgramos", "Libras", "Stone", "Toneladas Largas", "Toneladas Cortas", "Onzas"})
        Me.cbxentrada.Location = New System.Drawing.Point(484, 156)
        Me.cbxentrada.Name = "cbxentrada"
        Me.cbxentrada.Size = New System.Drawing.Size(121, 21)
        Me.cbxentrada.TabIndex = 11
        '
        'cbxsalida
        '
        Me.cbxsalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxsalida.FormattingEnabled = True
        Me.cbxsalida.Items.AddRange(New Object() {"===PESO===", "", "Miligramos", "Gramos", "Kilogramos", "Toneladas", "Microgramos", "Libras", "Stone", "Toneladas Largas", "Toneladas Cortas", "Onzas"})
        Me.cbxsalida.Location = New System.Drawing.Point(484, 236)
        Me.cbxsalida.Name = "cbxsalida"
        Me.cbxsalida.Size = New System.Drawing.Size(121, 21)
        Me.cbxsalida.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.lblum)
        Me.GroupBox1.Controls.Add(Me.lblr)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(306, 300)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 100)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado"
        '
        'cmdnuevo
        '
        Me.cmdnuevo.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.cmdnuevo.Location = New System.Drawing.Point(50, 236)
        Me.cmdnuevo.Name = "cmdnuevo"
        Me.cmdnuevo.Size = New System.Drawing.Size(76, 146)
        Me.cmdnuevo.TabIndex = 14
        Me.cmdnuevo.Text = "Borrar"
        Me.cmdnuevo.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Location = New System.Drawing.Point(119, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 146)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Terminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdnuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbxsalida)
        Me.Controls.Add(Me.cbxentrada)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.cmdconvertir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Convertidor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblum As Label
    Friend WithEvents lblr As Label
    Friend WithEvents cmdconvertir As Button
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents cbxentrada As ComboBox
    Friend WithEvents cbxsalida As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdnuevo As Button
    Friend WithEvents Button2 As Button
End Class
