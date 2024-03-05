using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];

            int correct = 0;
            int zero = 0;
            int rank;

            foreach (int lot in lottos)
            {
                foreach(int num in win_nums)
                {
                    if (lot == num)
                        correct++;
                }

                if (lot == 0)
                    zero++;
            }            
            if (correct >= 2)
                rank = 7 - correct;
            else
                rank = 6;
            answer[1] = rank;

            rank = correct + zero < 2 ? 6 : 7 - (correct + zero);
            answer[0] = rank;
            

            return answer;
    }
}