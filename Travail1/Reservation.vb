﻿Public Class Reservation
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableTxtBox()
    End Sub
    Sub DisableTxtBox()
        txtDate.Enabled = False
        txtNoEtudiant.Enabled = False
        txtNom.Enabled = False
        txtNoReservation.Enabled = False
        txtPrenom.Enabled = False
    End Sub
End Class