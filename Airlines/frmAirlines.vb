' Program Name: Airline Passenger Growth
' Date: December 1, 2024
' Author: K Bola
' Purpose: This application computes and display passenegers' growth over the next ten years.
Public Class frmAirlines
    Dim intYearInput As Integer
    Dim lngCalculate As Long
    Const _cdblRate As Double = 0.069
    Const _clngInitialPassengers As Long = 3800000000
    Private Sub fmAirlines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)
    End Sub
    Private Sub CalculateNextDecade()
        intYearInput = Convert.ToInt32(txtYear.Text)
        For year As Integer = 1 To 10
            Dim intProjectedYear As Integer = intYearInput + (year - 1)
            lngCalculate = _clngInitialPassengers * (1 + _cdblRate) ^ year
            lstYears.Items.Add("Year: " & intProjectedYear & " = " & "Passengers: " & lngCalculate.ToString("N"))
        Next
    End Sub
    Private Function ValidateYear() As Integer
        Try
            intYearInput = Convert.ToInt32(txtYear.Text)
            If (intYearInput > 2017) Then
                CalculateNextDecade()
            Else
                MsgBox("Year must be greater than 2017", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Entry")
            End If
        Catch ex As Exception
            MsgBox("Enter a Value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Entry")
        End Try
        Return intYearInput
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lstYears.Items.Clear()
        ValidateYear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtYear.Clear()
        txtYear.Focus()
        lstYears.Items.Clear()
    End Sub
End Class
