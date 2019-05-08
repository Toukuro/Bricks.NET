Imports System.Reflection

Namespace Logging

    ''' <summary>
    ''' ログの出力レベル
    ''' </summary>
    Public Enum OutputLevelEnum
        ''' <summary>全て</summary>
        All
        ''' <summary>デバッグ</summary>
        Debug
        ''' <summary>詳細</summary>
        Detail
        ''' <summary>情報</summary>
        Info
        ''' <summary>警告</summary>
        Warning
        ''' <summary>エラー</summary>
        [Error]
        ''' <summary>致命的エラー</summary>
        Fatal
        ''' <summary>出力なし</summary>
        None
    End Enum

    ''' <summary>
    ''' ログ出力の基本クラス
    ''' </summary>
    Public Class Logger

        ''' <summary>出力アクセサ</summary>
        Protected accessor As LogAccessor = Nothing

#Region "コンストラクタ"

        ''' <summary>
        ''' デフォルトのコンストラクタ
        ''' </summary>
        Public Sub New()
            accessor = New NullAccessor
        End Sub

        ''' <summary>
        ''' 出力先指定のコンストラクタ
        ''' </summary>
        ''' <param name="iLogAccessor">出力アクセサ</param>
        Public Sub New(iLogAccessor As LogAccessor)
            accessor = iLogAccessor
        End Sub

#End Region

#Region "プロパティ"

        ''' <summary>
        ''' 出力レベルの参照と設定
        ''' </summary>
        ''' <returns></returns>
        Public Property OutputLevel As OutputLevelEnum = OutputLevelEnum.All

#End Region

#Region "ログ出力メソッド"

#Region "情報"

        ''' <summary>
        ''' 情報出力（フォーマット指定）
        ''' </summary>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iData">埋め込みデータ</param>
        Public Overridable Sub Info(iMessage As String, ParamArray iData() As Object)
            Write(OutputLevelEnum.Info, iMessage, iData)
        End Sub

        ''' <summary>
        ''' 情報出力（例外出力）
        ''' </summary>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iException">例外</param>
        Public Overridable Sub Info(iMessage As String, iException As Exception)
            Write(OutputLevelEnum.Info, iMessage, iException)
        End Sub

#End Region

#Region "詳細"

        ''' <summary>
        ''' 詳細出力（フォーマット指定）
        ''' </summary>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iData">埋め込みデータ</param>
        Public Overridable Sub Detail(iMessage As String, ParamArray iData() As Object)
            Write(OutputLevelEnum.Detail, iMessage, iData)
        End Sub

        ''' <summary>
        ''' 詳細出力（例外出力）
        ''' </summary>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iException">例外</param>
        Public Overridable Sub Detail(iMessage As String, iException As Exception)
            Write(OutputLevelEnum.Detail, iMessage, iException)
        End Sub

#End Region

#Region "デバッグ"

        ''' <summary>
        ''' デバッグ出力（フォーマット指定）
        ''' </summary>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iData">埋め込みデータ</param>
        Public Overridable Sub Debug(iMessage As String, ParamArray iData() As Object)
            Write(OutputLevelEnum.Debug, iMessage, iData)
        End Sub

        ''' <summary>
        ''' デバッグ出力（例外出力）
        ''' </summary>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iException">例外</param>
        Public Overridable Sub Debug(iMessage As String, iException As Exception)
            Write(OutputLevelEnum.Debug, iMessage, iException)
        End Sub

#End Region

#Region "警告"

        ''' <summary>
        ''' 警告出力（フォーマット指定）
        ''' </summary>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iData">埋め込みデータ</param>
        Public Overridable Sub Warning(iMessage As String, ParamArray iData() As Object)
            Write(OutputLevelEnum.Warning, iMessage, iData)
        End Sub

        ''' <summary>
        ''' 警告出力（例外出力）
        ''' </summary>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iException">例外</param>
        Public Overridable Sub Warning(iMessage As String, iException As Exception)
            Write(OutputLevelEnum.Warning, iMessage, iException)
        End Sub

#End Region

#Region "エラー"

        ''' <summary>
        ''' エラー出力（フォーマット指定）
        ''' </summary>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iData">埋め込みデータ</param>
        Public Overridable Sub [Error](iMessage As String, ParamArray iData() As Object)
            Write(OutputLevelEnum.Error, iMessage, iData)
        End Sub

        ''' <summary>
        ''' エラー出力（例外出力）
        ''' </summary>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iException">例外</param>
        Public Overridable Sub [Error](iMessage As String, iException As Exception)
            Write(OutputLevelEnum.Error, iMessage, iException)
        End Sub

#End Region

#Region "致命的エラー"

        ''' <summary>
        ''' 致命的エラー出力（フォーマット指定）
        ''' </summary>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iData">埋め込みデータ</param>
        Public Overridable Sub Fatal(iMessage As String, ParamArray iData() As Object)
            Write(OutputLevelEnum.Fatal, iMessage, iData)
        End Sub

        ''' <summary>
        ''' 致命的エラー出力（例外出力）
        ''' </summary>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iException">例外</param>
        Public Overridable Sub Fatal(iMessage As String, iException As Exception)
            Write(OutputLevelEnum.Fatal, iMessage, iException)
        End Sub
#End Region

#Region "出力レベル指定"

        ''' <summary>
        ''' レベル指定出力（フォーマット指定）
        ''' </summary>
        ''' <param name="iLevel">出力レベル</param>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iData">埋め込みデータ</param>
        Public Overridable Sub Write(iLevel As OutputLevelEnum, iMessage As String, ParamArray iData() As Object)
            Dim outMsg As String = If(iData.Length > 0, String.Format(iMessage, iData), iMessage)

            If accessor Is Nothing OrElse iLevel < OutputLevel Then
                Return
            End If

            With accessor
                .Open()
                .Write(outMsg, iLevel)
                .Close()
            End With
        End Sub

        ''' <summary>
        ''' レベル指定出力（例外出力）
        ''' </summary>
        ''' <param name="iLevel">出力レベル</param>
        ''' <param name="iMessage">ログメッセージ</param>
        ''' <param name="iException">例外</param>
        Public Overridable Sub Write(iLevel As OutputLevelEnum, iMessage As String, iException As Exception)
            If accessor Is Nothing OrElse iLevel < OutputLevel Then
                Return
            End If

            With accessor
                Dim exMsg As String = "Exception"
                .Open()
                .Write(iMessage)
                While iException IsNot Nothing
                    .Write(String.Format("{0}: {1}", exMsg, iException.Message))
                    .Write(iException.StackTrace)
                    iException = iException.InnerException
                    exMsg = "Inner " & exMsg
                End While
                .Close()
            End With
        End Sub

#End Region

#End Region

    End Class
End Namespace
