<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateAction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdateAction))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnValidAction = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbCom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbTypeAction = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbARelancer = New System.Windows.Forms.ComboBox()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblMsg)
        Me.GroupBox4.Controls.Add(Me.btnValidAction)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.tbCom)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.cbTypeAction)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox4.Controls.Add(Me.cbARelancer)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(312, 229)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Modifier l'action vers le contact sélectionné"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(6, 179)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(163, 13)
        Me.lblMsg.TabIndex = 46
        Me.lblMsg.Text = "Entrez les informations de l'action"
        '
        'btnValidAction
        '
        Me.btnValidAction.Location = New System.Drawing.Point(6, 195)
        Me.btnValidAction.Name = "btnValidAction"
        Me.btnValidAction.Size = New System.Drawing.Size(297, 28)
        Me.btnValidAction.TabIndex = 5
        Me.btnValidAction.Text = "Enregistrer l'action"
        Me.btnValidAction.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Type d'action"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Date de relance"
        '
        'tbCom
        '
        Me.tbCom.Location = New System.Drawing.Point(89, 113)
        Me.tbCom.Multiline = True
        Me.tbCom.Name = "tbCom"
        Me.tbCom.Size = New System.Drawing.Size(214, 51)
        Me.tbCom.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Commentaire"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "A Relancer"
        '
        'cbTypeAction
        '
        Me.cbTypeAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypeAction.FormattingEnabled = True
        Me.cbTypeAction.Location = New System.Drawing.Point(89, 29)
        Me.cbTypeAction.Name = "cbTypeAction"
        Me.cbTypeAction.Size = New System.Drawing.Size(214, 21)
        Me.cbTypeAction.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(89, 56)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(214, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'cbARelancer
        '
        Me.cbARelancer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbARelancer.FormattingEnabled = True
        Me.cbARelancer.Items.AddRange(New Object() {"Oui", "Non"})
        Me.cbARelancer.Location = New System.Drawing.Point(89, 82)
        Me.cbARelancer.Name = "cbARelancer"
        Me.cbARelancer.Size = New System.Drawing.Size(214, 21)
        Me.cbARelancer.TabIndex = 3
        '
        'FrmUpdateAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(336, 250)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUpdateAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monin - Modification action"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblMsg As Label
    Friend WithEvents btnValidAction As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbCom As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbTypeAction As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbARelancer As ComboBox
End Class
