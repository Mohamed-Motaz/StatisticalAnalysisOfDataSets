namespace LinkFormsToPython
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.barGraphButton = new System.Windows.Forms.Button();
            this.TestGraphButton = new System.Windows.Forms.Button();
            this.pieChartButton = new System.Windows.Forms.Button();
            this.histogramButton = new System.Windows.Forms.Button();
            this.dotPlotButton = new System.Windows.Forms.Button();
            this.boxPlotButton = new System.Windows.Forms.Button();
            this.ShowFormulasButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barGraphButton
            // 
            this.barGraphButton.Location = new System.Drawing.Point(32, 91);
            this.barGraphButton.Name = "barGraphButton";
            this.barGraphButton.Size = new System.Drawing.Size(139, 59);
            this.barGraphButton.TabIndex = 0;
            this.barGraphButton.Text = "Bar Graph";
            this.barGraphButton.UseVisualStyleBackColor = true;
            this.barGraphButton.Click += new System.EventHandler(this.barGraphButton_click);
            // 
            // TestGraphButton
            // 
            this.TestGraphButton.Location = new System.Drawing.Point(373, 316);
            this.TestGraphButton.Name = "TestGraphButton";
            this.TestGraphButton.Size = new System.Drawing.Size(139, 59);
            this.TestGraphButton.TabIndex = 1;
            this.TestGraphButton.Text = "Test Graph";
            this.TestGraphButton.UseVisualStyleBackColor = true;
            this.TestGraphButton.Click += new System.EventHandler(this.TestGraphButton_Click);
            // 
            // pieChartButton
            // 
            this.pieChartButton.Location = new System.Drawing.Point(373, 195);
            this.pieChartButton.Name = "pieChartButton";
            this.pieChartButton.Size = new System.Drawing.Size(139, 59);
            this.pieChartButton.TabIndex = 2;
            this.pieChartButton.Text = "Pie Chart";
            this.pieChartButton.UseVisualStyleBackColor = true;
            this.pieChartButton.Click += new System.EventHandler(this.pieChartButton_Click);
            // 
            // histogramButton
            // 
            this.histogramButton.Location = new System.Drawing.Point(373, 91);
            this.histogramButton.Name = "histogramButton";
            this.histogramButton.Size = new System.Drawing.Size(139, 59);
            this.histogramButton.TabIndex = 3;
            this.histogramButton.Text = "Histogram";
            this.histogramButton.UseVisualStyleBackColor = true;
            this.histogramButton.Click += new System.EventHandler(this.histogramButton_Click);
            // 
            // dotPlotButton
            // 
            this.dotPlotButton.Location = new System.Drawing.Point(32, 316);
            this.dotPlotButton.Name = "dotPlotButton";
            this.dotPlotButton.Size = new System.Drawing.Size(139, 59);
            this.dotPlotButton.TabIndex = 4;
            this.dotPlotButton.Text = "Dot Plot";
            this.dotPlotButton.UseVisualStyleBackColor = true;
            this.dotPlotButton.Click += new System.EventHandler(this.dotPlotButton_Click);
            // 
            // boxPlotButton
            // 
            this.boxPlotButton.Location = new System.Drawing.Point(32, 195);
            this.boxPlotButton.Name = "boxPlotButton";
            this.boxPlotButton.Size = new System.Drawing.Size(139, 59);
            this.boxPlotButton.TabIndex = 5;
            this.boxPlotButton.Text = "Box Plot";
            this.boxPlotButton.UseVisualStyleBackColor = true;
            this.boxPlotButton.Click += new System.EventHandler(this.boxPlotButton_Click);
            // 
            // ShowFormulasButton
            // 
            this.ShowFormulasButton.Location = new System.Drawing.Point(207, 440);
            this.ShowFormulasButton.Name = "ShowFormulasButton";
            this.ShowFormulasButton.Size = new System.Drawing.Size(139, 59);
            this.ShowFormulasButton.TabIndex = 6;
            this.ShowFormulasButton.Text = "Show Formulas";
            this.ShowFormulasButton.UseVisualStyleBackColor = true;
            this.ShowFormulasButton.Click += new System.EventHandler(this.ShowFormulasButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 537);
            this.Controls.Add(this.ShowFormulasButton);
            this.Controls.Add(this.boxPlotButton);
            this.Controls.Add(this.dotPlotButton);
            this.Controls.Add(this.histogramButton);
            this.Controls.Add(this.pieChartButton);
            this.Controls.Add(this.TestGraphButton);
            this.Controls.Add(this.barGraphButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button barGraphButton;
        private System.Windows.Forms.Button TestGraphButton;
        private System.Windows.Forms.Button pieChartButton;
        private System.Windows.Forms.Button histogramButton;
        private System.Windows.Forms.Button dotPlotButton;
        private System.Windows.Forms.Button boxPlotButton;
        private System.Windows.Forms.Button ShowFormulasButton;
    }
}

