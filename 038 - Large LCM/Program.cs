using System.Collections.Generic;
using System.Linq;
using System;

class Program {

    private const long MAX = 1000000000000000000;

    public static void Main(string[] args) {
        var ab = Console.ReadLine().Split(" ");
        long a = long.Parse(ab[0]);
        long b = long.Parse(ab[1]);

        var lcm = Lcm(a, b);

        if (lcm <= MAX) {
            Console.WriteLine(lcm);
        } else {
            Console.WriteLine("Large");
        }
    }

    /// <summary>
    /// 最大公約数（ユークリッドの互除法）
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

    /// <summary>
    /// 最小公倍数
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    private static long Lcm(long a, long b) {
        var gcd = Gcd(a, b);
        try {
            checked {
                return a / gcd * b;
            }
        } catch (OverflowException) {
            return MAX + 1;
        }
    }
}