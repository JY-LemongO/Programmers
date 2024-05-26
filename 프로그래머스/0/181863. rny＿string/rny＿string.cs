using System;
using System.Text;

public class Solution {
    public string solution(string rny_string)
        {
            StringBuilder sb = new StringBuilder();

            foreach(char c in rny_string)
            {
                if (c == 'm')
                {
                    sb.Append("rn");
                    continue;
                }

                sb.Append(c);
            }

            return sb.ToString();
        }
}