using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strArr) {
        List<string> strList = new List<string>();

foreach(string s in strArr)
{
    if (s.Contains("ad"))
        continue;

    strList.Add(s);
}

return strList.ToArray();
    }
}