public class Program
{
    static void Main(string[] args)
    {
        try
        {
            string[] lines = File.ReadAllLines(@"D:\ConsoleApp2\ConsoleApp3\bin\Debug\net7.0\numbers.txt");

            int[] height = lines[0].Split(' ').Select(int.Parse).ToArray();

            int maxArea = 0;
            int leftBorder = 0;
            int rightBorder = height.Length - 1;

            while (leftBorder < rightBorder)
            {
                int h = Math.Min(height[leftBorder], height[rightBorder]);
                int w = rightBorder - leftBorder;
                maxArea = Math.Max(maxArea, h * w);

                if (height[leftBorder] < height[rightBorder])
                {
                    leftBorder++;
                }
                else
                {
                    rightBorder--;
                }
            }

            Console.WriteLine($"Максимальная площадь воды: {maxArea}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }
}