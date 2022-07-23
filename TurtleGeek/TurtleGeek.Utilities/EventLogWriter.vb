Option Explicit On
Option Strict On
Option Compare Text

Public NotInheritable Class EventLogWriter

    Public Shared Function WriteToApplicationEventLog(ByVal vsEntry As String, ByVal vsAppName As String, ByVal veEventType As System.Diagnostics.EventLogEntryType) As Boolean

        Dim oEventLog As System.Diagnostics.EventLog = Nothing

        Try
            oEventLog = New System.Diagnostics.EventLog

            '----------------------------------------------------------------
            '-- register the AppName as an Event Source
            '----------------------------------------------------------------
            If (Not System.Diagnostics.EventLog.SourceExists(vsAppName)) Then
                System.Diagnostics.EventLog.CreateEventSource(vsAppName, "Application")
            End If

            oEventLog.Source = vsAppName
            oEventLog.WriteEntry(vsEntry, veEventType)
            oEventLog.Close()

            Return True

        Catch ex As System.Exception
            '----------------------------------------------------------------
            '-- absorb any exceptions; we do not need to trap them
            '----------------------------------------------------------------
            Return False

        Finally
            oEventLog.Dispose()
            oEventLog = Nothing
        End Try

    End Function

End Class
