using System;

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>();
        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        List<int> hourGlass = new List<int>();
        List<int> count = new List<int>();
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                count.Add(arr[row][col]);
                count.Add(arr[row][col + 1]);
                count.Add(arr[row][col + 2]);
                count.Add(arr[row + 1][col + 1]);
                count.Add(arr[row + 2][col]);
                count.Add(arr[row + 2][col + 1]);
                count.Add(arr[row + 2][col + 2]);
                hourGlass.Add(count.Sum());
                count.Clear();
            }
        }
        Console.WriteLine(hourGlass.Max());
    }
}