Option Explicit On 
Option Strict On
Option Compare Text

Public NotInheritable Class ErrorMessageBox

    Public Shared Sub Show(ByVal oException As Exception, Optional ByVal sCaption As String = "")

        Dim sb As System.Text.StringBuilder
        Dim oStackTrace As System.Diagnostics.StackTrace
        Dim frm As New ErrorMessageBoxForm

        Try

            sb = New System.Text.StringBuilder

            '----------------------------------------------------------------
            '-- glean the calling assembly and routine from the stack trace
            '----------------------------------------------------------------
            oStackTrace = New System.Diagnostics.StackTrace(True)

            '----------------------------------------------------------------
            '-- first, write the error message to the error log file...
            '----------------------------------------------------------------
            ErrorLogWriter.WriteToErrorLog(oException)

            '----------------------------------------------------------------
            '--- ...then display the message box
            '----------------------------------------------------------------
            If Not (oException Is Nothing) Then
                sb.AppendLine(oException.ToString)
            End If

            If (sCaption.Trim.Length = 0) Then
                frm.Text = System.Windows.Forms.Application.ProductName
            End If

            frm.txtErrorMessageText.Text = sb.ToString
            frm.txtErrorMessageText.SelectionLength = 0
            frm.ShowDialog()

        Finally

            sb = Nothing
            oStackTrace = Nothing

        End Try

    End Sub

End Class
