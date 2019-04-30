Public Class recherche_client
    Dim Ds As New AR_EL_Travail_1DataSet
    Dim Ta_Reservation As New AR_EL_Travail_1DataSetTableAdapters.tbl_ReservationTableAdapter
    Dim Ta_Client As New AR_EL_Travail_1DataSetTableAdapters.tbl_ClientTableAdapter
    Dim Bs_Client As New BindingSource
    Dim Bs_Reservation As New BindingSource

    Private Sub recherche_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNom.Text = ""
        dgvClient.Refresh()
        dgvReservation.Refresh()
    End Sub

    Private Sub btnGererReservation_Click(sender As Object, e As EventArgs) Handles btnGererReservation.Click

        Reservation.txtNoReservation.Text = dgvReservation.Item(0, dgvReservation.CurrentRow.Index).Value
        Reservation.txtNoClient.Text = dgvClient.Item(0, dgvClient.CurrentRow.Index).Value
        Reservation.txtPrenom.Text = dgvClient.Item(2, dgvClient.CurrentRow.Index).Value
        Reservation.txtNom.Text = dgvClient.Item(1, dgvClient.CurrentRow.Index).Value
        Reservation.txtDate.Text = dgvReservation.Item(1, dgvReservation.CurrentRow.Index).Value
        Reservation.ShowDialog()
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        Try
            If Ds.HasChanges Then
                Enregistrement()
            End If
            chargerdgv()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub chargerdgv()
        Ta_Client.FillByRecherche(Ds.tbl_Client, txtNom.Text)
        Ta_Reservation.Fill(Ds.tbl_Reservation)

        Bs_Client.DataSource = Ds
        Bs_Client.DataMember = "tbl_Client"

        Bs_Reservation.DataSource = Bs_Client
        Bs_Reservation.DataMember = "FK__tbl_Reser__No_Cl__1B0907CE"

        dgvClient.DataSource = Bs_Client
        dgvReservation.DataSource = Bs_Reservation

        dgvClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        dgvReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        dgvReservation.Columns("No_Reservation").HeaderText = "No Réservation"
        dgvReservation.Columns("Date_reservation").HeaderText = "Date réservation"

        dgvClient.Columns("No_Client").HeaderText = "No client"
        dgvClient.AllowUserToAddRows = False
        dgvClient.AllowUserToDeleteRows = False
        dgvClient.ReadOnly = True
        dgvReservation.Columns("No_Client").Visible = False
        dgvReservation.ReadOnly = True
    End Sub


    Private Sub dgvReservation_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles dgvReservation.DefaultValuesNeeded
        Dim place As Integer = (dgvReservation.GetCellCount(DataGridViewElementStates.ReadOnly) / 3) - 1
        dgvReservation.Item("Date_reservation", place).Value = Date.Today()
        sender.BindingContext(sender.DataSource).EndCurrentEdit()
        Dim result As Integer = MessageBox.Show("Voulez-vous ajouter les détails? ", "Option", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            enregistrer()
            Reservation.txtNoReservation.Text = dgvReservation.Item(0, dgvReservation.CurrentRow.Index).Value
            Reservation.txtNoClient.Text = dgvClient.Item(0, dgvClient.CurrentRow.Index).Value
            Reservation.txtPrenom.Text = dgvClient.Item(2, dgvClient.CurrentRow.Index).Value
            Reservation.txtNom.Text = dgvClient.Item(1, dgvClient.CurrentRow.Index).Value
            Reservation.txtDate.Text = dgvReservation.Item(1, dgvReservation.CurrentRow.Index).Value
            Reservation.ShowDialog()
        End If
    End Sub

    Private Sub btnEnregistrerReservation_Click(sender As Object, e As EventArgs) Handles btnEnregistrerReservation.Click
        enregistrer()
    End Sub
    Sub enregistrer()

        Try
            If Ds.HasChanges Then
                Ta_Reservation.Update(Ds.tbl_Reservation)
                MessageBox.Show("enregistrement réussi")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub Enregistrement()

        Dim reponse As String
        If Ds.HasChanges = True Then
            reponse = MessageBox.Show("Voulez-vous enregistrer vos changement?", "changement", MessageBoxButtons.YesNo)
            If reponse = vbYes Then
                enregistrer()
            End If
        End If

    End Sub

    Private Sub recherche_client_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Ds.HasChanges Then
                Enregistrement()
            End If
            Ds.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvReservation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservation.CellContentClick

    End Sub
End Class