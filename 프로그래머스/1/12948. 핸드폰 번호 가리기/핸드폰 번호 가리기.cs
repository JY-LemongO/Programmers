public class Solution {
    public string solution(string phone_number) {
           char[] c = phone_number.ToCharArray();
            for(int i = 0; i<c.Length - 4; i++)
                c[i] = '*';
            string answer = new string(c);

            return answer;
    }
}