using System;

public class Solution {
    public int[] solution(string[] wallpaper)
        {
    int[] answer = { int.MaxValue, int.MaxValue, int.MinValue, int.MinValue };

for (int i = 0; i < wallpaper.Length; i++)
{
    for (int j = 0; j < wallpaper[i].Length; j++)
    {
        if (wallpaper[i][j] == '#')
        {
            answer[0] = answer[0] < i ? answer[0] : i;
            answer[1] = answer[1] < j ? answer[1] : j;
            answer[2] = answer[2] > i ? answer[2] : i + 1;
            answer[3] = answer[3] > j ? answer[3] : j + 1;
        }
    }
}

return answer;
}
}