using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> goods = new Dictionary<int, string>();

            Console.WriteLine("Список товаров:");

            Console.WriteLine("1.Молоко\n2.Сахар\n3.Гречка\n4.Макароны\n");
            goods.Add(1, "Молоко");
            goods.Add(2, "Сахар");
            goods.Add(3, "Гречка");
            goods.Add(4, "Макароны");

            Console.Write("Введите название товара:");
            string name = Console.ReadLine();


            int countOfUntrueValues = 0;
            foreach (KeyValuePair<int, string> item in goods)
            {
                if (name == item.Value)
                {
                    Console.WriteLine($"Товар с названием {name} имеет номер — {item.Key}");
                }
                else {
                    countOfUntrueValues++;
                    
                }

            }
            if(countOfUntrueValues == goods.Count) Console.WriteLine($"Товар с названием {name} не найден");

            Console.ReadKey();
        }
    }
}
