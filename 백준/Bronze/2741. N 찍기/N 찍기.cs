using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static void Main(string[] args){
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int.TryParse(sr.ReadLine(), out int output);

for (int i = 0; i < output; i++)
{                
    sw.WriteLine(i + 1);
}

sr.Close();
sw.Close();
    }
}