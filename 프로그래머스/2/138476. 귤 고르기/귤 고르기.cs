using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int[] tangerine)
{
    int answer = 0;

    Array.Sort(tangerine);

    int latestSize = tangerine[0];
    int sizeCount = 0;

    List<int> sizeCounts = new List<int>();

    for (int i = 0; i < tangerine.Length; i++)
    {                
        if (tangerine[i] != latestSize)
        {
            sizeCounts.Add(sizeCount);
            sizeCount = 0;
            latestSize = tangerine[i];
        }
        sizeCount++;
    }
    sizeCounts.Add(sizeCount);
    sizeCounts.Sort();            

    for(int i = sizeCounts.Count - 1; i >= 0; i--)
    {
        answer++;
        k -= sizeCounts[i];
        if (k <= 0)
            break;
    }

    return answer;
}
}