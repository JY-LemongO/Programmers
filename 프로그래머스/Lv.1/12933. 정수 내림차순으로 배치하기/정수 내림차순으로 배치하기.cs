public class Solution {
    public long solution(long n) {
        long answer = 0;
            char[] c = n.ToString().ToCharArray();
            for(int i = 0; i< c.Length - 1; i++)
            {
                for (int j = 0; j < c.Length - 1; j++)
                {
                    int x = int.Parse(c[j].ToString());
                    int y = int.Parse(c[j + 1].ToString());
                    if (x < y)
                    {
                        char temp = c[j];
                        c[j] = c[j + 1];
                        c[j + 1] = temp;
                    }                    
                }
            }
            long multi = 1;
            for(int i = c.Length - 1; i >= 0; i--)
            {
                long x = long.Parse(c[i].ToString());
                answer += x * multi;
                multi *= 10;
            }
            return answer;
    }
}