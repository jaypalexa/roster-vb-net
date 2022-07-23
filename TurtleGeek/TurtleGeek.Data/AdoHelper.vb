Option Explicit On 
Option Strict On

' ===============================================================================
' Microsoft Data Access Application Block for .NET 3.0
'
' AdoHelper.vb
'
' This file contains an abstract implementations of the AdoHelper class.
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
Imports System.Configuration
Imports System.Data
Imports System.Data.Common
Imports System.Reflection
Imports System.Xml
Imports System.Diagnostics
Imports System.Windows.Forms

''' <summary>
''' The AdoHelper class is intended to encapsulate high performance, scalable best practices for
''' common data access uses. It uses the Abstract Factory pattern to be easily extensible
''' to any ADO.NET provider. The current implementation provides helpers for SQL Server, ODBC,
''' OLEDB, and Oracle.
'''
''' *** NOTE:  SafeDataReader is used instead of IDataReader for all ExecuteReader overrides!!!
'''
''' </summary>
Public MustInherit Class AdoHelper
    Implements IDisposable

    ''' <summary>
    ''' This enum is used to indicate whether the connection was provided by the caller, or created by AdoHelper, so that
    ''' we can set the appropriate CommandBehavior when calling ExecuteReader()
    ''' </summary>
    Protected Enum AdoConnectionOwnership
        ''' <summary>Connection is owned and managed by ADOHelper</summary>
        Internal
        ''' <summary>Connection is owned and managed by the caller</summary>
        [External]
    End Enum 'AdoConnectionOwnership

#Region " Added Utility Functions "

    Public Function GetSqlStringWithParameters(ByVal voDbCommand As IDbCommand) As String

        Dim sCommandText As String
        Dim oDataParameter As System.Data.IDataParameter

        sCommandText = voDbCommand.CommandText

        For Each oDataParameter In voDbCommand.Parameters
            sCommandText = sCommandText.Replace(oDataParameter.ParameterName, GetParameterValue(oDataParameter))
        Next

        Return sCommandText

    End Function

    Private Function GetParameterValue(ByVal voDataParameter As IDataParameter) As String

        If (voDataParameter.Value Is System.DBNull.Value) Then
            Return "NULL"
        Else
            Select Case voDataParameter.DbType

                Case DbType.AnsiString, DbType.AnsiStringFixedLength, _
                     DbType.Date, DbType.DateTime, _
                     DbType.Guid, _
                     DbType.String, DbType.StringFixedLength, _
                     DbType.Time

                    Return "'" & voDataParameter.Value.ToString & "'"

                    'Case DbType.Binary, DbType.Object
                    '   Return ???

                Case Else
                    Return voDataParameter.Value.ToString

            End Select
        End If

    End Function

#End Region

#Region " Declare members "

    ' necessary for handling the general case of needing event handlers for RowUpdating/ed events
    ''' <summary>
    ''' Internal handler used for bubbling up the event to the user
    ''' </summary>
    Protected m_rowUpdating As RowUpdatingHandler

    ''' <summary>
    ''' Internal handler used for bubbling up the event to the user
    ''' </summary>
    Protected m_rowUpdated As RowUpdatedHandler

    ''' <summary>
    ''' Database-specific provider object
    ''' </summary>
    Private Shared moProvider As AdoHelper = Nothing

#End Region

#Region " Provider-Specific Abstract Methods "

    ''' <summary>
    ''' Returns an IDbConnection object for the given connection string
    ''' </summary>
    ''' <param name="connectionString">The connection string to be used to create the connection</param>
    ''' <returns>An IDbConnection object</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString is null</exception>
    Public MustOverride Function GetConnection(ByVal connectionString As String) As IDbConnection

    ''' <summary>
    ''' Returns an IDbDataAdapter object
    ''' </summary>
    ''' <returns>The IDbDataAdapter</returns>
    Public MustOverride Function GetDataAdapter() As IDbDataAdapter

    ''' <summary>
    ''' Calls the CommandBuilder.DeriveParameters method for the specified provider, doing any setup and cleanup necessary
    ''' </summary>
    ''' <param name="cmd">The IDbCommand referencing the stored procedure from which the parameter information is to be derived. The derived parameters are added to the Parameters collection of the IDbCommand. </param>
    Public MustOverride Sub DeriveParameters(ByVal cmd As IDbCommand)

    ''' <summary>
    ''' Returns an IDataParameter object
    ''' </summary>
    ''' <returns>The IDataParameter object</returns>
    Public MustOverride Overloads Function GetParameter() As IDataParameter

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the provided IDbConnection.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' XmlReader r = helper.ExecuteXmlReader(command);
    ''' </code></example>
    ''' <param name="cmd">The IDbCommand to execute</param>
    ''' <returns>An XmlReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if command is null.</exception>
    Public MustOverride Overloads Function ExecuteXmlReader(ByVal cmd As IDbCommand) As XmlReader

    ''' <summary>
    ''' Provider specific code to set up the updating/ed event handlers used by UpdateDataset
    ''' </summary>
    ''' <param name="dataAdapter">DataAdapter to attach the event handlers to</param>
    ''' <param name="rowUpdatingHandler">The handler to be called when a row is updating</param>
    ''' <param name="rowUpdatedHandler">The handler to be called when a row is updated</param>
    Protected MustOverride Sub AddUpdateEventHandlers(ByVal dataAdapter As IDbDataAdapter, ByVal rowUpdatingHandler As RowUpdatingHandler, ByVal rowUpdatedHandler As RowUpdatedHandler)

    ''' <summary>
    ''' Returns an array of IDataParameters of the specified size
    ''' </summary>
    ''' <param name="size">size of the array</param>
    ''' <returns>The array of IDataParameters</returns>
    Protected MustOverride Function GetDataParameters(ByVal size As Integer) As IDataParameter()

    ''' <summary>
    ''' Handle any provider-specific issues with BLOBs here by "washing" the IDataParameter and returning a new one that is set up appropriately for the provider.
    ''' </summary>
    ''' <param name="connection">The IDbConnection to use in cleansing the parameter</param>
    ''' <param name="p">The parameter before cleansing</param>
    ''' <returns>The parameter after it's been cleansed.</returns>
    Protected MustOverride Function GetBlobParameter(ByVal connection As IDbConnection, ByVal p As IDataParameter) As IDataParameter

    ''' <summary>
    ''' Connection string for the database provider object
    ''' </summary>
    Protected MustOverride Property ConnectionString() As String

    ''' <summary>
    ''' Native database provider type
    ''' </summary>
    Protected MustOverride ReadOnly Property ProviderDatabaseType() As DatabaseTypeEnum

    ''' <summary>
    ''' The date delimiter of the native database provider
    ''' </summary>
    Protected MustOverride ReadOnly Property ProviderDateDelimiter() As String

    ''' <summary>
    ''' The date format of the native database provider
    ''' </summary>
    Protected MustOverride ReadOnly Property ProviderDateFormat() As String

    ''' <summary>
    ''' The upper casing function of the native database provider
    ''' </summary>
    Protected MustOverride ReadOnly Property ProviderUpperFunction() As String

    ''' <summary>
    ''' The ISNULL or COALESCE or NVL or IFNULL function of the native database provider
    ''' </summary>
    ''' <param name="sColumnName">Column to check for null.</param>
    ''' <param name="sValue">Value to be used if field is null.</param>
    Protected MustOverride ReadOnly Property ProviderIsNullFunction(ByVal sColumnName As String, ByVal sValue As String) As String

    ''' <summary>
    ''' The native-provider SQL string to return the last Identity value  
    ''' </summary>
    Protected MustOverride ReadOnly Property ProviderLastIdentityValueSql() As String

    ''' <summary>
    ''' The native-provider routine to clean or compact/repair or truncate temp databases  
    ''' </summary>
    Protected MustOverride Sub ProviderCleanDatabase()

    ''' <summary>
    ''' The native-provider routine to determine if the specified table exists in the database 
    ''' </summary>
    Protected MustOverride Function ProviderTableExists(ByVal sTableName As String) As Boolean

    ''' <summary>
    ''' The native-provider routine to determine if the specified table + column exists in the database 
    ''' </summary>
    Protected MustOverride Function ProviderColumnExists(ByVal sTableName As String, ByVal sColumnName As String) As Boolean

    ''' <summary>
    ''' The native-provider routine to determine if the specified table + index exists in the database 
    ''' </summary>
    Protected MustOverride Function ProviderIndexExists(ByVal sTableName As String, ByVal sIndexName As String) As Boolean

#End Region

#Region "Delegates"
    ' also used in our general case of RowUpdating/ed events
    ''' <summary>
    ''' Delegate for creating a RowUpdatingEvent handler
    ''' </summary>
    ''' <param name="obj">The object that published the event</param>
    ''' <param name="e">The RowUpdatingEventArgs for the event</param>
    Delegate Sub RowUpdatingHandler(ByVal obj As Object, ByVal e As RowUpdatingEventArgs)
    ''' <summary>
    ''' Delegate for creating a RowUpdatedEvent handler
    ''' </summary>
    ''' <param name="obj">The object that published the event</param>
    ''' <param name="e">The RowUpdatedEventArgs for the event</param>
    Delegate Sub RowUpdatedHandler(ByVal obj As Object, ByVal e As RowUpdatedEventArgs)
#End Region

