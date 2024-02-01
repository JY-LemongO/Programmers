using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strings, int n) {
        List<string> stringss = new List<string>(strings);
            stringss.Sort((x, y) =>
            {
                char charX = x[n];
                char charY = y[n];

                if (charX != charY)
                {
                    return charX.CompareTo(charY);
                }
                else
                {
                    return x.CompareTo(y);
                }
            });

            string[] answer = stringss.ToArray();
            return answer;
    }
}