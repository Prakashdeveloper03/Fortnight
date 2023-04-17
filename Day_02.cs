using System;

class Result {
    public static void solve(double meal_cost, int tip_percent, int tax_percent) {
        double tax = (meal_cost * tax_percent) / 100;
        double tip = (meal_cost * tip_percent) / 100;
        double total = meal_cost + tax + tip;
        Console.WriteLine(Math.Round(total));
    }
}

class Solution {
    public static void Main(string[] args) {
        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());
        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());
        int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());
        Result.solve(meal_cost, tip_percent, tax_percent);
    }
}