public class Solution {
    public string solution(int a, int b) {
        string[] yoils = new string[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
            int month = 1;
            int day;
            int yoil = 5;
            
            while(month <= 12)
            {
                if (month < 8)
                    if (month % 2 == 0)
                        day = 30;
                    else
                        day = 31;
                else
                    if (month % 2 == 0)
                        day = 31;
                else
                        day = 30;
                if (month == 2)
                    day = 29;

                for(int i = 1; i <= day; i++)
                {
                    if (month == a && b == i)
                        return yoils[yoil % 7];

                    yoil++;                    
                }
                month++;
            }
            return "";
    }
}