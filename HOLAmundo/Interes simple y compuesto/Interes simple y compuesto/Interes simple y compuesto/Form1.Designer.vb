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
        Me.lblinteresCompuesto = New System.Windows.Forms.Label()
        Me.lblInteresSimple = New System.Windows.Forms.Label()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.lbltiempo = New System.Windows.Forms.Label()
        Me.txtinteres = New System.Windows.Forms.TextBox()
        Me.lblinteres = New System.Windows.Forms.Label()
        Me.txtcapital = New System.Windows.Forms.TextBox()
        Me.lblcapital = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblinteresCompuesto
        '
        Me.lblinteresCompuesto.AutoSize = True
        Me.lblinteresCompuesto.Location = New System.Drawing.Point(319, 163)
        Me.lblinteresCompuesto.Name = "lblinteresCompuesto"
        Me.lblinteresCompuesto.Size = New System.Drawing.Size(107, 13)
        Me.lblinteresCompuesto.TabIndex = 17
        Me.lblinteresCompuesto.Text = "Interes Compuesto: ?"
        '
        'lblInteresSimple
        '
        Me.lblInteresSimple.AutoSize = True
        Me.lblInteresSimple.Location = New System.Drawing.Point(118, 163)
        Me.lblInteresSimple.Name = "lblInteresSimple"
        Me.lblInteresSimple.Size = New System.Drawing.Size(85, 13)
        Me.lblInteresSimple.TabIndex = 16
        Me.lblInteresSimple.Text = "Interes Simple: ?"
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(431, 106)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(49, 20)
        Me.txtTiempo.TabIndex = 15
        '
        'lbltiempo
        '
        Me.lbltiempo.AutoSize = True
        Me.lbltiempo.Location = New System.Drawing.Point(347, 109)
        Me.lbltiempo.Name = "lbltiempo"
        Me.lbltiempo.Size = New System.Drawing.Size(78, 13)
        Me.lbltiempo.TabIndex = 14
        Me.lbltiempo.Text = "Tiempo (Años):"
        '
        'txtinteres
        '
        Me.txtinteres.Location = New System.Drawing.Point(284, 106)
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(55, 20)
        Me.txtinteres.TabIndex = 13
        '
        'lblinteres
        '
        Me.lblinteres.AutoSize = True
        Me.lblinteres.Location = New System.Drawing.Point(239, 109)
        Me.lblinteres.Name = "lblinteres"
        Me.lblinteres.Size = New System.Drawing.Size(42, 13)
        Me.lblinteres.TabIndex = 12
        Me.lblinteres.Text = "Interes:"
        '
        'txtcapital
        '
        Me.txtcapital.Location = New System.Drawing.Point(132, 106)
        Me.txtcapital.Name = "txtcapital"
        Me.txtcapital.Size = New System.Drawing.Size(102, 20)
        Me.txtcapital.TabIndex = 11
        '
        'lblcapital
        '
        Me.lblcapital.AutoSize = True
        Me.lblcapital.Location = New System.Drawing.Point(87, 109)
        Me.lblcapital.Name = "lblcapital"
        Me.lblcapital.Size = New System.Drawing.Size(42, 13)
        Me.lblcapital.TabIndex = 10
        Me.lblcapital.Text = "Capital:"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.RosyBrown
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalcular.Location = New System.Drawing.Point(191, 194)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(148, 99)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(571, 397)
        Me.Controls.Add(Me.lblinteresCompuesto)
        Me.Controls.Add(Me.lblInteresSimple)
        Me.Controls.Add(Me.txtTiempo)
        Me.Controls.Add(Me.lbltiempo)
        Me.Controls.Add(Me.txtinteres)
        Me.Controls.Add(Me.lblinteres)
        Me.Controls.Add(Me.txtcapital)
        Me.Controls.Add(Me.lblcapital)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Form1"
        Me.Text = "Interes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblinteresCompuesto As Label
    Friend WithEvents lblInteresSimple As Label
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents lbltiempo As Label
    Friend WithEvents txtinteres As TextBox
    Friend WithEvents lblinteres As Label
    Friend WithEvents txtcapital As TextBox
    Friend WithEvents lblcapital As Label
    Friend WithEvents btnCalcular As Button
End Class
