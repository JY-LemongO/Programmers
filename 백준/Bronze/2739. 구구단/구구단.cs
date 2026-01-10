using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static void Main(string[] args){
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

string format = "{0} * {1} = {2}";
int.TryParse(sr.ReadLine(), out int output);

object[] foramtArgs = new object[3];

for (int i = 1; i < 10; i++)
{
    foramtArgs[0] = output;
    foramtArgs[1] = i;
    foramtArgs[2] = output * i;

    string googoo = string.Format(format, foramtArgs);
    sw.WriteLine(googoo);
}

sr.Close();
sw.Close();
    }
}