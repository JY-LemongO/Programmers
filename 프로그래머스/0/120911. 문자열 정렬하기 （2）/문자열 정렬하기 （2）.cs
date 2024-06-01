using System;
using System.Text;

public class Solution {
    public string solution(string my_string)
        {
            StringBuilder sb = new StringBuilder(my_string.ToLower());
            
            for(int i = 0; i < sb.Length - 1; i++)
            {
                int index = i;
                for(int j = i + 1; j < sb.Length; j++)
                {
                    if (sb[index] > sb[j])
                        index = j;
                }

                char temp = sb[i];
                sb[i] = sb[index];
                sb[index] = temp;
            }

            return sb.ToString();
        }
}