public class Program
{
    static void Main(string[] args)  // Лабораторная 4 задание 6
    {
        Console.WriteLine("Введите a: ");
        double a = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Введите b: ");
        double b = Int32.Parse(Console.ReadLine());

        double x1 = 0;
        double y1 = 2;

        double x2 = -2;
        double y2 = -3;

        double x3 = 2;
        double y3 = -3;


        double areaOfTriangle = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        double areaOfSubTriangle1 = 0.5 * Math.Abs(a * (y2 - y3) + x2 * (y3 - b) + x3 * (b - y2));
        double areaOfTSubTriangle2 = 0.5 * Math.Abs(x1 * (b - y3) + a * (y3 - y1) + x3 * (y1 - b));
        double areaOfTSubTriangle3 = 0.5 * Math.Abs(x1 * (y2 - b) + x2 * (b - y1) + a * (y1 - y2));
        
        
        if (Math.Abs(areaOfTriangle - (areaOfSubTriangle1 + areaOfTSubTriangle2 + areaOfTSubTriangle3)) < 0.0001)
        {
            Console.WriteLine($"Точка ({a};{b}) принадлежит области.");
        }
        else
        {
            Console.WriteLine($"Точка ({a};{b}) не принадлежит области.");
        }
    }
}
