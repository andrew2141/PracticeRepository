namespace ConsoleApp1;

public class Program  // Лабораторная 2
{
    static void Main(string[] args)
    {
        int n = 100;   
        int[] numbers = new int[n];

        Console.Write("Введите стартовое значение: ");
        int startValue = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            numbers[i] = startValue;
            startValue -= 3;
        }

        Console.Write("Последовательность: ");
        
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}