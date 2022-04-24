using System.Collections.Generic;
using System.Linq;
using System;

class Program {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        var orderedA = Console.ReadLine().Split(" ").Select(int.Parse).OrderBy(x => x).ToArray();
        var orderedB = Console.ReadLine().Split(" ").Select(int.Parse).OrderBy(x => x).ToArray();

        long result = 0;
        for (int i = 0; i < n; i++) { 
            result += Math.Abs(orderedA[i] - orderedB[i]);
        }

        Console.WriteLine(result);
    }
}