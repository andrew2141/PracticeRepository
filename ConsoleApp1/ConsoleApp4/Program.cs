namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[,] temperatures = new int[12, 30];

        for (int month = 0; month < 12; month++)
        {
            for (int day = 0; day < 30; day++)
            {
                temperatures[month, day] = random.Next(-36, 35);
            }
        }
        
        Console.WriteLine("Temperatures by month: ");
        
        for (int month = 0; month < 12; month++)
        {
            Console.WriteLine($"Month {month + 1}:");
            for (int day = 0; day < 30; day++)
            {
                Console.Write(temperatures[month, day] + " ");
            }

            Console.WriteLine();
        }
        
        float[] averageTemperatures = calculateAverageTemperatures(temperatures);
        
        Console.WriteLine("\nAverage temperatures by month:");
        
        for (int month = 0; month < 12; month++)
        {
            Console.WriteLine($"Month {month + 1}: {averageTemperatures[month]:F2} degrees");
        }
        
        Array.Sort(averageTemperatures);
        
        Console.WriteLine("\nSorted average temperatures:");
        
        for (int month = 0; month < 12; month++)  
        {
            Console.WriteLine($"Month {month + 1}: {averageTemperatures[month]:F2} degrees");
        }

        static float[] calculateAverageTemperatures(int[,] temperatures)
        {
            float[] averageTemperatures = new float[12];

            for (int month = 0; month < 12; month++)
            {
                float sum = 0;
                for (int day = 0; day < 30; day++)
                {
                    sum += temperatures[month, day];
                }

                averageTemperatures[month] = sum / 30;
            }

            return averageTemperatures;
        }
    }
}