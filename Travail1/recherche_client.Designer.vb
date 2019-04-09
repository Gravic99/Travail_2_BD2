<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recherche_client
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
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.dgvClient = New System.Windows.Forms.DataGridView()
        Me.dgvReservation = New System.Windows.Forms.DataGridView()
        Me.btnEnregistrerReservation = New System.Windows.Forms.Button()
        Me.btnGererReservation = New System.Windows.Forms.Button()
        Me.lblReservation = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReservation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Location = New System.Drawing.Point(21, 35)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(115, 13)
        Me.lbl_nom.TabIndex = 0
        Me.lbl_nom.Text = "Nom complet ou partiel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRechercher)
        Me.GroupBox1.Controls.Add(Me.lbl_nom)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 88)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche"
        '
        'btnRechercher
        '
        Me.btnRechercher.Location = New System.Drawing.Point(259, 35)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(75, 23)
        Me.btnRechercher.TabIndex = 3
        Me.btnRechercher.Text = "Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = True
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(142, 35)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 2
        '
        'dgvClient
        '
        Me.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClient.Location = New System.Drawing.Point(43, 153)
        Me.dgvClient.Name = "dgvClient"
        Me.dgvClient.Size = New System.Drawing.Size(631, 150)
        Me.dgvClient.TabIndex = 2
        '
        'dgvReservation
        '
        Me.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservation.Location = New System.Drawing.Point(43, 340)
        Me.dgvReservation.Name = "dgvReservation"
        Me.dgvReservation.Size = New System.Drawing.Size(631, 150)
        Me.dgvReservation.TabIndex = 3
        '
        'btnEnregistrerReservation
        '
        Me.btnEnregistrerReservation.Location = New System.Drawing.Point(276, 568)
        Me.btnEnregistrerReservation.Name = "btnEnregistrerReservation"
        Me.btnEnregistrerReservation.Size = New System.Drawing.Size(174, 23)
        Me.btnEnregistrerReservation.TabIndex = 4
        Me.btnEnregistrerReservation.Text = "Enregistrer les réservations"
        Me.btnEnregistrerReservation.UseVisualStyleBackColor = True
        '
        'btnGererReservation
        '
        Me.btnGererReservation.Location = New System.Drawing.Point(486, 568)
        Me.btnGererReservation.Name = "btnGererReservation"
        Me.btnGererReservation.Size = New System.Drawing.Size(188, 23)
        Me.btnGererReservation.TabIndex = 5
        Me.btnGererReservation.Text = "Gérer la réservation sélectionnée" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnGererReservation.UseVisualStyleBackColor = True
        '
        'lblReservation
        '
        Me.lblReservation.AutoSize = True
        Me.lblReservation.Location = New System.Drawing.Point(40, 324)
        Me.lblReservation.Name = "lblReservation"
        Me.lblReservation.Size = New System.Drawing.Size(69, 13)
        Me.lblReservation.TabIndex = 4
        Me.lblReservation.Text = "Réservations"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Location = New System.Drawing.Point(40, 137)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(38, 13)
        Me.lblClient.TabIndex = 5
        Me.lblClient.Text = "Clients"
        '
        'recherche_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 619)
        Me.Controls.Add(Me.lblReservation)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.btnGererReservation)
        Me.Controls.Add(Me.btnEnregistrerReservation)
        Me.Controls.Add(Me.dgvReservation)
        Me.Controls.Add(Me.dgvClient)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "recherche_client"
        Me.Text = "recherche_client"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReservation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_nom As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents btnRechercher As Button
    Friend WithEvents dgvClient As DataGridView
    Friend WithEvents dgvReservation As DataGridView
    Friend WithEvents btnEnregistrerReservation As Button
    Friend WithEvents btnGererReservation As Button
    Friend WithEvents lblReservation As Label
    Friend WithEvents lblClient As Label
End Class
