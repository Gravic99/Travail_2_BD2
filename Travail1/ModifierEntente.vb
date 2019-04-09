Imports System.ComponentModel

Public Class ModifierEntente

    Dim Ds As New AR_EL_Travail_1DataSet
    Dim Ta_View As New AR_EL_Travail_1DataSetTableAdapters.View_EntenteTableAdapter
    Private Sub ModifierEntente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Ta_View.FillByOrder(Ds.View_Entente)
            dgv_entente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            dgv_entente.DataSource = Ds.View_Entente
            dgv_entente.Columns("No_Items").Visible = False
            dgv_entente.Columns("No_fournisseur").Visible = False
            dgv_entente.Columns("No_Essences_Arbre").Visible = False

            dgv_entente.Columns("Essence").ReadOnly = True
            dgv_entente.Columns("Fournisseur").ReadOnly = True
            dgv_entente.Columns("No_Essences_Arbre").ReadOnly = True
            dgv_entente.Columns("Quantite").ReadOnly = True
            dgv_entente.Columns("Annee_Entente").ReadOnly = True

            dgv_entente.Columns("Quantite_Disponible").HeaderText = "Quantité entendu"
            dgv_entente.Columns("Quantite").HeaderText = "Quantité déjà réservée"
            dgv_entente.Columns("Annee_Entente").HeaderText = "Année"

            dgv_entente.AllowUserToAddRows = False
            dgv_entente.AllowUserToDeleteRows = False
            enregistrer()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub btn_enregistrer_Click(sender As Object, e As EventArgs) Handles btn_enregistrer.Click
        enregistrer()
        dgv_entente.Refresh()
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
    Sub enregistrer()

        Try
            If Ds.HasChanges Then
                Ta_View.Adapter.ContinueUpdateOnError = True
                Ta_View.Update(Ds.View_Entente)
                If Ds.View_Entente.HasErrors Then

                    MessageBox.Show("Les données sans erreur ont été enregistrer, mais il reste des erreurs")
                    Dim ligne As DataRow
                    For Each ligne In Ds.tbl_Fournisseur.GetErrors
                        If ligne.RowError.Contains("UNIQUE") Then
                            ligne.RowError = "Entrez un nom unique"
                        End If

                    Next
                Else
                    Ta_View.Update(Ds.View_Entente)
                    MessageBox.Show("Enregistrement réaliser avec succès")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ModifierEntente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            If Ds.HasChanges Then
                Enregistrement()
            End If
            Ds.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgv_entente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_entente.CellContentClick

    End Sub

    Private Sub dgv_entente_CellErrorTextChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_entente.CellErrorTextChanged

    End Sub

    Private Sub dgv_entente_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_entente.CellLeave

    End Sub
End Class