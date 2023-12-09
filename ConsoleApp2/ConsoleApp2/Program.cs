public class Program
{
    static void Main(string[] args)    // Лабораторная 3 задание 1
    {
        try
        {
            string[] lines = File.ReadAllLines(@"D:\ConsoleApp2\ConsoleApp2\bin\Debug\net7.0\input.txt");

            int[] chosenNumbers = lines[0].Split(' ').Select(int.Parse).ToArray();

            int numberOfTickets = int.Parse(lines[1]);

            using (StreamWriter writer = new StreamWriter(@"D:\ConsoleApp2\ConsoleApp2\bin\Debug\net7.0.\output.txt"))
            {
                for (int i = 2; i < 2 + numberOfTickets; i++)
                {
                    int[] ticketNumbers = lines[i].Split(' ').Select(int.Parse).ToArray();

                    int matches = ticketNumbers.Intersect(chosenNumbers).Count();
                    
                    writer.WriteLine(matches >= 3 ? "Lucky" : "Unlucky");
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }
}
