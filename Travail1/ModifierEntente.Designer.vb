<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifierEntente
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
        Me.dgv_entente = New System.Windows.Forms.DataGridView()
        Me.lbl_entente = New System.Windows.Forms.Label()
        Me.btn_enregistrer = New System.Windows.Forms.Button()
        CType(Me.dgv_entente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_entente
        '
        Me.dgv_entente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_entente.Location = New System.Drawing.Point(12, 104)
        Me.dgv_entente.Name = "dgv_entente"
        Me.dgv_entente.Size = New System.Drawing.Size(776, 229)
        Me.dgv_entente.TabIndex = 0
        '
        'lbl_entente
        '
        Me.lbl_entente.AutoSize = True
        Me.lbl_entente.Location = New System.Drawing.Point(344, 73)
        Me.lbl_entente.Name = "lbl_entente"
        Me.lbl_entente.Size = New System.Drawing.Size(44, 13)
        Me.lbl_entente.TabIndex = 1
        Me.lbl_entente.Text = "Entente"
        '
        'btn_enregistrer
        '
        Me.btn_enregistrer.Location = New System.Drawing.Point(577, 369)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(75, 23)
        Me.btn_enregistrer.TabIndex = 2
        Me.btn_enregistrer.Text = "Enregistrer"
        Me.btn_enregistrer.UseVisualStyleBackColor = True
        '
        'ModifierEntente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_enregistrer)
        Me.Controls.Add(Me.lbl_entente)
        Me.Controls.Add(Me.dgv_entente)
        Me.Name = "ModifierEntente"
        Me.Text = "ModifierEntente"
        CType(Me.dgv_entente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_entente As DataGridView
    Friend WithEvents lbl_entente As Label
    Friend WithEvents btn_enregistrer As Button
End Class
