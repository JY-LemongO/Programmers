public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
            foreach (int x in arr)
                answer += x;        
            return answer / arr.Length;
    }
}