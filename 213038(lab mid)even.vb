
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Console.()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Public MainForm()
        {
            InitializeComponent();
        }

        Private void MainForm_Load(Object sender, EventArgs e)
        {
            // Set the default value of the Basic Salary based on the Employee Grade Level
            comboBoxGradeLevel.SelectedIndex = 0;
            SetBasicSalary();

            // Add items to the CheckedListBox for Bonuses
            checkedListBoxBonuses.Items.Add("Project Completion Bonus", False);
            checkedListBoxBonuses.Items.Add("Year End Bonus", False);
            checkedListBoxBonuses.Items.Add("Performance Bonus", False);
            checkedListBoxBonuses.Items.Add("Customer appreciation Bonus", False);
        }
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Private void SetBasicSalary()
        {
            Switch(comboBoxGradeLevel.Text)
            {
                Case "Director"
        radioButton30000.Checked = True;
                    break;
                Case "Manager"
        radioButton40000.Checked = True;
                    break;
                Case "Project Manager"
        radioButton50000.Checked = True;
                    break;
                Case "Programmer"
        radioButton100000.Checked = True;
                    break;
                Default
                    break;
            }
        }
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
        Private void buttonCalculate_Click(Object sender, EventArgs e)
        {
            Double basicSalary = 0;
            Double benefitsTotal = 0;
            Double bonusesTotal = 0;
            Double deductions = 0;

            // Calculate Basic Salary
            If (radioButton30000.Checked) Then basicSalary = 30000;
            If (radioButton40000.Checked) Then basicSalary = 40000;
            If (radioButton50000.Checked) Then basicSalary = 50000;
            If (radioButton100000.Checked) Then basicSalary = 100000;

            // Calculate Benefits
            If (checkBoxHousingAllowance.Checked) Then benefitsTotal += 20000;
            If (checkBoxConveyanceAllowance.Checked) Then benefitsTotal += 15000;
            If (checkBoxOtherBenefit1.Checked) Then benefitsTotal += 10000;
            If (checkBoxOtherBenefit2.Checked) Then benefitsTotal += 10000;

            // Calculate Bonuses
            foreach(String item In checkedListBoxBonuses.CheckedItems)
            {
                Switch(item)
                {
                    Case "Project Completion Bonus"
                                        bonusesTotal += 20000;
                        break;
                    Case "Year End Bonus"
                                        bonusesTotal += 30000;
                        break;
                    Case "Performance Bonus"
                                        bonusesTotal += 25000;
                        break;
                    Case "Customer appreciation Bonus"
                                        bonusesTotal += 15000;
                        break;
                }
            }

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
