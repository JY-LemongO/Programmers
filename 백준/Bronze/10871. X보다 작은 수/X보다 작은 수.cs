using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program{
    static void Main(string[] args){
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

string[] nx = sr.ReadLine().Split(' ');
string[] nums = sr.ReadLine().Split(' ');

int.TryParse(nx[1], out int X);

StringBuilder sb = new();

for (int i = 0; i < nums.Length; i++)
{
    int.TryParse(nums[i], out int output);

    if (output < X)
    {
        sb.Append(output);
        sb.Append(" ");
    }
}
sb.Remove(sb.Length - 1, 1);
sw.WriteLine(sb.ToString());

sb.Clear();
sr.Close();
sw.Close();
    }
}