using System;

public class Solution {
    public int solution(string number)
        {
            int answer = 0;

            foreach(char c in number)
                answer += c - '0';

            answer %= 9;

            return answer;
        }
}