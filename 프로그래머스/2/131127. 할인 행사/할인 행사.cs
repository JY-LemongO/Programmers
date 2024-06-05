
using System;
using System.Collections.Generic;

public class Solution {
    int m_totalCount = 0 ;
    Dictionary<string, int> m_wantDic = new Dictionary<string, int>();
    int m_answer = 0;
    public int solution(string[] want, int[] number, string[] discount) {

        for(int i = 0 ; i < want.Length; i++){
            string wantConsume = want[i];
            int wantCount = number[i];
            m_totalCount += wantCount;
            m_wantDic.Add(wantConsume, wantCount );
        }


        //가장 단순한건 - 한번 i가 시작하면 계속해서 i를 올리면서 탐방하는거 해당 딕션에서 
        for ( int i = 0 ; i <= discount.Length - m_totalCount ; i ++ ){
            CheckConsume(m_wantDic, i, discount);
        }

        return m_answer;
    }
    void CheckConsume(Dictionary<string, int> _consumeDic, int _startIndex, string[] _discount){
        Dictionary<string, int> insDic = new Dictionary<string, int>(_consumeDic);
        //Console.WriteLine(_startIndex+"부터 시작 만족해야하는 물품 수" +m_totalCount);
         for ( int i = _startIndex ; i < _startIndex + m_totalCount ; i ++ ){
            string disCountConsume = _discount[i];
             if(!insDic.ContainsKey(disCountConsume)){
                 return;
             }
             insDic[disCountConsume] -= 1;
             if(insDic[disCountConsume]<0){
                 return;
             }

        }
       // Console.WriteLine(_startIndex+"는 가능");
        m_answer += 1; 
    }
}