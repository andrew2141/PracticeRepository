namespace ConsoleApp;

public class Program
{
    static void Main(string[] args) 
    {
        Console.Write("Введите строку: ");
        string line = Console.ReadLine();

        int wordCount = 0;

        string[] words = line.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        wordCount = words.Length;

        string resultLine = $"Start {line} End";
        
        Console.WriteLine($"Количество слов в строке: {wordCount}");
        Console.WriteLine($"Измененная строка: {resultLine}");
    }
}