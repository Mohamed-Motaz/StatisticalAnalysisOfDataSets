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

        public Form1()
        {
            InitializeComponent();
        }

        
        private void barGraphButton_click(object sender, EventArgs e)
        {
            runPythonScript("bargraph.py");
        }
        private void boxPlotButton_Click(object sender, EventArgs e)
        {
            runPythonScript("boxplot.py");
        }

        private void dotPlotButton_Click(object sender, EventArgs e)
        {
            runPythonScript("dotplot.py"); ;
        }

        private void histogramButton_Click(object sender, EventArgs e)
        {
            runPythonScript("histogram.py");
        }

        private void pieChartButton_Click(object sender, EventArgs e)
        {
            runPythonScript("piechart.py");
        }

        private void TestGraphButton_Click(object sender, EventArgs e)
        {
            runPythonScript("tesgraph.py");
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
    } 
}
