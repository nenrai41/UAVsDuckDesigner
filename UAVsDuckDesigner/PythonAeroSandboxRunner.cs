using System;
using Python.Runtime;

namespace UAVsDuckDesigner
{
    public class PythonAeroSandboxRunner
    {
        private static PythonAeroSandboxRunner instance;

        private PythonAeroSandboxRunner()
        {
            InitializePython();
        }

        public static PythonAeroSandboxRunner GetInstance()
        {
            if (instance == null)
            {
                instance = new PythonAeroSandboxRunner();
            }
            return instance;
        }

        // Инициализация Python.NET
        private void InitializePython()
        {
            if (!PythonEngine.IsInitialized)
            {
                Runtime.PythonDLL = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Programs\Python\Python311\python311.dll";
                PythonEngine.Initialize();
            }
        }

        private dynamic np;
        private dynamic asb;
        private dynamic pyBuiltins;
        private dynamic plt;
        private dynamic scipy;
        private dynamic pickle;
        private dynamic trimesh;
        private dynamic os;

        private bool IsModulesOpen = false;

        private void ImportModules()
        {
            if (!IsModulesOpen)
            {
                np = Py.Import("numpy");
                asb = Py.Import("aerosandbox");
                pyBuiltins = Py.Import("builtins");
                plt = Py.Import("matplotlib.pyplot");
                scipy = Py.Import("scipy.integrate");
                pickle = Py.Import("pickle");
                trimesh = Py.Import("trimesh");
                os = Py.Import("os");
                IsModulesOpen = true;
            }
            
        }
        private void CloseModules()
        {
            if (IsModulesOpen)
            {
                np.Dispose();      // Закрываем модуль numpy
                asb.Dispose();     // Закрываем aerosandbox
                plt.Dispose();     // Закрываем matplotlib.pyplot
                scipy.Dispose();   // Закрываем scipy.integrate
                pyBuiltins.Dispose(); // Закрываем builtins
                pickle.Dispose();
                trimesh.Dispose();
                os.Dispose();

                np = null;
                asb = null;
                plt = null;
                scipy = null;
                pyBuiltins = null;
                pickle=null;
                trimesh = null;
                os = null;

                GC.Collect(); // Принудительный вызов сборщика мусора
                GC.WaitForPendingFinalizers(); // Ожидаем завершения финализации

                IsModulesOpen = false;
            }
           
        }
        public double GetOfCl(string nameOfProfile, double alpha = 0, double reynoldsNumber = 300000, double machNumber = 0.2)
        {
            try
            {
                // Импорт модулей
                ImportModules();
                
                dynamic airfoil = asb.Airfoil(name: nameOfProfile);

                // Параметры анализа
                double _alpha = alpha;                                 // углы атаки 0 градусов
                double _reynoldsNumber = reynoldsNumber;               // число Рейнольдса
                double _machNumber = machNumber;                       // число Маха

                // Получаем характеристики профиля
                dynamic neuralfoil = airfoil.get_aero_from_neuralfoil(
                    alpha: _alpha,
                    Re: _reynoldsNumber,
                    mach: _machNumber
                );
                if (neuralfoil != null && neuralfoil != 0)
                {
                    CloseModules();
                    return (double)neuralfoil["CL"];
                }
                else
                {
                    CloseModules();
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при работе с AeroSandbox: {ex.Message}");
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Внутреннее исключение: {ex.InnerException.Message}");
                    return 0;
                }
                return 0;
            }

        }

        // Основной метод для создания и визуализации модели 
        public void CreateAndVisualizeAircraft(DataResults results)
        {
            using (Py.GIL())
            {
                try
                {
                    // Импорт модулей
                    ImportModules();
                    

                    // Создание профиля крыла
                    dynamic airfoilMainWing = asb.Airfoil(name: results.ProfileOfWingName);
                    dynamic airfoilControlWing = asb.Airfoil(name: results.ProfileOfControlName);

                    // Создание крыльев на основе расчетных данных
                    dynamic mainWing = CreateMainWing(asb, np, pyBuiltins, airfoilMainWing, results);
                    dynamic controlSurface = CreateControlSurface(asb, np, pyBuiltins, airfoilControlWing, results);

                    // Создание фюзеляжа на основе расчетных данных
                    dynamic fuselage = CreateFuselage(asb, np, pyBuiltins, results);

                    // Создание списков крыльев и фюзеляжей
                    dynamic wings = pyBuiltins.list();
                    wings.append(mainWing);
                    wings.append(controlSurface);

                    dynamic fuselages = pyBuiltins.list();
                    fuselages.append(fuselage);

                    // Создание объекта ЛА
                    dynamic airplane = asb.Airplane(
                        name: "UAV Model",
                        xyz_ref: np.array(new[] { 0.0, 0.0, 0.0 }.ToPython()),
                        wings: wings,
                        fuselages: fuselages
                    );
                    results.UAVs = airplane;

                    // Визуализация модели
                    airplane.draw();

                    // Создание точки эксплуатации с заданной скоростью
                    dynamic op_point = asb.OperatingPoint(
                        velocity: results.Speed,  // Используем скорость из результатов
                        alpha: 3.0,  // Угол атаки можно настроить
                        beta: 0.0    // Угол скольжения
                    );

                    // Аэродинамический расчет
                    dynamic vlm = asb.VortexLatticeMethod(airplane: airplane, op_point: op_point);
                    dynamic aero_data = vlm.run();

                    results.CD = aero_data["CD"];
                    results.CL = aero_data["CL"];
                    
                    //results.AerodynamicCenterOfControl = airplane.wings[1].aerodynamic_center()[0];
                    
                    // Визуализация аэродинамической сетки
                    //vlm.draw();

                    CloseModules();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при работе с AeroSandbox: {ex.Message}");
                    CloseModules();
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show($"Внутреннее исключение: {ex.InnerException.Message}");
                    }
                    return;
                }
            }
        }

