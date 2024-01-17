public class Solution {
    public bool solution(int x) {
        bool answer;
        int devideNum = 0;
            int origin = x;                        
            for (int i = 0; i < x; i = 0)
            {
                devideNum += x % 10;                
                x /= 10;
            }
            answer = origin % devideNum == 0;

            return answer;
    }
}