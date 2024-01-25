using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long bill = 0;
            for (int i = 1; i < count + 1; i++)
                bill += price * i;
            return money - bill > 0 ? 0 : bill - money;
    }
}