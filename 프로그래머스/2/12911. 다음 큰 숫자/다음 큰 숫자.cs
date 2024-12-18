using System;

class Solution 
{
    public int solution(int n) 
   {
        // n < m 
        // 2진수로 변환했을 때 1의 개수가 같다.
        // 위 두 조건을 만족하는 것들 중 가장 작은 수
        int m = -1;

int oneCount = 0;
string binary = Convert.ToString(n, 2);
foreach (char c in binary)
    if (c == '1')
        oneCount++;

for(int i = n+1; i < 1000000; i++)
{
    int oneCountI = 0;
    string binaryI = Convert.ToString(i, 2);
    foreach (char c in binaryI)
        if (c == '1')
            oneCountI++;

    if(oneCount == oneCountI)
    {
        m = i;
        break;
    }                    
}

return m;
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
//         string resultN;
//             string resultB;
//             int b = n;
//             bool correct = false;
            
//             while (!correct)
//             {
//                 b++;

//                 resultN = Convert.ToString(n, 2);
//                 resultB = Convert.ToString(b, 2);

//                 int countN = 0;
//                 int countB = 0;

//                 for (int i = 0; i < resultB.Length; i++)
//                 {
//                     if (resultB[i] == '1')
//                         countB++;
//                     if(i <= resultN.Length - 1)
//                         if (resultN[i] == '1')
//                             countN++;
//                 }                
//                 correct = countN == countB;
//             }

//             return b;
    }
}