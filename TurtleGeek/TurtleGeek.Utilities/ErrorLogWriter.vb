Option Explicit On
Option Strict On

Public NotInheritable Class ErrorLogWriter

    Private Sub New()
        '-- prevent direct creation of this object (all methods are shared)
    End Sub

    Public Shared ReadOnly Property ERROR_LOG_FILE_NAME() As String
        Get
            Return My.Application.Info.DirectoryPath & "\ErrorLog.txt"
        End Get
    End Property

    Public Shared Function WriteToErrorLog(ByVal oException As System.Exception) As Boolean

        Dim sIniFileName As String = String.Empty
        Dim sErrorLogFile As String = String.Empty
        Dim sInnerExceptionText As String = String.Empty
        Dim oStreamWriter As System.IO.StreamWriter = Nothing

        Try
            '----------------------------------------------------------------
            '-- append the inner exception, if any
            '----------------------------------------------------------------
            If Not (oException.InnerException Is Nothing) Then
                sInnerExceptionText = "; Error Inner Exception = " & oException.InnerException.ToString
            Else
                sInnerExceptionText = String.Empty
            End If

            '----------------------------------------------------------------
            '-- add timestamp and write entry to the error log file
            '----------------------------------------------------------------
            oStreamWriter = New System.IO.StreamWriter(ERROR_LOG_FILE_NAME, True)
            oStreamWriter.WriteLine(DateTime.Now.ToString("MM-dd-yyyy") & "; " & DateTime.Now.ToString("HH:mm:ss.ff") & "; " & "[PID" & System.Diagnostics.Process.GetCurrentProcess().Id.ToString & "]; Error Message = " & oException.Message & "; Error Source = " & oException.Source & "; Error Stack Trace = " & oException.StackTrace & sInnerExceptionText)
            oStreamWriter.Flush()

            Return True

        Catch ex As System.Exception
            '----------------------------------------------------------------
            '-- if an error occurred when writing out to the error log file, 
            '-- write the message to the system application event log
            '----------------------------------------------------------------
            EventLogWriter.WriteToApplicationEventLog("Attempting to write to error log:  " & oException.ToString & ControlChars.CrLf & ControlChars.CrLf & "Error encountered during attempted write:  " & ex.ToString, System.Windows.Forms.Application.ProductName, System.Diagnostics.EventLogEntryType.Error)
            Return False

        Finally
            If Not (oStreamWriter Is Nothing) Then
                oStreamWriter.Close()
            End If
            oStreamWriter = Nothing
        End Try

    End Function

End Class