        // Создание основного крыла на основе расчетных данных
        private dynamic CreateMainWing(dynamic asb, dynamic np, dynamic pyBuiltins, dynamic airfoil, DataResults results)
        {
            dynamic xsecs = pyBuiltins.list();

            // Корневое сечение
            dynamic root_section = asb.WingXSec(
                xyz_le: np.array(new[] { results.WingPosition, 0.0, 0.0 }.ToPython()),
                chord: results.Chord_Wing,
                twist: 2.0,  // Угол можно настроить
                airfoil: airfoil
            );

            // Концевое сечение
            dynamic tip_section = asb.WingXSec(
                    xyz_le: np.array(new[] { results.WingPosition, results.WingSpan / 2, 0.0 }.ToPython()),
                    chord: results.Chord_Wing * 0.7,  // Сужение к концу крыла
                    twist: 0.0,  // Угол можно настроить
                    airfoil: airfoil
                );

            xsecs.append(root_section);
            xsecs.append(tip_section);

            // Создание крыла
            return asb.Wing(
                name: "Main Wing",
                xyz_le: np.array(new[] { results.WingPosition, 0.0, 0.0 }.ToPython()),
                xsecs: xsecs,
                symmetric: true
            );
        }

        // Создание поверхности управления (рули)
        private dynamic CreateControlSurface(dynamic asb, dynamic np, dynamic pyBuiltins, dynamic airfoil, DataResults results)
        {
            dynamic xsecs = pyBuiltins.list();

            // Корневое сечение
            dynamic root_section = asb.WingXSec(
                xyz_le: np.array(new[] { results.ControlPosition, 0.0, 0.0 }.ToPython()),
                chord: results.Chord_Control,
                twist: 0.0,
                airfoil: airfoil
            );

            // Концевое сечение
            dynamic tip_section = asb.WingXSec(
                    xyz_le: np.array(new[] { results.ControlPosition, results.ControlSpan / 2, 0.0 }.ToPython()),
                    chord: results.Chord_Control * 0.8,  // Сужение к концу
                    twist: 0.0,
                    airfoil: airfoil
                );

            xsecs.append(root_section);
            xsecs.append(tip_section);

            // Создание поверхности управления
            return asb.Wing(
                name: "Control Surface",
                xyz_le: np.array(new[] { results.ControlPosition, 0.0, 0.0 }.ToPython()),
                xsecs: xsecs,
                symmetric: true
            );
        }

        // Создание фюзеляжа на основе расчетных данных
        private dynamic CreateFuselage(dynamic asb, dynamic np, dynamic pyBuiltins, DataResults results)
        {
            dynamic xsecs = pyBuiltins.list();

            // Носовой конус (начало отсека с аппаратурой)
            dynamic nose = asb.FuselageXSec(
                xyz_c: np.array(new[] { 0.0, 0.0, 0.0 }.ToPython()),
                radius: results.Diameter / 4  // Начало носа (узкая часть)
            );

            // Конец носовогоконуса (отсека с аппараутрой)
            dynamic noseEnd = asb.FuselageXSec(
                xyz_c: np.array(new[] { results.LengthAvionics, 0.0, 0.0 }.ToPython()),
                radius: results.Diameter / 2
            );

            // Средняя часть (полезная нагрузка)
            dynamic payloadSection = asb.FuselageXSec(
                xyz_c: np.array(new[] { results.LengthAvionics + results.LengthPayload, 0.0, 0.0 }.ToPython()),
                radius: results.Diameter / 2
            );

            // Топливный отсек
            dynamic fuelSection = asb.FuselageXSec(
                xyz_c: np.array(new[] { results.LengthAvionics + results.LengthPayload + results.LengthFuel, 0.0, 0.0 }.ToPython()),
                radius: results.Diameter / 2
            );

            // Хвостовая часть (двигатель)
            dynamic engineSection = asb.FuselageXSec(
                xyz_c: np.array(new[] { results.LengthTotal, 0.0, 0.0 }.ToPython()),
                radius: results.Diameter / 2
            );

            // Нулевое сечение в начале ( закрывает нос)
            dynamic noseCap = asb.FuselageXSec(
                xyz_c: np.array(new[] { -0.001, 0.0, 0.0 }.ToPython()),  // чуть перед началом
                radius: 0.0  // нулевой радиус = закрыто
            );

            // Нулевое сечение в конце (закрывает хвост)
            dynamic tailCap = asb.FuselageXSec(
                    xyz_c: np.array(new[] { results.LengthTotal + 0.001, 0.0, 0.0 }.ToPython()),
                    radius: 0.0
                 );


            xsecs.append(noseCap);
            xsecs.append(nose);
            xsecs.append(noseEnd);
            xsecs.append(payloadSection);
            xsecs.append(fuelSection);
            xsecs.append(engineSection);
            xsecs.append(tailCap);


            // Создание фюзеляжа
            return asb.Fuselage(
                    name: "Main Fuselage",
                    xyz_le: np.array(new[] { 0.0, 0.0, 0.0 }.ToPython()),
                    xsecs: xsecs
                );
        }

