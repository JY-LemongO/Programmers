using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer;            
            List<int> list = new List<int>(arr);
            Array.Sort(arr);
            int index = 0;
            for(int i = 0; i < list.Count; i++)
                if (arr[0] == list[i])
                    index = i;
            list.RemoveAt(index);
            answer = list.ToArray();            
            if (arr.Length == 1)
                return new int[] { -1 };
            return answer;
    }
}