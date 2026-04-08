using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var sr = new System.IO.StreamReader(new System.IO.BufferedStream(Console.OpenStandardInput()));
        var sw = new System.IO.StreamWriter(new System.IO.BufferedStream(Console.OpenStandardOutput()));

        while (true)
        {
            int[] input = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(input);

            int a = input[0], b = input[1], c = input[2];
            if (a == 0 && b == 0 && c == 0) break;

            if (c * c == b * b + a * a)
                sw.WriteLine("right");
            else
                sw.WriteLine("wrong");
        }

        sw.Flush();
        sr.Close();
        sw.Close();
    }
}
