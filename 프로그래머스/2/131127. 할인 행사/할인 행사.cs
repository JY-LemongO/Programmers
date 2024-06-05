using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount)
        {
            Dictionary<string, int> saleItem = new Dictionary<string, int>();

        for (int i = 0; i < 10; i++)
        {
            if (saleItem.ContainsKey(discount[i]))
            {
                saleItem[discount[i]]++;
            }

            else
            {
                saleItem.Add(discount[i], 1);
            }
        }

        int answer = 0;
        for (int i = 0; ; i++)
        {
            bool passCheck = true;
            for (int j = 0; j < want.Length; j++)
            {
                if (!saleItem.ContainsKey(want[j]) || saleItem[want[j]] < number[j])
                {
                    passCheck = false;
                    break;
                }
            }

            if (passCheck)
            {
                answer++;
            }

            if (discount.Length <= i + 10)
            {
                break;
            }
            saleItem[discount[i]]--;
            if (saleItem.ContainsKey(discount[i + 10]))
            {
                saleItem[discount[i + 10]]++;
            }

            else
            {
                saleItem.Add(discount[i + 10], 1);
            }
        }

        return answer;
        }
}