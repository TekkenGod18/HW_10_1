using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            { 
            Console.WriteLine("Введите значение угла!");
            Console.Write("Введите градусы: ");
            int gradus = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите угловые минуты: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите угловые секунды: ");
            int sec = Convert.ToInt32(Console.ReadLine());

            Angle angle = new Angle(gradus, min, sec);

            Console.WriteLine($"Созданный угол: {angle}");
            Console.WriteLine($"Значение в радианах: {angle.ToRadians():F6}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено некорректное числовое значение");
            }
            Console.ReadKey();
        }
    }
}
