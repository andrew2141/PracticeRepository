public class Program
{
    static void Main(string[] args)  Лабораторная 5 задание 3
    {
        try
        {
            int[] numbers = File.ReadAllText(@"D:\ConsoleApp4\ConsoleApp2\bin\Debug\net7.0\numsTask3 (2).txt").Split(' ').Select(int.Parse).ToArray();

            int minIndex = Array.IndexOf(numbers, numbers.Min());

            int sum = 0;
            for (int i = 0; i < minIndex; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Среднее арифметическое элементов расположенных до минимального: {sum / minIndex}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }
}
