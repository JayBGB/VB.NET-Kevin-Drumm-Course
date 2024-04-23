Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblNumber1 As Double
        Dim dblNumber2 As Double
        Dim dblResult As Double

        dblNumber1 = txtNumber1.Text
        dblNumber2 = txtNumber2.Text

        dblResult = dblNumber1 + dblNumber2
        MessageBox.Show(dblResult)

        dblResult = dblNumber1 - dblNumber2
        MessageBox.Show(dblResult)

        dblResult = dblNumber1 * dblNumber2
        MessageBox.Show(dblResult)

        dblResult = dblNumber1 / dblNumber2
        MessageBox.Show(dblResult)

        dblResult = dblNumber1 ^ dblNumber2
        MessageBox.Show(dblResult)

        dblResult = dblNumber1 \ dblNumber2
        MessageBox.Show(dblResult)

        dblResult = dblNumber1 Mod dblNumber2
        MessageBox.Show(dblResult)

    End Sub
End Class
