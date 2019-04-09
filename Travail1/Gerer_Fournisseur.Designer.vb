<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerer_Fournisseur
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
        Me.dgv_Fournisser = New System.Windows.Forms.DataGridView()
        Me.btn_enregistrer = New System.Windows.Forms.Button()
        Me.lbl_fournisseur = New System.Windows.Forms.Label()
        CType(Me.dgv_Fournisser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Fournisser
        '
        Me.dgv_Fournisser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Fournisser.Location = New System.Drawing.Point(12, 134)
        Me.dgv_Fournisser.Name = "dgv_Fournisser"
        Me.dgv_Fournisser.Size = New System.Drawing.Size(493, 208)
        Me.dgv_Fournisser.TabIndex = 0
        '
        'btn_enregistrer
        '
        Me.btn_enregistrer.Location = New System.Drawing.Point(404, 404)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(75, 23)
        Me.btn_enregistrer.TabIndex = 1
        Me.btn_enregistrer.Text = "Enregistrer"
        Me.btn_enregistrer.UseVisualStyleBackColor = True
        '
        'lbl_fournisseur
        '
        Me.lbl_fournisseur.AutoSize = True
        Me.lbl_fournisseur.Location = New System.Drawing.Point(203, 75)
        Me.lbl_fournisseur.Name = "lbl_fournisseur"
        Me.lbl_fournisseur.Size = New System.Drawing.Size(61, 13)
        Me.lbl_fournisseur.TabIndex = 2
        Me.lbl_fournisseur.Text = "Fournisseur"
        '
        'Gerer_Fournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 451)
        Me.Controls.Add(Me.lbl_fournisseur)
        Me.Controls.Add(Me.btn_enregistrer)
        Me.Controls.Add(Me.dgv_Fournisser)
        Me.Name = "Gerer_Fournisseur"
        Me.Text = "Gerer_Fournisseur"
        CType(Me.dgv_Fournisser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Fournisser As DataGridView
    Friend WithEvents btn_enregistrer As Button
    Friend WithEvents lbl_fournisseur As Label
End Class
