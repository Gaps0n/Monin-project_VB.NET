<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_nouveauProduit
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TBPrix = New System.Windows.Forms.TextBox()
        Me.TBPhoto = New System.Windows.Forms.TextBox()
        Me.TBDesc = New System.Windows.Forms.TextBox()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.CBGamme2 = New System.Windows.Forms.ComboBox()
        Me.LabelLib = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnAjout = New System.Windows.Forms.Button()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBPrix
        '
        Me.TBPrix.Location = New System.Drawing.Point(138, 165)
        Me.TBPrix.Name = "TBPrix"
        Me.TBPrix.Size = New System.Drawing.Size(181, 20)
        Me.TBPrix.TabIndex = 0
        '
        'TBPhoto
        '
        Me.TBPhoto.Location = New System.Drawing.Point(138, 126)
        Me.TBPhoto.Name = "TBPhoto"
        Me.TBPhoto.Size = New System.Drawing.Size(181, 20)
        Me.TBPhoto.TabIndex = 1
        '
        'TBDesc
        '
        Me.TBDesc.Location = New System.Drawing.Point(138, 87)
        Me.TBDesc.Name = "TBDesc"
        Me.TBDesc.Size = New System.Drawing.Size(181, 20)
        Me.TBDesc.TabIndex = 2
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(138, 48)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(181, 20)
        Me.TBNom.TabIndex = 3
        '
        'CBGamme2
        '
        Me.CBGamme2.FormattingEnabled = True
        Me.CBGamme2.Location = New System.Drawing.Point(138, 217)
        Me.CBGamme2.Name = "CBGamme2"
        Me.CBGamme2.Size = New System.Drawing.Size(181, 21)
        Me.CBGamme2.TabIndex = 4
        '
        'LabelLib
        '
        Me.LabelLib.AutoSize = True
        Me.LabelLib.Location = New System.Drawing.Point(9, 48)
        Me.LabelLib.Name = "LabelLib"
        Me.LabelLib.Size = New System.Drawing.Size(79, 13)
        Me.LabelLib.TabIndex = 5
        Me.LabelLib.Text = "Nom du produit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Derscription"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Photo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Prix Unitaire"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Gamme"
        '
        'BtnAjout
        '
        Me.BtnAjout.Location = New System.Drawing.Point(350, 65)
        Me.BtnAjout.Name = "BtnAjout"
        Me.BtnAjout.Size = New System.Drawing.Size(51, 22)
        Me.BtnAjout.TabIndex = 10
        Me.BtnAjout.Text = "Ajouter"
        Me.BtnAjout.UseVisualStyleBackColor = True
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(350, 124)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(51, 22)
        Me.BtnRetour.TabIndex = 11
        Me.BtnRetour.Text = "Retour"
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'Form_nouveauProduit
        '
        Me.ClientSize = New System.Drawing.Size(413, 262)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.BtnAjout)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelLib)
        Me.Controls.Add(Me.CBGamme2)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.TBDesc)
        Me.Controls.Add(Me.TBPhoto)
        Me.Controls.Add(Me.TBPrix)
        Me.Name = "Form_nouveauProduit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CBgamme As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LstProd As ListBox
    Friend WithEvents BtnModif As Button
    Friend WithEvents BtnSuppr As Button
    Friend WithEvents TBPrix As TextBox
    Friend WithEvents TBPhoto As TextBox
    Friend WithEvents TBDesc As TextBox
    Friend WithEvents TBNom As TextBox
    Friend WithEvents CBGamme2 As ComboBox
    Friend WithEvents LabelLib As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnAjout As Button
    Friend WithEvents BtnRetour As Button
End Class
