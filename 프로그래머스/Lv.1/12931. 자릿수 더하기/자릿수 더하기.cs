using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
            int devide = n;
            for (int i = 0; i < n; i++)
            {
                int remain = devide % 10;
                answer += remain;
                devide /= 10;
            }
            return answer;
    }
}