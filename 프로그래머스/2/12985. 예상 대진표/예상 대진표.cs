using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 1;

int round = n / 2;

for(int i = 0; i < round; i++)
{
    if (a % 2 == 1 && a + 1 == b)
    break;
else if (a % 2 == 0 && a - 1 == b)
    break;    

a = a % 2 == 0 ? a / 2 : (a + 1) / 2;
b = b % 2 == 0 ? b / 2 : (b + 1) / 2;

    answer++;
}

return answer;
    }
}