#Region "Factory"

    ''' <summary>
    ''' Create an AdoHelper for working with a specific provider (i.e. Sql, Odbc, OleDb, Oracle, SQLite)
    ''' </summary>
    ''' <returns>An AdoHelper instance of the specified type</returns>
    ''' <example><code>
    ''' Dim helper As AdoHelper = AdoHelper.CreateHelper();
    ''' </code></example>
    Public Overloads Shared Function CreateHelper() As AdoHelper

        Dim sConnectionString As String = String.Empty
        Dim sProviderAssemblyName As String = String.Empty
        Dim sProviderType As String = String.Empty
        Dim oProviderAssembly As System.Reflection.Assembly
        Dim oConfiguration As Configuration

        Try
            '----------------------------------------------------------------
            '-- load the vendor-specific database provider class
            '----------------------------------------------------------------
            sProviderAssemblyName = "TurtleGeek.Data"

            '----------------------------------------------------------------
            '-- first, try the WINDOWS configuration manager...
            '----------------------------------------------------------------
            If (System.Reflection.Assembly.GetEntryAssembly IsNot Nothing) Then
                oConfiguration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
                sProviderType = sProviderAssemblyName & "." & oConfiguration.ConnectionStrings.ConnectionStrings("Default").ProviderName
                sConnectionString = oConfiguration.ConnectionStrings.ConnectionStrings("Default").ConnectionString
            Else
                '----------------------------------------------------------------
                '-- ... else, try the WEB configuration manager
                '----------------------------------------------------------------
                sProviderType = sProviderAssemblyName & "." & System.Web.Configuration.WebConfigurationManager.ConnectionStrings("Default").ProviderName
                sConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings("Default").ConnectionString
            End If

            oProviderAssembly = System.Reflection.Assembly.Load(sProviderAssemblyName)
            moProvider = DirectCast(oProviderAssembly.CreateInstance(sProviderType), AdoHelper)
            moProvider.ConnectionString = sConnectionString

            Return moProvider

        Finally

            oConfiguration = Nothing
            oProviderAssembly = Nothing

        End Try

        '========================================================================================================================
        '== USE CODE BLOCK BELOW TO GET INFO FROM app.config FILE
        '------------------------------------------------------------------------------------------------------------------------
        '  <connectionStrings>
        '     <add name="Source1" providerName="SqlServer" connectionString="Data Source=Leahy\Leahy2005;Database=ngtest55;uid=ngdevl;pwd=ngdevl;" />
        '  </connectionStrings>
        '========================================================================================================================
        'Dim sProviderAssemblyName As String = String.Empty
        'Dim sProviderType As String = String.Empty
        'Dim oProviderAssembly As System.Reflection.Assembly

        'sProviderAssemblyName = "TurtleGeek.Data"
        'sProviderType = "TurtleGeek.Data." & ConfigurationManager.ConnectionStrings(sDbSourceName).ProviderName

        'If moProvider Is Nothing Then
        '    oProviderAssembly = System.Reflection.Assembly.Load(sProviderAssemblyName)
        '    moProvider = DirectCast(oProviderAssembly.CreateInstance(sProviderType), AdoHelper)
        '    moProvider.ConnectionString = ConfigurationManager.ConnectionStrings(sDbSourceName).ConnectionString
        'End If

        'Return moProvider

    End Function

    ' <summary>
    ' Create an AdoHelper for working with a specific provider (i.e. Sql, Odbc, OleDb, Oracle, SQLite)
    ' </summary>
    ' <param name="providerAssemblyName">Assembly containing the specified helper subclass</param>
    ' <param name="providerType">Specific type of the provider</param>
    ' <returns>An AdoHelper instance of the specified type</returns>
    ' <example><code>
    ' AdoHelper helper = AdoHelper.CreateHelper("TurtleGeek.Data", "TurtleGeek.Data.SqlServer");
    ' </code></example>
    'Public Overloads Shared Function CreateHelper(ByVal providerAssemblyName As String, ByVal providerType As String) As AdoHelper
    '    Dim providerAssembly As System.Reflection.Assembly = System.Reflection.Assembly.Load(providerAssemblyName)
    '    Dim provider As Object = providerAssembly.CreateInstance(providerType)
    '    If TypeOf provider Is AdoHelper Then
    '        Return DirectCast(provider, AdoHelper)
    '    Else
    '        Throw New InvalidOperationException("The provider specified does not extend the AdoHelper abstract class.")
    '    End If
    'End Function 'CreateHelper

    ' <summary>
    ' Create an AdoHelper instance for working with a specific provider by using a providerAlias specified in the App.Config file.
    ' </summary>
    ' <param name="providerAlias">The alias to look up</param>
    ' <returns>An AdoHelper instance of the specified type</returns>
    ' <example><code>
    ' AdoHelper helper = AdoHelper.CreateHelper("OracleHelper");
    ' </code></example>
    'Public Overloads Shared Function CreateHelper(ByVal providerAlias As String) As AdoHelper
    '    Dim dict As IDictionary
    '    Try
    '        dict = CType(ConfigurationSettings.GetConfig("daabProviders"), IDictionary)
    '    Catch e As Exception
    '        Throw New InvalidOperationException("If the section is not defined on the configuration file, this method can't be used to create an AdoHelper instance.", e)
    '    End Try

    '    Dim providerConfig As providerAlias = DirectCast(dict(providerAlias), providerAlias)
    '    Dim providerAssembly As String = providerConfig.AssemblyName
    '    Dim providerType As String = providerConfig.TypeName

    '    Dim [assembly] As [assembly] = [assembly].Load(providerAssembly)
    '    Dim provider As Object = [assembly].CreateInstance(providerType)
    '    If TypeOf provider Is AdoHelper Then
    '        Return DirectCast(provider, AdoHelper)
    '    Else
    '        Throw New InvalidOperationException("The provider specified does not extend the AdoHelper abstract class.")
    '    End If
    'End Function 'CreateHelper

#End Region

#Region "GetParameter"
    ''' <summary>
    ''' Get an IDataParameter for use in a SQL command
    ''' </summary>
    ''' <param name="name">The name of the parameter to create</param>
    ''' <param name="value">The value of the specified parameter</param>
    ''' <returns>An IDataParameter object</returns>
    Public Overridable Overloads Function GetParameter(ByVal name As String, ByVal value As Object) As IDataParameter
        Dim parameter As IDataParameter = GetParameter()
        parameter.ParameterName = name
        parameter.Value = value
        Return parameter
    End Function 'GetParameter


    ''' <summary>
    ''' Get an IDataParameter for use in a SQL command
    ''' </summary>
    ''' <param name="name">The name of the parameter to create</param>
    ''' <param name="value">The value of the specified parameter</param>
    ''' <param name="dbType">The System.Data.DbType of the parameter</param>
    ''' <returns>An IDataParameter object</returns>
    Public Overridable Overloads Function GetParameter(ByVal name As String, ByVal value As Object, ByVal dbType As DbType) As IDataParameter
        Dim parameter As IDataParameter = GetParameter()
        parameter.ParameterName = name
        parameter.Value = value
        parameter.DbType = dbType
        Return parameter
    End Function 'GetParameter


    ''' <summary>
    ''' Get an IDataParameter for use in a SQL command
    ''' </summary>
    ''' <param name="name">The name of the parameter to create</param>
    ''' <param name="value">The value of the specified parameter</param>
    ''' <param name="dbType">The System.Data.DbType of the parameter</param>
    ''' <param name="size">The size of the parameter</param>
    ''' <returns>An IDataParameter object</returns>
    Public Overridable Overloads Function GetParameter(ByVal name As String, ByVal value As Object, ByVal dbType As DbType, ByVal size As Integer) As IDataParameter
        Dim parameter As IDataParameter = GetParameter()
        parameter.ParameterName = name
        parameter.Value = value
        parameter.DbType = dbType
        If size > 0 AndAlso TypeOf parameter Is IDbDataParameter Then
            Dim dbDataParameter As IDbDataParameter = DirectCast(parameter, IDbDataParameter)
            dbDataParameter.Size = size
        End If
        Return parameter
    End Function 'GetParameter


    ''' <summary>
    ''' Get an IDataParameter for use in a SQL command
    ''' </summary>
    ''' <param name="name">The name of the parameter to create</param>
    ''' <param name="dbType">The System.Data.DbType of the parameter</param>
    ''' <param name="size">The size of the parameter</param>
    ''' <param name="direction">The System.Data.ParameterDirection of the parameter</param>
    ''' <returns>An IDataParameter object</returns>
    Public Overridable Overloads Function GetParameter(ByVal name As String, ByVal dbType As DbType, ByVal size As Integer, ByVal direction As ParameterDirection) As IDataParameter
        Dim dataParameter As IDataParameter = GetParameter()
        dataParameter.DbType = dbType
        dataParameter.Direction = direction
        dataParameter.ParameterName = name

        If size > 0 AndAlso TypeOf dataParameter Is IDbDataParameter Then
            Dim dbDataParameter As IDbDataParameter = DirectCast(dataParameter, IDbDataParameter)
            dbDataParameter.Size = size
        End If
        Return dataParameter
    End Function 'GetParameter

    ''' <summary>
    ''' Get an IDataParameter for use in a SQL command
    ''' </summary>
    ''' <param name="name">The name of the parameter to create</param>
    ''' <param name="dbType">The System.Data.DbType of the parameter</param>
    ''' <param name="size">The size of the parameter</param>
    ''' <param name="sourceColumn">The source column of the parameter</param>
    ''' <param name="sourceVersion">The System.Data.DataRowVersion of the parameter</param>
    ''' <returns>An IDataParameter object</returns>
    Public Overridable Overloads Function GetParameter(ByVal name As String, ByVal dbType As DbType, ByVal size As Integer, ByVal sourceColumn As String, ByVal sourceVersion As DataRowVersion) As IDataParameter
        Dim dataParameter As IDataParameter = GetParameter()
        dataParameter.DbType = dbType
        dataParameter.ParameterName = name
        dataParameter.SourceColumn = sourceColumn
        dataParameter.SourceVersion = sourceVersion

        If size > 0 AndAlso TypeOf dataParameter Is IDbDataParameter Then
            Dim dbDataParameter As IDbDataParameter = DirectCast(dataParameter, IDbDataParameter)
            dbDataParameter.Size = size
        End If
        Return dataParameter
    End Function 'GetParameter
#End Region

#Region " Private Utility Methods "

    ''' <summary>
    ''' This method is used to attach array of IDataParameters to an IDbCommand.
    '''
    ''' This method will assign a value of DbNull to any parameter with a direction of
    ''' InputOutput and a value of null.
    '''
    ''' This behavior will prevent default values from being used, but
    ''' this will be the less common case than an intended pure output parameter (derived as InputOutput)
    ''' where the user provided no input value.
    ''' </summary>
    ''' <param name="command">The command to which the parameters will be added</param>
    ''' <param name="commandParameters">An array of IDataParameterParameters to be added to command</param>
    ''' <exception cref="System.ArgumentNullException">Thrown if command is null.</exception>
    Protected Overridable Sub AttachParameters(ByVal command As IDbCommand, ByVal commandParameters() As IDataParameter)
        If command Is Nothing Then
            Throw New ArgumentNullException("command")
        End If
        If Not (commandParameters Is Nothing) Then
            Dim p As IDataParameter
            For Each p In commandParameters
                If Not (p Is Nothing) Then
                    ' Check for derived output value with no value assigned
                    If (p.Direction = ParameterDirection.InputOutput OrElse p.Direction = ParameterDirection.Input) AndAlso p.Value Is Nothing Then
                        p.Value = DBNull.Value
                    End If

                    ' handle null values for datetime types
                    If (p.DbType = DbType.DateTime) OrElse (p.DbType = DbType.Date) Then
                        If (CType(p.Value, DateTime) = DateTime.MinValue) Then
                            p.Value = DBNull.Value
                        End If
                    End If

                    If (p.DbType = DbType.Binary) Then
                        ' special handling for BLOBs
                        command.Parameters.Add(GetBlobParameter(command.Connection, p))
                    Else
                        command.Parameters.Add(p)
                    End If
                End If
            Next p
        End If
    End Sub 'AttachParameters

    ''' <summary>
    ''' This method assigns dataRow column values to an IDataParameterCollection
    ''' </summary>
    ''' <param name="commandParameters">The IDataParameterCollection to be assigned values</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values</param>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the parameter names are invalid.</exception>
    Protected Friend Overloads Sub AssignParameterValues(ByVal commandParameters As IDataParameterCollection, ByVal dataRow As DataRow)
        If commandParameters Is Nothing OrElse dataRow Is Nothing Then
            ' Do nothing if we get no data
            Return
        End If

        Dim columns As DataColumnCollection = dataRow.Table.Columns

        Dim i As Integer = 0
        ' Set the parameters values
        Dim commandParameter As IDataParameter
        For Each commandParameter In commandParameters
            ' Check the parameter name
            If commandParameter.ParameterName Is Nothing OrElse commandParameter.ParameterName.Length <= 1 Then
                Throw New ArgumentException(String.Format("Please provide a valid parameter name on the parameter #{0}, the ParameterName property has the following value: '{1}'.", i, commandParameter.ParameterName))
            End If

            If columns.Contains(commandParameter.ParameterName) Then
                commandParameter.Value = dataRow(commandParameter.ParameterName)
            Else
                If columns.Contains(commandParameter.ParameterName.Substring(1)) Then
                    commandParameter.Value = dataRow(commandParameter.ParameterName.Substring(1))
                End If
            End If
            i += 1
        Next commandParameter
    End Sub 'AssignParameterValues

    ''' <summary>
    ''' This method assigns dataRow column values to an array of IDataParameters
    ''' </summary>
    ''' <param name="commandParameters">Array of IDataParameters to be assigned values</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values</param>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the parameter names are invalid.</exception>
    Protected Overloads Sub AssignParameterValues(ByVal commandParameters() As IDataParameter, ByVal dataRow As DataRow)
        If commandParameters Is Nothing OrElse dataRow Is Nothing Then
            ' Do nothing if we get no data
            Return
        End If

        Dim columns As DataColumnCollection = dataRow.Table.Columns

        Dim i As Integer = 0
        ' Set the parameters values
        Dim commandParameter As IDataParameter
        For Each commandParameter In commandParameters
            ' Check the parameter name
            If commandParameter.ParameterName Is Nothing OrElse commandParameter.ParameterName.Length <= 1 Then
                Throw New InvalidOperationException(String.Format("Please provide a valid parameter name on the parameter #{0}, the ParameterName property has the following value: '{1}'.", i, commandParameter.ParameterName))
            End If

            If columns.Contains(commandParameter.ParameterName) Then
                commandParameter.Value = dataRow(commandParameter.ParameterName)
            Else
                If columns.Contains(commandParameter.ParameterName.Substring(1)) Then
                    commandParameter.Value = dataRow(commandParameter.ParameterName.Substring(1))
                End If
            End If
            i += 1
        Next commandParameter
    End Sub 'AssignParameterValues

    ''' <summary>
    ''' This method assigns an array of values to an array of IDataParameters
    ''' </summary>
    ''' <param name="commandParameters">Array of IDataParameters to be assigned values</param>
    ''' <param name="parameterValues">Array of objects holding the values to be assigned</param>
    ''' <exception cref="System.ArgumentException">Thrown if an incorrect number of parameters are passed.</exception>
    Protected Overloads Sub AssignParameterValues(ByVal commandParameters() As IDataParameter, ByVal parameterValues() As Object)
        If commandParameters Is Nothing OrElse parameterValues Is Nothing Then
            ' Do nothing if we get no data
            Return
        End If

        ' We must have the same number of values as we pave parameters to put them in
        If commandParameters.Length <> parameterValues.Length Then
            Throw New ArgumentException("Parameter count does not match Parameter Value count.")
        End If

        ' Iterate through the IDataParameters, assigning the values from the corresponding position in the 
        ' value array
        Dim i As Integer = 0
        Dim j As Integer = commandParameters.Length
        Dim k As Integer = 0
        For i = 0 To j - 1
            If commandParameters(i).Direction <> ParameterDirection.ReturnValue Then
                ' If the current array value derives from IDataParameter, then assign its Value property
                If TypeOf parameterValues(k) Is IDataParameter Then
                    Dim paramInstance As IDataParameter = DirectCast(parameterValues(k), IDataParameter)
                    If paramInstance.Value Is Nothing Then
                        commandParameters(i).Value = DBNull.Value
                    Else
                        commandParameters(i).Value = paramInstance.Value
                    End If
                Else
                    If parameterValues(k) Is Nothing Then
                        commandParameters(i).Value = DBNull.Value
                    Else
                        commandParameters(i).Value = parameterValues(k)
                    End If
                End If
                k += 1
            End If
        Next i
    End Sub 'AssignParameterValues

    ''' <summary>
    ''' This method cleans up the parameter syntax for the provider
    ''' </summary>
    ''' <param name="command">The IDbCommand containing the parameters to clean up.</param>
    Public Overridable Sub CleanParameterSyntax(ByVal command As IDbCommand)
        ' do nothing by default
    End Sub 'CleanParameterSyntax

    ''' <summary>
    ''' This method opens (if necessary) and assigns a connection, transaction, command type and parameters
    ''' to the provided command
    ''' </summary>
    ''' <param name="command">The IDbCommand to be prepared</param>
    ''' <param name="connection">A valid IDbConnection, on which to execute this command</param>
    ''' <param name="transaction">A valid IDbTransaction, or 'null'</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters to be associated with the command or 'null' if no parameters are required</param>
    ''' <param name="mustCloseConnection"><c>true</c> if the connection was opened by the method, otherwose is false.</param>
    ''' <exception cref="System.ArgumentNullException">Thrown if command or commandText is null.</exception>
    Protected Overridable Sub PrepareCommand(ByVal command As IDbCommand, ByVal connection As IDbConnection, ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal commandParameters() As IDataParameter, ByRef mustCloseConnection As Boolean)
        If command Is Nothing Then
            Throw New ArgumentNullException("command")
        End If
        If commandText Is Nothing OrElse commandText.Length = 0 Then
            Throw New ArgumentNullException("commandText")
        End If
        ' If the provided connection is not open, we will open it
        If connection.State <> ConnectionState.Open Then
            mustCloseConnection = True
            connection.Open()
        Else
            mustCloseConnection = False
        End If

        ' Associate the connection with the command
        command.Connection = connection

        ' Set the command text (stored procedure name or SQL statement)
        command.CommandText = commandText

        ' If we were provided a transaction, assign it
        If Not (transaction Is Nothing) Then
            If transaction.Connection Is Nothing Then
                Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
            End If
            command.Transaction = transaction
        End If

        ' Set the command type
        command.CommandType = commandType

        ' Attach the command parameters if they are provided
        If Not (commandParameters Is Nothing) Then
            AttachParameters(command, commandParameters)
        End If
        Return
    End Sub 'PrepareCommand

    ''' <summary>
    ''' This method clears (if necessary) the connection, transaction, command type and parameters
    ''' from the provided command
    ''' </summary>
    ''' <remarks>
    ''' Not implemented here because the behavior of this method differs on each data provider.
    ''' </remarks>
    ''' <param name="command">The IDbCommand to be cleared</param>
    Protected Overridable Sub ClearCommand(ByVal command As IDbCommand)
        ' do nothing by default
    End Sub 'ClearCommand

#End Region

#Region "ExecuteDataset"
    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string.
    ''' </summary>
    ''' <param name="command">The IDbCommand object to use</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if command is null.</exception>
    Public Overridable Overloads Function ExecuteDataset(ByVal command As IDbCommand) As DataSet
        Dim mustCloseConnection As Boolean = False

        ' Clean Up Parameter Syntax
        CleanParameterSyntax(command)

        If command.Connection.State <> ConnectionState.Open Then
            command.Connection.Open()
            mustCloseConnection = True
        End If

        ' Create the DataAdapter & DataSet
        Dim da As IDbDataAdapter = Nothing
        Try
            da = GetDataAdapter()
            da.SelectCommand = command

            Dim ds As New DataSet

            Try

                ' Fill the DataSet using default values for DataTable names, etc
                da.Fill(ds)
            Catch ex As Exception
                ' Don't just throw ex.  It changes the call stack.  But we want the ex around for debugging, so...
                Debug.WriteLine(ex)
                Throw
            End Try

            ' Detach the IDataParameters from the command object, so they can be used again
            ' Don't do this...screws up output params -- cjb 
            'command.Parameters.Clear();
            ' Return the dataset
            Return ds
        Finally
            If mustCloseConnection Then
                command.Connection.Close()
            End If
            If Not (da Is Nothing) Then
                Dim id As IDisposable = DirectCast(da, IDisposable)
                If Not (id Is Nothing) Then
                    id.Dispose()
                End If
            End If
        End Try
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the database specified in
    ''' the connection string.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' DataSet ds = helper.ExecuteDataset(connString, CommandType.StoredProcedure, "GetOrders");
    ''' </code></example>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    Public Overridable Overloads Function ExecuteDataset(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String) As DataSet
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteDataset(connectionString, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the database specified in
    ''' the connection string.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' DataSet ds = helper.ExecuteDataset(connString, CommandType.StoredProcedure, "GetOrders");
    ''' </code></example>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    Public Overridable Overloads Function ExecuteDataset(ByVal commandType As CommandType, ByVal commandText As String) As DataSet
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteDataset(moProvider.ConnectionString, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute a SQL query (that returns a resultset and takes no parameters).
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' DataSet ds = helper.ExecuteDataset("SELECT * FROM Orders");
    ''' </code></example>
    ''' <param name="commandText">The SQL query (*NOT* a stored procedure name or table name)</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    Public Overridable Overloads Function ExecuteDataset(ByVal commandText As String) As DataSet
        Return ExecuteDataset(CommandType.Text, commandText)
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the database specified in the connection string
    ''' using the provided parameters.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' DataSet ds = helper.ExecuteDataset(connString, CommandType.StoredProcedure, "GetOrders", new IDbParameter("@prodid", 24));
    ''' </code></example>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDbParamters used to execute the command</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteDataset(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As DataSet
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        ' Create & open a IDbConnection, and dispose of it after we are done
        Dim connection As IDbConnection = GetConnection(connectionString)
        Try
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            Return ExecuteDataset(connection, commandType, commandText, commandParameters)
        Finally
            connection.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the database specified in the connection string
    ''' using the provided parameters.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' DataSet ds = helper.ExecuteDataset(CommandType.StoredProcedure, "GetOrders", new IDbParameter("@prodid", 24));
    ''' </code></example>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDbParamters used to execute the command</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteDataset(ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As DataSet
        ' Create & open a IDbConnection, and dispose of it after we are done
        Dim connection As IDbConnection = GetConnection(moProvider.ConnectionString)
        Try
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            Return ExecuteDataset(connection, commandType, commandText, commandParameters)
        Finally
            connection.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' DataSet ds = helper.ExecuteDataset(connString, "GetOrders", 24, 36);
    ''' </code>
    ''' </example>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    Public Overridable Overloads Function ExecuteDataset(ByVal connectionString As String, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As DataSet
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else
                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(connectionString, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDataParameters
                Return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' DataSet ds = helper.ExecuteDataset("GetOrders", 24, 36);
    ''' </code>
    ''' </example>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    Public Overridable Overloads Function ExecuteDataset(ByVal spName As String, ByVal ParamArray parameterValues() As Object) As DataSet
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteDataset(moProvider.ConnectionString, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else
                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(moProvider.ConnectionString, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDataParameters
                Return ExecuteDataset(moProvider.ConnectionString, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteDataset(moProvider.ConnectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the provided IDbConnection.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' DataSet ds = helper.ExecuteDataset(conn, CommandType.StoredProcedure, "GetOrders");
    ''' </code>
    ''' </example>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or connection is null</exception>
    Public Overridable Overloads Function ExecuteDataset(ByVal connection As IDbConnection, ByVal commandType As CommandType, ByVal commandText As String) As DataSet
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteDataset(connection, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the specified IDbConnection
    ''' using the provided parameters.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' DataSet ds = helper.ExecuteDataset(conn, CommandType.StoredProcedure, "GetOrders", new IDataParameter("@prodid", 24));
    ''' </code>
    ''' </example>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteDataset(ByVal connection As IDbConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As DataSet
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        ' Create a command and prepare it for execution
        Dim cmd As IDbCommand = connection.CreateCommand()
        Dim mustCloseConnection As Boolean = False
        PrepareCommand(cmd, connection, DirectCast(Nothing, IDbTransaction), commandType, commandText, commandParameters, mustCloseConnection)
        CleanParameterSyntax(cmd)

        Dim ds As DataSet = ExecuteDataset(cmd)

        If mustCloseConnection Then
            connection.Close()
        End If
        cmd.Dispose()

        ' Return the dataset
        Return ds
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified IDbConnection
    ''' using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' DataSet ds = helper.ExecuteDataset(conn, "GetOrders", 24, 36);
    ''' </code></example>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteDataset(ByVal connection As IDbConnection, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As DataSet
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteDataset(connection, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else
                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(connection, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDataParameters
                Return ExecuteDataset(connection, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteDataset(connection, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the provided IDbTransaction.
    ''' </summary>
    ''' <example><code>
    ''' DataSet ds = helper.ExecuteDataset(trans, CommandType.StoredProcedure, "GetOrders");
    ''' </code></example>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or transaction or transaction.Connection is null</exception>
    Public Overridable Overloads Function ExecuteDataset(ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String) As DataSet
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteDataset(transaction, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the specified IDbTransaction
    ''' using the provided parameters.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' DataSet ds = helper.ExecuteDataset(trans, CommandType.StoredProcedure, "GetOrders", new IDataParameter("@prodid", 24));
    ''' </code></example>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or transaction or transaction.Connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteDataset(ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As DataSet
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        ' Create a command and prepare it for execution
        Dim cmd As IDbCommand = transaction.Connection.CreateCommand()
        Dim mustCloseConnection As Boolean = False
        PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)
        CleanParameterSyntax(cmd)

        Dim returnDataset As DataSet
        returnDataset = ExecuteDataset(cmd)
        cmd.Dispose()

        Return returnDataset

    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified
    ''' IDbTransaction using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' DataSet ds = helper.ExecuteDataset(tran, "GetOrders", 24, 36);
    ''' </code></example>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or transaction or transaction.Connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteDataset(ByVal transaction As IDbTransaction, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As DataSet
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteDataset(transaction, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else

                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(transaction.Connection, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDataParameters
                Return ExecuteDataset(transaction, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteDataset(transaction, CommandType.StoredProcedure, spName)
        End If
    End Function

#End Region

#Region "ExecuteNonQuery"

    ''' <summary>
    ''' Execute an IDbCommand (that returns no resultset) against the database
    ''' </summary>
    ''' <param name="command">The IDbCommand to execute</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if command is null.</exception>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal command As IDbCommand) As Integer
        Dim mustCloseConnection As Boolean = False

        ' Clean Up Parameter Syntax
        CleanParameterSyntax(command)

        If command.Connection.State <> ConnectionState.Open Then
            command.Connection.Open()
            mustCloseConnection = True
        End If

        If command Is Nothing Then
            Throw New ArgumentNullException("command")
        End If
        Dim returnVal As Integer

        'If (IsAllSqlLoggingEnabled) Then
        '    WriteToAllSqlLog(command)
        'End If

        Try
            returnVal = command.ExecuteNonQuery()

        Catch ex As Exception
            'WriteToDbErrorLog(command, ex)
            ' Don't throw "ex" --  It changes the call stack; Just use "Throw" by itself
            Throw

        Finally
            If mustCloseConnection Then
                command.Connection.Close()
            End If
        End Try

        Return returnVal
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns no resultset and takes no parameters) against the database specified in
    ''' the connection string
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String) As Integer
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteNonQuery(connectionString, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns no resultset and takes no parameters) against the database specified in
    ''' the connection string
    ''' </summary>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal commandType As CommandType, ByVal commandText As String) As Integer
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteNonQuery(moProvider.ConnectionString, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute a SQL query (that returns no resultset and takes no parameters).
    ''' </summary>
    ''' <param name="commandText">The SQL query (*NOT* a stored procedure name or table name)</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal commandText As String) As Integer
        Return ExecuteNonQuery(CommandType.Text, commandText)
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns no resultset) against the database specified in the connection string
    ''' using the provided parameters
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As Integer
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        ' Create & open a IDbConnection, and dispose of it after we are done
        Dim connection As IDbConnection = GetConnection(connectionString)
        Try
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            Return ExecuteNonQuery(connection, commandType, commandText, commandParameters)
        Finally
            connection.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns no resultset) against the database specified in the connection string
    ''' using the provided parameters
    ''' </summary>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As Integer
        ' Create & open a IDbConnection, and dispose of it after we are done
        Dim connection As IDbConnection = GetConnection(moProvider.ConnectionString)
        Try
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            Return ExecuteNonQuery(connection, commandType, commandText, commandParameters)
        Finally
            connection.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns no resultset) against the database specified in
    ''' the connection string using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    '''
    ''' </remarks>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="spName">The name of the stored prcedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal connectionString As String, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As Integer
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else
                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(connectionString, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDataParameters
                Return ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns no resultset) against the database specified in
    ''' the connection string using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    '''
    ''' </remarks>
    ''' <param name="spName">The name of the stored prcedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal spName As String, ByVal ParamArray parameterValues() As Object) As Integer
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteNonQuery(moProvider.ConnectionString, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else
                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(moProvider.ConnectionString, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDataParameters
                Return ExecuteNonQuery(moProvider.ConnectionString, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteNonQuery(moProvider.ConnectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns no resultset and takes no parameters) against the provided IDbConnection.
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or connection is null</exception>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal connection As IDbConnection, ByVal commandType As CommandType, ByVal commandText As String) As Integer
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteNonQuery(connection, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns no resultset) against the specified IDbConnection
    ''' using the provided parameters.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDbParamters used to execute the command</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal connection As IDbConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As Integer
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        ' Create a command and prepare it for execution
        Dim cmd As IDbCommand = connection.CreateCommand()
        Dim mustCloseConnection As Boolean = False
        PrepareCommand(cmd, connection, DirectCast(Nothing, IDbTransaction), commandType, commandText, commandParameters, mustCloseConnection)
        CleanParameterSyntax(cmd)

        ' Finally, execute the command
        Dim retval As Integer = ExecuteNonQuery(cmd)

        ' Detach the IDataParameters from the command object, so they can be used again
        ' don't do this...screws up output parameters -- cjbreisch
        ' cmd.Parameters.Clear();
        If mustCloseConnection Then
            connection.Close()
        End If
        cmd.Dispose()

        Return retval
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns no resultset) against the specified IDbConnection
    ''' using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    '''
    ''' </remarks>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal connection As IDbConnection, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As Integer
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteNonQuery(connection, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else

                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(connection, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDataParameters
                Return ExecuteNonQuery(connection, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteNonQuery(connection, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns no resultset and takes no parameters) against the provided IDbTransaction.
    ''' </summary>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or transaction or transaction.Connection is null</exception>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String) As Integer
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteNonQuery(transaction, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns no resultset) against the specified IDbTransaction
    ''' using the provided parameters.
    ''' </summary>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or transaction or transaction.Connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As Integer
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        ' Create a command and prepare it for execution
        Dim cmd As IDbCommand = transaction.Connection.CreateCommand()
        Dim mustCloseConnection As Boolean = False
        PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)
        CleanParameterSyntax(cmd)

        ' Finally, execute the command
        Dim retval As Integer = ExecuteNonQuery(cmd)

        ' Detach the IDataParameters from the command object, so they can be used again
        ' don't do this...screws up output parameters -- cjbreisch
        ' cmd.Parameters.Clear();

        cmd.Dispose()

        Return retval

    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns no resultset) against the specified
    ''' IDbTransaction using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or transaction or transaction.Connection is null</exception>
    Public Overridable Overloads Function ExecuteNonQuery(ByVal transaction As IDbTransaction, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As Integer
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else

                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(transaction.Connection, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDbParameters
                Return ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName)
        End If
    End Function

#End Region

#Region "ExecuteReader"

    '*** NOTE:  SafeDataReader is used instead of IDataReader for all ExecuteReader overrides!!!

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string.
    ''' </summary>
    ''' <param name="command">The IDbCommand object to use</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if command is null.</exception>
    Public Overridable Overloads Function ExecuteReader(ByVal command As IDbCommand) As SafeDataReader
        Return ExecuteReader(command, AdoConnectionOwnership.External)
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string.
    ''' </summary>
    ''' <param name="command">The IDbCommand object to use</param>
    ''' <param name="connectionOwnership">Enum indicating whether the connection was created internally or externally.</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if command is null.</exception>
    Protected Overridable Overloads Function ExecuteReader(ByVal command As IDbCommand, ByVal connectionOwnership As AdoConnectionOwnership) As SafeDataReader
        ' Clean Up Parameter Syntax
        CleanParameterSyntax(command)

        If command.Connection.State <> ConnectionState.Open Then
            command.Connection.Open()
            connectionOwnership = AdoConnectionOwnership.Internal
        End If

        'If (IsAllSqlLoggingEnabled) Then
        '    WriteToAllSqlLog(command)
        'End If

        ' Create a reader
        Dim dataReader As IDataReader

        ' Call ExecuteReader with the appropriate CommandBehavior
        If connectionOwnership = AdoConnectionOwnership.External Then
            Try
                dataReader = command.ExecuteReader()

            Catch ex As Exception
                'WriteToDbErrorLog(command, ex)
                ' Don't throw "ex" --  It changes the call stack; Just use "Throw" by itself
                Throw

            Finally
                ClearCommand(command)
            End Try

        Else
            Try
                dataReader = command.ExecuteReader(CommandBehavior.CloseConnection)

            Catch ex As Exception
                'WriteToDbErrorLog(command, ex)
                ' Don't throw "ex" --  It changes the call stack; Just use "Throw" by itself
                Throw

            Finally
                ClearCommand(command)
            End Try
        End If

        Return New SafeDataReader(dataReader)

    End Function

    ''' <summary>
    ''' Create and prepare an IDbCommand, and call ExecuteReader with the appropriate CommandBehavior.
    ''' </summary>
    ''' <remarks>
    ''' If we created and opened the connection, we want the connection to be closed when the DataReader is closed.
    '''
    ''' If the caller provided the connection, we want to leave it to them to manage.
    ''' </remarks>
    ''' <param name="connection">A valid IDbConnection, on which to execute this command</param>
    ''' <param name="transaction">A valid IDbTransaction, or 'null'</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters to be associated with the command or 'null' if no parameters are required</param>
    ''' <param name="connectionOwnership">Indicates whether the connection parameter was provided by the caller, or created by AdoHelper</param>
    ''' <returns>IDataReader containing the results of the command</returns>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Private Overloads Function ExecuteReader(ByVal connection As IDbConnection, ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal commandParameters() As IDataParameter, ByVal connectionOwnership As AdoConnectionOwnership) As SafeDataReader
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        Dim mustCloseConnection As Boolean = False
        ' Create a command and prepare it for execution
        Dim cmd As IDbCommand = connection.CreateCommand()

        PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)
        CleanParameterSyntax(cmd)

        ' override conenctionOwnership if we created the connection in PrepareCommand -- cjbreisch
        If mustCloseConnection Then
            connectionOwnership = AdoConnectionOwnership.Internal
        End If

        ' Create a reader
        Dim dataReader As IDataReader

        dataReader = ExecuteReader(cmd, connectionOwnership)

        ClearCommand(cmd)
        cmd.Dispose()

        Return CType(dataReader, SafeDataReader)

    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the database specified in
    ''' the connection string.
    ''' </summary>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    Public Overridable Overloads Function ExecuteReader(ByVal sConnectionString As String, ByVal commandType As CommandType, ByVal commandText As String) As SafeDataReader
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteReader(sConnectionString, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the database specified in
    ''' the connection string.
    ''' </summary>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    Public Overridable Overloads Function ExecuteReader(ByVal commandType As CommandType, ByVal commandText As String) As SafeDataReader
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteReader(moProvider.ConnectionString, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute a SQL query (that returns a resultset and takes no parameters).
    ''' </summary>
    ''' <param name="commandText">The SQL query (*NOT* a stored procedure name or table name)</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    Public Overridable Overloads Function ExecuteReader(ByVal commandText As String) As SafeDataReader
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteReader(CommandType.Text, commandText)
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the database specified in the connection string
    ''' using the provided parameters.
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteReader(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As SafeDataReader
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        Dim connection As IDbConnection = Nothing
        Try
            connection = GetConnection(connectionString)
            connection.Open()

            ' Call the private overload that takes an internally owned connection in place of the connection string
            Return ExecuteReader(connection, DirectCast(Nothing, IDbTransaction), commandType, commandText, commandParameters, AdoConnectionOwnership.Internal)
        Catch
            ' If we fail to return the IDataReader, we need to close the connection ourselves
            If Not connection Is Nothing Then connection.Close()
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the database specified in the connection string
    ''' using the provided parameters.
    ''' </summary>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteReader(ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As SafeDataReader

        Return ExecuteReader(moProvider.ConnectionString, commandType, commandText, commandParameters)

    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' IDataReader dr = helper.ExecuteReader(connString, "GetOrders", 24, 36);
    ''' </code></example>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>an IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteReader(ByVal connectionString As String, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As SafeDataReader
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteReader(connectionString, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else

                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(connectionString, spName, includeReturnValue)

                AssignParameterValues(commandParameters, parameterValues)

                Return ExecuteReader(connectionString, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteReader(connectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' IDataReader dr = helper.ExecuteReader("GetOrders", 24, 36);
    ''' </code></example>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>an IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteReader(ByVal spName As String, ByVal ParamArray parameterValues() As Object) As SafeDataReader
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteReader(moProvider.ConnectionString, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else

                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(moProvider.ConnectionString, spName, includeReturnValue)

                AssignParameterValues(commandParameters, parameterValues)

                Return ExecuteReader(moProvider.ConnectionString, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteReader(moProvider.ConnectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the provided IDbConnection.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' IDataReader dr = helper.ExecuteReader(conn, CommandType.StoredProcedure, "GetOrders");
    ''' </code></example>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>an IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText is null</exception>
    Public Overridable Overloads Function ExecuteReader(ByVal connection As IDbConnection, ByVal commandType As CommandType, ByVal commandText As String) As SafeDataReader
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteReader(connection, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the specified IDbConnection
    ''' using the provided parameters.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' IDataReader dr = helper.ExecuteReader(conn, CommandType.StoredProcedure, "GetOrders", new IDataParameter("@prodid", 24));
    ''' </code></example>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>an IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteReader(ByVal connection As IDbConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As SafeDataReader
        ' Pass through the call to the private overload using a null transaction value and an externally owned connection
        Return ExecuteReader(connection, DirectCast(Nothing, IDbTransaction), commandType, commandText, commandParameters, AdoConnectionOwnership.External)
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified IDbConnection
    ''' using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' IDataReader dr = helper.ExecuteReader(conn, "GetOrders", 24, 36);
    ''' </code></example>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>an IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteReader(ByVal connection As IDbConnection, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As SafeDataReader
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteReader(connection, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else

                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(connection, spName, includeReturnValue)

                AssignParameterValues(commandParameters, parameterValues)

                Return ExecuteReader(connection, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteReader(connection, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the provided IDbTransaction.
    ''' </summary>
    ''' <example><code>
    ''' IDataReader dr = helper.ExecuteReader(trans, CommandType.StoredProcedure, "GetOrders");
    ''' </code></example>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText is null</exception>
    Public Overridable Overloads Function ExecuteReader(ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String) As SafeDataReader
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteReader(transaction, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the specified IDbTransaction
    ''' using the provided parameters.
    ''' </summary>
    ''' <remarks>
    ''' e.g.:
    ''' IDataReader dr = ExecuteReader(trans, CommandType.StoredProcedure, "GetOrders", new IDataParameter("@prodid", 24));
    ''' </remarks>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    Public Overridable Overloads Function ExecuteReader(ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As SafeDataReader
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        ' Pass through to private overload, indicating that the connection is owned by the caller
        Return ExecuteReader(transaction.Connection, transaction, commandType, commandText, commandParameters, AdoConnectionOwnership.External)
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified
    ''' IDbTransaction using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' IDataReader dr = helper.ExecuteReader(tran, "GetOrders", 24, 36);
    ''' </code></example>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>an IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or transaction or transaction.Connection is null</exception>
    Public Overridable Overloads Function ExecuteReader(ByVal transaction As IDbTransaction, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As SafeDataReader
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("An open (not rolled back or committed) transaction is required.", "transaction")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteReader(transaction, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else

                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(transaction.Connection, spName, includeReturnValue)

                AssignParameterValues(commandParameters, parameterValues)

                Return ExecuteReader(transaction, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteReader(transaction, CommandType.StoredProcedure, spName)
        End If
    End Function
#End Region

#Region "ExecuteScalar"

    ''' <summary>
    ''' Execute an IDbCommand (that returns a 1x1 resultset) against the database specified in
    ''' the connection string.
    ''' </summary>
    ''' <param name="command">The IDbCommand to execute</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if command is null.</exception>
    Public Overridable Overloads Function ExecuteScalar(ByVal command As IDbCommand) As Object
        Dim mustCloseConnection As Boolean = False
        Dim retval As Object

        ' Clean Up Parameter Syntax
        CleanParameterSyntax(command)

        If command.Connection.State <> ConnectionState.Open Then
            command.Connection.Open()
            mustCloseConnection = True
        End If

        'If (IsAllSqlLoggingEnabled) Then
        '    WriteToAllSqlLog(command)
        'End If

        Try
            ' Execute the command & return the results
            retval = command.ExecuteScalar()

        Catch ex As Exception
            'WriteToDbErrorLog(command, ex)
            ' Don't throw "ex" --  It changes the call stack; Just use "Throw" by itself
            Throw

        Finally
            ' Detach the IDataParameters from the command object, so they can be used again
            ' don't do this...screws up output params -- cjbreisch
            ' command.Parameters.Clear();
            If mustCloseConnection Then
                command.Connection.Close()
            End If
        End Try

        Return retval
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a 1x1 resultset and takes no parameters) against the database specified in
    ''' the connection string.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' int orderCount = (int)helper.ExecuteScalar(connString, CommandType.StoredProcedure, "GetOrderCount");
    ''' </code></example>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    Public Overridable Overloads Function ExecuteScalar(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String) As Object
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteScalar(connectionString, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a 1x1 resultset and takes no parameters) against the database specified in
    ''' the connection string.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' int orderCount = (int)helper.ExecuteScalar(CommandType.StoredProcedure, "GetOrderCount");
    ''' </code></example>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText is null</exception>
    Public Overridable Overloads Function ExecuteScalar(ByVal commandType As CommandType, ByVal commandText As String) As Object
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteScalar(moProvider.ConnectionString, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute a SQL query (that returns a 1x1 resultset and takes no parameters).
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' int orderCount = (int)helper.ExecuteScalar("SELECT COUNT(*) FROM Orders");
    ''' </code></example>
    ''' <param name="commandText">The SQL query (*NOT* a stored procedure name or table name)</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    Public Overridable Overloads Function ExecuteScalar(ByVal commandText As String) As Object
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteScalar(CommandType.Text, commandText)
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a 1x1 resultset) against the database specified in the connection string
    ''' using the provided parameters.
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteScalar(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As Object
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If ' Create & open a IDbConnection, and dispose of it after we are done
        Dim connection As IDbConnection = Nothing
        Try
            connection = GetConnection(connectionString)
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            Return ExecuteScalar(connection, commandType, commandText, commandParameters)
        Finally
            Dim id As IDisposable = connection
            If Not (id Is Nothing) Then
                id.Dispose()
            End If
        End Try
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a 1x1 resultset) against the database specified in the connection string
    ''' using the provided parameters.
    ''' </summary>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteScalar(ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As Object
        ' Create & open a IDbConnection, and dispose of it after we are done
        Dim connection As IDbConnection = Nothing
        Try
            connection = GetConnection(moProvider.ConnectionString)
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            Return ExecuteScalar(connection, commandType, commandText, commandParameters)
        Finally
            Dim id As IDisposable = connection
            If Not (id Is Nothing) Then
                id.Dispose()
            End If
        End Try
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a 1x1 resultset) against the database specified in
    ''' the connection string using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' int orderCount = (int)helper.ExecuteScalar(connString, "GetOrderCount", 24, 36);
    ''' </code></example>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteScalar(ByVal connectionString As String, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As Object
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteScalar(connectionString, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else

                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(connectionString, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDataParameters
                Return ExecuteScalar(connectionString, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteScalar(connectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a 1x1 resultset) against the database specified in
    ''' the connection string using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' int orderCount = (int)helper.ExecuteScalar("GetOrderCount", 24, 36);
    ''' </code></example>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteScalar(ByVal spName As String, ByVal ParamArray parameterValues() As Object) As Object
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteScalar(moProvider.ConnectionString, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else

                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(moProvider.ConnectionString, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDataParameters
                Return ExecuteScalar(moProvider.ConnectionString, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteScalar(moProvider.ConnectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a 1x1 resultset and takes no parameters) against the provided IDbConnection.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' int orderCount = (int)helper.ExecuteScalar(conn, CommandType.StoredProcedure, "GetOrderCount");
    ''' </code></example>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText is null</exception>
    Public Overridable Overloads Function ExecuteScalar(ByVal connection As IDbConnection, ByVal commandType As CommandType, ByVal commandText As String) As Object
        ' Pass through the call providing null for the set of IDbParameters
        Return ExecuteScalar(connection, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a 1x1 resultset) against the specified IDbConnection
    ''' using the provided parameters.
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteScalar(ByVal connection As IDbConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As Object
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        ' Create a command and prepare it for execution
        Dim cmd As IDbCommand = connection.CreateCommand()

        Dim mustCloseConnection As Boolean = False
        PrepareCommand(cmd, connection, DirectCast(Nothing, IDbTransaction), commandType, commandText, commandParameters, mustCloseConnection)
        CleanParameterSyntax(cmd)

        ' Execute the command & return the results
        Dim retval As Object = ExecuteScalar(cmd)
        cmd.Dispose()

        ' Detach the IDataParameters from the command object, so they can be used again
        ' don't do this...screws up output parameters -- cjbreisch
        ' cmd.Parameters.Clear();
        If mustCloseConnection Then
            connection.Close()
        End If
        Return retval
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a 1x1 resultset) against the specified IDbConnection
    ''' using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' int orderCount = (int)helper.ExecuteScalar(conn, "GetOrderCount", 24, 36);
    ''' </code></example>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteScalar(ByVal connection As IDbConnection, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As Object
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteScalar(connection, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else

                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(connection, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDataParameters
                Return ExecuteScalar(connection, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteScalar(connection, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a 1x1 resultset and takes no parameters) against the provided IDbTransaction.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' int orderCount = (int)helper.ExecuteScalar(tran, CommandType.StoredProcedure, "GetOrderCount");
    ''' </code></example>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText is null</exception>
    Public Overridable Overloads Function ExecuteScalar(ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String) As Object
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteScalar(transaction, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function

    ''' <summary>
    ''' Execute an IDbCommand (that returns a 1x1 resultset) against the specified IDbTransaction
    ''' using the provided parameters.
    ''' </summary>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDbParamters used to execute the command</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or transaction or transaction.Connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function ExecuteScalar(ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As Object
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        ' Create a command and prepare it for execution
        Dim cmd As IDbCommand = transaction.Connection.CreateCommand()
        Dim mustCloseConnection As Boolean = False
        PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)
        CleanParameterSyntax(cmd)

        ' Execute the command & return the results
        Dim retval As Object = ExecuteScalar(cmd)
        cmd.Dispose()

        ' Detach the IDataParameters from the command object, so they can be used again
        ' don't do this...screws up output parameters -- cjbreisch
        ' cmd.Parameters.Clear();
        Return retval
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a 1x1 resultset) against the specified
    ''' IDbTransaction using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' int orderCount = (int)helper.ExecuteScalar(tran, "GetOrderCount", 24, 36);
    ''' </code></example>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or spName or transaction or transaction.Connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied -or- if the transaction is rolled back or commmitted</exception>
    Public Overridable Overloads Function ExecuteScalar(ByVal transaction As IDbTransaction, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As Object
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                Return ExecuteScalar(transaction, CommandType.StoredProcedure, spName, iDataParameterValues)
            Else
                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(transaction.Connection, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDataParameters
                Return ExecuteScalar(transaction, CommandType.StoredProcedure, spName, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteScalar(transaction, CommandType.StoredProcedure, spName)
        End If
    End Function

#End Region

#Region "ExecuteXmlReader"

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the provided IDbConnection.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' XmlReader r = helper.ExecuteXmlReader(conn, CommandType.StoredProcedure, "GetOrders");
    ''' </code></example>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command using "FOR XML AUTO"</param>
    ''' <returns>An XmlReader containing the resultset generated by the command</returns>
    Public Overloads Function ExecuteXmlReader(ByVal connection As IDbConnection, ByVal commandType As CommandType, ByVal commandText As String) As XmlReader
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteXmlReader(connection, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function 'ExecuteXmlReader

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the specified IDbConnection
    ''' using the provided parameters.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' XmlReader r = helper.ExecuteXmlReader(conn, CommandType.StoredProcedure, "GetOrders", GetParameter("@prodid", 24));
    ''' </code></example>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command using "FOR XML AUTO"</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>An XmlReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overloads Function ExecuteXmlReader(ByVal connection As IDbConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As XmlReader
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        Dim mustCloseConnection As Boolean = False
        ' Create a command and prepare it for execution
        Dim cmd As IDbCommand = connection.CreateCommand()
        Try
            PrepareCommand(cmd, connection, DirectCast(Nothing, IDbTransaction), commandType, commandText, commandParameters, mustCloseConnection)
            CleanParameterSyntax(cmd)

            Return ExecuteXmlReader(cmd)
        Catch ex As Exception
            If mustCloseConnection Then
                connection.Close()
            End If
            ' Don't just throw ex.  It changes the call stack.  But we want the ex around for debugging, so...
            Debug.WriteLine(ex)
            Throw
        End Try
    End Function 'ExecuteXmlReader

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified IDbConnection
    ''' using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' XmlReader r = helper.ExecuteXmlReader(conn, "GetOrders", 24, 36);
    ''' </code></example>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure using "FOR XML AUTO"</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>An XmlReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overloads Function ExecuteXmlReader(ByVal connection As IDbConnection, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As XmlReader
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim tempParameter As New ArrayList
            Dim parameter As IDataParameter
            For Each parameter In GetSpParameterSet(connection, spName)
                tempParameter.Add(parameter)
            Next parameter
            Dim commandParameters As IDataParameter() = DirectCast(tempParameter.ToArray(GetType(IDataParameter)), IDataParameter())

            ' Assign the provided values to these parameters based on parameter order
            AssignParameterValues(commandParameters, parameterValues)

            ' Call the overload that takes an array of IDataParameters
            Return ExecuteXmlReader(connection, CommandType.StoredProcedure, spName, commandParameters)
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteXmlReader(connection, CommandType.StoredProcedure, spName)
        End If
    End Function 'ExecuteXmlReader

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the provided IDbTransaction.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' XmlReader r = helper.ExecuteXmlReader(tran, CommandType.StoredProcedure, "GetOrders");
    ''' </code></example>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command using "FOR XML AUTO"</param>
    ''' <returns>An XmlReader containing the resultset generated by the command</returns>
    Public Overloads Function ExecuteXmlReader(ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String) As XmlReader
        ' Pass through the call providing null for the set of IDataParameters
        Return ExecuteXmlReader(transaction, commandType, commandText, DirectCast(Nothing, IDataParameter()))
    End Function 'ExecuteXmlReader

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the specified IDbTransaction
    ''' using the provided parameters.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' XmlReader r = helper.ExecuteXmlReader(tran, CommandType.StoredProcedure, "GetOrders", GetParameter("@prodid", 24));
    ''' </code></example>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command using "FOR XML AUTO"</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <returns>An XmlReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or transaction or transaction.Connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overloads Function ExecuteXmlReader(ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As XmlReader
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        ' Create a command and prepare it for execution
        Dim cmd As IDbCommand = transaction.Connection.CreateCommand()
        Dim mustCloseConnection As Boolean = False
        PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)
        CleanParameterSyntax(cmd)

        ' Create the DataAdapter & DataSet
        Dim retval As XmlReader = ExecuteXmlReader(cmd)

        ' Detach the IDataParameters from the command object, so they can be used again
        ' don't do this...screws up output params -- cjbreisch
        ' cmd.Parameters.Clear();
        Return retval
    End Function 'ExecuteXmlReader

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified
    ''' IDbTransaction using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' XmlReader r = helper.ExecuteXmlReader(trans, "GetOrders", 24, 36);
    ''' </code></example>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="spName">The name of the stored procedure using "FOR XML AUTO"</param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>An XmlReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or transaction or transaction.Connection is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overloads Function ExecuteXmlReader(ByVal transaction As IDbTransaction, ByVal spName As String, ByVal ParamArray parameterValues() As Object) As XmlReader
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim tempParameter As New ArrayList
            Dim parameter As IDataParameter
            For Each parameter In GetSpParameterSet(transaction.Connection, spName)
                tempParameter.Add(parameter)
            Next parameter
            Dim commandParameters As IDataParameter() = DirectCast(tempParameter.ToArray(GetType(IDataParameter)), IDataParameter())

            ' Assign the provided values to these parameters based on parameter order
            AssignParameterValues(commandParameters, parameterValues)

            ' Call the overload that takes an array of IDataParameters
            Return ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName, commandParameters)
        Else
            ' Otherwise we can just call the SP without params
            Return ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName)
        End If
    End Function 'ExecuteXmlReader

#End Region

#Region "ExecuteXmlReaderTypedParams"

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified IDbConnection
    ''' using the dataRow column values as the stored procedure's parameters values.
    ''' This method will assign the parameter values based on parameter order.
    ''' </summary>
    ''' <param name="command">The IDbCommand to execute</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>An XmlReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if command is null.</exception>
    Public Overloads Function ExecuteXmlReaderTypedParams(ByVal command As IDbCommand, ByVal dataRow As DataRow) As XmlReader
        If command Is Nothing Then
            Throw New ArgumentNullException("command")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Set the parameters values
            AssignParameterValues(command.Parameters, dataRow)

            Return ExecuteXmlReader(command)
        Else
            Return ExecuteXmlReader(command)
        End If
    End Function 'ExecuteXmlReaderTypedParams

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified IDbConnection
    ''' using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>An XmlReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    Public Overloads Function ExecuteXmlReaderTypedParams(ByVal connection As IDbConnection, ByVal spName As [String], ByVal dataRow As DataRow) As XmlReader
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim tempParameter As New ArrayList
            Dim parameter As IDataParameter
            For Each parameter In GetSpParameterSet(connection, spName)
                tempParameter.Add(parameter)
            Next parameter
            Dim commandParameters As IDataParameter() = DirectCast(tempParameter.ToArray(GetType(IDataParameter)), IDataParameter())

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteXmlReader(connection, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteXmlReader(connection, CommandType.StoredProcedure, spName)
        End If
    End Function 'ExecuteXmlReaderTypedParams

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified IDbTransaction
    ''' using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <param name="transaction">A valid IDbTransaction object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>An XmlReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or transaction or transaction.Connection is null</exception>
    Public Overloads Function ExecuteXmlReaderTypedParams(ByVal transaction As IDbTransaction, ByVal spName As [String], ByVal dataRow As DataRow) As XmlReader
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim tempParameter As New ArrayList
            Dim parameter As IDataParameter
            For Each parameter In GetSpParameterSet(transaction.Connection, spName)
                tempParameter.Add(parameter)
            Next parameter
            Dim commandParameters As IDataParameter() = DirectCast(tempParameter.ToArray(GetType(IDataParameter)), IDataParameter())

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName)
        End If
    End Function 'ExecuteXmlReaderTypedParams

#End Region

#Region "FillDataset"

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string.
    ''' </summary>
    ''' <param name="command">The IDbCommand to execute</param>
    ''' <param name="dataSet">A DataSet wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)</param>
    ''' <exception cref="System.ArgumentNullException">Thrown if command is null.</exception>
    Public Overridable Overloads Sub FillDataset(ByVal command As IDbCommand, ByVal dataSet As DataSet, ByVal tableNames() As String)
        Dim mustCloseConnection As Boolean = False

        ' Clean Up Parameter Syntax
        CleanParameterSyntax(command)

        If command.Connection.State <> ConnectionState.Open Then
            command.Connection.Open()
            mustCloseConnection = True
        End If

        ' Create the DataAdapter & DataSet
        Dim dataAdapter As IDbDataAdapter = Nothing
        Try
            dataAdapter = GetDataAdapter()
            dataAdapter.SelectCommand = command

            ' Add the table mappings specified by the user
            If Not (tableNames Is Nothing) AndAlso tableNames.Length > 0 Then
                Dim tableName As String = "Table"
                Dim index As Integer
                For index = 0 To tableNames.Length - 1
                    If tableNames(index) Is Nothing OrElse tableNames(index).Length = 0 Then
                        Throw New ArgumentException("The tableNames parameter must contain a list of tables, a value was provided as null or empty string.", "tableNames")
                    End If
                    dataAdapter.TableMappings.Add(tableName + DirectCast(IIf(index = 0, "", index.ToString()), String), tableNames(index))
                Next index
            End If

            ' Fill the DataSet using default values for DataTable names, etc
            dataAdapter.Fill(dataSet)

            If mustCloseConnection Then
                command.Connection.Close()
            End If

            ' Detach the IDataParameters from the command object, so they can be used again
            ' don't do this...screws up output params  --cjb
            ' command.Parameters.Clear();
        Finally
            Dim id As IDisposable = DirectCast(dataAdapter, IDisposable)
            If Not (id Is Nothing) Then
                id.Dispose()
            End If
        End Try
    End Sub 'FillDataset

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the database specified in
    ''' the connection string.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' helper.FillDataset(connString, CommandType.StoredProcedure, "GetOrders", ds, new string[] "orders");
    ''' </code></example>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="dataSet">A DataSet wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)</param>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    Public Overridable Overloads Sub FillDataset(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames() As String)
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If dataSet Is Nothing Then
            Throw New ArgumentNullException("dataSet")
        End If
        ' Create & open a IDbConnection, and dispose of it after we are done
        Dim connection As IDbConnection = Nothing
        Try
            connection = GetConnection(connectionString)
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            FillDataset(connection, commandType, commandText, dataSet, tableNames)
        Finally
            Dim id As IDisposable = connection
            If Not (id Is Nothing) Then
                id.Dispose()
            End If
        End Try
    End Sub 'FillDataset

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the database specified in
    ''' the connection string.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' helper.FillDataset(CommandType.StoredProcedure, "GetOrders", ds, new string[] "orders");
    ''' </code></example>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="dataSet">A DataSet wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)</param>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText is null</exception>
    Public Overridable Overloads Sub FillDataset(ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames() As String)
        If dataSet Is Nothing Then
            Throw New ArgumentNullException("dataSet")
        End If
        ' Create & open a IDbConnection, and dispose of it after we are done
        Dim connection As IDbConnection = Nothing
        Try
            connection = GetConnection(moProvider.ConnectionString)
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            FillDataset(connection, commandType, commandText, dataSet, tableNames)
        Finally
            Dim id As IDisposable = connection
            If Not (id Is Nothing) Then
                id.Dispose()
            End If
        End Try
    End Sub 'FillDataset

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the database specified in the connection string
    ''' using the provided parameters.
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <param name="dataSet">A DataSet wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)
    ''' </param>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Sub FillDataset(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames() As String, ByVal ParamArray commandParameters() As IDataParameter)
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If dataSet Is Nothing Then
            Throw New ArgumentNullException("dataSet")
        End If ' Create & open a IDbConnection, and dispose of it after we are done
        Dim connection As IDbConnection = Nothing
        Try
            connection = GetConnection(connectionString)
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            FillDataset(connection, commandType, commandText, dataSet, tableNames, commandParameters)
        Finally
            Dim id As IDisposable = connection
            If Not (id Is Nothing) Then
                id.Dispose()
            End If
        End Try
    End Sub 'FillDataset

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the database specified in the connection string
    ''' using the provided parameters.
    ''' </summary>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <param name="dataSet">A DataSet wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)
    ''' </param>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText is null</exception>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Sub FillDataset(ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames() As String, ByVal ParamArray commandParameters() As IDataParameter)
        If dataSet Is Nothing Then
            Throw New ArgumentNullException("dataSet")
        End If ' Create & open a IDbConnection, and dispose of it after we are done
        Dim connection As IDbConnection = Nothing
        Try
            connection = GetConnection(moProvider.ConnectionString)
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            FillDataset(connection, commandType, commandText, dataSet, tableNames, commandParameters)
        Finally
            Dim id As IDisposable = connection
            If Not (id Is Nothing) Then
                id.Dispose()
            End If
        End Try
    End Sub 'FillDataset

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' helper.FillDataset(connString, CommandType.StoredProcedure, "GetOrders", ds, new string[] "orders", 24);
    ''' </code></example>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataSet">A dataset wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)
    ''' </param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Sub FillDataset(ByVal connectionString As String, ByVal spName As String, ByVal dataSet As DataSet, ByVal tableNames() As String, ByVal ParamArray parameterValues() As Object)
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If dataSet Is Nothing Then
            Throw New ArgumentNullException("dataSet")
        End If

        ' Create & open a IDbConnection, and dispose of it after we are done
        Dim connection As IDbConnection = Nothing
        Try
            connection = GetConnection(connectionString)
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            FillDataset(connection, spName, dataSet, tableNames, parameterValues)
        Finally
            Dim id As IDisposable = connection
            If Not (id Is Nothing) Then
                id.Dispose()
            End If
        End Try
    End Sub 'FillDataset

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' helper.FillDataset(CommandType.StoredProcedure, "GetOrders", ds, new string[] "orders", 24);
    ''' </code></example>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataSet">A dataset wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)
    ''' </param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName is null</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Sub FillDataset(ByVal spName As String, ByVal dataSet As DataSet, ByVal tableNames() As String, ByVal ParamArray parameterValues() As Object)
        If dataSet Is Nothing Then
            Throw New ArgumentNullException("dataSet")
        End If

        ' Create & open a IDbConnection, and dispose of it after we are done
        Dim connection As IDbConnection = Nothing
        Try
            connection = GetConnection(moProvider.ConnectionString)
            connection.Open()

            ' Call the overload that takes a connection in place of the connection string
            FillDataset(connection, spName, dataSet, tableNames, parameterValues)
        Finally
            Dim id As IDisposable = connection
            If Not (id Is Nothing) Then
                id.Dispose()
            End If
        End Try
    End Sub 'FillDataset

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the provided IDbConnection.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' helper.FillDataset(conn, CommandType.StoredProcedure, "GetOrders", ds, new string[] "orders");
    ''' </code></example>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="dataSet">A dataset wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)
    ''' </param>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or connection is null</exception>
    Public Overridable Overloads Sub FillDataset(ByVal connection As IDbConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames() As String)
        FillDataset(connection, commandType, commandText, dataSet, tableNames, Nothing)
    End Sub 'FillDataset

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the specified IDbConnection
    ''' using the provided parameters.
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="dataSet">A DataSet wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)
    ''' </param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or connection is null</exception>
    Public Overridable Overloads Sub FillDataset(ByVal connection As IDbConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames() As String, ByVal ParamArray commandParameters() As IDataParameter)
        FillDataset(connection, Nothing, commandType, commandText, dataSet, tableNames, commandParameters)
    End Sub 'FillDataset

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified IDbConnection
    ''' using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' helper.FillDataset(conn, "GetOrders", ds, new string[] "orders", 24, 36);
    ''' </code></example>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataSet">A dataset wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)
    ''' </param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    Public Overridable Overloads Sub FillDataset(ByVal connection As IDbConnection, ByVal spName As String, ByVal dataSet As DataSet, ByVal tableNames() As String, ByVal ParamArray parameterValues() As Object)
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If dataSet Is Nothing Then
            Throw New ArgumentNullException("dataSet")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                FillDataset(connection, CommandType.StoredProcedure, spName, dataSet, tableNames, iDataParameterValues)
            Else

                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(connection, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDataParameters
                FillDataset(connection, CommandType.StoredProcedure, spName, dataSet, tableNames, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            FillDataset(connection, CommandType.StoredProcedure, spName, dataSet, tableNames)
        End If
    End Sub 'FillDataset

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset and takes no parameters) against the provided IDbTransaction.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' helper.FillDataset(tran, CommandType.StoredProcedure, "GetOrders", ds, new string[] "orders");
    ''' </code></example>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="dataSet">A dataset wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)
    ''' </param>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or transaction or transaction.Connection is null</exception>
    Public Overridable Overloads Sub FillDataset(ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames() As String)
        FillDataset(transaction, commandType, commandText, dataSet, tableNames, Nothing)
    End Sub 'FillDataset

    ''' <summary>
    ''' Execute an IDbCommand (that returns a resultset) against the specified IDbTransaction
    ''' using the provided parameters.
    ''' </summary>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="dataSet">A DataSet wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)
    ''' </param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or transaction or transaction.Connection is null</exception>
    Public Overridable Overloads Sub FillDataset(ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames() As String, ByVal ParamArray commandParameters() As IDataParameter)
        FillDataset(transaction.Connection, transaction, commandType, commandText, dataSet, tableNames, commandParameters)
    End Sub 'FillDataset

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified
    ''' IDbTransaction using the provided parameter values. This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <remarks>
    ''' This method provides no access to output parameters or the stored procedure's return value parameter.
    ''' </remarks>
    ''' <example>
    ''' <code>
    ''' helper.FillDataset(tran, "GetOrders", ds, new string[] "orders", 24, 36);
    ''' </code></example>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataSet">A dataset wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)
    ''' </param>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or transaction or transaction.Connection is null</exception>
    Public Overridable Overloads Sub FillDataset(ByVal transaction As IDbTransaction, ByVal spName As String, ByVal dataSet As DataSet, ByVal tableNames() As String, ByVal ParamArray parameterValues() As Object)
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        If dataSet Is Nothing Then
            Throw New ArgumentNullException("dataSet")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If we receive parameter values, we need to figure out where they go
        If Not (parameterValues Is Nothing) AndAlso parameterValues.Length > 0 Then
            Dim iDataParameterValues As IDataParameter() = GetDataParameters(parameterValues.Length)

            ' if we've been passed IDataParameters, don't do parameter discovery
            If AreParameterValuesIDataParameters(parameterValues, iDataParameterValues) Then
                FillDataset(transaction, CommandType.StoredProcedure, spName, dataSet, tableNames, iDataParameterValues)
            Else
                ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
                Dim includeReturnValue As Boolean = CheckForReturnValueParameter(parameterValues)
                Dim commandParameters As IDataParameter() = GetSpParameterSet(transaction.Connection, spName, includeReturnValue)

                ' Assign the provided values to these parameters based on parameter order
                AssignParameterValues(commandParameters, parameterValues)

                ' Call the overload that takes an array of IDataParameters
                FillDataset(transaction, CommandType.StoredProcedure, spName, dataSet, tableNames, commandParameters)
            End If
        Else
            ' Otherwise we can just call the SP without params
            FillDataset(transaction, CommandType.StoredProcedure, spName, dataSet, tableNames)
        End If
    End Sub 'FillDataset

    ''' <summary>
    ''' Private helper method that execute an IDbCommand (that returns a resultset) against the specified IDbTransaction and IDbConnection
    ''' using the provided parameters.
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="transaction">A valid IDbTransaction</param>
    ''' <param name="commandType">The CommandType (stored procedure, text, etc.)</param>
    ''' <param name="commandText">The stored procedure name or SQL command</param>
    ''' <param name="dataSet">A DataSet wich will contain the resultset generated by the command</param>
    ''' <param name="tableNames">This array will be used to create table mappings allowing the DataTables to be referenced
    ''' by a user defined name (probably the actual table name)
    ''' </param>
    ''' <param name="commandParameters">An array of IDataParameters used to execute the command</param>
    Private Overloads Sub FillDataset(ByVal connection As IDbConnection, ByVal transaction As IDbTransaction, ByVal commandType As CommandType, ByVal commandText As String, ByVal dataSet As DataSet, ByVal tableNames() As String, ByVal ParamArray commandParameters() As IDataParameter)
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If dataSet Is Nothing Then
            Throw New ArgumentNullException("dataSet")
        End If
        ' Create a command and prepare it for execution
        Dim command As IDbCommand = connection.CreateCommand()
        Dim mustCloseConnection As Boolean = False
        PrepareCommand(command, connection, transaction, commandType, commandText, commandParameters, mustCloseConnection)
        CleanParameterSyntax(command)

        FillDataset(command, dataSet, tableNames)

        If mustCloseConnection Then
            connection.Close()
        End If
    End Sub 'FillDataset

#End Region

#Region "UpdateDataset"

    ''' <summary>
    ''' This method consumes the RowUpdatingEvent and passes it on to the consumer specifed in the call to UpdateDataset
    ''' </summary>
    ''' <param name="obj">The object that generated the event</param>
    ''' <param name="e">The System.Data.Common.RowUpdatingEventArgs</param>
    Protected Sub RowUpdating(ByVal obj As Object, ByVal e As System.Data.Common.RowUpdatingEventArgs)
        If Not (Me.m_rowUpdating Is Nothing) Then
            m_rowUpdating(obj, e)
        End If
    End Sub 'RowUpdating

    ''' <summary>
    ''' This method consumes the RowUpdatedEvent and passes it on to the consumer specifed in the call to UpdateDataset
    ''' </summary>
    ''' <param name="obj">The object that generated the event</param>
    ''' <param name="e">The System.Data.Common.RowUpdatingEventArgs</param>
    Protected Sub RowUpdated(ByVal obj As Object, ByVal e As System.Data.Common.RowUpdatedEventArgs)
        If Not (Me.m_rowUpdated Is Nothing) Then
            m_rowUpdated(obj, e)
        End If
    End Sub 'RowUpdated

    ''' <summary>
    ''' Set up a command for updating a DataSet.
    ''' </summary>
    ''' <param name="command">command object to prepare</param>
    ''' <param name="mustCloseConnection">output parameter specifying whether the connection used should be closed by the DAAB</param>
    ''' <returns>An IDbCommand object</returns>
    Protected Overridable Function SetCommand(ByVal command As IDbCommand, ByRef mustCloseConnection As Boolean) As IDbCommand
        mustCloseConnection = False
        If Not (command Is Nothing) Then
            Dim commandParameters(command.Parameters.Count) As IDataParameter
            command.Parameters.CopyTo(commandParameters, 0)
            command.Parameters.Clear()
            Me.PrepareCommand(command, command.Connection, Nothing, command.CommandType, command.CommandText, commandParameters, mustCloseConnection)
            CleanParameterSyntax(command)
        End If

        Return command
    End Function 'SetCommand

    ''' <summary>
    ''' Executes the respective command for each inserted, updated, or deleted row in the DataSet.
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' helper.UpdateDataset(conn, insertCommand, deleteCommand, updateCommand, dataSet, "Order");
    ''' </code></example>
    ''' <param name="insertCommand">A valid SQL statement or stored procedure to insert new records into the data source</param>
    ''' <param name="deleteCommand">A valid SQL statement or stored procedure to delete records from the data source</param>
    ''' <param name="updateCommand">A valid SQL statement or stored procedure used to update records in the data source</param>
    ''' <param name="dataSet">The DataSet used to update the data source</param>
    ''' <param name="tableName">The DataTable used to update the data source.</param>
    Public Overridable Overloads Sub UpdateDataset(ByVal insertCommand As IDbCommand, ByVal deleteCommand As IDbCommand, ByVal updateCommand As IDbCommand, ByVal dataSet As DataSet, ByVal tableName As String)
        UpdateDataset(insertCommand, deleteCommand, updateCommand, dataSet, tableName, Nothing, Nothing)
    End Sub 'UpdateDataset

    ''' <summary>
    ''' Executes the IDbCommand for each inserted, updated, or deleted row in the DataSet also implementing RowUpdating and RowUpdated Event Handlers
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' RowUpdatingEventHandler rowUpdatingHandler = new RowUpdatingEventHandler( OnRowUpdating );
    ''' RowUpdatedEventHandler rowUpdatedHandler = new RowUpdatedEventHandler( OnRowUpdated );
    ''' helper.UpdateDataSet(sqlInsertCommand, sqlDeleteCommand, sqlUpdateCommand, dataSet, "Order", rowUpdatingHandler, rowUpdatedHandler);
    ''' </code></example>
    ''' <param name="insertCommand">A valid SQL statement or stored procedure to insert new records into the data source</param>
    ''' <param name="deleteCommand">A valid SQL statement or stored procedure to delete records from the data source</param>
    ''' <param name="updateCommand">A valid SQL statement or stored procedure used to update records in the data source</param>
    ''' <param name="dataSet">The DataSet used to update the data source</param>
    ''' <param name="tableName">The DataTable used to update the data source.</param>
    ''' <param name="rowUpdatingHandler">RowUpdatingEventHandler</param>
    ''' <param name="rowUpdatedHandler">RowUpdatedEventHandler</param>
    Public Overloads Sub UpdateDataset(ByVal insertCommand As IDbCommand, ByVal deleteCommand As IDbCommand, ByVal updateCommand As IDbCommand, ByVal dataSet As DataSet, ByVal tableName As String, ByVal rowUpdatingHandler As RowUpdatingHandler, ByVal rowUpdatedHandler As RowUpdatedHandler)
        If tableName Is Nothing OrElse tableName.Length = 0 Then
            Throw New ArgumentNullException("tableName")
        End If
        ' Create a IDbDataAdapter, and dispose of it after we are done
        Dim dataAdapter As IDbDataAdapter = Nothing
        Try
            Dim mustCloseUpdateConnection As Boolean = False
            Dim mustCloseInsertConnection As Boolean = False
            Dim mustCloseDeleteConnection As Boolean = False

            dataAdapter = GetDataAdapter()

            ' Set the data adapter commands
            dataAdapter.UpdateCommand = SetCommand(updateCommand, mustCloseUpdateConnection)
            dataAdapter.InsertCommand = SetCommand(insertCommand, mustCloseInsertConnection)
            dataAdapter.DeleteCommand = SetCommand(deleteCommand, mustCloseDeleteConnection)

            AddUpdateEventHandlers(dataAdapter, rowUpdatingHandler, rowUpdatedHandler)

            If TypeOf dataAdapter Is DbDataAdapter Then
                ' Update the dataset changes in the data source
                Try
                    DirectCast(dataAdapter, DbDataAdapter).Update(dataSet, tableName)
                Catch ex As Exception
                    ' Don't just throw ex.  It changes the call stack.  But we want the ex around for debugging, so...
                    Debug.WriteLine(ex)
                    Throw
                End Try
            Else
                dataAdapter.TableMappings.Add(tableName, "Table")

                ' Update the dataset changes in the data source
                dataAdapter.Update(dataSet)
            End If

            ' Commit all the changes made to the DataSet
            dataSet.Tables(tableName).AcceptChanges()

            If mustCloseUpdateConnection Then
                updateCommand.Connection.Close()
            End If
            If mustCloseInsertConnection Then
                insertCommand.Connection.Close()
            End If
            If mustCloseDeleteConnection Then
                deleteCommand.Connection.Close()
            End If
        Finally
            Dim id As IDisposable = DirectCast(dataAdapter, IDisposable)
            If Not (id Is Nothing) Then
                id.Dispose()
            End If
        End Try
    End Sub 'UpdateDataset

#End Region

#Region "CreateCommand"

    ''' <summary>
    ''' Simplify the creation of an IDbCommand object by allowing
    ''' a stored procedure and optional parameters to be provided
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' IDbCommand command = helper.CreateCommand(conn, "AddCustomer", "CustomerID", "CustomerName");
    ''' </code></example>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="sourceColumns">An array of string to be assigned as the source columns of the stored procedure parameters</param>
    ''' <returns>A valid IDbCommand object</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function CreateCommand(ByVal connectionString As String, ByVal spName As String, ByVal ParamArray sourceColumns() As String) As IDbCommand
        Return CreateCommand(Me.GetConnection(connectionString), spName, sourceColumns)
    End Function 'CreateCommand

    ''' <summary>
    ''' Simplify the creation of an IDbCommand object by allowing
    ''' a stored procedure and optional parameters to be provided
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' IDbCommand command = helper.CreateCommand(conn, "AddCustomer", "CustomerID", "CustomerName");
    ''' </code></example>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="sourceColumns">An array of string to be assigned as the source columns of the stored procedure parameters</param>
    ''' <returns>A valid IDbCommand object</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName is null</exception>
    ''' <exception cref="System.InvalidOperationException">Thrown if any of the IDataParameters.ParameterNames are null, or if the parameter count does not match the number of values supplied</exception>
    ''' <exception cref="System.ArgumentException">Thrown if the parameter count does not match the number of values supplied</exception>
    Public Overridable Overloads Function CreateCommand(ByVal spName As String, ByVal ParamArray sourceColumns() As String) As IDbCommand
        Return CreateCommand(Me.GetConnection(moProvider.ConnectionString), spName, sourceColumns)
    End Function 'CreateCommand

    ''' <summary>
    ''' Simplify the creation of an IDbCommand object by allowing
    ''' a stored procedure and optional parameters to be provided
    ''' </summary>
    ''' <example>
    ''' <code>
    ''' IDbCommand command = helper.CreateCommand(conn, "AddCustomer", "CustomerID", "CustomerName");
    ''' </code></example>
    ''' <param name="connection">A valid IDbConnection object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="sourceColumns">An array of string to be assigned as the source columns of the stored procedure parameters</param>
    ''' <returns>A valid IDbCommand object</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    Public Overridable Overloads Function CreateCommand(ByVal connection As IDbConnection, ByVal spName As String, ByVal ParamArray sourceColumns() As String) As IDbCommand
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' Create a IDbCommand
        Dim cmd As IDbCommand = connection.CreateCommand()
        cmd.CommandText = spName
        cmd.CommandType = CommandType.StoredProcedure

        ' If we receive parameter values, we need to figure out where they go
        If Not (sourceColumns Is Nothing) AndAlso sourceColumns.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(connection, spName)

            ' Assign the provided source columns to these parameters based on parameter order
            Dim index As Integer
            For index = 0 To sourceColumns.Length - 1
                commandParameters(index).SourceColumn = sourceColumns(index)
            Next index
            ' Attach the discovered parameters to the IDbCommand object
            AttachParameters(cmd, commandParameters)
        End If

        Return cmd
    End Function 'CreateCommand

    ''' <summary>
    ''' Simplify the creation of an IDbCommand object by allowing
    ''' a stored procedure and optional parameters to be provided
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="commandType">A System.Data.CommandType</param>
    ''' <param name="commandText">A valid SQL statement</param>
    ''' <param name="commandParameters">The parameters for the SQL statement</param>
    ''' <returns>A valid IDbCommand object</returns>
    Public Overridable Overloads Function CreateCommand(ByVal connectionString As String, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As IDbCommand
        Return CreateCommand(Me.GetConnection(connectionString), commandType, commandText, commandParameters)
    End Function 'CreateCommand

    ''' <summary>
    ''' Simplify the creation of an IDbCommand object by allowing
    ''' a stored procedure and optional parameters to be provided
    ''' </summary>
    ''' <param name="commandType">A System.Data.CommandType</param>
    ''' <param name="commandText">A valid SQL statement</param>
    ''' <param name="commandParameters">The parameters for the SQL statement</param>
    ''' <returns>A valid IDbCommand object</returns>
    Public Overridable Overloads Function CreateCommand(ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As IDbCommand
        Return CreateCommand(Me.GetConnection(moProvider.ConnectionString), commandType, commandText, commandParameters)
    End Function 'CreateCommand

    ''' <summary>
    ''' Simplify the creation of an IDbCommand object by allowing
    ''' a stored procedure and optional parameters to be provided
    ''' </summary>
    ''' <example><code>
    ''' IDbCommand command = helper.CreateCommand(conn, "AddCustomer", "CustomerID", "CustomerName");
    ''' </code></example>
    ''' <param name="connection">A valid IDbConnection object</param>
    ''' <param name="commandType">A System.Data.CommandType</param>
    ''' <param name="commandText">A valid SQL statement</param>
    ''' <param name="commandParameters">The parameters for the SQL statement</param>
    ''' <returns>A valid IDbCommand object</returns>
    Public Overridable Overloads Function CreateCommand(ByVal connection As IDbConnection, ByVal commandType As CommandType, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter) As IDbCommand
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If commandText Is Nothing OrElse commandText.Length = 0 Then
            Throw New ArgumentNullException("commandText")
        End If
        ' Create a IDbCommand
        Dim cmd As IDbCommand = connection.CreateCommand()
        cmd.CommandText = commandText
        cmd.CommandType = commandType

        ' If we receive parameter values, we need to figure out where they go
        If Not (commandParameters Is Nothing) AndAlso commandParameters.Length > 0 Then
            ' Assign the provided source columns to these parameters based on parameter order
            Dim index As Integer
            For index = 0 To commandParameters.Length - 1
                If commandParameters(index).SourceColumn = String.Empty Then
                    commandParameters(index).SourceColumn = commandParameters(index).ParameterName.TrimStart(New Char() {"@"c})
                End If
            Next index

            ' Attach the discovered parameters to the IDbCommand object
            AttachParameters(cmd, commandParameters)
        End If

        Return cmd
    End Function 'CreateCommand

#End Region

#Region "ExecuteNonQueryTypedParams"

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns no resultset)
    ''' against the database specified in the connection string using the
    ''' dataRow column values as the stored procedure's parameters values.
    ''' This method will assign the parameter values based on row values.
    ''' </summary>
    ''' <param name="command">The IDbCommand to execute</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if command is null.</exception>
    Public Overridable Overloads Function ExecuteNonQueryTypedParams(ByVal command As IDbCommand, ByVal dataRow As DataRow) As Integer
        Dim retVal As Integer = 0

        ' Clean Up Parameter Syntax
        CleanParameterSyntax(command)

        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Set the parameters values
            AssignParameterValues(command.Parameters, dataRow)

            retVal = ExecuteNonQuery(command)
        Else
            retVal = ExecuteNonQuery(command)
        End If

        Return retVal
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns no resultset) against the database specified in
    ''' the connection string using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on row values.
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    Public Overridable Overloads Function ExecuteNonQueryTypedParams(ByVal connectionString As [String], ByVal spName As [String], ByVal dataRow As DataRow) As Integer
        If ConnectionString Is Nothing OrElse ConnectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(ConnectionString, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteNonQuery(ConnectionString, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteNonQuery(ConnectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns no resultset) against the database specified in
    ''' the connection string using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on row values.
    ''' </summary>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName is null</exception>
    Public Overridable Overloads Function ExecuteNonQueryTypedParams(ByVal spName As [String], ByVal dataRow As DataRow) As Integer
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(moProvider.ConnectionString, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteNonQuery(moProvider.ConnectionString, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteNonQuery(moProvider.ConnectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns no resultset) against the specified IDbConnection
    ''' using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on row values.
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    Public Overridable Overloads Function ExecuteNonQueryTypedParams(ByVal connection As IDbConnection, ByVal spName As [String], ByVal dataRow As DataRow) As Integer
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(connection, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteNonQuery(connection, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteNonQuery(connection, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns no resultset) against the specified
    ''' IDbTransaction using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on row values.
    ''' </summary>
    ''' <param name="transaction">A valid IDbTransaction object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>An int representing the number of rows affected by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or transaction or transaction.Connection is null</exception>
    Public Overridable Overloads Function ExecuteNonQueryTypedParams(ByVal transaction As IDbTransaction, ByVal spName As [String], ByVal dataRow As DataRow) As Integer
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' Sf the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(transaction.Connection, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName)
        End If
    End Function

#End Region

#Region "ExecuteDatasetTypedParams"

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string using the dataRow column values as the stored procedure's parameters values.
    ''' This method will assign the paraemter values based on row values.
    ''' </summary>
    ''' <param name="command">The IDbCommand to execute</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if command is null.</exception>
    Public Overridable Overloads Function ExecuteDatasetTypedParams(ByVal command As IDbCommand, ByVal dataRow As DataRow) As DataSet
        Dim ds As DataSet = Nothing

        ' Clean Up Parameter Syntax
        CleanParameterSyntax(Command)

        ' If the row has values, the stored procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Set the parameter values
            AssignParameterValues(Command.Parameters, dataRow)
        End If
        ds = ExecuteDataset(Command)

        Return ds
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on row values.
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    Public Overridable Overloads Function ExecuteDatasetTypedParams(ByVal connectionString As String, ByVal spName As String, ByVal dataRow As DataRow) As DataSet
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        'If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(connectionString, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on row values.
    ''' </summary>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName is null</exception>
    Public Overridable Overloads Function ExecuteDatasetTypedParams(ByVal spName As [String], ByVal dataRow As DataRow) As DataSet
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        'If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(moProvider.ConnectionString, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteDataset(moProvider.ConnectionString, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteDataset(moProvider.ConnectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified IDbConnection
    ''' using the dataRow column values as the store procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on row values.
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    Public Overridable Overloads Function ExecuteDatasetTypedParams(ByVal connection As IDbConnection, ByVal spName As [String], ByVal dataRow As DataRow) As DataSet
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(connection, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteDataset(connection, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteDataset(connection, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified IDbTransaction
    ''' using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on row values.
    ''' </summary>
    ''' <param name="transaction">A valid IDbTransaction object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>A DataSet containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or transaction or transaction.Connection is null</exception>
    Public Overridable Overloads Function ExecuteDatasetTypedParams(ByVal transaction As IDbTransaction, ByVal spName As [String], ByVal dataRow As DataRow) As DataSet
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(transaction.Connection, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteDataset(transaction, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteDataset(transaction, CommandType.StoredProcedure, spName)
        End If
    End Function

#End Region

#Region "ExecuteReaderTypedParams"

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string using the dataRow column values as the stored procedure's parameters values.
    ''' This method will assign the parameter values based on parameter order.
    ''' </summary>
    ''' <param name="command">The IDbCommand to execute</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if command is null.</exception>
    Public Overridable Overloads Function ExecuteReaderTypedParams(ByVal command As IDbCommand, ByVal dataRow As DataRow) As IDataReader
        Dim reader As IDataReader = Nothing

        ' Clean Up Parameter Syntax
        CleanParameterSyntax(command)

        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Set the parameters values
            AssignParameterValues(command.Parameters, dataRow)

            reader = ExecuteReader(command)
        Else
            reader = ExecuteReader(command)
        End If

        Return reader
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    Public Overridable Overloads Function ExecuteReaderTypedParams(ByVal connectionString As String, ByVal spName As String, ByVal dataRow As DataRow) As IDataReader
        If ConnectionString Is Nothing OrElse ConnectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(ConnectionString, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteReader(ConnectionString, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteReader(ConnectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the database specified in
    ''' the connection string using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    Public Overridable Overloads Function ExecuteReaderTypedParams(ByVal spName As String, ByVal dataRow As DataRow) As IDataReader
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(moProvider.ConnectionString, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteReader(moProvider.ConnectionString, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteReader(moProvider.ConnectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified IDbConnection
    ''' using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    Public Overridable Overloads Function ExecuteReaderTypedParams(ByVal connection As IDbConnection, ByVal spName As [String], ByVal dataRow As DataRow) As IDataReader
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(connection, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteReader(connection, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteReader(connection, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a resultset) against the specified IDbTransaction
    ''' using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <param name="transaction">A valid IDbTransaction object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>A IDataReader containing the resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or transaction or transaction.Connection is null</exception>
    Public Overridable Overloads Function ExecuteReaderTypedParams(ByVal transaction As IDbTransaction, ByVal spName As [String], ByVal dataRow As DataRow) As IDataReader
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(transaction.Connection, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteReader(transaction, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteReader(transaction, CommandType.StoredProcedure, spName)
        End If
    End Function

#End Region

#Region "ExecuteScalarTypedParams"

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a 1x1 resultset) against the database specified in
    ''' the connection string using the dataRow column values as the stored procedure's parameters values.
    ''' This method will assign the parameter values based on parameter order.
    ''' </summary>
    ''' <param name="command">The IDbCommand to execute</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if command is null.</exception>
    Public Overridable Overloads Function ExecuteScalarTypedParams(ByVal command As IDbCommand, ByVal dataRow As DataRow) As Object
        Dim retVal As Object = Nothing

        ' Clean Up Parameter Syntax
        CleanParameterSyntax(Command)

        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Set the parameters values
            AssignParameterValues(Command.Parameters, dataRow)

            retVal = ExecuteScalar(Command)
        Else
            retVal = ExecuteScalar(Command)
        End If

        Return retVal
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a 1x1 resultset) against the database specified in
    ''' the connection string using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for an IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    Public Overridable Overloads Function ExecuteScalarTypedParams(ByVal connectionString As String, ByVal spName As String, ByVal dataRow As DataRow) As Object
        If ConnectionString Is Nothing OrElse ConnectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(ConnectionString, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteScalar(ConnectionString, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteScalar(ConnectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a 1x1 resultset) against the database specified in
    ''' the connection string using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName is null</exception>
    Public Overridable Overloads Function ExecuteScalarTypedParams(ByVal spName As String, ByVal dataRow As DataRow) As Object
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(moProvider.ConnectionString, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteScalar(moProvider.ConnectionString, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteScalar(moProvider.ConnectionString, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a 1x1 resultset) against the specified IDbConnection
    ''' using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    Public Overridable Overloads Function ExecuteScalarTypedParams(ByVal connection As IDbConnection, ByVal spName As [String], ByVal dataRow As DataRow) As Object
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(connection, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteScalar(connection, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteScalar(connection, CommandType.StoredProcedure, spName)
        End If
    End Function

    ''' <summary>
    ''' Execute a stored procedure via an IDbCommand (that returns a 1x1 resultset) against the specified IDbTransaction
    ''' using the dataRow column values as the stored procedure's parameters values.
    ''' This method will query the database to discover the parameters for the
    ''' stored procedure (the first time each stored procedure is called), and assign the values based on parameter order.
    ''' </summary>
    ''' <param name="transaction">A valid IDbTransaction object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="dataRow">The dataRow used to hold the stored procedure's parameter values.</param>
    ''' <returns>An object containing the value in the 1x1 resultset generated by the command</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or transaction or transaction.Connection is null</exception>
    Public Overridable Overloads Function ExecuteScalarTypedParams(ByVal transaction As IDbTransaction, ByVal spName As [String], ByVal dataRow As DataRow) As Object
        If transaction Is Nothing Then
            Throw New ArgumentNullException("transaction")
        End If
        If Not (transaction Is Nothing) AndAlso transaction.Connection Is Nothing Then
            Throw New ArgumentException("The transaction was rolled back or committed, please provide an open transaction.", "transaction")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' If the row has values, the store procedure parameters must be initialized
        If Not (dataRow Is Nothing) AndAlso dataRow.ItemArray.Length > 0 Then
            ' Pull the parameters for this stored procedure from the parameter cache (or discover them & populate the cache)
            Dim commandParameters As IDataParameter() = GetSpParameterSet(transaction.Connection, spName)

            ' Set the parameters values
            AssignParameterValues(commandParameters, dataRow)

            Return ExecuteScalar(transaction, CommandType.StoredProcedure, spName, commandParameters)
        Else
            Return ExecuteScalar(transaction, CommandType.StoredProcedure, spName)
        End If
    End Function

#End Region

#Region "Parameter Discovery Functions"

    ''' <summary>
    ''' Checks for the existence of a return value parameter in the parametervalues
    ''' </summary>
    ''' <param name="parameterValues">An array of objects to be assigned as the input values of the stored procedure</param>
    ''' <returns>true if the parameterValues contains a return value parameter, false otherwise</returns>
    Private Function CheckForReturnValueParameter(ByVal parameterValues() As Object) As Boolean
        Dim hasReturnValue As Boolean = False
        Dim paramObject As Object
        For Each paramObject In parameterValues
            If TypeOf paramObject Is IDataParameter Then
                Dim paramInstance As IDataParameter = DirectCast(paramObject, IDataParameter)
                If paramInstance.Direction = ParameterDirection.ReturnValue Then
                    hasReturnValue = True
                    Exit For
                End If
            End If
        Next paramObject
        Return hasReturnValue
    End Function 'CheckForReturnValueParameter

    ''' <summary>
    ''' Check to see if the parameter values passed to the helper are, in fact, IDataParameters.
    ''' </summary>
    ''' <param name="parameterValues">Array of parameter values passed to helper</param>
    ''' <param name="iDataParameterValues">new array of IDataParameters built from parameter values</param>
    ''' <returns>True if the parameter values are IDataParameters</returns>
    Private Function AreParameterValuesIDataParameters(ByVal parameterValues() As Object, ByVal iDataParameterValues() As IDataParameter) As Boolean
        Dim areIDataParameters As Boolean = True

        Dim i As Integer
        For i = 0 To parameterValues.Length - 1
            If Not TypeOf parameterValues(i) Is IDataParameter Then
                areIDataParameters = False
                Exit For
            End If
            iDataParameterValues(i) = DirectCast(parameterValues(i), IDataParameter)
        Next i
        Return areIDataParameters
    End Function 'AreParameterValuesIDataParameters

    ''' <summary>
    ''' Retrieves the set of IDataParameters appropriate for the stored procedure
    ''' </summary>
    ''' <remarks>
    ''' This method will query the database for this information, and then store it in a cache for future requests.
    ''' </remarks>
    ''' <param name="connectionString">A valid connection string for a IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <returns>An array of IDataParameterParameters</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    Public Overridable Overloads Function GetSpParameterSet(ByVal connectionString As String, ByVal spName As String) As IDataParameter()
        Return GetSpParameterSet(connectionString, spName, False)
    End Function 'GetSpParameterSet

    ''' <summary>
    ''' Retrieves the set of IDataParameters appropriate for the stored procedure
    ''' </summary>
    ''' <remarks>
    ''' This method will query the database for this information, and then store it in a cache for future requests.
    ''' </remarks>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <returns>An array of IDataParameterParameters</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName is null</exception>
    Public Overridable Overloads Function GetSpParameterSet(ByVal spName As String) As IDataParameter()
        Return GetSpParameterSet(moProvider.ConnectionString, spName, False)
    End Function 'GetSpParameterSet

    ''' <summary>
    ''' Retrieves the set of IDataParameters appropriate for the stored procedure
    ''' </summary>
    ''' <remarks>
    ''' This method will query the database for this information, and then store it in a cache for future requests.
    ''' </remarks>
    ''' <param name="connectionString">A valid connection string for a IDbConnection</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="includeReturnValueParameter">A bool value indicating whether the return value parameter should be included in the results</param>
    ''' <returns>An array of IDataParameters</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    Public Overridable Overloads Function GetSpParameterSet(ByVal connectionString As String, ByVal spName As String, ByVal includeReturnValueParameter As Boolean) As IDataParameter()
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        Dim connection As IDbConnection = GetConnection(connectionString)
        Try
            Return GetSpParameterSetInternal(connection, spName, includeReturnValueParameter)
        Finally
            connection.Dispose()
        End Try
    End Function 'GetSpParameterSet

    ''' <summary>
    ''' Retrieves the set of IDataParameters appropriate for the stored procedure
    ''' </summary>
    ''' <remarks>
    ''' This method will query the database for this information, and then store it in a cache for future requests.
    ''' </remarks>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="includeReturnValueParameter">A bool value indicating whether the return value parameter should be included in the results</param>
    ''' <returns>An array of IDataParameters</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or spName is null</exception>
    Public Overridable Overloads Function GetSpParameterSet(ByVal spName As String, ByVal includeReturnValueParameter As Boolean) As IDataParameter()
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        Dim connection As IDbConnection = GetConnection(moProvider.ConnectionString)
        Try
            Return GetSpParameterSetInternal(connection, spName, includeReturnValueParameter)
        Finally
            connection.Dispose()
        End Try
    End Function 'GetSpParameterSet

    ''' <summary>
    ''' Retrieves the set of IDataParameters appropriate for the stored procedure
    ''' </summary>
    ''' <remarks>
    ''' This method will query the database for this information, and then store it in a cache for future requests.
    ''' </remarks>
    ''' <param name="connection">A valid IDataConnection object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <returns>An array of IDataParameters</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    Public Overridable Overloads Function GetSpParameterSet(ByVal connection As IDbConnection, ByVal spName As String) As IDataParameter()
        Return GetSpParameterSet(connection, spName, False)
    End Function 'GetSpParameterSet

    ''' <summary>
    ''' Retrieves the set of IDataParameterParameters appropriate for the stored procedure
    ''' </summary>
    ''' <remarks>
    ''' This method will query the database for this information, and then store it in a cache for future requests.
    ''' </remarks>
    ''' <param name="connection">A valid IDbConnection object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="includeReturnValueParameter">A bool value indicating whether the return value parameter should be included in the results</param>
    ''' <returns>An array of IDataParameterParameters</returns>
    Public Overridable Overloads Function GetSpParameterSet(ByVal connection As IDbConnection, ByVal spName As String, ByVal includeReturnValueParameter As Boolean) As IDataParameter()
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If Not TypeOf (connection) Is ICloneable Then
            Throw New ArgumentException("Cannot discover parameters because the connection object does not implement the ICloneable interface", "connection")
        End If

        Dim clonedConnection As IDbConnection = DirectCast(DirectCast(connection, ICloneable).Clone(), IDbConnection)
        Return GetSpParameterSetInternal(clonedConnection, spName, includeReturnValueParameter)
    End Function 'GetSpParameterSet

    ''' <summary>
    ''' Retrieves the set of IDataParameters appropriate for the stored procedure
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="includeReturnValueParameter">A bool value indicating whether the return value parameter should be included in the results</param>
    ''' <returns>An array of IDataParameters</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    Private Function GetSpParameterSetInternal(ByVal connection As IDbConnection, ByVal spName As String, ByVal includeReturnValueParameter As Boolean) As IDataParameter()
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        ' string hashKey = connection.ConnectionString + ":" + spName + (includeReturnValueParameter ? ":include ReturnValue Parameter":"");
        Dim cachedParameters() As IDataParameter

        cachedParameters = GetCachedParameterSet(connection, spName + DirectCast(IIf(includeReturnValueParameter, ":include ReturnValue Parameter", ""), String))

        If cachedParameters Is Nothing Then
            Dim spParameters As IDataParameter() = DiscoverSpParameterSet(connection, spName, includeReturnValueParameter)
            CacheParameterSet(connection, spName + DirectCast(IIf(includeReturnValueParameter, ":include ReturnValue Parameter", ""), String), spParameters)

            cachedParameters = ADOHelperParameterCache.CloneParameters(spParameters)
        End If

        Return cachedParameters
    End Function 'GetSpParameterSetInternal

    ''' <summary>
    ''' Retrieve a parameter array from the cache
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for a IDbConnection</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <returns>An array of IDataParameters</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if connectionString or commandText is null</exception>
    Public Overloads Function GetCachedParameterSet(ByVal connectionString As String, ByVal commandText As String) As IDataParameter()
        Dim connection As IDbConnection = GetConnection(connectionString)
        Try
            Return GetCachedParameterSetInternal(connection, commandText)
        Finally
            connection.Dispose()
        End Try
    End Function 'GetCachedParameterSet

    ''' <summary>
    ''' Retrieve a parameter array from the cache
    ''' </summary>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <returns>An array of IDataParameters</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText is null</exception>
    Public Overloads Function GetCachedParameterSet(ByVal commandText As String) As IDataParameter()
        Dim connection As IDbConnection = GetConnection(moProvider.ConnectionString)
        Try
            Return GetCachedParameterSetInternal(connection, commandText)
        Finally
            connection.Dispose()
        End Try
    End Function 'GetCachedParameterSet

    ''' <summary>
    ''' Retrieve a parameter array from the cache
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection object</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <returns>An array of IDataParameters</returns>
    Public Overloads Function GetCachedParameterSet(ByVal connection As IDbConnection, ByVal commandText As String) As IDataParameter()
        Return GetCachedParameterSetInternal(connection, commandText)
    End Function 'GetCachedParameterSet

    ''' <summary>
    ''' Retrieve a parameter array from the cache
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection object</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <returns>An array of IDataParameters</returns>
    Private Function GetCachedParameterSetInternal(ByVal connection As IDbConnection, ByVal commandText As String) As IDataParameter()
        Dim mustCloseConnection As Boolean = False
        ' this way we control the connection, and therefore the connection string that gets saved as a hash key
        If connection.State <> ConnectionState.Open Then
            connection.Open()
            mustCloseConnection = True
        End If

        Dim parameters As IDataParameter() = ADOHelperParameterCache.GetCachedParameterSet(connection.ConnectionString, commandText)

        If mustCloseConnection Then
            connection.Close()
        End If

        Return parameters
    End Function 'GetCachedParameterSetInternal

    ''' <summary>
    ''' Add parameter array to the cache
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for a IDbConnection</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters to be cached</param>
    Public Overloads Sub CacheParameterSet(ByVal connectionString As String, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter)
        Dim connection As IDbConnection = GetConnection(connectionString)
        Try
            CacheParameterSetInternal(connection, commandText, commandParameters)
        Finally
            connection.Dispose()
        End Try
    End Sub 'CacheParameterSet

    ''' <summary>
    ''' Add parameter array to the cache
    ''' </summary>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters to be cached</param>
    Public Overloads Sub CacheParameterSet(ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter)
        Dim connection As IDbConnection = GetConnection(moProvider.ConnectionString)
        Try
            CacheParameterSetInternal(connection, commandText, commandParameters)
        Finally
            connection.Dispose()
        End Try
    End Sub 'CacheParameterSet

    ''' <summary>
    ''' Add parameter array to the cache
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters to be cached</param>
    Public Overloads Sub CacheParameterSet(ByVal connection As IDbConnection, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter)
        If TypeOf connection Is ICloneable Then
            Dim clonedConnection As IDbConnection = DirectCast(DirectCast(connection, ICloneable).Clone(), IDbConnection)
            Try
                CacheParameterSetInternal(clonedConnection, commandText, commandParameters)
            Finally
                clonedConnection.Dispose()
            End Try
        Else
            Throw New InvalidCastException
        End If
    End Sub 'CacheParameterSet

    ''' <summary>
    ''' Add parameter array to the cache
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters to be cached</param>
    Private Sub CacheParameterSetInternal(ByVal connection As IDbConnection, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter)
        ' this way we control the connection, and therefore the connection string that gets saved as a hask key
        connection.Open()
        ADOHelperParameterCache.CacheParameterSet(connection.ConnectionString, commandText, commandParameters)
        connection.Close()
    End Sub 'CacheParameterSetInternal

    ''' <summary>
    ''' Resolve at run time the appropriate set of IDataParameters for a stored procedure
    ''' </summary>
    ''' <param name="connection">A valid IDbConnection object</param>
    ''' <param name="spName">The name of the stored procedure</param>
    ''' <param name="includeReturnValueParameter">Whether or not to include their return value parameter</param>
    ''' <returns>The parameter array discovered.</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if spName or connection is null</exception>
    Private Function DiscoverSpParameterSet(ByVal connection As IDbConnection, ByVal spName As String, ByVal includeReturnValueParameter As Boolean) As IDataParameter()
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If
        If spName Is Nothing OrElse spName.Length = 0 Then
            Throw New ArgumentNullException("spName")
        End If
        Dim cmd As IDbCommand = connection.CreateCommand()
        cmd.CommandText = spName
        cmd.CommandType = CommandType.StoredProcedure

        connection.Open()
        DeriveParameters(cmd)
        connection.Close()

        If Not includeReturnValueParameter Then
            ' not all providers have return value parameters...don't just remove this parameter indiscriminately
            If cmd.Parameters.Count > 0 AndAlso DirectCast(cmd.Parameters(0), IDataParameter).Direction = ParameterDirection.ReturnValue Then
                cmd.Parameters.RemoveAt(0)
            End If
        End If

        Dim discoveredParameters(cmd.Parameters.Count - 1) As IDataParameter

        cmd.Parameters.CopyTo(discoveredParameters, 0)

        ' Init the parameters with a DBNull value
        Dim discoveredParameter As IDataParameter
        For Each discoveredParameter In discoveredParameters
            discoveredParameter.Value = DBNull.Value
        Next discoveredParameter

        cmd.Dispose()

        Return discoveredParameters

    End Function 'DiscoverSpParameterSet

#End Region

    ''' <summary>
    ''' Creates and returns a database connection for app.config appSettings.ConnectionString connection string. 
    ''' </summary>
    ''' <returns>A database connection for app.config appSettings->ConnectionString connection string.</returns>
    ''' <remarks>Requires an entry in the app.config file for appSettings->ConnectionString.</remarks>
    Public Function GetConnection() As IDbConnection
        Return moProvider.GetConnection(GetConnectionString())
    End Function

    ''' <summary>
    ''' Returns the current database connection string for the native database provider.
    ''' </summary>
    ''' <returns>The current database connection string for the native database provider.</returns>
    Public Function GetConnectionString() As String
        Return moProvider.ConnectionString
    End Function

    ''' <summary>
    ''' Native database provider type
    ''' </summary>
    Public ReadOnly Property DatabaseType() As DatabaseTypeEnum
        Get
            Return moProvider.ProviderDatabaseType
        End Get
    End Property

    ''' <summary>
    ''' Native database provider type
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Deprecated.</remarks>
    Public ReadOnly Property DBMS() As DatabaseTypeEnum
        Get
            Return Me.DatabaseType
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether the current database is a Microsoft Access database.
    ''' </summary>
    Public ReadOnly Property IsAccessDatabase() As Boolean
        Get
            If ((Me.DatabaseType = DatabaseTypeEnum.OleDb) OrElse (Me.DatabaseType = DatabaseTypeEnum.Odbc)) AndAlso (Me.ConnectionString.ToUpper.Contains(".MDB") OrElse Me.ConnectionString.ToUpper.Contains(".ACCDB")) Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    ''' <summary>
    ''' The date delimiter of the native database provider
    ''' </summary>
    Public ReadOnly Property DateDelimiter() As String
        Get
            Return moProvider.ProviderDateDelimiter
        End Get
    End Property

    ''' <summary>
    ''' The date format of the native database provider
    ''' </summary>
    Public ReadOnly Property DateFormat() As String
        Get
            Return moProvider.ProviderDateFormat
        End Get
    End Property

    ''' <summary>
    ''' The upper casing function of the native database provider
    ''' </summary>
    Public ReadOnly Property UpperFunction() As String
        Get
            Return moProvider.ProviderUpperFunction
        End Get
    End Property

    ''' <summary>
    ''' The ISNULL or COALESCE or NVL or IFNULL function of the native database provider
    ''' </summary>
    ''' <param name="sColumnName">Column to check for null.</param>
    ''' <param name="sValue">Value to be used if field is null.</param>
    Public ReadOnly Property IsNullFunction(ByVal sColumnName As String, ByVal sValue As String) As String
        Get
            Return moProvider.ProviderIsNullFunction(sColumnName, sValue)
        End Get
    End Property

    ''' <summary>
    ''' The native-provider routine to clean or compact/repair or truncate temp databases  
    ''' </summary>
    Public Sub CleanDatabase()
        moProvider.ProviderCleanDatabase()
    End Sub

    ''' <summary>
    ''' For those providers which support Identity type fields, this function returns the last created identity value for a given transaction.
    ''' </summary>
    ''' <typeparam name="I">Data type of the Identity type field</typeparam>
    ''' <param name="oTransaction">Current database transaction</param>
    ''' <returns>The last created identity value for a given transaction</returns>
    ''' <remarks>Not supported by all database providers.</remarks>
    Public Function GetLastIdentityValue(Of I)(ByVal oTransaction As IDbTransaction) As I

        Dim s As String = String.Empty

        Try

            s = moProvider.ProviderLastIdentityValueSql

            If Not String.IsNullOrEmpty(s) Then

                Return DirectCast(Me.ExecuteScalar(oTransaction, CommandType.Text, s), I)

            Else

                Return Nothing

            End If

        Catch ex As Exception

            Throw

        Finally

        End Try

    End Function

    ''' <summary>
    ''' The native-provider routine to determine if the specified table exists in the database 
    ''' </summary>
    Public Function TableExists(ByVal sTableName As String) As Boolean
        Return moProvider.ProviderTableExists(sTableName)
    End Function

    ''' <summary>
    ''' The native-provider routine to determine if the specified table + column exists in the database 
    ''' </summary>
    Public Function ColumnExists(ByVal sTableName As String, ByVal sColumnName As String) As Boolean
        Return moProvider.ProviderColumnExists(sTableName, sColumnName)
    End Function

    ''' <summary>
    ''' The native-provider routine to determine if the specified table + index exists in the database 
    ''' </summary>
    Public Function IndexExists(ByVal sTableName As String, ByVal sIndexName As String) As Boolean
        Return moProvider.ProviderIndexExists(sTableName, sIndexName)
    End Function

#Region " IDisposable Support "

    Private mbDisposedValue As Boolean     ' To detect redundant calls

    ''' <summary>
    ''' Disposes the object.
    ''' </summary>
    ''' <param name="disposing">True if called by
    ''' the public Dispose method.</param>
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.mbDisposedValue Then
            If disposing Then
                ' free unmanaged resources when explicitly called
            End If

            ' free shared unmanaged resources
        End If
        Me.mbDisposedValue = True
    End Sub

    ''' <summary>
    ''' Disposes the object.
    ''' </summary>
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    ''' <summary>
    ''' Object finalizer.
    ''' </summary>
    Protected Overrides Sub Finalize()
        Dispose(False)
    End Sub

#End Region

    ''' <summary>
    ''' Translates a <b>Boolean</b> value into its corresponding one-character string.
    ''' </summary>
    ''' <param name="bBooleanValue">A <b>Boolean</b> value to translate.</param>
    ''' <returns><b>'Y'</b> if the <b>Boolean</b> value is <b>True</b>; else, <b>'N'.</b></returns>
    Public Shared Function DbSetBooleanString(ByVal bBooleanValue As Boolean) As String

        If (bBooleanValue = True) Then
            Return "Y"
        Else
            Return "N"
        End If

    End Function

    ''' <summary>
    ''' Prepares a <b>DateTime</b> value for database input.
    ''' </summary>
    ''' <param name="dtDateValue">The <b>DateTime</b> value to be prepared.</param>
    ''' <returns>If the input value is <b>DateTime.MinValue</b>, then <b>DbNull.Value</b> is returned; else, the <b>DateTime</b> value with hh:mm:ss = to their original value.</returns>
    Public Shared Function DbSetDateTime(ByVal dtDateValue As DateTime) As Object

        If (dtDateValue = DateTime.MinValue) Then
            Return DBNull.Value
        Else
            Return dtDateValue
        End If

    End Function

    ''' <summary>
    ''' Prepares a <b>DateTime</b> value for database input.
    ''' </summary>
    ''' <param name="dtDateValue">The <b>DateTime</b> value to be prepared.</param>
    ''' <returns>If the input value is <b>DateTime.MinValue</b>, then <b>DbNull.Value</b> is returned; else, the <b>DateTime</b> value with hh:mm:ss = 00:00:00.</returns>
    Public Shared Function DbSetDate(ByVal dtDateValue As DateTime) As Object

        If (dtDateValue = DateTime.MinValue) Then
            Return DBNull.Value
        Else
            Return New Date(dtDateValue.Year, dtDateValue.Month, dtDateValue.Day, 0, 0, 0)
        End If

    End Function

End Class

#Region " ParameterCache "

''' <summary>
''' ADOHelperParameterCache provides functions to leverage a static cache of procedure parameters  
''' and the ability to discover parameters for stored procedures at run-time.
''' </summary>
Public NotInheritable Class ADOHelperParameterCache

    Private Shared paramCache As Hashtable = Hashtable.Synchronized(New Hashtable)

    ''' <summary>
    ''' Deep copy of cached IDataParameter array
    ''' </summary>
    ''' <param name="originalParameters"></param>
    ''' <returns></returns>
    Friend Shared Function CloneParameters(ByVal originalParameters() As IDataParameter) As IDataParameter()
        Dim clonedParameters(originalParameters.Length - 1) As IDataParameter

        Dim i As Integer = 0
        Dim j As Integer = originalParameters.Length

        While (i < j)
            clonedParameters(i) = DirectCast(DirectCast(originalParameters(i), ICloneable).Clone(), IDataParameter)
            i += 1
        End While

        Return clonedParameters
    End Function

#Region " Caching Functions "

    ''' <summary>
    ''' Add parameter array to the cache
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for a IDbConnection</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <param name="commandParameters">An array of IDataParameters to be cached</param>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or connectionString is null</exception>
    Friend Shared Sub CacheParameterSet(ByVal connectionString As String, ByVal commandText As String, ByVal ParamArray commandParameters() As IDataParameter)
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If commandText Is Nothing OrElse commandText.Length = 0 Then
            Throw New ArgumentNullException("commandText")
        End If
        Dim hashKey As String = connectionString + ":" + commandText

        paramCache(hashKey) = commandParameters
    End Sub 'CacheParameterSet

    ''' <summary>
    ''' Retrieve a parameter array from the cache
    ''' </summary>
    ''' <param name="connectionString">A valid connection string for a IDbConnection</param>
    ''' <param name="commandText">The stored procedure name or T-SQL command</param>
    ''' <returns>An array of IDataParameters</returns>
    ''' <exception cref="System.ArgumentNullException">Thrown if commandText or connectionString is null</exception>
    Friend Shared Function GetCachedParameterSet(ByVal connectionString As String, ByVal commandText As String) As IDataParameter()
        If connectionString Is Nothing OrElse connectionString.Length = 0 Then
            Throw New ArgumentNullException("connectionString")
        End If
        If commandText Is Nothing OrElse commandText.Length = 0 Then
            Throw New ArgumentNullException("commandText")
        End If
        Dim hashKey As String = connectionString + ":" + commandText

        Dim cachedParameters As IDataParameter() = DirectCast(paramCache(hashKey), IDataParameter())
        If cachedParameters Is Nothing Then
            Return Nothing
        Else
            Return CloneParameters(cachedParameters)
        End If
    End Function 'GetCachedParameterSet

#End Region

End Class

#End Region

