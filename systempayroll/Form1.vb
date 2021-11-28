Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim netpay As Double
        Dim gross As Double
        Dim week, hour, sun, sat, sathour, sunhour As Double
        Dim dec, tax As Double
        week = Convert.ToDouble(txtWeek.Text) * 125
        sun = Convert.ToDouble(txtSun.Text) * 80
        sat = Convert.ToDouble(txtSat.Text) * 160
        hour = Convert.ToDouble(txtHourRate.Text) * 180
        sathour = Convert.ToDouble(txtHRsat.Text) * 145
        sunhour = Convert.ToDouble(txtHRsun.Text) * 30
        gross = (week + hour + sun + sat + sathour + sunhour)

        dec = gross * (10 / 100)
        tax = gross * (15 / 100)
        netpay = gross - tax - dec
        txtGross.Text = Convert.ToString(gross)
        txtDec.Text = Convert.ToString(dec)
        txtTax.Text = Convert.ToString(tax)
        TextBox13.Text = Convert.ToString(netpay)



    End Sub
End Class
