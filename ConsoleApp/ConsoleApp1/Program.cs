namespace ConsoleApp;

public class Program
{
    static void Main(string[] args) 
    {
        List<int> numbers = new List<int>();    

        int summ = 0;    
        int product = 1;

        while (true)   
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
                summ += number;
                product *= number;
            }
            else
            {
                break;
            }
        }

        float average = (float) summ / numbers.Count;    
        
        Console.WriteLine($"Сумма: {summ}");   
        Console.WriteLine($"Среднее арифметическое: {average}");
        Console.WriteLine($"Произведение: {product}");

    }
}