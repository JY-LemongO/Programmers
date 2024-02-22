using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        int[] pattern1 = { 1, 2, 3, 4, 5 };
        int[] pattern2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] pattern3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        // 각 수포자의 점수
        Dictionary<int, int> scores = new Dictionary<int, int>
        {
            { 1, 0 },
            { 2, 0 },
            { 3, 0 }
        };

        // 정답 확인 및 점수 계산
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == pattern1[i % pattern1.Length])
                scores[1]++;

            if (answers[i] == pattern2[i % pattern2.Length])
                scores[2]++;

            if (answers[i] == pattern3[i % pattern3.Length])
                scores[3]++;
        }

        // 가장 높은 점수를 받은 수포자(들) 찾기
        int maxScore = scores.Max(pair => pair.Value);
        int[] result = scores.Where(pair => pair.Value == maxScore).Select(pair => pair.Key).ToArray();

        return result;
    }
}