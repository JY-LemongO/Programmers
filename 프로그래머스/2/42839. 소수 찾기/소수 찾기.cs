using System;
using System.Collections.Generic;

class Solution
{
    public int solution(string numbers)
    {
        var permutations = new HashSet<int>();
        GeneratePermutations("", numbers, permutations);

        int count = 0;
        foreach (var num in permutations)
        {
            if (IsPrime(num))
            {
                count++;
            }
        }

        return count;
    }

    private void GeneratePermutations(string current, string remaining, HashSet<int> results)
    {
        if (current != "")
        {
            results.Add(int.Parse(current));
        }

        for (int i = 0; i < remaining.Length; i++)
        {
            GeneratePermutations(
                current + remaining[i],
                remaining.Substring(0, i) + remaining.Substring(i + 1),
                results
            );
        }
    }

    private bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}
