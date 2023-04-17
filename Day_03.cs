using System;

class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        if(N % 2 == 0) {
            if(N >= 2 && N <= 5) {
                Console.WriteLine("Not Weird");
            } else if(N >= 6 && N <= 20) {
                Console.WriteLine("Weird");
            } else {
                Console.WriteLine("Not Weird");
            }
        } else {
            Console.WriteLine("Weird");
        }
    }
}