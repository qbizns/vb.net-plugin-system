Imports System.Collections
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Resources
Imports System.Text
Imports System.Threading

Namespace Salling.Localization

    <AttributeUsage(AttributeTargets.[Enum])> _
    Public NotInheritable Class LocalizableStringAttribute
        Inherits Attribute
        Private myBaseName As String

        Public ReadOnly Property BaseName() As String
            Get
                Return Me.myBaseName
            End Get
        End Property

        Public Sub New(baseName As String)
            If baseName Is Nothing Then
                Throw New ArgumentNullException("baseName")
            End If
            Me.myBaseName = baseName
        End Sub

        Public Sub New()
            Me.myBaseName = ""
        End Sub
    End Class

    <AttributeUsage(AttributeTargets.Field)> _
    Public NotInheritable Class DefaultStringAttribute
        Inherits Attribute
        Private myText As String

        Public ReadOnly Property Text() As String
            Get
                Return Me.myText
            End Get
        End Property

        Public Sub New(text As String)
            If text Is Nothing Then
                Throw New ArgumentNullException("text")
            End If
            Me.myText = text
        End Sub
    End Class

    Public NotInheritable Class Localizer
        Private Shared myTable As New Hashtable()

        Private Sub New()
        End Sub

        Public Shared Function GetString(id As [Enum], ParamArray args As Object()) As String
            If id Is Nothing Then
                Throw New ArgumentNullException("id")
            End If
            Dim type As Type = id.[GetType]()
            Dim localizableStringAttribute As LocalizableStringAttribute = TryCast(Attribute.GetCustomAttribute(DirectCast(type, MemberInfo), GetType(LocalizableStringAttribute)), LocalizableStringAttribute)
            If localizableStringAttribute Is Nothing Then
                Throw New ArgumentException("LocalizableStringAttribute was not defined.", "id")
            End If
            Dim str As String = DirectCast(Nothing, String)
            If Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName <> "en" Then
                str = Localizer.GetStringFromResource(type, localizableStringAttribute.BaseName, id.ToString())
            End If
            If str Is Nothing Then
                Dim defaultStringAttribute As DefaultStringAttribute = TryCast(Attribute.GetCustomAttribute(type.GetMember(id.ToString())(0), GetType(DefaultStringAttribute)), DefaultStringAttribute)
                str = If(defaultStringAttribute Is Nothing, String.Empty, defaultStringAttribute.Text)
            End If
            Dim stringBuilder As New StringBuilder()
            Dim index As Integer = 0
            While index < str.Length
                If CInt(AscW(str(index))) = 92 AndAlso index < str.Length - 1 AndAlso CInt(AscW(str(index + 1))) = 92 Then
                    stringBuilder.Append("\"c)
                    index += 2
                ElseIf CInt(AscW(str(index))) = 92 AndAlso index < str.Length - 1 AndAlso CInt(AscW(str(index + 1))) = 110 Then
                    stringBuilder.AppendLine()
                    index += 2
                ElseIf CInt(AscW(str(index))) = 92 AndAlso index < str.Length - 1 AndAlso CInt(AscW(str(index + 1))) = 116 Then
                    stringBuilder.Append(ControlChars.Tab)
                    index += 2
                Else
                    stringBuilder.Append(str(System.Math.Max(System.Threading.Interlocked.Increment(index), index - 1)))
                End If
            End While
            Dim format As String = stringBuilder.ToString()
            If args IsNot Nothing Then
                Return String.Format(format, args)
            End If
            Return format
        End Function

        Private Shared Function GetStringFromResource(type As Type, baseName As String, id As String) As String
            SyncLock Localizer.myTable.SyncRoot
                If Not Localizer.myTable.ContainsKey(DirectCast(type, Object)) Then
                    If baseName.Length = 0 Then
                        baseName = type.Assembly.GetName().Name + ".LocalizationRes"
                    End If
                    Dim local_0 As New ResourceManager(baseName, type.Assembly)
                    Localizer.myTable.Add(DirectCast(type, Object), DirectCast(local_0, Object))
                End If
            End SyncLock
            Dim resourceManager As ResourceManager = DirectCast(Localizer.myTable(DirectCast(type, Object)), ResourceManager)
            If resourceManager Is Nothing Then
                Return DirectCast(Nothing, String)
            End If
            Try
                Return resourceManager.GetString(Convert.ToString(type.FullName + ".") & id)
            Catch ex As MissingManifestResourceException
                Return DirectCast(Nothing, String)
            End Try
        End Function

        Public Shared Function GetEnumStringsWithExclude(type As Type, ParamArray idToExclude As [Enum]()) As String()
            If Not type.IsEnum Then
                Throw New ArgumentException("type is not enum.", "type")
            End If
            Dim list As New List(Of String)()
            Dim localizableStringAttribute As LocalizableStringAttribute = TryCast(Attribute.GetCustomAttribute(DirectCast(type, MemberInfo), GetType(LocalizableStringAttribute)), LocalizableStringAttribute)
            If localizableStringAttribute Is Nothing Then
                Throw New ArgumentException("LocalizableStringAttribute was not defined.", "type")
            End If
            For Each fieldInfo As FieldInfo In type.GetFields()
                If idToExclude IsNot Nothing AndAlso idToExclude.Length > 0 Then
                    Dim flag As Boolean = False
                    For index As Integer = 0 To idToExclude.Length - 1
                        If fieldInfo.Name.Equals(idToExclude(index).ToString()) Then
                            flag = True
                            Exit For
                        End If
                    Next
                    If flag Then
                        Continue For
                    End If
                End If
                Dim defaultStringAttributeArray As DefaultStringAttribute() = TryCast(fieldInfo.GetCustomAttributes(GetType(DefaultStringAttribute), False), DefaultStringAttribute())
                If defaultStringAttributeArray.Length > 0 Then
                    Dim str As String = DirectCast(Nothing, String)
                    If Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName <> "en" Then
                        str = Localizer.GetStringFromResource(type, localizableStringAttribute.BaseName, fieldInfo.Name)
                    End If
                    If str IsNot Nothing Then
                        list.Add(str)
                    Else
                        list.Add(defaultStringAttributeArray(0).Text)
                    End If
                End If
            Next
            Return list.ToArray()
        End Function

        Public Shared Function GetEnumStrings(type As Type) As String()
            Return Localizer.GetEnumStringsWithExclude(type)
        End Function
    End Class
End Namespace