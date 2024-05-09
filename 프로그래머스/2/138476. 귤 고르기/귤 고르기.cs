using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        int rest = k ;
        //크기의 평균이 아닌, 다른 종류의 수를 최솟값으로 하려는게 목적
        //가장 많은 수를 넣으면 될듯. 
        //귤 수는 10만, 종류는 1천만 
        Dictionary<int, int> sizeAndCount = new Dictionary<int, int>();
        for( int i = 0 ; i < tangerine.Length; i++){
            if(sizeAndCount.ContainsKey(tangerine[i])){
                sizeAndCount[tangerine[i]] +=1;
            }
            else {
                sizeAndCount.Add(tangerine[i],1);
            }
        }
        foreach (KeyValuePair<int, int> items in sizeAndCount){
            //System.Console.WriteLine(items.Key+"의 수량은"+items.Value);
        }
       var gg = sizeAndCount.OrderByDescending(x => x.Value);
        //System.Console.WriteLine("정렬");
        foreach (KeyValuePair<int, int> items in gg){
            answer += 1 ; //종류 하나 더하고
            rest -= items.Value; //숫자 만큼 빼고
            if(rest <=0){
                break; //남은 게 없으면 빼고 
            }
            //System.Console.WriteLine(items.Key+"의 수량은"+items.Value);
        }
        return answer;
    }
}
