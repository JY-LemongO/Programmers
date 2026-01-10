using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static void Main(string[] args){
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int.TryParse(sr.ReadLine(), out int output);

for (int i = 1; i < 10; i++)
{
    string googoo = $"{output} * {i} = {output * i}";
    
    sw.WriteLine(googoo);
}

sr.Close();
sw.Close();
    }
}