using System;

public class Solution {
    public int solution(string number)
        {
            int answer = 0;

            foreach(char c in number)
                answer += c - '0';

            return answer %= 9;
        }
}