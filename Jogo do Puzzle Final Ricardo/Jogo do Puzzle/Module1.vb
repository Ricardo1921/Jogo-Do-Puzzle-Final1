Module Module1
    Sub cblev1(ByRef Button1 As Button, ByRef Button2 As Button)
        If Button2.Text = "" Then
            Button2.Text = Button1.Text
            Button2.BackgroundImage = Button1.BackgroundImage
            Button1.Text = ""
            Button1.BackgroundImage = Nothing
        End If
    End Sub
End Module
