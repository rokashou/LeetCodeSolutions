/*
Apr 12, 2023 22:41
Runtime 61 ms, Beats 77%
Memory 36.1 MB, Beats 63%
*/

public class Solution {
    public int MaxDepth(string s) {
        int curr = 0, max = 0;
        foreach(var ch in s)
        {
            if (ch == '(') curr++;
            if (ch == ')') curr--;
            max = Math.Max(max, curr);
        }
        return max;
    }
}

