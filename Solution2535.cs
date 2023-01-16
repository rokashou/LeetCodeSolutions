/*
Runtime 109 ms, Beats 100%
Memory 42.1 MB ,Beats 100%
Accepted Jan 16, 2023 21:59
*/

public class Solution {
    int DigitSum(int x)
    {
        int ans = 0;
        while(x > 9)
        {
            ans += x % 10;
            x /= 10;
        }
        if (x > 0)
            ans += x;
        return ans;
    }

    public int DifferenceOfSum(int[] nums)
    {
        int sum1 = 0, sum2 = 0;
        foreach(var n in nums)
        {
            sum1 += n;
            sum2 += DigitSum(n);
        }
        return Math.Abs(sum1 - sum2);
        
    }
}
