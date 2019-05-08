Imports System.Windows

Namespace Logging

    ''' <summary>
    ''' WindowsFormのTextプロパティに対してログ出力を行うアクセサ
    ''' </summary>
    Public Class FormAccessor
        Inherits LogAccessor

        ''' <summary></summary>
        Private _Control As Control = Nothing

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="iControl"></param>
        Public Sub New(iControl As Control)
            _Control = iControl
        End Sub

        ''' <summary>
        ''' ログの出力処理
        ''' </summary>
        ''' <param name="iMsg"></param>
        ''' <param name="iLevel"></param>
        Public Overrides Sub Write(iMsg As String, Optional iLevel As OutputLevelEnum = OutputLevelEnum.All)
            If _Control IsNot Nothing Then
                _Control.Text &= iMsg & vbCrLf
            End If
        End Sub
    End Class

End Namespace
