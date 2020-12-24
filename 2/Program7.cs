using System;
using System.Collections.Generic;

namespace SimpleLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Words = new List<string>() { "fanat", "apple", "abracadabra", "Tarantino", "yahoo", "yandex", "gool", "logo" }; Words.Sort(); foreach (string str in Words) { Console.WriteLine(str); }
        }
    }
}
