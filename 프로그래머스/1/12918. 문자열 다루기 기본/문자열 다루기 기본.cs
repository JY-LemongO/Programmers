public class Solution {
    public bool solution(string s) {
        int a;
            bool answer = int.TryParse(s, out a);
            if (a < 0 || s == "" || (s.Length != 4 && s.Length != 6))
                return false;
            return answer;
    }
}