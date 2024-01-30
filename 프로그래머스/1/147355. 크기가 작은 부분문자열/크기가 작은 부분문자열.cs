using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;                   
            string n = "";
            for (int i = 0; i < p.Length; i++)
            {
                char[] c = t.ToCharArray();
                n += c[i];
                if (i == p.Length - 1)
                {
                    i = -1;
                    t = t.Substring(1);                    
                    long a = long.Parse(n);
                    long b = long.Parse(p);
                    if (a <= b)
                        answer++;
                    n = "";

                    if (t.Length <= 18 && p.Length > t.Length)
                        break;
                }
            }
            return answer;
    }
}