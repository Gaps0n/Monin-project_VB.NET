<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateContact
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbTitre = New System.Windows.Forms.ComboBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnValid = New System.Windows.Forms.Button()
        Me.tbTelPortable = New System.Windows.Forms.TextBox()
        Me.tbTelInterne = New System.Windows.Forms.TextBox()
        Me.tbMail = New System.Windows.Forms.TextBox()
        Me.tbPrenom = New System.Windows.Forms.TextBox()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.cbEntreprise = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbTitre)
        Me.GroupBox1.Controls.Add(Me.lblMsg)
        Me.GroupBox1.Controls.Add(Me.btnValid)
        Me.GroupBox1.Controls.Add(Me.tbTelPortable)
        Me.GroupBox1.Controls.Add(Me.tbTelInterne)
        Me.GroupBox1.Controls.Add(Me.tbMail)
        Me.GroupBox1.Controls.Add(Me.tbPrenom)
        Me.GroupBox1.Controls.Add(Me.tbNom)
        Me.GroupBox1.Controls.Add(Me.cbEntreprise)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 287)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modifiez un contact"
        '
        'cbTitre
        '
        Me.cbTitre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTitre.FormattingEnabled = True
        Me.cbTitre.Items.AddRange(New Object() {"Mr", "Mme"})
        Me.cbTitre.Location = New System.Drawing.Point(110, 31)
        Me.cbTitre.Name = "cbTitre"
        Me.cbTitre.Size = New System.Drawing.Size(167, 21)
        Me.cbTitre.TabIndex = 1
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
        'btnValid
        '
        Me.btnValid.Location = New System.Drawing.Point(6, 258)
        Me.btnValid.Name = "btnValid"
        Me.btnValid.Size = New System.Drawing.Size(267, 23)
        Me.btnValid.TabIndex = 8
        Me.btnValid.Text = "Validez"
        Me.btnValid.UseVisualStyleBackColor = True
        '
        'tbTelPortable
        '
        Me.tbTelPortable.Location = New System.Drawing.Point(109, 161)
        Me.tbTelPortable.Name = "tbTelPortable"
        Me.tbTelPortable.Size = New System.Drawing.Size(167, 20)
        Me.tbTelPortable.TabIndex = 6
        '
        'tbTelInterne
        '
        Me.tbTelInterne.Location = New System.Drawing.Point(109, 135)
        Me.tbTelInterne.Name = "tbTelInterne"
        Me.tbTelInterne.Size = New System.Drawing.Size(167, 20)
        Me.tbTelInterne.TabIndex = 5
        '
        'tbMail
        '
        Me.tbMail.Location = New System.Drawing.Point(110, 109)
        Me.tbMail.Name = "tbMail"
        Me.tbMail.Size = New System.Drawing.Size(167, 20)
        Me.tbMail.TabIndex = 4
        '
        'tbPrenom
        '
        Me.tbPrenom.Location = New System.Drawing.Point(110, 83)
        Me.tbPrenom.Name = "tbPrenom"
        Me.tbPrenom.Size = New System.Drawing.Size(167, 20)
        Me.tbPrenom.TabIndex = 3
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(109, 57)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(167, 20)
        Me.tbNom.TabIndex = 2
        '
        'cbEntreprise
        '
        Me.cbEntreprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEntreprise.FormattingEnabled = True
        Me.cbEntreprise.Location = New System.Drawing.Point(109, 187)
        Me.cbEntreprise.Name = "cbEntreprise"
        Me.cbEntreprise.Size = New System.Drawing.Size(167, 21)
        Me.cbEntreprise.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Entreprise"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tel Portable"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tel Interne"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Prénom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titre"
        '
        'FrmUpdateContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(322, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmUpdateContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monin - Modification contact"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblMsg As Label
    Friend WithEvents btnValid As Button
    Friend WithEvents tbTelPortable As TextBox
    Friend WithEvents tbTelInterne As TextBox
    Friend WithEvents tbMail As TextBox
    Friend WithEvents tbPrenom As TextBox
    Friend WithEvents tbNom As TextBox
    Friend WithEvents cbEntreprise As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbTitre As ComboBox
End Class
