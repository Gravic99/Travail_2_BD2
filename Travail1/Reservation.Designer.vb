<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Me.components = New System.ComponentModel.Container()
        Me.lblReservation = New System.Windows.Forms.Label()
        Me.lblNoReservation = New System.Windows.Forms.Label()
        Me.lblNoClient = New System.Windows.Forms.Label()
        Me.txtNoReservation = New System.Windows.Forms.TextBox()
        Me.txtNoClient = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDetailsReservation = New System.Windows.Forms.Label()
        Me.dgvDetailsReservation = New System.Windows.Forms.DataGridView()
        Me.btnEnregistrerDetailsReservation = New System.Windows.Forms.Button()
        Me.AR_EL_Travail_1DataSet = New Travail1.AR_EL_Travail_1DataSet()
        Me.TblReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_ReservationTableAdapter = New Travail1.AR_EL_Travail_1DataSetTableAdapters.tbl_ReservationTableAdapter()
        Me.ARELTravail1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblReservationParItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Reservation_Par_ItemsTableAdapter = New Travail1.AR_EL_Travail_1DataSetTableAdapters.tbl_Reservation_Par_ItemsTableAdapter()
        CType(Me.dgvDetailsReservation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AR_EL_Travail_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARELTravail1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblReservationParItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblReservation
        '
        Me.lblReservation.AutoSize = True
        Me.lblReservation.Location = New System.Drawing.Point(12, 9)
        Me.lblReservation.Name = "lblReservation"
        Me.lblReservation.Size = New System.Drawing.Size(64, 13)
        Me.lblReservation.TabIndex = 0
        Me.lblReservation.Text = "Réservation"
        '
        'lblNoReservation
        '
        Me.lblNoReservation.AutoSize = True
        Me.lblNoReservation.Location = New System.Drawing.Point(25, 29)
        Me.lblNoReservation.Name = "lblNoReservation"
        Me.lblNoReservation.Size = New System.Drawing.Size(76, 13)
        Me.lblNoReservation.TabIndex = 1
        Me.lblNoReservation.Text = "No réservation"
        '
        'lblNoClient
        '
        Me.lblNoClient.AutoSize = True
        Me.lblNoClient.Location = New System.Drawing.Point(25, 54)
        Me.lblNoClient.Name = "lblNoClient"
        Me.lblNoClient.Size = New System.Drawing.Size(50, 13)
        Me.lblNoClient.TabIndex = 2
        Me.lblNoClient.Text = "No Client"
        '
        'txtNoReservation
        '
        Me.txtNoReservation.Location = New System.Drawing.Point(107, 26)
        Me.txtNoReservation.Name = "txtNoReservation"
        Me.txtNoReservation.Size = New System.Drawing.Size(100, 20)
        Me.txtNoReservation.TabIndex = 3
        '
        'txtNoClient
        '
        Me.txtNoClient.Location = New System.Drawing.Point(107, 51)
        Me.txtNoClient.Name = "txtNoClient"
        Me.txtNoClient.Size = New System.Drawing.Size(100, 20)
        Me.txtNoClient.TabIndex = 4
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(107, 77)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtPrenom.TabIndex = 6
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(25, 80)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(43, 13)
        Me.lblPrenom.TabIndex = 5
        Me.lblPrenom.Text = "Prénom"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(107, 103)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 8
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(25, 106)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(29, 13)
        Me.lblNom.TabIndex = 7
        Me.lblNom.Text = "Nom"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(325, 26)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 10
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(243, 29)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 9
        Me.lblDate.Text = "Date"
        '
        'lblDetailsReservation
        '
        Me.lblDetailsReservation.AutoSize = True
        Me.lblDetailsReservation.Location = New System.Drawing.Point(25, 152)
        Me.lblDetailsReservation.Name = "lblDetailsReservation"
        Me.lblDetailsReservation.Size = New System.Drawing.Size(120, 13)
        Me.lblDetailsReservation.TabIndex = 11
        Me.lblDetailsReservation.Text = "Détails de la réservation"
        '
        'dgvDetailsReservation
        '
        Me.dgvDetailsReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetailsReservation.Location = New System.Drawing.Point(28, 180)
        Me.dgvDetailsReservation.Name = "dgvDetailsReservation"
        Me.dgvDetailsReservation.Size = New System.Drawing.Size(738, 211)
        Me.dgvDetailsReservation.TabIndex = 12
        '
        'btnEnregistrerDetailsReservation
        '
        Me.btnEnregistrerDetailsReservation.Location = New System.Drawing.Point(606, 404)
        Me.btnEnregistrerDetailsReservation.Name = "btnEnregistrerDetailsReservation"
        Me.btnEnregistrerDetailsReservation.Size = New System.Drawing.Size(160, 34)
        Me.btnEnregistrerDetailsReservation.TabIndex = 13
        Me.btnEnregistrerDetailsReservation.Text = "Enregistrer la réservation"
        Me.btnEnregistrerDetailsReservation.UseVisualStyleBackColor = True
        '
        'AR_EL_Travail_1DataSet
        '
        Me.AR_EL_Travail_1DataSet.DataSetName = "AR_EL_Travail_1DataSet"
        Me.AR_EL_Travail_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblReservationBindingSource
        '
        Me.TblReservationBindingSource.DataMember = "tbl_Reservation"
        Me.TblReservationBindingSource.DataSource = Me.AR_EL_Travail_1DataSet
        '
        'Tbl_ReservationTableAdapter
        '
        Me.Tbl_ReservationTableAdapter.ClearBeforeFill = True
        '
        'ARELTravail1DataSetBindingSource
        '
        Me.ARELTravail1DataSetBindingSource.DataSource = Me.AR_EL_Travail_1DataSet
        Me.ARELTravail1DataSetBindingSource.Position = 0
        '
        'TblReservationParItemsBindingSource
        '
        Me.TblReservationParItemsBindingSource.DataMember = "tbl_Reservation_Par_Items"
        Me.TblReservationParItemsBindingSource.DataSource = Me.ARELTravail1DataSetBindingSource
        '
        'Tbl_Reservation_Par_ItemsTableAdapter
        '
        Me.Tbl_Reservation_Par_ItemsTableAdapter.ClearBeforeFill = True
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnregistrerDetailsReservation)
        Me.Controls.Add(Me.dgvDetailsReservation)
        Me.Controls.Add(Me.lblDetailsReservation)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.txtNoClient)
        Me.Controls.Add(Me.txtNoReservation)
        Me.Controls.Add(Me.lblNoClient)
        Me.Controls.Add(Me.lblNoReservation)
        Me.Controls.Add(Me.lblReservation)
        Me.Name = "Reservation"
        Me.Text = "Reservation"
        CType(Me.dgvDetailsReservation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AR_EL_Travail_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARELTravail1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblReservationParItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblReservation As Label
    Friend WithEvents lblNoReservation As Label
    Friend WithEvents lblNoClient As Label
    Friend WithEvents txtNoReservation As TextBox
    Friend WithEvents txtNoClient As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents lblPrenom As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDetailsReservation As Label
    Friend WithEvents dgvDetailsReservation As DataGridView
    Friend WithEvents btnEnregistrerDetailsReservation As Button
    Friend WithEvents AR_EL_Travail_1DataSet As AR_EL_Travail_1DataSet
    Friend WithEvents TblReservationBindingSource As BindingSource
    Friend WithEvents Tbl_ReservationTableAdapter As AR_EL_Travail_1DataSetTableAdapters.tbl_ReservationTableAdapter
    Friend WithEvents ARELTravail1DataSetBindingSource As BindingSource
    Friend WithEvents TblReservationParItemsBindingSource As BindingSource
    Friend WithEvents Tbl_Reservation_Par_ItemsTableAdapter As AR_EL_Travail_1DataSetTableAdapters.tbl_Reservation_Par_ItemsTableAdapter
End Class
