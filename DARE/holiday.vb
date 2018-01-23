Imports System.Data.SqlClient
Public Class holiday
    Dim constr As String = "Data Source=saint\haris;Initial Catalog=DARE;Integrated Security=True"
    Dim con As New SqlConnection(constr)
    Dim adp As New SqlDataAdapter
    Dim reader As SqlDataReader
    Dim dset As New DataSet
    Dim cmd As New SqlCommand
    Dim txtholiday As String
    Dim day, days, mon, mons, year, years As String
    Dim count As Integer
    Dim Mark As Label
    Dim serialkey As String
    Dim txtRollNum As Object




    Private Sub holiday_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sure.Visible = False
        yes.Visible = False
        no.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        day = dd.Text
        days = day.ToString()
        mon = mm.Text
        mons = mon.ToString()
        year = yyyy.Text
        years = year.ToString()
        txtholiday = days & mons & years
        If (dd.Text = "" Or mm.Text = "" Or yyyy.Text = "") Then
            MsgBox("Enter a Valid Date !", MsgBoxStyle.Exclamation, "Sorry")
            dd.Text = ""
            mm.Text = ""
            yyyy.Text = ""
            dd.Select()
        Else
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select * from Attendance where Dates='" & txtholiday & " ' "
            reader = cmd.ExecuteReader
            If reader.HasRows = True Then
                reader.Close()
                MsgBox("There Are Some Records For This Date. Kindly Check The DataBase Or Enter A New Date As Holiday !", MsgBoxStyle.Critical, "Error")
                dd.Text = ""
                mm.Text = ""
                yyyy.Text = ""
                con.Close()

            Else
                sure.Visible = True
                yes.Visible = True
                no.Visible = True
                ok.Enabled = False

            End If
        End If

    End Sub

    Private Sub yes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yes.Click

        count = 1
        con.Close()
        con.Open()
        cmd.Connection = con
        adp = New SqlDataAdapter("select serial from password ", con)
        dset.Clear()
        adp.Fill(dset, "Password")
        con.Close()
        serialkey = dset.Tables("Password").Rows(0).Item(0)

Mark:
        If (count <= serialkey) Then
            con.Close()

            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select RollNum from Members where Serial='" & count & "'"
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then
                reader.Close()
                adp = New SqlDataAdapter("select RollNum,FirstName,LastName from Members where Serial='" & count & "'", con)
                dset.Clear()
                adp.Fill(dset, "Members")
                txtRollNum.Text = dset.Tables("Members").Rows(0).Item(0)
                txtfirst.Text = dset.Tables("Members").Rows(0).Item(1)
                txtlast.Text = dset.Tables("Members").Rows(0).Item(2)
                con.Close()

                con.Open()
                cmd.Connection = con
                cmd.CommandText = "insert into Attendance values('" & txtRollNum.Text & "','" & txtRollNum.Text & "','" & txtfirst.Text & "','" & txtlast.Text & "','" & txtholiday & "','" & DateTimePicker1.Value & "','Holiday','H')"
                cmd.ExecuteNonQuery()
                con.Close()
                txtRollNum.Text = ""
                txtfirst.Text = ""
                txtlast.Text = ""

                count = count + 1
                GoTo Mark

            ElseIf reader.HasRows = False Then
                reader.Close()
                con.Close()
                count = count + 1
                GoTo Mark

            End If
        Else
            MsgBox("Holiday Attendance Marked", MsgBoxStyle.Information, "Holiday Marked")
            Me.Close()
        End If





    End Sub

    Private Sub no_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no.Click
        dd.Text = ""
        mm.Text = ""
        yyyy.Text = ""
        con.Close()
        sure.Visible = False
        yes.Visible = False
        no.Visible = False
        ok.Enabled = True
    End Sub

   
    Private Sub txtlast_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlast.TextChanged

    End Sub
End Class