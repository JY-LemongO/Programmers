using System;

public class Solution {
    public int solution(int[] num_list) {
        int sqr = 0;
int multiple = 1;

foreach (int num in num_list)
    sqr += num;
sqr *= sqr;

foreach (int num in num_list)
    multiple *= num;

return sqr > multiple ? 1 : 0;
    }
}