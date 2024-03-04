using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;            

            for (int i = 1; i <= number; i++)
            {
                int division = CountDivisors(i);

                int weaponPower = (division <= limit) ? division : power;
                answer += weaponPower;
            }            

            return answer;
    }
    
    public int CountDivisors(int num)
        {
            int count = 1; // 1은 모든 수의 약수이므로 1로 시작

            for (int i = 2; i * i <= num; i++)
            {
                int exponent = 0;

                while (num % i == 0)
                {
                    num /= i;
                    exponent++;
                }

                count *= (exponent + 1);
            }

            if (num > 1)
            {
                // 마지막에 소수가 남아있는 경우
                count *= 2;
            }

            return count;
        }
}