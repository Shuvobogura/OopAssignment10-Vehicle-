using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorForm
{
    public partial class SalaryCalculator : Form
    {
        SalaryClass eSalaryClass=new SalaryClass();
        public SalaryCalculator()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            eSalaryClass.Name = nameTextBox.Text;
            eSalaryClass.BasicSalary = Convert.ToDouble(salaryTextBox.Text);
            eSalaryClass.HouseRent = Convert.ToDouble(houseRentTextBox.Text);
            eSalaryClass.MedicalAllowance = Convert.ToDouble(medicalTextBox.Text);

            MessageBox.Show("Name is : "+eSalaryClass.Name+" Salary is : "+eSalaryClass.GetTotalSalary());
        }
    }
}
