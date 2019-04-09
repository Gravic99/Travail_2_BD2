Imports System.Data.SqlClient
Public Class Menu
    Private Sub AjoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutToolStripMenuItem.Click
        Ajout_Essence.ShowDialog()
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click
        Modifier_Essence.ShowDialog()
    End Sub

    Private Sub DétruireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DétruireToolStripMenuItem.Click
        Detruire_Essence.ShowDialog()
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        Entente.ShowDialog()
    End Sub

    Private Sub AjoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AjoutToolStripMenuItem1.Click
        Ajout_Fournisseur.ShowDialog()


    End Sub

    Private Sub GererToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GererToolStripMenuItem.Click
        Gerer_Fournisseur.ShowDialog()
    End Sub

    Private Sub ModifierEntenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierEntenteToolStripMenuItem.Click
        ModifierEntente.ShowDialog()
    End Sub
End Class
