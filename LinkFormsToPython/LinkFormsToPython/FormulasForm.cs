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

        public static List<String> stateNames = new List<string>();
        public static List<double> deathsPerState = new List<double>();
        public static List<double> percentageSmokersPerState = new List<double>();
        public FormulasForm()
        {
            InitializeComponent();
            ImportCsvDataSets.run();
            stateNames = ImportCsvDataSets.stateNames;
            deathsPerState = ImportCsvDataSets.deathsPerState;
            percentageSmokersPerState = ImportCsvDataSets.percentageSmokersPerState;
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

            PercentageDeathsTextBox.Text = (Formulas.calcPredictedY(deathsPerState, percentageSmokersPerState, value)).ToString();
        }

        private void RevealButton_Click(object sender, EventArgs e)
        {

        }
    }
}
