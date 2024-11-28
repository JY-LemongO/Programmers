using System.Text;

public class Solution {
    public string solution(string s) {
         string answer = s.ToLower();
bool isUpperTurn = true;

StringBuilder sb = new StringBuilder();            

for (int i = 0; i < answer.Length; i++)
{
    if (answer[i] == ' ')
    {
        isUpperTurn = true;
        sb.Append(answer[i]);
        continue;
    }

    if ((answer[i] < 48 || answer[i] > 57) && isUpperTurn)
    {
        sb.Append(char.ToUpper(answer[i])); 
        isUpperTurn = false;
        continue;
    }

    sb.Append(answer[i]);
    isUpperTurn = false;
}

answer = sb.ToString();

return answer;
            
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
//         string answer = "";
//             int index = 0;
            
//             for(int i = 0; i < s.Length; i++)
//             {
//                 if (!char.IsDigit(s[i]))
//                 {
//                     string upper;
//                     string lower;
//                     if (index == 0)
//                     {
//                         upper = s.Substring(i, 1).ToUpper();
//                         answer += upper;
//                     }
//                     else
//                     {
//                         lower = s.Substring(i, 1).ToLower();
//                         answer += lower;
//                     }
//                 }
//                 else
//                     answer += s[i];
//                 index++;

//                 if (s[i] == ' ')
//                     index = 0;                
//             }

//             return answer;
    }
}