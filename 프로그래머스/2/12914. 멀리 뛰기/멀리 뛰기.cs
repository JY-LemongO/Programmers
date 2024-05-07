public class Solution {
    public long solution(int n) {
        int[] cases = new int[2000];

cases[0] = 1;
cases[1] = 2;            

for(int i = 2; i < n; i++)
    cases[i] = (cases[i - 2] + cases[i - 1]) % 1234567;

return cases[n - 1];
    }
}