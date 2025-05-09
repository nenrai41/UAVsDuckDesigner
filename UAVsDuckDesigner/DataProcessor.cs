using Microsoft.VisualBasic;
using System;


namespace UAVsDuckDesigner
{
    public class DataProcessor
    {

        // Название профиля крыла
        public string ProfileOfWingName { get; set; }

        // Название профиля руля
        public string ProfileOfControlName { get; set; }
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

        private void SetFieldsDataResults(DataResults _dataResults)
        {
            _dataResults.Speed = this.Speed;
            _dataResults.Diameter = this.Diameter;
            _dataResults.K_Payload = this.K_Payload;
            _dataResults.K_Avionics = this.K_Avionics;
            _dataResults.K_Fuel = this.K_Fuel;
            _dataResults.K_Engine = this.K_Engine;
            _dataResults.K_Wing = this.K_Wing;
            _dataResults.K_Control = this.K_Control;
            _dataResults.CL_Wing = this.CL_Wing;
            _dataResults.CL_Control = this.CL_Control;
            _dataResults.Chord_Wing = this.Chord_Wing;
            _dataResults.Chord_Control = this.Chord_Control;
            _dataResults.Rho_Avionics = this.Rho_Avionics;
            _dataResults.Rho_Payload = this.Rho_Payload;
            _dataResults.Rho_Fuel = this.Rho_Fuel;
            _dataResults.Rho_Engine = this.Rho_Engine;
            _dataResults.Rho_Frame = this.Rho_Frame;
            _dataResults.Rho_Stringer = this.Rho_Stringer;
            _dataResults.Rho_Skin = this.Rho_Skin;
            _dataResults.SkinThickness = this.SkinThickness;
            _dataResults.EngineThrust = this.EngineThrust;
            _dataResults.FuelConsumptionRate = this.FuelConsumptionRate;
            _dataResults.ProfileOfWingName = this.ProfileOfWingName;
            _dataResults.ProfileOfControlName = this.ProfileOfControlName;
        }

        public DataResults Calculate(DataResults dataResutsObject)
        {
            var r = dataResutsObject;

            SetFieldsDataResults(r);

            // 1. Расчет масс компонентов
            double massWithoutStruct = PayloadMass / K_Payload;

            r.PayloadMass = PayloadMass;
            r.AvionicsMass = K_Avionics * massWithoutStruct;
            r.FuelMass = K_Fuel * massWithoutStruct;
            r.EngineMass = K_Engine * massWithoutStruct;
            r.WingMass = K_Wing * massWithoutStruct;
            r.ControlMass = K_Control * massWithoutStruct;

            // 2. Расчет геометрии
            CalculateGeometry(r);

            // 3. Расчет конструкции
            CalculateStructure(r);

            // 4. Полная масса
            r.TotalMass = r.PayloadMass + r.AvionicsMass + r.FuelMass +
                         r.EngineMass + r.WingMass + r.ControlMass +
                         r.StructureMass;

            // 5 Аэродинамический расчет
            CalculateAerodynamics(r);

            // 6. Оптимизация центровки
            OptimizeCentering(this, r);

            return r;

        }

