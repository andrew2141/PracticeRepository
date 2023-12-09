public class Program
{
    static void Main(string[] args)   //  Лабораторная 4 задание 5
    {
        Console.WriteLine("Введите a: ");
        double m = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите b: ");
        double n = Int32.Parse(Console.ReadLine());

        double xMinimum = -1.0;
        double xMaximum = 3.0;
        double yMinimum = -2.0;
        double yMaximum = 4.0;


        if ((m >= xMinimum && m <= xMaximum) && (n >= yMinimum && n <= yMaximum))
        {
            Console.WriteLine($"Точка ({m};{n}) принадлежит заданной области");
        }
        else
        {
            Console.WriteLine($"Точка ({m};{n}) не принадлежит области.");
        }    
    }
}
