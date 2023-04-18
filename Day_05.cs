using System;

class Solution {
    public static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        if(n>=2 && 20 >= n) {
            for(int i = 1; i < 11; i++) {
                string a = n.ToString();
                string b = i.ToString();
                int result = n * i;
                Console.WriteLine(a + " x " + b + " = " + result);
            }
        }
    }
}