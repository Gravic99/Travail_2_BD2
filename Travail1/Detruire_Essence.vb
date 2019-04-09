Imports System.Data.SqlClient
Public Class Detruire_Essence
    Private Sub Btn_Detruire_Click(sender As Object, e As EventArgs) Handles Btn_Detruire.Click
        Dim Cnn As New SqlConnection(MaChaine)
        Dim Cmd As New SqlCommand

        Dim resultat As Integer = MessageBox.Show("êtes-vous sûr de vouloir détruire l'essence désiré?", "Validation", MessageBoxButtons.YesNo)
        If resultat = DialogResult.Yes Then

            Try
                Cmd.Connection = Cnn
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.CommandText = "Detruire_Essence"
                Cmd.Parameters.Add("@return", SqlDbType.Int)
                Cmd.Parameters.Add("@Nom_Essence", SqlDbType.NVarChar, 100)
                Cmd.Parameters("@return").Direction = ParameterDirection.ReturnValue
                Cmd.Parameters("@Nom_Essence").Value = ComboBox_Essence.Text


                Cnn.Open()
                Cmd.ExecuteScalar()
                Cnn.Close()
                If Cmd.Parameters("@return").Value = 97 Then
                    MessageBox.Show("L'essence ne peux pas être détruite car elle est utilisé dans une entente")
                ElseIf Cmd.Parameters("@return").Value = 95 Then
                    MessageBox.Show("L'essence n'existe pas")

                Else
                    MessageBox.Show("La destruction à été effectué")
                    Remplir_Combobox_Essence()
                    ComboBox_Essence.Text = ""
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

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

    Private Sub Detruire_Essence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Remplir_Combobox_Essence()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class