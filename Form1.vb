Imports Oracle.DataAccess.Client
Imports Telerik.WinControls.UI

Public Class Form1
    Dim Ora_Con As New OracleConnection
    Dim Ora_Ada As New OracleDataAdapter
    Dim type As String
    'Dim Query As String = String.Empty


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ora_Con.ConnectionString = ("Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false")
        Ora_Con.Open()
        RG_VIEW()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim Query As String = String.Empty
        Dim Result As Long = 0
        ' Dim dt3 As New DataTable
        For Each GROW As GridViewRowInfo In RG1.Rows
            Dim seq As Object = Nothing
            Query = ("insert into STU1 (STUDENT_ID,STUDENT_NAME,DEPARTMENT) values (seqn.nextval,'" & GROW.Cells("STUDENT_NAME").Value & "','" & GROW.Cells("DEPARTMENT").Value & "')")
            Using Cmd As New OracleCommand(Query, Ora_Con)
                Result = Cmd.ExecuteNonQuery()
            End Using
        Next
        If Result > 0 Then
            MsgBox("insert succesfully")
            RG_VIEW()
            ' Me.Hide()
        Else
            MsgBox("insert failed")
        End If
    End Sub

    Private Sub btnconfrm_Click(sender As Object, e As EventArgs) Handles btnconfrm.Click
        Dim Query As String = String.Empty
        Dim Result As Long = 0
        Dim dt As New DataTable
        Dim STUDENT_ID As Double
        Dim RESULTCOUNT As Double
        Dim RESULTUPDATE As Double
        Dim dt2 As New DataTable
        RESULTCOUNT = 0
        Query = "Select distinct STUDENT_ID_FK from STUDETAILS where  ADDRESS <> ' ' or MOBILENO <> 0 "
        Using cmd As New OracleCommand(Query, Ora_Con)
            Using Ora_Ada As New OracleDataAdapter(cmd)
                Ora_Ada.Fill(dt2)
            End Using
        End Using
        For Each GROW As GridViewRowInfo In RG2.Rows
            If GROW.Cells("address").Value.ToString <> "" Or GROW.Cells("mobileno").Value.ToString <> "" Then
                For Each dtrow As DataRow In dt2.Rows
                    If GROW.Cells("STUDENT_ID").Value.ToString = dtrow("STUDENT_ID_FK").ToString Then
                        STUDENT_ID = 1
                    End If
                Next
                If STUDENT_ID = 0 Then
                    Query = "insert into STUDETAILS(STUDENT_ID_FK,STUDENT_NAME,Department,address,mobileno) values(" & GROW.Cells("STUDENT_ID").Value & ",'" & GROW.Cells("STUDENT_NAME").Value & "','" & GROW.Cells("department").Value & "','" & GROW.Cells("address").Value & "','" & GROW.Cells("mobileno").Value & "') "
                    Using Cmd As New OracleCommand(Query, Ora_Con)
                        Result = Cmd.ExecuteNonQuery()
                        RESULTCOUNT = RESULTCOUNT + 1
                    End Using
                Else
                    Query = "UPDATE STUDETAILS set address = '" & GROW.Cells("address").Value & "',mobileno = '" & GROW.Cells("mobileno").Value & "' where STUDENT_ID_FK = " & GROW.Cells("STUDENT_ID").Value.ToString & ""
                    Using cmd As New OracleCommand(Query, Ora_Con)
                        Result = cmd.ExecuteNonQuery()
                        RESULTUPDATE = RESULTUPDATE + 1
                    End Using
                    STUDENT_ID = 0
                End If
            End If
        Next
        If RESULTCOUNT > 0 Then
            MsgBox("inserted  successful")
            RG_VIEW()
            Me.Close()
        ElseIf RESULTUPDATE > 0 Then
            MsgBox("update succesfully")
            RG_VIEW()
            Me.Close()
        Else
            MsgBox(" failed")
        End If

    End Sub

    Private Sub RG_VIEW()
        Dim query As String = String.Empty
        Dim dt As New DataTable
        query = "SELECT * FROM STU1 T1 LEFT OUTER JOIN STUDETAILS T2 ON STUDENT_ID =STUDENT_ID_FK"
        Using cmd As New OracleCommand(query, Ora_Con)
            Using Ora_Ada As New OracleDataAdapter(cmd)
                Ora_Ada.Fill(dt)
            End Using
        End Using
        RG2.DataSource = dt
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click
        Report.Show()
    End Sub
End Class
