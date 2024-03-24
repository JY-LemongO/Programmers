using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
         int answer = 0;

            List<int> reserveList = new List<int>(reserve);
            List<int> lostList = new List<int>(lost);

            reserveList.Sort();
            lostList.Sort();

            List<int> removeList = new List<int>();
            foreach (int res in reserveList)
            {
                foreach(int los in lostList)
                {
                    if (res == los)
                    {
                        removeList.Add(res);
                        break;
                    }                 
                }
            }

            foreach(int remove in removeList)
            {
                reserveList.Remove(remove);
                lostList.Remove(remove);
            }

            for(int i = 0; i < lostList.Count; i++)
            {
                foreach(int re in reserveList)
                {
                    if(re == lostList[i] + 1 || re == lostList[i] - 1)
                    {
                        answer++;
                        reserveList.Remove(re);
                        break;
                    }
                }
            }

            return n - (lostList.Count - answer);
    }
}
