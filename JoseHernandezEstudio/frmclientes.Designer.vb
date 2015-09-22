<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclientes
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
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JH2DataSet = New WindowsApplication1.JH2DataSet()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.ObraDataGridView = New System.Windows.Forms.DataGridView()
        Me.Obras = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClienteTableAdapter = New WindowsApplication1.JH2DataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.JH2DataSetTableAdapters.TableAdapterManager()
        Me.ObraTableAdapter = New WindowsApplication1.JH2DataSetTableAdapters.obraTableAdapter()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JH2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(22, 59)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(76, 20)
        NombreLabel.TabIndex = 12
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidoLabel.Location = New System.Drawing.Point(22, 100)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(78, 20)
        ApellidoLabel.TabIndex = 13
        ApellidoLabel.Text = "Apellido:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(22, 141)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(89, 20)
        DireccionLabel.TabIndex = 14
        DireccionLabel.Text = "Direccion:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(22, 182)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(84, 20)
        TelefonoLabel.TabIndex = 15
        TelefonoLabel.Text = "Telefono:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(22, 224)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(58, 20)
        EmailLabel.TabIndex = 0
        EmailLabel.Text = "Email:"
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AllowUserToAddRows = False
        Me.ClienteDataGridView.AllowUserToDeleteRows = False
        Me.ClienteDataGridView.AllowUserToOrderColumns = True
        Me.ClienteDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ClienteDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.GridColor = System.Drawing.SystemColors.ControlText
        Me.ClienteDataGridView.Location = New System.Drawing.Point(24, 314)
        Me.ClienteDataGridView.MultiSelect = False
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ClienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ClienteDataGridView.ShowEditingIcon = False
        Me.ClienteDataGridView.Size = New System.Drawing.Size(1206, 329)
        Me.ClienteDataGridView.TabIndex = 6
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn5.HeaderText = "telefono"
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
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.JH2DataSet
        '
        'JH2DataSet
        '
        Me.JH2DataSet.DataSetName = "JH2DataSet"
        Me.JH2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(152, 49)
        Me.NombreTextBox.Multiline = True
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(398, 33)
        Me.NombreTextBox.TabIndex = 0
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "apellido", True))
        Me.ApellidoTextBox.Enabled = False
        Me.ApellidoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(152, 88)
        Me.ApellidoTextBox.Multiline = True
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(398, 33)
        Me.ApellidoTextBox.TabIndex = 1
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "direccion", True))
        Me.DireccionTextBox.Enabled = False
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionTextBox.Location = New System.Drawing.Point(152, 131)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(398, 33)
        Me.DireccionTextBox.TabIndex = 2
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "telefono", True))
        Me.TelefonoTextBox.Enabled = False
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(152, 172)
        Me.TelefonoTextBox.Multiline = True
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(398, 33)
        Me.TelefonoTextBox.TabIndex = 3
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "idcliente", True))
        Me.IdclienteTextBox.Location = New System.Drawing.Point(152, 268)
        Me.IdclienteTextBox.Multiline = True
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(10, 10)
        Me.IdclienteTextBox.TabIndex = 17
        '
        'ObraDataGridView
        '
        Me.ObraDataGridView.AllowUserToAddRows = False
        Me.ObraDataGridView.AllowUserToDeleteRows = False
        Me.ObraDataGridView.AllowUserToOrderColumns = True
        Me.ObraDataGridView.AutoGenerateColumns = False
        Me.ObraDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ObraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ObraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.ObraDataGridView.DataSource = Me.ObraBindingSource
        Me.ObraDataGridView.Location = New System.Drawing.Point(735, 53)
        Me.ObraDataGridView.Name = "ObraDataGridView"
        Me.ObraDataGridView.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObraDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ObraDataGridView.Size = New System.Drawing.Size(569, 213)
        Me.ObraDataGridView.TabIndex = 17
        '
        'Obras
        '
        Me.Obras.AutoSize = True
        Me.Obras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Obras.Location = New System.Drawing.Point(731, 26)
        Me.Obras.Name = "Obras"
        Me.Obras.Size = New System.Drawing.Size(66, 24)
        Me.Obras.TabIndex = 18
        Me.Obras.Text = "Obras"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Clientes"
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.avanceTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.contratistaTableAdapter = Nothing
        Me.TableAdapterManager.itemTableAdapter = Nothing
        Me.TableAdapterManager.obraTableAdapter = Nothing
        Me.TableAdapterManager.presupuestoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.JH2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ObraTableAdapter
        '
        Me.ObraTableAdapter.ClearBeforeFill = True
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(152, 213)
        Me.EmailTextBox.Multiline = True
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(398, 34)
        Me.EmailTextBox.TabIndex = 4
        '
        'btnExportar
        '
        Me.btnExportar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.images
        Me.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportar.Location = New System.Drawing.Point(1236, 314)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(68, 54)
        Me.btnExportar.TabIndex = 20
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn7.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "barrio"
        Me.DataGridViewTextBoxColumn9.HeaderText = "barrio"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "provincia"
        Me.DataGridViewTextBoxColumn11.HeaderText = "provincia"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'ObraBindingSource
        '
        Me.ObraBindingSource.DataMember = "clienteobra"
        Me.ObraBindingSource.DataSource = Me.ClienteBindingSource
        '
        'btnborrar
        '
        Me.btnborrar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.remove
        Me.btnborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnborrar.Location = New System.Drawing.Point(583, 230)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(92, 72)
        Me.btnborrar.TabIndex = 16
        Me.btnborrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.save
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.Location = New System.Drawing.Point(152, 252)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(57, 51)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.edit_tool
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btneditar.Location = New System.Drawing.Point(583, 136)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(92, 76)
        Me.btneditar.TabIndex = 8
        Me.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.add_user
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Location = New System.Drawing.Point(582, 46)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 74)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Datos Cliente"
        '
        'frmclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1316, 655)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Obras)
        Me.Controls.Add(Me.ObraDataGridView)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.IdclienteTextBox)
        Me.Name = "frmclientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JH2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JH2DataSet As WindowsApplication1.JH2DataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As WindowsApplication1.JH2DataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.JH2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents IdclienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ObraTableAdapter As WindowsApplication1.JH2DataSetTableAdapters.obraTableAdapter
    Friend WithEvents ObraDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Obras As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
