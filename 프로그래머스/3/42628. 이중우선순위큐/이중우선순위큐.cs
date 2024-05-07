using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] operations) {
        int[] answer = new int[2];
            List<int> list = new List<int>();
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i].Contains('D'))
                {
                    if (list.Count <= 0)
                        continue;

                    if (operations[i].Contains('-'))
                        list.RemoveAt(0);
                    else
                        list.RemoveAt(list.Count - 1);
                }
                else
                {
                    string nums = "";
                    foreach (char c in operations[i])
                        if (char.IsDigit(c))
                            nums += c;
                    if (operations[i].Contains('-'))
                        list.Add(int.Parse(nums) * -1);
                    else
                        list.Add(int.Parse(nums));
                }
                list.Sort();
            }

            if(list.Count > 0)
            {
                answer[0] = list[list.Count - 1];
                answer[1] = list[0];
            }            

            return answer;
    }
}
