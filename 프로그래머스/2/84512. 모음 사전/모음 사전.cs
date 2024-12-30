using System;
using System.Text;

public class Solution {
    public int solution(string word) 
        {            
            StringBuilder sb = new StringBuilder();            
            int answer = 0;

            while (true)
            {
                // 현재 단어가 5자리일 때
                if(sb.Length == 5)
                {
                    char append = LastWordConvert(sb);
                    sb.Append(append);
                }
                // 현재 단어가 5자리 미만이면
                else
                {
                    sb.Append('A');                    
                }
                answer++;

                if (sb.ToString() == word)
                    break;
            }

            return answer;
        }
    public char LastWordConvert(StringBuilder sb)
{            
    char lastWord = sb[sb.Length - 1];
    sb.Remove(sb.Length - 1, 1);
    if (lastWord == 'U')
        return LastWordConvert(sb);
    
    switch (lastWord)
    {
        case 'A':
            lastWord = 'E';
            break;
        case 'E':
            lastWord = 'I';
            break;
        case 'I':
            lastWord = 'O';
            break;
        case 'O':
            lastWord = 'U';
            break;
    }

    return lastWord;
}
}