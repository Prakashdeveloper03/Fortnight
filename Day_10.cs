using System;

class Solution {
    public static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string result = Convert.ToString(n,2).Split('0').Max();           
        int final = 0;
        foreach(char slice in result)
            final++;
        Console.WriteLine(final);
    }
}