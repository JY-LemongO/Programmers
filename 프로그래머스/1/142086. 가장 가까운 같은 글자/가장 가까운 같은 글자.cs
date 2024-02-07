using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
            string cl = "";           

            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (!cl.Contains(c))
                {
                    answer[i] = -1;
                    continue;
                }
            }
            for(int i = 0; i < s.Length - 1; i++)
            {
                char c = s[i];
                int count = 0;

                for(int j = i + 1; j < s.Length; j++)
                {
                    count++;
                    char cn = s[j];
                    if (c == cn)
                        answer[j] = count;
                }
            }
            return answer;
    }
}