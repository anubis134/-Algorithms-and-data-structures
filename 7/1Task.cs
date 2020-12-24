using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FIrst1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = GenerateList();

            foreach(object item in list)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }

        static List<object> GenerateList()
        {
            List<object> list = new List<object>();

            for (char i = 'A'; i < 'Z'; i++)
            {
                list.Add(i);
            }

            for (char i = 'a'; i < 'z'; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i <= 9; i++)
            {
                list.Add(i);
            }

            List<object> answer = new List<object>();

            Random random = new Random();

            for (int i = 0; i <= 9; i++)
            {
                answer.Add(list[random.Next(0, list.Count - 1)]);
            }

            return answer;
        }
    }
}
