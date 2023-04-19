Module gsfospl2
    Public Sub forpopup(ByVal forck, ByVal intp)
        'intp --> in taskpane
        'forck--> for check

        Dim ma As TextBox = fodummy.DefInstance.meaning1
        Dim mb As TextBox = fodummy.DefInstance.meaning2
        Dim mc As TextBox = fodummy.DefInstance.grammar
        Dim ts As TextBox = foform1.DefInstance.textsearch
        Dim st As Button = foform1.DefInstance.stag1
        Dim tpword As Label = foform1.DefInstance.word
        Dim tpmean1 As Label = foform1.DefInstance.mean1
        Dim tpmean2 As Label = foform1.DefInstance.mean2
        Dim tpgram As Label = foform1.DefInstance.gram
        Dim tpbut1 As gscore10.gsflatxp = foform1.DefInstance.amean1
        Dim tpbut2 As gscore10.gsflatxp = foform1.DefInstance.amean2
        If intp = True Then
            tpword.Visible = True
            tpmean1.Visible = True
            tpmean2.Visible = True
            tpgram.Visible = True
            tpbut1.Visible = True
            tpbut2.Visible = True
        ElseIf intp = False Then
            tpword.Visible = False
            tpmean1.Visible = False
            tpmean2.Visible = False
            tpgram.Visible = False
            tpbut1.Visible = False
            tpbut2.Visible = False
        End If
        'Started for spell check
        If forck = "good" Then
            ma.Text = "high-quality"
            mb.Text = "decent"
            mc.Text = "grammar : adj."
            st.Visible = True
            If intp = True Then
                tpword.Text = "Good"
                tpmean1.Text = "high-quality"
                tpmean2.Text = "decent"
                tpgram.Text = "grammar : adj."
            End If
            GoTo cleartext
        End If
err:
        ts.Text = ""
        'added at the last of this module
        ma.Text = ""
        mb.Text = ""
        mc.Text = ""
cleartext:
        forck = ""
        Exit Sub
    End Sub
End Module
