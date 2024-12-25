using System;

public class Solution {
    public int solution(int[] numbers, int target) {
        return DFS(numbers, target, 0, 0);
    }
    private int DFS(int[] numbers, int target, int index, int currentSum)
{
    // 배열 끝에 도달했을 때 합계가 target과 같은지 확인
    if (index == numbers.Length)
    {
        return currentSum == target ? 1 : 0;
    }

    // 현재 숫자를 더하는 경우와 빼는 경우를 재귀적으로 호출
    return DFS(numbers, target, index + 1, currentSum + numbers[index]) +
           DFS(numbers, target, index + 1, currentSum - numbers[index]);
}
}