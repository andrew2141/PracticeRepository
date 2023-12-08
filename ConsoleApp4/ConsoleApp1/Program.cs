public class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllText(@"D:\ConsoleApp4\ConsoleApp1\bin\Debug\net7.0\numsTask2 (2).txt").Split(';');
        float[] numbers = Array.ConvertAll(lines, float.Parse);

        Array.Sort(numbers);

        File.WriteAllText(@"D:\ConsoleApp4\ConsoleApp1\bin\Debug\net7.0\numsTask2 (2).txt", string.Join(";", numbers.Select(num => num.ToString())));

        Console.WriteLine("Числа отсортированы");
    }
}