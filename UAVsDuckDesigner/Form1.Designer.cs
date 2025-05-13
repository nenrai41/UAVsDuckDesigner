namespace UAVsDuckDesigner
{
    partial class Form1
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            K_Payload_TextBox = new TextBox();
            K_Avionics_TextBox = new TextBox();
            K_Fuel_TextBox = new TextBox();
            K_Engine_TextBox = new TextBox();
            K_Wing_TextBox = new TextBox();
            K_Control_TextBox = new TextBox();
            PayloadMass_TextBox = new TextBox();
            Chord_Wing_TextBox = new TextBox();
            Chord_Control_TextBox = new TextBox();
            Speed_TextBox = new TextBox();
            Diameter_TextBox = new TextBox();
            Rho_Avionics_TextBox = new TextBox();
            Rho_Payload_TextBox = new TextBox();
            Rho_Fuel_TextBox = new TextBox();
            Rho_Engine_TextBox = new TextBox();
            Rho_Frame_TextBox = new TextBox();
            Rho_Stringer_TextBox = new TextBox();
            Rho_Skin_TextBox = new TextBox();
            SkinThickness_TextBox = new TextBox();
            EngineThrust_TextBox = new TextBox();
            FuelConsumptionRate_TextBox = new TextBox();
            K_Payload_Label = new Label();
            K_Avionics_Label = new Label();
            K_Fuel_Label = new Label();
            K_Engine_Label = new Label();
            K_Wing_Label = new Label();
            K_Control_Label = new Label();
            PayloadMass_Label = new Label();
            Chord_Wing_Label = new Label();
            Chord_Control_Label = new Label();
            Speed_Label = new Label();
            DiameterLabel = new Label();
            Rho_Avionics_Label = new Label();
            Rho_Payload_Label = new Label();
            Rho_Fuel_Label = new Label();
            Rho_Engine_Label = new Label();
            Rho_Frame_Label = new Label();
            MaterialParemeters_Label = new Label();
            Rho_Stringer_Label = new Label();
            Rho_Skin_Label = new Label();
            SkinThickness_Label = new Label();
            RHO_Label = new Label();
            RelativeMasses_Label = new Label();
            EngineThrust_Label = new Label();
            FuelConsumptionRate_Label = new Label();
            Calculations_Button = new Button();
            ProfileOfWingNames_Label = new Label();
            ProfileOfControlNames_Label = new Label();
            ShowResults_Button = new Button();
            ProfileOfWingNames_ComboBox = new ComboBox();
            ProfileOfControlNames_ComboBox = new ComboBox();
            SaveModelBotton = new Button();
            SaveModel_Dialog = new SaveFileDialog();
            SuspendLayout();
            // 
            // K_Payload_TextBox
            // 
            K_Payload_TextBox.Location = new Point(35, 63);
            K_Payload_TextBox.Name = "K_Payload_TextBox";
            K_Payload_TextBox.Size = new Size(115, 23);
            K_Payload_TextBox.TabIndex = 0;
            K_Payload_TextBox.TextChanged += K_Payload_TextBox_TextChanged;
            // 
            // K_Avionics_TextBox
            // 
            K_Avionics_TextBox.Location = new Point(35, 118);
            K_Avionics_TextBox.Name = "K_Avionics_TextBox";
            K_Avionics_TextBox.Size = new Size(115, 23);
            K_Avionics_TextBox.TabIndex = 1;
            K_Avionics_TextBox.TextChanged += K_Avionics_TextBox_TextChanged;
            // 
            // K_Fuel_TextBox
            // 
            K_Fuel_TextBox.Location = new Point(35, 174);
            K_Fuel_TextBox.Name = "K_Fuel_TextBox";
            K_Fuel_TextBox.Size = new Size(115, 23);
            K_Fuel_TextBox.TabIndex = 2;
            K_Fuel_TextBox.TextChanged += K_Fuel_TextBox_TextChanged;
            // 
            // K_Engine_TextBox
            // 
            K_Engine_TextBox.Location = new Point(35, 226);
            K_Engine_TextBox.Name = "K_Engine_TextBox";
            K_Engine_TextBox.Size = new Size(115, 23);
            K_Engine_TextBox.TabIndex = 3;
            K_Engine_TextBox.TextChanged += K_Engine_TextBox_TextChanged;
            // 
            // K_Wing_TextBox
            // 
            K_Wing_TextBox.Location = new Point(35, 271);
            K_Wing_TextBox.Name = "K_Wing_TextBox";
            K_Wing_TextBox.Size = new Size(115, 23);
            K_Wing_TextBox.TabIndex = 4;
            K_Wing_TextBox.TextChanged += K_Wing_TextBox_TextChanged;
            // 
            // K_Control_TextBox
            // 
            K_Control_TextBox.Location = new Point(35, 315);
            K_Control_TextBox.Name = "K_Control_TextBox";
            K_Control_TextBox.Size = new Size(115, 23);
            K_Control_TextBox.TabIndex = 5;
            K_Control_TextBox.TextChanged += K_Control_TextBox_TextChanged;
            // 
            // PayloadMass_TextBox
            // 
            PayloadMass_TextBox.Location = new Point(35, 369);
            PayloadMass_TextBox.Name = "PayloadMass_TextBox";
            PayloadMass_TextBox.Size = new Size(115, 23);
            PayloadMass_TextBox.TabIndex = 6;
            PayloadMass_TextBox.TextChanged += PayloadMass_TextBox_TextChanged;
            // 
            // Chord_Wing_TextBox
            // 
            Chord_Wing_TextBox.Location = new Point(177, 174);
            Chord_Wing_TextBox.Name = "Chord_Wing_TextBox";
            Chord_Wing_TextBox.Size = new Size(106, 23);
            Chord_Wing_TextBox.TabIndex = 7;
            Chord_Wing_TextBox.TextChanged += Chord_Wing_TextBox_TextChanged;
            // 
            // Chord_Control_TextBox
            // 
            Chord_Control_TextBox.Location = new Point(177, 226);
            Chord_Control_TextBox.Name = "Chord_Control_TextBox";
            Chord_Control_TextBox.Size = new Size(106, 23);
            Chord_Control_TextBox.TabIndex = 8;
            Chord_Control_TextBox.TextChanged += Chord_Control_TextBox_TextChanged;
            // 
            // Speed_TextBox
            // 
            Speed_TextBox.Location = new Point(177, 65);
            Speed_TextBox.Name = "Speed_TextBox";
            Speed_TextBox.Size = new Size(106, 23);
            Speed_TextBox.TabIndex = 9;
            Speed_TextBox.TextChanged += Speed_TextBox_TextChanged;
            // 
            // Diameter_TextBox
            // 
            Diameter_TextBox.Location = new Point(177, 118);
            Diameter_TextBox.Name = "Diameter_TextBox";
            Diameter_TextBox.Size = new Size(106, 23);
            Diameter_TextBox.TabIndex = 10;
            Diameter_TextBox.TextChanged += Diameter_TextBox_TextChanged;
            // 
            // Rho_Avionics_TextBox
            // 
            Rho_Avionics_TextBox.Location = new Point(355, 63);
            Rho_Avionics_TextBox.Name = "Rho_Avionics_TextBox";
            Rho_Avionics_TextBox.Size = new Size(108, 23);
            Rho_Avionics_TextBox.TabIndex = 11;
            Rho_Avionics_TextBox.TextChanged += Rho_Avionics_TextBox_TextChanged;
            // 
            // Rho_Payload_TextBox
            // 
            Rho_Payload_TextBox.Location = new Point(355, 118);
            Rho_Payload_TextBox.Name = "Rho_Payload_TextBox";
            Rho_Payload_TextBox.Size = new Size(108, 23);
            Rho_Payload_TextBox.TabIndex = 12;
            Rho_Payload_TextBox.TextChanged += Rho_Payload_TextBox_TextChanged;
            // 
            // Rho_Fuel_TextBox
            // 
            Rho_Fuel_TextBox.Location = new Point(355, 174);
            Rho_Fuel_TextBox.Name = "Rho_Fuel_TextBox";
            Rho_Fuel_TextBox.Size = new Size(108, 23);
            Rho_Fuel_TextBox.TabIndex = 13;
            Rho_Fuel_TextBox.TextChanged += Rho_Fuel_TextBox_TextChanged;
            // 
            // Rho_Engine_TextBox
            // 
            Rho_Engine_TextBox.Location = new Point(355, 226);
            Rho_Engine_TextBox.Name = "Rho_Engine_TextBox";
            Rho_Engine_TextBox.Size = new Size(108, 23);
            Rho_Engine_TextBox.TabIndex = 14;
            Rho_Engine_TextBox.TextChanged += Rho_Engine_TextBox_TextChanged;
            // 
            // Rho_Frame_TextBox
            // 
            Rho_Frame_TextBox.Location = new Point(532, 63);
            Rho_Frame_TextBox.Name = "Rho_Frame_TextBox";
            Rho_Frame_TextBox.Size = new Size(100, 23);
            Rho_Frame_TextBox.TabIndex = 15;
            Rho_Frame_TextBox.TextChanged += Rho_Frame_TextBox_TextChanged;
            // 
            // Rho_Stringer_TextBox
            // 
            Rho_Stringer_TextBox.Location = new Point(531, 121);
            Rho_Stringer_TextBox.Name = "Rho_Stringer_TextBox";
            Rho_Stringer_TextBox.Size = new Size(100, 23);
            Rho_Stringer_TextBox.TabIndex = 16;
            Rho_Stringer_TextBox.TextChanged += Rho_Stringer_TextBox_TextChanged;
            // 
            // Rho_Skin_TextBox
            // 
            Rho_Skin_TextBox.Location = new Point(532, 174);
            Rho_Skin_TextBox.Name = "Rho_Skin_TextBox";
            Rho_Skin_TextBox.Size = new Size(100, 23);
            Rho_Skin_TextBox.TabIndex = 17;
            Rho_Skin_TextBox.TextChanged += Rho_Skin_TextBox_TextChanged;
            // 
            // SkinThickness_TextBox
            // 
            SkinThickness_TextBox.Location = new Point(531, 226);
            SkinThickness_TextBox.Name = "SkinThickness_TextBox";
            SkinThickness_TextBox.Size = new Size(100, 23);
            SkinThickness_TextBox.TabIndex = 18;
            SkinThickness_TextBox.TextChanged += SkinThickness_TextBox_TextChanged;
            // 
            // EngineThrust_TextBox
            // 
            EngineThrust_TextBox.Location = new Point(688, 63);
            EngineThrust_TextBox.Name = "EngineThrust_TextBox";
            EngineThrust_TextBox.Size = new Size(110, 23);
            EngineThrust_TextBox.TabIndex = 19;
            EngineThrust_TextBox.TextChanged += EngineThrust_TextBox_TextChanged;
            // 
            // FuelConsumptionRate_TextBox
            // 
            FuelConsumptionRate_TextBox.Location = new Point(688, 121);
            FuelConsumptionRate_TextBox.Name = "FuelConsumptionRate_TextBox";
            FuelConsumptionRate_TextBox.Size = new Size(110, 23);
            FuelConsumptionRate_TextBox.TabIndex = 20;
            FuelConsumptionRate_TextBox.TextChanged += FuelConsumptionRate_TextBox_TextChanged;
            // 
            // K_Payload_Label
            // 
            K_Payload_Label.AutoSize = true;
            K_Payload_Label.Location = new Point(83, 45);
            K_Payload_Label.Name = "K_Payload_Label";
            K_Payload_Label.Size = new Size(25, 15);
            K_Payload_Label.TabIndex = 21;
            K_Payload_Label.Text = "ПН";
            // 
            // K_Avionics_Label
            // 
            K_Avionics_Label.AutoSize = true;
            K_Avionics_Label.Location = new Point(54, 95);
            K_Avionics_Label.Name = "K_Avionics_Label";
            K_Avionics_Label.Size = new Size(72, 15);
            K_Avionics_Label.TabIndex = 22;
            K_Avionics_Label.Text = "Аппаратура";
            // 
            // K_Fuel_Label
            // 
            K_Fuel_Label.AutoSize = true;
            K_Fuel_Label.Location = new Point(64, 156);
            K_Fuel_Label.Name = "K_Fuel_Label";
            K_Fuel_Label.Size = new Size(55, 15);
            K_Fuel_Label.TabIndex = 23;
            K_Fuel_Label.Text = "Топливо";
            // 
            // K_Engine_Label
            // 
            K_Engine_Label.AutoSize = true;
            K_Engine_Label.Location = new Point(83, 208);
            K_Engine_Label.Name = "K_Engine_Label";
            K_Engine_Label.Size = new Size(22, 15);
            K_Engine_Label.TabIndex = 24;
            K_Engine_Label.Text = "ДУ";
            // 
            // K_Wing_Label
            // 
            K_Wing_Label.AutoSize = true;
            K_Wing_Label.Location = new Point(74, 253);
            K_Wing_Label.Name = "K_Wing_Label";
            K_Wing_Label.Size = new Size(44, 15);
            K_Wing_Label.TabIndex = 25;
            K_Wing_Label.Text = "Крыло";
            // 
            // K_Control_Label
            // 
            K_Control_Label.AutoSize = true;
            K_Control_Label.Location = new Point(74, 297);
            K_Control_Label.Name = "K_Control_Label";
            K_Control_Label.Size = new Size(34, 15);
            K_Control_Label.TabIndex = 26;
            K_Control_Label.Text = "Рули";
            // 
            // PayloadMass_Label
            // 
            PayloadMass_Label.AutoSize = true;
            PayloadMass_Label.Location = new Point(54, 351);
            PayloadMass_Label.Name = "PayloadMass_Label";
            PayloadMass_Label.Size = new Size(80, 15);
            PayloadMass_Label.TabIndex = 27;
            PayloadMass_Label.Text = "Масса ПН, кг";
            // 
            // Chord_Wing_Label
            // 
            Chord_Wing_Label.AutoSize = true;
            Chord_Wing_Label.Location = new Point(184, 156);
            Chord_Wing_Label.Name = "Chord_Wing_Label";
            Chord_Wing_Label.Size = new Size(93, 15);
            Chord_Wing_Label.TabIndex = 28;
            Chord_Wing_Label.Text = "Хорда крыла, м";
            // 
            // Chord_Control_Label
            // 
            Chord_Control_Label.AutoSize = true;
            Chord_Control_Label.Location = new Point(184, 208);
            Chord_Control_Label.Name = "Chord_Control_Label";
            Chord_Control_Label.Size = new Size(91, 15);
            Chord_Control_Label.TabIndex = 29;
            Chord_Control_Label.Text = "Хорда рулей, м";
            // 
            // Speed_Label
            // 
            Speed_Label.AutoSize = true;
            Speed_Label.Location = new Point(152, 45);
            Speed_Label.Name = "Speed_Label";
            Speed_Label.Size = new Size(156, 15);
            Speed_Label.TabIndex = 30;
            Speed_Label.Text = "Крейсерская скорость, м/с";
            // 
            // DiameterLabel
            // 
            DiameterLabel.AutoSize = true;
            DiameterLabel.Location = new Point(167, 95);
            DiameterLabel.Name = "DiameterLabel";
            DiameterLabel.Size = new Size(131, 15);
            DiameterLabel.TabIndex = 31;
            DiameterLabel.Text = "Диаметр фюзеляжа, м";
            // 
            // Rho_Avionics_Label
            // 
            Rho_Avionics_Label.AutoSize = true;
            Rho_Avionics_Label.Location = new Point(365, 45);
            Rho_Avionics_Label.Name = "Rho_Avionics_Label";
            Rho_Avionics_Label.Size = new Size(72, 15);
            Rho_Avionics_Label.TabIndex = 32;
            Rho_Avionics_Label.Text = "Аппаратура";
            // 
            // Rho_Payload_Label
            // 
            Rho_Payload_Label.AutoSize = true;
            Rho_Payload_Label.Location = new Point(395, 95);
            Rho_Payload_Label.Name = "Rho_Payload_Label";
            Rho_Payload_Label.Size = new Size(25, 15);
            Rho_Payload_Label.TabIndex = 33;
            Rho_Payload_Label.Text = "ПН";
            // 
            // Rho_Fuel_Label
            // 
            Rho_Fuel_Label.AutoSize = true;
            Rho_Fuel_Label.Location = new Point(382, 156);
            Rho_Fuel_Label.Name = "Rho_Fuel_Label";
            Rho_Fuel_Label.Size = new Size(55, 15);
            Rho_Fuel_Label.TabIndex = 34;
            Rho_Fuel_Label.Text = "Топливо";
            // 
            // Rho_Engine_Label
            // 
            Rho_Engine_Label.AutoSize = true;
            Rho_Engine_Label.Location = new Point(398, 208);
            Rho_Engine_Label.Name = "Rho_Engine_Label";
            Rho_Engine_Label.Size = new Size(22, 15);
            Rho_Engine_Label.TabIndex = 35;
            Rho_Engine_Label.Text = "ДУ";
            // 
            // Rho_Frame_Label
            // 
            Rho_Frame_Label.AutoSize = true;
            Rho_Frame_Label.Location = new Point(546, 45);
            Rho_Frame_Label.Name = "Rho_Frame_Label";
            Rho_Frame_Label.Size = new Size(70, 15);
            Rho_Frame_Label.TabIndex = 36;
            Rho_Frame_Label.Text = "Шпангоуты";
            // 
            // MaterialParemeters_Label
            // 
            MaterialParemeters_Label.AutoSize = true;
            MaterialParemeters_Label.Location = new Point(497, 19);
            MaterialParemeters_Label.Name = "MaterialParemeters_Label";
            MaterialParemeters_Label.Size = new Size(170, 15);
            MaterialParemeters_Label.TabIndex = 37;
            MaterialParemeters_Label.Text = "Плотность материалов, кг/м³";
            // 
            // Rho_Stringer_Label
            // 
            Rho_Stringer_Label.AutoSize = true;
            Rho_Stringer_Label.Location = new Point(546, 95);
            Rho_Stringer_Label.Name = "Rho_Stringer_Label";
            Rho_Stringer_Label.Size = new Size(68, 15);
            Rho_Stringer_Label.TabIndex = 38;
            Rho_Stringer_Label.Text = "Стрингеры";
            // 
            // Rho_Skin_Label
            // 
            Rho_Skin_Label.AutoSize = true;
            Rho_Skin_Label.Location = new Point(555, 156);
            Rho_Skin_Label.Name = "Rho_Skin_Label";
            Rho_Skin_Label.Size = new Size(59, 15);
            Rho_Skin_Label.TabIndex = 39;
            Rho_Skin_Label.Text = "Обшивка";
            // 
            // SkinThickness_Label
            // 
            SkinThickness_Label.AutoSize = true;
            SkinThickness_Label.Location = new Point(518, 208);
            SkinThickness_Label.Name = "SkinThickness_Label";
            SkinThickness_Label.Size = new Size(128, 15);
            SkinThickness_Label.TabIndex = 40;
            SkinThickness_Label.Text = "Толщина обшивки, м";
            // 
            // RHO_Label
            // 
            RHO_Label.AutoSize = true;
            RHO_Label.Location = new Point(304, 19);
            RHO_Label.Name = "RHO_Label";
            RHO_Label.Size = new Size(173, 15);
            RHO_Label.TabIndex = 41;
            RHO_Label.Text = "Плотность компоновки, кг/м³";
            // 
            // RelativeMasses_Label
            // 
            RelativeMasses_Label.AutoSize = true;
            RelativeMasses_Label.Location = new Point(17, 14);
            RelativeMasses_Label.Name = "RelativeMasses_Label";
            RelativeMasses_Label.Size = new Size(133, 15);
            RelativeMasses_Label.TabIndex = 42;
            RelativeMasses_Label.Text = "Относительные массы";
            // 
            // EngineThrust_Label
            // 
            EngineThrust_Label.AutoSize = true;
            EngineThrust_Label.Location = new Point(707, 45);
            EngineThrust_Label.Name = "EngineThrust_Label";
            EngineThrust_Label.Size = new Size(64, 15);
            EngineThrust_Label.TabIndex = 43;
            EngineThrust_Label.Text = "Тяга ДУ, Н";
            // 
            // FuelConsumptionRate_Label
            // 
            FuelConsumptionRate_Label.AutoSize = true;
            FuelConsumptionRate_Label.Location = new Point(696, 95);
            FuelConsumptionRate_Label.Name = "FuelConsumptionRate_Label";
            FuelConsumptionRate_Label.Size = new Size(92, 15);
            FuelConsumptionRate_Label.TabIndex = 44;
            FuelConsumptionRate_Label.Text = "Расход топлива";
            // 
            // Calculations_Button
            // 
            Calculations_Button.Location = new Point(362, 368);
            Calculations_Button.Name = "Calculations_Button";
            Calculations_Button.Size = new Size(75, 23);
            Calculations_Button.TabIndex = 45;
            Calculations_Button.Text = "Расчёт";
            Calculations_Button.UseVisualStyleBackColor = true;
            Calculations_Button.Click += Calculations_Button_Click;
            // 
            // ProfileOfWingNames_Label
            // 
            ProfileOfWingNames_Label.AutoSize = true;
            ProfileOfWingNames_Label.Location = new Point(688, 156);
            ProfileOfWingNames_Label.Name = "ProfileOfWingNames_Label";
            ProfileOfWingNames_Label.Size = new Size(97, 15);
            ProfileOfWingNames_Label.TabIndex = 47;
            ProfileOfWingNames_Label.Text = "Профиль крыла";
            // 
            // ProfileOfControlNames_Label
            // 
            ProfileOfControlNames_Label.AutoSize = true;
            ProfileOfControlNames_Label.Location = new Point(692, 208);
            ProfileOfControlNames_Label.Name = "ProfileOfControlNames_Label";
            ProfileOfControlNames_Label.Size = new Size(88, 15);
            ProfileOfControlNames_Label.TabIndex = 48;
            ProfileOfControlNames_Label.Text = "Профиль руля";
            // 
            // ShowResults_Button
            // 
            ShowResults_Button.Location = new Point(672, 325);
            ShowResults_Button.Name = "ShowResults_Button";
            ShowResults_Button.Size = new Size(136, 23);
            ShowResults_Button.TabIndex = 50;
            ShowResults_Button.Text = "Показать результаты";
            ShowResults_Button.UseVisualStyleBackColor = true;
            ShowResults_Button.Click += ShowResults_Button_Click;
            // 
            // ProfileOfWingNames_ComboBox
            // 
            ProfileOfWingNames_ComboBox.FormattingEnabled = true;
            ProfileOfWingNames_ComboBox.Items.AddRange(new object[] { "naca2412", "naca2415", "naca2418", "naca2421", "naca2424", "naca4412", "naca4415", "naca4418", "naca4421", "naca4424" });
            ProfileOfWingNames_ComboBox.Location = new Point(672, 182);
            ProfileOfWingNames_ComboBox.Name = "ProfileOfWingNames_ComboBox";
            ProfileOfWingNames_ComboBox.Size = new Size(136, 23);
            ProfileOfWingNames_ComboBox.TabIndex = 51;
            ProfileOfWingNames_ComboBox.SelectedIndexChanged += ProfileOfWingNames_ComboBox_SelectedIndexChanged;
            // 
            // ProfileOfControlNames_ComboBox
            // 
            ProfileOfControlNames_ComboBox.FormattingEnabled = true;
            ProfileOfControlNames_ComboBox.Items.AddRange(new object[] { "naca2412", "naca2415", "naca2418", "naca2421", "naca2424", "naca4412", "naca4415", "naca4418", "naca4421", "naca4424" });
            ProfileOfControlNames_ComboBox.Location = new Point(672, 226);
            ProfileOfControlNames_ComboBox.Name = "ProfileOfControlNames_ComboBox";
            ProfileOfControlNames_ComboBox.Size = new Size(136, 23);
            ProfileOfControlNames_ComboBox.TabIndex = 52;
            ProfileOfControlNames_ComboBox.SelectedIndexChanged += ProfileOfControlNames_ComboBox_SelectedIndexChanged;
            // 
            // SaveModelBotton
            // 
            SaveModelBotton.Location = new Point(672, 368);
            SaveModelBotton.Name = "SaveModelBotton";
            SaveModelBotton.Size = new Size(136, 23);
            SaveModelBotton.TabIndex = 53;
            SaveModelBotton.Text = "Сохранить модель";
            SaveModelBotton.UseVisualStyleBackColor = true;
            SaveModelBotton.Click += SaveModelBotton_Click;
            // 
            // SaveModel_Dialog
            // 
            SaveModel_Dialog.FileOk += SaveModel_Dialog_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 425);
            Controls.Add(SaveModelBotton);
            Controls.Add(ProfileOfControlNames_ComboBox);
            Controls.Add(ProfileOfWingNames_ComboBox);
            Controls.Add(ShowResults_Button);
            Controls.Add(ProfileOfControlNames_Label);
            Controls.Add(ProfileOfWingNames_Label);
            Controls.Add(Calculations_Button);
            Controls.Add(FuelConsumptionRate_Label);
            Controls.Add(EngineThrust_Label);
            Controls.Add(RelativeMasses_Label);
            Controls.Add(RHO_Label);
            Controls.Add(SkinThickness_Label);
            Controls.Add(Rho_Skin_Label);
            Controls.Add(Rho_Stringer_Label);
            Controls.Add(MaterialParemeters_Label);
            Controls.Add(Rho_Frame_Label);
            Controls.Add(Rho_Engine_Label);
            Controls.Add(Rho_Fuel_Label);
            Controls.Add(Rho_Payload_Label);
            Controls.Add(Rho_Avionics_Label);
            Controls.Add(DiameterLabel);
            Controls.Add(Speed_Label);
            Controls.Add(Chord_Control_Label);
            Controls.Add(Chord_Wing_Label);
            Controls.Add(PayloadMass_Label);
            Controls.Add(K_Control_Label);
            Controls.Add(K_Wing_Label);
            Controls.Add(K_Engine_Label);
            Controls.Add(K_Fuel_Label);
            Controls.Add(K_Avionics_Label);
            Controls.Add(K_Payload_Label);
            Controls.Add(FuelConsumptionRate_TextBox);
            Controls.Add(EngineThrust_TextBox);
            Controls.Add(SkinThickness_TextBox);
            Controls.Add(Rho_Skin_TextBox);
            Controls.Add(Rho_Stringer_TextBox);
            Controls.Add(Rho_Frame_TextBox);
            Controls.Add(Rho_Engine_TextBox);
            Controls.Add(Rho_Fuel_TextBox);
            Controls.Add(Rho_Payload_TextBox);
            Controls.Add(Rho_Avionics_TextBox);
            Controls.Add(Diameter_TextBox);
            Controls.Add(Speed_TextBox);
            Controls.Add(Chord_Control_TextBox);
            Controls.Add(Chord_Wing_TextBox);
            Controls.Add(PayloadMass_TextBox);
            Controls.Add(K_Control_TextBox);
            Controls.Add(K_Wing_TextBox);
            Controls.Add(K_Engine_TextBox);
            Controls.Add(K_Fuel_TextBox);
            Controls.Add(K_Avionics_TextBox);
            Controls.Add(K_Payload_TextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "БПЛА \"Утка\"";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox K_Payload_TextBox;
        private TextBox K_Avionics_TextBox;
        private TextBox K_Fuel_TextBox;
        private TextBox K_Engine_TextBox;
        private TextBox K_Wing_TextBox;
        private TextBox K_Control_TextBox;
        private TextBox PayloadMass_TextBox;
        private TextBox Chord_Wing_TextBox;
        private TextBox Chord_Control_TextBox;
        private TextBox Speed_TextBox;
        private TextBox Diameter_TextBox;
        private TextBox Rho_Avionics_TextBox;
        private TextBox Rho_Payload_TextBox;
        private TextBox Rho_Fuel_TextBox;
        private TextBox Rho_Engine_TextBox;
        private TextBox Rho_Frame_TextBox;
        private TextBox Rho_Stringer_TextBox;
        private TextBox Rho_Skin_TextBox;
        private TextBox SkinThickness_TextBox;
        private TextBox EngineThrust_TextBox;
        private TextBox FuelConsumptionRate_TextBox;
        private Label K_Payload_Label;
        private Label K_Avionics_Label;
        private Label K_Fuel_Label;
        private Label K_Engine_Label;
        private Label K_Wing_Label;
        private Label K_Control_Label;
        private Label PayloadMass_Label;
        private Label Chord_Wing_Label;
        private Label Chord_Control_Label;
        private Label Speed_Label;
        private Label DiameterLabel;
        private Label Rho_Avionics_Label;
        private Label Rho_Payload_Label;
        private Label Rho_Fuel_Label;
        private Label Rho_Engine_Label;
        private Label Rho_Frame_Label;
        private Label MaterialParemeters_Label;
        private Label Rho_Stringer_Label;
        private Label Rho_Skin_Label;
        private Label SkinThickness_Label;
        private Label RHO_Label;
        private Label RelativeMasses_Label;
        private Label EngineThrust_Label;
        private Label FuelConsumptionRate_Label;
        private Button Calculations_Button;
        private Label ProfileOfWingNames_Label;
        private Label ProfileOfControlNames_Label;
        private Button ShowResults_Button;
        private ComboBox ProfileOfWingNames_ComboBox;
        private ComboBox ProfileOfControlNames_ComboBox;
        private Button SaveModelBotton;
        private SaveFileDialog SaveModel_Dialog;
    }
}
