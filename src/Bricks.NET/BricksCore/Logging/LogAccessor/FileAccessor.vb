Imports System.IO

Namespace Logging

    ''' <summary>
    ''' テキストファイルに出力するアクセサ
    ''' </summary>
    Public Class FileAccessor
        Inherits LogAccessor

        Private _stream As Stream = Nothing

    End Class

End Namespace
