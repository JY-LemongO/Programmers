public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int max = GCD(n,m);
        int min = (n * m) / GCD(n, m);
        answer[0] = max;
        answer[1] = min;
        return answer;
    }
    
    int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}