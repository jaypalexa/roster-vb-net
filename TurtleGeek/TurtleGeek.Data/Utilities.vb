Option Strict On
Option Explicit On 
Option Compare Text

Public Enum DatabaseTypeEnum
    Unknown = 0
    SqlServer = 1
    Oracle = 2
    Odbc = 3
    OleDb = 4
    SQLite = 5
    MySQL = 6
End Enum

Public Class Utilities

    Public Shared Function GetDBConcat(ByVal veDatabaseTypeEnum As DatabaseTypeEnum) As String

        Dim sReturnValue As String

        If (veDatabaseTypeEnum = DatabaseTypeEnum.Oracle) Then
            sReturnValue = "||"
        Else
            sReturnValue = "+"
        End If

        Return sReturnValue

    End Function

    Public Shared Function GetDBConvert(ByVal veDatabaseTypeEnum As DatabaseTypeEnum, ByVal vsColName As String, ByVal vsToDataType As String, Optional ByVal vsDateFormat As String = "") As String
        '********************************************************************************************************
        'Depending on your source db type and the parms passed, this property will return the convert string
        '
        'Parms      veDatabaseTypeEnum - database provider type
        '           vsColName - column name to be converted
        '           vsToDataType - target data type
        '           vsDateFormat - target format for oracle data to char conversions
        '
        'Expected vsToDataType:
        '           1 - datetime
        '           2 - timestamp  'Note, not SQL Server Timestamp(Rowstamp), but Oracle Timestamp which is equivalent to SQL Server Datetime
        '           3 - char(i)
        '           4 - varchar(i)
        '           5 - integer or number
        '
        'Expected vsDateFormat:
        '           1 - YYYYMMDD                'Equivalent to SQL Server 112, use with char / varchar
        '           2 - MM/DD/YYYY              'Equivalent to SQL Server 101, use with char / varchar
        '           3 - MM/DD/YYYY HH:MM:SS     'Equivalent to SQL Server 109, use with char / varchar - HH:MM:SS Only works for to_char function in oracle, to_timestamp must use HH:MI:SS
        '           4 - MM/DD/YYYY HH:MI:SS     'Use with timestamp
        '           5 - String.Empty            'if used with datetime then vsDateFormat defaults to YYYYMMDD
        '
        'Example call:
        '   NextGen.BBP.Data.Utilities.GetDBConvert(NextGen.BBP.Security.UserSecurity.DatabaseType, "vn.create_timestamp", "VARCHAR(8)", "YYYYMMDD")
        '********************************************************************************************************

        Dim sReturnValue As String = String.Empty

        vsColName = vsColName.ToUpper.Trim
        vsToDataType = vsToDataType.ToUpper.Trim
        vsDateFormat = vsDateFormat.ToUpper.Trim

        If (vsToDataType.StartsWith("DATE")) Then
            vsToDataType = "DATETIME"
        Else
            'do nothing
        End If

        If (veDatabaseTypeEnum = DatabaseTypeEnum.Oracle) Then
            'to_char from a date in a date format
            If ((vsToDataType.StartsWith("VARCHAR")) OrElse (vsToDataType.StartsWith("CHAR"))) AndAlso (vsDateFormat.Length > 0) Then
                sReturnValue = "TO_CHAR(" & vsColName & ", '" & vsDateFormat & "')"
                'to_char from a date no date format
            ElseIf ((vsToDataType.StartsWith("VARCHAR")) OrElse (vsToDataType.StartsWith("CHAR"))) AndAlso (vsDateFormat.Length = 0) Then
                sReturnValue = "TO_CHAR(" & vsColName & ")"
                'to_date from char with dateformat
            ElseIf (vsToDataType.StartsWith("DATE")) AndAlso (vsDateFormat.Length > 0) Then
                sReturnValue = "TO_DATE(" & vsColName & ", '" & vsDateFormat & "')"
            ElseIf (vsToDataType.StartsWith("DATE")) AndAlso (vsDateFormat.Length = 0) Then
                sReturnValue = "TO_DATE(" & vsColName & ", '" & "YYYYMMDD" & "')" 'default format if none is provided for date
            ElseIf (vsToDataType.StartsWith("TIMESTAMP")) AndAlso (vsDateFormat.Length > 0) Then
                sReturnValue = "TO_TIMESTAMP(" & vsColName & ", '" & vsDateFormat & "')"
            ElseIf (vsToDataType.StartsWith("NUMBER")) OrElse (vsToDataType.StartsWith("INT")) Then
                sReturnValue = "TO_NUMBER(" & vsColName & ")"
            End If
        Else
            Select Case vsToDataType
                Case "TIMESTAMP"
                    vsToDataType = "DATETIME"
                Case "NUMBER"
                    vsToDataType = "INT"
            End Select

            Select Case vsDateFormat
                Case "YYYYMMDD"
                    sReturnValue = "CONVERT(" & vsToDataType & ", " & vsColName & ", 112)"
                Case "MM/DD/YYYY"
                    sReturnValue = "CONVERT(" & vsToDataType & ", " & vsColName & ", 101)"
                Case "MM/DD/YYYY HH:MM:SS", "MON DD YYYY HH24:MI:SS"
                    sReturnValue = "CONVERT(" & vsToDataType & ", " & vsColName & ", 101) + ' ' + CONVERT(" & vsToDataType & ", " & vsColName & ", 108)"
                Case Else
                    sReturnValue = "CONVERT(" & vsToDataType & ", " & vsColName & ")"
            End Select
        End If

        Return sReturnValue

    End Function

    Public Shared Function GetDBEqualsBlankString(ByVal veDatabaseTypeEnum As DatabaseTypeEnum, ByVal vsColumnName As String) As String

        Dim sReturnValue As String

        If (veDatabaseTypeEnum = DatabaseTypeEnum.Oracle) Then
            sReturnValue = "LTRIM(RTRIM(" & vsColumnName & ")) IS NULL"
        Else
            sReturnValue = "LTRIM(RTRIM(ISNULL(" & vsColumnName & ", ''))) = ''"
        End If

        Return sReturnValue

    End Function

    Public Shared Function GetDBNotEqualsBlankString(ByVal veDatabaseTypeEnum As DatabaseTypeEnum, ByVal vsColumnName As String) As String

        Dim sReturnValue As String

        If (veDatabaseTypeEnum = DatabaseTypeEnum.Oracle) Then
            sReturnValue = "LTRIM(RTRIM(" & vsColumnName & ")) IS NOT NULL"
        Else
            sReturnValue = "LTRIM(RTRIM(ISNULL(" & vsColumnName & ", ''))) <> ''"
        End If

        Return sReturnValue

    End Function

    Public Shared Function GetDBFromDual(ByVal veDatabaseTypeEnum As DatabaseTypeEnum) As String

        Dim sReturnValue As String

        If (veDatabaseTypeEnum = DatabaseTypeEnum.Oracle) Then
            sReturnValue = "FROM DUAL "
        Else
            sReturnValue = String.Empty
        End If

        Return sReturnValue

    End Function

    Public Shared Function GetDBFunctionCall(ByVal veDatabaseTypeEnum As DatabaseTypeEnum, ByVal vsFunctionName As String) As String

        Dim sReturnValue As String

        If (veDatabaseTypeEnum = DatabaseTypeEnum.Oracle) Then
            sReturnValue = vsFunctionName
        Else
            sReturnValue = "dbo." & vsFunctionName
        End If

        Return sReturnValue

    End Function

    Public Shared Sub CompactAccessDatabase(ByVal sDatabaseFileName As String)

        Dim sAccessExePath As String = String.Empty
        Dim oProcess As System.Diagnostics.Process
        Dim oRegistryKey As Microsoft.Win32.RegistryKey

        Try
            '----------------------------------------------------------------
            '-- get Microsoft Access executable location
            '----------------------------------------------------------------
            oRegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\MSACCESS.EXE")

            If Not (oRegistryKey Is Nothing) Then

                sAccessExePath = oRegistryKey.GetValue("Path").ToString()

                If Not String.IsNullOrEmpty(sAccessExePath) Then

                    '----------------------------------------------------------------
                    '-- run Microsoft Access with the "compact" switch
                    '----------------------------------------------------------------
                    oProcess = New System.Diagnostics.Process()
                    oProcess.StartInfo.FileName = sAccessExePath & "MSACCESS.EXE"
                    oProcess.StartInfo.Arguments = Chr(34) & sDatabaseFileName & Chr(34) & " /compact /nostartup"
                    oProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                    oProcess.Start()

                End If

            End If

        Catch ex As Exception
        End Try

    End Sub

End Class