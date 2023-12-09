public class Program
{
    static void Main(string[] args)    // Лабораторная 4 задание 4
    {
        try
        {
            string[] lines = File.ReadAllLines("numsTask4.txt");

            int[] nums = lines[0].Split(' ').Select(int.Parse).ToArray();
            int count = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество одинаковых рядом стоящих чисел: {count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }
}
