<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddEntreprise
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddEntreprise))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnValid = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.tbMail = New System.Windows.Forms.TextBox()
        Me.tbTel = New System.Windows.Forms.TextBox()
        Me.tbVille = New System.Windows.Forms.TextBox()
        Me.tbCp = New System.Windows.Forms.TextBox()
        Me.tbAdr = New System.Windows.Forms.TextBox()
        Me.cbPays = New System.Windows.Forms.ComboBox()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom :"
        '
        'btnValid
        '
        Me.btnValid.Location = New System.Drawing.Point(6, 258)
        Me.btnValid.Name = "btnValid"
        Me.btnValid.Size = New System.Drawing.Size(267, 23)
        Me.btnValid.TabIndex = 8
        Me.btnValid.Text = "Validez"
        Me.btnValid.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMsg)
        Me.GroupBox1.Controls.Add(Me.btnValid)
        Me.GroupBox1.Controls.Add(Me.tbMail)
        Me.GroupBox1.Controls.Add(Me.tbTel)
        Me.GroupBox1.Controls.Add(Me.tbVille)
        Me.GroupBox1.Controls.Add(Me.tbCp)
        Me.GroupBox1.Controls.Add(Me.tbAdr)
        Me.GroupBox1.Controls.Add(Me.cbPays)
        Me.GroupBox1.Controls.Add(Me.tbNom)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 287)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajoutez une entreprise"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(9, 230)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(180, 13)
        Me.lblMsg.TabIndex = 3
        Me.lblMsg.Text = "Entrez les informations de l'entreprise"
        '
        'tbMail
        '
        Me.tbMail.Location = New System.Drawing.Point(109, 161)
        Me.tbMail.Name = "tbMail"
        Me.tbMail.Size = New System.Drawing.Size(167, 20)
        Me.tbMail.TabIndex = 6
        '
        'tbTel
        '
        Me.tbTel.Location = New System.Drawing.Point(109, 135)
        Me.tbTel.Name = "tbTel"
        Me.tbTel.Size = New System.Drawing.Size(167, 20)
        Me.tbTel.TabIndex = 5
        '
        'tbVille
        '
        Me.tbVille.Location = New System.Drawing.Point(109, 109)
        Me.tbVille.Name = "tbVille"
        Me.tbVille.Size = New System.Drawing.Size(167, 20)
        Me.tbVille.TabIndex = 4
        '
        'tbCp
        '
        Me.tbCp.Location = New System.Drawing.Point(109, 83)
        Me.tbCp.Name = "tbCp"
        Me.tbCp.Size = New System.Drawing.Size(167, 20)
        Me.tbCp.TabIndex = 3
        '
        'tbAdr
        '
        Me.tbAdr.Location = New System.Drawing.Point(109, 57)
        Me.tbAdr.Name = "tbAdr"
        Me.tbAdr.Size = New System.Drawing.Size(167, 20)
        Me.tbAdr.TabIndex = 2
        '
        'cbPays
        '
        Me.cbPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPays.FormattingEnabled = True
        Me.cbPays.Location = New System.Drawing.Point(109, 187)
        Me.cbPays.Name = "cbPays"
        Me.cbPays.Size = New System.Drawing.Size(167, 21)
        Me.cbPays.TabIndex = 7
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(109, 31)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(167, 20)
        Me.tbNom.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Pays :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Mail :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tel :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Code Postal :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ville :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Adresse (avec rue) :"
        '
        'FrmAddEntreprise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(303, 300)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAddEntreprise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monin - Ajout entreprise"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnValid As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbPays As ComboBox
    Friend WithEvents tbNom As TextBox
    Friend WithEvents tbMail As TextBox
    Friend WithEvents tbTel As TextBox
    Friend WithEvents tbVille As TextBox
    Friend WithEvents tbCp As TextBox
    Friend WithEvents tbAdr As TextBox
    Friend WithEvents lblMsg As Label
End Class
