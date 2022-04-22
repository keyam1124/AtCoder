using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var a = Console.ReadLine().Split(" ");
        // 昇順にソート
        var orderedA = a.Select(int.Parse).OrderBy(x => x).ToList();
        int q = int.Parse(Console.ReadLine());
        for (int i = 0; i < q; i++)
        {
            int bItem = int.Parse(Console.ReadLine());
            int index = LowerBound(orderedA, bItem, Comparer<int>.Default);
            if (index >= orderedA.Count)
            {
                index = orderedA.Count - 1;
                Console.WriteLine(Math.Abs(bItem - orderedA[index]));
            }
            else if (index == 0)
            {
                Console.WriteLine(Math.Abs(bItem - orderedA[index]));
            }
            else
            {
                int temp1 = Math.Abs(bItem - orderedA[index]);
                int temp2 = Math.Abs(bItem - orderedA[index - 1]);
                Console.WriteLine(temp1 > temp2 ? temp2 : temp1);
            }
        }
    }
    public static int LowerBound<T>(List<T> a, T v, Comparer<T> cmp)
    {
        var l = 0;
        var r = a.Count - 1;
        while (l <= r)
        {
            var mid = l + (r - l) / 2;
            var res = cmp.Compare(a[mid], v);
            if (res == -1) l = mid + 1;
            else r = mid - 1;
        }
        return l;
    }
}