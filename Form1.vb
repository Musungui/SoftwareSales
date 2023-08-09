Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCostofLicensing, decOptional As Decimal
        Dim RadiobuttonYearly, RadiobuttonOneTimePurchase, CheckBoxTechnicalSupport, CheckboxTraining, Checkboxcloudcost As Decimal
            RadiobuttonYearly = radioButtonYearlyLicense.Checked
            RadiobuttonOneTimePurchase = radioButtonOneTime.Checked
            CheckBoxTechnicalSupport = checkBoxLevel3.Checked
            CheckboxTraining = checkBoxOnSite.Checked
            Checkboxcloudcost = checkBoxCloud.Checked


        If radioButtonYearlyLicense.Checked Then
            RadiobuttonYearly = 5000
        Else
            RadiobuttonYearly = 0
        End If

        If radioButtonOneTime.Checked Then
            RadiobuttonOneTimePurchase = 20000
        Else
            RadiobuttonOneTimePurchase = 0
        End If

        If checkBoxLevel3.Checked Then
            CheckBoxTechnicalSupport = 3500
        Else
            CheckBoxTechnicalSupport = 0
        End If

        If checkBoxOnSite.Checked Then
            CheckboxTraining = 2000
        Else
            CheckboxTraining = 0
        End If

        If checkBoxCloud.Checked Then
            Checkboxcloudcost = 300
        Else
            Checkboxcloudcost = 0
        End If

        decCostofLicensing = (RadiobuttonYearly + RadiobuttonOneTimePurchase)
        lblSoftwareLicensingCost.Text = decCostofLicensing.ToString("C")

        decOptional = (CheckboxTraining + CheckBoxTechnicalSupport + Checkboxcloudcost)
        lblOptional.Text = decOptional.ToString("C")



    End Sub

    Private Sub radioButtonYearlyLicense_CheckedChanged(sender As Object, e As EventArgs) Handles radioButtonYearlyLicense.CheckedChanged

    End Sub

    Private Sub radioButtonOneTime_CheckedChanged(sender As Object, e As EventArgs) Handles radioButtonOneTime.CheckedChanged

    End Sub

    Private Sub checkBoxLevel3_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxLevel3.CheckedChanged

    End Sub

    Private Sub checkBoxOnSite_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxOnSite.CheckedChanged


    End Sub

    Private Sub checkBoxCloud_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxCloud.CheckedChanged

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radioButtonYearlyLicense.Checked = False
        radioButtonOneTime.Checked = False

        checkBoxLevel3.Checked = False
        checkBoxOnSite.Checked = False
        checkBoxCloud.Checked = False

        lblSoftwareLicensingCost.Text = " "
        lblOptional.Text = " "


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
