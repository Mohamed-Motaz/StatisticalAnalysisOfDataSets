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
        public static List<double> percentageDeathsPerState = new List<double>();
        public static List<double> percentageSmokersPerState = new List<double>();
        public FormulasForm()
        {
            InitializeComponent();
            ImportCsvDataSets.run();
            stateNames = ImportCsvDataSets.stateNames;
            percentageDeathsPerState = ImportCsvDataSets.percentageDeathsPerState;
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

            PercentageDeathsTextBox.Text = (Formulas.calcPredictedY(percentageDeathsPerState, percentageSmokersPerState, value)).ToString();
        }

        private void RevealButton_Click(object sender, EventArgs e)
        {
            
            MeanDeathsTextBox.Text = Math.Round(Formulas.calcMeanUnGroupedData(percentageDeathsPerState), 2).ToString();
            MeanPercentageSmokersTextBox.Text = Math.Round(Formulas.calcMeanUnGroupedData(percentageSmokersPerState), 2).ToString();

            VarianceDeathsTextBox.Text = Math.Round(Formulas.calcVarianceUnGrouped(percentageDeathsPerState), 2).ToString();
            VariancePercentageSmokersTextBox.Text = Math.Round(Formulas.calcVarianceUnGrouped(percentageSmokersPerState), 2).ToString();

            StandardDeviationDeathsTextBox.Text = Math.Round(Formulas.calcStandardDeviationUnGrouped(percentageDeathsPerState), 2).ToString();
            StandardDeviationPercentageSmokersTextBox.Text = Math.Round(Formulas.calcStandardDeviationUnGrouped(percentageSmokersPerState), 2).ToString();

            double val = Math.Round(Formulas.calcPearsonR(percentageDeathsPerState, percentageSmokersPerState), 2);
            PearsonsRTextBox.Text = val.ToString();

            if (val == 1)
                textBox2.Text = "perfect positive linear";
            else if (val >= 0.7)
                textBox2.Text = "strong positive linear";
            else if (val >= 0.3)
                textBox2.Text = "medium positive linear";
            else if (val > 0.0)
                textBox2.Text = "weak positive linear";
            else if (val > -0.3)
                textBox2.Text = "weak negative linear";
            else if (val > -0.7)
                textBox2.Text = "medium negative linear";
            else if (val > -1)
                textBox2.Text = "strong negative linear";
            else if (val == -1)
                textBox2.Text = "perfect negative linear";

        }
    }
}
