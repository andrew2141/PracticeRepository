namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размерность матрицы: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if ((i == 0) || (j == 0))
                {
                    matrix[i, j] = 1;
                }
                else
                {
                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
                }
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.Write("\n");
        }
    }
}