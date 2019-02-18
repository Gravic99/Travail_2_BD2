<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modifier_Essence
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
        Me.Btn_Modifier = New System.Windows.Forms.Button()
        Me.ComboBox_Essence = New System.Windows.Forms.ComboBox()
        Me.Txt_description = New System.Windows.Forms.TextBox()
        Me.Lbl_Nom = New System.Windows.Forms.Label()
        Me.Lbl_Nouveau_nom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Modifier
        '
        Me.Btn_Modifier.Location = New System.Drawing.Point(129, 148)
        Me.Btn_Modifier.Name = "Btn_Modifier"
        Me.Btn_Modifier.Size = New System.Drawing.Size(121, 23)
        Me.Btn_Modifier.TabIndex = 5
        Me.Btn_Modifier.Text = "Modifier"
        Me.Btn_Modifier.UseVisualStyleBackColor = True
        '
        'ComboBox_Essence
        '
        Me.ComboBox_Essence.FormattingEnabled = True
        Me.ComboBox_Essence.Location = New System.Drawing.Point(129, 57)
        Me.ComboBox_Essence.Name = "ComboBox_Essence"
        Me.ComboBox_Essence.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Essence.TabIndex = 4
        '
        'Txt_description
        '
        Me.Txt_description.Location = New System.Drawing.Point(129, 96)
        Me.Txt_description.Name = "Txt_description"
        Me.Txt_description.Size = New System.Drawing.Size(121, 20)
        Me.Txt_description.TabIndex = 3
        '
        'Lbl_Nom
        '
        Me.Lbl_Nom.AutoSize = True
        Me.Lbl_Nom.Location = New System.Drawing.Point(49, 65)
        Me.Lbl_Nom.Name = "Lbl_Nom"
        Me.Lbl_Nom.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_Nom.TabIndex = 6
        Me.Lbl_Nom.Text = "Nom"
        '
        'Lbl_Nouveau_nom
        '
        Me.Lbl_Nouveau_nom.AutoSize = True
        Me.Lbl_Nouveau_nom.Location = New System.Drawing.Point(49, 103)
        Me.Lbl_Nouveau_nom.Name = "Lbl_Nouveau_nom"
        Me.Lbl_Nouveau_nom.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Nouveau_nom.TabIndex = 7
        Me.Lbl_Nouveau_nom.Text = "Nouveau nom"
        '
        'Modifier_Essence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 241)
        Me.Controls.Add(Me.Lbl_Nouveau_nom)
        Me.Controls.Add(Me.Lbl_Nom)
        Me.Controls.Add(Me.Btn_Modifier)
        Me.Controls.Add(Me.ComboBox_Essence)
        Me.Controls.Add(Me.Txt_description)
        Me.Name = "Modifier_Essence"
        Me.Text = "Modifier_Essence"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Modifier As Button
    Friend WithEvents ComboBox_Essence As ComboBox
    Friend WithEvents Txt_description As TextBox
    Friend WithEvents Lbl_Nom As Label
    Friend WithEvents Lbl_Nouveau_nom As Label
End Class
