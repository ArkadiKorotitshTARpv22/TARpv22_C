using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace ConsoleApplication
{
    class Program
    {
        static void Tax()
        {
            double t = 0.13;
            Console.WriteLine("Kirjutage üles teenitud rahasumma: ");
            double m = int.Parse(Console.ReadLine());
            double ml = m * t;
            double totalm = m - ml;
            Console.WriteLine(totalm+"$");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");

            /*Console.WriteLine("Pakkumine:");
            string line = Console.ReadLine();
            string vowels = "iüueöõoäa";
            int lineTotal = line.Length;
            int result = 0;
            foreach (char symbol in line)
            {
                if (vowels.Contains(symbol.ToString()))
                    result++;
            }
            var percent = ((double)result / (double)lineTotal) * 100;
            Console.WriteLine(percent+"%");*/

            Console.WriteLine("---------------------------------------------");

            /*Console.Write("N = ");
            var N = int.Parse(Console.ReadLine());
            var a = new int[N];
            var r = new Random();
            var count = 0;
            for (var i = 0; i < N; i++)
            {
                a[i] = r.Next(-3000,3000);
                if (a[i] > -100 && a[i] < 100) count++;
            }
            Console.WriteLine("Count {0}", count);*/

            Console.WriteLine("---------------------------------------------");

            /*Tax();
            Console.WriteLine("Uuesti proovida? (y/n) ");
            string ask = Console.ReadLine();
            ask.ToLower();
            if (ask=="y")
            {
                Tax();
            }
            else
            {
                Console.WriteLine("Hüvasti");
            }*/

            Console.WriteLine("---------------------------------------------");
        }
    }
}