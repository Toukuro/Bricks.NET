Imports System.IO
Imports System.Text

Namespace Logging

    ''' <summary>
    ''' テキストファイルに出力するアクセサ
    ''' </summary>
    Public Class FileAccessor
        Inherits LogAccessor

        ''' <summary>ファイルストリーム</summary>
        Private _stream As TextWriter = Nothing

        ''' <summary>出力エンコーディング</summary>
        Private _encoding As Encoding = Encoding.Default

#Region "コンストラクタ"

        ''' <summary>
        ''' デフォルトのコンストラクタ
        ''' </summary>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' ファイル名指定のコンストラクタ
        ''' </summary>
        ''' <param name="iFileName">ログファイルのファイル名</param>
        Public Sub New(iFileName As String)
            _FileName = iFileName
        End Sub

#End Region

#Region "プロパティ"

        ''' <summary>
        ''' 設定されているファイル名を返却する
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property FileName As String = "application.log"

#End Region

#Region "メソッド"

        ''' <summary>
        ''' ログファイルをオープンする
        ''' </summary>
        Public Overrides Sub Open()
            _stream = New StreamWriter(_FileName, True)
        End Sub

        ''' <summary>
        ''' ログファイルをクローズする
        ''' </summary>
        Public Overrides Sub Close()
            _stream.Close()
            _stream.Dispose()
            _stream = Nothing
        End Sub

        ''' <summary>
        ''' ログメッセージをファイルに出力する
        ''' </summary>
        ''' <param name="iMsg"></param>
        ''' <param name="iLevel"></param>
        Public Overrides Sub Write(iMsg As String, Optional iLevel As OutputLevelEnum = OutputLevelEnum.All)
            _stream.WriteLine(iMsg)
        End Sub
    End Class

#End Region

End Namespace
