'' Author: Francisco Bumanglag
'' Project: Rainfall Statistics
'' Assignment: Module 10 Project
'' Course: Adv Visual Basic, Santa Ana College
'' Class: CMPR205 Dr. Kimberly Davis 
'' Date: April 28, 2024


Public Class Form1

    Private RainFile As New Dictionary(Of Integer, Double)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate the list box with the range of years
        For year As Integer = 2004 To 2021
            lstBoxYears.Items.Add(year.ToString)
        Next

        'import the data from the rainfall file
        Try
            RainFile = LoadRainfallData("rain.txt")
        Catch ex As Exception
            MessageBox.Show("Error loading the rainfall file: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'compute the average rainfall
        Dim averageRainfall As Double = RainFile.Values.Average()
        lblAverageRainfall.Text = String.Format("The average rainfall was {0:F2} inches.", averageRainfall)


        'find the rainiest year
        Dim maxRainfall As Double = RainFile.Values.Max()
        Dim rainiestYear As Integer = RainFile.FirstOrDefault(Function(x) x.Value = maxRainfall).Key
        lblRainiestYear.Text = $"Year {rainiestYear} had the most rain with {maxRainfall:F2} inches."

        'display the selected year's rainfall
        If lstBoxYears.SelectedItem IsNot Nothing Then
            Dim selectedYear As Integer = Convert.ToInt32(lstBoxYears.SelectedItem)
            Dim selectedYearRainfall As Double = RainFile(selectedYear)
            lblYearRainfall.Text = $"The total rainfall in Year {selectedYear} is {selectedYearRainfall:F2} inches."
        End If
    End Sub

    Private Function LoadRainfallData(fileName As String) As Dictionary(Of Integer, Double)
        Dim data As New Dictionary(Of Integer, Double)
        Dim lines As String() = System.IO.File.ReadAllLines(fileName)

        'ensure there is an even number of lines (each year should have a corresponding rainfall entry)
        If lines.Length Mod 2 <> 0 Then
            MessageBox.Show("The data file appears to be malformed. Please check that each year entry has a corresponding rainfall value.")
            Return data
        End If

        For i As Integer = 0 To lines.Length - 2 Step 2
            Dim yearLine As String = lines(i)
            Dim rainfallLine As String = lines(i + 1)

            'extract the year from the year line, assuming format "Year YYYY"
            Dim yearStr As String = yearLine.Split(New Char() {" "c})(1)
            Dim year As Integer
            If Not Integer.TryParse(yearStr, year) Then
                MessageBox.Show($"Invalid year format: {yearStr}")
                Continue For
            End If

            'parse the rainfall from the rainfall line
            Dim rainfall As Double
            If Not Double.TryParse(rainfallLine, System.Globalization.CultureInfo.InvariantCulture, rainfall) Then
                MessageBox.Show($"Invalid rainfall format: {rainfallLine}")
                Continue For
            End If

            'add year and rainfall to the dictionary
            If Not data.ContainsKey(year) Then
                data.Add(year, rainfall)
            Else
                MessageBox.Show($"Duplicate year entry found: {year}")
            End If
        Next

        Return data
    End Function


End Class



