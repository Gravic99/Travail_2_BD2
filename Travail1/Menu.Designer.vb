<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormulaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EssenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DétruireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FournisseurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GererToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierEntenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RéservationÉtudiantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormulaireToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(394, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormulaireToolStripMenuItem
        '
        Me.FormulaireToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EssenceToolStripMenuItem, Me.ToolStripTextBox1, Me.FournisseurToolStripMenuItem, Me.ModifierEntenteToolStripMenuItem, Me.RéservationÉtudiantToolStripMenuItem})
        Me.FormulaireToolStripMenuItem.Name = "FormulaireToolStripMenuItem"
        Me.FormulaireToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.FormulaireToolStripMenuItem.Text = "Formulaire"
        '
        'EssenceToolStripMenuItem
        '
        Me.EssenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutToolStripMenuItem, Me.ModifierToolStripMenuItem, Me.DétruireToolStripMenuItem})
        Me.EssenceToolStripMenuItem.Name = "EssenceToolStripMenuItem"
        Me.EssenceToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.EssenceToolStripMenuItem.Text = "Essence"
        '
        'AjoutToolStripMenuItem
        '
        Me.AjoutToolStripMenuItem.Name = "AjoutToolStripMenuItem"
        Me.AjoutToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AjoutToolStripMenuItem.Text = "Ajout"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'DétruireToolStripMenuItem
        '
        Me.DétruireToolStripMenuItem.Name = "DétruireToolStripMenuItem"
        Me.DétruireToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.DétruireToolStripMenuItem.Text = "Détruire"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "Ajout entente"
        '
        'FournisseurToolStripMenuItem
        '
        Me.FournisseurToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutToolStripMenuItem1, Me.GererToolStripMenuItem})
        Me.FournisseurToolStripMenuItem.Name = "FournisseurToolStripMenuItem"
        Me.FournisseurToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.FournisseurToolStripMenuItem.Text = "Fournisseur"
        '
        'AjoutToolStripMenuItem1
        '
        Me.AjoutToolStripMenuItem1.Name = "AjoutToolStripMenuItem1"
        Me.AjoutToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.AjoutToolStripMenuItem1.Text = "Ajout"
        '
        'GererToolStripMenuItem
        '
        Me.GererToolStripMenuItem.Name = "GererToolStripMenuItem"
        Me.GererToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.GererToolStripMenuItem.Text = "Gerer"
        '
        'ModifierEntenteToolStripMenuItem
        '
        Me.ModifierEntenteToolStripMenuItem.Name = "ModifierEntenteToolStripMenuItem"
        Me.ModifierEntenteToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ModifierEntenteToolStripMenuItem.Text = "Modifier Entente"
        '
        'RéservationÉtudiantToolStripMenuItem
        '
        Me.RéservationÉtudiantToolStripMenuItem.Name = "RéservationÉtudiantToolStripMenuItem"
        Me.RéservationÉtudiantToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RéservationÉtudiantToolStripMenuItem.Text = "Rechercher étudiant"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 159)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FormulaireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EssenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents AjoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DétruireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FournisseurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GererToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierEntenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RéservationÉtudiantToolStripMenuItem As ToolStripMenuItem
End Class
