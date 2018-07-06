<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUpdateRecette
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdateRecette))
        Me.lbCompo = New System.Windows.Forms.ListBox()
        Me.lbProduit = New System.Windows.Forms.ListBox()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.btnLess = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNomRecette = New System.Windows.Forms.TextBox()
        Me.btnValid = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbCompo
        '
        Me.lbCompo.FormattingEnabled = True
        Me.lbCompo.Location = New System.Drawing.Point(6, 18)
        Me.lbCompo.Name = "lbCompo"
        Me.lbCompo.Size = New System.Drawing.Size(120, 160)
        Me.lbCompo.TabIndex = 1
        '
        'lbProduit
        '
        Me.lbProduit.FormattingEnabled = True
        Me.lbProduit.Location = New System.Drawing.Point(6, 18)
        Me.lbProduit.Name = "lbProduit"
        Me.lbProduit.Size = New System.Drawing.Size(120, 160)
        Me.lbProduit.TabIndex = 0
        '
        'btnMore
        '
        Me.btnMore.Location = New System.Drawing.Point(153, 232)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(26, 23)
        Me.btnMore.TabIndex = 2
        Me.btnMore.Text = "+"
        Me.btnMore.UseVisualStyleBackColor = True
        '
        'btnLess
        '
        Me.btnLess.Location = New System.Drawing.Point(153, 261)
        Me.btnLess.Name = "btnLess"
        Me.btnLess.Size = New System.Drawing.Size(26, 23)
        Me.btnLess.TabIndex = 3
        Me.btnLess.Text = "-"
        Me.btnLess.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(32, 353)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(174, 13)
        Me.lblMsg.TabIndex = 53
        Me.lblMsg.Text = "Entrez les informations de la recette"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbCompo)
        Me.GroupBox1.Location = New System.Drawing.Point(185, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 184)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Composition"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Description"
        '
        'tbDesc
        '
        Me.tbDesc.Location = New System.Drawing.Point(32, 64)
        Me.tbDesc.Multiline = True
        Me.tbDesc.Name = "tbDesc"
        Me.tbDesc.Size = New System.Drawing.Size(275, 77)
        Me.tbDesc.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Nom de la recette"
        '
        'tbNomRecette
        '
        Me.tbNomRecette.Location = New System.Drawing.Point(126, 20)
        Me.tbNomRecette.Name = "tbNomRecette"
        Me.tbNomRecette.Size = New System.Drawing.Size(180, 20)
        Me.tbNomRecette.TabIndex = 48
        '
        'btnValid
        '
        Me.btnValid.Location = New System.Drawing.Point(32, 370)
        Me.btnValid.Name = "btnValid"
        Me.btnValid.Size = New System.Drawing.Size(287, 22)
        Me.btnValid.TabIndex = 47
        Me.btnValid.Text = "Validez"
        Me.btnValid.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbProduit)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(135, 184)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste des produits"
        '
        'FrmUpdateRecette
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(348, 413)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnMore)
        Me.Controls.Add(Me.btnLess)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbNomRecette)
        Me.Controls.Add(Me.btnValid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUpdateRecette"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monin - Modifcation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCompo As ListBox
    Friend WithEvents lbProduit As ListBox
    Friend WithEvents btnMore As Button
    Friend WithEvents btnLess As Button
    Friend WithEvents lblMsg As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbDesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbNomRecette As TextBox
    Friend WithEvents btnValid As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
