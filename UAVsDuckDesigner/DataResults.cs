using System;

namespace UAVsDuckDesigner
{
    public class DataResults
    {
        // Название профиля крыла
        public string ProfileOfWingName { get; set; }

        // Название профиля руля
        public string ProfileOfControlName { get; set; }
        // Массы компонентов (кг)
        public double TotalMass { get; set; } // Общая масса БПЛА с топливом 
        public double PayloadMass { get; set; } // Масса полезной нагрузки 
        public double AvionicsMass { get; set; } // Масса аппаратуры 
        public double FuelMass { get; set; } // Масса топлива 
        public double EngineMass { get; set; } // Масса ДУ 
        public double WingMass { get; set; } // Масса крыла 
        public double ControlMass { get; set; } // Масса рулей 
        public double StructureMass { get; set; } // Масса конструкции

        // Компоненты конструкции (кг)
        public double FrameMass { get; set; } // Масса шпангоутов
        public double StringerMass { get; set; } // Масса стрингеров
        public double SkinMass { get; set; } // Масса обшивки

        // Геометрические параметры (м)
        public double LengthTotal { get; set; } // Общая длина БПЛА 
        public double LengthAvionics { get; set; } // Длина отсека с аппаратурой 
        public double LengthPayload { get; set; } // Длина отсека с ПН 
        public double LengthFuel { get; set; } // Длина отсека с топливом 
        public double LengthEngine { get; set; } // Длина отсека ДУ 

        // Аэродинамика 
        public double WingSpan { get; set; } // Размах крыла (м)
        public double ControlSpan { get; set; } // Размах рулей (м)
        public double WingArea { get; set; } // Площаль крыла (м^2)
        public double ControlArea { get; set; } // Площаль рулей (м^2)

        // Центровка (м)
        public double CG_Position { get; set; }      // Положение центра масс 
        public double CP_Position { get; set; }      // Положение фокуса 
        public double StabilityMargin { get; set; }  // Запас устойчивости 


        // Координаты элементов (м)
        public double WingPosition { get; set; } // Координаты крыла
        public double ControlPosition { get; set; } // Координаты рулей

        // Результаты ASB
        public double CD { get; set; } // Коэффициент сопротивлоения воздуха БПЛА
        public double CL { get; set; } // Коэффициент подъемной силы БПЛА
        public double AerodynamicCenterOfControl { get; set; } //Аэродинамический центр рулей

        //Дублирующие свойства из DataProcessor
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

        public double EngineThrust { get; set; } // Тяга двигателя
        public double FuelConsumptionRate { get; set; } // Расход топлива двигателя

        // Модель БПЛА в ASB
        public dynamic UAVs { get; set; }

    }
}
