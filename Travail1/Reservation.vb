Public Class Reservation
    Dim Ds As New AR_EL_Travail_1DataSet
    Dim Ta_ReservationParItems As New AR_EL_Travail_1DataSetTableAdapters.tbl_Reservation_Par_ItemsTableAdapter
    Dim Ta_Arbre As New AR_EL_Travail_1DataSetTableAdapters.tbl_Essences_ArbreTableAdapter
    Dim Ta_Fournisseur As New AR_EL_Travail_1DataSetTableAdapters.tbl_FournisseurTableAdapter
    Dim Ta_Items As New AR_EL_Travail_1DataSetTableAdapters.tbl_ItemsTableAdapter
    Dim Bs_reservation_par_Items As New BindingSource
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bs_reservation_par_Items.DataSource = Ds
        Bs_reservation_par_Items.DataMember = "tbl_Reservation_Par_Items"
        Ta_Items.Fill(Ds.tbl_Items)

        Ta_ReservationParItems.FillByPrecis(Ds.tbl_Reservation_Par_Items, txtNoReservation.Text)
        dgvDetailsReservation.DataSource = Bs_reservation_par_Items
        dgvDetailsReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        dgvDetailsReservation.Columns("No_Reservation").HeaderText = "No détail"
        dgvDetailsReservation.Columns("No_Items").HeaderText = "Arbre / Fournisseur"
        dgvDetailsReservation.Columns("Livree").HeaderText = "Livré"
        dgvDetailsReservation.Columns("No_Reservation").ReadOnly = True
        dgvDetailsReservation.Columns("No_Items").ReadOnly = True

        'Dim cbbox As New DataGridViewComboBoxColumn
        'With cbbox
        '    .DataPropertyName = "No_Items"
        '    .HeaderText = "No_Items"
        '    .DataSource = Ta_Items
        '    .ValueMember = "Arbre_Fournisseur"
        '    .DisplayMember = "Arbre / fournisseur"

        'End With
        'If dgvDetailsReservation.Columns.Contains("No_DA") Then
        '    dgvDetailsReservation.Columns.Remove("No_DA")
        '    dgvDetailsReservation.Columns.Insert(2, cbbox)
        'End If
        DisableTxtBox()
    End Sub
    Sub DisableTxtBox()
        txtDate.Enabled = False
        txtNoClient.Enabled = False
        txtNom.Enabled = False
        txtNoReservation.Enabled = False
        txtPrenom.Enabled = False
    End Sub

    Private Sub btnEnregistrerDetailsReservation_Click(sender As Object, e As EventArgs) Handles btnEnregistrerDetailsReservation.Click
        enregistrer()
    End Sub
    Sub enregistrer()
        Try
            If Ds.HasChanges Then
                Ta_ReservationParItems.Adapter.ContinueUpdateOnError = True
                Ta_ReservationParItems.Update(Ds.tbl_Reservation_Par_Items)
                If Ds.tbl_Fournisseur.HasErrors = True Then
                    MessageBox.Show("Les données sans erreur ont été enregistrer, mais il reste des erreurs")
                    Dim ligne As DataRow
                    For Each ligne In Ds.tbl_Reservation_Par_Items.GetErrors
                        If ligne.RowError.Contains("UNIQUE") Then
                            ligne.RowError = "Entrez un nom unique"
                        End If

                    Next
                Else
                    MessageBox.Show("Enregistrement réaliser avec succès")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub dgvDetailsReservation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetailsReservation.CellContentClick

    End Sub
End Class