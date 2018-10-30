using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_recursive_10_2
{
    class Program

     // Реализовать функцию перевода из 10 системы в двоичную используя рекурсию.
    {
        static string a(int i)
        {
            return (i == 0) ? "0" : b(i);
        }

        static string b(int i)
        {
            return (i > 0) ? b(i / 2) + (i % 2).ToString() : "";
        }

        static void Main(string[] args)
        {
            Console.Write(a(8));
            Console.ReadKey();
        }
    }
}
