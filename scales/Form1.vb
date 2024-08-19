Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Scale As Double

        Scale = TextBox1.Text


        If Scale >= 1.0 And Scale <= 2.9 Then
            Label1.Text = "Micro - not felt, but can be recorded by topography"
            PictureBox1.Image = My.Resources.Screenshot_2023_03_02_111200
        ElseIf Scale >= 3.0 And Scale <= 3.9 Then
            Label1.Text = "Minor - Vibrations detected "
            PictureBox1.Image = My.Resources.Screenshot_2023_03_02_111208
        ElseIf Scale >= 4.0 And Scale <= 4.9 Then
            Label1.Text = "Light - Vibrations detected"
            PictureBox1.Image = My.Resources.Screenshot_2023_03_02_111216
        ElseIf Scale = 5.0 And Scale <= 5.9 Then
            Label1.Text = "Moderate - Window rattle or break, light damage"
            PictureBox1.Image = My.Resources.Screenshot_2023_03_02_111223
        ElseIf Scale = 6.0 And Scale <= 6.9 Then
            Label1.Text = "Strong - Cracks in buildings, falling branches"
            PictureBox1.Image = My.Resources.Screenshot_2023_03_02_111236
        ElseIf Scale >= 7.0 And Scale <= 7.9 Then
            Label1.Text = "Major - building collapses, landslides"
            PictureBox1.Image = My.Resources.Screenshot_2023_03_02_111251
        ElseIf Scale > 8.0 Then
            Label1.Text = "Great - Devastation, many deaths"
            PictureBox1.Image = My.Resources.Screenshot_2023_03_02_111301

        End If
    End Sub
End Class
