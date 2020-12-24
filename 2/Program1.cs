using System;

namespace Operations
{
    class Program
    {

        private static int CalculateLenghtOfRope() {
            int Width = 4;
            int Height = 3;
            int result = (Math.Sqrt((Width * Width) + (Height * Height))) + 3; // Calculate Length of the rope and add 3 additional metres
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine($"В первом случае {FirstEvent()}\nВо втором случае {SecondEvent()}");
        }
    }
}
