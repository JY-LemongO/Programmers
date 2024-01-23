public class Solution {
    public string solution(string s) {
        string answer;
            int mid = s.Length % 2;
            char[] c;
            if(mid == 0)
            {
                c = new char[2];
                for (int i = 0; i < 2; i++)
                    c[i] = s[s.Length / 2 + i - 1];
            }
            else
            {
                c = new char[1];
                c[0] = s[s.Length / 2];
            }
            answer = new string(c);
                
            return answer;
    }
}