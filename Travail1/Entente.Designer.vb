<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entente
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
        Me.ComboBox_Fournisseur = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Essence = New System.Windows.Forms.ComboBox()
        Me.Txt_Prix = New System.Windows.Forms.TextBox()
        Me.Txt_Quantite_Entente = New System.Windows.Forms.TextBox()
        Me.Txt_Annee = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_ajouter_fournisseur = New System.Windows.Forms.Button()
        Me.Btn_ajouter_Essence = New System.Windows.Forms.Button()
        Me.Btn_Ajouter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox_Fournisseur
        '
        Me.ComboBox_Fournisseur.FormattingEnabled = True
        Me.ComboBox_Fournisseur.Location = New System.Drawing.Point(174, 37)
        Me.ComboBox_Fournisseur.Name = "ComboBox_Fournisseur"
        Me.ComboBox_Fournisseur.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Fournisseur.TabIndex = 0
        '
        'ComboBox_Essence
        '
        Me.ComboBox_Essence.FormattingEnabled = True
        Me.ComboBox_Essence.Location = New System.Drawing.Point(174, 74)
        Me.ComboBox_Essence.Name = "ComboBox_Essence"
        Me.ComboBox_Essence.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Essence.TabIndex = 1
        '
        'Txt_Prix
        '
        Me.Txt_Prix.Location = New System.Drawing.Point(174, 110)
        Me.Txt_Prix.Name = "Txt_Prix"
        Me.Txt_Prix.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Prix.TabIndex = 2
        '
        'Txt_Quantite_Entente
        '
        Me.Txt_Quantite_Entente.Location = New System.Drawing.Point(174, 145)
        Me.Txt_Quantite_Entente.Name = "Txt_Quantite_Entente"
        Me.Txt_Quantite_Entente.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Quantite_Entente.TabIndex = 3
        '
        'Txt_Annee
        '
        Me.Txt_Annee.Location = New System.Drawing.Point(174, 181)
        Me.Txt_Annee.Name = "Txt_Annee"
        Me.Txt_Annee.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Annee.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fournisseur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Essence"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Prix"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Quantité entente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Année"
        '
        'Btn_ajouter_fournisseur
        '
        Me.Btn_ajouter_fournisseur.Location = New System.Drawing.Point(317, 40)
        Me.Btn_ajouter_fournisseur.Name = "Btn_ajouter_fournisseur"
        Me.Btn_ajouter_fournisseur.Size = New System.Drawing.Size(29, 23)
        Me.Btn_ajouter_fournisseur.TabIndex = 10
        Me.Btn_ajouter_fournisseur.Text = "+"
        Me.Btn_ajouter_fournisseur.UseVisualStyleBackColor = True
        '
        'Btn_ajouter_Essence
        '
        Me.Btn_ajouter_Essence.Location = New System.Drawing.Point(317, 72)
        Me.Btn_ajouter_Essence.Name = "Btn_ajouter_Essence"
        Me.Btn_ajouter_Essence.Size = New System.Drawing.Size(29, 23)
        Me.Btn_ajouter_Essence.TabIndex = 11
        Me.Btn_ajouter_Essence.Text = "+"
        Me.Btn_ajouter_Essence.UseVisualStyleBackColor = True
        '
        'Btn_Ajouter
        '
        Me.Btn_Ajouter.Location = New System.Drawing.Point(174, 229)
        Me.Btn_Ajouter.Name = "Btn_Ajouter"
        Me.Btn_Ajouter.Size = New System.Drawing.Size(121, 23)
        Me.Btn_Ajouter.TabIndex = 12
        Me.Btn_Ajouter.Text = "Ajouter"
        Me.Btn_Ajouter.UseVisualStyleBackColor = True
        '
        'Entente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 269)
        Me.Controls.Add(Me.Btn_Ajouter)
        Me.Controls.Add(Me.Btn_ajouter_Essence)
        Me.Controls.Add(Me.Btn_ajouter_fournisseur)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Annee)
        Me.Controls.Add(Me.Txt_Quantite_Entente)
        Me.Controls.Add(Me.Txt_Prix)
        Me.Controls.Add(Me.ComboBox_Essence)
        Me.Controls.Add(Me.ComboBox_Fournisseur)
        Me.Name = "Entente"
        Me.Text = "Entente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox_Fournisseur As ComboBox
    Friend WithEvents ComboBox_Essence As ComboBox
    Friend WithEvents Txt_Prix As TextBox
    Friend WithEvents Txt_Quantite_Entente As TextBox
    Friend WithEvents Txt_Annee As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn_ajouter_fournisseur As Button
    Friend WithEvents Btn_ajouter_Essence As Button
    Friend WithEvents Btn_Ajouter As Button
End Class
