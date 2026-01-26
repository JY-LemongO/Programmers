using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static void Main(string[] args){
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(sr.ReadLine());
int lowestNum = 0;

// n - 1 부터 시작 역순으로 내려가기
for (int startNum = n - 1; startNum >= 1; startNum--)
{
    // 현재 숫자가 몇 자리의 수 인지 
    int divideCount = 1;
    int divide = 10;

    while (true)
    {
        if (startNum / divide == 0)
            break;

        divide *= 10;
        divideCount++;
    }

    // 현재 숫자 분해
    int[] eachNumArry = new int[divideCount];
    int remain = startNum;

    for (int i = divideCount; i > 0; i--)
    {
        int pow = (int)Math.Pow(10, --divideCount);

        eachNumArry[i - 1] = remain / pow;
        remain = remain % pow;
    }

    // 이번 분기의 분해합
    int decomSum = 0;
    for (int i = 0; i < eachNumArry.Length; i++)
    {
        decomSum += eachNumArry[i];
    }
    decomSum += startNum;

    // 
    if (decomSum == n)
        lowestNum = startNum;
}

sw.WriteLine(lowestNum);

sw.Flush();

sr.Close();
sw.Close();
    }
}