Imports Newtonsoft.Json

Public Class Attachment

    Public Enum Colors
        good
        warning
        danger
    End Enum

    ''' <summary>
    ''' A plain-text summary of the attachment. This text will be used in clients that don't show formatted text (eg. IRC, mobile notifications) and should not contain any markup.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("fallback")>
    Public Property Fallback As String

    ''' <summary>
    ''' An optional value that can either be one of good, warning, danger, or any hex color code (eg. #439FE0). This value is used to color the border along the left side of the message attachment.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("color")>
    Public Property Color As String

    ''' <summary>
    ''' This is optional text that appears above the message attachment block.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("pretext")>
    Public Property PreText As String

    ''' <summary>
    ''' Small text used to display the author's name.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("author_name")>
    Public Property AuthourName As String

    ''' <summary>
    ''' A valid URL that will hyperlink the author_name text mentioned above. Will only work if author_name is present.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("author_link")>
    Public Property AuthorLink As String

    ''' <summary>
    ''' A valid URL that displays a small 16x16px image to the left of the author_name text. Will only work if author_name is present.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("author_icon")>
    Public Property AuthorIcon As String

    ''' <summary>
    ''' The title is displayed as larger, bold text near the top of a message attachment. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("title")>
    Public Property Title As String

    ''' <summary>
    ''' By passing a valid URL in the title_link parameter (optional), the title text will be hyperlinked.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("title_link")>
    Public Property TitleLink As String

    ''' <summary>
    ''' This is the main text in a message attachment, and can contain standard message markup (see details below). The content will automatically collapse if it contains 700+ characters or 5+ linebreaks, and will display a "Show more..." link to expand the content.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("text")>
    Public Property Text As String

    ''' <summary>
    ''' Fields are defined as an array, and hashes contained within it will be displayed in a table inside the message attachment.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("fields")>
    Public Property Fields As List(Of Field)

    ''' <summary>
    ''' A valid URL to an image file that will be displayed inside a message attachment. We currently support the following formats: GIF, JPEG, PNG, and BMP.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("image_url")>
    Public Property ImageUrl As String

    ''' <summary>
    ''' A valid URL to an image file that will be displayed as a thumbnail on the right side of a message attachment. We currently support the following formats: GIF, JPEG, PNG, and BMP
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("thumb_url")>
    Public Property ThumbUrl As String

    Public Sub New()
        _Fields = New List(Of Field)
    End Sub

    Public Sub SetColor(ByVal value As Colors)
        _Color = value.ToString
    End Sub

End Class
