Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Ajout_Fournisseur
    Private Sub Btn_Ajouter_Click(sender As Object, e As EventArgs) Handles Btn_Ajouter.Click
        Dim Cnn As New SqlConnection(MaChaine)
        Dim Cmd As New SqlCommand

        Try
            Cmd.Connection = Cnn
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "Ajouter_Fournisseur"
            Cmd.Parameters.Add("@return", SqlDbType.Int)
            Cmd.Parameters.Add("@Nom_Fournisseur", SqlDbType.NVarChar, 100)
            Cmd.Parameters("@return").Direction = ParameterDirection.ReturnValue
            Cmd.Parameters("@Nom_Fournisseur").Value = txt_Fournisseur.Text

            Cnn.Open()
            Cmd.ExecuteScalar()
            Cnn.Close()
            If Cmd.Parameters("@return").Value = 96 Then
                MessageBox.Show("Le fournisseur desire existe deja")
            Else
                MessageBox.Show("Le fournisseur desire à été ajouté avec succès")
                txt_Fournisseur.Text = ""
                Entente.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Ajout_Fournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class