using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer = 0;            
foreach (int n in numbers)
    answer += n;

return answer / numbers.Length;
    }
}