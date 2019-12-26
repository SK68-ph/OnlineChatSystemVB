
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class LoginForm
    'Declare Functions needed for Mysql operations
    Private reader As MySqlDataReader
    Private command As New MySqlCommand
    Private con As New MySqlConnection("datasource=johnny.heliohost.org;port=3306;username=barumbad_testuser;password=december262019;database=barumbad_usersDB")
    'Username that the user logged in with
    Public userAuth As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        RegisterForm.Close()
    End Sub

    'get the account id that we want to login using the typed user input
    Private Function getAccountId(user As String)
        Dim query As String = ""
        command = New MySqlCommand("SELECT id from tbl_users where user = '" & user & "'", con)
        con.Open()
        Dim temp As String = ""
        reader = command.ExecuteReader
        If reader.HasRows Then
            Console.WriteLine("has rows !")
            reader.Read()
            temp = reader.Item(0)
        Else
            MsgBox("Account Not Found!, Try Again")
            temp = Nothing
        End If
        con.Close()

        Return temp
    End Function

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'get the user input then store to variable without extra spaces and UpperCase
        Dim userInput As String = txtbox_user.Text.ToLower.Replace(" ", "").Trim
        Dim passInput As String = txtbox_pass.Text
        If userInput IsNot "" And passInput IsNot "" Then
            Try
                Dim pass, user As String
                'encrypt both of the inputed password and the account id then concatinate it to a one whole string
                Dim pass_tempencypt As String = Hash.GetHashString(passInput) + Hash.GetHashString(getAccountId(userInput).ToString)
                'encrypt again to shorten and conjoin the encryption
                Dim pass_encypt As String = Hash.GetHashString(pass_tempencypt)

                'if password encryption failed then retry
                If pass_encypt = "" Then
                    Console.WriteLine("password encryption failed")
                Else
                    command = Nothing
                    'get the row of the userinput and the encrypted password in table
                    command = New MySqlCommand("SELECT * FROM tbl_users WHERE user ='" & userInput & "' AND pass='" & pass_encypt & "'", con)
                    con.Open()
                    reader = command.ExecuteReader

                    If reader.HasRows Then
                        reader.Read()
                        user = reader.Item(1)
                        pass = reader.Item(2)

                    Else


                    End If
                    con.Close()
                    'compare the local input of user and encrypted password and the database user and password(encrypted on register)
                    'then if compared correctly show the ChatForm
                    If userInput.ToString.Equals(user) AndAlso pass_encypt.ToString.Equals(pass) Then
                        userAuth = user
                        MsgBox("Successfuly Logged in" & vbCrLf & "Welcome " & userAuth)
                        ChatForm.Show()
                        Me.Hide()
                    End If

                End If
            Catch ex As System.NullReferenceException
                MsgBox("Account Not Found!,Please Try Again")
                Console.WriteLine("User Input null or empty")
            End Try

        End If

    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Me.Hide()
        RegisterForm.Show()
    End Sub

    Private Sub onClick_Exit(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub


    'Changing Different Colors per 100ms for fun :)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim haha As Integer
        Dim Generator As System.Random = New System.Random()
        haha = Generator.Next(0, 8)

        If haha = 8 Then
            Me.ForeColor = (Color.Red)
            txtbox_pass.ForeColor = (Color.Red)
            txtbox_user.ForeColor = (Color.Red)
        ElseIf haha = 7 Then
            Me.ForeColor = (Color.Green)
            txtbox_pass.ForeColor = (Color.Green)
            txtbox_user.ForeColor = (Color.Green)
        ElseIf haha = 6 Then
            Me.ForeColor = (Color.Beige)
            txtbox_pass.ForeColor = (Color.Beige)
            txtbox_user.ForeColor = (Color.Beige)
        ElseIf haha = 5 Then
            Me.ForeColor = (Color.Blue)
            txtbox_pass.ForeColor = (Color.Blue)
            txtbox_user.ForeColor = (Color.Blue)
        ElseIf haha = 4 Then
            Me.ForeColor = (Color.SkyBlue)
            txtbox_pass.ForeColor = (Color.SkyBlue)
            txtbox_user.ForeColor = (Color.SkyBlue)
        ElseIf haha = 3 Then
            Me.ForeColor = (Color.DarkSeaGreen)
            txtbox_pass.ForeColor = (Color.DarkSeaGreen)
            txtbox_user.ForeColor = (Color.DarkSeaGreen)
        ElseIf haha = 2 Then
            Me.ForeColor = (Color.AliceBlue)
            txtbox_pass.ForeColor = (Color.AliceBlue)
            txtbox_user.ForeColor = (Color.AliceBlue)
        ElseIf haha = 1 Then
            Me.ForeColor = (Color.Crimson)
            txtbox_pass.ForeColor = (Color.Crimson)
            txtbox_user.ForeColor = (Color.Crimson)
        ElseIf haha = 0 Then
            Me.ForeColor = (Color.White)
            txtbox_pass.ForeColor = (Color.White)
            txtbox_user.ForeColor = (Color.White)
        End If
    End Sub



    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    command = New MySqlCommand("SELECT * FROM testTBL", con)
    '    Dim message As String
    '    con.Open()
    '    reader = command.ExecuteReader

    '    While reader.Read()

    '        message = reader.Item("message")

    '    End While
    '    MsgBox(message)

    '    con.Close()

    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    'INSERT INTO `tbl_users` (`id`, `user`, `pass`) VALUES ('1', 'user01', PASSWORD('test'));
    '    If txtbox_message IsNot "" Then
    '        command = New MySqlCommand("INSERT INTO testTBL(message) VALUES('" & txtbox_message.Text & "')", con)
    '        con.Open()
    '        MsgBox(command.ExecuteNonQuery())
    '        con.Close()
    '    End If
    'End Sub
End Class
