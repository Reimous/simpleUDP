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
        Me.components = New System.ComponentModel.Container
        Me.TBTo = New System.Windows.Forms.TextBox
        Me.TBPort = New System.Windows.Forms.TextBox
        Me.TBSend = New System.Windows.Forms.TextBox
        Me.TBRcv = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TBTo
        '
        Me.TBTo.Location = New System.Drawing.Point(49, 27)
        Me.TBTo.Name = "TBTo"
        Me.TBTo.Size = New System.Drawing.Size(100, 20)
        Me.TBTo.TabIndex = 0
        Me.TBTo.Text = "192.168.1.50"
        '
        'TBPort
        '
        Me.TBPort.Location = New System.Drawing.Point(49, 63)
        Me.TBPort.Name = "TBPort"
        Me.TBPort.Size = New System.Drawing.Size(100, 20)
        Me.TBPort.TabIndex = 0
        Me.TBPort.Text = "8081"
        '
        'TBSend
        '
        Me.TBSend.Location = New System.Drawing.Point(49, 100)
        Me.TBSend.Name = "TBSend"
        Me.TBSend.Size = New System.Drawing.Size(100, 20)
        Me.TBSend.TabIndex = 0
        Me.TBSend.Text = "Prueba"
        '
        'TBRcv
        '
        Me.TBRcv.Location = New System.Drawing.Point(49, 173)
        Me.TBRcv.Name = "TBRcv"
        Me.TBRcv.Size = New System.Drawing.Size(100, 20)
        Me.TBRcv.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 476)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TBRcv)
        Me.Controls.Add(Me.TBSend)
        Me.Controls.Add(Me.TBPort)
        Me.Controls.Add(Me.TBTo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBTo As System.Windows.Forms.TextBox
    Friend WithEvents TBPort As System.Windows.Forms.TextBox
    Friend WithEvents TBSend As System.Windows.Forms.TextBox
    Friend WithEvents TBRcv As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
