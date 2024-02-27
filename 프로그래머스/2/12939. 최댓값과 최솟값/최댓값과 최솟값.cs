using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";
            bool minus = false;            
            int sum = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '-')
                {
                    minus = true;
                    continue;
                }                   
                                   
                if (char.IsDigit(s[i]))
                {
                    if (sum != 0)
                        sum *= 10;
                    sum += (s[i] - 48);
                }          

                if (s[i] == ' ' || i == s.Length - 1)
                {
                    int multi = minus ? -1 : 1;
                    list.Add(sum * multi);
                    minus = false;
                    sum = 0;
                }
            }
            list.Sort();
            answer = $"{list[0]} {list[list.Count - 1]}";

            return answer;
    }
}