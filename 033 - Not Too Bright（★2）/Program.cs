using System.Collections.Generic;
using System.Linq;
using System;

class Program {
    public static void Main(string[] args) {
        var hw = Console.ReadLine().Split(" ");
        int h = int.Parse(hw[0]);
        int w = int.Parse(hw[1]);

        if (h == 1 || w == 1) {
            Console.WriteLine(h * w);
        } else {
            decimal temp1 = Math.Ceiling(h / 2.0M);
            decimal temp2 = Math.Ceiling(w / 2.0M);

            Console.WriteLine(temp1 * temp2);
        }

    }
}