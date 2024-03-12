using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        if (m == 1)
                return section.Length;

            if (section.Length == 1)
                return 1;

            int answer = 1; // 한 번은 칠하기
            int paintCount = section.Length; // 칠해야 하는 단위 공간 개수
            int startIndex = section[0]; // 처음에 칠해야 하는 곳

            for (int i = 0; i < paintCount; i++)
            {
                if (section[i] <= startIndex - 1 + m) // 처음에 칠해야 하는 곳 부터 롤러가 닿는 곳 까지 section[i]가 작거나 같으면 한 번에 칠할 수 있으니 continue
                    continue;

                startIndex = section[i];
                answer++;
            }

            

            return answer;
    }
}