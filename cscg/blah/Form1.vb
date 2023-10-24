Public Class Form1

    'variable defs
    Dim cs As Integer
    Dim clickperclick As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cs = 0
        clickperclick = 1
        click_count.Items.Clear()
        click_count.Items.Add(cs)

    End Sub

    Private Sub clicky_Click(sender As Object, e As EventArgs) Handles clicky.Click

        cs += clickperclick         'adds to the click count on click
        click_count.Items.Clear()   '}
        click_count.Items.Add(cs)   '} updates the click counter

    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click

        End

    End Sub

    'upgrades vvvvvv
    'cpc

    Private Sub BuyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuyToolStripMenuItem.Click

        If cs >= 100 Then
            cs -= 100
            BuyToolStripMenuItem.Enabled = False
            If clickperclick < 2 Then
                clickperclick = 2
            End If
        Else
            MsgBox("Not enough Clicks!")
        End If
        click_count.Items.Clear()
        click_count.Items.Add(cs)

    End Sub

    Private Sub BuyToolStripMenuItem_2_Click(sender As Object, e As EventArgs) Handles BuyToolStripMenuItem1.Click

        If cs >= 500 Then
            cs -= 500
            BuyToolStripMenuItem1.Enabled = False
            If clickperclick < 4 Then
                clickperclick = 4
            End If
        Else
            MsgBox("Not enough Clicks!")
        End If
        click_count.Items.Clear()
        click_count.Items.Add(cs)

    End Sub

    Private Sub BuyToolStripMenuItem_3_Click(sender As Object, e As EventArgs) Handles BuyToolStripMenuItem2.Click

        If cs >= 1000 Then
            cs -= 1000
            BuyToolStripMenuItem2.Enabled = False
            If clickperclick < 8 Then
                clickperclick = 8
            Else
                MsgBox("Are you sure? You already have an upgrade better than this.", MsgBoxStyle = MsgBoxStyle.YesNo)
            End If
        Else
            MsgBox("Not enough Clicks!")
        End If
        click_count.Items.Clear()
        click_count.Items.Add(cs)

    End Sub

    Private Sub BuyToolStripMenuItem_4_Click(sender As Object, e As EventArgs) Handles BuyToolStripMenuItem3.Click

        If cs >= 5000 Then
            cs -= 5000
            BuyToolStripMenuItem3.Enabled = False
            If clickperclick < 16 Then
                clickperclick = 16
            End If
        Else
            MsgBox("Not enough Clicks!")
        End If
        click_count.Items.Clear()
        click_count.Items.Add(cs)

    End Sub

    Private Sub BuyToolStripMenuItem_5_Click(sender As Object, e As EventArgs) Handles BuyToolStripMenuItem4.Click

        If cs >= 10000 Then
            cs -= 10000
            BuyToolStripMenuItem4.Enabled = False
            If clickperclick < 32 Then
                clickperclick = 32
            End If
        Else
            MsgBox("Not enough Clicks!")
        End If
        click_count.Items.Clear()
        click_count.Items.Add(cs)

    End Sub

    'easter egg shhhhhhhhhhhhhhhhh

    Private Sub InspectElementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InspectToolStripMenuItem.Click

        MsgBox("You really thought that would work, didn't you?")
        MsgBox("Oh well. Say goodbye to your progress!")
        Me.WindowState = FormWindowState.Minimized
        click_count.Items.Clear()
        click_count.Items.Add("gottem :3")
        click_count.Items.Add("click to continue!")

    End Sub

End Class
