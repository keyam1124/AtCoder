using System.Collections.Generic;
using System.Linq;
using System;

class Program {


    public static void Main(string[] args) {
        var n = int.Parse(Console.ReadLine());
        var modAAndCnt = Console.ReadLine().Split(" ").Select(x => int.Parse(x) % 46).GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        var modBAndCnt = Console.ReadLine().Split(" ").Select(x => int.Parse(x) % 46).GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        var modCAndCnt = Console.ReadLine().Split(" ").Select(x => int.Parse(x) % 46).GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

        long cnt = 0;
        foreach (var modA in modAAndCnt.Keys) {
            foreach (var modB in modBAndCnt.Keys) {
                foreach (var modC in modCAndCnt.Keys) {
                    if ((modA + modB + modC) % 46 == 0) {
                        cnt += (long)modAAndCnt[modA] * (long)modBAndCnt[modB] * (long)modCAndCnt[modC];
                    }
                }
            }
        }

        Console.WriteLine(cnt);
    }
}