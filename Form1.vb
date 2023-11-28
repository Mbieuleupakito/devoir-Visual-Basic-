Public Class Form1







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prod As New Emprunt()

        prod.labelnomlecteur = labelnomlecteur.Text
        prod.labelcodeouvrage = labelcodeouvrage.Text
        prod.labelouvrage = labelouvrage.Text

        prod.labeltitre = labeltitre.Text
        prod.labelnombre = labelnombre.Text


        If prod.valider() = True Then
            Form2.Label1.Text = prod.labelnomlecteur
            Form2.Label2.Text = prod.labelcodeouvrage
            Form2.Label3.Text = prod.labelouvrage
            Form2.Label4.Text = prod.labeltitre
            Form2.Label4.Text = prod.labelnombre

            Form4.DataGridView1.Rows.Add(prod.labelnomlecteur, prod.labelcodeouvrage, prod.labelouvrage, prod.labeltitre, prod.labelnombre)

            Form4.Show()
        End If
    End Sub


End Class
