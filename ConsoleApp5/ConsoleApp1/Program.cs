public class Program
{
    static void Main(string[] args)  // Лабораторная 6 задание 2
    {
        try
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Andrey\Desktop\Новая папка (2)\ConsoleApp5\ConsoleApp1\bin\Debug\net7.0\numsTask2 (3).txt");

            string result = string.Join(" ", lines);
            
            Console.WriteLine(result);
            
            File.WriteAllText(@"C:\Users\Andrey\Desktop\Новая папка (2)\ConsoleApp5\ConsoleApp1\bin\Debug\net7.0\numsTask2 (3).txt", result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
        
    }
}
