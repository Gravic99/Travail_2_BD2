Public Class Reservation
    Dim Ds As New AR_EL_Travail_1DataSet
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DisableTxtBox()
    End Sub
    Sub DisableTxtBox()
        txtDate.Enabled = False
        txtNoClient.Enabled = False
        txtNom.Enabled = False
        txtNoReservation.Enabled = False
        txtPrenom.Enabled = False
    End Sub
End Class