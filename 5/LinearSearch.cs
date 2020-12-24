using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SimpleSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];

            Console.WriteLine("Заполните массив!");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Введите число на {0} индекс массива: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Введите число, которое хотите найти: ");
            int s = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                if (s == array[i])
                {
                    
                    Console.WriteLine($"Число {s} найдено!");
                    break;
                }
                stopwatch.Stop();

                Console.WriteLine($"Выполнено за {stopwatch.ElapsedTicks / (decimal)Stopwatch.Frequency} секунд!");
            }

            Console.ReadKey();
        }
    }
}
