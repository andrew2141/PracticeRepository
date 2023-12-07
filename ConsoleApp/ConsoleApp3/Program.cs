namespace ConsoleApp;

public class Program
{
    static void Main(string[] args) 
    {
        Console.Write("Введите начало диапазона: ");
        int leftBorder = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите конец диапазона: ");
        int rightBorder = Convert.ToInt32(Console.ReadLine());

        List<int> randomNums = GenerateRandomNumbers(leftBorder, rightBorder);
        
        Console.Write("Элементы массива: ");
        foreach (var i in randomNums)
        {
            Console.Write($"{i} ");
        }
    }

    static List<int> GenerateRandomNumbers(int leftBorder, int rightBorder)
    {
        List<int> randomNumbers = new List<int>();
        Random random = new Random();

        Console.Write("Введите количество чисел: ");
        int count = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < count; i++)
        {
            int randomNum = random.Next(leftBorder, rightBorder + 1);
            randomNumbers.Add(randomNum);
        }

        return randomNumbers;
    }
}