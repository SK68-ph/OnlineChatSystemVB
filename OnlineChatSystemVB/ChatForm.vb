Imports MySql.Data.MySqlClient
Public Class ChatForm
    Private command As MySqlCommand
    Private reader As MySqlDataReader
    Private con As New MySqlConnection("datasource=johnny.heliohost.org;port=3306;username=barumbad_testuser;password=december262019;database=barumbad_ChatDB")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'send data to database
        command = New MySqlCommand("INSERT INTO tbl_chat(name, message) VALUES('" + txtbox_name.Text + "','" + txtbox_pm.Text + "')", con)
        con.Open()
        command.ExecuteNonQuery()
        con.Close()
        update_data()
    End Sub

    Private Sub ChatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get user from login then update the chat form to load current chats online
        txtbox_name.Text = LoginForm.userAuth
        txtbox_name.ReadOnly = True
        update_data()
    End Sub
    Private Sub on_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        LoginForm.Show()
        Clear()
    End Sub
    'TODO
    'Get the last message then append to current local message withour latency
    'Selecting all of the message from the start is not efficient(causing lag and scroll reset)


    Private Sub update_data()
        Dim message As String = ""
        command = New MySqlCommand("Select * from tbl_chat", con)
        con.Open()
        reader = command.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                message = message & Environment.NewLine & reader.Item("name") & " :" & reader.Item("message")
            End While
            Console.WriteLine("No rows found")
        End If
        con.Close()
        RichTextBox1.Focus()
        RichTextBox1.Text = message
    End Sub

    Public Sub Clear()
        RichTextBox1.Text = Nothing
        command = Nothing
        LoginForm.txtbox_user.Text = ""
        LoginForm.txtbox_pass.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clear()
        LoginForm.Show()
        Me.Close()
    End Sub
End Class