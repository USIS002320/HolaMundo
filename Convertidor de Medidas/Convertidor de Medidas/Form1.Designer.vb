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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblr = New System.Windows.Forms.TextBox()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxentrada = New System.Windows.Forms.ComboBox()
        Me.cbxsalida = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(408, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(334, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Selecciones la Unidad de Medidas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(247, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Convertidor de Longitud"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(103, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 124)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Convertir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblr
        '
        Me.lblr.Location = New System.Drawing.Point(396, 333)
        Me.lblr.Multiline = True
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(143, 40)
        Me.lblr.TabIndex = 17
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(103, 209)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(142, 20)
        Me.txtvalor.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label4.Location = New System.Drawing.Point(332, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Resultado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ingrese un valor"
        '
        'cbxentrada
        '
        Me.cbxentrada.FormattingEnabled = True
        Me.cbxentrada.ItemHeight = 13
        Me.cbxentrada.Items.AddRange(New Object() {"Milimetros", "Centimetros", "Metros", "Kilometros", "Pulgadas", "Milla", "Nanometro", "Yarda", "Milla Nautica", "Micrometro"})
        Me.cbxentrada.Location = New System.Drawing.Point(523, 251)
        Me.cbxentrada.Name = "cbxentrada"
        Me.cbxentrada.Size = New System.Drawing.Size(121, 21)
        Me.cbxentrada.TabIndex = 13
        '
        'cbxsalida
        '
        Me.cbxsalida.FormattingEnabled = True
        Me.cbxsalida.ItemHeight = 13
        Me.cbxsalida.Items.AddRange(New Object() {"Milimetros", "Centimetros", "Metros", "Kilometros", "Pulgadas", "Milla", "Nanometro", "Yarda", "Milla Nautica", "Micrometro"})
        Me.cbxsalida.Location = New System.Drawing.Point(523, 175)
        Me.cbxsalida.Name = "cbxsalida"
        Me.cbxsalida.Size = New System.Drawing.Size(121, 21)
        Me.cbxsalida.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxentrada)
        Me.Controls.Add(Me.cbxsalida)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblr As TextBox
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxentrada As ComboBox
    Friend WithEvents cbxsalida As ComboBox
End Class
