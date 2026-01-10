using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static void Main(string[] args){
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int.TryParse(sr.ReadLine(), out int count);

for (int i = 0; i < count; i++)
{
    int current = 0;
    
    while(current < i + 1)
    {
        sw.Write("*");
        current++;
    }

    if (i != count - 1)
        sw.WriteLine();
}                        

sr.Close();
sw.Close();
    }
}