using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
            char[] c = s.ToCharArray();
            int index = 0;
            for(int i = 0; i < c.Length; i++)
            {                    
                if (index % 2 == 0 && c[i] != ' ')
                    answer += c[i].ToString().ToUpper();
                if (index % 2 != 0 || c[i] == ' ')
                    answer += c[i].ToString().ToLower();                
                index++;
                if (c[i] == ' ')
                    index = 0;
            }
            return answer;
    }
}