using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list)
        {
            List<int> intList = new List<int>(arr);
            foreach (int i in delete_list)
            {
                if(intList.Contains(i))
                    intList.Remove(i);
            }

            return intList.ToArray();
        }
}