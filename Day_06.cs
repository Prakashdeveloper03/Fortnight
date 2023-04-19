using System;

class Solution {
    public static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        for (int i = 0; i < t; i++) {
            var s = Console.ReadLine();
            var even = "", odd = "";
            foreach (var (c, index) in s.Select((value, index) => (value, index))) {
                if (index % 2 == 0) {
                    even += c;
                } else {
                    odd += c;
                }
            }
            Console.WriteLine($"{even} {odd}");
        }
    }
}