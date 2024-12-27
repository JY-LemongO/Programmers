using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        int[] days = new int[progresses.Length];
            for(int i = 0; i < progresses.Length; i++)
            {
                days[i] = (100 - progresses[i]) / speeds[i];
                if (progresses[i] + speeds[i] * days[i] < 100)
                    days[i]++;
            }

            Queue<int> dayQueue = new Queue<int>(days);
            List<int> answerList = new List<int>();            
            
            while(dayQueue.Count > 0)
            {
                int count = 0;
                int prev = dayQueue.Dequeue();
                count++;

                while (true)
                {
                    if (dayQueue.Count > 0 && prev >= dayQueue.Peek())
                    {
                        dayQueue.Dequeue();
                        count++;
                    }
                    else
                        break;
                }                    

                answerList.Add(count);                
            }            

            return answerList.ToArray();
    }
}