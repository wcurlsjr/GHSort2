<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GHSort
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdSORT = New System.Windows.Forms.Button()
        Me.dsLOTTO = New System.Data.DataSet()
        Me.txtRecCount = New System.Windows.Forms.TextBox()
        Me.OleDbConnection = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbLotto = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        CType(Me.dsLOTTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSORT
        '
        Me.cmdSORT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSORT.Location = New System.Drawing.Point(129, 83)
        Me.cmdSORT.Name = "cmdSORT"
        Me.cmdSORT.Size = New System.Drawing.Size(86, 28)
        Me.cmdSORT.TabIndex = 0
        Me.cmdSORT.Text = "SORT?"
        Me.cmdSORT.UseVisualStyleBackColor = True
        '
        'dsLOTTO
        '
        Me.dsLOTTO.DataSetName = "dsLOTTO"
        '
        'txtRecCount
        '
        Me.txtRecCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecCount.Location = New System.Drawing.Point(13, 43)
        Me.txtRecCount.Name = "txtRecCount"
        Me.txtRecCount.Size = New System.Drawing.Size(320, 24)
        Me.txtRecCount.TabIndex = 1
        '
        'OleDbConnection
        '
        Me.OleDbConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GH\gh.mdb"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT * FROM PBLotto"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `PBLotto` (`Date`, `WNbr1`, `WNbr2`, `WNbr3`, `WNbr4`, `WNbr5`, `Bonu" &
    "s`) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.[Date], 0, "Date"), New System.Data.OleDb.OleDbParameter("WNbr1", System.Data.OleDb.OleDbType.SmallInt, 0, "WNbr1"), New System.Data.OleDb.OleDbParameter("WNbr2", System.Data.OleDb.OleDbType.SmallInt, 0, "WNbr2"), New System.Data.OleDb.OleDbParameter("WNbr3", System.Data.OleDb.OleDbType.SmallInt, 0, "WNbr3"), New System.Data.OleDb.OleDbParameter("WNbr4", System.Data.OleDb.OleDbType.SmallInt, 0, "WNbr4"), New System.Data.OleDb.OleDbParameter("WNbr5", System.Data.OleDb.OleDbType.SmallInt, 0, "WNbr5"), New System.Data.OleDb.OleDbParameter("Bonus", System.Data.OleDb.OleDbType.SmallInt, 0, "Bonus")})
        '
        'OleDbLotto
        '
        Me.OleDbLotto.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbLotto.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbLotto.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbLotto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PBLotto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Date", "Date"), New System.Data.Common.DataColumnMapping("WNbr1", "WNbr1"), New System.Data.Common.DataColumnMapping("WNbr2", "WNbr2"), New System.Data.Common.DataColumnMapping("WNbr3", "WNbr3"), New System.Data.Common.DataColumnMapping("WNbr4", "WNbr4"), New System.Data.Common.DataColumnMapping("WNbr5", "WNbr5"), New System.Data.Common.DataColumnMapping("Bonus", "Bonus")})})
        Me.OleDbLotto.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM PBLotto"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection
        '
        'GHSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 145)
        Me.Controls.Add(Me.txtRecCount)
        Me.Controls.Add(Me.cmdSORT)
        Me.Name = "GHSort"
        Me.Text = "GHSort Chg #1"
        CType(Me.dsLOTTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSORT As Button
    Friend WithEvents dsLOTTO As DataSet
    Friend WithEvents txtRecCount As TextBox
    Public WithEvents OleDbConnection As OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbLotto As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
End Class
