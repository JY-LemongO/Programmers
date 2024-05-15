using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
List<char> chars = new List<char>(s);

for(int i = 0; i < s.Length; i++)
{
    answer += IsCorrect(chars) ? 1 : 0;
    chars.Add(chars[0]);
    chars.RemoveAt(0);
}

return answer;
    }
    
    private bool IsCorrect(List<char> chars)
{
    Stack<char> stack = new Stack<char>();
    string open = "({[";
    string close = ")}]";

    for(int i = 0; i < chars.Count; i++)
    {
        if (open.Contains(chars[i]))
            stack.Push(chars[i]);
        else
        {
            if (stack.Count == 0)
                return false;
            if (chars[i] != close[open.IndexOf(stack.Peek())])
                return false;
            stack.Pop();
        }
    }
    if(stack.Count != 0)
        return false;
    return true;
}
}