using System;

public class Solution {
    public string[] solution(string[] strArr)
        {
            string[] answer = new string[strArr.Length];
            for(int i = 0; i < strArr.Length; i++)
                answer[i] = i % 2 == 0 ? strArr[i].ToLower() : strArr[i].ToUpper();

            return answer;
        }
}