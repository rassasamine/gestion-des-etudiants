Imports System.Data.OleDb

Public Class Form1
    Dim connexion As OleDbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ConnexionString As String
        ConnexionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source= C:\Users\Emine 'HusSoka' Rass\Documents\Visual Studio 2017\Projects\Gestion_Etudiant\WindowsApp2\Database1.mdb"
        connexion = New OleDbConnection(ConnexionString)
        connexion.Open()

        Dim reqAffiche As String
        reqAffiche = "SELECT prenom FROM personne"
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(reqAffiche, connexion)

        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            cmbNom.Items.Add(reader.Item(0))
        End While
    End Sub

    Private Sub lblCode_Click(sender As Object, e As EventArgs) Handles lblCode.Click

    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged

    End Sub

    Private Sub lblNom_Click(sender As Object, e As EventArgs) Handles lblNom.Click

    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged

    End Sub

    Private Sub lblPrenom_Click(sender As Object, e As EventArgs) Handles lblPrenom.Click

    End Sub

    Private Sub txtPrenom_TextChanged(sender As Object, e As EventArgs) Handles txtPrenom.TextChanged

    End Sub

    Private Sub lblAdresse_Click(sender As Object, e As EventArgs) Handles lblAdresse.Click

    End Sub

    Private Sub txtAdresse_TextChanged(sender As Object, e As EventArgs) Handles txtAdresse.TextChanged

    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        If (txtCode.Text <> "" And txtNom.Text <> "" And txtPrenom.Text <> "" And txtAdresse.Text <> "") Then
            Dim req As String
            req = "INSERT INTO personne (code,nom,prenom,adresse) VALUES(" & Val(txtCode.Text) & ", '" & txtNom.Text & "','" & txtPrenom.Text & "','" & txtAdresse.Text & "')"
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(req, connexion)
            cmd.ExecuteNonQuery()

            MsgBox("Ajout avec succès !")

            txtCode.Clear()
            txtNom.Clear()
            txtPrenom.Clear()
            txtAdresse.Clear()
        Else
            MsgBox("Veuillez entrer les informations !")
        End If
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If (txtCode.Text <> "" And txtNom.Text <> "" And txtPrenom.Text <> "" And txtAdresse.Text <> "") Then
            Dim deleteStr As String = "DELETE * FROM personne WHERE personne.code = " & Val(txtCode.Text) & ""
            Dim deleteCMD As OleDbCommand
            deleteCMD = New OleDbCommand(deleteStr, connexion)
            deleteCMD.ExecuteNonQuery()

            MsgBox("Suppression avec succès !")

            txtCode.Clear()
            txtNom.Clear()
            txtPrenom.Clear()
            txtAdresse.Clear()
        Else
            MsgBox("Veuillez entrer les informations de l'etudiant à supprimer !")
        End If
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        If (txtCode.Text <> "" And txtNom.Text <> "" And txtPrenom.Text <> "" And txtAdresse.Text <> "") Then
            Dim updateStr As String = "UPDATE personne SET nom='" & txtNom.Text & "', prenom='" & txtPrenom.Text & "', adresse='" & txtAdresse.Text & "' WHERE personne.code = " & Val(txtCode.Text) & ""
            Dim updateCMD As OleDbCommand
            updateCMD = New OleDbCommand(updateStr, connexion)
            updateCMD.ExecuteNonQuery()
            MsgBox("Modification avec succès !")
            txtCode.Clear()
            txtNom.Clear()
            txtPrenom.Clear()
            txtAdresse.Clear()
        Else
            MsgBox("Veuillez entrer les informations de l'etudiant à modifier !")
        End If
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        If (txtCode.Text <> "") Then
            Dim req As String
            req = "SELECT * FROM personne WHERE personne.code = " & Val(txtCode.Text) & ""
            Dim Cmd As OleDbCommand
            Cmd = New OleDbCommand(req, connexion)
            Dim Reader As OleDbDataReader = Cmd.ExecuteReader()
            If Reader.HasRows Then
                While Reader.Read()
                    txtCode.Text = (Reader.Item(0)).ToString()
                    txtNom.Text = (Reader.Item(1)).ToString()
                    txtPrenom.Text = (Reader.Item(2)).ToString()
                    txtAdresse.Text = (Reader.Item(3)).ToString()
                End While
            Else
                MsgBox("Etudiant non trouvé ! Veuillez rechercher par code.")
            End If
        Else
            MsgBox("Veuillez entrer le code de l'etudiant à chercher !")
        End If
    End Sub
End Class
