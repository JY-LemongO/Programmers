using System;

public class Solution {
    public int solution(int[] numbers)
        {
            Array.Sort(numbers);

            if (numbers[0] * numbers[1] > numbers[numbers.Length - 1] * numbers[numbers.Length - 2])
                return numbers[0] * numbers[1];

            return numbers[numbers.Length - 1] * numbers[numbers.Length - 2];
        }
}