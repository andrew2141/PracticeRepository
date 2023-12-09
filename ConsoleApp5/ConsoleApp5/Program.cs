public class Program
{
    static void Main(string[] args)    // Лабораторная 6 задание 1
    {
        try
        {
            string[] words = File.ReadAllText(@"C:\\Users\\Andrey\\Desktop\\Новая папка (2)\\ConsoleApp5\\ConsoleApp5\\bin\\Debug\\net7.0\numsTask1 (2).txt").Split(' ', ',').ToArray();
        
            foreach (var word in words)
            {
                if (word.Length % 2 != 0)
                {
                    Console.Write($"{word} ");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }
}
