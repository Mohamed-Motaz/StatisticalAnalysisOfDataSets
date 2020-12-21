using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkFormsToPython
{
    public partial class FormulasForm : Form
    {
        List<double> dataSet1 = new List<double>();
        List<double> dataSet2 = new List<double>();
        public FormulasForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (PercentageMasksWornTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a value to predict.");
                return;
            }
            double value;
            try
            {
                value = Double.Parse(PercentageMasksWornTextBox.Text);
            }catch (Exception)
            {
                MessageBox.Show("Please enter a valid value");
                return;
            }
            if (value > 1) value /= 100;

            PercentageDeathsTextBox.Text = (Formulas.calcPredictedY(dataSet1, dataSet2, value)).ToString();
        }

        private void RevealButton_Click(object sender, EventArgs e)
        {

        }
    }
}
