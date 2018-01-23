Imports System.Data.SqlClient
Public Class bydept
    Dim constr As String = "" 'db-source here
    Dim con As New SqlConnection(constr)
    Dim adp As New SqlDataAdapter
    Dim reader As SqlDataReader
    Dim dset As New DataSet
    Dim cmd As New SqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGrid1.Hide()

        txtdept.Text = ""
        txtdept.Select()

    End Sub

    Private Sub byempid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGrid1.Hide()
        txtdept.Select()

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from Members where Department='" & txtdept.Text & " ' "
        cmd.ExecuteNonQuery()
        reader = cmd.ExecuteReader
        If reader.HasRows = False Then

            reader.Close()
            MsgBox("No Such Department Exists !", MsgBoxStyle.Critical, "Error")
            txtdept.Text = ""
            txtdept.Select()
            con.Close()
            Exit Sub
        End If
        'con.Open()
        reader.Close()
        con.Close()
        con.Open()
        adp = New SqlDataAdapter("select * from Members where Department='" & txtdept.Text & " ' ", con)
        dset.Clear()
        adp.Fill(dset, "Members")
        con.Close()
        DataGrid1.Show()
        DataGrid1.DataSource = dset.Tables("Members")

    End Sub

    
End Class
