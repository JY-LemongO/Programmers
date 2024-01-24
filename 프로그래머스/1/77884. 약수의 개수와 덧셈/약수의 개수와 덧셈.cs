using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        for(int i = left; i < right + 1; i++)
            {
                int x = 0;
                for (int j = 1; j < i + 1; j++)
                {
                    if (i % j == 0)
                        x++;
                }
                answer += x % 2 == 0 ? i : -i;                    
            }
        return answer;
    }
}