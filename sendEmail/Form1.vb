Imports System.Net.Mail

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Dim smtp_server As New SmtpClient
        Dim e_mail As New MailMessage
        smtp_server.UseDefaultCredentials = False
        smtp_server.Credentials = New Net.NetworkCredential("alecksgarciazr16@gmail.com", "kris-2021#")
        smtp_server.Port = 25
        smtp_server.EnableSsl = True
        smtp_server.Host = "smtp.gmail.com"

        e_mail = New MailMessage
        e_mail.From = New MailAddress("alecksgarciazr16@gmail.com")
        e_mail.To.Add("mgarciag22@miumg.edu.gt")
        e_mail.Subject = txtAsunto.Text
        e_mail.IsBodyHtml = False
        e_mail.Body = txtMensaje.Text
        smtp_server.Send(e_mail)


    End Sub
End Class
