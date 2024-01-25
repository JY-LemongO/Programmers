using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s) {
        char[] c = s.ToCharArray();
            for(int i = 0; i < c.Length - 1; i++)
            {
                for(int j = i+1; j < c.Length; j++)
                {
                    if((int)c[i] < (int)c[j])
                    {
                        char temp = c[i];
                        c[i] = c[j];
                        c[j] = temp;
                    }                    
                }
            }

            return new string(c);
    }
}