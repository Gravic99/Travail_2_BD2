

Partial Class AR_EL_Travail_1DataSet
    Partial Public Class tbl_Reservation_Par_ItemsDataTable
        Private Sub tbl_Reservation_Par_ItemsDataTable_tbl_Reservation_Par_ItemsRowChanging(sender As Object, e As tbl_Reservation_Par_ItemsRowChangeEvent) Handles Me.tbl_Reservation_Par_ItemsRowChanging

        End Sub

    End Class

    Partial Public Class View_EntenteDataTable
        Private Sub View_EntenteDataTable_View_EntenteRowChanging(sender As Object, e As View_EntenteRowChangeEvent) Handles Me.View_EntenteRowChanging
            If e.Row.IsNull("Quantite_Disponible") Or e.Row.IsNull("Quantite") Then

            Else

                If e.Row.Quantite > e.Row.Quantite_Disponible Then
                    e.Row.SetColumnError("Quantite_Disponible", "La quantité entendu doit être plus grande que la quantité déjà réservé")

                Else
                    e.Row.ClearErrors()
                End If
            End If

        End Sub

    End Class
End Class
