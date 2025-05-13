namespace UAVsDuckDesigner
{
    partial class ResultForm
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
            TotalMass_Label = new Label();
            PayloadMass_Label = new Label();
            AvionicsMass_Label = new Label();
            FuelMass_Label = new Label();
            EngineMass_Label = new Label();
            WingMass_Label = new Label();
            ControlMass_Label = new Label();
            StructureMass_Label = new Label();
            FrameMass_Label = new Label();
            StringerMass_Label = new Label();
            SkinMass_Label = new Label();
            LengthTotal_Label = new Label();
            LengthAvionics_Label = new Label();
            LengthPayload_Label = new Label();
            LengthFuel_Label = new Label();
            LengthEngine_Label = new Label();
            WingSpan_label = new Label();
            ControlSpan_Label = new Label();
            WingArea_Label = new Label();
            ControlArea_Label = new Label();
            CG_Position_Label = new Label();
            CP_Position_Label = new Label();
            StabilityMargin_Label = new Label();
            WingPosition_label = new Label();
            ControlPosition_Label = new Label();
            CD_Label = new Label();
            CL_Label = new Label();
            SuspendLayout();
            // 
            // TotalMass_Label
            // 
            TotalMass_Label.AutoSize = true;
            TotalMass_Label.Location = new Point(22, 22);
            TotalMass_Label.Name = "TotalMass_Label";
            TotalMass_Label.Size = new Size(85, 15);
            TotalMass_Label.TabIndex = 0;
            TotalMass_Label.Text = "Общая масса:";
            // 
            // PayloadMass_Label
            // 
            PayloadMass_Label.AutoSize = true;
            PayloadMass_Label.Location = new Point(23, 48);
            PayloadMass_Label.Name = "PayloadMass_Label";
            PayloadMass_Label.Size = new Size(66, 15);
            PayloadMass_Label.TabIndex = 1;
            PayloadMass_Label.Text = "Масса ПН:";
            // 
            // AvionicsMass_Label
            // 
            AvionicsMass_Label.AutoSize = true;
            AvionicsMass_Label.Location = new Point(22, 77);
            AvionicsMass_Label.Name = "AvionicsMass_Label";
            AvionicsMass_Label.Size = new Size(114, 15);
            AvionicsMass_Label.TabIndex = 2;
            AvionicsMass_Label.Text = "Масса аппаратуры:";
            // 
            // FuelMass_Label
            // 
            FuelMass_Label.AutoSize = true;
            FuelMass_Label.Location = new Point(22, 102);
            FuelMass_Label.Name = "FuelMass_Label";
            FuelMass_Label.Size = new Size(93, 15);
            FuelMass_Label.TabIndex = 3;
            FuelMass_Label.Text = "Масса топлива:";
            // 
            // EngineMass_Label
            // 
            EngineMass_Label.AutoSize = true;
            EngineMass_Label.Location = new Point(22, 128);
            EngineMass_Label.Name = "EngineMass_Label";
            EngineMass_Label.Size = new Size(63, 15);
            EngineMass_Label.TabIndex = 4;
            EngineMass_Label.Text = "Масса ДУ:";
            // 
            // WingMass_Label
            // 
            WingMass_Label.AutoSize = true;
            WingMass_Label.Location = new Point(22, 154);
            WingMass_Label.Name = "WingMass_Label";
            WingMass_Label.Size = new Size(83, 15);
            WingMass_Label.TabIndex = 5;
            WingMass_Label.Text = "Масса крыла:";
            // 
            // ControlMass_Label
            // 
            ControlMass_Label.AutoSize = true;
            ControlMass_Label.Location = new Point(22, 180);
            ControlMass_Label.Name = "ControlMass_Label";
            ControlMass_Label.Size = new Size(81, 15);
            ControlMass_Label.TabIndex = 6;
            ControlMass_Label.Text = "Масса рулей:";
            // 
            // StructureMass_Label
            // 
            StructureMass_Label.AutoSize = true;
            StructureMass_Label.Location = new Point(22, 206);
            StructureMass_Label.Name = "StructureMass_Label";
            StructureMass_Label.Size = new Size(119, 15);
            StructureMass_Label.TabIndex = 7;
            StructureMass_Label.Text = "Масса конструкции:";
            // 
            // FrameMass_Label
            // 
            FrameMass_Label.AutoSize = true;
            FrameMass_Label.Location = new Point(22, 231);
            FrameMass_Label.Name = "FrameMass_Label";
            FrameMass_Label.Size = new Size(115, 15);
            FrameMass_Label.TabIndex = 8;
            FrameMass_Label.Text = "Масса шпангоутов:";
            // 
            // StringerMass_Label
            // 
            StringerMass_Label.AutoSize = true;
            StringerMass_Label.Location = new Point(22, 258);
            StringerMass_Label.Name = "StringerMass_Label";
            StringerMass_Label.Size = new Size(111, 15);
            StringerMass_Label.TabIndex = 9;
            StringerMass_Label.Text = "Масса стрингеров:";
            // 
            // SkinMass_Label
            // 
            SkinMass_Label.AutoSize = true;
            SkinMass_Label.Location = new Point(22, 285);
            SkinMass_Label.Name = "SkinMass_Label";
            SkinMass_Label.Size = new Size(99, 15);
            SkinMass_Label.TabIndex = 10;
            SkinMass_Label.Text = "Масса обшивки:";
            // 
            // LengthTotal_Label
            // 
            LengthTotal_Label.AutoSize = true;
            LengthTotal_Label.Location = new Point(285, 20);
            LengthTotal_Label.Name = "LengthTotal_Label";
            LengthTotal_Label.Size = new Size(120, 15);
            LengthTotal_Label.TabIndex = 11;
            LengthTotal_Label.Text = "Общая длина БПЛА:";
            // 
            // LengthAvionics_Label
            // 
            LengthAvionics_Label.AutoSize = true;
            LengthAvionics_Label.Location = new Point(285, 47);
            LengthAvionics_Label.Name = "LengthAvionics_Label";
            LengthAvionics_Label.Size = new Size(167, 15);
            LengthAvionics_Label.TabIndex = 12;
            LengthAvionics_Label.Text = "Длина отсека с аппаратурой:";
            // 
            // LengthPayload_Label
            // 
            LengthPayload_Label.AutoSize = true;
            LengthPayload_Label.Location = new Point(286, 73);
            LengthPayload_Label.Name = "LengthPayload_Label";
            LengthPayload_Label.Size = new Size(114, 15);
            LengthPayload_Label.TabIndex = 13;
            LengthPayload_Label.Text = "Длина отсека с ПН:";
            // 
            // LengthFuel_Label
            // 
            LengthFuel_Label.AutoSize = true;
            LengthFuel_Label.Location = new Point(286, 102);
            LengthFuel_Label.Name = "LengthFuel_Label";
            LengthFuel_Label.Size = new Size(151, 15);
            LengthFuel_Label.TabIndex = 14;
            LengthFuel_Label.Text = "Длина отсека с топливом:";
            // 
            // LengthEngine_Label
            // 
            LengthEngine_Label.AutoSize = true;
            LengthEngine_Label.Location = new Point(285, 128);
            LengthEngine_Label.Name = "LengthEngine_Label";
            LengthEngine_Label.Size = new Size(111, 15);
            LengthEngine_Label.TabIndex = 15;
            LengthEngine_Label.Text = "Длина отсека с ДУ:";
            // 
            // WingSpan_label
            // 
            WingSpan_label.AutoSize = true;
            WingSpan_label.Location = new Point(23, 333);
            WingSpan_label.Name = "WingSpan_label";
            WingSpan_label.Size = new Size(86, 15);
            WingSpan_label.TabIndex = 16;
            WingSpan_label.Text = "Размах крыла:";
            // 
            // ControlSpan_Label
            // 
            ControlSpan_Label.AutoSize = true;
            ControlSpan_Label.Location = new Point(23, 358);
            ControlSpan_Label.Name = "ControlSpan_Label";
            ControlSpan_Label.Size = new Size(84, 15);
            ControlSpan_Label.TabIndex = 17;
            ControlSpan_Label.Text = "Размах рулей:";
            // 
            // WingArea_Label
            // 
            WingArea_Label.AutoSize = true;
            WingArea_Label.Location = new Point(23, 382);
            WingArea_Label.Name = "WingArea_Label";
            WingArea_Label.Size = new Size(100, 15);
            WingArea_Label.TabIndex = 18;
            WingArea_Label.Text = "Площадь крыла:";
            // 
            // ControlArea_Label
            // 
            ControlArea_Label.AutoSize = true;
            ControlArea_Label.Location = new Point(22, 409);
            ControlArea_Label.Name = "ControlArea_Label";
            ControlArea_Label.Size = new Size(98, 15);
            ControlArea_Label.TabIndex = 19;
            ControlArea_Label.Text = "Площадь рулей:";
            // 
            // CG_Position_Label
            // 
            CG_Position_Label.AutoSize = true;
            CG_Position_Label.Location = new Point(286, 359);
            CG_Position_Label.Name = "CG_Position_Label";
            CG_Position_Label.Size = new Size(98, 15);
            CG_Position_Label.TabIndex = 20;
            CG_Position_Label.Text = "Положение ЦМ:";
            // 
            // CP_Position_Label
            // 
            CP_Position_Label.AutoSize = true;
            CP_Position_Label.Location = new Point(286, 382);
            CP_Position_Label.Name = "CP_Position_Label";
            CP_Position_Label.Size = new Size(95, 15);
            CP_Position_Label.TabIndex = 21;
            CP_Position_Label.Text = "Положение ЦД:";
            // 
            // StabilityMargin_Label
            // 
            StabilityMargin_Label.AutoSize = true;
            StabilityMargin_Label.Location = new Point(286, 334);
            StabilityMargin_Label.Name = "StabilityMargin_Label";
            StabilityMargin_Label.Size = new Size(121, 15);
            StabilityMargin_Label.TabIndex = 22;
            StabilityMargin_Label.Text = "Запас устойчивости:";
            // 
            // WingPosition_label
            // 
            WingPosition_label.AutoSize = true;
            WingPosition_label.Location = new Point(22, 439);
            WingPosition_label.Name = "WingPosition_label";
            WingPosition_label.Size = new Size(113, 15);
            WingPosition_label.TabIndex = 23;
            WingPosition_label.Text = "Положение крыла:";
            // 
            // ControlPosition_Label
            // 
            ControlPosition_Label.AutoSize = true;
            ControlPosition_Label.Location = new Point(22, 462);
            ControlPosition_Label.Name = "ControlPosition_Label";
            ControlPosition_Label.Size = new Size(111, 15);
            ControlPosition_Label.TabIndex = 24;
            ControlPosition_Label.Text = "Положение рулей:";
            // 
            // CD_Label
            // 
            CD_Label.AutoSize = true;
            CD_Label.Location = new Point(127, 512);
            CD_Label.Name = "CD_Label";
            CD_Label.Size = new Size(254, 15);
            CD_Label.TabIndex = 25;
            CD_Label.Text = "Коэффициент сопротивления воздуха БПЛА:";
            // 
            // CL_Label
            // 
            CL_Label.AutoSize = true;
            CL_Label.Location = new Point(127, 539);
            CL_Label.Name = "CL_Label";
            CL_Label.Size = new Size(220, 15);
            CL_Label.TabIndex = 26;
            CL_Label.Text = "Коэффициент подъёмной силы БПЛА:";
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 621);
            Controls.Add(CL_Label);
            Controls.Add(CD_Label);
            Controls.Add(ControlPosition_Label);
            Controls.Add(WingPosition_label);
            Controls.Add(StabilityMargin_Label);
            Controls.Add(CP_Position_Label);
            Controls.Add(CG_Position_Label);
            Controls.Add(ControlArea_Label);
            Controls.Add(WingArea_Label);
            Controls.Add(ControlSpan_Label);
            Controls.Add(WingSpan_label);
            Controls.Add(LengthEngine_Label);
            Controls.Add(LengthFuel_Label);
            Controls.Add(LengthPayload_Label);
            Controls.Add(LengthAvionics_Label);
            Controls.Add(LengthTotal_Label);
            Controls.Add(SkinMass_Label);
            Controls.Add(StringerMass_Label);
            Controls.Add(FrameMass_Label);
            Controls.Add(StructureMass_Label);
            Controls.Add(ControlMass_Label);
            Controls.Add(WingMass_Label);
            Controls.Add(EngineMass_Label);
            Controls.Add(FuelMass_Label);
            Controls.Add(AvionicsMass_Label);
            Controls.Add(PayloadMass_Label);
            Controls.Add(TotalMass_Label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ResultForm";
            Text = "Результаты";
            Load += ResultForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TotalMass_Label;
        private Label PayloadMass_Label;
        private Label AvionicsMass_Label;
        private Label FuelMass_Label;
        private Label EngineMass_Label;
        private Label WingMass_Label;
        private Label ControlMass_Label;
        private Label StructureMass_Label;
        private Label FrameMass_Label;
        private Label StringerMass_Label;
        private Label SkinMass_Label;
        private Label LengthTotal_Label;
        private Label LengthAvionics_Label;
        private Label LengthPayload_Label;
        private Label LengthFuel_Label;
        private Label LengthEngine_Label;
        private Label WingSpan_label;
        private Label ControlSpan_Label;
        private Label WingArea_Label;
        private Label ControlArea_Label;
        private Label CG_Position_Label;
        private Label CP_Position_Label;
        private Label StabilityMargin_Label;
        private Label WingPosition_label;
        private Label ControlPosition_Label;
        private Label CD_Label;
        private Label CL_Label;
    }
}