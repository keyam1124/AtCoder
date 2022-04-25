using System.Collections.Generic;
using System.Linq;
using System;

class Program {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        var abc = Console.ReadLine().Split(" ");
        var a = int.Parse(abc[0]);
        var b = int.Parse(abc[1]);
        var c = int.Parse(abc[2]);

        const int MAX = 9999;

        long ans = MAX;
        for (long i = 0; i <= 9999; i++) {
            for (long j = 0; j <= MAX - i; j++) {
                long abSum = i * a + j * b;
                if (abSum > n) {
                    break;
                }
                long nokori = n - abSum;
                if (nokori % c == 0) {
                    long sum = i + j + nokori / c;
                    if (ans > sum) {
                        ans = sum;
                    }
                }
            }
        }

        Console.WriteLine(ans);

    }
}