namespace Chernovik2;

public class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Dictionary<string, int[]> DictionaryOfTemperatures = new Dictionary<string, int[]>();
        
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        Console.WriteLine("Temperatures by month: ");

        foreach (var month in months)
        {
            int[] temperatures = new int[30];
            Console.Write($"{month}: ");

            for (int day = 0; day < 30; day++)
            {
                temperatures[day] = random.Next(-20, 30);
                Console.Write(temperatures[day] + " ");
            }

            DictionaryOfTemperatures.Add(month, temperatures);
            Console.WriteLine();
        }

        Dictionary<string, float> averageTemperatureDictionary = calculateAverageTemperatures(DictionaryOfTemperatures);
        Console.WriteLine("\nAverage temperatures by month: ");
        foreach (var entry in averageTemperatureDictionary)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value:F2} degrees");
        }

        var sortedAverageTemperatures = new SortedDictionary<float, string>();
        foreach (var entry in averageTemperatureDictionary)
        {
            sortedAverageTemperatures.Add(entry.Value, entry.Key);
        }
        
        Console.WriteLine("\nSorted average temperatures:");
        foreach (var entry in sortedAverageTemperatures)
        {
            Console.WriteLine($"{entry.Value}: {entry.Key:F2} degrees");
        }
    }

    static Dictionary<string, float> calculateAverageTemperatures(Dictionary<string, int[]> temperatureDictionary)
    {
        Dictionary<string, float> averageTemperatureDictionary = new Dictionary<string, float>();

        foreach (var entry in temperatureDictionary)
        {
            float sum = 0;
            foreach (var temperature in entry.Value)
            {
                sum += temperature;
            }

            float averageTemperature = sum / entry.Value.Length;
            averageTemperatureDictionary.Add(entry.Key, averageTemperature);
        }

        return averageTemperatureDictionary;
    }
}
