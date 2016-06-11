Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SlackVB

<TestClass()> Public Class IncomingWebhooksTest

    Private url As String = "https://hooks.slack.com/services/xxx/xxx/xxx"

    <TestMethod> Public Sub PostMessage()

        Dim client As New IncomingWebhooksClient(url)

        'color
        Dim attachmentColorGood As New Attachment
        With attachmentColorGood
            .Text = "This is good!"
            .SetColor(Attachment.Colors.good)
        End With
        Dim attachmentColorWarning As New Attachment
        With attachmentColorWarning
            .Text = "Warning!"
            .SetColor(Attachment.Colors.warning)
        End With
        Dim attachmentColorDanger As New Attachment
        With attachmentColorDanger
            .Text = "DANGER DANGER!"
            .SetColor(Attachment.Colors.danger)
        End With
        Dim attachmentColorHex As New Attachment
        With attachmentColorHex
            .Text = "This was a hex value"
            .Color = "#439FE0"
        End With
        Dim messageColor As New Message
        With messageColor
            .Attachments.Add(attachmentColorGood)
            .Attachments.Add(attachmentColorWarning)
            .Attachments.Add(attachmentColorDanger)
            .Attachments.Add(attachmentColorHex)
        End With

        Dim resColor = client.PostMessage(messageColor)
        Debug.Assert((resColor = "ok"))

        'pretext
        Dim attachmentPretext As New Attachment
        With attachmentPretext
            .PreText = "This is pretext that appears outside the attachment."
            .Text = "This is text on the inside of the attachment."
        End With
        Dim messagePretext As New Message
        With messagePretext
            .Attachments.Add(attachmentPretext)
        End With

        Dim resPretext = client.PostMessage(messagePretext)
        Debug.Assert((resPretext = "ok"))

        'author parameters
        Dim attachmentAuthor As New Attachment
        With attachmentAuthor
            .AuthourName = "Bobby Tables"
            .AuthorLink = ""
            .AuthorIcon = ""
        End With
        Dim messageAuthor As New Message
        messageAuthor.Attachments.Add(attachmentAuthor)

        Dim resAuthor = client.PostMessage(messageAuthor)
        Debug.Assert((resAuthor = "ok"))

    End Sub

End Class