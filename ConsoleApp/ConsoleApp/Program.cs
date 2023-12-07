namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)  // Лабораторная 1
    {
        int n = 10;    
        Random rnd = new Random();    
        int[] numbers = new int[10];   
        int minIndex = 0;

        for (int i = 0; i < n; i++)    
        {
            numbers[i] = rnd.Next(1, 1000);
        }

        for (int i = 0; i < n; i++)    
        {
            if (numbers[i] < numbers[minIndex])
            {
                minIndex = i;
            }
        }

        for (int i = 0; i < n; i++)    
        {
            Console.Write(numbers[i] + " ");    
        }
        
        Console.Write(" ");
        Console.WriteLine($"Индекс наименшьего числа: {minIndex}");
        
    }
}