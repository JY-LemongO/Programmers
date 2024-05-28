using System;
using System.Text;

public class Solution {
    public string solution(string myString)
        {
            int l = 'l';

        for(int j = 0; j < myString.Length; j++)
        {
            if (myString[j] < l)
            {
                myString = myString.Replace(myString[j], 'l');
            }
        }

        return myString;
        }
}