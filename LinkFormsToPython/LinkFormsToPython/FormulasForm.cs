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
                value = double.Parse(PercentageMasksWornTextBox.Text);
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
            MeanDeathsTextBox.Text = Formulas.calcMeanUnGroupedData(deathsPerState).ToString();
            MeanPercentageSmokersTextBox.Text = Formulas.calcMeanUnGroupedData(percentageSmokersPerState).ToString();

            VarianceDeathsTextBox.Text = Formulas.calcVarianceUnGrouped(deathsPerState).ToString();
            VariancePercentageSmokersTextBox.Text = Formulas.calcVarianceUnGrouped(percentageSmokersPerState).ToString();

            StandardDeviationDeathsTextBox.Text = Formulas.calcStandardDeviationUnGrouped(deathsPerState).ToString();
            StandardDeviationPercentageSmokersTextBox.Text = Formulas.calcStandardDeviationUnGrouped(percentageSmokersPerState).ToString();

            double val = Formulas.calcPearsonR(deathsPerState, percentageSmokersPerState);
            PearsonsRTextBox.Text = val.ToString();

            if (val >= 0.7)
                textBox2.Text = "strong positive linear";
            else if (val >= 0.3)
                textBox2.Text = "medium positive linear";
            else if (val > 0.0)
                textBox2.Text = "weak positive linear";
            else if (val >= -0.3)
                textBox2.Text = "weak negaive linear";
            else if (val >= -0.7)
                textBox2.Text = "medium negative linear";
            else if (val >= -1)
                textBox2.Text = "strong negative linear";

        }
    }
}
