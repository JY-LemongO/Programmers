using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static void Main(string[] args){
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

string[] numStrs = sr.ReadLine().Split(' ');            

int startNum = int.Parse(numStrs[0]);
if (startNum != 1 && startNum != 8)
{
    sw.WriteLine("mixed");
    sw.Flush();

    sr.Close();
    sw.Close();
    return;
}

int nextCalc = startNum == 8 ? -1 : startNum == 1 ? 1 : 0;

for (int i = 0; i < numStrs.Length - 1; i++)
{
    int num = int.Parse(numStrs[i]);
    int nextNum = int.Parse(numStrs[i + 1]);

    if ((num + nextCalc) != nextNum)
    {
        sw.WriteLine("mixed");
        sw.Flush();

        sr.Close();
        sw.Close();
        return;
    }
}

if(startNum == 1)
    sw.WriteLine("ascending");
else
    sw.WriteLine("descending");

sw.Flush();

sr.Close();
sw.Close();
    }
}