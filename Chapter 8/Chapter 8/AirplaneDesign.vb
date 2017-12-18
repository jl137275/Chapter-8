Public Class Seating_Chart

    Private Sub btnDisplayPrice_Click(sender As Object, e As EventArgs) Handles btnDisplayPrice.Click
        Dim intRow, intCol As Integer

        Const intMax_Row As Integer = 5
        Const intMax_Col As Integer = 3

        Dim decPrice(,) = {{450D, 450D, 450D, 450D},
                            {425D, 425D, 425D, 425D},
                            {400D, 400D, 400D, 400D},
                            {375D, 375D, 375D, 375D},
                            {375D, 375D, 375D, 375D},
                            {350D, 350D, 350D, 350D}}
        Try
            intRow = CInt(txtRow.Text)
            intCol = CInt(txtCol.Text)

            If intRow >= 0 And intRow <= intMax_Row Then
                If intCol >= 0 And intCol <= intMax_Col Then
                    lblPrice.text = decPrice(intRow, intCol).ToString("c")
                Else
                    MessageBox.Show("Column must be 0 through" & intMax_Col.ToString())
                End If
            Else
                MessageBox.Show("Row must be 0 through" & intMax_Row.ToString())
            End If
        Catch ex As Exception
            MessageBox.Show("Row and Column must be integers")
        End Try
    End Sub
End Class