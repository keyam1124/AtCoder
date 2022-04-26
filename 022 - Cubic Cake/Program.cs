using System.Collections.Generic;
using System.Linq;
using System;

class Program {
    public static void Main(string[] args) {
        var abc = Console.ReadLine().Split(" ");
        long a = long.Parse(abc[0]);
        long b = long.Parse(abc[1]);
        long c = long.Parse(abc[2]);

        // a b cの最大公約数を求める
        long gcdab = Gcd(a, b);
        long gcdcab = Gcd(c, gcdab);
        long res = (a / gcdcab - 1) + (b / gcdcab - 1) + (c / gcdcab - 1);
        Console.WriteLine(res);
    }

    /// <summary>
    /// ユークリッドの互除法
    /// </summary>
    /// <returns></returns>
    private static long Gcd(long a, long b) {
        if (a < b)
            // 引数を入替えて自分を呼び出す
            return Gcd(b, a);
        while (b != 0) {
            var remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }

}