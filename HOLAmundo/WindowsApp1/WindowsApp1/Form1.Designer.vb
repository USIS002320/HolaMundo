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
        Me.lblntabla = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.txtNtabla = New System.Windows.Forms.TextBox()
        Me.lstTabla = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblntabla
        '
        Me.lblntabla.AutoSize = True
        Me.lblntabla.Location = New System.Drawing.Point(382, 113)
        Me.lblntabla.Name = "lblntabla"
        Me.lblntabla.Size = New System.Drawing.Size(37, 13)
        Me.lblntabla.TabIndex = 0
        Me.lblntabla.Text = "Tabla:"
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(96, 91)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(192, 95)
        Me.btnProcesar.TabIndex = 1
        Me.btnProcesar.Text = "generar tabla "
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'txtNtabla
        '
        Me.txtNtabla.Location = New System.Drawing.Point(349, 129)
        Me.txtNtabla.Name = "txtNtabla"
        Me.txtNtabla.Size = New System.Drawing.Size(107, 20)
        Me.txtNtabla.TabIndex = 2
        '
        'lstTabla
        '
        Me.lstTabla.FormattingEnabled = True
        Me.lstTabla.Location = New System.Drawing.Point(505, 100)
        Me.lstTabla.Name = "lstTabla"
        Me.lstTabla.Size = New System.Drawing.Size(259, 316)
        Me.lstTabla.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstTabla)
        Me.Controls.Add(Me.txtNtabla)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.lblntabla)
        Me.Name = "Form1"
        Me.Text = "Tabla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblntabla As Label
    Friend WithEvents btnProcesar As Button
    Friend WithEvents txtNtabla As TextBox
    Friend WithEvents lstTabla As ListBox
End Class
