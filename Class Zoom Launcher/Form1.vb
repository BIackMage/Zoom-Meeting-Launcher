Public Class Form1
    Private Sub Load_Settings()

        TextBox1.Text = My.Settings.Class1_Name
        TextBox2.Text = My.Settings.Class1_Link
        TextBox3.Text = My.Settings.Class1_Password

        TextBox6.Text = My.Settings.Class2_Name
        TextBox5.Text = My.Settings.Class2_Link
        TextBox4.Text = My.Settings.Class2_Password

        TextBox9.Text = My.Settings.Class3_Name
        TextBox8.Text = My.Settings.Class3_Link
        TextBox7.Text = My.Settings.Class3_Password

        TextBox12.Text = My.Settings.Class4_Name
        TextBox11.Text = My.Settings.Class4_Link
        TextBox10.Text = My.Settings.Class4_Password

        TextBox15.Text = My.Settings.Class5_Name
        TextBox14.Text = My.Settings.Class5_Link
        TextBox13.Text = My.Settings.Class5_Password

        TextBox18.Text = My.Settings.Class6_Name
        TextBox17.Text = My.Settings.Class6_Link
        TextBox16.Text = My.Settings.Class6_Password

        TextBox30.Text = My.Settings.Class7_Name
        TextBox29.Text = My.Settings.Class7_Link
        TextBox28.Text = My.Settings.Class7_Password

        TextBox27.Text = My.Settings.Class8_Name
        TextBox26.Text = My.Settings.Class8_Link
        TextBox25.Text = My.Settings.Class8_Password

        TextBox24.Text = My.Settings.Class9_Name
        TextBox23.Text = My.Settings.Class9_Link
        TextBox22.Text = My.Settings.Class9_Password

        TextBox21.Text = My.Settings.Class10_Name
        TextBox20.Text = My.Settings.Class10_Link
        TextBox19.Text = My.Settings.Class10_Password

    End Sub
    Private Sub Go(ByVal row As Integer)
        Dim course As String = ""
        Dim link As String = ""
        Dim pass As String = ""

        Select Case row
            Case 0
                course = TextBox1.Text
                link = TextBox2.Text
                pass = TextBox3.Text
            Case 1
                course = TextBox6.Text
                link = TextBox5.Text
                pass = TextBox4.Text
            Case 2
                course = TextBox9.Text
                link = TextBox8.Text
                pass = TextBox7.Text
            Case 3
                course = TextBox12.Text
                link = TextBox11.Text
                pass = TextBox10.Text
            Case 4
                course = TextBox15.Text
                link = TextBox14.Text
                pass = TextBox13.Text
            Case 5
                course = TextBox18.Text
                link = TextBox17.Text
                pass = TextBox16.Text
            Case 6
                course = TextBox30.Text
                link = TextBox29.Text
                pass = TextBox28.Text
            Case 7
                course = TextBox27.Text
                link = TextBox26.Text
                pass = TextBox25.Text
            Case 8
                course = TextBox24.Text
                link = TextBox23.Text
                pass = TextBox22.Text
            Case 9
                course = TextBox21.Text
                link = TextBox20.Text
                pass = TextBox19.Text
        End Select

        If course <> "" And link <> "" And pass <> "" Then
            Clipboard.SetText(pass)
            System.Diagnostics.Process.Start(link)
        End If
    End Sub

    Private Sub SaveSettings(ByVal row As Integer)
        Select Case row
            Case 0
                My.Settings.Class1_Name = TextBox1.Text
                My.Settings.Class1_Link = TextBox2.Text
                My.Settings.Class1_Password = TextBox3.Text
            Case 1
                My.Settings.Class2_Name = TextBox6.Text
                My.Settings.Class2_Link = TextBox5.Text
                My.Settings.Class2_Password = TextBox4.Text
            Case 2
                My.Settings.Class3_Name = TextBox9.Text
                My.Settings.Class3_Link = TextBox8.Text
                My.Settings.Class3_Password = TextBox7.Text
            Case 3
                My.Settings.Class4_Name = TextBox12.Text
                My.Settings.Class4_Link = TextBox11.Text
                My.Settings.Class4_Password = TextBox10.Text
            Case 4
                My.Settings.Class5_Name = TextBox15.Text
                My.Settings.Class5_Link = TextBox14.Text
                My.Settings.Class5_Password = TextBox13.Text
            Case 5
                My.Settings.Class6_Name = TextBox18.Text
                My.Settings.Class6_Link = TextBox17.Text
                My.Settings.Class6_Password = TextBox16.Text
            Case 6
                My.Settings.Class7_Name = TextBox30.Text
                My.Settings.Class7_Link = TextBox29.Text
                My.Settings.Class7_Password = TextBox28.Text
            Case 7
                My.Settings.Class8_Name = TextBox27.Text
                My.Settings.Class8_Link = TextBox26.Text
                My.Settings.Class8_Password = TextBox25.Text
            Case 8
                My.Settings.Class9_Name = TextBox24.Text
                My.Settings.Class9_Link = TextBox23.Text
                My.Settings.Class9_Password = TextBox22.Text
            Case 9
                My.Settings.Class10_Name = TextBox21.Text
                My.Settings.Class10_Link = TextBox20.Text
                My.Settings.Class10_Password = TextBox19.Text
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Settings()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveSettings(0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SaveSettings(1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SaveSettings(2)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SaveSettings(3)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        SaveSettings(4)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        SaveSettings(5)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Go(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Go(1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Go(2)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Go(3)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Go(4)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Go(5)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        SaveSettings(6)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Go(6)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        SaveSettings(7)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        SaveSettings(8)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        SaveSettings(9)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Go(7)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Go(8)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Go(9)
    End Sub
End Class
