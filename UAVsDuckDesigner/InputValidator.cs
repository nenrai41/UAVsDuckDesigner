using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVsDuckDesigner
{
    public class InputValidator
    {
        public string ProfileOfWingName { get; set; } // Название профиля крыла
        public string ProfileOfControlName { get; set; } // Название профиля руля

        public double PayloadMass { get; set; } // Масса полезной нагрузки 
        public double Speed { get; set; } // Скорость полета (м/с)
        public double Diameter { get; set; } // Диаметр фюзеляжа (м)

        // Относительные массы (доли)
        public double K_Payload { get; set; } // ПН
        public double K_Avionics { get; set; } // Аппаратура
        public double K_Fuel { get; set; } // Топливо
        public double K_Engine { get; set; } // ДУ
        public double K_Wing { get; set; } // Крыло
        public double K_Control { get; set; } // Рули

        // Аэродинамические параметры
        public double CL_Wing { get; set; }   // Коэффициент подъемной силы крыла
        public double CL_Control { get; set; }  // Коэффициент подъемной силы рулей
        public double Chord_Wing { get; set; }    // Хорда крыла (м)
        public double Chord_Control { get; set; } // Хорда рулей (м)

        // Плотности компоновки (кг/м³)
        public double Rho_Avionics { get; set; } // Плотность компоновки аппаратуры 
        public double Rho_Payload { get; set; } // Плотность компоновки ПН
        public double Rho_Fuel { get; set; } // Плотность компоновки топлива
        public double Rho_Engine { get; set; } // Плотность компоновки ДУ

        // Параметры материалов (кг/м³)
        public double Rho_Frame { get; set; }     // Плотность шпангоутов 
        public double Rho_Stringer { get; set; }  // Плотность стрингеров 
        public double Rho_Skin { get; set; }      // Плотность обшивки 
        public double SkinThickness { get; set; } // Толщина обшивки (м)

        // Параметры двигателя
        public double EngineThrust { get; set; } // Тяга двигателя
        public double FuelConsumptionRate { get; set; } // Расход топлива двигателя

        public bool IsEnterTheRelativeMassesCorrectly(DataProcessor dataProcessor, PythonAeroSandboxRunner pythonAeroSandboxRunner)
        {
            if ((K_Payload + K_Avionics + K_Fuel + K_Engine + K_Wing + K_Control) == 1)
            {
                _setParemeters(dataProcessor, pythonAeroSandboxRunner);
                return true;
            }
            else
            {
                MessageBox.Show("Относительные массы не равны 1!");
                return false;
            }    
                
        }
        private void _setParemeters(DataProcessor dataProcessor, PythonAeroSandboxRunner _pythonAeroSandboxRunner)
        {
            dataProcessor.PayloadMass = this.PayloadMass;
            dataProcessor.Speed = this.Speed;
            dataProcessor.Diameter = this.Diameter;
            dataProcessor.K_Payload = this.K_Payload;
            dataProcessor.K_Avionics = this.K_Avionics;
            dataProcessor.K_Fuel = this.K_Fuel;
            dataProcessor.K_Engine = this.K_Engine;
            dataProcessor.K_Wing = this.K_Wing;
            dataProcessor.K_Control = this.K_Control;
            dataProcessor.Chord_Wing = this.Chord_Wing;
            dataProcessor.Chord_Control = this.Chord_Control;
            dataProcessor.Rho_Avionics = this.Rho_Avionics;
            dataProcessor.Rho_Payload = this.Rho_Payload;
            dataProcessor.Rho_Fuel = this.Rho_Fuel;
            dataProcessor.Rho_Engine = this.Rho_Engine;
            dataProcessor.Rho_Frame = this.Rho_Frame;
            dataProcessor.Rho_Stringer = this.Rho_Stringer;
            dataProcessor.Rho_Skin = this.Rho_Skin;
            dataProcessor.SkinThickness = this.SkinThickness;
            dataProcessor.EngineThrust = this.EngineThrust;
            dataProcessor.FuelConsumptionRate = this.FuelConsumptionRate;
            dataProcessor.ProfileOfWingName = this.ProfileOfWingName;
            dataProcessor.ProfileOfControlName = this.ProfileOfControlName;
            dataProcessor.CL_Wing = _pythonAeroSandboxRunner.GetOfCl(ProfileOfWingName);
            dataProcessor.CL_Control = _pythonAeroSandboxRunner.GetOfCl(ProfileOfControlName);
        }

        
    }
}
