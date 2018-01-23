Imports System.Data.SqlClient
Public Class Byroll
    Dim constr As String = ""  'enter the db source here
    Dim con As New SqlConnection(constr)
    Dim adp As New SqlDataAdapter
    Dim reader As SqlDataReader
    Dim dset As New DataSet
    Dim cmd As New SqlCommand
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGrid1.Hide()

        txtempid.Text = ""
        txtempid.Select()

    End Sub

    Private Sub byempid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGrid1.Hide()
        txtempid.Select()

    End Sub


    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Open()
        cmd.Connection = con
        adp = New SqlDataAdapter("select * from member where RollNum='" & txtempid.Text & " ' ", con)
        'reader = cmd.ExecuteReader
        If reader.HasRows = False Then

            reader.Close()
            MsgBox("No Such Roll Number Exists !", MsgBoxStyle.Critical, "Error")
            txtempid.Text = ""
            txtempid.Select()
            con.Close()
            Exit Sub
        End If
        con.Open()
        reader.Close()

        adp = New SqlDataAdapter("select * from member where RollNum=' " & txtempid.Text & " ' ", con)
        dset.Clear()
        adp.Fill(dset, "member")
        con.Close()
        DataGrid1.Show()
        DataGrid1.DataSource = dset.Tables("member")

    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub
End Class
