using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(" ");
        int h = int.Parse(input[0]);
        int w = int.Parse(input[1]);

        var table = new List<List<int>>();
        for (int i = 0; i < h; i++)
        {
            var input2 = Console.ReadLine().Split(" ");
            table.Add(input2.Select(int.Parse).ToList());
        }

        var rowSumList = Enumerable.Repeat(0, h).ToList();
        var colSumList = Enumerable.Repeat(0, w).ToList();
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                var item = table[i][j];
                rowSumList[i] += item;
                colSumList[j] += item;
            }
        }


        var ansRow = new List<int>();
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                var item = table[i][j];
                ansRow.Add(rowSumList[i] + colSumList[j] - item);
            }

            Console.WriteLine(string.Join(' ', ansRow));
            ansRow.Clear();
        }
    }
}