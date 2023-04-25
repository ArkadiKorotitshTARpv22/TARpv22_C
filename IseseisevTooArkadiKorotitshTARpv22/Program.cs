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

            //Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения гласных букв латинского алфавита в строку (не различая регистры).

            /*Console.WriteLine("Pakkumine: ");
            string line = Console.ReadLine();
            string glas = "iüueöõoäaIÜUEÖÕOÄA";
            int lineTotal = line.Length;
            int result = 0;
            foreach (char symbol in line)
            {
                if (glas.Contains(symbol.ToString()))
                    result++;
            }
            double percent = ((double)result / (double)lineTotal) * 100;
            Console.WriteLine("vokaalid kokku: " + result);
            Console.WriteLine("vokaalide esinemise protsent: "+percent +"%");*/

            Console.WriteLine("---------------------------------------------");

            //Задан массив действительных чисел из N элементов (используйте генератор случайных чисел). Определить количество элементов, значения которых находятся в диапазоне от -100 до +100.

            /*var rnd = new Random();
            int[] arvud = new int[rnd.Next(100)];
            int count = 0;
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(-1000, 1000);
            }
            foreach (int arv in arvud)
            {
                if (arv > -100 && arv < 100)
                {
                    Console.WriteLine(arv);
                    count++;
                }
                    
            }
            Console.WriteLine("Kokku: "+count);*/

            Console.WriteLine("---------------------------------------------");

            //Написать подпрограмму, которая вычисляет подоходный налог для введеной пользователем зарплаты.

            Tax();
            Console.WriteLine("Uuesti proovida? (y/n) ");
            string ask = Console.ReadLine();
            ask = ask.ToLower();
            if (ask=="y")
                do{
                    Tax();
                    Console.WriteLine("Uuesti proovida? (y/n) ");
                    ask = Console.ReadLine();
                    ask = ask.ToLower();
                } while (ask == "y");
            else if (ask != "y")
            {
                Console.WriteLine("Hüvasti");
            }

            Console.WriteLine("---------------------------------------------");
        }
    }
}