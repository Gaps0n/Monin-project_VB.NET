<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddContact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddContact))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbEntreprise = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTelPortable = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbTelInterne = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbMail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPrenom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTitre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMsg)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cbEntreprise)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbTelPortable)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbTelInterne)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbMail)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbPrenom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbNom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbTitre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 295)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter un contact"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(13, 228)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(166, 13)
        Me.lblMsg.TabIndex = 45
        Me.lblMsg.Text = "Entrez les informations du contact"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 42)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Enregistrer le contact" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbEntreprise
        '
        Me.cbEntreprise.BackColor = System.Drawing.Color.White
        Me.cbEntreprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEntreprise.FormattingEnabled = True
        Me.cbEntreprise.Location = New System.Drawing.Point(77, 185)
        Me.cbEntreprise.Name = "cbEntreprise"
        Me.cbEntreprise.Size = New System.Drawing.Size(152, 21)
        Me.cbEntreprise.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Entreprise"
        '
        'tbTelPortable
        '
        Me.tbTelPortable.Location = New System.Drawing.Point(77, 159)
        Me.tbTelPortable.Name = "tbTelPortable"
        Me.tbTelPortable.Size = New System.Drawing.Size(152, 20)
        Me.tbTelPortable.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Tel Portable"
        '
        'tbTelInterne
        '
        Me.tbTelInterne.Location = New System.Drawing.Point(77, 133)
        Me.tbTelInterne.Name = "tbTelInterne"
        Me.tbTelInterne.Size = New System.Drawing.Size(152, 20)
        Me.tbTelInterne.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Tel Interne"
        '
        'tbMail
        '
        Me.tbMail.Location = New System.Drawing.Point(61, 106)
        Me.tbMail.Name = "tbMail"
        Me.tbMail.Size = New System.Drawing.Size(168, 20)
        Me.tbMail.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Mail"
        '
        'tbPrenom
        '
        Me.tbPrenom.Location = New System.Drawing.Point(61, 80)
        Me.tbPrenom.Name = "tbPrenom"
        Me.tbPrenom.Size = New System.Drawing.Size(168, 20)
        Me.tbPrenom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Prénom"
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(61, 54)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(168, 20)
        Me.tbNom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nom"
        '
        'cbTitre
        '
        Me.cbTitre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTitre.FormattingEnabled = True
        Me.cbTitre.Items.AddRange(New Object() {"Monsieur", "Madame"})
        Me.cbTitre.Location = New System.Drawing.Point(61, 29)
        Me.cbTitre.Name = "cbTitre"
        Me.cbTitre.Size = New System.Drawing.Size(168, 21)
        Me.cbTitre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Titre"
        '
        'FrmAddContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(255, 310)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAddContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Monin - Ajout"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cbEntreprise As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbTelPortable As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbTelInterne As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbMail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbPrenom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTitre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMsg As Label
End Class
