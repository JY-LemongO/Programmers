public class Solution {
    public bool solution(int x) {
        bool answer;
            int origin = x;
            int[] arry = new int[5];
            int index = 0;
            for (int i = 0; i < x; i = 0)
            {
                arry[index] = x % 10;
                index++;
                x /= 10;
            }
            int devideNum = 0;
            for(int i = 0; i < arry.Length; i++)
            {
                devideNum += arry[i];
            }
            answer = origin % devideNum == 0;

            return answer;
    }
}