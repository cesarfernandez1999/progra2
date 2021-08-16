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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtchequesp = New System.Windows.Forms.TextBox()
        Me.txtchequeso = New System.Windows.Forms.TextBox()
        Me.txtefectivo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.saldoAnterior = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.saldoNuevo = New System.Windows.Forms.Label()
        Me.txtinteres = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Depósito"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Método de Depósito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(442, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Monto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(629, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Saldo Anterior"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(247, 104)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 21)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Cheques Propios"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(247, 163)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(172, 21)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Cheques otros bancos"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(247, 227)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(80, 21)
        Me.CheckBox3.TabIndex = 6
        Me.CheckBox3.Text = "Efectivo"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(53, 104)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(92, 21)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Monetario"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(53, 163)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(145, 21)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Monetario Premier"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(53, 227)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(79, 21)
        Me.RadioButton3.TabIndex = 9
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Ahorros"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(442, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Q"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(442, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Q"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(442, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Q"
        '
        'txtchequesp
        '
        Me.txtchequesp.Enabled = False
        Me.txtchequesp.Location = New System.Drawing.Point(467, 104)
        Me.txtchequesp.Name = "txtchequesp"
        Me.txtchequesp.Size = New System.Drawing.Size(100, 22)
        Me.txtchequesp.TabIndex = 13
        '
        'txtchequeso
        '
        Me.txtchequeso.Enabled = False
        Me.txtchequeso.Location = New System.Drawing.Point(467, 164)
        Me.txtchequeso.Name = "txtchequeso"
        Me.txtchequeso.Size = New System.Drawing.Size(100, 22)
        Me.txtchequeso.TabIndex = 14
        '
        'txtefectivo
        '
        Me.txtefectivo.Enabled = False
        Me.txtefectivo.Location = New System.Drawing.Point(467, 225)
        Me.txtefectivo.Name = "txtefectivo"
        Me.txtefectivo.Size = New System.Drawing.Size(100, 22)
        Me.txtefectivo.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(629, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Q"
        '
        'saldoAnterior
        '
        Me.saldoAnterior.Location = New System.Drawing.Point(654, 102)
        Me.saldoAnterior.Name = "saldoAnterior"
        Me.saldoAnterior.Size = New System.Drawing.Size(100, 22)
        Me.saldoAnterior.TabIndex = 17
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(652, 167)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 18
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Saldo Nuevo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(53, 313)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Interés:"
        '
        'saldoNuevo
        '
        Me.saldoNuevo.AutoSize = True
        Me.saldoNuevo.Location = New System.Drawing.Point(150, 278)
        Me.saldoNuevo.Name = "saldoNuevo"
        Me.saldoNuevo.Size = New System.Drawing.Size(16, 17)
        Me.saldoNuevo.TabIndex = 21
        Me.saldoNuevo.Text = "0"
        '
        'txtinteres
        '
        Me.txtinteres.AutoSize = True
        Me.txtinteres.Location = New System.Drawing.Point(150, 313)
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(16, 17)
        Me.txtinteres.TabIndex = 22
        Me.txtinteres.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 363)
        Me.Controls.Add(Me.txtinteres)
        Me.Controls.Add(Me.saldoNuevo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.saldoAnterior)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtefectivo)
        Me.Controls.Add(Me.txtchequeso)
        Me.Controls.Add(Me.txtchequesp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Banco"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtchequesp As TextBox
    Friend WithEvents txtchequeso As TextBox
    Friend WithEvents txtefectivo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents saldoAnterior As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents saldoNuevo As Label
    Friend WithEvents txtinteres As Label
End Class
