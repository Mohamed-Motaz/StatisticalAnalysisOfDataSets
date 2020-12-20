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
        public Form1()
        {
            InitializeComponent();
        }

        private string pythonExeDir = @"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Python37_64\python.exe";

       

        private void bargraphButton_click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = pythonExeDir;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            string script = @"C:\Users\moham\source\repos\PythonApplication1\PythonApplication1\PythonApplication1.py";
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
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ProcessStartInfo start = new ProcessStartInfo();
        //    start.FileName = @"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Python37_64\python.exe";
        //    start.UseShellExecute = false;
        //    start.RedirectStandardOutput = true;
        //    string script = @"C:\Users\moham\source\repos\PythonApplication1\PythonApplication1\PythonApplication1.py";
        //    start.Arguments = $"\"{script}\"";
        //    using (Process process = Process.Start(start))
        //    {
        //        using (StreamReader reader = process.StandardOutput)
        //        {
        //            string result = reader.ReadToEnd();
        //            Console.Write(result);
        //        }
        //    }
        //}
    }
}
