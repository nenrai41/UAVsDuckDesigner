namespace UAVsDuckDesigner
{
    public partial class Form1 : Form
    {
        private InputValidator inputValidator;
        private DataProcessor _dataProcessor;
        private PythonAeroSandboxRunner _asb;
        private DataResults _dataResults;
        public Form1()
        {
            InitializeComponent();
            SaveModel_Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            SaveModel_Dialog.Title = "Сохранить файл";
            _asb = PythonAeroSandboxRunner.GetInstance();
            inputValidator = new InputValidator();
            _dataResults = new DataResults();
            _dataProcessor = new DataProcessor();
        }

        private void K_Payload_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(K_Payload_TextBox.Text, out temp_value))
                inputValidator.K_Payload = temp_value;
        }

        private void K_Avionics_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(K_Avionics_TextBox.Text, out temp_value))
                inputValidator.K_Avionics = temp_value;
        }

        private void K_Fuel_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(K_Fuel_TextBox.Text, out temp_value))
                inputValidator.K_Fuel = temp_value;
        }

        private void K_Engine_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(K_Engine_TextBox.Text, out temp_value))
                inputValidator.K_Engine = temp_value;
        }

        private void K_Wing_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(K_Wing_TextBox.Text, out temp_value))
                inputValidator.K_Wing = temp_value;
        }

        private void K_Control_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(K_Control_TextBox.Text, out temp_value))
                inputValidator.K_Control = temp_value;
        }

        private void PayloadMass_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(PayloadMass_TextBox.Text, out temp_value))
                inputValidator.PayloadMass = temp_value;
        }

        private void Speed_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(Speed_TextBox.Text, out temp_value))
                inputValidator.Speed = temp_value;
        }

        private void Diameter_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(Diameter_TextBox.Text, out temp_value))
                inputValidator.Diameter = temp_value;
        }

        private void Chord_Wing_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(Chord_Wing_TextBox.Text, out temp_value))
                inputValidator.Chord_Wing = temp_value;
        }

        private void Chord_Control_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(Chord_Control_TextBox.Text, out temp_value))
                inputValidator.Chord_Control = temp_value;
        }

        private void Rho_Avionics_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(Rho_Avionics_TextBox.Text, out temp_value))
                inputValidator.Rho_Avionics = temp_value;
        }

        private void Rho_Payload_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(Rho_Payload_TextBox.Text, out temp_value))
                inputValidator.Rho_Payload = temp_value;
        }

        private void Rho_Fuel_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(Rho_Fuel_TextBox.Text, out temp_value))
                inputValidator.Rho_Fuel = temp_value;
        }

        private void Rho_Engine_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(Rho_Engine_TextBox.Text, out temp_value))
                inputValidator.Rho_Engine = temp_value;
        }

        private void Rho_Frame_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(Rho_Frame_TextBox.Text, out temp_value))
                inputValidator.Rho_Frame = temp_value;
        }

        private void Rho_Stringer_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(Rho_Stringer_TextBox.Text, out temp_value))
                inputValidator.Rho_Stringer = temp_value;
        }

        private void Rho_Skin_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(Rho_Skin_TextBox.Text, out temp_value))
                inputValidator.Rho_Skin = temp_value;
        }

        private void SkinThickness_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(SkinThickness_TextBox.Text, out temp_value))
                inputValidator.SkinThickness = temp_value;
        }

        private void EngineThrust_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(EngineThrust_TextBox.Text, out temp_value))
                inputValidator.EngineThrust = temp_value;
        }

        private void FuelConsumptionRate_TextBox_TextChanged(object sender, EventArgs e)
        {
            double temp_value;
            if (Manipulator.ConvertTo(FuelConsumptionRate_TextBox.Text, out temp_value))
                inputValidator.FuelConsumptionRate = temp_value;
        }

        private void Calculations_Button_Click(object sender, EventArgs e)
        {
            if (inputValidator.IsEnterTheRelativeMassesCorrectly(_dataProcessor, _asb))
            {
                _dataProcessor.Calculate(_dataResults);
                _asb.CreateAndVisualizeAircraft(_dataResults);
            }
        }

        private void ShowResults_Button_Click(object sender, EventArgs e)
        {
            var resultsWindow = new ResultForm();
            resultsWindow.SetResults(_dataResults);
            resultsWindow.Show();
        }

        private void ProfileOfWingNames_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputValidator.ProfileOfWingName = ProfileOfWingNames_ComboBox.Text;
        }

        private void ProfileOfControlNames_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputValidator.ProfileOfControlName = ProfileOfControlNames_ComboBox.Text;
        }

        private void SaveModel_Dialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void SaveModelBotton_Click(object sender, EventArgs e)
        {
            // Настройка диалога
            SaveModel_Dialog.Filter = "STL files (*.stl)|*.stl|OBJ files (*.obj)|*.obj";
            SaveModel_Dialog.DefaultExt = "stl";
            SaveModel_Dialog.Title = "Сохранить модель AeroSandbox";

            // Показываем диалог и проверяем результат
            if (SaveModel_Dialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь ТОЛЬКО после подтверждения
                string filePath = SaveModel_Dialog.FileName;

                try
                {
                    _asb.SaveModelToFile(filePath, _dataResults);
                    MessageBox.Show($"Модель сохранена в:\n{filePath}", "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении:\n{ex.Message}", "Ошибка");
                }
            }
        }
    }
}
