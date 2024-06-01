using System;
using System.Text;

public class Solution {
    public string solution(string myString)
        {
            StringBuilder sb = new StringBuilder(myString.ToLower());

            for (int i = 0; i < sb.Length; i++)
                if (sb[i] == 'a')
                    sb[i] = 'A';

            return sb.ToString();
        }
}