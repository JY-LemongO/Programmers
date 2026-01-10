using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static void Main(string[] args){
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int.TryParse(sr.ReadLine(), out int output);

if (output > 89)
    sw.WriteLine("A");
else if (output > 79)
    sw.WriteLine("B");
else if (output > 69)
    sw.WriteLine("C");
else if (output > 59)
    sw.WriteLine("D");
else
    sw.WriteLine("F");

sr.Close();
sw.Close();
    }
}