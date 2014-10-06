Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim Result As Double
        Dim aSt As String = txtSideOne.Text
        Dim bSt As String = txtSideTwo.Text
        Dim a, b As Double
        a = CDbl(aSt)
        b = CDbl(bst)
        Result = Hypotenuse(a, b)
        txtHyp.Text = CStr(Result)

    End Sub

    Function Hypotenuse(ByVal a As Double, ByVal b As Double) As Double
        Dim C As Double = Math.Sqrt(a ^ 2 + b ^ 2)
        Return C
    End Function

End Class
