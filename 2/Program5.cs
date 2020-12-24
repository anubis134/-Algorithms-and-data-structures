using System;
using System.Collections.Generic;

namespace SimpleLogic
{
    class Program
    {
        public static void DecideOftheTask() {
            float AllCash = 44000;
            List<float> spendedMoney = new List<float>();
            spendedMoney.Add(11000);
            spendedMoney.Add( AllCash * 0.25f);
            spendedMoney.Add(AllCash * 0.15f);
            foreach (float value in spendedMoney) {
                AllCash -= value;
            }
            Console.WriteLine("Осталось " + AllCash + " $");
        }
        static void Main(string[] args)
        {
            DecideOftheTask();
        }
    }
}
