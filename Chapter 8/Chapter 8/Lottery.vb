Public Class Lottery

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Const intMax_SUBSCRIPT As Integer = 4
        Dim intNumbers(intMax_SUBSCRIPT) As Integer
        Dim intCount As Integer

        Dim rand As New Random

        For intCount = 0 To intMax_SUBSCRIPT
            intNumbers(intCount) = rand.Next(100)
        Next

        lblFirst.Text = intNumbers(0).ToString
        lblSecond.Text = intNumbers(1).ToString
        lblThird.Text = intNumbers(2).ToString
        lblFourth.Text = intNumbers(3).ToString
        lblFifth.Text = intNumbers(4).ToString

    End Sub
End Class
