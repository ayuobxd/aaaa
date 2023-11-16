Imports System.Data.DataTable
Public Class InputData
    Private Sub InputData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = MaximizeBox.Equals(0)

    End Sub


End Class