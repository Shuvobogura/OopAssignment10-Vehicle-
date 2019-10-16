using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorForm
{
    
    public partial class RefrigeratorUi : Form
    {
        Refrigerator aRefrigerator=new Refrigerator();
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aRefrigerator.MaximumWeight = Convert.ToDouble(maximumWeightTextBox.Text);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                double item = Convert.ToDouble(totalItemsTextBox.Text);
                double weight = Convert.ToDouble(weightTextBox.Text);
                double totalWeight = item * weight;

                if (totalWeight+aRefrigerator.TotalWeights.Sum()>aRefrigerator.MaximumWeight)
                {
                    MessageBox.Show("Your given amount can't be entered because it will be over flow");
                    return;
                }

                currentWeightTextBox.Text = aRefrigerator.GetCurrentWeight(totalWeight).ToString();
                remainingWeightTextBox.Text = aRefrigerator.GetRemainingWeight().ToString();
            }
            catch (Exception exception)
            {

            }
        }
    }
}
