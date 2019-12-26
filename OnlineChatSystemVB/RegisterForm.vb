Imports MySql.Data
Imports MySql.Data.MySqlClient

'Registration of account needs to have a username and Encypted password within the process to send to database 
'For comparing in login system.
Public Class RegisterForm
    'Declare Functions needed for Mysql operations
    Private reader As MySqlDataReader
    Private command As New MySqlCommand
    Private con As New MySqlConnection("datasource=johnny.heliohost.org;port=3306;username=barumbad_testuser;password=december262019;database=barumbad_usersDB")

    'get the next incremented Account id from the table
    Private Function getNextAccountId()

        command = New MySqlCommand("SELECT MAX(id) from tbl_users", con)
        con.Open()
        Dim temp As String = ""
        reader = command.ExecuteReader
        If reader.HasRows Then
            reader.Read()
            temp = reader.Item(0)
            'add 1 number to the current max id to get the id thats about to get created
            temp = Integer.Parse(temp) + 1
            temp = temp.ToString()

        Else
            MsgBox("Account Creation Failed!, Try Again")
            temp = Nothing
        End If
        con.Close()

        Return temp
    End Function
    Private Sub Register_onClick(sender As Object, e As EventArgs) Handles Panel4.Click, Label2.Click
        'make sure that there is no extra space and lowercase only
        Dim user_Input As String = txtbox_user.Text.ToLower.Replace(" ", "").Trim
        Dim pass_Input As String = txtbox_pass.Text
        'check if user filled the required fields
        If user_Input IsNot "" AndAlso pass_Input IsNot "" Then
            'Encrypt the password that has been inputed then get the next account id that we are about to register 
            'Using getNextAccountId() Function. then concatinate it both as a joined string
            'then encrypt it again to shorten and secure the password
            Dim pass_tempencypt As String = Hash.GetHashString(pass_Input) + Hash.GetHashString(getNextAccountId)
            Dim pass_encypt As String = Hash.GetHashString(pass_tempencypt)

            If pass_encypt.Equals("") Or pass_encypt = Nothing Then
                MsgBox("Registration Failed")
            Else
                Try
                    'insert the username and the encrypted password into the database
                    command = New MySqlCommand("INSERT INTO `tbl_users` (`user`, `pass`) VALUES ('" & user_Input & "','" & pass_encypt & "')", con)
                    con.Open()
                    command.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Registered Successfully")
                    LoginForm.Show()
                    Me.Close()
                    'username must be unique so they have to retype if already taken
                Catch ex As MySql.Data.MySqlClient.MySqlException
                    MsgBox("That Username is taken, Try Another")
                End Try

            End If
            pass_encypt = Nothing
        End If
        user_Input = Nothing
        pass_Input = Nothing
        command = Nothing

    End Sub

    Private Sub on_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        LoginForm.Show()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class