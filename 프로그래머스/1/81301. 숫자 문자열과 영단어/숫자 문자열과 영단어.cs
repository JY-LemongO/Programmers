using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer;
            List<string> sl = new List<string>();
            sl.Add("zero");
            sl.Add("one");
            sl.Add("two");
            sl.Add("three");
            sl.Add("four");
            sl.Add("five");
            sl.Add("six");
            sl.Add("seven");
            sl.Add("eight");
            sl.Add("nine");
            
            for(int i = 0; i < sl.Count; i++)
                if (s.Contains(sl[i]))
                    s = s.Replace(sl[i], $"{i}");

            answer = int.Parse(s);

            return answer;
    }
}