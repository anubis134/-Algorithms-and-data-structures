using System;
using System.Collections.Generic;

namespace DictionaryTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string SourceText = "Люблю читать русскую классику и современную зарубежную литературу с хорошим адаптированным переводом. Книги нравятся разные - смешные, грустные, сложные, простые, невероятные в своей фантастичности, удивительные в своей реалистичности.";
            string[] ArrayOfWords = SourceText.Split(" ");
            List<object> list = GenerateList(ArrayOfWords.Length);

            foreach (object item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            
          
            Dictionary<object,string> Pair = new Dictionary<object,string>();

          

            CreateDictionary(Pair,ArrayOfWords,list);

            PrintDictionary(Pair);

            Console.ReadKey();

        }

        static void PrintDictionary(Dictionary<object,string> Pair) {
            foreach (KeyValuePair<object, string> pair in Pair) {
                Console.WriteLine($"Ключ '{pair.Key}' | Значение '{pair.Value}'");
            }
        }


        static void CreateDictionary(Dictionary<object,string> dict, string[] Array,List<object> listOfChars) {
            for (int i = 0; i < listOfChars.Count-1; i++) {
                dict.Add(listOfChars[i], Array[i]);
            }
        }

        static List<object> GenerateList(int countOfChars)
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

            for (int i = 0; i <= countOfChars; i++)
            {
            Repeat:

                object value = list[random.Next(0, list.Count - 1)];

                foreach (object obj in answer) {
                    if (value == obj) goto Repeat;
                }
                answer.Add(value);
               
                
            }

            return answer;
        }
    }
}
