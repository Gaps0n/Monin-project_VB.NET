<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGammes
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
        Me.TBGamme = New System.Windows.Forms.TextBox()
        Me.BtnAjout = New System.Windows.Forms.Button()
        Me.BtnModif = New System.Windows.Forms.Button()
        Me.BtnSupp = New System.Windows.Forms.Button()
        Me.CBGamme = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TBGamme
        '
        Me.TBGamme.Location = New System.Drawing.Point(12, 78)
        Me.TBGamme.Name = "TBGamme"
        Me.TBGamme.Size = New System.Drawing.Size(329, 20)
        Me.TBGamme.TabIndex = 1
        '
        'BtnAjout
        '
        Me.BtnAjout.Location = New System.Drawing.Point(12, 145)
        Me.BtnAjout.Name = "BtnAjout"
        Me.BtnAjout.Size = New System.Drawing.Size(101, 40)
        Me.BtnAjout.TabIndex = 2
        Me.BtnAjout.Text = "Ajouter une Gamme"
        Me.BtnAjout.UseVisualStyleBackColor = True
        '
        'BtnModif
        '
        Me.BtnModif.Location = New System.Drawing.Point(142, 145)
        Me.BtnModif.Name = "BtnModif"
        Me.BtnModif.Size = New System.Drawing.Size(101, 40)
        Me.BtnModif.TabIndex = 3
        Me.BtnModif.Text = "Modifier le nom de gamme"
        Me.BtnModif.UseVisualStyleBackColor = True
        '
        'BtnSupp
        '
        Me.BtnSupp.Location = New System.Drawing.Point(272, 145)
        Me.BtnSupp.Name = "BtnSupp"
        Me.BtnSupp.Size = New System.Drawing.Size(101, 40)
        Me.BtnSupp.TabIndex = 4
        Me.BtnSupp.Text = "Suppression de la gamme"
        Me.BtnSupp.UseVisualStyleBackColor = True
        '
        'CBGamme
        '
        Me.CBGamme.FormattingEnabled = True
        Me.CBGamme.Location = New System.Drawing.Point(12, 33)
        Me.CBGamme.Name = "CBGamme"
        Me.CBGamme.Size = New System.Drawing.Size(329, 21)
        Me.CBGamme.TabIndex = 5
        '
        'FrmGammes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(395, 207)
        Me.Controls.Add(Me.CBGamme)
        Me.Controls.Add(Me.BtnSupp)
        Me.Controls.Add(Me.BtnModif)
        Me.Controls.Add(Me.BtnAjout)
        Me.Controls.Add(Me.TBGamme)
        Me.Name = "FrmGammes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monin - Gammes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBGamme As TextBox
    Friend WithEvents BtnAjout As Button
    Friend WithEvents BtnModif As Button
    Friend WithEvents BtnSupp As Button
    Friend WithEvents CBGamme As ComboBox
End Class
