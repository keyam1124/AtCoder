using System.Collections.Generic;
using System.Linq;
using System;

class Program {


    public static void Main(string[] args) {
        var nk = Console.ReadLine().Split(" ");
        int n = int.Parse(nk[0]);
        int k = int.Parse(nk[1]);
        var list = new List<long>();
        for (int i = 0; i < n; i++) {
            var ab = Console.ReadLine().Split(" ");
            list.Add(int.Parse(ab[1]));
            list.Add(int.Parse(ab[0]) - int.Parse(ab[1]));
        }
        list.Sort();
        list.Reverse();
        Console.WriteLine(list.Take(k).Sum());
    }
}