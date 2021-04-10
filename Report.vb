'
Imports Microsoft.Reporting.WinForms
Imports Oracle.DataAccess.Client
Public Class Report
    Dim Ora_Con As New OracleConnection
    Dim query As String = String.Empty

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ora_Con.ConnectionString = ("Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false")
        Ora_Con.Open()

        Dim ds As New DataSet
        query = "select * from studetails"
        Using Cmd As New OracleCommand(query, Ora_Con)
            Using Ora_Ada As New OracleDataAdapter(Cmd)
                Ora_Ada.Fill(ds, "DATA1")
            End Using
        End Using
        Dim rds As ReportDataSource = New ReportDataSource("DATA1", ds.Tables(0))
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "STUDENT.REP.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(rds)
        Me.ReportViewer1.ZoomPercent = 125

        Me.ReportViewer1.Refresh()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class