using System;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
            List<int> list = new List<int>();
            for (int i = 1; i < food.Length; i++)
            {
                if (food[i] % 2 != 0)
                    food[i]--;

                food[i] = food[i] / 2;

                for (int j = 0; j < food[i]; j++)
                    list.Add(i);
            } 
            
            answer += string.Join("", list);
            answer += "0";
            list.Reverse();
            answer += string.Join("", list);

            return answer;
    }
}