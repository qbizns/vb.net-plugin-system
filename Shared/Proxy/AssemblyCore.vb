Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports System.Reflection

Namespace Salling
    Public Class AssemblyCore
        ''' <summary>
        ''' Returns the Filename that is originaly refered by the application.
        ''' </summary>
        Const OriginalAssemblyFileName As String = "Plugins\DefaultAssembly.dll"

        Private _activeAssemblyFile As String
        ''' <summary>
        ''' Gets the Original name of assembly file that is currenlty used as DefaultAssemblyFile
        ''' </summary>
        Public ReadOnly Property ActiveAssemblyFile() As String
            Get
                Return _activeAssemblyFile
            End Get
        End Property


        Private _CurrentType As String
        ' Gets the currently used type
        Public Property CurrentType() As String
            Get
                Return _CurrentType
            End Get
            Set(value As String)
                _CurrentType = value
            End Set
        End Property
        ''' <summary>
        ''' returns the currently Active Assembly File. The name will be same but 
        ''' the file will different and if we create an .Net Assembly Reference from this 
        ''' it will be different.
        ''' </summary>
        Public ReadOnly Property DefaultAssemblyFileName() As String
            Get
                Return OriginalAssemblyFileName
            End Get
        End Property

        Private _DefaultAssemblyFile As FileInfo
        ''' <summary>
        ''' Returns the currently Active Assembly File's FileInfo Object.
        ''' </summary>
        Public ReadOnly Property DefaultAssemblyFile() As FileInfo
            Get
                Return _DefaultAssemblyFile
            End Get
        End Property


        Public Sub New(AssemblyFileName As String, TypeName As String)
            CurrentType = TypeName
            SetDefaultAssemblyFile(AssemblyFileName)
        End Sub

        ''' <summary>
        ''' Sets a reference to the Specified Assembly file. 
        ''' File Should be in Bin folder of the application. If not, it should be an absolute path
        ''' </summary>
        ''' <param name="AssemblyFileName">Name of Assembly file without FilePath</param>
        ''' <returns></returns>
        Public Function SetDefaultAssemblyFile(AssemblyFileName As String) As Boolean
            Try
                'saves the original file name.
                _activeAssemblyFile = AssemblyFileName
                File.Copy(AssemblyFileName, OriginalAssemblyFileName, True)
                _DefaultAssemblyFile = New FileInfo(AssemblyFileName)
                Return True
            Catch Err As Exception
                MsgBox("An Error Occured. Versioning Failed. Details : " + Err.Message)
                Return False
            End Try
        End Function
    End Class
End Namespace