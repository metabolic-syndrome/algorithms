using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_power
{ // Реализовать функцию возведения числа a в степень b
  
    class Program
    {
        static void Main(string[] args)
        {
            Double a, p;  // Переменные 
            Console.WriteLine("Введите a");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            a = Convert.ToDouble(Console.ReadLine());      // без рекурсии 
            p = System.Math.Pow(p, a);
            Console.WriteLine("результат = " + p);
            Console.Read();

            int Pow(int number, int power)
            {
                if (power == 1)
                    return number;
                return number * Pow(number, --power);  // с рекурсией
            }

        }
    }
}