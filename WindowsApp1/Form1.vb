Public Class Form1
    Dim users As New List(Of User)()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'AddUser(txtnome.Text)


        Using context As New DBUsers()

            Dim user = New User_E With {.Nome = txtnome.Text, .Altura = txtaltura.Text, .Idade = txtidade.Text, .Peso = txtpeso.Text}
            context.Users.Add(user)
            context.SaveChanges()

        End Using

        txtnome.Text = ""
        txtaltura.Text = ""
        txtpeso.Text = ""
        txtidade.Text = ""

    End Sub

    Private Sub AddUser(username As String)
        Dim User = New User()

        User.nome = username
        User.altura = txtaltura.Text
        User.peso = txtpeso.Text
        User.idade = txtidade.Text

        users.Add(User)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'dgvBookings.Columns.Add("Column1", "Column1")
        'LoadFromList()
        LoadFromEF()

    End Sub

    Private Sub LoadFromList()

        For Each user As User In users
            With user
                Grid1.Rows.Add(.nome.ToString(), .idade.ToString(), .peso.ToString(), .altura.ToString())
            End With
        Next

    End Sub

    Private Sub LoadFromEF()

        Using context As New DBUsers()

            Dim users =
                    From d In context.Users
                    Order By d.Nome
                    Select d

            Grid1.Rows.Clear()

            For Each user In users
                Grid1.Rows.Add(user.Nome.ToString(), user.Idade.ToString(), user.Peso.ToString(), user.Altura.ToString())
            Next

        End Using




    End Sub

End Class
