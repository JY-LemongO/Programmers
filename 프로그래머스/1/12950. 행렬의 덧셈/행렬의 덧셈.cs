using System;
public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int sqrtY = arr1.GetLength(0);
            int sqrtX = arr1.GetLength(1);
            int[,] answer = new int[sqrtY, sqrtX];
            for (int y = 0; y < sqrtY; y++)
                for (int x = 0; x < sqrtX; x++)
                    answer[y, x] = arr1[y, x] + arr2[y, x];
            return answer;
    }
}