        private void CalculateGeometry(DataResults r)
        {

            // Носовой обтекатель (конус)
            double coneVol = 3 * r.AvionicsMass / Rho_Avionics;
            double denominator = Math.PI * Math.Pow(Diameter / 2, 2) *
                               Math.Tan(Constants.NoseConeAngle * Math.PI / 180);
            r.LengthAvionics = Math.Max(Math.Pow(coneVol / denominator, 1.0 / 3.0), 0.2);

            // Цилиндрические отсеки
            double cylArea = Math.PI * Math.Pow(Diameter / 2, 2);

            r.LengthPayload = Math.Max(r.PayloadMass / (Rho_Payload * cylArea), 0.15);
            r.LengthFuel = Math.Max(r.FuelMass / (Rho_Fuel * cylArea), 0.3);
            r.LengthEngine = Math.Max(r.EngineMass / (Rho_Engine * cylArea), 0.25);

            r.LengthTotal = r.LengthAvionics + r.LengthPayload + r.LengthFuel + r.LengthEngine;

            // Положение элементов (схема "утка")
            r.ControlPosition = r.LengthAvionics + 0.3 * r.LengthPayload; // Рули впереди
            r.WingPosition = r.LengthAvionics + r.LengthPayload + 0.4 * r.LengthFuel; // Крыло сзади
        }
        private void CalculateStructure(DataResults r)
        {
            // Шпангоуты (5 колец)
            double tFrame = 0.05 * Diameter;  // Толщина 5% от диаметра
            double hFrame = 0.03 * Diameter;  // Высота 3% от диаметра
            r.FrameMass = 5 * (Math.PI * Diameter) * (tFrame * hFrame) * Rho_Frame;

            // Стрингеры (4 уголка 20x20x3 мм)
            double AStringer = 2 * 0.02 * 0.003 - Math.Pow(0.003, 2);
            r.StringerMass = 4 * r.LengthTotal * AStringer * Rho_Stringer;

            // Обшивка
            double skinArea = Math.PI * Diameter * (r.LengthTotal - r.LengthAvionics) +
                            Math.PI * (Diameter / 2) *
                            Math.Sqrt(Math.Pow(Diameter / 2, 2) + Math.Pow(r.LengthAvionics, 2));
            r.SkinMass = skinArea * SkinThickness * Rho_Skin;

            r.StructureMass = r.FrameMass + r.StringerMass + r.SkinMass;
        }
        private void CalculateAerodynamics(DataResults r)
        {
            // Распределение подъемной силы: 85% - крыло, 15% - рули
            r.WingArea = (Diameter * Chord_Wing) + ((0.85 * r.TotalMass * Constants.Gravity) /
                        (0.5 * Constants.AirDensity * Math.Pow(Speed, 2) * CL_Wing));

            r.ControlArea = (Diameter * Chord_Control) + (0.15 * r.TotalMass * Constants.Gravity) /
                          (0.5 * Constants.AirDensity * Math.Pow(Speed, 2) * CL_Control);


            // Ограничение размаха
            r.WingSpan = r.WingArea / Chord_Wing;
            r.ControlSpan = r.ControlArea / Chord_Control;
        }
        private void OptimizeCentering(DataProcessor p, DataResults r)
        {
            const double MaxStabilityMargin = 0.05; // Максимальный запас устойчивости (5 см)

            // Инициализируем лучшие значения
            double bestStability = double.MaxValue;
            double bestCP = 0;
            double bestCG = 0;
            double bestControlPos = r.ControlPosition;
            bool solutionFound = false;

            // Определяем допустимые границы для положения рулей
            double minControlPos = r.LengthAvionics * 0.01; // Минимальная позиция - 5% от длины отсека с аппаратурой
            double maxControlPos = r.LengthAvionics + r.LengthPayload; // Максимальная позиция - конец отсека с полезной нагрузкой

            // Шаг для перебора позиций
            double stepSize = 0.001; // Шаг 1 мм для более точного поиска

            //Console.WriteLine($"Поиск оптимального положения рулей между {minControlPos:F3} м и {maxControlPos:F3} м");
            //MessageBox.Show($"Поиск оптимального положения рулей между {minControlPos:F3} м и {maxControlPos:F3} м");

            // Пробуем разные положения рулей в допустимом диапазоне
            for (double currentControlPos = minControlPos; currentControlPos <= maxControlPos; currentControlPos += stepSize)
            {
                // Расчёт центра масс (CG)
                double cmAvionics = 0.75 * r.LengthAvionics;
                double cmPayload = r.LengthAvionics + r.LengthPayload / 2;
                double cmFuel = r.LengthAvionics + r.LengthPayload + r.LengthFuel / 2;
                double cmEngine = r.LengthAvionics + r.LengthPayload + r.LengthFuel + r.LengthEngine / 2;
                double cmControl = currentControlPos + 0.25 * p.Chord_Control;
                double cmWing = r.WingPosition + 0.25 * p.Chord_Wing;

                double CG = (r.AvionicsMass * cmAvionics +
                           r.PayloadMass * cmPayload +
                           r.FuelMass * cmFuel +
                           r.EngineMass * cmEngine +
                           r.ControlMass * cmControl +
                           r.WingMass * cmWing) / r.TotalMass;

                // Расчёт центра давления (CP)
                double totalArea = r.WingArea + r.ControlArea;
                if (totalArea <= 1e-6) // Защита от деления на ноль
                {
                    MessageBox.Show("Ошибка: Суммарная площадь крыла и рулей слишком мала.");
                    return;
                }

                // Правильная формула для CP
                double CP = (r.WingArea * (r.WingPosition + 0.25 * p.Chord_Wing) +
                             r.ControlArea * (currentControlPos + 0.25 * p.Chord_Control)) / totalArea;

                // Запас статической устойчивости
                double stability = CP - CG;

                //// Для диагностики выводим каждые 10 шагов
                //if (Math.Round(currentControlPos * 100) % 10 == 0)
                //{
                //    //Console.WriteLine($"Отчет: Позиция={currentControlPos:F3}, CG={CG:F3}, CP={CP:F3}, Запас={stability:F3}");
                //    MessageBox.Show($"Отчет: Позиция={currentControlPos:F3}, CG={CG:F3}, CP={CP:F3}, Запас={stability:F3}");
                //}

                // Проверяем выполнение условия устойчивости
                if (stability >= 0 && stability <= MaxStabilityMargin)
                {
                    // Найденное решение
                    if (solutionFound == false || stability < bestStability)
                    {
                        bestStability = stability;
                        bestCP = CP;
                        bestCG = CG;
                        bestControlPos = currentControlPos;
                        solutionFound = true;
                    }
                }
                else if (!solutionFound)
                {
                    // Если решение еще не найдено, сохраняем ближайшее к условию
                    double currentDist = Math.Abs(stability - (stability >= 0 ? MaxStabilityMargin / 2 : 0));
                    double bestDist = Math.Abs(bestStability - (bestStability >= 0 ? MaxStabilityMargin / 2 : 0));

                    if (currentDist < bestDist || bestStability < 0)
                    {
                        bestStability = stability;
                        bestCP = CP;
                        bestCG = CG;
                        bestControlPos = currentControlPos;
                    }
                }
            }

            // Устанавливаем лучшие найденные значения
            r.CG_Position = bestCG;
            r.CP_Position = bestCP;
            r.StabilityMargin = bestStability;
            r.ControlPosition = bestControlPos;

            // Вывод результатов
            if (solutionFound)
            {
                //Console.WriteLine($"Оптимизация успешна. Запас устойчивости: {bestStability:F3} м");
                MessageBox.Show($"Оптимизация успешна. Запас устойчивости: {bestStability:F3} м");
            }
            else
            {
                //Console.WriteLine($"Предупреждение: Не удалось достичь 0 <= CP - CG <= {MaxStabilityMargin} м.");
                MessageBox.Show($"Предупреждение: Не удалось достичь 0 <= CP - CG <= {MaxStabilityMargin} м.");
            }

            //Console.WriteLine($"Итоговые параметры:");
            //Console.WriteLine($"- Положение рулей: {bestControlPos:F3} м");
            //Console.WriteLine($"- Центр масс (CG): {bestCG:F3} м");
            //Console.WriteLine($"- Центр давления (CP): {bestCP:F3} м");
            //Console.WriteLine($"- Запас устойчивости: {bestStability:F3} м");
        }

    }
}
