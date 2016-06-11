Imports Newtonsoft.Json

''' <summary>
''' Fields are defined as an array, and hashes contained within it will be displayed in a table inside the message attachment.
''' </summary>
''' <remarks></remarks>
Public Class Field

    ''' <summary>
    ''' Shown as a bold heading above the value text. It cannot contain markup and will be escaped for you.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("title")>
    Public Property Title As String

    ''' <summary>
    ''' The text value of the field. It may contain standard message markup and must be escaped as normal. May be multi-line.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <JsonProperty("value")>
    Public Property Value As String

    <JsonProperty("short")>
    Private shortValue As String = "false"

    ''' <summary>
    ''' An optional flag indicating whether the value is short enough to be displayed side-by-side with other values.
    ''' </summary>
    ''' <remarks></remarks>
    <JsonIgnore>
    Public Property [Short] As Boolean
        Get
            Return Boolean.Parse(shortValue)
        End Get
        Set(value As Boolean)
            shortValue = value.ToString.ToLower
        End Set
    End Property

    ''' <summary>
    ''' Fields are defined as an array, and hashes contained within it will be displayed in a table inside the message attachment.
    ''' </summary>
    ''' <param name="title">Shown as a bold heading above the value text. It cannot contain markup and will be escaped for you.</param>
    ''' <param name="value">The text value of the field. It may contain standard message markup and must be escaped as normal. May be multi-line.</param>
    ''' <param name="short">An optional flag indicating whether the value is short enough to be displayed side-by-side with other values.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal title As String,
                   ByVal value As String,
                   ByVal [short] As Boolean)

        _Title = title
        _Value = value
        shortValue = [short].ToString.ToLower

    End Sub

    ''' <summary>
    ''' Fields are defined as an array, and hashes contained within it will be displayed in a table inside the message attachment.
    ''' </summary>
    ''' <param name="title">Shown as a bold heading above the value text. It cannot contain markup and will be escaped for you.</param>
    ''' <param name="value">The text value of the field. It may contain standard message markup and must be escaped as normal. May be multi-line.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal title As String,
                   ByVal value As String)

        _Title = title
        _Value = value
        shortValue = Boolean.FalseString.ToLower

    End Sub


End Class
