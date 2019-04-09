Imports System.Data.SqlClient
Public Class Entente
    Private Sub Btn_Ajouter_Click(sender As Object, e As EventArgs) Handles Btn_Ajouter.Click

        Try
            Dim UneAnnee = Year(Now)
            If (ComboBox_Fournisseur.Text <> "" And ComboBox_Essence.Text <> "" And Txt_Annee.Text > 0 And Txt_Prix.Text >= 0 And Txt_Quantite_Entente.Text > 0) Then
                Dim Cnn As New SqlConnection(MaChaine)
                Dim Cmd As New SqlCommand
                Cmd.Connection = Cnn
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.CommandText = "Ajout_Entente"
                Cmd.Parameters.Add("@return", SqlDbType.Int)
                Cmd.Parameters.Add("@Nom_Fournisseur", SqlDbType.NVarChar, 100)
                Cmd.Parameters.Add("@Nom_Essence", SqlDbType.NVarChar, 100)
                Cmd.Parameters.Add("@Annee_Entente", SqlDbType.Int)
                Cmd.Parameters.Add("@Prix", SqlDbType.Money)
                Cmd.Parameters.Add("@Quantite_Disponible", SqlDbType.Int)
                Cmd.Parameters("@return").Direction = ParameterDirection.ReturnValue
                Cmd.Parameters("@Nom_Fournisseur").Value = ComboBox_Fournisseur.Text
                Cmd.Parameters("@Nom_Essence").Value = ComboBox_Essence.Text
                Cmd.Parameters("@Annee_Entente").Value = Txt_Annee.Text
                Cmd.Parameters("@Prix").Value = Txt_Prix.Text
                Cmd.Parameters("@Quantite_Disponible").Value = Txt_Quantite_Entente.Text
                Cnn.Open()
                Cmd.ExecuteNonQuery()

                Cnn.Close()
                If Cmd.Parameters("@return").Value = 98 Then
                    MessageBox.Show("L'entente desire existe deja pour l'annee choisie")
                Else
                    ComboBox_Fournisseur.Text = ""
                    ComboBox_Essence.Text = ""
                    Txt_Annee.Text = ""
                    Txt_Prix.Text = ""
                    Txt_Quantite_Entente.Text = ""
                    MessageBox.Show("L'entente à été effectué")
                End If

            Else
                If Txt_Prix.Text < 0 Then
                    MessageBox.Show("Le prix doit être plus grand ou égal que 0")
                End If
                If Txt_Quantite_Entente.Text < 0 Then
                    MessageBox.Show("La quantité doit être plus grand ou égal que 0")
                End If
                If Txt_Annee.Text < UneAnnee Then
                    MessageBox.Show("L'année doit être plus grand ou égal que cette année")
                End If
                MessageBox.Show("Tous les champs doivent être remplis.")
            End If


        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)
        End Try
    End Sub

    Sub Remplir_Combobox_Fourniseur()
        ComboBox_Fournisseur.Items.Clear()
        Dim Connexion As New SqlConnection(MaChaine)
        Dim commande As New SqlCommand
        Dim Dr As SqlDataReader
        Connexion.Open()
        commande.Connection = Connexion
        commande.CommandText = "select No_Fournisseur,Nom  from tbl_Fournisseur order by Nom"
        Dr = commande.ExecuteReader
        While Dr.Read = True
            ComboBox_Fournisseur.Items.Add(Dr.Item("Nom"))

        End While
        Connexion.Close()

    End Sub

    Sub Remplir_Combobox_Essence()
        ComboBox_Essence.Items.Clear()
        Dim Connexion As New SqlConnection(MaChaine)
        Dim commande As New SqlCommand
        Dim Dr As SqlDataReader
        Connexion.Open()
        commande.Connection = Connexion
        commande.CommandText = "select No_Essences_Arbre,Nom  from tbl_Essences_Arbre order by Nom"
        Dr = commande.ExecuteReader
        While Dr.Read = True
            ComboBox_Essence.Items.Add(Dr.Item("Nom"))

        End While
        Connexion.Close()

    End Sub
    Sub Remplir_Combobox()
        Remplir_Combobox_Fourniseur()
        Remplir_Combobox_Essence()
    End Sub

    Private Sub Entente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Remplir_Combobox()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btn_ajouter_fournisseur_Click(sender As Object, e As EventArgs) Handles Btn_ajouter_fournisseur.Click
        Ajout_Fournisseur.ShowDialog()
        Remplir_Combobox()
    End Sub

    Private Sub Btn_ajouter_Essence_Click(sender As Object, e As EventArgs) Handles Btn_ajouter_Essence.Click
        Ajout_Essence.ShowDialog()
        Remplir_Combobox()
    End Sub

End Class