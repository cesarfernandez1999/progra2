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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProcesarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.txtplaca = New System.Windows.Forms.TextBox()
        Me.txtdias = New System.Windows.Forms.TextBox()
        Me.txtefectivo = New System.Windows.Forms.TextBox()
        Me.txttarjeta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbmarca = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox_placa = New System.Windows.Forms.ListBox()
        Me.ListBox_marca = New System.Windows.Forms.ListBox()
        Me.ListBox_dias = New System.Windows.Forms.ListBox()
        Me.ListBox_pagoparcial = New System.Windows.Forms.ListBox()
        Me.ListBox_descuento = New System.Windows.Forms.ListBox()
        Me.ListBox_pagofinal = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbmarca)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txttarjeta)
        Me.GroupBox1.Controls.Add(Me.txtefectivo)
        Me.GroupBox1.Controls.Add(Me.txtdias)
        Me.GroupBox1.Controls.Add(Me.txtplaca)
        Me.GroupBox1.Controls.Add(Me.txtnit)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 354)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ListBox_pagofinal)
        Me.GroupBox2.Controls.Add(Me.ListBox_descuento)
        Me.GroupBox2.Controls.Add(Me.ListBox_pagoparcial)
        Me.GroupBox2.Controls.Add(Me.ListBox_dias)
        Me.GroupBox2.Controls.Add(Me.ListBox_marca)
        Me.GroupBox2.Controls.Add(Me.ListBox_placa)
        Me.GroupBox2.Location = New System.Drawing.Point(429, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 376)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcesarToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProcesarToolStripMenuItem
        '
        Me.ProcesarToolStripMenuItem.Name = "ProcesarToolStripMenuItem"
        Me.ProcesarToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.ProcesarToolStripMenuItem.Text = "Procesar"
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 240)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 21)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Efectivo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(11, 293)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(75, 21)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Tarjeta"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(115, 29)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(100, 22)
        Me.txtnit.TabIndex = 2
        '
        'txtplaca
        '
        Me.txtplaca.Location = New System.Drawing.Point(115, 63)
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Size = New System.Drawing.Size(100, 22)
        Me.txtplaca.TabIndex = 3
        '
        'txtdias
        '
        Me.txtdias.Location = New System.Drawing.Point(137, 139)
        Me.txtdias.Name = "txtdias"
        Me.txtdias.Size = New System.Drawing.Size(100, 22)
        Me.txtdias.TabIndex = 4
        '
        'txtefectivo
        '
        Me.txtefectivo.Location = New System.Drawing.Point(115, 239)
        Me.txtefectivo.Name = "txtefectivo"
        Me.txtefectivo.Size = New System.Drawing.Size(100, 22)
        Me.txtefectivo.TabIndex = 5
        '
        'txttarjeta
        '
        Me.txttarjeta.Location = New System.Drawing.Point(115, 293)
        Me.txttarjeta.Name = "txttarjeta"
        Me.txttarjeta.Size = New System.Drawing.Size(100, 22)
        Me.txttarjeta.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NIT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Placa del auto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Marca:"
        '
        'cbmarca
        '
        Me.cbmarca.FormattingEnabled = True
        Me.cbmarca.Items.AddRange(New Object() {"Honda", "Mercedes Benz", "Toyota", "Mazda"})
        Me.cbmarca.Location = New System.Drawing.Point(116, 94)
        Me.cbmarca.Name = "cbmarca"
        Me.cbmarca.Size = New System.Drawing.Size(121, 24)
        Me.cbmarca.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cantidad de dias:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Forma de Pago:"
        '
        'ListBox_placa
        '
        Me.ListBox_placa.FormattingEnabled = True
        Me.ListBox_placa.ItemHeight = 16
        Me.ListBox_placa.Location = New System.Drawing.Point(18, 47)
        Me.ListBox_placa.Name = "ListBox_placa"
        Me.ListBox_placa.Size = New System.Drawing.Size(120, 84)
        Me.ListBox_placa.TabIndex = 0
        '
        'ListBox_marca
        '
        Me.ListBox_marca.FormattingEnabled = True
        Me.ListBox_marca.ItemHeight = 16
        Me.ListBox_marca.Location = New System.Drawing.Point(213, 47)
        Me.ListBox_marca.Name = "ListBox_marca"
        Me.ListBox_marca.Size = New System.Drawing.Size(120, 84)
        Me.ListBox_marca.TabIndex = 1
        '
        'ListBox_dias
        '
        Me.ListBox_dias.FormattingEnabled = True
        Me.ListBox_dias.ItemHeight = 16
        Me.ListBox_dias.Location = New System.Drawing.Point(18, 154)
        Me.ListBox_dias.Name = "ListBox_dias"
        Me.ListBox_dias.Size = New System.Drawing.Size(120, 84)
        Me.ListBox_dias.TabIndex = 2
        '
        'ListBox_pagoparcial
        '
        Me.ListBox_pagoparcial.FormattingEnabled = True
        Me.ListBox_pagoparcial.ItemHeight = 16
        Me.ListBox_pagoparcial.Location = New System.Drawing.Point(213, 154)
        Me.ListBox_pagoparcial.Name = "ListBox_pagoparcial"
        Me.ListBox_pagoparcial.Size = New System.Drawing.Size(120, 84)
        Me.ListBox_pagoparcial.TabIndex = 3
        '
        'ListBox_descuento
        '
        Me.ListBox_descuento.FormattingEnabled = True
        Me.ListBox_descuento.ItemHeight = 16
        Me.ListBox_descuento.Location = New System.Drawing.Point(18, 270)
        Me.ListBox_descuento.Name = "ListBox_descuento"
        Me.ListBox_descuento.Size = New System.Drawing.Size(120, 84)
        Me.ListBox_descuento.TabIndex = 4
        '
        'ListBox_pagofinal
        '
        Me.ListBox_pagofinal.FormattingEnabled = True
        Me.ListBox_pagofinal.ItemHeight = 16
        Me.ListBox_pagofinal.Location = New System.Drawing.Point(213, 270)
        Me.ListBox_pagofinal.Name = "ListBox_pagofinal"
        Me.ListBox_pagofinal.Size = New System.Drawing.Size(120, 84)
        Me.ListBox_pagofinal.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Placa del auto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(210, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Marca:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Cantidad de dias:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(210, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Pago Parcial:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Descuento:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(210, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Pago Final:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbmarca As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttarjeta As TextBox
    Friend WithEvents txtefectivo As TextBox
    Friend WithEvents txtdias As TextBox
    Friend WithEvents txtplaca As TextBox
    Friend WithEvents txtnit As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBox_pagofinal As ListBox
    Friend WithEvents ListBox_descuento As ListBox
    Friend WithEvents ListBox_pagoparcial As ListBox
    Friend WithEvents ListBox_dias As ListBox
    Friend WithEvents ListBox_marca As ListBox
    Friend WithEvents ListBox_placa As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProcesarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
