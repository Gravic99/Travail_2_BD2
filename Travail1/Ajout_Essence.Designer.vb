<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_Essence
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
        Me.Txt_description = New System.Windows.Forms.TextBox()
        Me.Btn_Ajouter = New System.Windows.Forms.Button()
        Me.Lbl_Nom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt_description
        '
        Me.Txt_description.Location = New System.Drawing.Point(99, 29)
        Me.Txt_description.Name = "Txt_description"
        Me.Txt_description.Size = New System.Drawing.Size(121, 20)
        Me.Txt_description.TabIndex = 0
        '
        'Btn_Ajouter
        '
        Me.Btn_Ajouter.Location = New System.Drawing.Point(99, 67)
        Me.Btn_Ajouter.Name = "Btn_Ajouter"
        Me.Btn_Ajouter.Size = New System.Drawing.Size(121, 23)
        Me.Btn_Ajouter.TabIndex = 2
        Me.Btn_Ajouter.Text = "Ajouter"
        Me.Btn_Ajouter.UseVisualStyleBackColor = True
        '
        'Lbl_Nom
        '
        Me.Lbl_Nom.AutoSize = True
        Me.Lbl_Nom.Location = New System.Drawing.Point(36, 36)
        Me.Lbl_Nom.Name = "Lbl_Nom"
        Me.Lbl_Nom.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_Nom.TabIndex = 3
        Me.Lbl_Nom.Text = "Nom"
        '
        'Ajout_Essence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 119)
        Me.Controls.Add(Me.Lbl_Nom)
        Me.Controls.Add(Me.Btn_Ajouter)
        Me.Controls.Add(Me.Txt_description)
        Me.Name = "Ajout_Essence"
        Me.Text = "Ajout_Essence"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_description As TextBox
    Friend WithEvents Btn_Ajouter As Button
    Friend WithEvents Lbl_Nom As Label
End Class
