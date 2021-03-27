using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkFormsToPython
{
    public partial class Form1 : Form
    {
        
        private string pythonExeDir = @"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Python37_64\python.exe";
        private string pythonScriptsLocation = @"C:\Users\moham\Desktop\StatisticalAnalysisOfDataSets\Graphs\";
        private string statesToDeaths = "StatesToDeaths.py";
        private string statesToSmokers = "StatesToSmokers.py";

        public Form1()
        {
            InitializeComponent();
        }

        
        private void barGraphButton_click(object sender, EventArgs e)
        {
            runPythonScript("bargraph" + statesToDeaths);
        }
        private void boxPlotButton_Click(object sender, EventArgs e)
        {
            runPythonScript("boxplot" + statesToDeaths);
        }

        private void dotPlotButton_Click(object sender, EventArgs e)
        {
            runPythonScript("dotplot"+ statesToDeaths);
        }

        private void histogramButton_Click(object sender, EventArgs e)
        {
            runPythonScript("histogram" + statesToDeaths);
        }

        private void pieChartButton_Click(object sender, EventArgs e)
        {
            runPythonScript("piechart" + statesToDeaths);
        }

        private void ScatterPlotButton_Click(object sender, EventArgs e)
        {
            runPythonScript("scatterplot" + statesToDeaths);
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            runPythonScript("bargraph" + statesToSmokers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runPythonScript("boxplot" + statesToSmokers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            runPythonScript("dotplot" + statesToSmokers);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            runPythonScript("histogram" + statesToSmokers);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            runPythonScript("piechart" + statesToSmokers);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            runPythonScript("scatterplot" + statesToSmokers);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            runPythonScript("regressionAnalysis.py");
        }

        private void runPythonScript(string path)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = pythonExeDir;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            string script = pythonScriptsLocation + path;
            start.Arguments = $"\"{script}\"";
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }

        private void ShowFormulasButton_Click(object sender, EventArgs e)
        {
            FormulasForm formulasForm = new FormulasForm();
            formulasForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    } 
}
