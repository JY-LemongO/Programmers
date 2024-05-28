using System;
using System.Text;

public class Solution {
    public string solution(string myString)
        {
            StringBuilder sb = new StringBuilder(myString);
            for (int i = 0; i < sb.Length; i++)
                if (sb[i] < 'l')
                    sb[i] = 'l';

            return sb.ToString();
        }
}