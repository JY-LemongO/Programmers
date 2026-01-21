using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static void Main(string[] args){
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int.TryParse(sr.ReadLine(), out int count);

string[] numStr = sr.ReadLine().Split(' ');

int min = int.MaxValue;
int max = int.MinValue;

for (int i = 0; i < count; i++)
{
    int num = int.Parse(numStr[i]);
    
    if(num < min) min = num;
    if(num > max) max = num;
}            

sw.WriteLine($"{min} {max}");

sr.Close();
sw.Close();
    }
}