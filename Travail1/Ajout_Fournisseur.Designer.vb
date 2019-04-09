<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_Fournisseur
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
        Me.txt_Fournisseur = New System.Windows.Forms.TextBox()
        Me.Btn_Ajouter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_Fournisseur
        '
        Me.txt_Fournisseur.Location = New System.Drawing.Point(93, 29)
        Me.txt_Fournisseur.Name = "txt_Fournisseur"
        Me.txt_Fournisseur.Size = New System.Drawing.Size(100, 20)
        Me.txt_Fournisseur.TabIndex = 0
        '
        'Btn_Ajouter
        '
        Me.Btn_Ajouter.Location = New System.Drawing.Point(93, 74)
        Me.Btn_Ajouter.Name = "Btn_Ajouter"
        Me.Btn_Ajouter.Size = New System.Drawing.Size(100, 23)
        Me.Btn_Ajouter.TabIndex = 1
        Me.Btn_Ajouter.Text = "Ajouter"
        Me.Btn_Ajouter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom"
        '
        'Ajout_Fournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 121)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Ajouter)
        Me.Controls.Add(Me.txt_Fournisseur)
        Me.Name = "Ajout_Fournisseur"
        Me.Text = "Ajout_Fournisseur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Fournisseur As TextBox
    Friend WithEvents Btn_Ajouter As Button
    Friend WithEvents Label1 As Label
End Class
