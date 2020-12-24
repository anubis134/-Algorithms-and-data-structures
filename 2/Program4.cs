using System;

namespace Operations
{
    class Program
    {
        #region Static Methods which returning values for creating universal base sructures
        private static float CalculateAllTime(float distance, float speed)// Calculate Time spended on all way 
        {
            float result = distance / speed;
            return result;
         
        }

        private static float CalculateDistance(float speed, float time)// Calculate Distance with using current speed
        {
            float result = speed * time;
            return result;

        }

        private static float ConvertUnitsOfSpeed(float speed) // convert units from metres/sec to killometres/sec
        {
            float resultofSpeed = speed * 3.6f;
           
          
                return resultofSpeed;
        }
        private static float ConvertUnitsOfTime(float time) // convert units from metres/sec to killometres/sec
        {
            float resultofTime = time / 60f;


            return resultofTime;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Общее время затраченное на дорогу: " + CalculateAllTime(CalculateDistance(ConvertUnitsOfSpeed(30), ConvertUnitsOfTime(10)), 4f) + " часа");
            Console.WriteLine($"Время затраченное на дорогу с учетом уже пройденного пути: { CalculateAllTime(CalculateDistance(ConvertUnitsOfSpeed(30), ConvertUnitsOfTime(10)), 4f) - 2f} часа");
        }
    }
}
