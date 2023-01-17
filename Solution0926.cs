/*
Runtime 82 ms, Beats 71.88%
Memory 43.7 MB, Beats 50%
Accepted: Jan 17, 2023 21:24
*/

public class Solution {
    public int MinFlipsMonoIncr(string s) {
        int ans = 0, num = 0;
        foreach(var c in s)
        {
            if (c == '0')
                ans = Math.Min(num, ans + 1);
            else
                num++;
        }
        return ans;
    }
}
