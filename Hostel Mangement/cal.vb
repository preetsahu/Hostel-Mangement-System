﻿Public Class cal
    Dim lblDayz As Label
    Dim y As Int32 = 0
    Dim x As Int32
    Dim ndayz As Int32
    Dim Dayofweek, CurrentCulture As String     'Next, we will code for our Form_Load to display the current date.

    'Then we will create a function named CheckDay() As Int32 to check if the given day is valid or not.
    Function CheckDay() As Int32
        Dim time As DateTime = Convert.ToDateTime(comboBoxMonth.Text + "/01/" + textBoxYear.Text)
        'get the start day of the week for the entered date and month
        DayOfWeek = Application.CurrentCulture.Calendar.GetDayOfWeek(time).ToString()
        If DayOfWeek = "Sunday" Then
            x = 0
        ElseIf DayOfWeek = "Monday" Then
            x = 0 + 42
            ndayz = 1
        ElseIf DayOfWeek = "Tuesday" Then
            x = 0 + 84
            ndayz = 2
        ElseIf DayOfWeek = "Wednesday" Then
            x = 0 + 84 + 42
            ndayz = 3
        ElseIf DayOfWeek = "Thursday" Then
            x = 0 + 84 + 84
            ndayz = 4
        ElseIf DayOfWeek = "Friday" Then
            x = 0 + 84 + 84 + 42
            ndayz = 5
        ElseIf DayOfWeek = "Saturday" Then
            x = 0 + 84 + 84 + 84
            ndayz = 6
        End If
        Return (x)

    End Function
    'Next, we will go for coding the searching button then we will use the Function CheckDay() for this to validate the inputted date.
    Private Sub buttonGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonGo.Click
        If comboBoxMonth.Text = Nothing Or textBoxYear.Text = Nothing Then
            MessageBox.Show("Either year or month is incorrect")
        Else
            Try
                Dim t As Int32 = Convert.ToInt32(textBoxYear.Text)
                If Not textBoxYear.Text = "0" Or t < 1 Then
                    'remove all the controls in the panel
                    Panel1.Controls.Clear()
                    My.Application.ChangeCulture(CurrentCulture)
                    'display the selected month's fullname
                    labelMonth.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(comboBoxMonth.Text))
                    My.Application.ChangeCulture("en-za")
                    Dim Dayz As Int32 = DateTime.DaysInMonth(Convert.ToInt32(textBoxYear.Text), Convert.ToInt32(comboBoxMonth.Text))
                    CheckDay()
                    For i As Int32 = 1 To Dayz
                        ndayz += 1
                        lblDayz = New Label()
                        lblDayz.Text = i.ToString()
                        lblDayz.BorderStyle = BorderStyle.Fixed3D
                        Dim mon As Int32 = Convert.ToInt32(comboBoxMonth.Text)
                        Dim years As Int32 = Convert.ToInt32(textBoxYear.Text)
                        If ((i = DateTime.Now.Day) And (mon = DateTime.Now.Month) And (years = DateTime.Now.Year)) Then
                            'the current day must be highlighted differently
                            lblDayz.BackColor = Color.Green
                        ElseIf ndayz = 1 Then
                            lblDayz.BackColor = Color.Red
                        Else
                            'set this color for other days in the selected month
                            lblDayz.BackColor = Color.Aquamarine
                        End If
                        lblDayz.Font = label31.Font
                        lblDayz.SetBounds(x, y, 37, 27)
                        x += 42
                        If ndayz = 7 Then
                            x = 0
                            ndayz = 0
                            y += 29
                        End If
                        Panel1.Controls.Add(lblDayz)
                    Next
                    x = 0
                    ndayz = 0
                    y = 0
                Else
                    MessageBox.Show("must be between 0 and 9999")
                    textBoxYear.Focus()
                End If
            Catch er As FormatException
                MessageBox.Show("Year must be between 0 and 9999")
                textBoxYear.Focus()
            End Try
        End If
    End Sub

    'For displaying the next date, we will code for Button1_click. Have this code below:
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim currentmonth, currentyear As Int32
            currentyear = Convert.ToInt32(textBoxYear.Text)
            currentmonth = Convert.ToInt32(comboBoxMonth.Text)
            If (currentmonth = 12) Then
                'move to the next month
                currentyear += 1
                currentmonth = 1
                textBoxYear.Text = currentyear.ToString()
                comboBoxMonth.Text = currentmonth.ToString()
            Else
                currentmonth += 1
                comboBoxMonth.Text = currentmonth.ToString()
            End If
            'remove all the controls in the panel
            Panel1.Controls.Clear()
            'Display the month's name in the windows culture
            My.Application.ChangeCulture(CurrentCulture)
            'display the selected month's fullname
            labelMonth.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(currentmonth)
            'This project was created in a computer using en-za
            My.Application.ChangeCulture("en-za")
            Dim Dayz As Int32 = DateTime.DaysInMonth(Convert.ToInt32(textBoxYear.Text), Convert.ToInt32(comboBoxMonth.Text))
            CheckDay()
            For i As Int32 = 1 To Dayz
                ndayz += 1
                lblDayz = New Label()
                lblDayz.Text = i.ToString()
                lblDayz.BorderStyle = BorderStyle.Fixed3D
                Dim mon As Int32 = Convert.ToInt32(comboBoxMonth.Text)
                Dim years As Int32 = Convert.ToInt32(textBoxYear.Text)
                If ((i = DateTime.Now.Day) And (mon = DateTime.Now.Month) And (years = DateTime.Now.Year)) Then
                    'the current day must be highlighted differently
                    lblDayz.BackColor = Color.Green
                ElseIf (ndayz = 1) Then
                    lblDayz.BackColor = Color.Red
                Else
                    'set this color for other days in the selected month
                    lblDayz.BackColor = Color.Aquamarine
                End If
                lblDayz.Font = label31.Font
                lblDayz.SetBounds(x, y, 37, 27)
                x += 42
                If (ndayz = 7) Then
                    x = 0
                    ndayz = 0
                    y += 29
                End If
                Panel1.Controls.Add(lblDayz)
            Next
            x = 0
            ndayz = 0
            y = 0
        Catch et As FormatException
            MessageBox.Show("Invalid date has been entered")
            textBoxYear.Focus()
        Catch ex As NullReferenceException
            MessageBox.Show("Invalid date has been entered")
            textBoxYear.Focus()
        End Try
    End Sub
    'For displaying the previous date, we will code for Button2_click. Have this code below:
    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim currentmonth, currentyear As Int32
            currentyear = Convert.ToInt32(textBoxYear.Text)
            currentmonth = Convert.ToInt32(comboBoxMonth.Text)
            If currentmonth = 1 Then
                'go to the previous month
                currentyear -= 1
                'go to the last month
                currentmonth = 12
                textBoxYear.Text = currentyear.ToString()
                comboBoxMonth.Text = currentmonth.ToString()
            Else
                'go to the previous month
                currentmonth -= 1
                comboBoxMonth.Text = currentmonth.ToString()
            End If
            'remove all the controls in the panel
            Panel1.Controls.Clear()

            My.Application.ChangeCulture(CurrentCulture)
            'display the selected month's fullname
            labelMonth.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(currentmonth)
            My.Application.ChangeCulture("en-za")
            Dim Dayz As Int32 = DateTime.DaysInMonth(Convert.ToInt32(textBoxYear.Text), Convert.ToInt32(comboBoxMonth.Text))
            CheckDay()
            For i As Int32 = 1 To Dayz
                ndayz += 1
                lblDayz = New Label()
                lblDayz.Text = i.ToString()
                lblDayz.BorderStyle = BorderStyle.Fixed3D
                Dim mon As Int32 = Convert.ToInt32(comboBoxMonth.Text)
                Dim years As Int32 = Convert.ToInt32(textBoxYear.Text)
                If ((i = DateTime.Now.Day) And (mon = DateTime.Now.Month) And (years = DateTime.Now.Year)) Then
                    'the current day must be highlighted differently
                    lblDayz.BackColor = Color.Green
                ElseIf ndayz = 1 Then
                    'highlight the sunday's in red color
                    lblDayz.BackColor = Color.Red
                Else
                    'set this color for other days in the selected month
                    lblDayz.BackColor = Color.Aquamarine
                End If
                lblDayz.Font = label31.Font
                lblDayz.SetBounds(x, y, 37, 27)
                x += 42
                If (ndayz = 7) Then
                    x = 0
                    ndayz = 0
                    y += 29
                End If
                Panel1.Controls.Add(lblDayz)
            Next
            x = 0
            ndayz = 0
            y = 0
        Catch er As FormatException
            MessageBox.Show("Invalid date has been entered")
            textBoxYear.Focus()
        Catch ex As NullReferenceException
            MessageBox.Show("Invalid date has been entered")
            textBoxYear.Focus()
        End Try
    End Sub
    Private Sub cal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'display the current month
        comboBoxMonth.Text = DateTime.Now.Month.ToString()
        'Get there windows culture
        CurrentCulture = Globalization.CultureInfo.CurrentCulture.Name
        'display the full name of the current month
        labelMonth.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(comboBoxMonth.Text))
        'get the number of days in the selected month and year
        My.Application.ChangeCulture("en-za")
        Dim Dayz As Int32 = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)
        'display the current year in the textbox
        textBoxYear.Text = DateTime.Now.Year.ToString()
        'call the checkday function
        CheckDay()
        For i As Int32 = 1 To Dayz
            ndayz += 1
            lblDayz = New Label()
            lblDayz.Name = "B" & i
            lblDayz.Text = i.ToString()
            lblDayz.BorderStyle = BorderStyle.Fixed3D
            If i = DateTime.Now.Day Then
                lblDayz.BackColor = Color.Green
            ElseIf ndayz = 1 Then
                lblDayz.BackColor = Color.Red
            Else
                lblDayz.BackColor = Color.Aquamarine
            End If
            lblDayz.Font = Label31.Font
            lblDayz.SetBounds(x, y, 37, 27)
            x += 42
            If ndayz = 7 Then
                x = 0
                ndayz = 0
                y += 29
            End If
            Panel1.Controls.Add(lblDayz)
        Next
        'return all values to default
        x = 0
        ndayz = 0
        y = 0
    End Sub
End Class