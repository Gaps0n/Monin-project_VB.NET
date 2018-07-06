<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjoutGamme
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
        Me.TBAjout = New System.Windows.Forms.TextBox()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBAjout
        '
        Me.TBAjout.Location = New System.Drawing.Point(12, 51)
        Me.TBAjout.Name = "TBAjout"
        Me.TBAjout.Size = New System.Drawing.Size(196, 20)
        Me.TBAjout.TabIndex = 0
        '
        'BtnValider
        '
        Me.BtnValider.Location = New System.Drawing.Point(64, 77)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(99, 25)
        Me.BtnValider.TabIndex = 1
        Me.BtnValider.Text = "Ajouter la gamme"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom de la nouvelle gamme :"
        '
        'FrmAjoutGamme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(225, 121)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnValider)
        Me.Controls.Add(Me.TBAjout)
        Me.Name = "FrmAjoutGamme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monin - Ajout de Gamme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBAjout As TextBox
    Friend WithEvents BtnValider As Button
    Friend WithEvents Label1 As Label
End Class
