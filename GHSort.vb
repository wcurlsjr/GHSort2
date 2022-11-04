Imports System.Data.OleDb
Public Class GHSort
    'Public Shared OleDbLotto = New System.Data.OleDb.OleDbConnection().ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GH\gh.mdb"

    Private Sub GHSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LText As String
        Dim RecCount As Integer

        Me.txtRecCount.Enabled = False
        OleDbConnection.Open()
        dsLOTTO.Reset()
        dsLOTTO.Tables.Clear()
        OleDbLotto.SelectCommand.CommandText =
        "Select Date, Wnbr1, WNbr2, WNbr3, WNbr4, WNbr5, Bonus from PBNoSort"
        OleDbLotto.Fill(dsLOTTO)
        If dsLOTTO.Tables(0).Rows.Count = 0 Then
            LText = "No Lotto Data exists in PBNoSort "
            MessageBox.Show(LText, "BAD TABLE", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            RecCount = dsLOTTO.Tables(0).Rows.Count
            Me.txtRecCount.Text = "Total Number of Records = " & Convert.ToString(RecCount)
        End If

    End Sub

    Private Sub cmdSORT_Click(sender As Object, e As EventArgs) Handles cmdSORT.Click
        Dim A As Integer
        Dim Dte As Date
        Dim BonusNbr As Integer = 0
        Dim dsLottoCnt As Integer
        Dim NewLotto(5) As Integer
        Dim strInsertTxt As String
        Dim OsqlDate As String

        dsLOTTO.Clear()
        OleDbLotto.DeleteCommand.CommandText = "DELETE FROM PBLotto"
        OleDbLotto.DeleteCommand.ExecuteNonQuery()

        dsLOTTO.Reset() : dsLOTTO.Clear()
        OleDbLotto.SelectCommand.CommandText = "Select * from PBNoSort"
        OleDbLotto.Fill(dsLOTTO)
        dsLottoCnt = (dsLOTTO.Tables(0).Rows.Count - 1)

        A = 0
        Do Until A > dsLottoCnt
            Dte = Convert.ToDateTime(dsLOTTO.Tables(0).Rows(A)(0))
            OsqlDate = "#" & Convert.ToString(Dte.ToShortDateString) & "#"
            For w As Integer = 1 To 5
                NewLotto(w) = Convert.ToInt16(dsLOTTO.Tables(0).Rows(A)(w))
            Next
            BonusNbr = Convert.ToInt16(dsLOTTO.Tables(0).Rows(A)(6))
            modSORT.Sort(NewLotto)
            strInsertTxt = "INSERT INTO PBLotto ([Date], WNbr1, WNbr2, WNbr3, WNbr4, WNbr5, Bonus) " &
                "VALUES (" & OsqlDate & ", " & NewLotto(1) & ", " & NewLotto(2) & ", " & NewLotto(3) & ", " &
                NewLotto(4) & ", " & NewLotto(5) & ", " & BonusNbr & ")"
            OleDbLotto.InsertCommand.CommandText = strInsertTxt
            OleDbLotto.InsertCommand.ExecuteNonQuery()
            A += 1
        Loop

        MessageBox.Show("Sorted!", "PBLOTTO SORTED", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End

    End Sub

End Class
