<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContact
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContact))
        Me.tbClient = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDelContact = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAddContact = New System.Windows.Forms.Button()
        Me.dgContact = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboEntreprise = New System.Windows.Forms.ComboBox()
        Me.dgAction = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnDelAction = New System.Windows.Forms.Button()
        Me.btnEditAction = New System.Windows.Forms.Button()
        Me.btnAddAction = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgAction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbClient
        '
        Me.tbClient.Location = New System.Drawing.Point(298, 19)
        Me.tbClient.Name = "tbClient"
        Me.tbClient.Size = New System.Drawing.Size(100, 20)
        Me.tbClient.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Entreprise"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nom du client"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDelContact)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnAddContact)
        Me.GroupBox1.Controls.Add(Me.dgContact)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(900, 254)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact"
        '
        'btnDelContact
        '
        Me.btnDelContact.Location = New System.Drawing.Point(772, 162)
        Me.btnDelContact.Name = "btnDelContact"
        Me.btnDelContact.Size = New System.Drawing.Size(115, 54)
        Me.btnDelContact.TabIndex = 11
        Me.btnDelContact.Text = "Supprimer le contact"
        Me.btnDelContact.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(772, 102)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(115, 54)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Editer le contact"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAddContact
        '
        Me.btnAddContact.Location = New System.Drawing.Point(595, 26)
        Me.btnAddContact.Name = "btnAddContact"
        Me.btnAddContact.Size = New System.Drawing.Size(159, 43)
        Me.btnAddContact.TabIndex = 8
        Me.btnAddContact.Text = "Ajout d'un nouveau contact"
        Me.btnAddContact.UseVisualStyleBackColor = True
        '
        'dgContact
        '
        Me.dgContact.AllowUserToAddRows = False
        Me.dgContact.AllowUserToDeleteRows = False
        Me.dgContact.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgContact.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgContact.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgContact.Location = New System.Drawing.Point(6, 80)
        Me.dgContact.Name = "dgContact"
        Me.dgContact.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgContact.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContact.Size = New System.Drawing.Size(748, 167)
        Me.dgContact.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cboEntreprise)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.tbClient)
        Me.GroupBox3.Location = New System.Drawing.Point(119, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(406, 55)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recherche"
        '
        'cboEntreprise
        '
        Me.cboEntreprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEntreprise.FormattingEnabled = True
        Me.cboEntreprise.Items.AddRange(New Object() {"Tous les contacts"})
        Me.cboEntreprise.Location = New System.Drawing.Point(64, 19)
        Me.cboEntreprise.Name = "cboEntreprise"
        Me.cboEntreprise.Size = New System.Drawing.Size(139, 21)
        Me.cboEntreprise.TabIndex = 6
        '
        'dgAction
        '
        Me.dgAction.AllowUserToAddRows = False
        Me.dgAction.AllowUserToDeleteRows = False
        Me.dgAction.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAction.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgAction.Location = New System.Drawing.Point(6, 52)
        Me.dgAction.Name = "dgAction"
        Me.dgAction.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAction.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgAction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAction.Size = New System.Drawing.Size(552, 129)
        Me.dgAction.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnDelAction)
        Me.GroupBox2.Controls.Add(Me.btnEditAction)
        Me.GroupBox2.Controls.Add(Me.btnAddAction)
        Me.GroupBox2.Controls.Add(Me.dgAction)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(669, 187)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions vers le contact sélectionné"
        '
        'BtnDelAction
        '
        Me.BtnDelAction.Location = New System.Drawing.Point(564, 122)
        Me.BtnDelAction.Name = "BtnDelAction"
        Me.BtnDelAction.Size = New System.Drawing.Size(98, 34)
        Me.BtnDelAction.TabIndex = 15
        Me.BtnDelAction.Text = "Supprimer l'action"
        Me.BtnDelAction.UseVisualStyleBackColor = True
        '
        'btnEditAction
        '
        Me.btnEditAction.Location = New System.Drawing.Point(564, 82)
        Me.btnEditAction.Name = "btnEditAction"
        Me.btnEditAction.Size = New System.Drawing.Size(98, 34)
        Me.btnEditAction.TabIndex = 14
        Me.btnEditAction.Text = "Editer l'action"
        Me.btnEditAction.UseVisualStyleBackColor = True
        '
        'btnAddAction
        '
        Me.btnAddAction.Location = New System.Drawing.Point(422, 12)
        Me.btnAddAction.Name = "btnAddAction"
        Me.btnAddAction.Size = New System.Drawing.Size(136, 34)
        Me.btnAddAction.TabIndex = 13
        Me.btnAddAction.Text = "Ajout d'une action pour le contact sélectionné"
        Me.btnAddAction.UseVisualStyleBackColor = True
        '
        'FrmContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(927, 471)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monin - Contact"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgAction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbClient As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgAction As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAddContact As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgContact As DataGridView
    Friend WithEvents btnDelContact As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAddAction As Button
    Friend WithEvents BtnDelAction As Button
    Friend WithEvents btnEditAction As Button
    Friend WithEvents cboEntreprise As ComboBox
End Class
