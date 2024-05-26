using System;

public class Solution {
    public int solution(int[] numbers)
        {
           int maxLen = numbers.Length-1;
        Array.Sort(numbers);
        return (int)MathF.Max(numbers[0]*numbers[1], numbers[maxLen]*numbers[maxLen-1]);
        }
}