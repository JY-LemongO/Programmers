
using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {        
        return arr.SelectMany(num => Enumerable.Repeat(num, num)).ToArray();
    }
}