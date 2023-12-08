public class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Введите количество строк матрицы:");
        int rows = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Введите количество столбцов матрицы:");
        int colls = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[rows, colls];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colls; j++)
            {
                matrix[i, j] = random.Next(0, 2);
            }
        }
        
        Console.WriteLine("Матрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colls; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }

        int[,] changedMatrix = new int[rows, colls + 1];
        int count = 0;
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colls; j++)
            {
                changedMatrix[i, j] = matrix[i, j];
                if (matrix[i, j] == 1)
                {
                    count++;
                }
            }

            if (count % 2 == 0)
            {
                changedMatrix[i, rows + 2] = 0;
            }
            else
            {
                changedMatrix[i, rows + 2] = 1;
            }

            count = 0;
        }
        
        Console.WriteLine("Измененная матрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colls + 1; j++)
            {
                Console.Write($"{changedMatrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}