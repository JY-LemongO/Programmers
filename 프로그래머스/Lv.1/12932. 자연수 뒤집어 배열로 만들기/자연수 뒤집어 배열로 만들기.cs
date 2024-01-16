public class Solution {
    public int[] solution(long n) {
        string s = n.ToString();
            int[] answer = new int[s.Length];
        int index = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                answer[index] = int.Parse(s[i].ToString());
                index++;
            }           
            return answer;
    }
}