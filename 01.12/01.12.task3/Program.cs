using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._12.task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть у скільки вирушив поїзд зі станції А(години)");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть хвилини коли вирушив поїзд");
            int m=int.Parse(Console.ReadLine());
            m = h * 60 + m;
            Console.WriteLine("Введіть скілько поїзд їхав(години)");
            int dh = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть скілько поїзд їхав(хвилини)");
            int dm = int.Parse(Console.ReadLine());
            dm = dh * 60 + dm;
            int em = dm + m;
            int eh = em / 60;
            em = em % 60;
            Console.WriteLine("Поїзд прибув о " + eh + ":" + em);
            Console.ReadKey();


        }
    }
}
