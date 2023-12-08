public class Program
{
    static void Main(string[] args)
    {
        try
        {
            string[] lines = File.ReadAllLines(@"D:\ConsoleApp2\ConsoleApp1\bin\Debug\net7.0\nums.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] numbers = lines[i].Split(' ');

                lines[i] = string.Join(" ", numbers.Where(number => isEven(number)));
            }

            File.WriteAllLines(@"D:\ConsoleApp2\ConsoleApp1\bin\Debug\net7.0\nums.txt", lines);

            Console.WriteLine("Числа удалены успешно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }

    static bool isEven(string number)
    {
        if (int.TryParse(number, out int num))
        {
            return num % 2 != 0;
        }

        return true;
    }
}