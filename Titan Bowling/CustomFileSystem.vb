Public Class CustomFileSystem
    Shared Function ImageFromFile(Directory As String)
        Return Image.FromFile(Application.StartupPath.Replace("\bin\Debug\net6.0-windows\", "\") + Directory)
    End Function

    Shared Function ProjectDirectory()
        Return Application.StartupPath.Replace("\bin\Debug\net6.0-windows\", "\")
    End Function
End Class
