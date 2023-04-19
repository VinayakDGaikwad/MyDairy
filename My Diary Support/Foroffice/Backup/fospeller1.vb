Module fospellmod1
    Public Sub docheck(ByVal word As String)
        If word = "apple" Then
            foform1.DefInstance.stpanel1.Visible = True
            foform1.DefInstance.dostag1menu("apple")
            Exit Sub
        End If

        If word = "man" Then

        End If
        foform1.DefInstance.stpanel1.Visible = False
    End Sub

End Module
