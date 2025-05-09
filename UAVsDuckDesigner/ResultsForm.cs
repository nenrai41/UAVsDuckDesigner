using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAVsDuckDesigner
{
    public partial class ResultsForm : Form
    {
        private DataResults _dataResults;
        public ResultsForm(DataResults dataResults)
        {
            _dataResults = dataResults;
            InitializeComponent();
        }
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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



        
        private void InitializeComponent()
        {
            TotalMass_Label = new Label();
            SuspendLayout();
            // 
            // TotalMass_Label
            // 
            TotalMass_Label.AutoSize = true;
            TotalMass_Label.Location = new Point(12, 9);
            TotalMass_Label.Name = "TotalMass_Label";
            TotalMass_Label.Size = new Size(38, 15);
            TotalMass_Label.TabIndex = 0;
            TotalMass_Label.Text = $"Общая масса БПЛА: {_dataResults.TotalMass}";
            TotalMass_Label.Click += TotalMass_Label_Click;
            // 
            // ResultsForm
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(TotalMass_Label);
            Name = "ResultsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void TotalMass_Label_Click(object sender, EventArgs e)
        {

        }

        private Label TotalMass_Label;
    }
}
