using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVsDuckDesigner
{
    public static class Manipulator
    {
        

        public static bool ConvertTo(string value, out double result)
        {
            if (double.TryParse(value, out result))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Некорректный ввод! Введите число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = 0; // Устанавливаем значение по умолчанию
                return false;
            }
        }
    }

}
