Imports System.Data.SqlClient
Public Class Newmembers
    Dim constr As String = "Data Source=TAMSEEL-PC;Initial Catalog=DARE;Integrated Security=True"
    Dim con As New SqlConnection(constr)
    Dim adp As New SqlDataAdapter
    Dim reader As SqlDataReader
    Dim dset As New DataSet
    Dim cmd As New SqlCommand
    Dim txtdob As String
    Dim txtdoa As String
    Dim day1, days1, mon1, mons1, year1, years1 As String
    Dim day2, days2, mon2, mons2, year2, years2 As String
    Dim serialkey, incserial As String

    Private Sub Members_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AllClear()


    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        day1 = dd1.Text
        days1 = day1.ToString()
        mon1 = mm1.Text
        mons1 = mon1.ToString()
        year1 = yyyy1.Text
        years1 = year1.ToString()
        txtdoa = days1 & mons1 & years1

        day2 = dd2.Text
        days2 = day2.ToString()
        mon2 = mm2.Text
        mons2 = mon2.ToString()
        year2 = yyyy2.Text
        years2 = year2.ToString()
        txtdoa = days2 & mons2 & years2

        con.Close()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from Member where RollNum='" & txtrollnum.Text & " ' "
        reader = cmd.ExecuteReader
        If reader.HasRows = True Then
            reader.Close()
            MsgBox("Roll Number Already Exists !", MsgBoxStyle.Critical, "Error")
            txtrollnum.Text = ""
            txtrollnum.Select()
            con.Close()
        Else

            If txtrollnum.Text = "" Or txtdept.Text = "" Or txtdeptid.Text = "" Or txtfirst.Text = "" Or txtlast.Text = "" Or txtdoa = "" Then

                MsgBox("Fill All Compulsory Fields")
            Else
                con.Close()
                con.Open()
                cmd.CommandText = "insert into Member values('" & txtrollnum.Text & "','" & txtdept.Text & "','" & txtdeptid.Text & "','" & txtfirst.Text & "','" & txtmid.Text & "','" & txtlast.Text & "','" & txtfather.Text & "','" & txtmother.Text & "','" & txtlocal.Text & "','" & txtperm.Text & "','" & txtmob.Text & "','" & txtemail.Text & " ',' " & txtdoa & "','" & txtdoa & " ','" & txtnote.Text & "') "
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Student's Record Saved")
                AllClear()


            End If
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        AllClear()
    End Sub
    Public Sub AllClear()
        txtrollnum.Text = ""
        txtdept.Text = ""
        txtdeptid.Text = ""
        txtfirst.Text = ""
        txtmid.Text = ""
        txtlast.Text = ""
        txtfather.Text = ""
        txtmother.Text = ""
        txtlocal.Text = ""
        txtperm.Text = ""
        txtmob.Text = ""

        dd1.Text = ""
        mm1.Text = ""
        yyyy1.Text = ""
        dd2.Text = ""
        mm2.Text = ""
        yyyy2.Text = ""
        txtemail.Text = ""

        txtnote.Text = ""


    End Sub

    
    

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Hide()


    End Sub

End Class