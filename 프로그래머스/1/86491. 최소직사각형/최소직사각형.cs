using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] sizes) {
        List<int> width = new List<int>();
            List<int> height = new List<int>();
            for(int i = 0; i < sizes.GetLength(0); i++)
            {
                width.Add(sizes[i, 0]);
                height.Add(sizes[i, 1]);
            }

            while (true)
            {
                // 최고 가로길이와 인덱스 찾기
                int bestWidth = 0;
                int indexWidth = -1;
                for (int i = 0; i < width.Count; i++)
                {
                    if(bestWidth < width[i])
                    {
                        bestWidth = width[i];
                        indexWidth = i;
                    }
                }

                // 최고 세로길이와 인덱스 찾기
                int bestHeight = 0;
                int indexHeight = -1;
                for (int i = 0; i < height.Count; i++)
                {
                    if (bestHeight < height[i])
                    {
                        bestHeight = height[i];
                        indexHeight = i;
                    }
                }

                // 만약 가로 > 세로 (최고길이) 라면            
                if (bestWidth > bestHeight)
                {
                    // 세로가 졌으니까 세로(최고길이) 인덱스에 해당하는 가로랑 다시 떠
                    // 그래도 자기영역 가로보단 커? 그럼 자리 바꿔
                    if (height[indexHeight] > width[indexHeight])
                    {
                        int temp = width[indexHeight];
                        width[indexHeight] = height[indexHeight];
                        height[indexHeight] = temp;
                    }
                    // 근데 자기영역에서도 졌어?? 그럼 끝!
                    else
                        return bestWidth * bestHeight;
                }
                // 만약 세로 > 가로 (최고길이) 라면
                else
                {
                    // 가로가 졌으니까 가로(최고길이) 인덱스에 해당하는 세로랑 다시 떠
                    // 그래도 자기영역 세로보단 커? 그럼 자리 바꿔
                    if (width[indexWidth] > height[indexWidth])
                    {
                        int temp = width[indexWidth];
                        width[indexWidth] = height[indexWidth];
                        height[indexWidth] = temp;
                    }
                    // 근데 자기영역에서도 졌어?? 그럼 끝!
                    else
                        return bestWidth * bestHeight;
                }
            }  
    }
}