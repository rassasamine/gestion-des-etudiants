Imports System.Data.OleDb

Public Class Form1
    Dim connexion As OleDbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Etablir la connexion avec la base de donnée
        Dim ConnexionString As String
        ConnexionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source= C:\Users\Emine 'HusSoka' Rass\Documents\Visual Studio 2017\Projects\Gestion_Etudiant\WindowsApp2\Database1.mdb"
        connexion = New OleDbConnection(ConnexionString)
        connexion.Open()

        'requete de selection
        Dim reqAffiche As String
        reqAffiche = "SELECT prenom FROM personne"

        'Executer la requete
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(reqAffiche, connexion)

        'recuperer le resultat de la requete
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        'manipuler le resultat de la requete
        While reader.Read()
            cmbNom.Items.Add(reader.Item(0))
        End While
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        If (txtCode.Text <> "" And txtNom.Text <> "" And txtPrenom.Text <> "" And txtAdresse.Text <> "") Then
            'requete d'insertion
            Dim req As String
            req = "INSERT INTO personne (code,nom,prenom,adresse) VALUES(" & Val(txtCode.Text) & ", '" & txtNom.Text & "','" & txtPrenom.Text & "','" & txtAdresse.Text & "')"

            'Executer la requete
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

            'requete de suppression
            Dim deleteStr As String
            deleteStr = "DELETE * FROM personne WHERE personne.code = " & Val(txtCode.Text) & ""

            'Executer la requete
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

            'requete de mise à jour
            Dim updateStr As String
            updateStr = "UPDATE personne SET nom='" & txtNom.Text & "', prenom='" & txtPrenom.Text & "', adresse='" & txtAdresse.Text & "' WHERE personne.code = " & Val(txtCode.Text) & ""

            'Executer la requete
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

            'requete de selection
            Dim req As String
            req = "SELECT * FROM personne WHERE personne.code = " & Val(txtCode.Text) & ""

            'Executer la requete
            Dim Cmd As OleDbCommand
            Cmd = New OleDbCommand(req, connexion)

            'recuperer le resultat de la requete
            Dim Reader As OleDbDataReader = Cmd.ExecuteReader()
            'manipuler le resultat de la requete
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
