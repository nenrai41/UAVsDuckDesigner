using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAVsDuckDesigner
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
        public void SetResults(DataResults dataResults)
        {
            // Массовая сводка
            TotalMass_Label.Text += " " + $"{dataResults.TotalMass:F5}";
            PayloadMass_Label.Text += " " + $"{dataResults.PayloadMass:F5}";
            AvionicsMass_Label.Text += " " + $"{dataResults.AvionicsMass:F5}";
            FuelMass_Label.Text += " " + $"{dataResults.FuelMass:F5}";
            EngineMass_Label.Text += " " + $"{dataResults.EngineMass:F5}";
            WingMass_Label.Text += " " + $"{dataResults.WingMass:F5}";
            ControlMass_Label.Text += " " + $"{dataResults.ControlMass:F5}";
            StructureMass_Label.Text += " " + $"{dataResults.StructureMass:F5}";
            FrameMass_Label.Text += " " + $"{dataResults.FrameMass:F5}";
            StringerMass_Label.Text += " " + $"{dataResults.StringerMass:F5}";
            SkinMass_Label.Text += " " + $"{dataResults.SkinMass:F5}";

            // Размерная сводка
            LengthTotal_Label.Text += " " + $"{dataResults.LengthTotal:F5}";
            LengthAvionics_Label.Text += " " + $"{dataResults.LengthAvionics:F5}";
            LengthPayload_Label.Text += " " + $"{dataResults.LengthPayload:F5}";
            LengthFuel_Label.Text += " " + $"{dataResults.LengthFuel:F5}";
            LengthEngine_Label.Text += " " + $"{dataResults.LengthEngine:F5}";

            // Аэродинамика
            WingSpan_label.Text += " " + $"{dataResults.WingSpan:F5}";
            WingArea_Label.Text += " " + $"{dataResults.WingArea:F5}";
            ControlArea_Label.Text += " " + $"{dataResults.ControlArea:F5}";
            ControlSpan_Label.Text += " " + $"{dataResults.ControlSpan:F5}";
            WingPosition_label.Text += " " + $"{dataResults.WingPosition:F5}";
            ControlPosition_Label.Text += " " + $"{dataResults.ControlPosition:F5}";

            // Центр масс и фокус давления
            CG_Position_Label.Text += " " + $"{dataResults.CG_Position:F5}";
            CP_Position_Label.Text += " " + $"{dataResults.CP_Position:F5}"; 
            StabilityMargin_Label.Text += " " + $"{dataResults.StabilityMargin:F5}";

            // Результаты ABS
            CD_Label.Text += " " + $"{dataResults.CD:F5}"; 
            CL_Label.Text += " " + $"{dataResults.CL:F5}"; 

        }
    }
}
