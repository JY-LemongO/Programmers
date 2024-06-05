using System;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount)
        {
            int answer = 0;                        

            for (int day = 0; day < discount.Length - 9; day++)
            {
                int[] copy = new int[number.Length];
                int count = 0;

                for (int i = day; i < day + 10; i++)
                {                    
                    for (int j = 0; j < want.Length; j++)
                    {
                        if (discount[i] == want[j])
                        {
                            copy[j]++;
                        }
                    }
                }

                for(int i = 0; i < copy.Length; i++)
                {
                    if (copy[i] < number[i])
                        break;
                    count++;
                }
                if(count == number.Length)
                    answer++;
            }

            return answer;
        }
}