using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MethodShella
{
    class Program
    {
        static void ShellSort(int n, int[] mass)
        {
            int i, j, step;
            int tmp;
            for(step = n / 2; step > 0; step /= 2)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (i = step; i < n; i++)
                {
                    tmp = mass[i];
                    for(j = i;j >= step; j -= step)
                    {
                        if (tmp < mass[j - step])
                            mass[j] = mass[j - step];
                        else
                            break;
                    }
                    mass[j] = tmp;

                    stopwatch.Stop();

                    Console.WriteLine("Выполнено за " + stopwatch.ElapsedTicks / (decimal)Stopwatch.Frequency + " секунд!");
                }
            }
        }

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

            Console.WriteLine(new string('-', 40));

            ShellSort(10, a);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.ReadKey();
        }
    }
}
