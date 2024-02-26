using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;

            for(int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int sum = nums[i] + nums[j] + nums[k];
                        for (int x = 2; x < sum - 1; x++)
                            if (sum % x == 0)
                            {
                                sum = 0;
                                break;
                            }
                        if (sum == 0)
                            continue;
                        answer++;
                    }
                }
            }

            return answer;
    }
}