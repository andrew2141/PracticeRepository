try
{
    string[] lines = File.ReadAllLines("numbers.txt");

    int[] height = lines[0].Split(' ').Select(int.Parse).ToArray();

    int maxArea = 0;
    int left = 0;
    int right = height.Length - 1;
            
    while (left < right)
    {
        int h = Math.Min(height[left], height[right]);
        int w = right - left;
        maxArea = Math.Max(maxArea, h * w);

        if (height[left] < height[right])
        {
            left++;
        }
        else
        {
            right--;
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