using System;

class Solution {
    public static void Main(string[] args) {
        string S = Console.ReadLine();
        try {
            var n = Convert.ToInt32(S);
            Console.WriteLine(n);
        }
        catch (Exception e) {
            Console.WriteLine("Bad String");
        }
    } 
}