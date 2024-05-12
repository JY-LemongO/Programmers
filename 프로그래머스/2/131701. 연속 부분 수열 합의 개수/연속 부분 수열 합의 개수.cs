using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] elements) {
        int answer = 0;

        int[] flagedInts = new int[elements.Length * 1000 + 1];


        for(int addingLen = 1; addingLen <= elements.Length; ++addingLen)
        {
            for (int idxStart = 0; idxStart < elements.Length; ++idxStart)
            {
                int idx = 0;
                for (int idxAdding = 0; idxAdding < addingLen; ++idxAdding)
                {
                    idx += elements[(idxStart + idxAdding) % (elements.Length)];
                }
                if (flagedInts[idx] == 0)
                {
                    flagedInts[idx] = 1;
                    ++answer;
                }
            }
        }

        return answer;
    }
}