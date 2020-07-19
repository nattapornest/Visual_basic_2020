Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Dim password As Integer
        Username = InputBox("กรุณาป้อนชื่อของคุณ")
        password = InputBox("กรุณากรอกรหัสผ่าน")
        If Username = "นุ๊กเน็ต" And password = "0916591941" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\nattaporn\All_Images\ChaiYo.jpg")
        ElseIf Username = "Est" And password = "123456" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\nattaporn\All_Images\100733382_1856721801129390_4105055361273167872_n.jpg")
        ElseIf Username = "Oing" And password = "654321" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\nattaporn\All_Images\92512544_929905820797132_8188521712950706176_o.jpg")
        ElseIf Username = "Por" And password = "0916591941" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\nattaporn\All_Images\95903510_1665218953644553_4540252245331717313_n.jpg")
        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")
        End If

    End Sub
End Class
