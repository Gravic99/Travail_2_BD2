<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Detruire_Essence
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_Detruire = New System.Windows.Forms.Button()
        Me.ComboBox_Essence = New System.Windows.Forms.ComboBox()
        Me.Lbl_Nom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Detruire
        '
        Me.Btn_Detruire.Location = New System.Drawing.Point(99, 83)
        Me.Btn_Detruire.Name = "Btn_Detruire"
        Me.Btn_Detruire.Size = New System.Drawing.Size(121, 23)
        Me.Btn_Detruire.TabIndex = 5
        Me.Btn_Detruire.Text = "Détruire"
        Me.Btn_Detruire.UseVisualStyleBackColor = True
        '
        'ComboBox_Essence
        '
        Me.ComboBox_Essence.FormattingEnabled = True
        Me.ComboBox_Essence.Location = New System.Drawing.Point(99, 22)
        Me.ComboBox_Essence.Name = "ComboBox_Essence"
        Me.ComboBox_Essence.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Essence.TabIndex = 4
        '
        'Lbl_Nom
        '
        Me.Lbl_Nom.AutoSize = True
        Me.Lbl_Nom.Location = New System.Drawing.Point(46, 30)
        Me.Lbl_Nom.Name = "Lbl_Nom"
        Me.Lbl_Nom.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_Nom.TabIndex = 6
        Me.Lbl_Nom.Text = "Nom"
        '
        'Detruire_Essence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 126)
        Me.Controls.Add(Me.Lbl_Nom)
        Me.Controls.Add(Me.Btn_Detruire)
        Me.Controls.Add(Me.ComboBox_Essence)
        Me.Name = "Detruire_Essence"
        Me.Text = "Detruire_Essence"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Detruire As Button
    Friend WithEvents ComboBox_Essence As ComboBox
    Friend WithEvents Lbl_Nom As Label
End Class
