using System;
using System.Text;

public class Solution {
    public int solution(string myString, string pat)
        {
            StringBuilder sb = new StringBuilder();

            foreach(char c in myString)
            {
                if (c == 'A')
                    sb.Append('B');
                else
                    sb.Append('A');
            }

            return sb.ToString().Contains(pat) ? 1 : 0;            
        }
}