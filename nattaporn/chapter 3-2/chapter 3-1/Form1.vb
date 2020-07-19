Public Class Form1
    Dim Birds As Short
    Dim Inescts As Integer
    Dim worldPop As Long
    Dim Price As String
    Dim Fullname As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Short")
        ListBox1.Items.Add("Integer")
        ListBox1.Items.Add("Long")
        ListBox1.Items.Add("String")
        ListBox1.Items.Add("Fullname")

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                Birds = 12500
                Label3.Text = Birds
            Case 1
                Inescts = 37500000
                Label3.Text = Inescts
            Case 2
                worldPop = 899.99
                Label3.Text = worldPop
            Case 3
                Price = "Nattaporn"
                Label3.Text = Price
            Case 4
                Fullname = "ณัฐธภรณ์ สถิตพงษ์"
                Label3.Text = Fullname

        End Select
    End Sub
End Class
