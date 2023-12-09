public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");  // Лабораторная 4 задание 1
        int number = Int32.Parse(Console.ReadLine());

        int product = 1;
        for (int i = 3; i <= number; i += 3)
        {
            product *= i;
        }

        Console.WriteLine($"Произведение натуральных чисел, кратных трём и не превышающим число n: {product}");
    }
}
