using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];

int convert = 0;
int remove = 0;
int length = s.Length;            

while (s != "1")
{
    foreach (char c in s)
    {
        if (c == '0')
        {
            remove++;
            length--;
        }
    }

    s = Convert.ToString(length, 2);
    convert++;
    length = s.Length;
}

answer[0] = convert;
answer[1] = remove;

return answer;
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
//        int[] answer = new int[2];

//             string result = "";

//             while(s != "1")
//             {
//                 foreach (char c in s)
//                 {
//                     if (c == '0')
//                         answer[1]++;
//                     else
//                         result += c;
//                 }

//                 int nums = result.Length;
//                 s = Convert.ToString(nums, 2);
//                 answer[0]++;
//                 result = "";
//             }            

//             return answer;
    }
}