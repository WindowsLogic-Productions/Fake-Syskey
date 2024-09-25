Public Class Syskey1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()

    End Sub

    Private Sub btnupd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        Syskey2.Show()

    End Sub
End Class
