<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateProduit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdateProduit))
        Me.btnValid = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Photo = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnParcourir = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelLib = New System.Windows.Forms.Label()
        Me.cbGamme = New System.Windows.Forms.ComboBox()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.tbDesc = New System.Windows.Forms.TextBox()
        Me.tbPrix = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Photo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnValid
        '
        Me.btnValid.Location = New System.Drawing.Point(11, 279)
        Me.btnValid.Name = "btnValid"
        Me.btnValid.Size = New System.Drawing.Size(263, 32)
        Me.btnValid.TabIndex = 6
        Me.btnValid.Text = "Enregistrer le produit"
        Me.btnValid.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Photo)
        Me.GroupBox1.Controls.Add(Me.btnParcourir)
        Me.GroupBox1.Controls.Add(Me.lblMsg)
        Me.GroupBox1.Controls.Add(Me.btnValid)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LabelLib)
        Me.GroupBox1.Controls.Add(Me.cbGamme)
        Me.GroupBox1.Controls.Add(Me.tbNom)
        Me.GroupBox1.Controls.Add(Me.tbDesc)
        Me.GroupBox1.Controls.Add(Me.tbPrix)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 326)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modification du produit"
        '
        'Photo
        '
        Me.Photo.Controls.Add(Me.PictureBox1)
        Me.Photo.Location = New System.Drawing.Point(61, 137)
        Me.Photo.Name = "Photo"
        Me.Photo.Size = New System.Drawing.Size(107, 106)
        Me.Photo.TabIndex = 50
        Me.Photo.TabStop = False
        Me.Photo.Text = "Photo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'btnParcourir
        '
        Me.btnParcourir.Location = New System.Drawing.Point(174, 172)
        Me.btnParcourir.Name = "btnParcourir"
        Me.btnParcourir.Size = New System.Drawing.Size(75, 41)
        Me.btnParcourir.TabIndex = 5
        Me.btnParcourir.Text = "Choisir une photo"
        Me.btnParcourir.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(8, 263)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(162, 13)
        Me.lblMsg.TabIndex = 47
        Me.lblMsg.Text = "Entrez les informations du produit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Gamme"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Prix Unitaire"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Derscription"
        '
        'LabelLib
        '
        Me.LabelLib.AutoSize = True
        Me.LabelLib.Location = New System.Drawing.Point(8, 32)
        Me.LabelLib.Name = "LabelLib"
        Me.LabelLib.Size = New System.Drawing.Size(79, 13)
        Me.LabelLib.TabIndex = 28
        Me.LabelLib.Text = "Nom du produit"
        '
        'cbGamme
        '
        Me.cbGamme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGamme.FormattingEnabled = True
        Me.cbGamme.Location = New System.Drawing.Point(93, 107)
        Me.cbGamme.Name = "cbGamme"
        Me.cbGamme.Size = New System.Drawing.Size(181, 21)
        Me.cbGamme.TabIndex = 4
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(93, 29)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(181, 20)
        Me.tbNom.TabIndex = 1
        '
        'tbDesc
        '
        Me.tbDesc.Location = New System.Drawing.Point(93, 55)
        Me.tbDesc.Name = "tbDesc"
        Me.tbDesc.Size = New System.Drawing.Size(181, 20)
        Me.tbDesc.TabIndex = 2
        '
        'tbPrix
        '
        Me.tbPrix.Location = New System.Drawing.Point(93, 81)
        Me.tbPrix.Name = "tbPrix"
        Me.tbPrix.Size = New System.Drawing.Size(181, 20)
        Me.tbPrix.TabIndex = 3
        '
        'FrmUpdateProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(313, 343)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUpdateProduit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monin - Modif"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Photo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnValid As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Photo As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnParcourir As Button
    Friend WithEvents lblMsg As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelLib As Label
    Friend WithEvents cbGamme As ComboBox
    Friend WithEvents tbNom As TextBox
    Friend WithEvents tbDesc As TextBox
    Friend WithEvents tbPrix As TextBox
End Class
