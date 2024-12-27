using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(int[] numbers) {
        // 1. 숫자를 문자열로 변환
        var stringNumbers = numbers.Select(n => n.ToString()).ToList();

        // 2. 커스텀 정렬: X+Y vs Y+X 비교
        stringNumbers.Sort((x, y) => (y + x).CompareTo(x + y));

        // 3. 모든 숫자가 0인 경우 "0" 반환
        if (stringNumbers[0] == "0")
            return "0";

        // 4. 정렬된 결과를 이어붙여 반환
        return string.Join("", stringNumbers);
    }
}