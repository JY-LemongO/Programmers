using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static void Main(string[] args){
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int index = 0;
int maxNum = 0;

for (int i = 0; i < 9; i++)
{                
    int.TryParse(sr.ReadLine(), out int curNum);
    if (curNum > maxNum)
    {
        index = i + 1;
        maxNum = curNum;
    }                    
}

sw.WriteLine(maxNum);
sw.WriteLine(index);

sr.Close();
sw.Close();
    }
}