using System;

public class Solution {
    public int[] solution(int n, int k) {
        int[] answer = new int[n / k];

for (int i = 1; i <= answer.Length; i++)
    answer[i - 1] = i * k;

return answer;
    }
}