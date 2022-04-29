using System.Collections.Generic;
using System.Linq;
using System;

class Program {


    public static void Main(string[] args) {
        var nq = Console.ReadLine().Split(" ");
        int n = int.Parse(nq[0]);
        int q = int.Parse(nq[1]);
        var a = Console.ReadLine().Split(" ").Select(long.Parse).ToList();
        var aLastIdx = a.Count - 1;

        int shiftCnt = 0;

        for (int i = 0; i < q; i++) {
            var txy = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int t = txy[0];
            int x = txy[1];
            int y = txy[2];
            x = x <= shiftCnt ? x - shiftCnt + a.Count : x - shiftCnt;
            y = y <= shiftCnt ? y - shiftCnt + a.Count : y - shiftCnt;
            if (t == 1) {
                var ax = a[x - 1];
                var ay = a[y - 1];
                a[x - 1] = ay;
                a[y - 1] = ax;
            } else if (t == 2) {
                shiftCnt++;
                shiftCnt = shiftCnt % a.Count;
            } else {
                Console.WriteLine(a[x - 1]);
            }
        }
    }
}