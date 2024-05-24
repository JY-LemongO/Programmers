using System;
using System.Text;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;

        int c = 2 * a * b;

        int ab = int.Parse(a.ToString() + b.ToString());

        return ab > c ? ab : c;
    }
}