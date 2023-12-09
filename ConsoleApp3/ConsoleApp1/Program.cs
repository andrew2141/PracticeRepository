public class Program
{
    static void Main(string[] args)    // Лабораторная 4 задание 2
    {
        try
        {
            string[] lines = File.ReadAllLines("numsTask2.txt");
            
            float[] nums = lines[0].Split(';').Select(float.Parse).ToArray();
            float sum = 0;

            foreach (var num in  nums)
            {
                if (num == 0)
                {
                    break;
                }

                if (num > 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine($"Сумма положительных чисел до первого нуля: {sum}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }
}
