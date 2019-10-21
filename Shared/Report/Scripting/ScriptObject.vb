'Imports BCE.Localization
Imports System.Collections
Imports System.Reflection

Namespace Salling.Report.Scripting
    Public Class ScriptObject
        Private Shared myThrowScriptErrorException As Boolean = True
        Private myScriptName As String
        Private myObjects As ArrayList
        Private myIsScriptError As Boolean

        Public Shared Property ThrowScriptErrorException() As Boolean
            Get
                Return ScriptObject.myThrowScriptErrorException
            End Get
            Set(value As Boolean)
                ScriptObject.myThrowScriptErrorException = value
            End Set
        End Property

        Public ReadOnly Property IsScriptError() As Boolean
            Get
                Return Me.myIsScriptError
            End Get
        End Property

        Public Sub New(scriptName As String, objects As ArrayList, isScriptError As Boolean)
            Me.myScriptName = scriptName
            Me.myObjects = objects
            Me.myIsScriptError = isScriptError
        End Sub

        Public Function GetScriptErrorMessage() As String
            Dim str As String = SupportedScript.GetScriptDescription(Me.myScriptName)
            If str.Length = 0 Then
                str = Me.myScriptName
            End If
            Return Localizer.GetString(DirectCast(ScriptObjectStringId.ScriptErrorNoExecute, [Enum]), DirectCast(str, Object))
        End Function

        Public Function RunMethod(name As String) As Object
            Return Me.RunMethod(name, DirectCast(Nothing, Type()), DirectCast(Nothing, Object()))
        End Function

        Public Function RunMethod(name As String, types As Type(), ParamArray parameters As Object()) As Object
            Return Me.RunMethod(name, True, types, parameters)
        End Function

        Public Function RunMethod(name As String, catchException As Boolean, types As Type(), ParamArray parameters As Object()) As Object
            If name Is Nothing Then
                Throw New ArgumentNullException("name")
            End If
            If types Is Nothing Then
                types = New Type(-1) {}
            End If
            If Me.myIsScriptError AndAlso ScriptObject.myThrowScriptErrorException Then
                Dim str As String = SupportedScript.GetScriptDescription(Me.myScriptName)
                If str.Length = 0 Then
                    str = Me.myScriptName
                End If
                Throw New ScriptException(Localizer.GetString(DirectCast(ScriptObjectStringId.ScriptError, [Enum]), DirectCast(str, Object)))
            End If
            If Me.myObjects Is Nothing Then
                Return DirectCast(Nothing, Object)
            End If
            For index As Integer = 0 To Me.myObjects.Count - 1
                Dim obj1 As Object = Me.myObjects(index)
                Try
                    Dim method As MethodInfo = obj1.[GetType]().GetMethod(name, types)
                    If method <> DirectCast(Nothing, MethodInfo) Then
                        Dim obj2 As Object = method.Invoke(obj1, parameters)
                        If index = Me.myObjects.Count - 1 Then
                            Return obj2
                        End If
                    End If
                Catch ex As TargetInvocationException
                    If catchException Then
                        Throw New ScriptException(Localizer.GetString(DirectCast(ScriptObjectStringId.ExceptionFromScript, [Enum]), DirectCast(Me.myScriptName, Object), DirectCast(name, Object), DirectCast(ex.InnerException.Message, Object)), ex.InnerException)
                    End If
                    Throw ex.InnerException
                End Try
            Next
            Return DirectCast(Nothing, Object)
        End Function
    End Class
End Namespace