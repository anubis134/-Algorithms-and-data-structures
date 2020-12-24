using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HashFunc("Hello"));

            Console.ReadKey();
        }

        static string HashFunc(string data)
        {
            byte[] array = Encoding.ASCII.GetBytes(data);

            int i = array.Length - 1;

            

            string value = "";

            while(i >= 0)
            {
                value += (char)(array[i] + i);

                

                i--;
            }

            return value.ToString();
        }
    }
}
