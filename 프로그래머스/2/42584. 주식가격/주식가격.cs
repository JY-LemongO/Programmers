using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] prices)
        {
            int[] answer = new int[prices.Length];

            Queue<int> pricesQueue = new Queue<int>(prices);
            int index = 1;

            while(pricesQueue.Count > 0)
            {
                int checkPrice = pricesQueue.Dequeue();
                int sec = 0;

                for (int i = index; i < prices.Length; i++)
                {
                    sec++;
                    if (checkPrice > prices[i])
                        break;                    
                }
                answer[index - 1] = sec;

                index++;
            }

            return answer;
        }
}