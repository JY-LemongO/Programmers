using System;

public class Solution {
    public int solution(string binomial)
        {
            int answer = 0;
        string[] s = binomial.Split(' ');

        if(s[1] == "+"){
            answer = int.Parse(s[0]) + int.Parse(s[2]);
        }
         if(s[1] == "-"){
            answer = int.Parse(s[0]) - int.Parse(s[2]);
        }
         if(s[1] == "*"){
            answer = int.Parse(s[0]) * int.Parse(s[2]);
        }


        return answer;
        }
}