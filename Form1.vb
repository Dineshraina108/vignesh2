Imports Oracle.DataAccess.Client
Public Class Form1
    Dim Ora_Con As New OracleConnection
    Dim type As String
    Dim Query As String = String.Empty

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ora_Con.ConnectionString = ("Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false")
        Ora_Con.Open()
        Dim dt As New DataTable

        Query = "select productid,productname,qty from item1 where productid <> '0'"
        Using Cmd As New OracleCommand(Query, Ora_Con)
            Using Ora_Ada As New OracleDataAdapter(Cmd)
                Ora_Ada.Fill(dt)
            End Using

        End Using
        Cboid.DataSource = dt
        Cboid.DisplayMember = "productid"
        Cboid.ValueMember = "productid"
        Cboid.Focus()
        Cboid.DroppedDown = True


    End Sub


    Private Sub txtid_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Focus()
        End If
    End Sub

    Private Sub txtname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbobox.Focus()


            'Cbobox.DataSource = dt
            'Cbobox.DisplayMember = "GENDER"
            'Cbobox.Focus()
            'Cbobox.DroppedDown = True

            Cbobox.Items.Add("GRAM")
            Cbobox.Items.Add("KG")
            Cbobox.Items.Add("LITTRE")

        End If
    End Sub

    Private Sub Cbobox_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbobox.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprice.Focus()
        End If
    End Sub

    Private Sub txtprice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprice.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtgst.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Query As String = String.Empty
        Dim Result As Long = 0
        Query = ("Insert into item1(productid,productname,qty,price,gst) Values ('" & txtid.Text & "','" & txtname.Text & "','" & Cbobox.Text & "','" & txtprice.Text & "','" & txtgst.Text & "')")
        Using Cmd As New OracleCommand(Query, Ora_Con)
            Result = Cmd.ExecuteNonQuery()
        End Using
        If Result > 0 Then
            MsgBox("Save Successful")
            type = ""
        Else
            MsgBox("Failed")
        End If
    End Sub



    Private Sub txtgst_Leave(sender As Object, e As EventArgs) Handles txtgst.Leave

        Try
            txtGstP_Amount.Text = (Convert.ToDecimal(txtprice.Text / 100) * Convert.ToDecimal(txtgst.Text)).ToString()
            txttot.Text = (Convert.ToDecimal(txtprice.Text) + Convert.ToDecimal(txtGstP_Amount.Text)).ToString()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtid.Text = ""
        txtname.Text = ""
        Cbobox.Text = ""
        txtprice.Text = ""
        txtgst.Text = ""
        txttot.Text = ""
        txtGstP_Amount.Text = ""

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnext.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Dim dt As New DataTable
        Dim Query As String = String.Empty
        Dim Result As Long = 0
        Query = ("Select  productid,productname,qty,price,gst from item1 where productid <> 0 order by Productid")
        'Query = ("select from item1 where productid=106")
        Using Cmd As New OracleCommand(Query, Ora_Con)
            Using ora_ada As New OracleDataAdapter(Cmd)
                ora_ada.Fill(dt)
            End Using
        End Using
        GV1.DataSource = dt
        GV1.BestFitColumns()
    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Cboid.KeyDown
        Dim Dt1 As New DataTable
        If e.KeyCode = Keys.Enter Then ' Keys.Up Or e.KeyCode = Keys.Down Then
            Query = ("select productname,qty,price,gst from item1 where Productid ='" & Cboid.SelectedValue & "'")
            Using Cmd As New OracleCommand(Query, Ora_Con)
                Using Ora_Ada As New OracleDataAdapter(Cmd)
                    Ora_Ada.Fill(Dt1)
                End Using
            End Using
            txtname.Text = Dt1.Rows(0)("productname")
            Cbobox.Text = Dt1.Rows(0)("qty")
            txtprice.Text = Dt1.Rows(0)("price")
            txtgst.Focus()
        End If
    End Sub

    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles Button5.Click

        txtid.Visible = True
        Cboid.Visible = False
        type = "new "

    End Sub

    Private Sub BTNMDY_KeyDown(sender As Object, e As KeyEventArgs) Handles BTNMDY.KeyDown
        'Dim Query As String = String.Empty
        'Dim Result As Long = 0
        'Query = ("update  ITEM1 set productname =  '" & txtname.Text & "',qty='" & Cbobox.Text & "',price = '" & txtprice.Text & "',gst='" & txtgst.Text & "'where productid=" & Cboid.SelectedValue & "")
        'Using Cmd As New OracleCommand(Query, Ora_Con)
        '    Result = Cmd.ExecuteNonQuery()
        'End Using

        'If Result > 0 Then
        '    MsgBox("Update Successful")
        '    type = ""
        'Else
        '    MsgBox("Update Failed")
        'End If
    End Sub



    Private Sub btmd(sender As Object, e As EventArgs) Handles BTNMDY.Click
        Dim Query As String = String.Empty
        Dim Result As Long = 0
        Query = ("update  ITEM1 set productname =  '" & txtname.Text & "',qty='" & Cbobox.Text & "',price = '" & txtprice.Text & "',gst='" & txtgst.Text & "'where productid=" & Cboid.SelectedValue & "")
        Using Cmd As New OracleCommand(Query, Ora_Con)
            Result = Cmd.ExecuteNonQuery()
        End Using

        If Result > 0 Then
            MsgBox("Update Successful")
            type = ""
        Else
            MsgBox("Update Failed")
        End If
        txtid.Visible = False
        Cboid.Visible = True
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim Query As String = String.Empty
        Dim Result As Long = 0
        Query = "delete from item1 where productid=" & Cboid.SelectedValue & ""
        Using cmd As New OracleCommand(Query, Ora_Con)
            Result = cmd.ExecuteNonQuery()
        End Using
        If Result > 0 Then
            MsgBox("deleted Successful")
            type = ""
        Else
            MsgBox("Deletion Failed")
        End If
        txtid.Visible = False
        Cboid.Visible = True
    End Sub
End Class
