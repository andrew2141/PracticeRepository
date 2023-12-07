namespace ConsoleApp;

public class Program
{
    static void Main(string[] args) 
    {
        List<string> words = new List<string>(); 

        while (true)    
        {
            Console.Write("Введите строку: ");
            string word = Console.ReadLine();
            if (word != "")
            {
                words.Add(word);
            }
            else
            {
                break;
            }
        }

        string maxIndex = words[0]; 
        string minIndex = words[0];

        foreach (string word in words)    
        {
            if (word.Length > maxIndex.Length)
            {
                maxIndex = word;
            }

            if (word.Length < minIndex.Length)
            {
                minIndex = word;
            }
        }

        Console.Write($"наибольшая строка: {maxIndex}\n");
        Console.Write($"наименьшая строка: {minIndex}\n");
    }
}