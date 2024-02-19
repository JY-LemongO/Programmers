using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
            int boxCount = score.Length / m;
            List<int> list = new List<int>(score);
            list.Sort();            
            int pack = 0;
            int index = 1;            
            int[] box = new int[m];
            while (true)
            {
                if (pack == boxCount)
                    break;

                box[index - 1] = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                if (index % m == 0)
                {
                    answer += box[box.Length - 1] * m;
                    index = 1;
                    pack++;
                    continue;
                }
                index++;                
            }

            return answer;
    }
}