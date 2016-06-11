Imports Newtonsoft.Json

Public Class Message

    <JsonProperty("username")>
    Public Property UserName As String

    <JsonProperty("text")>
    Public Property Text As String

    <JsonProperty("icon_url")>
    Public Property IconUrl As String

    <JsonProperty("icon_emoji")>
    Public Property IconEmoji As String

    <JsonProperty("attachments")>
    Private attachmentsValue As List(Of Attachment)

    <JsonIgnore>
    Public ReadOnly Property Attachments As List(Of Attachment)
        Get
            Return attachmentsValue
        End Get
    End Property

    Public Sub New()
        attachmentsValue = New List(Of Attachment)
    End Sub

End Class
