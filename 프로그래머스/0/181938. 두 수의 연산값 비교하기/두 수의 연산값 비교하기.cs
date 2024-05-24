using System;
using System.Text;

public class Solution {
    public int solution(int a, int b) {
        int answer;
StringBuilder sb = new StringBuilder();
sb.Append(a.ToString());
sb.Append(b.ToString());
string st = sb.ToString();
int ab = int.Parse(st);
answer = ab > 2 * a * b ? ab : 2 * a * b;

return answer;
    }
}