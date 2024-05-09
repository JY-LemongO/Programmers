using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        Dictionary<int, int> size = new Dictionary<int, int>();
        foreach(int t in tangerine)
        {
            if(!size.TryAdd(t, 1))
            {
                size[t]+=1;
            }
        }
        List<int> count = new List<int>(size.Values);
        count.Sort();
        int kCount = 0;
        int kIndex = count.Count-1;
        while(k>kCount)
        {
            kCount+=count[kIndex--];
            answer++;
        }
        return answer;
    }
}