/*
Apr 13, 2023 22:49
Runtime 149 ms Beats 44.67%
Memory 49.1 MB Beats 39.96%
*/

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        const int MAXRANGE = 100000;
        bool[] checkNum = new bool[MAXRANGE];
        Array.Fill(checkNum, false);
        foreach(var n in nums)
        {
            if(n > 0 && n <= MAXRANGE)
            {
                checkNum[n - 1] = true;
            }
        }
        for(int i = 0; i < MAXRANGE; i++)
        {
            if (checkNum[i] == false)
            {
                return i + 1;
            }
        }
        return MAXRANGE+1;
    }
}
