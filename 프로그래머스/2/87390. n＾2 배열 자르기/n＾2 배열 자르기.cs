using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, long left, long right)
        {            
            List<int> list = new List<int>();

            // 인덱스를 찾는다.
            // 해당 인덱스에 들어갈 숫자를 찾는다.
            for(long i = left; i <= right; i++)
            {
                int value;
                if ((i + 1) % n == 0)
                    value = n;
                else
                    value = (int)((i + 1) / n + 1 > (i + 1) % n ? (i + 1) / n + 1 : (i + 1) % n);
                list.Add(value);                
            }

            return list.ToArray();
        }
}