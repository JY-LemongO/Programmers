using System;
using System.Text;

public class Solution {
    public string solution(string a, string b) {
        StringBuilder result = new StringBuilder();
int carry = 0;
int len1 = a.Length;
int len2 = b.Length;
int maxLength = Math.Max(len1, len2);

for (int i = 0; i < maxLength; i++)
{
    int digit1 = i < len1 ? a[len1 - 1 - i] - '0' : 0;
    int digit2 = i < len2 ? b[len2 - 1 - i] - '0' : 0;

    int sum = digit1 + digit2 + carry;
    carry = sum / 10;
    result.Insert(0, sum % 10);
}

if (carry > 0)
{
    result.Insert(0, carry);
}

return result.ToString();
    }
}