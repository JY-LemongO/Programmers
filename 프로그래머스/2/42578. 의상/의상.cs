using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes)
            {
                int answer = 1;

                Dictionary<string, int> dict = new Dictionary<string, int>();

                for(int i = 0; i < clothes.GetLength(0); i++)
                {
                    if (dict.ContainsKey(clothes[i, 1]))
                        dict[clothes[i, 1]]++;
                    else
                        dict.Add(clothes[i, 1], 1);
                }

                foreach(int i in dict.Values)
                    answer *= i + 1;

                return --answer;
            }
}