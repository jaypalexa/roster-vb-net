Option Explicit On 
Option Strict On

Imports System.Data

''' <summary>
''' This is a DataReader that 'fixes' any null values before
''' they are returned to our business code.
''' </summary>
Public Class SafeDataReader

    Implements IDataReader

    Private moDataReader As IDataReader
    Private miIndex As Integer = -1

    ''' <summary>
    ''' Initializes the SafeDataReader object to use data from
    ''' the provided DataReader object.
    ''' </summary>
    ''' <param name="DataReader">The source DataReader object containing the data.</param>
    Public Sub New(ByVal DataReader As IDataReader)
        moDataReader = DataReader
    End Sub

    ''' <summary>
    ''' Gets a string value from the datareader.
    ''' </summary>
    ''' <remarks>
    ''' Returns empty string for null.
    ''' </remarks>
    Public Function GetString(ByVal i As Integer) As String Implements IDataReader.GetString
        If moDataReader.IsDBNull(i) Then
            Return ""
        Else
            Return moDataReader.GetString(i)
        End If
    End Function

    ''' <summary>
    ''' Gets a string value from the datareader.
    ''' </summary>
    ''' <remarks>
    ''' Returns "" for null.
    ''' </remarks>
    Public Function GetString(ByVal Name As String) As String
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetString(miIndex)
    End Function

    ''' <summary>
    ''' Gets a value of type <see cref="System.Object" /> from the datareader.
    ''' </summary>
    ''' <remarks>
    ''' Returns Nothing for null.
    ''' </remarks>
    Public Function GetValue(ByVal i As Integer) As Object Implements IDataReader.GetValue
        If moDataReader.IsDBNull(i) Then
            Return Nothing
        Else
            Return moDataReader.GetValue(i)
        End If
    End Function

    ''' <summary>
    ''' Gets a value of type <see cref="System.Object" /> from the datareader.
    ''' </summary>
    ''' <remarks>
    ''' Returns Nothing for null.
    ''' </remarks>
    Public Function GetValue(ByVal Name As String) As Object
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetValue(miIndex)
    End Function

    ''' <summary>
    ''' Gets an integer from the datareader.
    ''' </summary>
    ''' <remarks>
    ''' Returns 0 for null.
    ''' </remarks>
    Public Function GetInt32(ByVal i As Integer) As Integer Implements IDataReader.GetInt32
        If moDataReader.IsDBNull(i) Then
            Return 0
        Else
            Try
                Return moDataReader.GetInt32(i)
            Catch icex As System.InvalidCastException
                Return moDataReader.GetInt16(i)
            End Try
        End If
    End Function

    ''' <summary>
    ''' Gets an integer from the datareader.
    ''' </summary>
    ''' <remarks>
    ''' Returns 0 for null.
    ''' </remarks>
    Public Function GetInt32(ByVal Name As String) As Integer
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetInt32(miIndex)
    End Function

    ''' <summary>
    ''' Gets a double from the datareader.
    ''' </summary>
    ''' <remarks>
    ''' Returns 0 for null.
    ''' </remarks>
    Public Function GetDouble(ByVal i As Integer) As Double Implements IDataReader.GetDouble
        If moDataReader.IsDBNull(i) Then
            Return 0
        Else
            Return moDataReader.GetDouble(i)
        End If
    End Function

    ''' <summary>
    ''' Gets a double from the datareader.
    ''' </summary>
    ''' <remarks>
    ''' Returns 0 for null.
    ''' </remarks>
    Public Function GetDouble(ByVal Name As String) As Double
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetDouble(miIndex)
    End Function

    ''' <summary>
    ''' Gets a Guid value from the datareader.
    ''' </summary>
    Public Function GetGuid(ByVal i As Integer) As Guid Implements IDataReader.GetGuid

        '-- It does no good to try to create/convert the GUID to an UPPER CASE STRING; 
        '-- the internal storage of the GUID is lower case

        Dim oGuidString As String
        Dim oValue As Object
        Dim oGuid As Guid

        If moDataReader.IsDBNull(i) Then
            Return Guid.Empty
        Else
            oValue = moDataReader.GetValue(i)
            If TypeOf oValue Is String Then
                oGuidString = moDataReader.GetString(i).Trim
                If (oGuidString.Length <> 36) Then
                    oGuid = New Guid("00000000-0000-0000-0000-000000000000")
                Else
                    oGuid = New Guid(oGuidString)
                End If
                Return oGuid
            Else
                Return moDataReader.GetGuid(i)
            End If
        End If

    End Function

    ''' <summary>
    ''' Gets a Guid value from the datareader.
    ''' </summary>
    Public Function GetGuid(ByVal Name As String) As Guid
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetGuid(miIndex)
    End Function

    ''' <summary>
    ''' Reads the next row of data from the datareader.
    ''' </summary>
    Public Function Read() As Boolean Implements IDataReader.Read
        Return moDataReader.Read
    End Function

    ''' <summary>
    ''' Moves to the next result set in the datareader.
    ''' </summary>
    Public Function NextResult() As Boolean Implements IDataReader.NextResult
        Return moDataReader.NextResult()
    End Function

    ''' <summary>
    ''' Closes the datareader.
    ''' </summary>
    Public Sub Close() Implements IDataReader.Close
        moDataReader.Close()
    End Sub

    ''' <summary>
    ''' Returns the depth property value from the datareader.
    ''' </summary>
    Public ReadOnly Property Depth() As Integer Implements System.Data.IDataReader.Depth
        Get
            Return moDataReader.Depth
        End Get
    End Property

    ''' <summary>
    ''' Returns the FieldCount property from the datareader.
    ''' </summary>
    Public ReadOnly Property FieldCount() As Integer Implements System.Data.IDataReader.FieldCount
        Get
            Return moDataReader.FieldCount
        End Get
    End Property

    ''' <summary>
    ''' Gets a boolean value from the datareader.
    ''' </summary>
    Public Function GetBoolean(ByVal i As Integer) As Boolean Implements System.Data.IDataReader.GetBoolean
        If moDataReader.IsDBNull(i) Then
            Return False
        Else
            Return moDataReader.GetBoolean(i)
        End If
    End Function

    ''' <summary>
    ''' Gets a boolean value from the datareader.
    ''' </summary>
    Public Function GetBoolean(ByVal Name As String) As Boolean
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetBoolean(miIndex)
    End Function

    ''' <summary>
    ''' Gets a boolean string value [Y|N] from the datareader.
    ''' </summary>
    Public Function GetBooleanString(ByVal i As Integer) As Boolean
        If moDataReader.IsDBNull(i) Then
            Return False
        Else
            Return System.Convert.ToBoolean(IIf((String.Compare(moDataReader.GetString(i).Trim, "Y", True) = 0), True, False))
        End If
    End Function

    ''' <summary>
    ''' Gets a boolean string value [Y|N] from the datareader.
    ''' </summary>
    Public Function GetBooleanString(ByVal Name As String) As Boolean
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetBooleanString(miIndex)
    End Function

    ''' <summary>
    ''' Gets a byte value from the datareader.
    ''' </summary>
    Public Function GetByte(ByVal i As Integer) As Byte Implements System.Data.IDataReader.GetByte
        If moDataReader.IsDBNull(i) Then
            Return 0
        Else
            Return moDataReader.GetByte(i)
        End If
    End Function

    ''' <summary>
    ''' Gets a byte value from the datareader.
    ''' </summary>
    Public Function GetByte(ByVal Name As String) As Byte
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetByte(miIndex)
    End Function

    ''' <summary>
    ''' Invokes the GetBytes method of the underlying datareader.
    ''' </summary>
    Public Function GetBytes(ByVal i As Integer, ByVal fieldOffset As Long, ByVal buffer() As Byte, ByVal bufferoffset As Integer, ByVal length As Integer) As Long Implements System.Data.IDataReader.GetBytes
        If moDataReader.IsDBNull(i) Then
            Return 0
        Else
            Return moDataReader.GetBytes(i, fieldOffset, buffer, bufferoffset, length)
        End If
    End Function

    ''' <summary>
    ''' Invokes the GetBytes method of the underlying datareader.
    ''' </summary>
    Public Function GetBytes(ByVal Name As String, ByVal fieldOffset As Long, ByVal buffer() As Byte, ByVal bufferoffset As Integer, ByVal length As Integer) As Long
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetBytes(miIndex, fieldOffset, buffer, bufferoffset, length)
    End Function

    ''' <summary>
    ''' Gets the number of bytes in a byte array using the GetBytes method of the underlying datareader.
    ''' </summary>
    Public Function GetByteCount(ByVal i As Integer) As Int32
        If moDataReader.IsDBNull(i) Then
            Return 0
        Else
            Return Convert.ToInt32(moDataReader.GetBytes(i, 0, Nothing, 0, Int32.MaxValue))
        End If
    End Function

    ''' <summary>
    ''' Gets the number of bytes in a byte array using the GetBytes method of the underlying datareader.
    ''' </summary>
    Public Function GetByteCount(ByVal Name As String) As Int32
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetByteCount(miIndex)
    End Function

    ''' <summary>
    ''' Gets a char value from the datareader.
    ''' </summary>
    Public Function GetChar(ByVal i As Integer) As Char Implements System.Data.IDataReader.GetChar
        If moDataReader.IsDBNull(i) Then
            Return Char.MinValue
        Else
            Return moDataReader.GetChar(i)
        End If
    End Function

    ''' <summary>
    ''' Gets a char value from the datareader.
    ''' </summary>
    Public Function GetChar(ByVal Name As String) As Char
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetChar(miIndex)
    End Function

    ''' <summary>
    ''' Invokes the GetChars method of the underlying datareader.
    ''' </summary>
    Public Function GetChars(ByVal i As Integer, ByVal fieldoffset As Long, ByVal buffer() As Char, ByVal bufferoffset As Integer, ByVal length As Integer) As Long Implements System.Data.IDataReader.GetChars
        If moDataReader.IsDBNull(i) Then
            Return 0
        Else
            Return moDataReader.GetChars(i, fieldoffset, buffer, bufferoffset, length)
        End If
    End Function

    ''' <summary>
    ''' Invokes the GetChars method of the underlying datareader.
    ''' </summary>
    Public Function GetChars(ByVal Name As String, ByVal fieldoffset As Long, ByVal buffer() As Char, ByVal bufferoffset As Integer, ByVal length As Integer) As Long
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetChars(miIndex, fieldoffset, buffer, bufferoffset, length)
    End Function

    ''' <summary>
    ''' Invokes the GetData method of the underlying datareader.
    ''' </summary>
    Public Function GetData(ByVal i As Integer) As System.Data.IDataReader Implements System.Data.IDataReader.GetData
        Return moDataReader.GetData(i)
    End Function

    ''' <summary>
    ''' Invokes the GetData method of the underlying datareader.
    ''' </summary>
    Public Function GetData(ByVal Name As String) As System.Data.IDataReader
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetData(miIndex)
    End Function

    ''' <summary>
    ''' Invokes the GetDataTypeName method of the underlying datareader.
    ''' </summary>
    Public Function GetDataTypeName(ByVal i As Integer) As String Implements System.Data.IDataReader.GetDataTypeName
        Return moDataReader.GetDataTypeName(i)
    End Function

    ''' <summary>
    ''' Invokes the GetDataTypeName method of the underlying datareader.
    ''' </summary>
    Public Function GetDataTypeName(ByVal Name As String) As String
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetDataTypeName(miIndex)
    End Function

    ''' <summary>
    ''' Gets a date value from the datareader.
    ''' </summary>
    Public Function GetDateTime(ByVal i As Integer) As Date Implements System.Data.IDataReader.GetDateTime
        If moDataReader.IsDBNull(i) Then
            Return Date.MinValue
        Else
            Return moDataReader.GetDateTime(i)
        End If
    End Function

    ''' <summary>
    ''' Gets a date value from the datareader.
    ''' </summary>
    Public Function GetDateTime(ByVal Name As String) As Date
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetDateTime(miIndex)
    End Function

    ''' <summary>
    ''' Gets a decimal value from the datareader.
    ''' </summary>
    Public Function GetDecimal(ByVal i As Integer) As Decimal Implements System.Data.IDataReader.GetDecimal
        If moDataReader.IsDBNull(i) Then
            Return 0
        Else
            Return moDataReader.GetDecimal(i)
        End If
    End Function

    ''' <summary>
    ''' Gets a decimal value from the datareader.
    ''' </summary>
    Public Function GetDecimal(ByVal Name As String) As Decimal
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetDecimal(miIndex)
    End Function

    ''' <summary>
    ''' Invokes the GetFieldType method of the underlying datareader.
    ''' </summary>
    Public Function GetFieldType(ByVal i As Integer) As System.Type Implements System.Data.IDataReader.GetFieldType
        Return moDataReader.GetFieldType(i)
    End Function

    ''' <summary>
    ''' Invokes the GetFieldType method of the underlying datareader.
    ''' </summary>
    Public Function GetFieldType(ByVal Name As String) As System.Type
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetFieldType(miIndex)
    End Function

    ''' <summary>
    ''' Gets a Single value from the datareader.
    ''' </summary>
    Public Function GetFloat(ByVal i As Integer) As Single Implements System.Data.IDataReader.GetFloat
        If moDataReader.IsDBNull(i) Then
            Return 0
        Else
            Return moDataReader.GetFloat(i)
        End If
    End Function

    ''' <summary>
    ''' Gets a Single value from the datareader.
    ''' </summary>
    Public Function GetFloat(ByVal Name As String) As Single
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetFloat(miIndex)
    End Function

    ''' <summary>
    ''' Gets a Short value from the datareader.
    ''' </summary>
    Public Function GetInt16(ByVal i As Integer) As Short Implements System.Data.IDataReader.GetInt16
        If moDataReader.IsDBNull(i) Then
            Return 0
        Else
            Return moDataReader.GetInt16(i)
        End If
    End Function

    ''' <summary>
    ''' Gets a Short value from the datareader.
    ''' </summary>
    Public Function GetInt16(ByVal Name As String) As Short
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetInt16(miIndex)
    End Function

    ''' <summary>
    ''' Gets a Long value from the datareader.
    ''' </summary>
    Public Function GetInt64(ByVal i As Integer) As Long Implements System.Data.IDataReader.GetInt64
        If moDataReader.IsDBNull(i) Then
            Return 0
        Else
            Return moDataReader.GetInt64(i)
        End If
    End Function

    ''' <summary>
    ''' Gets a Long value from the datareader.
    ''' </summary>
    Public Function GetInt64(ByVal Name As String) As Long
        miIndex = Me.GetOrdinal(Name)
        Return Me.GetInt64(miIndex)
    End Function

    ''' <summary>
    ''' Invokes the GetName method of the underlying datareader.
    ''' </summary>
    Public Function GetName(ByVal i As Integer) As String Implements System.Data.IDataReader.GetName
        Return moDataReader.GetName(i)
    End Function

    ''' <summary>
    ''' Gets an ordinal value from the datareader.
    ''' </summary>
    Public Function GetOrdinal(ByVal name As String) As Integer Implements System.Data.IDataReader.GetOrdinal
        Return moDataReader.GetOrdinal(name)
    End Function

    ''' <summary>
    ''' Invokes the GetSchemaTable method of the underlying datareader.
    ''' </summary>
    Public Function GetSchemaTable() As System.Data.DataTable Implements System.Data.IDataReader.GetSchemaTable
        Return moDataReader.GetSchemaTable
    End Function

    ''' <summary>
    ''' Invokes the GetValues method of the underlying datareader.
    ''' </summary>
    Public Function GetValues(ByVal values() As Object) As Integer Implements System.Data.IDataReader.GetValues
        Return moDataReader.GetValues(values)
    End Function

    ''' <summary>
    ''' Returns the IsClosed property value from the datareader.
    ''' </summary>
    Public ReadOnly Property IsClosed() As Boolean Implements System.Data.IDataReader.IsClosed
        Get
            Return moDataReader.IsClosed
        End Get
    End Property

    ''' <summary>
    ''' Invokes the IsDBNull method of the underlying datareader.
    ''' </summary>
    Public Function IsDBNull(ByVal i As Integer) As Boolean Implements System.Data.IDataReader.IsDBNull
        Return moDataReader.IsDBNull(i)
    End Function

    ''' <summary>
    ''' Invokes the IsDBNull method of the underlying datareader.
    ''' </summary>
    Public Function IsDBNull(ByVal Name As String) As Boolean
        miIndex = Me.GetOrdinal(Name)
        Return Me.IsDBNull(miIndex)
    End Function

    ''' <summary>
    ''' Returns a value from the datareader.
    ''' </summary>
    ''' <remarks>
    ''' Returns Nothing if the value is null.
    ''' </remarks>
    Default Public Overloads ReadOnly Property Item(ByVal name As String) As Object Implements System.Data.IDataReader.Item
        Get
            Dim value As Object = moDataReader.Item(name)
            If DBNull.Value.Equals(value) Then
                Return Nothing
            Else
                Return value
            End If
        End Get
    End Property

    ''' <summary>
    ''' Returns a value from the datareader.
    ''' </summary>
    ''' <remarks>
    ''' Returns Nothing if the value is null.
    ''' </remarks>
    Default Public Overloads ReadOnly Property Item(ByVal i As Integer) As Object Implements System.Data.IDataReader.Item
        Get
            If moDataReader.IsDBNull(i) Then
                Return Nothing
            Else
                Return moDataReader.Item(i)
            End If
        End Get
    End Property

    ''' <summary>
    ''' Returns the RecordsAffected property value from the underlying datareader.
    ''' </summary>
    Public ReadOnly Property RecordsAffected() As Integer Implements System.Data.IDataReader.RecordsAffected
        Get
            Return moDataReader.RecordsAffected
        End Get
    End Property

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
                moDataReader.Dispose()
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

End Class
