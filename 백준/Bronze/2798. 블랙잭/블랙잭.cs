using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var sr = new System.IO.StreamReader(new System.IO.BufferedStream(Console.OpenStandardInput()));
        var sw = new System.IO.StreamWriter(new System.IO.BufferedStream(Console.OpenStandardOutput()));

        int[] nm = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = nm[0], m = nm[1];
        int[] cards = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int best = 0;

        for (int i = 0; i < cards.Length - 2; i++)
        {
            for (int j = i + 1; j < cards.Length - 1; j++)
            {
                for (int k = j + 1; k < cards.Length; k++)
                {
                    int sum = cards[k] + cards[j] + cards[i];
                    if (sum <= m && best < sum)
                        best = sum;
                }
            }
        }

        sw.WriteLine(best);
        sw.Flush();
        sr.Close();
        sw.Close();
    }
}
