<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.cmbNom = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(125, 85)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(140, 20)
        Me.txtNom.TabIndex = 0
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(125, 134)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(140, 20)
        Me.txtPrenom.TabIndex = 1
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(125, 41)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(140, 20)
        Me.txtCode.TabIndex = 3
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(125, 182)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(140, 20)
        Me.txtAdresse.TabIndex = 2
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(23, 44)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(74, 13)
        Me.lblCode.TabIndex = 4
        Me.lblCode.Text = "&Code Etudiant"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(23, 92)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(29, 13)
        Me.lblNom.TabIndex = 5
        Me.lblNom.Text = "&Nom"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(23, 141)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(43, 13)
        Me.lblPrenom.TabIndex = 6
        Me.lblPrenom.Text = "&Prenom"
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(23, 189)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(45, 13)
        Me.lblAdresse.TabIndex = 7
        Me.lblAdresse.Text = "&Adresse"
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(290, 34)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouter.TabIndex = 8
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Location = New System.Drawing.Point(290, 82)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimer.TabIndex = 9
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(290, 131)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(75, 23)
        Me.btnModifier.TabIndex = 10
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnRechercher
        '
        Me.btnRechercher.Location = New System.Drawing.Point(290, 179)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(75, 23)
        Me.btnRechercher.TabIndex = 11
        Me.btnRechercher.Text = "Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = True
        '
        'cmbNom
        '
        Me.cmbNom.FormattingEnabled = True
        Me.cmbNom.Location = New System.Drawing.Point(533, 34)
        Me.cmbNom.Name = "cmbNom"
        Me.cmbNom.Size = New System.Drawing.Size(121, 21)
        Me.cmbNom.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 261)
        Me.Controls.Add(Me.cmbNom)
        Me.Controls.Add(Me.btnRechercher)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents lblCode As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnRechercher As Button
    Friend WithEvents cmbNom As ComboBox
End Class
