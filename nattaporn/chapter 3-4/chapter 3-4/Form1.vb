Public Class Form1
    Dim Price, Num, tal, Jai, Sudti As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Price = TextBox1.Text
        Num = TextBox2.Text
        tal = Price * Num
        total.Text = tal

        Jai = TextBox3.Text
        Sudti = Jai - tal
        Label7.Text = Sudti

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
