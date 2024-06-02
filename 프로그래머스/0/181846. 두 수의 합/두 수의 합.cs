using System;
using System.Text;

public class Solution {
    public string solution(string a, string b)
        {
            string answer = string.Empty;
        int count = a.Length >= b.Length ? a.Length : b.Length;
        int leftIndex = a.Length - 1, rightIndex = b.Length - 1, 
        leftValue = 0, rightValue = 0, result = 0, addNumber = 0;
        bool isComplete = false;
        while(isComplete == false)
        {
            if (leftIndex == -1 && rightIndex == -1 && addNumber == 0)
            {
                isComplete = true;
            }
            else
            {
                leftValue = leftIndex < 0 ? 0 : (int)char.GetNumericValue(a[leftIndex]);
                rightValue = rightIndex < 0 ? 0 : (int)char.GetNumericValue(b[rightIndex]);
                leftIndex = leftIndex-- <= 0 ? -1 : leftIndex--;
                rightIndex = rightIndex-- <= 0 ? -1 : rightIndex--;
                result = leftValue + rightValue + addNumber;

                if (result >= 10)
                {
                    addNumber = 1;
                    result = result - 10;
                }
                else
                {
                    addNumber = 0;
                }
                answer += result.ToString();
            }


        }      

        char[] charArray = answer.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);        
        }
}