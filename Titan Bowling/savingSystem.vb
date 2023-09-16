Imports System.IO
Imports Titan_Bowling.PlayingForm

Public Class SavingSystem

    Public Shared CurrentActiveSave As String = "1"

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
    Public a, b, c, d As String

    Public aA, bA, cA, dA As String()

    Public progress As Integer
    Public Function isSetup()
        Return aA.Length > 0 Or bA.Length > 0 Or cA.Length > 0 Or dA.Length > 0
    End Function
End Structure