using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static void Main(string[] args){
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

string[] words = sr.ReadLine().Split(' ');

int count = 0;

if (words[0] == "")
    count++;
if (words[words.Length - 1] == "")
    count++;

sw.WriteLine($"{words.Length - count}");

sr.Close();
sw.Close();
    }
}