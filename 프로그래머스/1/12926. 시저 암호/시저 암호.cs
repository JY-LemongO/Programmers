using System;

public class Solution {
    public string solution(string s, int n) {
        string answer = "";

            int ascLowerMin = 65;            
            int ascLowerMax = 90;

            int ascUpperMin = 97;
            int ascUpperMax = 122;

            for (int i = 0; i < s.Length; i++)
            {
                int asc = s[i];
                if (asc < ascLowerMin || (asc > ascLowerMax && asc < ascUpperMin) || asc > ascUpperMax)
                    answer += s[i];
                else
                {
                    int convert = asc;
                    for (int j = 1; j < n + 1; j++)
                    {
                        convert += 1;
                        if (convert > ascLowerMax && asc < ascUpperMin)
                            convert = ascLowerMin;
                        else if (convert > ascUpperMax)
                            convert = ascUpperMin;
                    }
                    answer += Convert.ToChar(convert);                    
                }                    
            }
            return answer;
    }
}