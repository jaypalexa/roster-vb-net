Option Explicit On 
Option Strict On

' ===============================================================================
' Microsoft Data Access Application Block for .NET 3.0
'
' Oracle.vb
'
' This file contains the implementations of the AdoHelper supporting Oracle.
'
' For more information see the Documentation. 
' ===============================================================================
' Release history
' VERSION	DESCRIPTION
'   2.0	Added support for FillDataset, UpdateDataset and "Param" helper methods
'   3.0	New abstract class supporting the same methods using ADO.NET interfaces
'
' ===============================================================================
' Copyright (C) 2000-2001 Microsoft Corporation
' All rights reserved.
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
' OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
' LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR
' FITNESS FOR A PARTICULAR PURPOSE.
' ==============================================================================
Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.OracleClient
Imports System.Xml
Imports System.IO

''' <summary>
''' The Oracle class is intended to encapsulate high performance, scalable best practices for 
''' common uses of the Oracle ADO.NET provider.  It is created using the abstract factory in AdoHelper.
''' </summary>
Public Class Oracle
    Inherits AdoHelper

    Private msConnectionString As String = String.Empty

    ''' <summary>
    ''' Create an Oracle Helper.  Needs to be a default constructor so that the Factory can create it
    ''' </summary>
    Public Sub New()

    End Sub 'New

#Region "Overrides"

    ''' <summary>
    ''' Native database provider type
    ''' </summary>
    Protected Overrides ReadOnly Property ProviderDatabaseType() As DatabaseTypeEnum
        Get
            Return DatabaseTypeEnum.Oracle
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
            Return "dd-MMM-yyyy hh:mm:ss tt"
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
            Return "NVL(" & sColumnName & ", " & sValue & ")"
        End Get
    End Property

    ''' <summary>
    ''' The native-provider SQL string to return the last Identity value  
    ''' </summary>
    Protected Overrides ReadOnly Property ProviderLastIdentityValueSql() As String
        Get
            Return String.Empty '???TODO:  find a way to do this in Oracle...maybe require a stored procedure???
        End Get
    End Property

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
    ''' Returns an array of OracleParameters of the specified size
    ''' </summary>
    ''' <param name="size">size of the array</param>
    ''' <returns>The array of OracleParameters</returns>
    Protected Overrides Function GetDataParameters(ByVal size As Integer) As IDataParameter()

        Return New OracleParameter(size - 1) {}
    End Function 'GetDataParameters

    ''' <summary>
    ''' The native-provider routine to clean or compact/repair or truncate temp databases  
    ''' </summary>
    Protected Overrides Sub ProviderCleanDatabase()
        ''???TODO:  figure out the ORACLE function
        'Try
        'Catch ex As Exception
        'End Try
    End Sub

    ''' <summary>
    ''' The native-provider routine to determine if the specified table exists in the database 
    ''' </summary>
    Protected Overrides Function ProviderTableExists(ByVal sTableName As String) As Boolean

        '*** ASSERTION ***
        If String.IsNullOrEmpty(sTableName) Then Throw New ArgumentNullException("sTableName")
        '*** ASSERTION ***

        Dim bReturnValue As Boolean = False
        Dim s As String = String.Empty

        sTableName = sTableName.Replace("[", "").Replace("]", "")

        s = "SELECT table_name FROM user_tables "
        s &= "WHERE UPPER(table_name) = UPPER('" & sTableName & "') "

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
            Using oDataReader As SafeDataReader = oAdoHelper.ExecuteReader(s)
                If oDataReader.Read() Then
                    bReturnValue = True
                End If
            End Using
        End Using

        Return bReturnValue

    End Function

    ''' <summary>
    ''' The native-provider routine to determine if the specified table + column exists in the database 
    ''' </summary>
    Protected Overrides Function ProviderColumnExists(ByVal sTableName As String, ByVal sColumnName As String) As Boolean

        '*** ASSERTION ***
        If String.IsNullOrEmpty(sTableName) Then Throw New ArgumentNullException("sTableName")
        If String.IsNullOrEmpty(sColumnName) Then Throw New ArgumentNullException("sColumnName")
        '*** ASSERTION ***

        Dim bReturnValue As Boolean = False
        Dim s As String = String.Empty

        If ProviderTableExists(sTableName) Then

            sTableName = sTableName.Replace("[", "").Replace("]", "")
            sColumnName = sColumnName.Replace("[", "").Replace("]", "")

            s = "SELECT column_name FROM user_tab_columns "
            s &= "WHERE UPPER(table_name) = UPPER('" & sTableName & "') "
            s &= "AND UPPER(column_name) = UPPER('" & sColumnName & "') "

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                Using oDataReader As SafeDataReader = oAdoHelper.ExecuteReader(s)
                    If oDataReader.Read() Then
                        bReturnValue = True
                    End If
                End Using
            End Using

        End If

        Return bReturnValue

    End Function

    ''' <summary>
    ''' The native-provider routine to determine if the specified table + index exists in the database 
    ''' </summary>
    Protected Overrides Function ProviderIndexExists(ByVal sTableName As String, ByVal sIndexName As String) As Boolean

        '*** ASSERTION ***
        If String.IsNullOrEmpty(sTableName) Then Throw New ArgumentNullException("sTableName")
        If String.IsNullOrEmpty(sIndexName) Then Throw New ArgumentNullException("sIndexName")
        '*** ASSERTION ***

        Dim bReturnValue As Boolean = False
        Dim s As String = String.Empty

        If ProviderTableExists(sTableName) Then

            sTableName = sTableName.Replace("[", "").Replace("]", "")
            sIndexName = sIndexName.Replace("[", "").Replace("]", "")

            s = "SELECT index_name FROM user_indexes "
            s &= "WHERE UPPER(table_name) = UPPER('" & sTableName & "') "
            s &= "AND UPPER(index_name) = UPPER('" & sIndexName & "') "

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                Using oDataReader As SafeDataReader = oAdoHelper.ExecuteReader(s)
                    If oDataReader.Read() Then
                        bReturnValue = True
                    End If
                End Using
            End Using

        End If

        Return bReturnValue

    End Function

    ''' <summary>
    ''' Returns an OracleConnection object for the given connection string
    ''' </summary>
    ''' <param name="connectionString">The connection string to be used to create the connection</param>
    ''' <returns>An OracleConnection object</returns>
    Public Overrides Function GetConnection(ByVal connectionString As String) As IDbConnection

        Return New OracleConnection(connectionString)
    End Function 'GetConnection

    ''' <summary>
    ''' Returns an OracleDataAdapter object
    ''' </summary>
    ''' <returns>The OracleDataAdapter</returns>
    Public Overrides Function GetDataAdapter() As IDbDataAdapter

        Return New OracleDataAdapter
    End Function 'GetDataAdapter

    ''' <summary>
    ''' Calls the CommandBuilder.DeriveParameters method for the specified provider, doing any setup and cleanup necessary
    ''' </summary>
    ''' <param name="cmd">The IDbCommand referencing the stored procedure from which the parameter information is to be derived. The derived parameters are added to the Parameters collection of the IDbCommand. </param>
    Public Overrides Sub DeriveParameters(ByVal cmd As IDbCommand)

        Dim mustCloseConnection As Boolean = False

        If Not TypeOf cmd Is OracleCommand Then
            Throw New ArgumentException("The command provided is not an OracleCommand instance.", "cmd")
        End If
        If cmd.Connection.State <> ConnectionState.Open Then

            cmd.Connection.Open()
            mustCloseConnection = True
        End If

        OracleCommandBuilder.DeriveParameters(DirectCast(cmd, OracleCommand))

        If mustCloseConnection Then

            cmd.Connection.Close()
        End If
    End Sub 'DeriveParameters

    ''' <summary>
    ''' Returns an OracleParameter object
    ''' </summary>
    ''' <returns>The OracleParameter object</returns>
    Public Overloads Overrides Function GetParameter() As IDataParameter

        Dim parameter As New OracleParameter
        parameter.Size = 4000   '255
        Return parameter
    End Function 'GetParameter

    ''' <summary>
    ''' Get an IDataParameter for use in a SQL command
    ''' </summary>
    ''' <param name="parameterName">The name of the parameter to create</param>
    ''' <param name="value">The value of the specified parameter</param>
    ''' <returns>An IDataParameter object</returns>
    Public Overloads Overrides Function GetParameter(ByVal parameterName As String, ByVal value As Object) As IDataParameter

        Dim parameter As New OracleParameter

        parameter.ParameterName = parameterName

        If (TypeOf value Is Guid) Then
            parameter.Value = value.ToString.ToUpper.Trim
        Else
            parameter.Value = value
        End If

        parameter.Size = GetParameterSize(parameterName)

        Return parameter

    End Function 'GetParameter

    ''' <summary> 
    ''' This function will get and assemble the parameter's size dynamically from db or cache 
    ''' </summary> 
    ''' <param name="name">The parameter name</param> 
    ''' <returns>The size</returns> 
    Private Function GetParameterSize(ByVal name As String) As Integer

        Dim Size As Integer = 4000  '255
        Return Size
    End Function 'GetParameterSize

    ''' <summary>
    ''' This cleans up the parameter syntax for an Oracle call.  This was split out from PrepareCommand so that it could be called independently.
    ''' </summary>
    ''' <param name="command">An IDbCommand object containing the CommandText to clean.</param>
    Public Overrides Sub CleanParameterSyntax(ByVal command As IDbCommand)

        If command.CommandType = CommandType.Text Then
            command.CommandText = command.CommandText.Replace("@", ":")
        End If

        If command.Parameters.Count > 0 Then
            Dim parameter As OracleParameter
            For Each parameter In command.Parameters

                parameter.ParameterName = parameter.ParameterName.Replace("@", ":")
            Next parameter
        End If
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
        Dim da As New OracleDataAdapter(DirectCast(command, OracleCommand))
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
            AddHandler DirectCast(dataAdapter, OracleDataAdapter).RowUpdating, AddressOf RowUpdating
        End If

        If Not (rowUpdatedHandler Is Nothing) Then

            Me.m_rowUpdated = rowUpdatedHandler
            AddHandler DirectCast(dataAdapter, OracleDataAdapter).RowUpdated, AddressOf RowUpdated
        End If
    End Sub 'AddUpdateEventHandlers

    ''' <summary>
    ''' Handles the RowUpdating event
    ''' </summary>
    ''' <param name="obj">The object that published the event</param>
    ''' <param name="e">The OracleRowUpdatingEventArgs</param>
    Protected Shadows Sub RowUpdating(ByVal obj As Object, ByVal e As OracleRowUpdatingEventArgs)

        MyBase.RowUpdating(obj, e)
    End Sub 'RowUpdating

    ''' <summary>
    ''' Handles the RowUpdated event
    ''' </summary>
    ''' <param name="obj">The object that published the event</param>
    ''' <param name="e">The OracleRowUpdatedEventArgs</param>
    Protected Shadows Sub RowUpdated(ByVal obj As Object, ByVal e As OracleRowUpdatedEventArgs)

        MyBase.RowUpdated(obj, e)
    End Sub 'RowUpdated

    ''' <summary>
    ''' Handle any provider-specific issues with BLOBs here by "washing" the IDataParameter and returning a new one that is set up appropriately for the provider.
    ''' See MS KnowledgeBase article: http://support.microsoft.com/default.aspx?scid=kb;en-us;322796
    ''' </summary>
    ''' <param name="connection">The IDbConnection to use in cleansing the parameter</param>
    ''' <param name="p">The parameter before cleansing</param>
    ''' <returns>The parameter after it's been cleansed.</returns>
    Protected Overrides Function GetBlobParameter(ByVal connection As IDbConnection, ByVal p As IDataParameter) As IDataParameter

        Dim clonedConnection As OracleConnection = DirectCast(DirectCast(connection, ICloneable).Clone(), OracleConnection)

        clonedConnection.Open()

        Dim cmd As OracleCommand = clonedConnection.CreateCommand()
        cmd.CommandText = "declare xx blob; begin dbms_lob.createtemporary(xx, false, 0); :tempblob := xx; end;"
        cmd.Parameters.Add(New OracleParameter("tempblob", OracleType.Blob)).Direction = ParameterDirection.Output
        cmd.ExecuteNonQuery()

        Dim tempLob As OracleLob
        tempLob = DirectCast(cmd.Parameters(0).Value, OracleLob)
        tempLob.BeginBatch(OracleLobOpenMode.ReadWrite)
        tempLob.Write(DirectCast(p.Value, Byte()), 0, System.Runtime.InteropServices.Marshal.SizeOf(p.Value))
        tempLob.EndBatch()

        Dim op As New OracleParameter(p.ParameterName, OracleType.Blob)
        op.Value = tempLob

        clonedConnection.Close()

        Return op
    End Function 'GetBlobParameter 

#End Region

End Class 'Oracle
