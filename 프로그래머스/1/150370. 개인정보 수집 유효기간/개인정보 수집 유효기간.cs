using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> list = new List<int>();
        int todayYear = int.Parse(today.Split('.')[0]);
        int todayMonth = int.Parse(today.Split('.')[1]);
        int todayDay = int.Parse(today.Split('.')[2]);
        int todaySum = (todayYear * 12 * 28) + (todayMonth * 28) + todayDay;
        
        string[] termsCode = new string[terms.Length];
        int[] termsMonth = new int[terms.Length];
        
        for(int i = 0; i < terms.Length; i++)
        {
            termsCode[i] = terms[i].Split(' ')[0];
            termsMonth[i] = int.Parse(terms[i].Split(' ')[1]);
        }
        
        for(int i = 0; i < privacies.Length; i++)
        {
            string[] temp = privacies[i].Split('.', ' ');
            int year = int.Parse(temp[0]);
            int month = int.Parse(temp[1]);
            int day = int.Parse(temp[2]);
            int num = Array.IndexOf(termsCode, temp[3]);
            month += Convert.ToInt32(termsMonth[num]);
            int sum = (year * 12 * 28) + (month* 28) + day - 1;
            
            if(todaySum > sum)
            {
                list.Add(i + 1);
            }
        }
        
        int[] answer = list.ToArray();
        return answer;
    }
}