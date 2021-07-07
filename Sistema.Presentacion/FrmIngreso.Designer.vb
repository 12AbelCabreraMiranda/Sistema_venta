<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngreso
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
        Me.components = New System.ComponentModel.Container()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TxtSerieComprobante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.ChkSeleccionar = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.Lbltotal = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PanelMostrar = New System.Windows.Forms.Panel()
        Me.BtnCerrarM = New System.Windows.Forms.Button()
        Me.LblTotalM = New System.Windows.Forms.Label()
        Me.LblTotalImpuestoM = New System.Windows.Forms.Label()
        Me.LblSubTotalM = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DgvMostrarDetalle = New System.Windows.Forms.DataGridView()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PanelArticulos = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LblTotalArticulos = New System.Windows.Forms.Label()
        Me.DgvArticulos = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarArticulosDetalle = New System.Windows.Forms.Button()
        Me.TxtBuscarArticulos = New System.Windows.Forms.TextBox()
        Me.BtnBuscarArticulos = New System.Windows.Forms.Button()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtTotalImpuesto = New System.Windows.Forms.TextBox()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumComprobante = New System.Windows.Forms.TextBox()
        Me.CboTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarProveedor = New System.Windows.Forms.Button()
        Me.TxtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.TxtIdProveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabPage1.SuspendLayout()
        Me.PanelMostrar.SuspendLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGeneral.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelArticulos.SuspendLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'TxtSerieComprobante
        '
        Me.TxtSerieComprobante.Location = New System.Drawing.Point(323, 74)
        Me.TxtSerieComprobante.Name = "TxtSerieComprobante"
        Me.TxtSerieComprobante.Size = New System.Drawing.Size(115, 20)
        Me.TxtSerieComprobante.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Comprobante"
        '
        'BtnAnular
        '
        Me.BtnAnular.Location = New System.Drawing.Point(403, 460)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnular.TabIndex = 7
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'ChkSeleccionar
        '
        Me.ChkSeleccionar.AutoSize = True
        Me.ChkSeleccionar.Location = New System.Drawing.Point(27, 464)
        Me.ChkSeleccionar.Name = "ChkSeleccionar"
        Me.ChkSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.ChkSeleccionar.TabIndex = 4
        Me.ChkSeleccionar.Text = "Seleccionar"
        Me.ChkSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(692, 44)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(211, 23)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(8, 47)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(658, 20)
        Me.TxtValor.TabIndex = 2
        '
        'Lbltotal
        '
        Me.Lbltotal.AutoSize = True
        Me.Lbltotal.Location = New System.Drawing.Point(780, 460)
        Me.Lbltotal.Name = "Lbltotal"
        Me.Lbltotal.Size = New System.Drawing.Size(31, 13)
        Me.Lbltotal.TabIndex = 1
        Me.Lbltotal.Text = "Total"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PanelMostrar)
        Me.TabPage1.Controls.Add(Me.BtnAnular)
        Me.TabPage1.Controls.Add(Me.ChkSeleccionar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.TxtValor)
        Me.TabPage1.Controls.Add(Me.Lbltotal)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1169, 611)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PanelMostrar
        '
        Me.PanelMostrar.BackColor = System.Drawing.Color.NavajoWhite
        Me.PanelMostrar.Controls.Add(Me.BtnCerrarM)
        Me.PanelMostrar.Controls.Add(Me.LblTotalM)
        Me.PanelMostrar.Controls.Add(Me.LblTotalImpuestoM)
        Me.PanelMostrar.Controls.Add(Me.LblSubTotalM)
        Me.PanelMostrar.Controls.Add(Me.Label8)
        Me.PanelMostrar.Controls.Add(Me.Label9)
        Me.PanelMostrar.Controls.Add(Me.Label10)
        Me.PanelMostrar.Controls.Add(Me.DgvMostrarDetalle)
        Me.PanelMostrar.Location = New System.Drawing.Point(378, 220)
        Me.PanelMostrar.Name = "PanelMostrar"
        Me.PanelMostrar.Size = New System.Drawing.Size(771, 344)
        Me.PanelMostrar.TabIndex = 8
        Me.PanelMostrar.Visible = False
        '
        'BtnCerrarM
        '
        Me.BtnCerrarM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarM.ForeColor = System.Drawing.Color.Red
        Me.BtnCerrarM.Location = New System.Drawing.Point(703, 16)
        Me.BtnCerrarM.Name = "BtnCerrarM"
        Me.BtnCerrarM.Size = New System.Drawing.Size(48, 37)
        Me.BtnCerrarM.TabIndex = 13
        Me.BtnCerrarM.Text = "X"
        Me.BtnCerrarM.UseVisualStyleBackColor = True
        '
        'LblTotalM
        '
        Me.LblTotalM.AutoSize = True
        Me.LblTotalM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalM.Location = New System.Drawing.Point(638, 294)
        Me.LblTotalM.Name = "LblTotalM"
        Me.LblTotalM.Size = New System.Drawing.Size(16, 16)
        Me.LblTotalM.TabIndex = 12
        Me.LblTotalM.Text = "0"
        '
        'LblTotalImpuestoM
        '
        Me.LblTotalImpuestoM.AutoSize = True
        Me.LblTotalImpuestoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalImpuestoM.Location = New System.Drawing.Point(638, 259)
        Me.LblTotalImpuestoM.Name = "LblTotalImpuestoM"
        Me.LblTotalImpuestoM.Size = New System.Drawing.Size(16, 16)
        Me.LblTotalImpuestoM.TabIndex = 11
        Me.LblTotalImpuestoM.Text = "0"
        '
        'LblSubTotalM
        '
        Me.LblSubTotalM.AutoSize = True
        Me.LblSubTotalM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTotalM.Location = New System.Drawing.Point(638, 229)
        Me.LblSubTotalM.Name = "LblSubTotalM"
        Me.LblSubTotalM.Size = New System.Drawing.Size(16, 16)
        Me.LblSubTotalM.TabIndex = 10
        Me.LblSubTotalM.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(520, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(520, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Total Impuesto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(520, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Sub Total"
        '
        'DgvMostrarDetalle
        '
        Me.DgvMostrarDetalle.AllowUserToAddRows = False
        Me.DgvMostrarDetalle.AllowUserToDeleteRows = False
        Me.DgvMostrarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMostrarDetalle.Location = New System.Drawing.Point(21, 59)
        Me.DgvMostrarDetalle.Name = "DgvMostrarDetalle"
        Me.DgvMostrarDetalle.ReadOnly = True
        Me.DgvMostrarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMostrarDetalle.Size = New System.Drawing.Size(730, 150)
        Me.DgvMostrarDetalle.TabIndex = 0
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.AllowUserToOrderColumns = True
        Me.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DgvListado.Location = New System.Drawing.Point(8, 87)
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(1141, 342)
        Me.DgvListado.TabIndex = 0
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(12, 26)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(1177, 637)
        Me.TabGeneral.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.TxtId)
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Controls.Add(Me.BtnInsertar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1169, 611)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PanelArticulos)
        Me.GroupBox2.Controls.Add(Me.BtnBuscarArticulos)
        Me.GroupBox2.Controls.Add(Me.TxtCodigo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.TxtTotalImpuesto)
        Me.GroupBox2.Controls.Add(Me.TxtSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DgvDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(912, 351)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'PanelArticulos
        '
        Me.PanelArticulos.BackColor = System.Drawing.Color.PaleTurquoise
        Me.PanelArticulos.Controls.Add(Me.BtnCerrar)
        Me.PanelArticulos.Controls.Add(Me.LblTotalArticulos)
        Me.PanelArticulos.Controls.Add(Me.DgvArticulos)
        Me.PanelArticulos.Controls.Add(Me.BtnBuscarArticulosDetalle)
        Me.PanelArticulos.Controls.Add(Me.TxtBuscarArticulos)
        Me.PanelArticulos.Location = New System.Drawing.Point(101, 59)
        Me.PanelArticulos.Name = "PanelArticulos"
        Me.PanelArticulos.Size = New System.Drawing.Size(773, 249)
        Me.PanelArticulos.TabIndex = 10
        Me.PanelArticulos.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Red
        Me.BtnCerrar.Location = New System.Drawing.Point(719, 16)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(35, 26)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.Text = "X"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'LblTotalArticulos
        '
        Me.LblTotalArticulos.AutoSize = True
        Me.LblTotalArticulos.Location = New System.Drawing.Point(648, 218)
        Me.LblTotalArticulos.Name = "LblTotalArticulos"
        Me.LblTotalArticulos.Size = New System.Drawing.Size(31, 13)
        Me.LblTotalArticulos.TabIndex = 3
        Me.LblTotalArticulos.Text = "Total"
        '
        'DgvArticulos
        '
        Me.DgvArticulos.AllowUserToAddRows = False
        Me.DgvArticulos.AllowUserToDeleteRows = False
        Me.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArticulos.Location = New System.Drawing.Point(22, 48)
        Me.DgvArticulos.Name = "DgvArticulos"
        Me.DgvArticulos.ReadOnly = True
        Me.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvArticulos.Size = New System.Drawing.Size(732, 150)
        Me.DgvArticulos.TabIndex = 2
        '
        'BtnBuscarArticulosDetalle
        '
        Me.BtnBuscarArticulosDetalle.Location = New System.Drawing.Point(388, 16)
        Me.BtnBuscarArticulosDetalle.Name = "BtnBuscarArticulosDetalle"
        Me.BtnBuscarArticulosDetalle.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarArticulosDetalle.TabIndex = 1
        Me.BtnBuscarArticulosDetalle.Text = "Buscar"
        Me.BtnBuscarArticulosDetalle.UseVisualStyleBackColor = True
        '
        'TxtBuscarArticulos
        '
        Me.TxtBuscarArticulos.Location = New System.Drawing.Point(22, 19)
        Me.TxtBuscarArticulos.Name = "TxtBuscarArticulos"
        Me.TxtBuscarArticulos.Size = New System.Drawing.Size(323, 20)
        Me.TxtBuscarArticulos.TabIndex = 0
        '
        'BtnBuscarArticulos
        '
        Me.BtnBuscarArticulos.Location = New System.Drawing.Point(464, 24)
        Me.BtnBuscarArticulos.Name = "BtnBuscarArticulos"
        Me.BtnBuscarArticulos.Size = New System.Drawing.Size(77, 23)
        Me.BtnBuscarArticulos.TabIndex = 9
        Me.BtnBuscarArticulos.Text = "Buscar"
        Me.BtnBuscarArticulos.UseVisualStyleBackColor = True
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(129, 27)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(317, 20)
        Me.TxtCodigo.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Código Artículo"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(767, 314)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 6
        '
        'TxtTotalImpuesto
        '
        Me.TxtTotalImpuesto.Location = New System.Drawing.Point(767, 279)
        Me.TxtTotalImpuesto.Name = "TxtTotalImpuesto"
        Me.TxtTotalImpuesto.ReadOnly = True
        Me.TxtTotalImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalImpuesto.TabIndex = 5
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Location = New System.Drawing.Point(767, 245)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtSubTotal.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(655, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(653, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total Impuesto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(653, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sub Total"
        '
        'DgvDetalle
        '
        Me.DgvDetalle.AllowUserToAddRows = False
        Me.DgvDetalle.AllowUserToOrderColumns = True
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Location = New System.Drawing.Point(29, 59)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalle.Size = New System.Drawing.Size(845, 164)
        Me.DgvDetalle.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtImpuesto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNumComprobante)
        Me.GroupBox1.Controls.Add(Me.CboTipoComprobante)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarProveedor)
        Me.GroupBox1.Controls.Add(Me.TxtNombreProveedor)
        Me.GroupBox1.Controls.Add(Me.TxtIdProveedor)
        Me.GroupBox1.Controls.Add(Me.TxtSerieComprobante)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(912, 120)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cabecera"
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Location = New System.Drawing.Point(744, 71)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.ReadOnly = True
        Me.TxtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.TxtImpuesto.TabIndex = 22
        Me.TxtImpuesto.Text = "0,18"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(664, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Impuesto"
        '
        'TxtNumComprobante
        '
        Me.TxtNumComprobante.Location = New System.Drawing.Point(455, 74)
        Me.TxtNumComprobante.Name = "TxtNumComprobante"
        Me.TxtNumComprobante.Size = New System.Drawing.Size(109, 20)
        Me.TxtNumComprobante.TabIndex = 20
        '
        'CboTipoComprobante
        '
        Me.CboTipoComprobante.FormattingEnabled = True
        Me.CboTipoComprobante.Items.AddRange(New Object() {"Factura", "Boleta", "Ticket"})
        Me.CboTipoComprobante.Location = New System.Drawing.Point(129, 74)
        Me.CboTipoComprobante.Name = "CboTipoComprobante"
        Me.CboTipoComprobante.Size = New System.Drawing.Size(158, 21)
        Me.CboTipoComprobante.TabIndex = 19
        Me.CboTipoComprobante.Text = "Boleta"
        '
        'BtnBuscarProveedor
        '
        Me.BtnBuscarProveedor.Location = New System.Drawing.Point(592, 37)
        Me.BtnBuscarProveedor.Name = "BtnBuscarProveedor"
        Me.BtnBuscarProveedor.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarProveedor.TabIndex = 18
        Me.BtnBuscarProveedor.Text = "..."
        Me.BtnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'TxtNombreProveedor
        '
        Me.TxtNombreProveedor.Location = New System.Drawing.Point(323, 39)
        Me.TxtNombreProveedor.Name = "TxtNombreProveedor"
        Me.TxtNombreProveedor.ReadOnly = True
        Me.TxtNombreProveedor.Size = New System.Drawing.Size(241, 20)
        Me.TxtNombreProveedor.TabIndex = 17
        '
        'TxtIdProveedor
        '
        Me.TxtIdProveedor.Location = New System.Drawing.Point(129, 39)
        Me.TxtIdProveedor.Name = "TxtIdProveedor"
        Me.TxtIdProveedor.ReadOnly = True
        Me.TxtIdProveedor.Size = New System.Drawing.Size(158, 20)
        Me.TxtIdProveedor.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Proveedor (*)"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(347, 16)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 6
        Me.TxtId.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(202, 570)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(123, 23)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Location = New System.Drawing.Point(41, 570)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(127, 23)
        Me.BtnInsertar.TabIndex = 0
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'FrmIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1227, 683)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "FrmIngreso"
        Me.Text = "Ingresos"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.PanelMostrar.ResumeLayout(False)
        Me.PanelMostrar.PerformLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelArticulos.ResumeLayout(False)
        Me.PanelArticulos.PerformLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TxtSerieComprobante As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAnular As Button
    Friend WithEvents ChkSeleccionar As CheckBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents Lbltotal As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CboTipoComprobante As ComboBox
    Friend WithEvents BtnBuscarProveedor As Button
    Friend WithEvents TxtNombreProveedor As TextBox
    Friend WithEvents TxtIdProveedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNumComprobante As TextBox
    Friend WithEvents TxtImpuesto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtTotalImpuesto As TextBox
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents BtnBuscarArticulos As Button
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelArticulos As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LblTotalArticulos As Label
    Friend WithEvents DgvArticulos As DataGridView
    Friend WithEvents BtnBuscarArticulosDetalle As Button
    Friend WithEvents TxtBuscarArticulos As TextBox
    Friend WithEvents PanelMostrar As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DgvMostrarDetalle As DataGridView
    Friend WithEvents BtnCerrarM As Button
    Friend WithEvents LblTotalM As Label
    Friend WithEvents LblTotalImpuestoM As Label
    Friend WithEvents LblSubTotalM As Label
End Class
