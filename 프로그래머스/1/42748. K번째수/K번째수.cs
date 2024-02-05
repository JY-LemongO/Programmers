using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
            List<int> list = new List<int>();
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    // commands i행 첫인자 - 1 보다 작으면 스킵
                    if (j < commands[i, 0] - 1)
                        continue;
                    // commands i행 두번째인자와 같거나 크면 스킵
                    if (j >= commands[i, 1])
                        continue;

                    list.Add(array[j]);
                }
                list.Sort();
                answer[i] = list[commands[i, 2] - 1];

                list.Clear();
            }

            return answer;
    }
}