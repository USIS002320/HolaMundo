﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxsalida = New System.Windows.Forms.ComboBox()
        Me.cbxentrada = New System.Windows.Forms.ComboBox()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(92, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 109)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Convertir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblr
        '
        Me.lblr.Location = New System.Drawing.Point(387, 339)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(100, 20)
        Me.lblr.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Resultado:"
        '
        'cbxsalida
        '
        Me.cbxsalida.FormattingEnabled = True
        Me.cbxsalida.Items.AddRange(New Object() {"Bit", "Kilobit", "Megabit", "Gigabit", "Terabit", "Petabit", "Megabyte", "Gigabyte", "Terabyte", "Petabyte"})
        Me.cbxsalida.Location = New System.Drawing.Point(487, 203)
        Me.cbxsalida.Name = "cbxsalida"
        Me.cbxsalida.Size = New System.Drawing.Size(121, 21)
        Me.cbxsalida.TabIndex = 20
        '
        'cbxentrada
        '
        Me.cbxentrada.FormattingEnabled = True
        Me.cbxentrada.Items.AddRange(New Object() {"Bit", "Kilobit", "Megabit", "Gigabit", "Terabit", "Petabit", "Megabyte", "Gigabyte", "Terabyte", "Petabyte"})
        Me.cbxentrada.Location = New System.Drawing.Point(487, 132)
        Me.cbxentrada.Name = "cbxentrada"
        Me.cbxentrada.Size = New System.Drawing.Size(121, 21)
        Me.cbxentrada.TabIndex = 19
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(92, 185)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Ingrese una Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(440, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "De:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(208, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(310, 24)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Convertidor de Almacenamiento"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(693, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxsalida)
        Me.Controls.Add(Me.cbxentrada)
        Me.Controls.Add(Me.txtvalor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxsalida As ComboBox
    Friend WithEvents cbxentrada As ComboBox
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
End Class
