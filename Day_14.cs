using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;
    public Difference(int[] integers)
    {
        elements = integers;
    }

    public void computeDifference()
    {
        var maxDeger = elements.Max();
        var minDeger = elements.Min();
        maximumDifference = Math.Abs(maxDeger - minDeger);
    }
}

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());
        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        Difference d = new Difference(a);
        d.computeDifference();
        Console.Write(d.maximumDifference);
    }
}