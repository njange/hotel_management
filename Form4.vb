﻿Public Class Form4
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim checkInForm As New Form2()
        checkInForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class