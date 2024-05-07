public class Solution {
    public int solution(int[] arr) {
    if (arr.Length == 1)
        return arr[0];

    int answer = LCM(arr[0], arr[1]);

    if (arr.Length == 2)
        return answer;

    for (int i = 2; i < arr.Length; i++)
        answer = LCM(answer, arr[i]);

    return answer;
}

public int LCM(int a, int b)
{
    int n = a;
    int m = b;
    while (m > 0)
    {
        int temp = n % m;
        n = m;
        m = temp;
    }
    return a * b / n;
}
}