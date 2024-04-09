using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";

            Dictionary<char, int> 유형별점수 = new Dictionary<char, int>();            

        유형별점수.Add('R', 0);
            유형별점수.Add('T', 0);
            유형별점수.Add('C', 0);
            유형별점수.Add('F', 0);
            유형별점수.Add('J', 0);
            유형별점수.Add('M', 0);
            유형별점수.Add('A', 0);
            유형별점수.Add('N', 0);
        
            for(int i = 0; i < survey.Length; i++)
            {
                if(choices[i] == 4)
                    continue;

                if(choices[i] < 4)
                {
                    char c = survey[i][0];
                    if (유형별점수.TryGetValue(c, out int value))
                        value += 4 - choices[i];

                    유형별점수[c] = value;
                }                    
                else                    
                {
                    char c = survey[i][1];
                    if(유형별점수.TryGetValue(c, out int value))
                    value += choices[i] - 4;

                    유형별점수[c] = value;
                }          
            }

            int one_left = 유형별점수.GetValueOrDefault('R');
            int one_right = 유형별점수.GetValueOrDefault('T');

            int two_left = 유형별점수.GetValueOrDefault('C');
            int two_right = 유형별점수.GetValueOrDefault('F');

            int three_left = 유형별점수.GetValueOrDefault('J');
            int three_right = 유형별점수.GetValueOrDefault('M');

            int four_left = 유형별점수.GetValueOrDefault('A');
            int four_right = 유형별점수.GetValueOrDefault('N');

            if (one_left == one_right)
                answer += 'R';
            else
                answer += one_left > one_right ? 'R' : 'T';

            if (two_left == two_right)
                answer += 'C';
            else
                answer += two_left > two_right ? 'C' : 'F';

            if (three_left == three_right)
                answer += 'J';
            else
                answer += three_left > three_right ? 'J' : 'M';

            if (four_left == four_right)
                answer += 'A';
            else
                answer += four_left > four_right ? 'A' : 'N';

            return answer;
    }
}