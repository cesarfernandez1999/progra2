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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cine = New System.Windows.Forms.ListBox()
        Me.Funcion = New System.Windows.Forms.ListBox()
        Me.SubTotal = New System.Windows.Forms.ListBox()
        Me.Descuento1 = New System.Windows.Forms.ListBox()
        Me.Descuento2 = New System.Windows.Forms.ListBox()
        Me.Total = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.ComboBox1.Location = New System.Drawing.Point(148, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBox2.Location = New System.Drawing.Point(148, 80)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 186)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Eija cine y función"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Lime
        Me.GroupBox2.Controls.Add(Me.Total)
        Me.GroupBox2.Controls.Add(Me.Descuento2)
        Me.GroupBox2.Controls.Add(Me.Descuento1)
        Me.GroupBox2.Controls.Add(Me.SubTotal)
        Me.GroupBox2.Controls.Add(Me.Funcion)
        Me.GroupBox2.Controls.Add(Me.Cine)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 258)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(767, 166)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cine:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Función:"
        '
        'Cine
        '
        Me.Cine.FormattingEnabled = True
        Me.Cine.ItemHeight = 16
        Me.Cine.Location = New System.Drawing.Point(11, 48)
        Me.Cine.Name = "Cine"
        Me.Cine.Size = New System.Drawing.Size(120, 84)
        Me.Cine.TabIndex = 0
        '
        'Funcion
        '
        Me.Funcion.FormattingEnabled = True
        Me.Funcion.ItemHeight = 16
        Me.Funcion.Location = New System.Drawing.Point(137, 48)
        Me.Funcion.Name = "Funcion"
        Me.Funcion.Size = New System.Drawing.Size(120, 84)
        Me.Funcion.TabIndex = 1
        '
        'SubTotal
        '
        Me.SubTotal.FormattingEnabled = True
        Me.SubTotal.ItemHeight = 16
        Me.SubTotal.Location = New System.Drawing.Point(263, 48)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Size = New System.Drawing.Size(120, 84)
        Me.SubTotal.TabIndex = 2
        '
        'Descuento1
        '
        Me.Descuento1.FormattingEnabled = True
        Me.Descuento1.ItemHeight = 16
        Me.Descuento1.Location = New System.Drawing.Point(389, 48)
        Me.Descuento1.Name = "Descuento1"
        Me.Descuento1.Size = New System.Drawing.Size(120, 84)
        Me.Descuento1.TabIndex = 3
        '
        'Descuento2
        '
        Me.Descuento2.FormattingEnabled = True
        Me.Descuento2.ItemHeight = 16
        Me.Descuento2.Location = New System.Drawing.Point(515, 48)
        Me.Descuento2.Name = "Descuento2"
        Me.Descuento2.Size = New System.Drawing.Size(120, 84)
        Me.Descuento2.TabIndex = 4
        '
        'Total
        '
        Me.Total.FormattingEnabled = True
        Me.Total.ItemHeight = 16
        Me.Total.Location = New System.Drawing.Point(641, 48)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(120, 84)
        Me.Total.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(479, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(611, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 41)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Limpiar Entradas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ComboBox3.Location = New System.Drawing.Point(148, 143)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Total As ListBox
    Friend WithEvents Descuento2 As ListBox
    Friend WithEvents Descuento1 As ListBox
    Friend WithEvents SubTotal As ListBox
    Friend WithEvents Funcion As ListBox
    Friend WithEvents Cine As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox3 As ComboBox
End Class
