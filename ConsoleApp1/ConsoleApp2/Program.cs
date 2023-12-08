namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        int n = 100;    
        int[] numbers = new int[n];
        int startValue = 1;
        
        for (int i = 0; i < n; i++)
        {
            numbers[i] = startValue;
            startValue += 2;
        }

        Console.Write("Последовательность: ");
        
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}