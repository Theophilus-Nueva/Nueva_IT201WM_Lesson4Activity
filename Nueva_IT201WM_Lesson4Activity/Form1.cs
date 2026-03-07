using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nueva_IT201WM_Lesson4Activity
{
    public partial class Form1 : Form
    {

        private string picpath;
        private Double basicIncome = 0.00,
            basicNumhrs = 0.00,
            basicRate = 0.00,
            honoIncome = 0.00,
            honoNumhrs = 0.00,
            honoRate = 0.00,
            otherIncome = 0.00,
            otherNumhrs = 0.00,
            otherRate = 0.00;
        private Double netIncome = 0.00,
            grossIncome = 0.00,
            contribSSS = 0.00,
            contribPagibig = 0.00,
            ph = 0.00,
            tax = 0.00;
        private Double loanSSS = 0.00,
            loanPagibig = 0.00,
            salaryLoan = 0.00,
            fsDeposit = 0.00,
            fsLoan = 0.00,
            others = 0.00,
            totalDeduction = 0.00,
            totalContrib = 0.00,
            totalLoan = 0.00;


        private void others_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedDeduction = others_cb.SelectedItem.ToString();

            switch (selectedDeduction)
            {
                case "Other 1":
                    others_txtbox.Text = "1000.00";
                    break;
                case "Other 2":
                    others_txtbox.Text = "23.00";
                    break;
                case "Other 3":
                    others_txtbox.Text = "500.00";
                    break;
                default:
                    others_txtbox.Text = "0.00";
                    break;
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            Activity5_PrintFrm print1 = new Activity5_PrintFrm();

            if (this.payslipView_listbox.Items.Count == 0)
            {
                MessageBox.Show("Please click 'PREVIEW PAYSLIP DETAILS' first to generate the data.", "Nothing to Print");
                return;
            }

            print1.priDisplay_listbox.Items.Clear();

            print1.priDisplay_listbox.Items.AddRange(this.payslipView_listbox.Items);

            print1.Show();
        }


        private void previewBtn_Click(object sender, EventArgs e)
        {

            payslipView_listbox.Items.Clear();

            payslipView_listbox.Items.Add("");
            payslipView_listbox.Items.Add($"Employee Number: " + empNum_txtbox.Text);
            payslipView_listbox.Items.Add($"Firstname: " + firstName_txtbox.Text);
            payslipView_listbox.Items.Add($"Middlename: " + midName_txtbox.Text);
            payslipView_listbox.Items.Add($"Surname: " + surname_txtbox.Text);
            payslipView_listbox.Items.Add($"Designation: " + desig_txtbox.Text);
            payslipView_listbox.Items.Add($"Employee Status: " + empStatus_txtbox.Text);
            payslipView_listbox.Items.Add($"Department: " + deptName_txtbox.Text);
            payslipView_listbox.Items.Add($"Pay Date: " + paydate.Text);
            payslipView_listbox.Items.Add("---------------------------------------------------------------------------------------------------------------------------------");

            payslipView_listbox.Items.Add($"BP Num. of Hrs.: " + basicNumhrs_txtbox.Text);
            payslipView_listbox.Items.Add($"BP Rate / Hr.: " + basicRate_txtbox.Text);
            payslipView_listbox.Items.Add($"Basic Pay Income: " + basicIncome_txtbox.Text);
            payslipView_listbox.Items.Add("");

            payslipView_listbox.Items.Add($"HI Num. of Hrs.: " + honoNumhrs_txtbox.Text);
            payslipView_listbox.Items.Add($"HI Rate / Hr.: " + honoRate_txtbox.Text);
            payslipView_listbox.Items.Add($"Honorarium Income: " + honoIncome_txtbox.Text);
            payslipView_listbox.Items.Add("");

            payslipView_listbox.Items.Add($"OTI Num. of Hrs.: " + otherNumhrs_txtbox.Text);
            payslipView_listbox.Items.Add($"OTI Rate / Hr.: " + otherRate_txtbox.Text);
            payslipView_listbox.Items.Add($"Other Income: " + otherIncome_txtbox.Text);
            payslipView_listbox.Items.Add("---------------------------------------------------------------------------------------------------------------------------------");

            payslipView_listbox.Items.Add($"SSS Contribution: " + contribSSS_txtbox.Text);
            payslipView_listbox.Items.Add($"PhilHealth Contribution: " + ph_txtbox.Text);
            payslipView_listbox.Items.Add($"Pagibig Contribution: " + contribPagibig_txtbox.Text);
            payslipView_listbox.Items.Add($"Tax Contribution: " + tax_txtbox.Text);
            payslipView_listbox.Items.Add($"SSS Loan: " + loanSSS_txtbox.Text);
            payslipView_listbox.Items.Add($"Pagibig Loan: " + loanPagibig_txtbox.Text);
            payslipView_listbox.Items.Add($"Faculty Savings Deposit: " + fsDeposit_txtbox.Text);
            payslipView_listbox.Items.Add($"Faculty Savings Loan: " + fsLoan_txtbox.Text);
            payslipView_listbox.Items.Add($"Salary Loan:s " + salaryLoan_txtbox.Text);


            payslipView_listbox.Items.Add($"Other Loan:       " + others_txtbox.Text);

            payslipView_listbox.Items.Add("---------------------------------------------------------------------------------------------------------------------------------");

            payslipView_listbox.Items.Add("Total Deduction:  P" + totalDeduc_txtbox.Text);
            payslipView_listbox.Items.Add("Gross Income:     P" + grossIncome_txtbox.Text);
            payslipView_listbox.Items.Add("Net Income:       P" + netIncome_txtbox.Text);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            empNum_txtbox.Focus();

            // INCOME
            basicNumhrs_txtbox.Text = "0.00";
            basicRate_txtbox.Text = "0.00";
            honoNumhrs_txtbox.Text = "0.00";
            honoRate_txtbox.Text = "0.00";
            otherNumhrs_txtbox.Text = "0.00";
            otherRate_txtbox.Text = "0.00";

            // DEDUCTION
            contribSSS_txtbox.Text = "0.00";
            contribPagibig_txtbox.Text = "0.00";
            ph_txtbox.Text = "0.00";
            tax_txtbox.Text = "0.00";

            loanSSS_txtbox.Text = "0.00";
            loanPagibig_txtbox.Text = "0.00";
            fsDeposit_txtbox.Text = "0.00";
            fsLoan_txtbox.Text = "0.00";
            salaryLoan_txtbox.Text = "0.00";
            others_txtbox.Text = "0.00";

            // OTHERS
            others_cb.Text = "Select other deduction";
            others_cb.Items.Add("Other 1");
            others_cb.Items.Add("Other 2");
            others_cb.Items.Add("Other 3");
            others_cb.Items.Add("Other 4");

        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
            openFileDialog.Title = "Select Employee Picture";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picpath = openFileDialog.FileName;

                try
                {
                    pictureBox1.Image = Image.FromFile(picpath);
                }
                catch
                {
                    MessageBox.Show("Error loading image. The file might be corrupted or is not a valid image.", "Image Error");
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearTextboxBtn(object sender, EventArgs e)
        {
            empNum_txtbox.Clear();
            firstName_txtbox.Clear();
            midName_txtbox.Clear();
            surname_txtbox.Clear();
            civilStatus_txtbox.Clear();
            desig_txtbox.Clear();
            numDependent_txtbox.Clear();
            empStatus_txtbox.Clear();
            deptName_txtbox.Clear();


            basicIncome_txtbox.Text = "0.00";
            basicNumhrs_txtbox.Text = "0.00";
            basicRate_txtbox.Text = "0.00";

            honoIncome_txtbox.Text = "0.00";
            honoNumhrs_txtbox.Text = "0.00";
            honoRate_txtbox.Text = "0.00";

            otherIncome_txtbox.Text = "0.00";
            otherNumhrs_txtbox.Text = "0.00";
            otherRate_txtbox.Text = "0.00";


            netIncome_txtbox.Text = "0.00";
            grossIncome_txtbox.Text = "0.00";

            contribSSS_txtbox.Text = "0.00";
            contribPagibig_txtbox.Text = "0.00";
            ph_txtbox.Text = "0.00";
            tax_txtbox.Text = "0.00";

            loanSSS_txtbox.Text = "0.00";
            loanPagibig_txtbox.Text = "0.00";
            fsDeposit_txtbox.Text = "0.00";
            fsLoan_txtbox.Text = "0.00";
            salaryLoan_txtbox.Text = "0.00";
            others_txtbox.Text = "0.00";

            totalDeduc_txtbox.Text = "0.00";


            others_cb.Text = "Select other deduction";
            payslipView_listbox.Items.Clear();

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

            empNum_txtbox.Focus();
        }



        private void calculateBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(basicNumhrs_txtbox.Text) ||
                    string.IsNullOrWhiteSpace(basicRate_txtbox.Text) ||
                    string.IsNullOrWhiteSpace(firstName_txtbox.Text) ||
                    string.IsNullOrWhiteSpace(surname_txtbox.Text))
            {
                MessageBox.Show("Required fields are empty. Please fill out the Employee Details", "Input Required");
                empNum_txtbox.Focus();
                return;
            }

            if (!double.TryParse(basicRate_txtbox.Text, out basicRate))
            {
                MessageBox.Show("Invalid input: Rate per hour under Basic Pay must be a number.", "Input Error");
                basicRate_txtbox.Focus();
                return; 
            }

            if (!double.TryParse(otherRate_txtbox.Text, out otherRate))
            {
                MessageBox.Show("Invalid input: Rate per hour under Other Income must be a number.", "Input Error");
                otherRate_txtbox.Focus();
                return;
            }
            try
                {
                    // INCOME

                    // Basic Pay
                    basicNumhrs = Double.Parse(basicNumhrs_txtbox.Text);
                    basicRate = Convert.ToDouble(basicRate_txtbox.Text);
                    basicIncome = basicNumhrs * basicRate;
                    basicIncome_txtbox.Text = basicIncome.ToString("n");

                    // Honorarium
                    honoNumhrs = Convert.ToDouble(honoNumhrs_txtbox.Text);
                    honoRate = Convert.ToDouble(honoRate_txtbox.Text);
                    honoIncome = honoNumhrs * honoRate;
                    honoIncome_txtbox.Text = honoIncome.ToString("n");

                    // Other Income
                    otherNumhrs = Convert.ToDouble(otherNumhrs_txtbox.Text);
                    otherRate = Convert.ToDouble(otherRate_txtbox.Text);
                    otherIncome = otherNumhrs * otherRate;
                    otherIncome_txtbox.Text = otherIncome.ToString("n");

                    // Gross Income Total
                    grossIncome = basicIncome + honoIncome + otherIncome;
                    grossIncome_txtbox.Text = grossIncome.ToString("n");

                    tax = grossIncome * 0.01;
                    tax_txtbox.Text = tax.ToString("n");


                    // DEDUCTIONS CALCULATION

                    contribSSS = Convert.ToDouble(contribSSS_txtbox.Text);
                    contribPagibig = Convert.ToDouble(contribPagibig_txtbox.Text);
                    ph = Convert.ToDouble(ph_txtbox.Text);

                    loanSSS = Convert.ToDouble(loanSSS_txtbox.Text);
                    loanPagibig = Convert.ToDouble(loanPagibig_txtbox.Text);
                    salaryLoan = Convert.ToDouble(salaryLoan_txtbox.Text);
                    fsLoan = Convert.ToDouble(fsLoan_txtbox.Text);
                    fsDeposit = Convert.ToDouble(fsDeposit_txtbox.Text);

                    others = Convert.ToDouble(others_txtbox.Text);

                    // TOTALS
                    totalContrib = contribSSS + contribPagibig + ph + tax;
                    totalLoan = loanSSS + loanPagibig + salaryLoan + fsLoan + fsDeposit + others;
                    totalDeduction = totalContrib + totalLoan;

                    // DISPLAY SUMMARY
                    totalDeduc_txtbox.Text = totalDeduction.ToString("n");
                    netIncome = grossIncome - totalDeduction;
                    netIncome_txtbox.Text = netIncome.ToString("n");
                }
                catch
                {

                }
            }

        }
    }
