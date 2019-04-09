Imports System.Data.SqlClient
Public Class Ajout_Essence
    Private Sub Btn_Ajouter_Click(sender As Object, e As EventArgs) Handles Btn_Ajouter.Click
        Dim Cnn As New SqlConnection(MaChaine)
        Dim Cmd As New SqlCommand

        Try
            Cmd.Connection = Cnn
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "Ajouter_Essence"
            Cmd.Parameters.Add("@return", SqlDbType.Int)
            Cmd.Parameters.Add("@Nom_Essence", SqlDbType.NVarChar, 100)
            Cmd.Parameters("@return").Direction = ParameterDirection.ReturnValue
            Cmd.Parameters("@Nom_Essence").Value = Txt_description.Text

            Cnn.Open()
            Cmd.ExecuteScalar()
            Cnn.Close()
            If Cmd.Parameters("@return").Value = 99 Then
                MessageBox.Show("L'essence desire existe deja")
            Else
                Txt_description.Text = ""
                MessageBox.Show("Essence ajouté avec succès")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class