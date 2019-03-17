Public Class Form1

    Private Property Day As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If DateTimePicker2.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.bell, AudioPlayMode.Background)
            Label2.ForeColor = Color.Blue
            Label3.ForeColor = Color.Red
            Label15.Text = "School Started"

        End If

        If DateTimePicker3.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.Bell, AudioPlayMode.Background)
            Label3.ForeColor = Color.Blue
            Label4.ForeColor = Color.Red
            Label15.Text = "The 1st period was beginning"
        End If

        If DateTimePicker4.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.Bell, AudioPlayMode.Background)
            Label4.ForeColor = Color.Blue
            Label5.ForeColor = Color.Red
            Label15.Text = "The 2nd period was beginning"
        End If

        If DateTimePicker5.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.Bell, AudioPlayMode.Background)
            Label5.ForeColor = Color.Blue
            Label6.ForeColor = Color.Red
            Label15.Text = "The 3rd period was beginning"
        End If

        If DateTimePicker6.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.Bell, AudioPlayMode.Background)
            Label6.ForeColor = Color.Blue
            Label7.ForeColor = Color.Red
            Label15.Text = "The 4th period was beginning"
        End If

        If DateTimePicker7.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.Bell, AudioPlayMode.Background)
            Label7.ForeColor = Color.Blue
            Label8.ForeColor = Color.Red
            Label15.Text = "The Interval was beginning"
        End If

        If DateTimePicker8.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.Bell, AudioPlayMode.Background)
            Label8.ForeColor = Color.Blue
            Label9.ForeColor = Color.Red
            Label15.Text = "The 5th period was beginning"
        End If

        If DateTimePicker9.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.Bell, AudioPlayMode.Background)
            Label9.ForeColor = Color.Blue
            Label10.ForeColor = Color.Red
            Label15.Text = "The 6th period was beginning"
        End If

        If DateTimePicker10.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.Bell, AudioPlayMode.Background)
            Label10.ForeColor = Color.Blue
            Label11.ForeColor = Color.Red
            Label15.Text = "The 7th period was beginning"
        End If
        If DateTimePicker1.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.Bell, AudioPlayMode.Background)
            Label11.ForeColor = Color.Blue
            Label12.ForeColor = Color.Red
            Label15.Text = "The 8th period was beginning"
        End If
        If DateTimePicker11.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.Bell, AudioPlayMode.Background)
            Label12.ForeColor = Color.Blue
            Label15.Text = "The school is over"
        End If

        If DateTimePicker12.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.bell, AudioPlayMode.Background)
            Label15.Text = "The school is over"
        End If

        If DateTimePicker14.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.bell, AudioPlayMode.Background)
            Label15.Text = "Good Bye"
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Stop()
        Timer4.Enabled = False
        Button1.Enabled = True
        Button4.Enabled = True
        Button2.Enabled = True
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        DateTimePicker3.Enabled = True
        DateTimePicker4.Enabled = True
        DateTimePicker5.Enabled = True
        DateTimePicker6.Enabled = True
        DateTimePicker7.Enabled = True
        DateTimePicker8.Enabled = True
        DateTimePicker9.Enabled = True
        DateTimePicker10.Enabled = True
        DateTimePicker11.Enabled = True
        Label14.Text = "Not Active"
        Label14.ForeColor = Color.Red

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Audio.Play(My.Resources._1st, AudioPlayMode.Background)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton3.Checked Then
            Timer3.Enabled = True
            Timer1.Enabled = False
            Button1.Enabled = False
            Button4.Enabled = False
            Button2.Enabled = False
            Label14.Text = "Active"
            Label14.ForeColor = Color.LightGreen
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            DateTimePicker3.Enabled = False
            DateTimePicker4.Enabled = False
            DateTimePicker5.Enabled = False
            DateTimePicker6.Enabled = False
            DateTimePicker7.Enabled = False
            DateTimePicker8.Enabled = False
            DateTimePicker9.Enabled = False
            DateTimePicker10.Enabled = False
            DateTimePicker11.Enabled = False
        ElseIf RadioButton4.Checked Then
            Timer1.Enabled = True
            Timer3.Enabled = False
            Button1.Enabled = False
            Button4.Enabled = False
            Button2.Enabled = False
            Label14.Text = "Active"
            Label14.ForeColor = Color.LightGreen
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            DateTimePicker3.Enabled = False
            DateTimePicker4.Enabled = False
            DateTimePicker5.Enabled = False
            DateTimePicker6.Enabled = False
            DateTimePicker7.Enabled = False
            DateTimePicker8.Enabled = False
            DateTimePicker9.Enabled = False
            DateTimePicker10.Enabled = False
            DateTimePicker11.Enabled = False
        Else
            MsgBox("Please selcet an Audio Type")
        End If

        

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Text = Date.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        About_Me.ShowDialog()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If DateTimePicker2.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.bell, AudioPlayMode.Background)
            Label2.ForeColor = Color.Blue
            Label3.ForeColor = Color.Red
            Label15.Text = "School Started"

        End If

        If DateTimePicker3.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources._1st, AudioPlayMode.Background)
            Label3.ForeColor = Color.Blue
            Label4.ForeColor = Color.Red
            Label15.Text = "The 1st period was beginning"
        End If

        If DateTimePicker4.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources._2nd, AudioPlayMode.Background)
            Label4.ForeColor = Color.Blue
            Label5.ForeColor = Color.Red
            Label15.Text = "The 2nd period was beginning"
        End If

        If DateTimePicker5.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources._3rd, AudioPlayMode.Background)
            Label5.ForeColor = Color.Blue
            Label6.ForeColor = Color.Red
            Label15.Text = "The 3rd period was beginning"
        End If

        If DateTimePicker6.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources._4th, AudioPlayMode.Background)
            Label6.ForeColor = Color.Blue
            Label7.ForeColor = Color.Red
            Label15.Text = "The 4th period was beginning"
        End If

        If DateTimePicker7.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.bell, AudioPlayMode.Background)
            Label7.ForeColor = Color.Blue
            Label8.ForeColor = Color.Red
            Label15.Text = "The Interval was beginning"
        End If

        If DateTimePicker8.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources._5th, AudioPlayMode.Background)
            Label8.ForeColor = Color.Blue
            Label9.ForeColor = Color.Red
            Label15.Text = "The 5th period was beginning"
        End If

        If DateTimePicker9.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources._6th, AudioPlayMode.Background)
            Label9.ForeColor = Color.Blue
            Label10.ForeColor = Color.Red
            Label15.Text = "The 6th period was beginning"
        End If

        If DateTimePicker10.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources._7th, AudioPlayMode.Background)
            Label10.ForeColor = Color.Blue
            Label11.ForeColor = Color.Red
            Label15.Text = "The 7th period was beginning"
        End If
        If DateTimePicker1.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources._8th, AudioPlayMode.Background)
            Label11.ForeColor = Color.Blue
            Label12.ForeColor = Color.Red
            Label15.Text = "The 8th period was beginning"
        End If
        If DateTimePicker11.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.bell, AudioPlayMode.Background)
            Label12.ForeColor = Color.Blue
            Label15.Text = "Please Ready to go home"
        End If

        If DateTimePicker12.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.bell, AudioPlayMode.Background)
            Label15.Text = "The school is over"
        End If

        If DateTimePicker14.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.bell, AudioPlayMode.Background)
            Label15.Text = "Good Bye"
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton5.CheckedChanged
        Timer4.Enabled = True
    End Sub

    Private Sub GroupBox8_Enter(sender As Object, e As EventArgs) Handles GroupBox8.Enter

    End Sub

    Private Sub DateTimePicker12_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker12.ValueChanged, DateTimePicker13.ValueChanged, DateTimePicker14.ValueChanged

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If DateTimePicker13.Value.ToString("hh:mm:ss tt") = Label1.Text Then
            My.Computer.Audio.Play(My.Resources.gatha, AudioPlayMode.Background)
            Label15.Text = "Sing Gatha"
        End If
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub
End Class

