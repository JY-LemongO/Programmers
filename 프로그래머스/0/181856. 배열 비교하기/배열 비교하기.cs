using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return arr1.Length > arr2.Length ? 1 : -1;

            int a1 = 0;
            int a2 = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                a1 += arr1[i];
                a2 += arr2[i];
            }

            return a1 > a2 ? 1 : a1 == a2 ? 0 : -1;
        }
}