using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_comparisons
{
    class Program
    {
        static int binarySearch_comparisons = 0;

        static int simpleSearch_comparisons = 0;
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

            Array.Sort(a);

            Console.WriteLine("Бинарный поиск!");

            Console.Write("Введите число, которое хотите найти: ");
            int s = int.Parse(Console.ReadLine());

            int serch = BinarySearch(a,s,0,a.Length - 1);

            if (serch < 0)
            {
                Console.WriteLine("Число {0} не найдено!", s);
            }
            else
            {
                Console.WriteLine("Число {0} было найдено!", s);
            }

            Console.WriteLine(new string('-', 40));

            Console.WriteLine("Простой поиск!");

            SimpleSearch(s,a);

            Console.WriteLine(new string('-', 40));

            Console.WriteLine("Кол-во сравнений для бинарного поиска:" + binarySearch_comparisons);
            Console.WriteLine("Кол-во сравнений для простого поиска:" + simpleSearch_comparisons);

            Console.ReadKey();

        }

        static void SimpleSearch(int s,int[] array)
        {
            for (int i = 0; i < 10; i++)
            {
                if (s == array[i])
                {

                    Console.WriteLine($"Число {s} найдено!");
                    break;
                }

                simpleSearch_comparisons++;
                
            }
        }

        static int BinarySearch(int[] array, int searchInt, int first, int last)
        {
            if (first > last)
            {
                return -1;
            }

            int middle = (first + last) / 2;

            int middleValue = array[middle];

            binarySearch_comparisons++;

            if (middleValue == searchInt)
            {
                return middle;
            }
            else
            {
                if (middleValue > searchInt)
                {
                    return BinarySearch(array, searchInt, first, middle - 1);
                }
                else
                {
                    return BinarySearch(array, searchInt, middle + 1, last);
                }
            }
        }
    }
}
