using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static void Main(string[] args){
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

// Center 기준::Start Down 1번 이동 -> LD = n - 1 번 이동 -> LU, RU, RD, LastDown = n 번 이동 -> 반복
// 한 바퀴 시작 할 때 마다 지나야 하는 방의 수 증가

int num = int.Parse(sr.ReadLine());
int current = 1;
int jump = 1;

if (current == num)
{
    sw.WriteLine(jump);
    sw.Flush();

    sr.Close();
    sw.Close();
    return;
}                

bool Step(int stepCount)
{
    for(int i = 0; i < stepCount; i++)
    {
        current++;
        if (current == num)
            return true;
    }
    return false;
}            

while (true)
{                
    //Start Down
    jump++;
    current++;

    if (current == num)
        break;

    //LD
    if (Step(jump - 2))
        break;
    //LU
    if (Step(jump - 1))
        break;
    //U
    if (Step(jump - 1))
        break;
    //RU
    if (Step(jump - 1))
        break;
    //RD
    if (Step(jump - 1))
        break;
    //LastDown
    if (Step(jump - 1))
        break;

    if (current == 1000000000)
        break;
}

sw.WriteLine(jump);

sw.Flush();

sr.Close();
sw.Close();
    }
}