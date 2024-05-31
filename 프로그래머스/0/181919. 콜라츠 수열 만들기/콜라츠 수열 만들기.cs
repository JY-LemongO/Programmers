using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n)
        {
            List<int> list = new List<int>() { n };

            while (n != 1)
            {
                if (n % 2 == 0)
                    n /= 2;
                else
                    n = n * 3 + 1;

                list.Add(n);
            }

            return list.ToArray();
        }
}