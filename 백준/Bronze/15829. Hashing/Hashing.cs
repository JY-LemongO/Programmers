using System;

class Program
{
    static void Main()
    {
        var sr = new System.IO.StreamReader(new System.IO.BufferedStream(Console.OpenStandardInput()));
        var sw = new System.IO.StreamWriter(new System.IO.BufferedStream(Console.OpenStandardOutput()));

        int L = int.Parse(sr.ReadLine());
        string s = sr.ReadLine();
        long M = 1234567891;
        long r = 31;

        long answer = 0;
        long rPow = 1;

        for (int i = 0; i < L; i++)
        {
            int num = s[i] - 'a' + 1;

            answer += (num * rPow);
            answer %= M;

            rPow *= r;
            rPow %= M;
        }

        sw.WriteLine(answer);

        sw.Close();
        sr.Close();
    }
}
