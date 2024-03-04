using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
            int width = 0;
            int height;
            int area = brown + yellow;
            while (true)
            {
                width++;
                height = area / width;
                if (area % width != 0 || width < 3 || height < 3 || width < height)
                    continue;
                if (width * height == area)
                {
                    if ((width - 2) * (height - 2) == yellow)
                    {
                        answer[0] = width;
                        answer[1] = height;
                        return answer;
                    }
                    else
                        continue;
                }
            }    
    }
}