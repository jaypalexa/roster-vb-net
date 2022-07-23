Option Explicit On
Option Strict On

Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SQLite
Imports System.Text.RegularExpressions
Imports System.Xml
Imports System.IO

''' <summary>
''' The SQLite class is intended to encapsulate high performance, scalable best practices for 
''' common uses of the SQLite ADO.NET provider.  It is created using the abstract factory in AdoHelper
''' </summary>
Public Class SQLite
    Inherits AdoHelper

    Private msConnectionString As String = String.Empty

    ''' <summary>
    ''' Create an SQLite Helper.  Needs to be a default constructor so that the Factory can create it
    ''' </summary>
    Public Sub New()

    End Sub 'New

#Region "Overrides"

    ''' <summary>
    ''' Native database provider type
    ''' </summary>
    Protected Overrides ReadOnly Property ProviderDatabaseType() As DatabaseTypeEnum
        Get
            Return DatabaseTypeEnum.SQLite
        End Get
    End Property

    ''' <summary>
    ''' The date delimiter of the native database provider
    ''' </summary>
    Protected Overrides ReadOnly Property ProviderDateDelimiter() As String
        Get
            Return "'"
        End Get
    End Property

    ''' <summary>
    ''' The date format of the native database provider
    ''' </summary>
    Protected Overrides ReadOnly Property ProviderDateFormat() As String
        Get
            Return "yyyy-MM-dd HH:mm:ss"
        End Get
    End Property

    ''' <summary>
    ''' The upper casing function of the native database provider
    ''' </summary>
    Protected Overrides ReadOnly Property ProviderUpperFunction() As String
        Get
            Return "UPPER"
        End Get
    End Property

    ''' <summary>
    ''' The ISNULL or COALESCE or NVL or IFNULL function of the native database provider
    ''' </summary>
    ''' <param name="sColumnName">Column to check for null.</param>
    ''' <param name="sValue">Value to be used if field is null.</param>
    Protected Overrides ReadOnly Property ProviderIsNullFunction(ByVal sColumnName As String, ByVal sValue As String) As String
        Get
            Return "COALESCE(" & sColumnName & ", " & sValue & ")"
        End Get
    End Property

    ''' <summary>
    ''' The native-provider SQL string to return the last Identity value  
    ''' </summary>
    Protected Overrides ReadOnly Property ProviderLastIdentityValueSql() As String
        Get
            Return String.Empty '???TODO:  find a way to do this in SQLite...maybe something using sqlite_last_insert_rowid???
        End Get
    End Property

    ''' <summary>
    ''' The native-provider routine to clean or compact/repair or truncate temp databases  
    ''' </summary>
    Protected Overrides Sub ProviderCleanDatabase()
        Try
            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                oAdoHelper.ExecuteNonQuery(CommandType.Text, "VACUUM")
            End Using
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' The native-provider routine to determine if the specified table exists in the database 
    ''' </summary>
    Protected Overrides Function ProviderTableExists(ByVal sTableName As String) As Boolean

        '*** ASSERTION ***
        If String.IsNullOrEmpty(sTableName) Then Throw New ArgumentNullException("sTableName")
        '*** ASSERTION ***

        Throw New ApplicationException("ProviderTableExists method not implemented for SQLite provider")

        Return False

    End Function

    ''' <summary>
    ''' The native-provider routine to determine if the specified table + column exists in the database 
    ''' </summary>
    Protected Overrides Function ProviderColumnExists(ByVal sTableName As String, ByVal sColumnName As String) As Boolean

        '*** ASSERTION ***
        If String.IsNullOrEmpty(sTableName) Then Throw New ArgumentNullException("sTableName")
        If String.IsNullOrEmpty(sColumnName) Then Throw New ArgumentNullException("sColumnName")
        '*** ASSERTION ***

        Throw New ApplicationException("ProviderColumnExists method not implemented for SQLite provider")

        Return False

    End Function

    ''' <summary>
    ''' The native-provider routine to determine if the specified table + index exists in the database 
    ''' </summary>
    Protected Overrides Function ProviderIndexExists(ByVal sTableName As String, ByVal sIndexName As String) As Boolean

        '*** ASSERTION ***
        If String.IsNullOrEmpty(sTableName) Then Throw New ArgumentNullException("sTableName")
        If String.IsNullOrEmpty(sIndexName) Then Throw New ArgumentNullException("sIndexName")
        '*** ASSERTION ***

        Throw New ApplicationException("ProviderIndexExists method not implemented for SQLite provider")

        Return False

    End Function

    ''' <summary>
    ''' Connection string for the database provider object
    ''' </summary>
    Protected Overrides Property ConnectionString() As String
        Get
            Return msConnectionString
        End Get
        Set(ByVal value As String)
            msConnectionString = value
        End Set
    End Property

    ''' <summary>
    ''' Returns an array of SQLiteParameters of the specified size
    ''' </summary>
    ''' <param name="size">size of the array</param>
    ''' <returns>The array of OdbcParameters</returns>
    Protected Overrides Function GetDataParameters(ByVal size As Integer) As IDataParameter()

        Return New SQLiteParameter(size - 1) {}
    End Function 'GetDataParameters

    ''' <summary>
    ''' Returns an SQLiteConnection object for the given connection string
    ''' </summary>
    ''' <param name="connectionString">The connection string to be used to create the connection</param>
    ''' <returns>An SQLiteConnection object</returns>
    Public Overrides Function GetConnection(ByVal connectionString As String) As IDbConnection

        Return New SQLiteConnection(connectionString)
    End Function 'GetConnection

    ''' <summary>
    ''' Returns an SQLiteDataAdapter object
    ''' </summary>
    ''' <returns>The SQLiteDataAdapter</returns>
    Public Overrides Function GetDataAdapter() As IDbDataAdapter

        Return New SQLiteDataAdapter
    End Function 'GetDataAdapter

    ''' <summary>
    ''' Calls the CommandBuilder.DeriveParameters method for the specified provider, doing any setup and cleanup necessary
    ''' </summary>
    ''' <param name="cmd">The IDbCommand referencing the stored procedure from which the parameter information is to be derived. The derived parameters are added to the Parameters collection of the IDbCommand. </param>
    Public Overrides Sub DeriveParameters(ByVal cmd As IDbCommand)

        '*****************************************************************************************
        '*** NOTE:  SQLite does NOT support stored procedures, so this routine is stubbed out. ***
        '*****************************************************************************************

        Dim mustCloseConnection As Boolean = False

        If Not TypeOf cmd Is SQLiteCommand Then
            Throw New ArgumentException("The command provided is not a SQLiteCommand instance.", "cmd")
        End If
        If cmd.Connection.State <> ConnectionState.Open Then

            cmd.Connection.Open()
            mustCloseConnection = True
        End If

        'v-- DeriveParameters method not defined --
        'SQLiteCommandBuilder.DeriveParameters(DirectCast(cmd, SQLiteCommand))
        '^-- DeriveParameters method not defined --

        If mustCloseConnection Then

            cmd.Connection.Close()
        End If
    End Sub 'DeriveParameters

    ''' <summary>
    ''' Returns an SQLiteParameter object
    ''' </summary>
    ''' <returns>The SQLiteParameter object</returns>
    Public Overloads Overrides Function GetParameter() As IDataParameter

        Return New SQLiteParameter
    End Function 'GetParameter

    ''' <summary>
    ''' This cleans up the parameter syntax for an SQLite call.  This was split out from PrepareCommand so that it could be called independently.
    ''' </summary>
    ''' <param name="command">An IDbCommand object containing the CommandText to clean.</param>
    Public Overrides Sub CleanParameterSyntax(ByVal command As IDbCommand)

    End Sub 'CleanParameterSyntax

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the provided IDbConnection. 
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' XmlReader r = helper.ExecuteXmlReader(command);
    ''' </code></example>
    ''' <param name="command">The IDbCommand to execute</param>
    ''' <returns>An XmlReader containing the resultset generated by the command</returns>
    Public Overloads Overrides Function ExecuteXmlReader(ByVal command As IDbCommand) As XmlReader

        Dim mustCloseConnection As Boolean = False

        If command.Connection.State <> ConnectionState.Open Then

            command.Connection.Open()
            mustCloseConnection = True
        End If

        CleanParameterSyntax(command)
        Dim da As New SQLiteDataAdapter(DirectCast(command, SQLiteCommand))
        Dim ds As New DataSet

        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds)

        Dim stream As New StringReader(ds.GetXml())
        If mustCloseConnection Then

            command.Connection.Close()
        End If

        Return New XmlTextReader(stream)
    End Function 'ExecuteXmlReader

    ''' <summary>
    ''' Provider specific code to set up the updating/ed event handlers used by UpdateDataset
    ''' </summary>
    ''' <param name="dataAdapter">DataAdapter to attach the event handlers to</param>
    ''' <param name="rowUpdatingHandler">The handler to be called when a row is updating</param>
    ''' <param name="rowUpdatedHandler">The handler to be called when a row is updated</param>
    Protected Overrides Sub AddUpdateEventHandlers(ByVal dataAdapter As IDbDataAdapter, ByVal rowUpdatingHandler As RowUpdatingHandler, ByVal rowUpdatedHandler As RowUpdatedHandler)

        If Not (rowUpdatingHandler Is Nothing) Then

            Me.m_rowUpdating = rowUpdatingHandler
            AddHandler DirectCast(dataAdapter, SQLiteDataAdapter).RowUpdating, AddressOf RowUpdating
        End If

        If Not (rowUpdatedHandler Is Nothing) Then

            Me.m_rowUpdated = rowUpdatedHandler
            AddHandler DirectCast(dataAdapter, SQLiteDataAdapter).RowUpdated, AddressOf RowUpdated
        End If
    End Sub 'AddUpdateEventHandlers

    ''' <summary>
    ''' Handles the RowUpdating event
    ''' </summary>
    ''' <param name="obj">The object that published the event</param>
    ''' <param name="e">The SQLiteRowUpdatingEventArgs</param>
    Protected Shadows Sub RowUpdating(ByVal obj As Object, ByVal e As System.Data.Common.RowUpdatingEventArgs)

        MyBase.RowUpdating(obj, e)
    End Sub 'RowUpdating

    ''' <summary>
    ''' Handles the RowUpdated event
    ''' </summary>
    ''' <param name="obj">The object that published the event</param>
    ''' <param name="e">The SQLiteRowUpdatedEventArgs</param>
    Protected Shadows Sub RowUpdated(ByVal obj As Object, ByVal e As System.Data.Common.RowUpdatedEventArgs)

        MyBase.RowUpdated(obj, e)
    End Sub 'RowUpdated

    ''' <summary>
    ''' Handle any provider-specific issues with BLOBs here by "washing" the IDataParameter and returning a new one that is set up appropriately for the provider.
    ''' </summary>
    ''' <param name="connection">The IDbConnection to use in cleansing the parameter</param>
    ''' <param name="p">The parameter before cleansing</param>
    ''' <returns>The parameter after it's been cleansed.</returns>
    Protected Overrides Function GetBlobParameter(ByVal connection As IDbConnection, ByVal p As IDataParameter) As IDataParameter

        ' nothing special needed for SQLite...as far as we know now
        Return p
    End Function 'GetBlobParameter

#End Region

End Class