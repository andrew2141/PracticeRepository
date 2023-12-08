public class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] numbers = File.ReadAllText(@"D:\ConsoleApp4\ConsoleApp3\bin\Debug\net7.0\numsTask4 (2).txt").Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Max() - numbers[i] == 1)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine($"Сумма элементов, отличающихся от максимального от 1: {sum}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }
}