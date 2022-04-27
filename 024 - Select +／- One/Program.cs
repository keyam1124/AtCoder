using System.Collections.Generic;
using System.Linq;
using System;

class Program {
    public static void Main(string[] args) {
        var nk = Console.ReadLine().Split(" ");
        int n = int.Parse(nk[0]);
        long k = long.Parse(nk[1]);
        var a = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        var b = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        long absSum = 0;
        for (int i = 0; i < n; i++) {
            absSum += Math.Abs(a[i] - b[i]);
        }

        // 絶対値の合計が試行回数より大きい場合はNG
        if (absSum > k) {
            Console.WriteLine("No");
        } else {
            // 絶対値の合計と試行回数の偶奇が一致するかを確認する
            if ((absSum + k) % 2 == 0) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }
        }
    }
}