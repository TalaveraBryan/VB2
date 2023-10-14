
Public Class Form1


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub OriginTxt_TextChanged(sender As Object, e As EventArgs) Handles OriginTxt.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each i As TextBox In Me.Controls.OfType(Of TextBox)
            i.Clear()
        Next
        ComboboxFrom.Text = ("")
        ComboboxTo.Text = ("")
        DiscountCombo.Text = ("")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OriginTxt.Text = ComboboxFrom.SelectedItem
        DestinationTxt.Text = ComboboxTo.SelectedItem
        Dim From As String = ComboboxFrom.SelectedItem
        Dim Tol As String = ComboboxTo.SelectedItem

        Dim fare As Integer = 20
        Dim grosspay As Integer = Math.Abs(ComboboxFrom.SelectedIndex - ComboboxTo.SelectedIndex) * fare
        GrossTxt.Text = grosspay










        Select Case DiscountCombo.SelectedIndex
            Case 0 'add 10% discount
                'DiscountCombo.SelectedIndex = grosspay * 0.1
                'GrossTxt.Text = ((10 / 100) * fare)
            Case 1 'add 15% discount 
                'DiscountCombo.SelectedIndex = grosspay * 0.15
                'NetfareTxt.Text = ((15 / 100) * fare)
            Case 2 'add 20% discount 
                'DiscountCombo.SelectedIndex = grosspay * 0.2
                Discounttext.Text = ((20 / 100) * grosspay)
                NetfareTxt.Text = grosspay - ((20 / 100) * grosspay)

            Case 3 'add 50% discount 
                'DiscountCombo.SelectedIndex = grosspay * 0.5

        End Select


    End Sub

    Private Sub DiscountCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DiscountCombo.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loc As String() = {"", "CONCEPCION", "URDANETA CITY", "ROSALES", "PANIQUI", "MONCADA", "TARLAC CITY", "CAPAS", "BAMBAN", "MABALACAT CITY", "ANGELES CITY"}
        For I As Integer = 0 To loc.Length - 1
            ComboboxFrom.Items.Add(loc(I))
            ComboboxTo.Items.Add(loc(I))
        Next
        ComboboxFrom.SelectedIndex = 0
        ComboboxTo.SelectedIndex = 0


    End Sub
End Class
