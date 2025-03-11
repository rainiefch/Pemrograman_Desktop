Public Class Form4
    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        Dim EditProfile As New Form2
        EditProfile.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SubscriberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubscriberToolStripMenuItem.Click
        Dim Subscription As New Form3
        Subscription.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Dim Report As New Form5
        Report.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Login As New Form1
        Login.Close()
    End Sub

    Private Sub Form_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

End Class