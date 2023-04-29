using System;

class Solution
{
    public static bool isPrime(int n)
    {
        bool pass = n > 1 && ((n % 2 > 0) || n == 2);
        if (pass)
        {
            int i = 3;
            int sqrt = (int)Math.Sqrt(n);
            while (i <= sqrt)
            {
                if ((n % i) == 0) return false;
                i += 2;
            };
        };
        return pass;
    }

    static void Main(String[] args)
    {
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string line = Console.ReadLine();
            Console.WriteLine(isPrime(int.Parse(line)) ? "Prime" : "Not prime");
        };
    }
}