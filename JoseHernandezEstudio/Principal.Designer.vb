<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnContratistas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.btnObras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnContratistas
        '
        Me.btnContratistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContratistas.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContratistas.Location = New System.Drawing.Point(216, 24)
        Me.btnContratistas.Name = "btnContratistas"
        Me.btnContratistas.Size = New System.Drawing.Size(153, 129)
        Me.btnContratistas.TabIndex = 1
        Me.btnContratistas.Text = "Contratistas"
        Me.btnContratistas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnContratistas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(375, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 129)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(216, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 129)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button1"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(49, 174)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 129)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button1"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.CLIENTES_POTENCIALES
        Me.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.Location = New System.Drawing.Point(375, 24)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(153, 129)
        Me.BtnClientes.TabIndex = 2
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'btnObras
        '
        Me.btnObras.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.dicas_para_contratar_mao_de_obra_6
        Me.btnObras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnObras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnObras.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObras.Location = New System.Drawing.Point(49, 24)
        Me.btnObras.Name = "btnObras"
        Me.btnObras.Size = New System.Drawing.Size(153, 129)
        Me.btnObras.TabIndex = 0
        Me.btnObras.Text = "Obras"
        Me.btnObras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnObras.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(626, 315)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.btnContratistas)
        Me.Controls.Add(Me.btnObras)
        Me.Name = "Principal"
        Me.Text = "Estudio Jose Hernandez"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnObras As System.Windows.Forms.Button
    Friend WithEvents btnContratistas As System.Windows.Forms.Button
    Friend WithEvents BtnClientes As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
