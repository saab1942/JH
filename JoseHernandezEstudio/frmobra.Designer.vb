<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmobra
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
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim BarrioLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim IdobraLabel As System.Windows.Forms.Label
        Dim FechainicioLabel As System.Windows.Forms.Label
        Dim IdcontratistaLabel As System.Windows.Forms.Label
        Dim IdclienteLabel As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim NombreLabel2 As System.Windows.Forms.Label
        Dim ApellidoLabel1 As System.Windows.Forms.Label
        Me.JH2DataSet = New WindowsApplication1.JH2DataSet()
        Me.ObraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObraTableAdapter = New WindowsApplication1.JH2DataSetTableAdapters.obraTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.JH2DataSetTableAdapters.TableAdapterManager()
        Me.ClienteTableAdapter = New WindowsApplication1.JH2DataSetTableAdapters.clienteTableAdapter()
        Me.ContratistaTableAdapter = New WindowsApplication1.JH2DataSetTableAdapters.contratistaTableAdapter()
        Me.ObraDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.BarrioTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.IdobraTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContratistaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechainicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdcontratistaTextBox = New System.Windows.Forms.TextBox()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox2 = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        NombreLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        BarrioLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        IdobraLabel = New System.Windows.Forms.Label()
        FechainicioLabel = New System.Windows.Forms.Label()
        IdcontratistaLabel = New System.Windows.Forms.Label()
        IdclienteLabel = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        NombreLabel2 = New System.Windows.Forms.Label()
        ApellidoLabel1 = New System.Windows.Forms.Label()
        CType(Me.JH2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratistaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(48, 30)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 24
        NombreLabel.Text = "nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(40, 59)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 25
        DireccionLabel.Text = "direccion:"
        '
        'BarrioLabel
        '
        BarrioLabel.AutoSize = True
        BarrioLabel.Location = New System.Drawing.Point(57, 95)
        BarrioLabel.Name = "BarrioLabel"
        BarrioLabel.Size = New System.Drawing.Size(36, 13)
        BarrioLabel.TabIndex = 26
        BarrioLabel.Text = "barrio:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(51, 121)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(42, 13)
        CiudadLabel.TabIndex = 27
        CiudadLabel.Text = "ciudad:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(40, 147)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(53, 13)
        ProvinciaLabel.TabIndex = 28
        ProvinciaLabel.Text = "provincia:"
        '
        'IdobraLabel
        '
        IdobraLabel.AutoSize = True
        IdobraLabel.Location = New System.Drawing.Point(54, 5)
        IdobraLabel.Name = "IdobraLabel"
        IdobraLabel.Size = New System.Drawing.Size(39, 13)
        IdobraLabel.TabIndex = 29
        IdobraLabel.Text = "idobra:"
        '
        'FechainicioLabel
        '
        FechainicioLabel.AutoSize = True
        FechainicioLabel.Location = New System.Drawing.Point(32, 189)
        FechainicioLabel.Name = "FechainicioLabel"
        FechainicioLabel.Size = New System.Drawing.Size(61, 13)
        FechainicioLabel.TabIndex = 31
        FechainicioLabel.Text = "fechainicio:"
        '
        'JH2DataSet
        '
        Me.JH2DataSet.DataSetName = "JH2DataSet"
        Me.JH2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ObraBindingSource
        '
        Me.ObraBindingSource.DataMember = "obra"
        Me.ObraBindingSource.DataSource = Me.JH2DataSet
        '
        'ObraTableAdapter
        '
        Me.ObraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.avanceTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.contratistaTableAdapter = Me.ContratistaTableAdapter
        Me.TableAdapterManager.itemTableAdapter = Nothing
        Me.TableAdapterManager.obraTableAdapter = Me.ObraTableAdapter
        Me.TableAdapterManager.presupuestoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.JH2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'ContratistaTableAdapter
        '
        Me.ContratistaTableAdapter.ClearBeforeFill = True
        '
        'ObraDataGridView
        '
        Me.ObraDataGridView.AutoGenerateColumns = False
        Me.ObraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ObraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ObraDataGridView.DataSource = Me.ObraBindingSource
        Me.ObraDataGridView.Location = New System.Drawing.Point(-1, 269)
        Me.ObraDataGridView.Name = "ObraDataGridView"
        Me.ObraDataGridView.Size = New System.Drawing.Size(954, 225)
        Me.ObraDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idobra"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idobra"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "barrio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "barrio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "provincia"
        Me.DataGridViewTextBoxColumn6.HeaderText = "provincia"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fechainicio"
        Me.DataGridViewTextBoxColumn7.HeaderText = "fechainicio"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idcontratistafk"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idcontratistafk"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "idclientefk"
        Me.DataGridViewTextBoxColumn9.HeaderText = "idclientefk"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObraBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(99, 27)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 25
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObraBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(99, 56)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 26
        '
        'BarrioTextBox
        '
        Me.BarrioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObraBindingSource, "barrio", True))
        Me.BarrioTextBox.Location = New System.Drawing.Point(99, 92)
        Me.BarrioTextBox.Name = "BarrioTextBox"
        Me.BarrioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BarrioTextBox.TabIndex = 27
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObraBindingSource, "ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(99, 118)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CiudadTextBox.TabIndex = 28
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObraBindingSource, "provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(99, 144)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProvinciaTextBox.TabIndex = 29
        '
        'IdobraTextBox
        '
        Me.IdobraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObraBindingSource, "idobra", True))
        Me.IdobraTextBox.Location = New System.Drawing.Point(99, 2)
        Me.IdobraTextBox.Name = "IdobraTextBox"
        Me.IdobraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdobraTextBox.TabIndex = 30
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.JH2DataSet
        '
        'ContratistaBindingSource
        '
        Me.ContratistaBindingSource.DataMember = "contratista"
        Me.ContratistaBindingSource.DataSource = Me.JH2DataSet
        '
        'FechainicioDateTimePicker
        '
        Me.FechainicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ObraBindingSource, "fechainicio", True))
        Me.FechainicioDateTimePicker.Location = New System.Drawing.Point(99, 185)
        Me.FechainicioDateTimePicker.Name = "FechainicioDateTimePicker"
        Me.FechainicioDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechainicioDateTimePicker.TabIndex = 32
        '
        'IdcontratistaLabel
        '
        IdcontratistaLabel.AutoSize = True
        IdcontratistaLabel.Location = New System.Drawing.Point(232, 99)
        IdcontratistaLabel.Name = "IdcontratistaLabel"
        IdcontratistaLabel.Size = New System.Drawing.Size(67, 13)
        IdcontratistaLabel.TabIndex = 32
        IdcontratistaLabel.Text = "idcontratista:"
        '
        'IdcontratistaTextBox
        '
        Me.IdcontratistaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContratistaBindingSource, "idcontratista", True))
        Me.IdcontratistaTextBox.Location = New System.Drawing.Point(305, 99)
        Me.IdcontratistaTextBox.Name = "IdcontratistaTextBox"
        Me.IdcontratistaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdcontratistaTextBox.TabIndex = 33
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(250, 5)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(49, 13)
        IdclienteLabel.TabIndex = 33
        IdclienteLabel.Text = "idcliente:"
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "idcliente", True))
        Me.IdclienteTextBox.Location = New System.Drawing.Point(305, 5)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdclienteTextBox.TabIndex = 34
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(254, 34)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(45, 13)
        NombreLabel1.TabIndex = 34
        NombreLabel1.Text = "nombre:"
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nombre", True))
        Me.NombreTextBox1.Location = New System.Drawing.Point(305, 31)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox1.TabIndex = 35
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(253, 60)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(46, 13)
        ApellidoLabel.TabIndex = 35
        ApellidoLabel.Text = "apellido:"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(305, 57)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 36
        '
        'NombreLabel2
        '
        NombreLabel2.AutoSize = True
        NombreLabel2.Location = New System.Drawing.Point(254, 128)
        NombreLabel2.Name = "NombreLabel2"
        NombreLabel2.Size = New System.Drawing.Size(45, 13)
        NombreLabel2.TabIndex = 36
        NombreLabel2.Text = "nombre:"
        '
        'NombreTextBox2
        '
        Me.NombreTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContratistaBindingSource, "nombre", True))
        Me.NombreTextBox2.Location = New System.Drawing.Point(305, 125)
        Me.NombreTextBox2.Name = "NombreTextBox2"
        Me.NombreTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox2.TabIndex = 37
        '
        'ApellidoLabel1
        '
        ApellidoLabel1.AutoSize = True
        ApellidoLabel1.Location = New System.Drawing.Point(253, 154)
        ApellidoLabel1.Name = "ApellidoLabel1"
        ApellidoLabel1.Size = New System.Drawing.Size(46, 13)
        ApellidoLabel1.TabIndex = 37
        ApellidoLabel1.Text = "apellido:"
        '
        'ApellidoTextBox1
        '
        Me.ApellidoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContratistaBindingSource, "apellido", True))
        Me.ApellidoTextBox1.Location = New System.Drawing.Point(305, 151)
        Me.ApellidoTextBox1.Name = "ApellidoTextBox1"
        Me.ApellidoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox1.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.next_
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(455, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 35)
        Me.Button1.TabIndex = 39
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.save
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.Location = New System.Drawing.Point(436, 185)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(57, 51)
        Me.btnGuardar.TabIndex = 31
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.images
        Me.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportar.Location = New System.Drawing.Point(959, 269)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(68, 54)
        Me.btnExportar.TabIndex = 24
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.remove
        Me.btnborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnborrar.Location = New System.Drawing.Point(861, 164)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(92, 72)
        Me.btnborrar.TabIndex = 23
        Me.btnborrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.edit_tool
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btneditar.Location = New System.Drawing.Point(861, 82)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(92, 76)
        Me.btneditar.TabIndex = 22
        Me.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.add_user
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Location = New System.Drawing.Point(861, 2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 74)
        Me.btnAgregar.TabIndex = 21
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back_
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(411, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 35)
        Me.Button2.TabIndex = 40
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back_
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(411, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 35)
        Me.Button3.TabIndex = 42
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.next_
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(455, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 35)
        Me.Button4.TabIndex = 41
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmobra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 514)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ApellidoLabel1)
        Me.Controls.Add(Me.ApellidoTextBox1)
        Me.Controls.Add(NombreLabel2)
        Me.Controls.Add(Me.NombreTextBox2)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(NombreLabel1)
        Me.Controls.Add(Me.NombreTextBox1)
        Me.Controls.Add(IdclienteLabel)
        Me.Controls.Add(Me.IdclienteTextBox)
        Me.Controls.Add(IdcontratistaLabel)
        Me.Controls.Add(Me.IdcontratistaTextBox)
        Me.Controls.Add(FechainicioLabel)
        Me.Controls.Add(Me.FechainicioDateTimePicker)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(IdobraLabel)
        Me.Controls.Add(Me.IdobraTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(BarrioLabel)
        Me.Controls.Add(Me.BarrioTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.ObraDataGridView)
        Me.Name = "frmobra"
        Me.Text = "Form1"
        CType(Me.JH2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratistaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JH2DataSet As WindowsApplication1.JH2DataSet
    Friend WithEvents ObraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ObraTableAdapter As WindowsApplication1.JH2DataSetTableAdapters.obraTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.JH2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ObraDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteTableAdapter As WindowsApplication1.JH2DataSetTableAdapters.clienteTableAdapter
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BarrioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CiudadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdobraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContratistaTableAdapter As WindowsApplication1.JH2DataSetTableAdapters.contratistaTableAdapter
    Friend WithEvents ContratistaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents FechainicioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IdcontratistaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdclienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
