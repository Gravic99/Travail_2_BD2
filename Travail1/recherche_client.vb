Public Class recherche_client
    Private Sub recherche_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGererReservation_Click(sender As Object, e As EventArgs) Handles btnGererReservation.Click
        Reservation.ShowDialog()

    End Sub
End Class