Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim checkInForm As New Form2()
        checkInForm.Show()
        Me.Hide()
    End Sub
End Class