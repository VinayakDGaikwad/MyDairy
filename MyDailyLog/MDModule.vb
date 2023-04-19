Module MDModule

    Function GetConnectionString()
        Dim sdf As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() _
                                                & "\MDL_Data\UserData_DB.Accdb;Persist Security Info=False;Jet OLEDB:Database Password =" + _
                                                "12*#&%*&#%*(#^%(jjBKLHBYILWAdbnas bchyGYWt7wq&$*^%&EBfdhb63295362"
        Return sdf

    End Function

End Module