        // Метод для сохранения модели в файл
        public void SaveModelToFile(string filePath, DataResults dataResults)
        {
            using (Py.GIL())
            {
                try
                {
                    ImportModules();
                    
                    // Преобразуем путь
                    dynamic pyPath = os.path.normpath(filePath);
                    //MessageBox.Show($"Нормализованный путь Python: {pyPath}");

                    // Создаем список для хранения мешей
                    dynamic meshes = pyBuiltins.list();
                    int meshCount = 0;

                    // Функция для обработки mesh_body результата
                    void ProcessMeshResult(dynamic mesh_result)
                    {
                        try
                        {
                            // Проверяем, является ли результат кортежем
                            bool isTuple = (bool)pyBuiltins.isinstance(mesh_result, pyBuiltins.tuple);
                            if (isTuple)
                            {
                                // Если это кортеж, извлекаем вершины и грани
                                dynamic vertices = mesh_result[0];
                                dynamic faces = mesh_result[1];
                                dynamic proper_mesh = trimesh.Trimesh(vertices: vertices, faces: faces);
                                meshes.append(proper_mesh);
                                meshCount++;
                            }
                            else
                            {
                                // Пытаемся получить доступ к vertices и faces как к свойствам
                                try
                                {
                                    dynamic vertices = mesh_result.vertices;
                                    dynamic faces = mesh_result.faces;
                                    dynamic proper_mesh = trimesh.Trimesh(vertices: vertices, faces: faces);
                                    meshes.append(proper_mesh);
                                    meshCount++;
                                }
                                catch
                                {
                                    MessageBox.Show("Меш имеет неизвестный формат - ни кортеж, ни объект с vertices/faces");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при обработке меша: {ex.Message}");
                        }
                    }

                    
                    // Получаем меш для каждого крыла
                    try
                    {
                        if (dataResults.UAVs.wings != null)
                        {
                            foreach (var wingObj in dataResults.UAVs.wings)
                            {
                                try
                                {
                                    dynamic wing = wingObj;
                                    dynamic mesh_result = wing.mesh_body();
                                    ProcessMeshResult(mesh_result);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Пропускаем крыло из-за ошибки: {ex.Message}");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при обработке крыльев: {ex.Message}");
                    }

                    // Получаем меш для фюзеляжа
                    try
                    {
                        if (dataResults.UAVs.fuselages != null)
                        {
                            foreach (var fuselageObj in dataResults.UAVs.fuselages)
                            {
                                try
                                {
                                    dynamic fuselage = fuselageObj;
                                    dynamic mesh_result = fuselage.mesh_body();
                                    ProcessMeshResult(mesh_result);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Пропускаем фюзеляж из-за ошибки: {ex.Message}");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при обработке фюзеляжей: {ex.Message}");
                    }

                    // Объединяем все меши
                    //MessageBox.Show($"Найдено мешей: {meshCount}");

                    if (meshCount == 0)
                    {
                        throw new Exception("Нет мешей для экспорта");
                    }
                    else if (meshCount == 1)
                    {
                        //MessageBox.Show("Экспортируем один меш напрямую");
                        dynamic combined_mesh = meshes[0];
                        combined_mesh.export(pyPath);
                    }
                    else
                    {
                        //MessageBox.Show($"Экспортируем {meshCount} мешей через Scene");
                        dynamic scene = trimesh.Scene();

                        foreach (var mesh in meshes)
                        {
                            scene.add_geometry(mesh);
                        }

                        try
                        {
                            scene.export(pyPath);
                            MessageBox.Show("Экспорт успешно выполнен");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при экспорте сцены: {ex.Message}");
                            MessageBox.Show("Пробуем альтернативный метод экспорта...");
                            dynamic combined = trimesh.util.concatenate(meshes);
                            combined.export(pyPath);
                        }
                    }

                    CloseModules();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении модели: {ex.Message}");
                    CloseModules();
                }
            }
        }


    }
}
