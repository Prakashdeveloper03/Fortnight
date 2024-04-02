using System;

class Solution
{
    public static int calculateFee(List<int> returned, List<int> due)
    {
        if (returned[2] > due[2])
            return 10000;
        else if (returned[2] < due[2])
            return 0;
        if (returned[1] > due[1])
            return 500 * (returned[1] - due[1]);
        if (returned[0] > due[0])
            return 15 * (returned[0] - due[0]);
        return 0;
    }

    static void Main(String[] args)
    {
        List<int> returned = Console.ReadLine().Split(' ').ToList().
                            Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        List<int> due = Console.ReadLine().Split(' ').ToList().
                        Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        Console.WriteLine(calculateFee(returned, due));
    }
}