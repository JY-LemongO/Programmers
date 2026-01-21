using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static void Main(string[] args){
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int a = int.Parse(sr.ReadLine());
int b = int.Parse(sr.ReadLine());
int c = int.Parse(sr.ReadLine());

int multi = a * b * c;

string numStr = multi.ToString();

for (int i = 0; i < 10; i++)
{
    int count = 0;

    for (int j = 0; j < numStr.Length; j++)
    {                    
        char numChar = numStr[j];
        if (numChar == i + 48)
            count++;
    }

    sw.WriteLine(count);
}

sr.Close();
sw.Close();
    }
}