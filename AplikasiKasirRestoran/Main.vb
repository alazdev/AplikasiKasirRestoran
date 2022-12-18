Imports System.Globalization

Public Class Main
    Dim totalBayar As Integer = 0


    Private Sub bersihkan()
        num_menu1.Value = 0
        num_menu2.Value = 0
        num_menu3.Value = 0
        num_menu4.Value = 0
        num_menu5.Value = 0
        num_menu6.Value = 0
        num_menu7.Value = 0
        num_menu8.Value = 0
        num_menu9.Value = 0

        totalBayar = 0
        tbox_totalbayar.Text = ""
        num_bayar.Value = 0
        tbox_kembalian.Text = ""
    End Sub

    Private Sub btn_hitungkembalian_Click(sender As Object, e As EventArgs) Handles btn_hitungkembalian.Click
        Dim bayaran As Integer = num_bayar.Value
        If totalBayar > bayaran Then
            MessageBox.Show("Uangnya belum cukup hehehe...", "OOops")
        Else
            Dim kembalian As Integer = bayaran - totalBayar
            tbox_kembalian.Text = "Rp " & kembalian.ToString("#,#")
        End If
    End Sub

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        totalBayar = 0
        tbox_totalbayar.Text = ""
        num_bayar.Value = 0
        tbox_kembalian.Text = ""

        totalBayar += num_menu1.Value * 12000
        totalBayar += num_menu2.Value * 14000
        totalBayar += num_menu3.Value * 15000
        totalBayar += num_menu4.Value * 12000
        totalBayar += num_menu5.Value * 9000
        totalBayar += num_menu6.Value * 6000
        totalBayar += num_menu7.Value * 7000
        totalBayar += num_menu8.Value * 8000
        totalBayar += num_menu9.Value * 10000

        tbox_totalbayar.Text = "Rp " & totalBayar.ToString("#,#")
    End Sub

    Private Sub btn_bersihkan_Click(sender As Object, e As EventArgs) Handles btn_bersihkan.Click
        bersihkan()
    End Sub
End Class
