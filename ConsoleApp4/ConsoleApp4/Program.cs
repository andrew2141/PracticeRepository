public class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] numbers = File.ReadAllText(@"D:\ConsoleApp4\ConsoleApp4\bin\Debug\net7.0\numsTask1.txt").Split(' ', ',').Select(int.Parse).ToArray();
            
            int minIndex = Array.IndexOf(numbers, numbers.Min());

            int product = 1;
            for (int i = minIndex + 1; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine($"Произведение элементов после минимального: {product}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }
}