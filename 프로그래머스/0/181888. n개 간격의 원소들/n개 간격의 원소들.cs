using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        List<int> list = new List<int>();

for (int i = 0; i < num_list.Length; i++)
    if (i % n == 0)
        list.Add(num_list[i]);

return list.ToArray();
    }
}