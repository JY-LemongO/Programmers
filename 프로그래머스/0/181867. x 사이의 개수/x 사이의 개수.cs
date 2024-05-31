using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string myString)
        {
            string[] ss = myString.Split('x');
        int[] answer = new int[ss.Length];
        for(int i=0;i<ss.Length;i++)
        {
            answer[i] = ss[i].Length;
        }
        return answer;
        }
}