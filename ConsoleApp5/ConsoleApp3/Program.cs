public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число a:");
        int a = Int32.Parse(Console.ReadLine());
        
        int sum = 0;
        
        Console.WriteLine("Введите число (при вводе отрицательного числа программа закончит работу): ");
        int number = Int32.Parse(Console.ReadLine());

        while(number >= 0)
        {
            Console.WriteLine("Введите число  (при вводе отрицательного числа программа закончит работу): ");
            number = Int32.Parse(Console.ReadLine());
            if (number % a == 0)
            {
                sum += number;
            }
        }

        Console.WriteLine($"Сумма чисел, делящихся на положительное число a нацело: {sum}");
    }
}