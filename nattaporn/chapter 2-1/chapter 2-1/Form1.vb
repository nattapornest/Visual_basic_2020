Public Class Nattaporn
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Firstname As String
        Firstname = "Nattaporn"
        Label2.Text = Firstname
        Firstname = "Satitpong"
        Label4.Text = Firstname
        Firstname = "Est"
        Label6.Text = Firstname

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Prompt, Firstname As String
        Prompt = "กรุณากรอกชื่อจริง"
        Firstname = InputBox(Prompt)
        Label2.Text = Firstname

        Dim Prom, lastname As String
        Prom = "กรุณากรอกนามสกุล"
        lastname = InputBox(Prom)
        Label4.Text = lastname

        Dim Pro, nickname As String
        Pro = "กรุณากรอกชื่อเล่น"
        nickname = InputBox(Pro)
        Label6.Text = nickname
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Prompt, Firstname As String
        Prompt = "กรุณาป้อนชื่อนามสกุล"
        Firstname = InputBox(Prompt)
        MsgBox(Firstname, , "ชื่อนามสกุลของคุณ")

        Dim Promp, nickname As String
        Promp = "กรุณาป้อนชื่อเล่น"
        nickname = InputBox(Promp)
        MsgBox(nickname, , "ชื่อเล่นของคุณ")
    End Sub
End Class
