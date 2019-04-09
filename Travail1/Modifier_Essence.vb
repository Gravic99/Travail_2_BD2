Imports System.Data.SqlClient
Public Class Modifier_Essence
    Private Sub Modifier_Essence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Remplir_Combobox_Essence()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Modifier_Click(sender As Object, e As EventArgs) Handles Btn_Modifier.Click
        Try
            Dim Connexion As New SqlConnection(MaChaine)
            Dim commande As New SqlCommand
            Dim Dr As SqlDataReader

            commande.Connection = Connexion
            commande.CommandType = CommandType.StoredProcedure
            commande.CommandText = "Modifier_Essence"
            commande.Parameters.Add("@return", SqlDbType.Int)
            commande.Parameters.Add("@Ancien_Nom_Essence", SqlDbType.NVarChar, 100)
            commande.Parameters.Add("@Nouveau_Nom_Essence", SqlDbType.NVarChar, 100)
            commande.Parameters("@return").Direction = ParameterDirection.ReturnValue
            commande.Parameters("@Ancien_Nom_Essence").Value = ComboBox_Essence.Text
            commande.Parameters("@Nouveau_Nom_Essence").Value = Txt_description.Text



            If Txt_description.Text <> "" And ComboBox_Essence.Text <> "" Then

                Connexion.Open()
                Dr = commande.ExecuteScalar
                Connexion.Close()
                If commande.Parameters("@return").Value = 94 Then
                    MessageBox.Show("Entrer une essence valide")
                Else
                    MessageBox.Show("La modifiction à été effectué")
                    ComboBox_Essence.Text = ""
                    Txt_description.Text = ""
                    Remplir_Combobox_Essence()
                End If

            Else
                MessageBox.Show("Tous les champs doivent être remplis")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Sub Remplir_Combobox_Essence()
        Dim Connexion As New SqlConnection(MaChaine)
        Dim commande As New SqlCommand
        Dim Dr As SqlDataReader
        ComboBox_Essence.Items.Clear()
        Connexion.Open()
        commande.Connection = Connexion
        commande.CommandText = "select No_Essences_Arbre,Nom  from tbl_Essences_Arbre order by Nom"
        Dr = commande.ExecuteReader
        While Dr.Read = True
            ComboBox_Essence.Items.Add(Dr.Item("Nom"))

        End While
        Connexion.Close()
    End Sub
End Class