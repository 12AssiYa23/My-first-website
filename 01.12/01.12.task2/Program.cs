using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._12.task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину ділянки(у метрах)");
            int d = int.Parse(Console.ReadLine());
            d = d * 100;
            int t60 = d / 60;
            int rem = d % 60;
            int t20 = rem / 20;
            int s = rem % 20;
            Console.WriteLine("t60=" + t60);
            Console.WriteLine("t20=" + t20);
            Console.WriteLine("s=" + s);
            Console.ReadKey();
        }
    }
}
