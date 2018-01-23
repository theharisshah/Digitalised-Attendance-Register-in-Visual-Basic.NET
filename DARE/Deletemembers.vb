Imports System.Data.SqlClient
Public Class deletemembers
    Dim constr As String = "" 'enter db-source here
    Dim con As New SqlConnection(constr)
    Dim adp As New SqlDataAdapter
    Dim reader As SqlDataReader
    Dim dset As New DataSet
    Dim cmd As New SqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        labelQuestion.Visible = True
        btnOk.Enabled = False
        btnClear.Enabled = False
        btnYes.Visible = True
        btnNo.Visible = True

        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from Member where RollNum='" & rollnum.Text & " ' "
        reader = cmd.ExecuteReader
        If reader.HasRows = False Then
            labelQuestion.Visible = False
            btnYes.Visible = False
            btnNo.Visible = False
            reader.Close()
            MsgBox("No Such Record Exists !", MsgBoxStyle.Critical, "Error")
            rollnum.Text = ""
            rollnum.Select()
            con.Close()
            btnOk.Enabled = True
            btnClear.Enabled = True
            Exit Sub
        End If
        'con.Open()
        reader.Close()

        adp = New SqlDataAdapter("select * from Member where RollNum=' " & rollnum.Text & " ' ", con)
        dset.Clear()
        adp.Fill(dset, "Member")
        con.Close()
        DataGrid1.Show()
        DataGrid1.DataSource = dset.Tables("Member")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        DataGrid1.Hide()
        rollnum.Text = ""
        rollnum.Select()

    End Sub

    Private Sub deletemembers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGrid1.Hide()
        rollnum.Select()
        labelQuestion.Visible = False
        btnYes.Visible = False
        btnNo.Visible = False


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        DataGrid1.Hide()
        btnYes.Visible = False
        btnNo.Visible = False
        labelQuestion.Visible = False
        rollnum.Text = ""
        rollnum.Select()
        btnOk.Enabled = True
        btnClear.Enabled = True
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        reader.Close()
        con.Open()

        cmd.Connection = con
        cmd.CommandText = "Delete from Member where RollNum=('" & rollnum.Text & " ') "
        MsgBox("Record Deleted", MsgBoxStyle.Information, "DELETED")
        If MsgBoxStyle.Information Then
            cmd.ExecuteNonQuery()
            con.Close()

            labelQuestion.Visible = False
            btnYes.Visible = False
            btnNo.Visible = False
            btnOk.Enabled = True
            btnClear.Enabled = True
            DataGrid1.Hide()
            rollnum.Text = ""
            rollnum.Select()

        Else
            Me.Close()

        End If
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelQuestion.Click

    End Sub
End Class
