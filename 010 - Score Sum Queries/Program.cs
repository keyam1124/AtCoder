using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var sum1List = Enumerable.Repeat(0, n + 1).ToArray();
        var sum2List = Enumerable.Repeat(0, n + 1).ToArray();
        for (int i = 1; i <= n; i++)
        {
            var ab = Console.ReadLine().Split(" ");
            if (ab[0] == "1")
            {
                sum1List[i] = sum1List[i - 1] + int.Parse(ab[1]);
                sum2List[i] = sum2List[i - 1];
            }
            else
            {
                sum1List[i] = sum1List[i - 1];
                sum2List[i] = sum2List[i - 1] + int.Parse(ab[1]);
            }
        }

        int q = int.Parse(Console.ReadLine());
        for (int i = 0; i < q; i++)
        {
            var lr = Console.ReadLine().Split(" ");
            int l = int.Parse(lr[0]);
            int r = int.Parse(lr[1]);
            int sum1 = sum1List[r] - sum1List[l - 1];
            int sum2 = sum2List[r] - sum2List[l - 1];
            Console.WriteLine($"{sum1} {sum2}");
        }
    }
}