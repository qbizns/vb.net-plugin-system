Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports Salling.Core
Imports Microsoft.Win32

Namespace Salling.Configs
    ''' <summary>
    ''' this class can be used for save/load configorations by 
    ''' an XML file
    ''' </summary>
    'Public Class XMLConfig
    '    Inherits Dictionary(Of String, Object)
    '    Implements IConfigoration

    '    Public Sub Save(ParamArray Parameters As Object()) Implements IConfigoration.Save
    '        Dim dt As New DataTable("Configoration")
    '        dt.Columns.Add("Key", GetType(String))
    '        dt.Columns.Add("Value", GetType(Object))

    '        Dim keys__1 As String() = Keys.ToArray(Of String)()
    '        Dim values__2 As Object() = Values.ToArray(Of Object)()
    '        For i As Integer = 0 To Count - 1
    '            dt.Rows.Add(keys__1(i), values__2(i))
    '        Next
    '        dt.WriteXml(Parameters(0).ToString(), True)
    '    End Sub

    '    Public Sub Load(ParamArray Parameters As Object()) Implements IConfigoration.Load
    '        Dim dt As New DataTable("Configoration")
    '        dt.Columns.Add("Key", GetType(String))
    '        dt.Columns.Add("Value", GetType(Object))
    '        dt.ReadXml(Parameters(0).ToString())
    '        Clear()
    '        For Each row As DataRow In dt.Rows
    '            Me(row(0).ToString()) = row(1)
    '        Next

    '    End Sub

    '    Public Function Exist(Key As String) As Boolean Implements IConfigoration.Exist

    '    End Function

    '    Public Sub Add1(item As KeyValuePair(Of String, Object)) Implements ICollection(Of KeyValuePair(Of String, Object)).Add

    '    End Sub

    '    Public Sub Clear1() Implements ICollection(Of KeyValuePair(Of String, Object)).Clear

    '    End Sub

    '    Public Function Contains(item As KeyValuePair(Of String, Object)) As Boolean Implements ICollection(Of KeyValuePair(Of String, Object)).Contains

    '    End Function

    '    Public Sub CopyTo(array() As KeyValuePair(Of String, Object), arrayIndex As Integer) Implements ICollection(Of KeyValuePair(Of String, Object)).CopyTo

    '    End Sub

    '    Public ReadOnly Property Count1 As Integer Implements ICollection(Of KeyValuePair(Of String, Object)).Count
    '        Get

    '        End Get
    '    End Property

    '    Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of KeyValuePair(Of String, Object)).IsReadOnly
    '        Get

    '        End Get
    '    End Property

    '    Public Function Remove1(item As KeyValuePair(Of String, Object)) As Boolean Implements ICollection(Of KeyValuePair(Of String, Object)).Remove

    '    End Function

    '    Public Sub Add2(key As String, value As Object) Implements IDictionary(Of String, Object).Add

    '    End Sub

    '    Public Function ContainsKey1(key As String) As Boolean Implements IDictionary(Of String, Object).ContainsKey

    '    End Function

    '    Default Public Property Item1(key As String) As Object Implements IDictionary(Of String, Object).Item
    '        Get

    '        End Get
    '        Set(value As Object)

    '        End Set
    '    End Property

    '    Public ReadOnly Property Keys1 As ICollection(Of String) Implements IDictionary(Of String, Object).Keys
    '        Get

    '        End Get
    '    End Property

    '    Public Function Remove2(key As String) As Boolean Implements IDictionary(Of String, Object).Remove

    '    End Function

    '    Public Function TryGetValue1(key As String, ByRef value As Object) As Boolean Implements IDictionary(Of String, Object).TryGetValue

    '    End Function

    '    Public ReadOnly Property Values1 As ICollection(Of Object) Implements IDictionary(Of String, Object).Values
    '        Get

    '        End Get
    '    End Property

    '    Public Function GetEnumerator1() As IEnumerator(Of KeyValuePair(Of String, Object)) Implements IEnumerable(Of KeyValuePair(Of String, Object)).GetEnumerator

    '    End Function
    'End Class
    ' ''' <summary>
    ''' this class can be used for save/load configorations by
    ''' win registry
    ''' </summary>
    'Public Class RegistryConfig
    '    Inherits Dictionary(Of String, Object)
    '    Implements IConfigoration

    '    Public Sub Save(ParamArray Parameters As Object()) Implements IConfigoration.Save
    '        Dim main As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
    '        main = main.OpenSubKey("Zagros", True)
    '        If main Is Nothing Then
    '            main = Registry.LocalMachine.OpenSubKey("SOFTWARE", True).CreateSubKey("Armani")
    '        End If
    '        Dim keys__1 As String() = Keys.ToArray(Of String)()
    '        Dim values__2 As Object() = Values.ToArray(Of Object)()
    '        For i As Integer = 0 To Count - 1
    '            main.SetValue(keys__1(i), values__2(i))
    '        Next
    '        main.Close()
    '    End Sub

    '    Public Sub Load(ParamArray Parameters As Object()) Implements IConfigoration.Load
    '        Dim main As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", False)
    '        main = main.OpenSubKey("Zagros")
    '        If main Is Nothing Then
    '            Return
    '        End If
    '        Dim keys As String() = main.GetValueNames()
    '        For Each key As String In keys
    '            Me(key) = main.GetValue(key)
    '        Next
    '        main.Close()
    '    End Sub

    '    Public Function Exist(Key As String) As Boolean Implements IConfigoration.Exist
    '        Return Me.Keys.ToList(Of String)().Exists(New Predicate(Of String)(Function(s As String) s = Key))
    '    End Function

    'End Class
End Namespace