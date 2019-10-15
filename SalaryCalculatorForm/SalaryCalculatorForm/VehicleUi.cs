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
    public partial class VehicleUi : Form
    {
        VehicleClass aVehicleClass = new VehicleClass();
        public VehicleUi()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicleClass.VehicleName = nameTextBox.Text;
            aVehicleClass.RegNo = regNoTextBox.Text;
            MessageBox.Show("Saved");

            //nameTextBox.Clear();
            //regNoTextBox.Clear();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double speed = Convert.ToDouble(speedTextBox.Text);
            aVehicleClass.Speeds.Add(speed);

            speedTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minTextBox.Text = aVehicleClass.GetMinSpeed().ToString();
            maxTextBox.Text = aVehicleClass.GetMaxSpeed().ToString();
            avgTextBox.Text = aVehicleClass.GetAvgSpeed().ToString();
        }
    }
}
