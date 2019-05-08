Namespace Logging

    ''' <summary>
    ''' ログ出力アクセサの抽象クラス
    ''' </summary>
    Public MustInherit Class LogAccessor

        ''' <summary>
        ''' アクセサのオープン処理
        ''' </summary>
        Public Overridable Sub Open()
            Return
        End Sub

        ''' <summary>
        ''' アクセサのクローズ処理
        ''' </summary>
        Public Overridable Sub Close()
            Return
        End Sub

        ''' <summary>
        ''' アクセサへの出力処理
        ''' </summary>
        ''' <param name="iMsg"></param>
        ''' <param name="iLevel"></param>
        Public Overridable Sub Write(iMsg As String, Optional iLevel As OutputLevelEnum = OutputLevelEnum.All)
            Return
        End Sub

    End Class

End Namespace