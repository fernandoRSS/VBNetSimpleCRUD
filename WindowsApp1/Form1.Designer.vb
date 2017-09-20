<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtidade = New System.Windows.Forms.TextBox()
        Me.Grid1 = New System.Windows.Forms.DataGridView()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Idade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtpeso = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtaltura = New System.Windows.Forms.MaskedTextBox()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 69)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtidade
        '
        Me.txtidade.Location = New System.Drawing.Point(12, 61)
        Me.txtidade.MaxLength = 3
        Me.txtidade.Name = "txtidade"
        Me.txtidade.Size = New System.Drawing.Size(66, 26)
        Me.txtidade.TabIndex = 2
        '
        'Grid1
        '
        Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nome, Me.Idade, Me.Peso, Me.Altura})
        Me.Grid1.Location = New System.Drawing.Point(245, 12)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RowTemplate.Height = 28
        Me.Grid1.Size = New System.Drawing.Size(727, 386)
        Me.Grid1.TabIndex = 7
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        '
        'Idade
        '
        Me.Idade.HeaderText = "Idade"
        Me.Idade.Name = "Idade"
        '
        'Peso
        '
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        '
        'Altura
        '
        Me.Altura.HeaderText = "Altura"
        Me.Altura.Name = "Altura"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 69)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Refresh Grid"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtpeso
        '
        Me.txtpeso.Location = New System.Drawing.Point(12, 93)
        Me.txtpeso.MaxLength = 3
        Me.txtpeso.Name = "txtpeso"
        Me.txtpeso.Size = New System.Drawing.Size(66, 26)
        Me.txtpeso.TabIndex = 3
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(12, 29)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(227, 26)
        Me.txtnome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Idade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Peso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Altura"
        '
        'txtaltura
        '
        Me.txtaltura.Location = New System.Drawing.Point(12, 128)
        Me.txtaltura.Mask = "0.00"
        Me.txtaltura.Name = "txtaltura"
        Me.txtaltura.Size = New System.Drawing.Size(66, 26)
        Me.txtaltura.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 410)
        Me.Controls.Add(Me.txtaltura)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.txtpeso)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.txtidade)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtidade As TextBox
    Friend WithEvents Grid1 As DataGridView
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Idade As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents Altura As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents txtpeso As TextBox
    Friend WithEvents txtnome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtaltura As MaskedTextBox
End Class
