Imports System.IO

Namespace Message

    Public Class FileResourceMessage
        Inherits ResourceMessage

        Public Const DTCNM_MSGID As String = "MsgId"
        Public Const DTCNM_MSGSTRING As String = "MsgString"

        Protected _BaseName As String
        Protected _MessageTbl As DataTable

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="iResourceMgr"></param>
        Public Sub New(iResourceMgr As Resources.ResourceManager, iMsgName As String)
            MyBase.New(iResourceMgr)

            _BaseName = iMsgName

            _MessageTbl = New DataTable
            _MessageTbl.Columns.Add(New DataColumn("MsgId", GetType(String)))
            _MessageTbl.Columns.Add(New DataColumn("MsgString", GetType(String)))
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="iMsgId"></param>
        ''' <param name="iLang"></param>
        ''' <returns></returns>
        Public Overrides Function GetMessageInfo(iMsgId As String, iLang As String) As Object
            If _MessageTbl.Rows.Count = 0 Then
                Dim _stream As Stream = _Resource.GetStream(String.Format("{1}.{0}", _BaseName, iLang))
                If _stream Is Nothing Then
                    _stream = _Resource.GetStream(_BaseName)
                End If
                _MessageTbl.ReadXml(_stream)
            End If

            Dim msgInfo As Object = Nothing
            Dim rows() As DataRow = _MessageTbl.Select(String.Format("{0} = '{1}'", DTCNM_MSGID, iMsgId))
            If rows.Count > 0 Then
                msgInfo = rows(0)
            End If

            Return msgInfo
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="iMsgInfo"></param>
        ''' <returns></returns>
        Public Overrides Function ExtractMessage(iMsgInfo As Object) As String
            If TypeOf iMsgInfo IsNot DataRow Then
                Return Nothing
            End If

            Dim msgRow As DataRow = CType(iMsgInfo, DataRow)
            Try
                Return msgRow(DTCNM_MSGSTRING)
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

    End Class

End Namespace
