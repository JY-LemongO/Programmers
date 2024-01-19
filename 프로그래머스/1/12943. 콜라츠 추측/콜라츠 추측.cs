public class Solution {
    public int solution(int num) {
        double x = num;
            int count = 0;
            for (int i = 0; i < 500; i++)
            {
                if (x == 1)
                    return count;
                x = x % 2 == 0 ? x / 2 : x * 3 + 1;
                count++;
            }
            return -1;
    }
}