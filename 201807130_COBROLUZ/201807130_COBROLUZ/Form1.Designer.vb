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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtNIT = New System.Windows.Forms.TextBox()
        Me.txtsaldoanterior = New System.Windows.Forms.TextBox()
        Me.txtwatts = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox_Servicio = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Tarifa = New System.Windows.Forms.ComboBox()
        Me.List_Cliente = New System.Windows.Forms.ListBox()
        Me.List_Servicio = New System.Windows.Forms.ListBox()
        Me.List_Tarifa = New System.Windows.Forms.ListBox()
        Me.List_SaldoAnt = New System.Windows.Forms.ListBox()
        Me.List_PagoIn = New System.Windows.Forms.ListBox()
        Me.List_Mora = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.List_PagoMora = New System.Windows.Forms.ListBox()
        Me.List_PagoParcial = New System.Windows.Forms.ListBox()
        Me.List_Desc = New System.Windows.Forms.ListBox()
        Me.List_Total = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1298, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtwatts)
        Me.GroupBox1.Controls.Add(Me.txtsaldoanterior)
        Me.GroupBox1.Controls.Add(Me.txtNIT)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(267, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Ingreso"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.ComboBox_Tarifa)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Servicio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(731, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Servicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIT:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Saldo Anterior:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Consumo de kW:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(63, 21)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 22)
        Me.txtnombre.TabIndex = 4
        '
        'txtNIT
        '
        Me.txtNIT.Location = New System.Drawing.Point(50, 60)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.Size = New System.Drawing.Size(100, 22)
        Me.txtNIT.TabIndex = 5
        '
        'txtsaldoanterior
        '
        Me.txtsaldoanterior.Location = New System.Drawing.Point(268, 19)
        Me.txtsaldoanterior.Name = "txtsaldoanterior"
        Me.txtsaldoanterior.Size = New System.Drawing.Size(100, 22)
        Me.txtsaldoanterior.TabIndex = 6
        '
        'txtwatts
        '
        Me.txtwatts.Location = New System.Drawing.Point(268, 60)
        Me.txtwatts.Name = "txtwatts"
        Me.txtwatts.Size = New System.Drawing.Size(100, 22)
        Me.txtwatts.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tipo de servicio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tipo de tarifa:"
        '
        'ComboBox_Servicio
        '
        Me.ComboBox_Servicio.FormattingEnabled = True
        Me.ComboBox_Servicio.Items.AddRange(New Object() {"Residencial", "Industrial"})
        Me.ComboBox_Servicio.Location = New System.Drawing.Point(121, 27)
        Me.ComboBox_Servicio.Name = "ComboBox_Servicio"
        Me.ComboBox_Servicio.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox_Servicio.TabIndex = 9
        '
        'ComboBox_Tarifa
        '
        Me.ComboBox_Tarifa.FormattingEnabled = True
        Me.ComboBox_Tarifa.Items.AddRange(New Object() {"Social", "No Social"})
        Me.ComboBox_Tarifa.Location = New System.Drawing.Point(121, 65)
        Me.ComboBox_Tarifa.Name = "ComboBox_Tarifa"
        Me.ComboBox_Tarifa.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox_Tarifa.TabIndex = 10
        '
        'List_Cliente
        '
        Me.List_Cliente.FormattingEnabled = True
        Me.List_Cliente.ItemHeight = 16
        Me.List_Cliente.Location = New System.Drawing.Point(6, 65)
        Me.List_Cliente.Name = "List_Cliente"
        Me.List_Cliente.Size = New System.Drawing.Size(120, 84)
        Me.List_Cliente.TabIndex = 3
        '
        'List_Servicio
        '
        Me.List_Servicio.FormattingEnabled = True
        Me.List_Servicio.ItemHeight = 16
        Me.List_Servicio.Location = New System.Drawing.Point(132, 65)
        Me.List_Servicio.Name = "List_Servicio"
        Me.List_Servicio.Size = New System.Drawing.Size(120, 84)
        Me.List_Servicio.TabIndex = 4
        '
        'List_Tarifa
        '
        Me.List_Tarifa.FormattingEnabled = True
        Me.List_Tarifa.ItemHeight = 16
        Me.List_Tarifa.Location = New System.Drawing.Point(258, 65)
        Me.List_Tarifa.Name = "List_Tarifa"
        Me.List_Tarifa.Size = New System.Drawing.Size(120, 84)
        Me.List_Tarifa.TabIndex = 5
        '
        'List_SaldoAnt
        '
        Me.List_SaldoAnt.FormattingEnabled = True
        Me.List_SaldoAnt.ItemHeight = 16
        Me.List_SaldoAnt.Location = New System.Drawing.Point(384, 65)
        Me.List_SaldoAnt.Name = "List_SaldoAnt"
        Me.List_SaldoAnt.Size = New System.Drawing.Size(120, 84)
        Me.List_SaldoAnt.TabIndex = 6
        '
        'List_PagoIn
        '
        Me.List_PagoIn.FormattingEnabled = True
        Me.List_PagoIn.ItemHeight = 16
        Me.List_PagoIn.Location = New System.Drawing.Point(510, 65)
        Me.List_PagoIn.Name = "List_PagoIn"
        Me.List_PagoIn.Size = New System.Drawing.Size(120, 84)
        Me.List_PagoIn.TabIndex = 7
        '
        'List_Mora
        '
        Me.List_Mora.FormattingEnabled = True
        Me.List_Mora.ItemHeight = 16
        Me.List_Mora.Location = New System.Drawing.Point(636, 65)
        Me.List_Mora.Name = "List_Mora"
        Me.List_Mora.Size = New System.Drawing.Size(120, 84)
        Me.List_Mora.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.List_Total)
        Me.GroupBox3.Controls.Add(Me.List_Desc)
        Me.GroupBox3.Controls.Add(Me.List_PagoParcial)
        Me.GroupBox3.Controls.Add(Me.List_PagoMora)
        Me.GroupBox3.Controls.Add(Me.List_Cliente)
        Me.GroupBox3.Controls.Add(Me.List_Mora)
        Me.GroupBox3.Controls.Add(Me.List_Servicio)
        Me.GroupBox3.Controls.Add(Me.List_PagoIn)
        Me.GroupBox3.Controls.Add(Me.List_Tarifa)
        Me.GroupBox3.Controls.Add(Me.List_SaldoAnt)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 218)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1274, 165)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultados"
        '
        'List_PagoMora
        '
        Me.List_PagoMora.FormattingEnabled = True
        Me.List_PagoMora.ItemHeight = 16
        Me.List_PagoMora.Location = New System.Drawing.Point(762, 65)
        Me.List_PagoMora.Name = "List_PagoMora"
        Me.List_PagoMora.Size = New System.Drawing.Size(120, 84)
        Me.List_PagoMora.TabIndex = 9
        '
        'List_PagoParcial
        '
        Me.List_PagoParcial.FormattingEnabled = True
        Me.List_PagoParcial.ItemHeight = 16
        Me.List_PagoParcial.Location = New System.Drawing.Point(888, 65)
        Me.List_PagoParcial.Name = "List_PagoParcial"
        Me.List_PagoParcial.Size = New System.Drawing.Size(120, 84)
        Me.List_PagoParcial.TabIndex = 10
        '
        'List_Desc
        '
        Me.List_Desc.FormattingEnabled = True
        Me.List_Desc.ItemHeight = 16
        Me.List_Desc.Location = New System.Drawing.Point(1014, 65)
        Me.List_Desc.Name = "List_Desc"
        Me.List_Desc.Size = New System.Drawing.Size(120, 84)
        Me.List_Desc.TabIndex = 11
        '
        'List_Total
        '
        Me.List_Total.FormattingEnabled = True
        Me.List_Total.ItemHeight = 16
        Me.List_Total.Location = New System.Drawing.Point(1140, 65)
        Me.List_Total.Name = "List_Total"
        Me.List_Total.Size = New System.Drawing.Size(120, 84)
        Me.List_Total.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(129, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Tipo de servicio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(257, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Tipo de tarifa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(381, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Saldo anterior"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(507, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Pago inicial"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(633, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 17)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Mora"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(759, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 17)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Pago con mora"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(885, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 17)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Pago parcial"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1011, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 17)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Descuento"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1137, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 17)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Pago total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1298, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtwatts As TextBox
    Friend WithEvents txtsaldoanterior As TextBox
    Friend WithEvents txtNIT As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_Tarifa As ComboBox
    Friend WithEvents ComboBox_Servicio As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents List_Cliente As ListBox
    Friend WithEvents List_Servicio As ListBox
    Friend WithEvents List_Tarifa As ListBox
    Friend WithEvents List_SaldoAnt As ListBox
    Friend WithEvents List_PagoIn As ListBox
    Friend WithEvents List_Mora As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents List_Total As ListBox
    Friend WithEvents List_Desc As ListBox
    Friend WithEvents List_PagoParcial As ListBox
    Friend WithEvents List_PagoMora As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
