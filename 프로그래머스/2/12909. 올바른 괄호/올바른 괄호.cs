using System;

public class Solution {
    public bool solution(string s) {
        int pair = 0;
        bool closing = false;
        
        foreach(var gwal in s){
            if(gwal == '('){                             
                pair++;                
            }
            else{                
                pair--;                
            }                
            
            if(pair < 0)
                return false;            
        }
        
        return pair == 0;
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        // int index = 0;
        //     foreach (char c in s)
        //     {
        //         index += c == '(' ? 1 : -1;
        //         if (index < 0)
        //             return false;
        //     }            
        //     return index == 0;
    }
}