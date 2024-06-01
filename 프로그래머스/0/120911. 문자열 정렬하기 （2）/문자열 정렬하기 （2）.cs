using System;
using System.Text;

public class Solution {
    public string solution(string my_string)
        {
            string answer = "";
        char[] tt = my_string.ToLower().ToCharArray();
        for (int i = 0; i < tt.Length - 1; i++) 
        {
            if (tt[i] > tt[i+1])
            {
                char c = tt[i];
                tt[i] = tt[i + 1];
                tt[i + 1] = c;
                i = -1;
            }
        }
        answer = new string(tt);
        return answer;
        }
}