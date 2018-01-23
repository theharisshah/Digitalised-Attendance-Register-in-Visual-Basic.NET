Imports System.Data.SqlClient
Public Class showall
    Dim constr As String = "Data Source=TAMSEEL-PC;Initial Catalog=DARE;Integrated Security=True"
    Dim con As New SqlConnection(constr)
    Dim adp As New SqlDataAdapter
    Dim reader As SqlDataReader
    Dim dset As New DataSet
    Dim cmd As New SqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub showall_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DataGrid1.Hide()
        con.Open()
        cmd.Connection = con
        adp = New SqlDataAdapter("select * from Member", con)
        dset.Clear()
        adp.Fill(dset, "Member")
        con.Close()
        DataGrid1.Show()
        DataGrid1.DataSource = dset.Tables("Member")

    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub
End Class