using System;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        int numInt = Convert.ToInt32(Console.ReadLine());
        double numDouble = Convert.ToDouble(Console.ReadLine());
        string inputString = Console.ReadLine();
        Console.WriteLine(i + numInt);
        Console.WriteLine((d + numDouble).ToString("F1"));
        Console.WriteLine(s + inputString);
    }
}