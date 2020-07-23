using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                      System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int N;

            int m = 0;

            bool f;
            do
            {
                Console.WriteLine("Ввести N= ");
                f = int.TryParse(Console.ReadLine(), out N);
                if (!f)
                {
                    Console.WriteLine("Помилка введіть ще раз");
                }
            } while (!f);

            while (N != 0)
            {
                m *= 10;
                m += N % 10;
                N /= 10;
            }
            Console.WriteLine(m);




            Console.ReadKey();
        }
    }
}
