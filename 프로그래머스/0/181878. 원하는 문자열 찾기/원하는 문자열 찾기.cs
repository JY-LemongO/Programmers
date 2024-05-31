using System;

public class Solution {
    public int solution(string myString, string pat)
        {
            string newStr = myString.ToUpper();            

            return newStr.Contains(pat.ToUpper()) ? 1 : 0;
        }
}