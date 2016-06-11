
Imports Newtonsoft.Json
Imports System.Collections.Specialized
Imports System.Net
Imports System.Text

Public Class IncomingWebhooksClient
    Private uri As Uri
    Private encoding As Encoding = New UTF8Encoding()

    Public Sub New(urlWithAccessToken As String)
        uri = New Uri(urlWithAccessToken)
    End Sub

    Public Function PostMessage(ByVal text As String,
                           Optional ByVal userName As String = Nothing) As String
        Dim payload As New Message
        With payload
            .username = userName
            .text = text
        End With
        Return PostMessage(payload)
    End Function

    Public Function PostMessage(ByVal msg As Message) As String
        Dim result As String = Nothing

        Dim serialized = JsonConvert.SerializeObject(msg)

        Using client As New WebClient()
            Dim data As New NameValueCollection()
            data("payload") = serialized
            Try
                Dim response = client.UploadValues(uri, "POST", data)
                Dim responseText As String = encoding.GetString(response)
                result = responseText
            Catch ex As Exception

            End Try
        End Using
        Return result

    End Function

End Class

