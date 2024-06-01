using System;
using System.Text;

public class Solution {
    public string solution(string my_string)
        {
            StringBuilder sb = new StringBuilder(my_string.ToLower());

            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (sb[i] > sb[i + 1])
                {
                    char c = sb[i];
                    sb[i] = sb[i + 1];
                    sb[i + 1] = c;
                    i = -1;
                }
            }

            return sb.ToString();
        }
}