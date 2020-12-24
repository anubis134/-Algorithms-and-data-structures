using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Console.WriteLine("Заполните массив!");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Введите число на {0} индекс массива: ",i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            Console.Write("Введите число, которое хотите найти: ");
            int s = int.Parse(Console.ReadLine());

            int serch = BinarySearch(array, s, 0, array.Length - 1);

            if(serch < 0)
            {
                Console.WriteLine("Число {0} не найдено!",s);
            }
            else
            {
                Console.WriteLine("Число {0} было найдено!",s);
            }

            Console.ReadKey();
        }

        static int BinarySearch(int[] array, int searchInt, int first,int last)
        {
            if(first > last)
            {
                return -1;
            }

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            int middle = (first + last) / 2;

            int middleValue = array[middle];

            stopwatch.Stop();

            Console.WriteLine("Выполнено за  " + stopwatch.ElapsedTicks / (decimal)Stopwatch.Frequency + " секунд!");

            if(middleValue == searchInt)
            {
                return middle;
            }
            else
            {
                if(middleValue > searchInt)
                {
                    return BinarySearch(array,searchInt,first,middle - 1);
                }
                else
                {
                    return BinarySearch(array,searchInt,middle + 1,last);
                }
            }
        } 
    }
}
