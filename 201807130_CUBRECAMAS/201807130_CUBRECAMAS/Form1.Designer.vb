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
        Me.Imperial = New System.Windows.Forms.RadioButton()
        Me.Matrimonial = New System.Windows.Forms.RadioButton()
        Me.Queen = New System.Windows.Forms.RadioButton()
        Me.King = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLino = New System.Windows.Forms.TextBox()
        Me.txtAlgodon = New System.Windows.Forms.TextBox()
        Me.txtSeda = New System.Windows.Forms.TextBox()
        Me.txtHiloCrudo = New System.Windows.Forms.TextBox()
        Me.Lino = New System.Windows.Forms.CheckBox()
        Me.Algodón = New System.Windows.Forms.CheckBox()
        Me.Seda = New System.Windows.Forms.CheckBox()
        Me.HiloCrudo = New System.Windows.Forms.CheckBox()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblprecioCosto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblprecioVenta = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblprecioHilo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblprecioSeda = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblprecioAlgodon = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblprecioLino = New System.Windows.Forms.Label()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Imperial)
        Me.GroupBox1.Controls.Add(Me.Matrimonial)
        Me.GroupBox1.Controls.Add(Me.Queen)
        Me.GroupBox1.Controls.Add(Me.King)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño"
        '
        'Imperial
        '
        Me.Imperial.AutoSize = True
        Me.Imperial.Location = New System.Drawing.Point(7, 103)
        Me.Imperial.Name = "Imperial"
        Me.Imperial.Size = New System.Drawing.Size(78, 21)
        Me.Imperial.TabIndex = 3
        Me.Imperial.TabStop = True
        Me.Imperial.Text = "Imperial"
        Me.Imperial.UseVisualStyleBackColor = True
        '
        'Matrimonial
        '
        Me.Matrimonial.AutoSize = True
        Me.Matrimonial.Location = New System.Drawing.Point(7, 76)
        Me.Matrimonial.Name = "Matrimonial"
        Me.Matrimonial.Size = New System.Drawing.Size(101, 21)
        Me.Matrimonial.TabIndex = 2
        Me.Matrimonial.TabStop = True
        Me.Matrimonial.Text = "Matrimonial"
        Me.Matrimonial.UseVisualStyleBackColor = True
        '
        'Queen
        '
        Me.Queen.AutoSize = True
        Me.Queen.Location = New System.Drawing.Point(7, 49)
        Me.Queen.Name = "Queen"
        Me.Queen.Size = New System.Drawing.Size(72, 21)
        Me.Queen.TabIndex = 1
        Me.Queen.TabStop = True
        Me.Queen.Text = "Queen"
        Me.Queen.UseVisualStyleBackColor = True
        '
        'King
        '
        Me.King.AutoSize = True
        Me.King.Location = New System.Drawing.Point(7, 22)
        Me.King.Name = "King"
        Me.King.Size = New System.Drawing.Size(57, 21)
        Me.King.TabIndex = 0
        Me.King.TabStop = True
        Me.King.Text = "King"
        Me.King.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.txtLino)
        Me.GroupBox2.Controls.Add(Me.txtAlgodon)
        Me.GroupBox2.Controls.Add(Me.txtSeda)
        Me.GroupBox2.Controls.Add(Me.txtHiloCrudo)
        Me.GroupBox2.Controls.Add(Me.Lino)
        Me.GroupBox2.Controls.Add(Me.Algodón)
        Me.GroupBox2.Controls.Add(Me.Seda)
        Me.GroupBox2.Controls.Add(Me.HiloCrudo)
        Me.GroupBox2.Location = New System.Drawing.Point(308, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 192)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material"
        '
        'txtLino
        '
        Me.txtLino.Enabled = False
        Me.txtLino.Location = New System.Drawing.Point(172, 151)
        Me.txtLino.Name = "txtLino"
        Me.txtLino.Size = New System.Drawing.Size(100, 22)
        Me.txtLino.TabIndex = 7
        Me.txtLino.Text = "0"
        '
        'txtAlgodon
        '
        Me.txtAlgodon.Enabled = False
        Me.txtAlgodon.Location = New System.Drawing.Point(172, 108)
        Me.txtAlgodon.Name = "txtAlgodon"
        Me.txtAlgodon.Size = New System.Drawing.Size(100, 22)
        Me.txtAlgodon.TabIndex = 6
        Me.txtAlgodon.Text = "0"
        '
        'txtSeda
        '
        Me.txtSeda.Enabled = False
        Me.txtSeda.Location = New System.Drawing.Point(172, 64)
        Me.txtSeda.Name = "txtSeda"
        Me.txtSeda.Size = New System.Drawing.Size(100, 22)
        Me.txtSeda.TabIndex = 5
        Me.txtSeda.Text = "0"
        '
        'txtHiloCrudo
        '
        Me.txtHiloCrudo.Enabled = False
        Me.txtHiloCrudo.Location = New System.Drawing.Point(172, 22)
        Me.txtHiloCrudo.Name = "txtHiloCrudo"
        Me.txtHiloCrudo.Size = New System.Drawing.Size(100, 22)
        Me.txtHiloCrudo.TabIndex = 4
        Me.txtHiloCrudo.Text = "0"
        '
        'Lino
        '
        Me.Lino.AutoSize = True
        Me.Lino.Location = New System.Drawing.Point(7, 152)
        Me.Lino.Name = "Lino"
        Me.Lino.Size = New System.Drawing.Size(57, 21)
        Me.Lino.TabIndex = 3
        Me.Lino.Text = "Lino"
        Me.Lino.UseVisualStyleBackColor = True
        '
        'Algodón
        '
        Me.Algodón.AutoSize = True
        Me.Algodón.Location = New System.Drawing.Point(6, 109)
        Me.Algodón.Name = "Algodón"
        Me.Algodón.Size = New System.Drawing.Size(82, 21)
        Me.Algodón.TabIndex = 2
        Me.Algodón.Text = "Algodón"
        Me.Algodón.UseVisualStyleBackColor = True
        '
        'Seda
        '
        Me.Seda.AutoSize = True
        Me.Seda.Location = New System.Drawing.Point(7, 66)
        Me.Seda.Name = "Seda"
        Me.Seda.Size = New System.Drawing.Size(63, 21)
        Me.Seda.TabIndex = 1
        Me.Seda.Text = "Seda"
        Me.Seda.UseVisualStyleBackColor = True
        '
        'HiloCrudo
        '
        Me.HiloCrudo.AutoSize = True
        Me.HiloCrudo.Location = New System.Drawing.Point(7, 22)
        Me.HiloCrudo.Name = "HiloCrudo"
        Me.HiloCrudo.Size = New System.Drawing.Size(96, 21)
        Me.HiloCrudo.TabIndex = 0
        Me.HiloCrudo.Text = "Hilo Crudo"
        Me.HiloCrudo.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(308, 253)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(88, 34)
        Me.Aceptar.TabIndex = 2
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Precio de Costo: Q."
        '
        'lblprecioCosto
        '
        Me.lblprecioCosto.AutoSize = True
        Me.lblprecioCosto.Location = New System.Drawing.Point(167, 219)
        Me.lblprecioCosto.Name = "lblprecioCosto"
        Me.lblprecioCosto.Size = New System.Drawing.Size(36, 17)
        Me.lblprecioCosto.TabIndex = 4
        Me.lblprecioCosto.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Precio de Venta: Q."
        '
        'lblprecioVenta
        '
        Me.lblprecioVenta.AutoSize = True
        Me.lblprecioVenta.Location = New System.Drawing.Point(167, 253)
        Me.lblprecioVenta.Name = "lblprecioVenta"
        Me.lblprecioVenta.Size = New System.Drawing.Size(36, 17)
        Me.lblprecioVenta.TabIndex = 6
        Me.lblprecioVenta.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Precio de Hilo Crudo: Q."
        '
        'lblprecioHilo
        '
        Me.lblprecioHilo.AutoSize = True
        Me.lblprecioHilo.Location = New System.Drawing.Point(167, 286)
        Me.lblprecioHilo.Name = "lblprecioHilo"
        Me.lblprecioHilo.Size = New System.Drawing.Size(36, 17)
        Me.lblprecioHilo.TabIndex = 8
        Me.lblprecioHilo.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Precio de Seda: Q."
        '
        'lblprecioSeda
        '
        Me.lblprecioSeda.AutoSize = True
        Me.lblprecioSeda.Location = New System.Drawing.Point(167, 319)
        Me.lblprecioSeda.Name = "lblprecioSeda"
        Me.lblprecioSeda.Size = New System.Drawing.Size(36, 17)
        Me.lblprecioSeda.TabIndex = 10
        Me.lblprecioSeda.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Precio de Algodón: Q."
        '
        'lblprecioAlgodon
        '
        Me.lblprecioAlgodon.AutoSize = True
        Me.lblprecioAlgodon.Location = New System.Drawing.Point(167, 351)
        Me.lblprecioAlgodon.Name = "lblprecioAlgodon"
        Me.lblprecioAlgodon.Size = New System.Drawing.Size(36, 17)
        Me.lblprecioAlgodon.TabIndex = 12
        Me.lblprecioAlgodon.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 381)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Precio de Lino: Q."
        '
        'lblprecioLino
        '
        Me.lblprecioLino.AutoSize = True
        Me.lblprecioLino.Location = New System.Drawing.Point(167, 381)
        Me.lblprecioLino.Name = "lblprecioLino"
        Me.lblprecioLino.Size = New System.Drawing.Size(36, 17)
        Me.lblprecioLino.TabIndex = 14
        Me.lblprecioLino.Text = "0.00"
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(443, 253)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(91, 34)
        Me.Limpiar.TabIndex = 15
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(576, 253)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(88, 33)
        Me.Salir.TabIndex = 16
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.lblprecioLino)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblprecioAlgodon)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblprecioSeda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblprecioHilo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblprecioVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblprecioCosto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Imperial As RadioButton
    Friend WithEvents Matrimonial As RadioButton
    Friend WithEvents Queen As RadioButton
    Friend WithEvents King As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lino As CheckBox
    Friend WithEvents Algodón As CheckBox
    Friend WithEvents Seda As CheckBox
    Friend WithEvents HiloCrudo As CheckBox
    Friend WithEvents txtLino As TextBox
    Friend WithEvents txtAlgodon As TextBox
    Friend WithEvents txtSeda As TextBox
    Friend WithEvents txtHiloCrudo As TextBox
    Friend WithEvents Aceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblprecioCosto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblprecioVenta As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblprecioHilo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblprecioSeda As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblprecioAlgodon As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblprecioLino As Label
    Friend WithEvents Limpiar As Button
    Friend WithEvents Salir As Button
End Class
