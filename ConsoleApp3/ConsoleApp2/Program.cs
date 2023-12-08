public class Program
{
    static void Main(string[] args)
    {
        try
        {
            string[] lines = File.ReadAllLines(@"D:\ConsoleApp3\ConsoleApp2\bin\Debug\net7.0\numsTask3.txt");
            
            int[] nums = lines[0].Split(',').Select(int.Parse).ToArray();
            int indexOfZero = Array.IndexOf(nums, 0);
            if (indexOfZero == -1)
            {
                Console.WriteLine("Нуля нет в последовательности");
                return;
            }

            int[] sequence = nums.Take(indexOfZero).ToArray();
            double ratio = Convert.ToDouble(sequence.Min()) / sequence.Max();

            Console.WriteLine($"Отношение минимального к максимальному: {ratio}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
        
    }
}