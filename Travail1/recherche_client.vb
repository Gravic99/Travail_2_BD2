Public Class recherche_client
    Dim Ds As New AR_EL_Travail_1DataSet
    Dim Ta_Reservation As New AR_EL_Travail_1DataSetTableAdapters.tbl_ReservationTableAdapter
    Dim Ta_Client As New AR_EL_Travail_1DataSetTableAdapters.tbl_ClientTableAdapter
    Dim Bs_Client As New BindingSource
    Dim Bs_Reservation As New BindingSource

    Private Sub recherche_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNom.Text = ""

    End Sub

    Private Sub btnGererReservation_Click(sender As Object, e As EventArgs) Handles btnGererReservation.Click

        'Reservation.txtNoReservation.Text = 
        'Reservation.txtNoEtudiant.Text =
        'Reservation.txtPrenom.Text
        'Reservation.txtNom.text = 
        'Reservation.txtDate.Text = 
        Reservation.ShowDialog()

    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        Try
            Ta_Client.FillByRecherche(Ds.tbl_Client, txtNom.Text)
            Ta_Reservation.Fill(Ds.tbl_Reservation)

            Bs_Client.DataSource = Ds
            Bs_Client.DataMember = "tbl_Client"

            Bs_Reservation.DataSource = Bs_Client
            Bs_Reservation.DataMember = "FK_No_Reservation"

            dgvClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            dgvReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

            dgvClient.AllowUserToAddRows = False
            dgvClient.AllowUserToDeleteRows = False
            dgvClient.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class