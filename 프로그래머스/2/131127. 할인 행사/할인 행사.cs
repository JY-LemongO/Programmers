using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string[] want, int[] number, string[] discount)
        {
            Dictionary<string, int> wantList = new Dictionary<string, int>();
            Dictionary<string, int> discountList = new Dictionary<string, int>();

            for (int i = 0; i < number.Length; i++)
            {
                if (wantList.ContainsKey(want[i]))
                {
                    wantList[want[i]]+=number[i];
                }
                else
                {
                    wantList.Add(want[i],number[i]);
                }
            }

            int day = 0;
            int result = 0;

            for (int i = 0; i < 10; i++)
            {
                string d = discount[i];
                if (discountList.ContainsKey(d))
                {
                    discountList[d]++;
                }
                else
                {
                    discountList.Add(d,1);
                }
            }

            while (day + 10<discount.Length+1)
            {
                string prevDis = discount[day];
                bool isPass = false;

                foreach (var w in wantList)
                {
                    if (!discountList.ContainsKey(w.Key))
                    {

                        isPass = true;
                    }
                    else if (discountList[w.Key] != w.Value)
                    {
                        isPass = true;
                    }
                }

                Console.WriteLine("");

                if (discountList[prevDis] == 1)
                {
                    discountList.Remove(prevDis);
                }
                else
                {
                    discountList[prevDis]--;
                }

                if (day+10<discount.Length)
                {
                    string ss = discount[day + 10];

                    if (discountList.ContainsKey(ss))
                    {
                        discountList[ss]++;
                    }
                    else
                    {
                        discountList.Add(ss,1);
                    }
                }

                if (isPass)
                {
                    day++;
                }
                else
                {
                    result++;
                    day++;
                }
            }
            return result;
        }
}