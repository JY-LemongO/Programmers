using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
            int devide = n;
        int count = 0;
        while(n > 0)
        {
            n /= 10;
            count++;
        }
            for (int i = 0; i < count; i++)
            {
                int remain = devide % 10;
                answer += remain;
                devide /= 10;
            }
            return answer;
    }
}
