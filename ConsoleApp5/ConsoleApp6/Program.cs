public class Program
{
    static void Main(string[] args) // Лабораторная 6 задание 6
    {
        Random random = new Random();
        
        Console.WriteLine("Введите размер массива: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        double[] array = new double[number];

        for (int i = 0; i < number; i++)
        {
            array[i] = random.Next(-100, 100) / 100.0;
        }

        int negativeCount = 0;
        int positiveCount = 0;
        
        foreach (var num in array)
        {
            if (num >= 0)
            {
                positiveCount++;
            }
            else
            {
                negativeCount++;
            }
        }
        double[] negativeArray = new double[negativeCount];
        double[] positiveArray = new double[positiveCount];

        int j = 0;
        int k = 0;
        
        for (int i = 0; i < number; i++)
        {
            if (array[i] >= 0)
            {
                positiveArray[j] = array[i];
                j++;
            }
            else
            {
                negativeArray[k] = array[i];
                k++;
            }
        }
        
        Console.WriteLine("Исходный массив");
        foreach (var num in array)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
        
        Console.WriteLine("Массив с положительными элементами");
        foreach (var num in positiveArray)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
        
        Console.WriteLine("Массив с отрицательными элементами");
        foreach (var num in negativeArray)
        {
            Console.Write($"{num} ");
        }
    }
}
