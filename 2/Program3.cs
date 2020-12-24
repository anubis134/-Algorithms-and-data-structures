using System;

namespace Operations
{
    using System;

    using System.Collections.Generic;



    namespace Operations

    {

        class Program

        {

            private static List<double> ResultOfCalculaton = new List<double>();

            private static double CalculateSquareOfRectangle(double width, double height)

            {

                double square = width * height;

                return square;

            }

            private static double CalculateSquareOfCircle(double radius)

            {

                double square = 2 * Math.PI * (radius * radius);

                return square;

            }



            private static void AddAllValues()
            {

                ResultOfCalculaton.Add(CalculateSquareOfRectangle(7, 9));

                ResultOfCalculaton.Add(CalculateSquareOfRectangle(8, 9) - CalculateSquareOfRectangle(3, 2));

                ResultOfCalculaton.Add(CalculateSquareOfCircle(4.5d));

            }



            static void Main(string[] args)

            {

                AddAllValues();

                ResultOfCalculaton.Sort();

                Console.WriteLine($"Самая маленькая площадь дома {ResultOfCalculaton[0]}");

            }

        }

    }
}