using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer;

int a = 0;
int b = 0;

for (int i = 0; i < num_list.Length; i++)
{
    if (i % 2 == 0)
        a += num_list[i];
    else
        b += num_list[i];
}

answer = a < b ? b : a;

return answer;
    }
}