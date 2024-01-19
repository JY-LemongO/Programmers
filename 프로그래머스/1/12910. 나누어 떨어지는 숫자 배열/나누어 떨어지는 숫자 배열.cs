using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int count = 0;            
            int[] answer;
            List<int> list = new List<int>();

            for(int i = 0; i < arr.Length; i++)
                if (arr[i] % divisor == 0)
                {
                    list.Add(arr[i]);
                    count++;
                }                    

            if (count == 0)
            {
                answer = new int[1] { -1 };
                return answer;
            }

            answer = new int[count];
            
            for(int i = 0; i < count; i++)
                answer[i] = list[i];
            Array.Sort(answer);            

            return answer;
    }
}