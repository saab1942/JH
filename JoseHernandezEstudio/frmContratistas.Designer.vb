<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContratistas
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
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim IdcontratistaLabel As System.Windows.Forms.Label
        Me.JH2DataSet = New WindowsApplication1.JH2DataSet()
        Me.ContratistaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContratistaTableAdapter = New WindowsApplication1.JH2DataSetTableAdapters.contratistaTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.JH2DataSetTableAdapters.TableAdapterManager()
        Me.ObraTableAdapter = New WindowsApplication1.JH2DataSetTableAdapters.obraTableAdapter()
        Me.ContratistaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObraDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.IdcontratistaTextBox = New System.Windows.Forms.TextBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        IdcontratistaLabel = New System.Windows.Forms.Label()
        CType(Me.JH2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratistaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratistaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(358, 15)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(370, 48)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(46, 13)
        ApellidoLabel.TabIndex = 5
        ApellidoLabel.Text = "apellido:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(371, 83)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(48, 13)
        TelefonoLabel.TabIndex = 7
        TelefonoLabel.Text = "telefono:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(380, 118)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 9
        DireccionLabel.Text = "direccion:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(402, 151)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "email:"
        '
        'IdcontratistaLabel
        '
        IdcontratistaLabel.AutoSize = True
        IdcontratistaLabel.Location = New System.Drawing.Point(398, 186)
        IdcontratistaLabel.Name = "IdcontratistaLabel"
        IdcontratistaLabel.Size = New System.Drawing.Size(67, 13)
        IdcontratistaLabel.TabIndex = 13
        IdcontratistaLabel.Text = "idcontratista:"
        '
        'JH2DataSet
        '
        Me.JH2DataSet.DataSetName = "JH2DataSet"
        Me.JH2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContratistaBindingSource
        '
        Me.ContratistaBindingSource.DataMember = "contratista"
        Me.ContratistaBindingSource.DataSource = Me.JH2DataSet
        '
        'ContratistaTableAdapter
        '
        Me.ContratistaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.avanceTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.contratistaTableAdapter = Me.ContratistaTableAdapter
        Me.TableAdapterManager.itemTableAdapter = Nothing
        Me.TableAdapterManager.obraTableAdapter = Me.ObraTableAdapter
        Me.TableAdapterManager.presupuestoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.JH2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ObraTableAdapter
        '
        Me.ObraTableAdapter.ClearBeforeFill = True
        '
        'ContratistaDataGridView
        '
        Me.ContratistaDataGridView.AllowUserToAddRows = False
        Me.ContratistaDataGridView.AllowUserToDeleteRows = False
        Me.ContratistaDataGridView.AutoGenerateColumns = False
        Me.ContratistaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContratistaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ContratistaDataGridView.DataSource = Me.ContratistaBindingSource
        Me.ContratistaDataGridView.Location = New System.Drawing.Point(73, 346)
        Me.ContratistaDataGridView.Name = "ContratistaDataGridView"
        Me.ContratistaDataGridView.ReadOnly = True
        Me.ContratistaDataGridView.Size = New System.Drawing.Size(867, 220)
        Me.ContratistaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idcontratista"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idcontratista"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'ObraBindingSource
        '
        Me.ObraBindingSource.DataMember = "contratistaobra"
        Me.ObraBindingSource.DataSource = Me.ContratistaBindingSource
        '
        'ObraDataGridView
        '
        Me.ObraDataGridView.AllowUserToAddRows = False
        Me.ObraDataGridView.AllowUserToDeleteRows = False
        Me.ObraDataGridView.AutoGenerateColumns = False
        Me.ObraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ObraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.ObraDataGridView.DataSource = Me.ObraBindingSource
        Me.ObraDataGridView.Location = New System.Drawing.Point(718, 15)
        Me.ObraDataGridView.Name = "ObraDataGridView"
        Me.ObraDataGridView.ReadOnly = True
        Me.ObraDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ObraDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idobra"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idobra"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn8.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "barrio"
        Me.DataGridViewTextBoxColumn10.HeaderText = "barrio"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "provincia"
        Me.DataGridViewTextBoxColumn12.HeaderText = "provincia"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "fechainicio"
        Me.DataGridViewTextBoxColumn13.HeaderText = "fechainicio"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "idcontratistafk"
        Me.DataGridViewTextBoxColumn14.HeaderText = "idcontratistafk"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "idclientefk"
        Me.DataGridViewTextBoxColumn15.HeaderText = "idclientefk"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContratistaBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(409, 12)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContratistaBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(422, 45)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 6
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContratistaBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(425, 80)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 8
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContratistaBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(439, 115)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 10
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContratistaBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(442, 148)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 12
        '
        'IdcontratistaTextBox
        '
        Me.IdcontratistaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContratistaBindingSource, "idcontratista", True))
        Me.IdcontratistaTextBox.Location = New System.Drawing.Point(471, 183)
        Me.IdcontratistaTextBox.Name = "IdcontratistaTextBox"
        Me.IdcontratistaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdcontratistaTextBox.TabIndex = 14
        '
        'btnExportar
        '
        Me.btnExportar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.images
        Me.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportar.Location = New System.Drawing.Point(950, 283)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(68, 54)
        Me.btnExportar.TabIndex = 25
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.remove
        Me.btnborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnborrar.Location = New System.Drawing.Point(597, 206)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(92, 72)
        Me.btnborrar.TabIndex = 24
        Me.btnborrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.save
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.Location = New System.Drawing.Point(468, 227)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(57, 51)
        Me.btnGuardar.TabIndex = 21
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.edit_tool
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btneditar.Location = New System.Drawing.Point(597, 112)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(92, 76)
        Me.btneditar.TabIndex = 23
        Me.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.add_user
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Location = New System.Drawing.Point(596, 22)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 74)
        Me.btnAgregar.TabIndex = 22
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmContratistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 599)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(IdcontratistaLabel)
        Me.Controls.Add(Me.IdcontratistaTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.ObraDataGridView)
        Me.Controls.Add(Me.ContratistaDataGridView)
        Me.Name = "frmContratistas"
        Me.Text = "Form1"
        CType(Me.JH2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratistaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratistaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JH2DataSet As WindowsApplication1.JH2DataSet
    Friend WithEvents ContratistaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContratistaTableAdapter As WindowsApplication1.JH2DataSetTableAdapters.contratistaTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.JH2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContratistaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObraTableAdapter As WindowsApplication1.JH2DataSetTableAdapters.obraTableAdapter
    Friend WithEvents ObraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ObraDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdcontratistaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class
