Public Class VisualHelpFunctions
    Shared Function OverlayObjects(ByRef child, ByRef parent, ByRef form)

        child.Parent = parent
        child.Location = parent.PointToClient(form.PointToScreen(child.Location))

        Return 0
    End Function
End Class
