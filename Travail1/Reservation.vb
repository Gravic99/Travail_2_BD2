Public Class Reservation
    Dim Ds As New AR_EL_Travail_1DataSet
    Dim Ta_ReservationParItems As New AR_EL_Travail_1DataSetTableAdapters.tbl_Reservation_Par_ItemsTableAdapter
    Dim Ta_Arbre As New AR_EL_Travail_1DataSetTableAdapters.tbl_Essences_ArbreTableAdapter
    Dim Ta_Fournisseur As New AR_EL_Travail_1DataSetTableAdapters.tbl_FournisseurTableAdapter
    Dim Ta_Items As New AR_EL_Travail_1DataSetTableAdapters.tbl_ItemsTableAdapter
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ta_ReservationParItems.FillByPrecis(Ds.tbl_Reservation_Par_Items, txtNoReservation.Text, txt)
        dgvDetailsReservation.DataSource = Ds.tbl_Items
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