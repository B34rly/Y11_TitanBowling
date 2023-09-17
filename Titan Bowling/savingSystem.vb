Imports System.IO
Imports Titan_Bowling.PlayingForm

Public Class SavingSystem

    Public Shared CurrentActiveSave As String = "1"
    Public Shared theme As Color = Color.FromArgb(1, 32, 76)

    Shared Function Save(s As SaveFile, n As String)
        FileOpen(1, CustomFileSystem.ProjectDirectory + n + ".save", OpenMode.Binary)
        FilePut(1, s)
        FileClose(1)
    End Function
    Shared Function Load(n As String) As SaveFile
        Dim s As SaveFile = New SaveFile()
        If My.Computer.FileSystem.FileExists(CustomFileSystem.ProjectDirectory + n + ".save") Then
            FileOpen(1, CustomFileSystem.ProjectDirectory + n + ".save", OpenMode.Binary)
            FileGet(1, s)
            FileClose(1)
        End If
        Return s
    End Function
    Shared Function DeleteFile(n As String)
        If My.Computer.FileSystem.FileExists(CustomFileSystem.ProjectDirectory + n + ".save") Then
            My.Computer.FileSystem.DeleteFile(CustomFileSystem.ProjectDirectory + n + ".save")
        End If
    End Function
End Class

<Serializable>
Public Structure SaveFile
    Public initialized As Boolean
    Public filled As Boolean
    Public a As String()
    Public b As String()
    Public c As String()
    Public d As String()
End Structure