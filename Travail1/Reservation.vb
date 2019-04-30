Public Class Reservation
    Dim Ds As New AR_EL_Travail_1DataSet
    Dim Ta_ReservationParItems As New AR_EL_Travail_1DataSetTableAdapters.tbl_Reservation_Par_ItemsTableAdapter
    Dim Ta_Arbre As New AR_EL_Travail_1DataSetTableAdapters.tbl_Essences_ArbreTableAdapter
    Dim Ta_Fournisseur As New AR_EL_Travail_1DataSetTableAdapters.tbl_FournisseurTableAdapter
    Dim Ta_Items As New AR_EL_Travail_1DataSetTableAdapters.tbl_ItemsTableAdapter
    Dim Ta_arbre_et_fournisseur As New AR_EL_Travail_1DataSetTableAdapters.arbre_et_fournisseurTableAdapter
    Dim Bs_reservation_par_Items As New BindingSource
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ta_ReservationParItems.FillByPrecis(Ds.tbl_Reservation_Par_Items, txtNoReservation.Text)

        Ta_arbre_et_fournisseur.Fill(Ds.arbre_et_fournisseur, (txtDate.Text).Substring(0, 4))

        dgvDetailsReservation.DataSource = Ds.tbl_Reservation_Par_Items
        dgvDetailsReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        dgvDetailsReservation.Columns("No_Reservation").HeaderText = "No détail"
        dgvDetailsReservation.Columns("Livree").HeaderText = "Livré"
        dgvDetailsReservation.Columns("No_Reservation").ReadOnly = True

        Dim cbbox As New DataGridViewComboBoxColumn
        With cbbox
            .DataPropertyName = "No_Items"
            .HeaderText = "arbre/fournisseur"
            .DataSource = Ds.arbre_et_fournisseur
            .ValueMember = "No_Items"
            .DisplayMember = "arbre_fournisseur"

        End With
        If dgvDetailsReservation.Columns.Contains("No_Items") Then
            dgvDetailsReservation.Columns.Remove("No_Items")
            dgvDetailsReservation.Columns.Insert(2, cbbox)
        End If
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
                If Ds.tbl_Reservation_Par_Items.HasErrors = True Then
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

    Private Sub Reservation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If dgvDetailsReservation.GetCellCount(DataGridViewElementStates.ReadOnly) = 1 Then
            Dim result As Integer = MessageBox.Show("Voulez-vous détruire ce détail et la réservation? ", "destruction", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                recherche_client.dgvReservation.Rows.RemoveAt(recherche_client.dgvReservation.CurrentCell.RowIndex)
                'recherche_client.dgvReservation("No_Reservation", recherche_client.dgvReservation.CurrentCell.RowIndex).Dispose()
                'recherche_client.chargerdgv()
            ElseIf result = DialogResult.No Then
                enregistrer()
            End If
        Else
            enregistrer()
        End If

    End Sub

    Private Sub dgvDetailsReservation_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles dgvDetailsReservation.DefaultValuesNeeded
        Dim place As Integer = (dgvDetailsReservation.GetCellCount(DataGridViewElementStates.ReadOnly) / 1) - 1
        dgvDetailsReservation.Item("No_Reservation", place).Value = txtNoReservation.Text
        dgvDetailsReservation.Item("Livree", place).Value = "non"
        dgvDetailsReservation.Item("Quantite", place).Value = 1


    End Sub
End Class