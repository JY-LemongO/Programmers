using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds)
        {
            int[] days = new int[progresses.Length];
            for(int i = 0; i < progresses.Length; i++)
            {
                days[i] = (100 - progresses[i]) / speeds[i];
                if (progresses[i] + speeds[i] * days[i] < 100)
                    days[i]++;
            }

            Queue<int> dayStack = new Queue<int>(days);
            List<int> answerList = new List<int>();
            
            int prev = 0;
            while(dayStack.Count > 0)
            {
                int count = 0;

                prev = dayStack.Dequeue();
                count++;

                while (true)
                {
                    if (dayStack.Count > 0 && prev >= dayStack.Peek())
                    {
                        dayStack.Dequeue();
                        count++;
                    }
                    else
                        break;
                }                    

                answerList.Add(count);
                count = 0;
            }            

            return answerList.ToArray();
        }
}