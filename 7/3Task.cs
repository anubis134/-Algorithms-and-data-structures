using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thirt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Хэширование машинного слова \"Привет, как дела?\"");

            Console.WriteLine("Хэш " + HashFunc("Привет, как дела?"));

            Console.ReadKey();
        }

        static string HashFunc(string data)
        {
            byte[] array = Encoding.ASCII.GetBytes(data);

            Random random = new Random();


            for (int i = 0; i < array.Length; i++)
            {
                array[i] += (byte)random.Next(1, 20);
            }

            

            return Encoding.ASCII.GetString(array,0,array.Length);
        }
    }
}
