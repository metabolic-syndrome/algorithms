using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{

    // Реализовать очередь.
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>(5);
            q.Enqueue("1");
            q.Enqueue("2");
            q.Enqueue("3");
            q.Enqueue("4");
            Console.WriteLine("Сделано: " + q.Dequeue());
            Console.WriteLine("Сделано: " + q.Dequeue());
            Console.WriteLine("Всего осталось: " + q.Count.ToString());
            Console.Read();
        }
    }
}