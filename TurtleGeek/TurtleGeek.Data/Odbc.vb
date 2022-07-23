Option Explicit On 
Option Strict On

' ===============================================================================
' Microsoft Data Access Application Block for .NET 3.0
'
' Odbc.vb
'
' This file contains the implementations of the AdoHelper supporting ODBC.
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
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Xml
Imports System.IO

''' <summary>
''' The Odbc class is intended to encapsulate high performance, scalable best practices for 
''' common uses of the Odbc ADO.NET provider.  It is created using the abstract factory in AdoHelper
''' </summary>
Public Class Odbc
    Inherits AdoHelper
    ' used for correcting Call syntax for stored procedures in ODBC
    Private Shared _regExpr As New Regex("\{.*call|CALL\s\w+.*}", RegexOptions.Compiled)

    Private msConnectionString As String = String.Empty

    ''' <summary>
    ''' Create an Odbc Helper.  Needs to be a default constructor so that the Factory can create it
    ''' </summary>
    Public Sub New()

    End Sub 'New

#Region "Overrides"

    ''' <summary>
    ''' Native database provider type
    ''' </summary>
    Protected Overrides ReadOnly Property ProviderDatabaseType() As DatabaseTypeEnum
        Get
            Return DatabaseTypeEnum.Odbc
        End Get
    End Property

    ''' <summary>
    ''' The date delimiter of the native database provider
    ''' </summary>
    Protected Overrides ReadOnly Property ProviderDateDelimiter() As String
        Get
            '-- if this is an Access database...
            If Me.ConnectionString.ToUpper.Contains(".MDB") OrElse Me.ConnectionString.ToUpper.Contains(".ACCDB") Then
                Return "#"
            Else
                '-- else, default to the most common date delimiter
                Return "'"
            End If
        End Get
    End Property

    ''' <summary>
    ''' The date format of the native database provider
    ''' </summary>
    Protected Overrides ReadOnly Property ProviderDateFormat() As String
        Get
            '-- if this is an Oracle database...
            If Me.ConnectionString.ToUpper.Contains("MSDSORA") OrElse Me.ConnectionString.ToUpper.Contains("ORACLE") Then
                Return "dd-MMM-yyyy HH:mm:ss"
            Else
                '-- else, default to the most common date format
                Return "yyyy-MM-dd HH:mm:ss"
            End If
        End Get
    End Property

    ''' <summary>
    ''' The upper casing function of the native database provider
    ''' </summary>
    Protected Overrides ReadOnly Property ProviderUpperFunction() As String
        Get
            If Me.ConnectionString.ToUpper.Contains(".MDB") OrElse Me.ConnectionString.ToUpper.Contains(".ACCDB") Then
                '-- if this is an Access database...
                Return "UCASE"
            Else
                '-- else, default to the most common upper casing function
                Return "UPPER"
            End If
        End Get
    End Property

    ''' <summary>
    ''' The ISNULL or COALESCE or NVL or IFNULL function of the native database provider
    ''' </summary>
    ''' <param name="sColumnName">Column to check for null.</param>
    ''' <param name="sValue">Value to be used if field is null.</param>
    Protected Overrides ReadOnly Property ProviderIsNullFunction(ByVal sColumnName As String, ByVal sValue As String) As String
        Get
            If Me.ConnectionString.ToUpper.Contains(".MDB") OrElse Me.ConnectionString.ToUpper.Contains(".ACCDB") Then
                'Return "IIF(ISNULL(my_count), 0, my_count)"
                '-- if this is an Access database...
                Return "IIF(ISNULL(" & sColumnName & "), " & sValue & ", " & sColumnName & ")"
            Else
                '-- else, default to the most common "is null" function
                Return "ISNULL(" & sColumnName & ", " & sValue & ")"
            End If
        End Get
    End Property

    ''' <summary>
    ''' The native-provider SQL string to return the last Identity value  
    ''' </summary>
    Protected Overrides ReadOnly Property ProviderLastIdentityValueSql() As String
        Get
            '-- if this is an Oracle database...
            If Me.ConnectionString.ToUpper.Contains("MSDSORA") OrElse Me.ConnectionString.ToUpper.Contains("ORACLE") Then
                Return String.Empty '???TODO:  find a way to do this in Oracle...maybe require a stored procedure???
            Else
                '-- else, default to the most common way to get the last Identity value
                Return "SELECT @@IDENTITY"
            End If
        End Get
    End Property

    ''' <summary>
    ''' The native-provider routine to clean or compact/repair or truncate temp databases  
    ''' </summary>
    Protected Overrides Sub ProviderCleanDatabase()

        Dim iStartPos As Integer
        Dim iEndPos As Integer
        Dim sConnectionString As String = String.Empty
        Dim sDatabaseFileExtension As String = String.Empty
        Dim sDatabaseFileName As String = String.Empty

        '----------------------------------------------------------------
        '-- if this is an Access database...
        '----------------------------------------------------------------
        sConnectionString = Me.ConnectionString
        If sConnectionString.ToUpper.Contains(".MDB") OrElse sConnectionString.ToUpper.Contains(".ACCDB") Then

            '----------------------------------------------------------------
            '-- run a "compact/repair" operation on the Access database 
            '-- to retrieve space created during deletions
            '----------------------------------------------------------------
            Try
                If sConnectionString.ToUpper.Contains(".MDB") Then
                    sDatabaseFileExtension = ".mdb"
                ElseIf sConnectionString.ToUpper.Contains(".ACCDB") Then
                    sDatabaseFileExtension = ".accdb"
                End If

                iStartPos = sConnectionString.IndexOf("Data Source=") + "Data Source=".Length
                iEndPos = sConnectionString.ToUpper.IndexOf(sDatabaseFileExtension.ToUpper) + sDatabaseFileExtension.Length
                sDatabaseFileName = sConnectionString.Substring(iStartPos, iEndPos - iStartPos)

                Utilities.CompactAccessDatabase(sDatabaseFileName)

            Catch ex As Exception
            End Try

        End If

    End Sub

    ''' <summary>
    ''' The native-provider routine to determine if the specified table exists in the database 
    ''' </summary>
    Protected Overrides Function ProviderTableExists(ByVal sTableName As String) As Boolean

        '*** ASSERTION ***
        If String.IsNullOrEmpty(sTableName) Then Throw New ArgumentNullException("sTableName")
        '*** ASSERTION ***

        Throw New ApplicationException("ProviderTableExists method not implemented for Odbc provider")

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

        Throw New ApplicationException("ProviderColumnExists method not implemented for Odbc provider")

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

        Throw New ApplicationException("ProviderIndexExists method not implemented for Odbc provider")

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
    ''' Returns an array of OdbcParameters of the specified size
    ''' </summary>
    ''' <param name="size">size of the array</param>
    ''' <returns>The array of OdbcParameters</returns>
    Protected Overrides Function GetDataParameters(ByVal size As Integer) As IDataParameter()

        Return New OdbcParameter(size - 1) {}
    End Function 'GetDataParameters

    ''' <summary>
    ''' Returns an OdbcConnection object for the given connection string
    ''' </summary>
    ''' <param name="connectionString">The connection string to be used to create the connection</param>
    ''' <returns>An OdbcConnection object</returns>
    Public Overrides Function GetConnection(ByVal connectionString As String) As IDbConnection
        Return New OdbcConnection(connectionString)
    End Function 'GetConnection

    ''' <summary>
    ''' Returns an OdbcDataAdapter object
    ''' </summary>
    ''' <returns>The OdbcDataAdapter</returns>
    Public Overrides Function GetDataAdapter() As IDbDataAdapter

        Return New OdbcDataAdapter
    End Function 'GetDataAdapter

    ''' <summary>
    ''' Calls the CommandBuilder.DeriveParameters method for the specified provider, doing any setup and cleanup necessary
    ''' </summary>
    ''' <param name="cmd">The IDbCommand referencing the stored procedure from which the parameter information is to be derived. The derived parameters are added to the Parameters collection of the IDbCommand. </param>
    Public Overrides Sub DeriveParameters(ByVal cmd As IDbCommand)

        Dim mustCloseConnection As Boolean = False

        If Not TypeOf cmd Is OdbcCommand Then
            Throw New ArgumentException("The command provided is not a OdbcCommand instance.", "cmd")
        End If
        If cmd.Connection.State <> ConnectionState.Open Then
            cmd.Connection.Open()
            mustCloseConnection = True
        End If

        OdbcCommandBuilder.DeriveParameters(DirectCast(cmd, OdbcCommand))

        If mustCloseConnection Then

            cmd.Connection.Close()
        End If
    End Sub 'DeriveParameters

    ''' <summary>
    ''' Returns an OdbcParameter object
    ''' </summary>
    ''' <returns>The OdbcParameter object</returns>
    Public Overloads Overrides Function GetParameter() As IDataParameter

        Return New OdbcParameter
    End Function 'GetParameter

    ''' <summary>
    ''' This cleans up the parameter syntax for an ODBC call.  This was split out from PrepareCommand so that it could be called independently.
    ''' </summary>
    ''' <param name="command">An IDbCommand object containing the CommandText to clean.</param>
    Public Overrides Sub CleanParameterSyntax(ByVal command As IDbCommand)

        Dim [call] As String = " call "

        If command.CommandType = CommandType.StoredProcedure Then

            If Not _regExpr.Match(command.CommandText).Success AndAlso _
                command.CommandText.Trim().IndexOf(" ") = -1 Then  ' It does not like like { call sp_name() }

                ' If there's only a stored procedure name
                Dim par As New StringBuilder
                If command.Parameters.Count <> 0 Then

                    Dim isFirst As Boolean = True
                    Dim hasParameters As Boolean = False
                    Dim i As Integer
                    For i = 0 To command.Parameters.Count - 1

                        Dim p As OdbcParameter = DirectCast(command.Parameters(i), OdbcParameter)
                        If p.Direction <> ParameterDirection.ReturnValue Then

                            If isFirst Then

                                isFirst = False
                                par.Append("(?")

                            Else

                                par.Append(",?")
                            End If
                            hasParameters = True

                        Else

                            [call] = " ? = call "
                        End If
                    Next i
                    If hasParameters Then

                        par.Append(")")
                    End If
                End If
                command.CommandText = "{" + [call] + command.CommandText + par.ToString() + " }"
            End If
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
        Dim da As New OdbcDataAdapter(DirectCast(command, OdbcCommand))
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
    ''' <param name="rowUpdatedHandler">The handler to be called when a row is updated</param>-----------------------------------------------------------------------------
    Protected Overrides Sub AddUpdateEventHandlers(ByVal dataAdapter As IDbDataAdapter, ByVal rowUpdatingHandler As RowUpdatingHandler, ByVal rowUpdatedHandler As RowUpdatedHandler)

        If Not (rowUpdatingHandler Is Nothing) Then

            Me.m_rowUpdating = rowUpdatingHandler
            AddHandler DirectCast(dataAdapter, OdbcDataAdapter).RowUpdating, AddressOf RowUpdating
        End If

        If Not (rowUpdatedHandler Is Nothing) Then

            Me.m_rowUpdated = rowUpdatedHandler
            AddHandler DirectCast(dataAdapter, OdbcDataAdapter).RowUpdated, AddressOf RowUpdated
        End If
    End Sub 'AddUpdateEventHandlers

    ''' <summary>
    ''' Handles the RowUpdating event
    ''' </summary>
    ''' <param name="obj">The object that published the event</param>
    ''' <param name="e">The OdbcRowUpdatingEventArgs</param>
    Protected Shadows Sub RowUpdating(ByVal obj As Object, ByVal e As OdbcRowUpdatingEventArgs)

        MyBase.RowUpdating(obj, e)
    End Sub 'RowUpdating

    ''' <summary>
    ''' Handles the RowUpdated event
    ''' </summary>
    ''' <param name="obj">The object that published the event</param>
    ''' <param name="e">The OdbcRowUpdatedEventArgs</param>
    Protected Shadows Sub RowUpdated(ByVal obj As Object, ByVal e As OdbcRowUpdatedEventArgs)

        MyBase.RowUpdated(obj, e)
    End Sub 'RowUpdated

    ''' <summary>
    ''' Handle any provider-specific issues with BLOBs here by "washing" the IDataParameter and returning a new one that is set up appropriately for the provider.
    ''' </summary>
    ''' <param name="connection">The IDbConnection to use in cleansing the parameter</param>
    ''' <param name="p">The parameter before cleansing</param>
    ''' <returns>The parameter after it's been cleansed.</returns>
    Protected Overrides Function GetBlobParameter(ByVal connection As IDbConnection, ByVal p As IDataParameter) As IDataParameter

        ' nothing special needed for ODBC...so far as we know now.
        Return p
    End Function 'GetBlobParameter

#End Region

End Class
