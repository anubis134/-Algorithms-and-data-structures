using System;

namespace Operations
{
    class Program
    {

        private static double CalculateLenghtOfRope(double Width, double Height)
        {
           
            double result = (Math.Sqrt((Width * Width) + (Height * Height))) + 3; // Calculate Length of the rope and add 3 additional metres
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Необходимая длина веревки: {CalculateLenghtOfRope(4,3)}");
        }
    }
}
