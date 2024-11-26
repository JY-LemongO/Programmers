using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";

int bestest = int.MinValue;
int worstest = int.MaxValue;
int multiplier = 1;

int currentNum = 0;

for (int i = 0; i < s.Length; i++)
{
    if (s[i] == '-')
    {
        multiplier = -1;
        continue;
    }
    else
    {
        if(s[i] == ' ' || i == s.Length - 1)
        {
            if(i == s.Length - 1)
    currentNum = currentNum * 10 + (s[i] - 48);
            
            currentNum *= multiplier;
            if (currentNum >= bestest)
                bestest = currentNum;
            if (currentNum <= worstest)
                worstest = currentNum;                        
        }
        else
        {
            currentNum = currentNum * 10 + (s[i] - 48);
            continue;
        }                    
    }

    multiplier = 1;
    currentNum = 0;
}

return answer = $"{worstest} {bestest}";          
        
        
        
        
//         string answer = "";
//             bool minus = false;            
//             int sum = 0;
//             List<int> list = new List<int>();
//             for (int i = 0; i < s.Length; i++)
//             {
//                 if (s[i] == '-')
//                 {
//                     minus = true;
//                     continue;
//                 }                   
                                   
//                 if (char.IsDigit(s[i]))
//                 {
//                     if (sum != 0)
//                         sum *= 10;
//                     sum += (s[i] - 48);
//                 }          

//                 if (s[i] == ' ' || i == s.Length - 1)
//                 {
//                     int multi = minus ? -1 : 1;
//                     list.Add(sum * multi);
//                     minus = false;
//                     sum = 0;
//                 }
//             }
//             list.Sort();
//             answer = $"{list[0]} {list[list.Count - 1]}";

//             return answer;
    }
}