using System;
using System.Text;

public class Solution {
    public string solution(string myString)
        {            
            for (int i = 0; i < myString.Length; i++)
                if (myString[i] < 'l')
                    myString = myString.Replace(myString[i], 'l');

            return myString;
        }
}