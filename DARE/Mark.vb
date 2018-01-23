Imports System.Data.SqlClient
Public Class Mark
    Dim constr As String = "server=(local);uid=sa;pwd=sa;database=BEARS"
    Dim con As New SqlConnection(constr)
    Dim adp As New SqlDataAdapter
    Dim reader As SqlDataReader
    Dim dset As New DataSet
    Dim cmd As New SqlCommand
    Dim serialkey As String
    Dim i As String
    Dim res As Label
    Dim count As Integer
    Dim lab1 As Label









    Private Sub Manual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear.Enabled = False
        mark.Enabled = False
        'edit.Enabled = False
        txtempid.Enabled = False
        combo1.Enabled = False
        combo2.Enabled = False
        go.Enabled = False
        txtdates.Select()

        clearall()
        txtempid.Select()


    End Sub

    Public Sub clearall()
        txtempid.Text = ""
        txtname1.Text = ""
        txtname2.Text = ""
        txtdepname.Text = ""
        txtdepid.Text = ""
        combo1.Text = ""
        combo2.Text = ""

    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        clearall()
        'edit.Enabled = False
        mark.Enabled = False

        txtempid.Select()


    End Sub

    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from Members where EmpID='" & txtempid.Text & " ' "
        reader = cmd.ExecuteReader
        If reader.HasRows = False Then

            reader.Close()
            MsgBox("No Such Record Exists !", MsgBoxStyle.Critical, "Error")
            txtempid.Text = ""
            txtempid.Select()
            con.Close()
            'edit.Enabled = True



        Else
            reader.Close()
            adp = New SqlDataAdapter("select * from Members where EmpID=' " & txtempid.Text & " ' ", con)
            dset.Clear()
            adp.Fill(dset, "Members")
            con.Close()
            txtname1.Text = dset.Tables("Members").Rows(0).Item(1)
            txtname2.Text = dset.Tables("Members").Rows(0).Item(2)
            txtdepname.Text = dset.Tables("Members").Rows(0).Item(5)
            txtdepid.Text = dset.Tables("Members").Rows(0).Item(6)
            combo1.Text = "Present"
            combo2.Text = "1"
            ' edit.Enabled = True
            clear.Enabled = True
            mark.Enabled = True




        End If

    End Sub

    Private Sub exitbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbutton.Click
        Me.Close()

    End Sub

    Private Sub mark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mark.Click
        If txtempid.Text = "" Then
            MsgBox("Enter Any Employee ID", MsgBoxStyle.Exclamation, "Error")
            txtempid.Text = ""
            txtempid.Select()
        Else
            con.Close()


            con.Open()
            cmd.CommandText = "update Attendance set EmpID='" & txtempid.Text & "',RecordNo='" & txtempid.Text & "',FirstName='" & txtname1.Text & "',LastName='" & txtname2.Text & "',Dates='" & txtdates.Text & "',DateTimeValue='" & DateTimePicker1.Value & "',Attendance_Type='" & combo1.Text & "',Attendance_Value='" & combo2.Text & "' where EmpID='" & txtempid.Text & "' and Dates='" & txtdates.Text & "' "
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Attendance Marked !")


            clearall()
            txtempid.Select()


        End If


    End Sub



    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        count = 1
        con.Close()
        con.Open()
        cmd.Connection = con
        adp = New SqlDataAdapter("select serial from password ", con)
        dset.Clear()
        adp.Fill(dset, "Password")
        con.Close()
        serialkey = dset.Tables("Password").Rows(0).Item(0)

        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select * from Attendance where Dates='" & txtdates.Text & "'"
        reader = cmd.ExecuteReader
        If (reader.HasRows) Then
            MsgBox("Attendance Records For This Date Already Exist ! Goto Edit Attendance Option in HOME Menu To Change Attendance.", MsgBoxStyle.Information, "Attention")
            txtdates.Text = ""
        Else



lab1:
            If (count <= serialkey) Then
                con.Close()

                con.Open()
                cmd.Connection = con
                cmd.CommandText = "select EmpID from Members where Serial='" & count & "'"
                reader = cmd.ExecuteReader()
                If reader.HasRows = True Then
                    reader.Close()
                    adp = New SqlDataAdapter("select EmpID,FirstName,LastName from Members where Serial='" & count & "'", con)
                    dset.Clear()
                    adp.Fill(dset, "Members")
                    txtempid.Text = dset.Tables("Members").Rows(0).Item(0)
                    txtfirst.Text = dset.Tables("Members").Rows(0).Item(1)
                    txtlast.Text = dset.Tables("Members").Rows(0).Item(2)
                    con.Close()

                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "insert into Attendance values('" & txtempid.Text & "','" & txtempid.Text & "','" & txtfirst.Text & "','" & txtlast.Text & "','" & txtdates.Text & "','" & DateTimePicker1.Value & "','Absent','0')"
                    cmd.ExecuteNonQuery()
                    con.Close()
                    txtempid.Text = ""
                    txtfirst.Text = ""
                    txtlast.Text = ""

                    count = count + 1
                    GoTo lab1

                ElseIf reader.HasRows = False Then
                    reader.Close()
                    con.Close()
                    count = count + 1
                    GoTo lab1

                End If
            Else


                txtdates.Enabled = False

                clear.Enabled = False
                mark.Enabled = False
                txtempid.Enabled = True
                combo1.Enabled = True
                combo2.Enabled = True
                go.Enabled = True
                txtempid.Select()
            End If

        End If


    End Sub


End Class
