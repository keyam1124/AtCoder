using System.Collections.Generic;
using System.Linq;
using System;

class Program {
    public static void Main(string[] args) {
        var n = int.Parse(Console.ReadLine());
        var signupedSet = new HashSet<string>();
        for (int i = 1; i <= n; i++) {
            string name = Console.ReadLine();
            bool canSignup = signupedSet.Add(name);
            if (canSignup) {
                Console.WriteLine(i);
            }
        }

    }
}