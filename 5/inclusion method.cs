using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SortInclusion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            Console.WriteLine("Заполните массив!");

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                a[i] = random.Next(-10, 10);
                Console.WriteLine(a[i]);
            }

            Console.WriteLine(new string('-',40));

            InclusionSort(a,10);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.ReadKey();
        }

        static void InclusionSort(int[] num,int size)
        {
            for(int i = 1; i < size; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                int value = num[i];

                int index = i;

                while((index > 0) && (num[index - 1] > value))
                {
                    num[index] = num[index - 1];
                    index--;
                }

                num[index] = value;

                stopwatch.Stop();

                Console.WriteLine("Выполнено за " + stopwatch.ElapsedTicks / (decimal)Stopwatch.Frequency + " секунд!");
            }
        }
    }
}
