using System.Collections.Generic;
using System.Linq;
using System;

class Program {
    public static void Main(string[] args) {
        var abc = Console.ReadLine().Split(" ");
        long a = long.Parse(abc[0]);
        int b = int.Parse(abc[1]);
        int c = int.Parse(abc[2]);

        // a < c^bをチェックする
        long bc = 1;
        for (int i = 0; i < b; i++) {
            bc = bc * c;
        }
        if (a < bc) {
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }
    }
}   