Public Class Gerer_Fournisseur


    Dim Ds As New AR_EL_Travail_1DataSet
    Dim Ta_Fournisseur As New AR_EL_Travail_1DataSetTableAdapters.tbl_FournisseurTableAdapter
    Dim Ta_Items As New AR_EL_Travail_1DataSetTableAdapters.tbl_ItemsTableAdapter

    Private Sub Gerer_Fournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Ta_Fournisseur.FillByOrderNom(Ds.tbl_Fournisseur)
            Ta_Items.Fill(Ds.tbl_Items)
            dgv_Fournisser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            dgv_Fournisser.DataSource = Ds.tbl_Fournisseur
            dgv_Fournisser.Columns("No_fournisseur").ReadOnly = True

            enregistrer()
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
    Sub enregistrer()

        Try
            If Ds.HasChanges Then
                Ta_Fournisseur.Adapter.ContinueUpdateOnError = True
                Ta_Fournisseur.Update(Ds.tbl_Fournisseur)
                If Ds.tbl_Fournisseur.HasErrors = True Then
                    MessageBox.Show("Les données sans erreur ont été enregistrer, mais il reste des erreurs")
                    Dim ligne As DataRow
                    For Each ligne In Ds.tbl_Fournisseur.GetErrors
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

    Private Sub btn_enregistrer_Click(sender As Object, e As EventArgs) Handles btn_enregistrer.Click

        enregistrer()

    End Sub

    Private Sub Gerer_Fournisseur_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Ds.HasChanges Then
                Enregistrement()

            End If
            Ds.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub dgv_Fournisser_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgv_Fournisser.DataError


        If e.Exception.Message.Contains("Impossible de supprimer cette ligne") Then
            MessageBox.Show("Impossible de supprimer le fournisseur car il a fait des dons")
        Else
            MessageBox.Show(e.Exception.Message)
        End If


    End Sub


End Class