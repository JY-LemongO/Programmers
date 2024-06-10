using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] priorities, int location)
        {
            int answer = 0;
            
            List<int> ints = new List<int>(priorities);

            while (true)
            {
                bool canProcess = true;
                int temp = ints[0];
                ints.RemoveAt(0);

                // 우선순위가 높은 프로세스가 있으면 방금 꺼낸 건 맨 뒤로
                foreach (int i in ints)
                {
                    if (temp < i)
                    {
                        ints.Add(temp);
                        canProcess = false;
                        break;
                    }                        
                }

                // 프로세스 실행 가능할 때
                if (canProcess)
                {
                    // 실행했으니 카운트 +1
                    answer++;                    
                    if (location == 0) // 방금 꺼낸게 찾는 프로세스면 while문 종료
                        break;                    
                }

                // 로케이션을 앞으로 당김. 0보다 작으면 다시 맨뒤로
                location = location - 1 < 0 ? ints.Count - 1 : location - 1;                
            }

            return answer;
        }
}