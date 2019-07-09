Namespace DataBase.Ado

    ''' <summary>
    ''' 
    ''' </summary>
    Public Class AdoAccess

#Region "プライベート変数"
        Private Shared _DefaultFactoryName As String = "System.Data.SqlClient"
        Private _dbFactory As Common.DbProviderFactory
        Private _dbConnStr As New Common.DbConnectionStringBuilder
        Private _dbConnection As Common.DbConnection
        Private _dbTransaction As Common.DbTransaction = Nothing

        Private _Logger As Logging.Logger = New Logging.Logger

#End Region

#Region "コンストラクタ"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="iConnectionStr"></param>
        Public Sub New(Optional iConnectionStr As String = "", Optional iDbProviderName As String = "")
            If Not String.IsNullOrEmpty(iConnectionStr) Then
                _dbConnStr.ConnectionString = iConnectionStr
            End If
            _dbFactory = Common.DbProviderFactories.GetFactory(_DefaultFactoryName)
        End Sub

#End Region

#Region "プロパティ"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Property Logger As Logging.Logger
            Get
                Return _Logger
            End Get
            Set(value As Logging.Logger)
                If value IsNot Nothing AndAlso TypeOf value Is Logging.Logger Then
                    _Logger = value
                Else
                    _Logger = New Logging.Logger
                End If
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Property CommandTimeout As Integer = 0

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Property ConnectionTimeout As Integer = 0

#End Region

#Region "接続・切断"

        ''' <summary>
        ''' 
        ''' </summary>
        Public Sub Connect()
            _dbConnection = _dbFactory.CreateConnection
            _dbConnection.ConnectionString = _dbConnStr.ConnectionString
            _dbConnection.Open()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Sub Disconnect()
            _dbConnection.Close()
        End Sub

#End Region

#Region "トランザクション制御"

        ''' <summary>
        ''' 
        ''' </summary>
        Public Sub BeginTran()
            Try
                _dbTransaction = _dbConnection.BeginTransaction()
                _Logger.Detail("Transaction beggining.")

            Catch ex As Exception
                Throw New AdoDataBaseException("", ex)
            End Try
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Sub CommitTran()
            _dbTransaction.Commit()
            _dbTransaction = Nothing
            _Logger.Detail("Transaction committed.")
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Sub RollbackTran()
            _dbTransaction.Rollback()
            _dbTransaction = Nothing
            _Logger.Detail("Transaction rollbacked.")
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Function IsBeggingTran() As Boolean
            Return (_dbTransaction IsNot Nothing)
        End Function

#End Region

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Function CreateCommand() As AdoCommand
            Dim cmd As New AdoCommand(Me)
            Return cmd
        End Function
    End Class

End Namespace
