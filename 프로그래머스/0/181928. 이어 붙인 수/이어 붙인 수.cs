using System;

public class Solution {
    public int solution(int[] num_list) {
        int a = 0;
int b = 0;

for (int i = 0; i < num_list.Length; i++)
{
    if (num_list[i] % 2 == 0)
        a = a > 0 ? a * 10 + num_list[i] : num_list[i];
    else
        b = b > 0 ? b * 10 + num_list[i] : num_list[i];
}

return a + b;
    }
}