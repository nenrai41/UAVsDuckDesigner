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
            TotalMass_Label.Text += " " + $"{dataResults.TotalMass.ToString():F5}";
            PayloadMass_Label.Text += " " + $"{dataResults.PayloadMass.ToString():F5}";
            AvionicsMass_Label.Text += " " + $"{dataResults.AvionicsMass.ToString():F5}";
            FuelMass_Label.Text += " " + $"{dataResults.FuelMass.ToString():F5}";
            EngineMass_Label.Text += " " + $"{dataResults.EngineMass.ToString():F5}";
            WingMass_Label.Text += " " + $"{dataResults.WingMass.ToString():F5}";
            ControlMass_Label.Text += " " + $"{dataResults.ControlMass.ToString():F5}";
            StructureMass_Label.Text += " " + $"{dataResults.StructureMass.ToString():F5}";
            FrameMass_Label.Text += " " + $"{dataResults.FrameMass.ToString():F5}";
            StringerMass_Label.Text += " " + $"{dataResults.StringerMass.ToString():F5}";
            SkinMass_Label.Text += " " + $"{dataResults.SkinMass.ToString():F5}";

            // Размерная сводка
            LengthTotal_Label.Text += " " + $"{dataResults.LengthTotal.ToString():F5}";
            LengthAvionics_Label.Text += " " + $"{dataResults.LengthAvionics.ToString():F5}";
            LengthPayload_Label.Text += " " + $"{dataResults.LengthPayload.ToString():F5}";
            LengthFuel_Label.Text += " " + $"{dataResults.LengthFuel.ToString():F5}";
            LengthEngine_Label.Text += " " + $"{dataResults.LengthEngine.ToString():F5}";

            // Аэродинамика
            WingSpan_label.Text += " " + $"{dataResults.WingSpan.ToString():F5}";
            WingArea_Label.Text += " " + $"{dataResults.WingArea.ToString():F5}";
            ControlArea_Label.Text += " " + $"{dataResults.ControlArea.ToString():F5}";
            ControlSpan_Label.Text += " " + $"{dataResults.ControlSpan.ToString():F5}";
            WingPosition_label.Text += " " + $"{dataResults.WingPosition.ToString():F5}";
            ControlPosition_Label.Text += " " + $"{dataResults.ControlPosition.ToString():F5}";

            // Центр масс и фокус давления
            CG_Position_Label.Text += " " + $"{dataResults.CG_Position.ToString():F5}";
            CP_Position_Label.Text += " " + $"{dataResults.CP_Position.ToString():F5}"; 
            StabilityMargin_Label.Text += " " + $"{dataResults.StabilityMargin.ToString():F5}";

            // Результаты ABS
            CD_Label.Text += " " + $"{dataResults.CD.ToString():F5}"; 
            CL_Label.Text += " " + $"{dataResults.CL.ToString():F5}"; 

        }
    }
}
