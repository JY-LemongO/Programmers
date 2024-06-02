using System;
using System.Text;

public class Solution {
    public string[] solution(string my_string)
        {
            StringBuilder sb = new StringBuilder(my_string);
            string[] strArr = new string[my_string.Length];

            for(int i = 0; i < my_string.Length; i++)
            {
                strArr[i] = sb.ToString();
                sb.Remove(0, 1);                
            }

            Array.Sort(strArr);

            return strArr;
        }
}