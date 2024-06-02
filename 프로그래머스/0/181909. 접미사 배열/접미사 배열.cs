
using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string[] solution(string my_string) {
        var answer = new List<string>();
        string str = "";
        for (int i = my_string.Length - 1; i >= 0; i--)
        {
            str = my_string[i] + str;
            answer.Add(str);
        }
        return answer.OrderBy(s=>s).ToArray();;
    }
}