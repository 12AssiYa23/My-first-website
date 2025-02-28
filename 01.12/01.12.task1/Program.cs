using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._12.task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість секунд");
            int s = int.Parse(Console.ReadLine());
            int h = s / 3600;
            Console.WriteLine("h=" + h);
            int reminder = s % 3600;
            Console.WriteLine("reminder=" + reminder);
            int m = reminder / 60;
            Console.WriteLine("m=" + m);
            int reminder1 = reminder % 60;
            Console.WriteLine("reminder1=" + reminder1);
            Console.ReadKey();
        }
    }
}
