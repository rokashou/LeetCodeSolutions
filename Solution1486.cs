/*
Mar 05, 2023 18:49
Runtime 26 ms, Beats 56.52%
Memory 26.7 MB, Beats 13.4%
*/

public class Solution {
    public int XorOperation(int n, int start) {
        var ans = start;
        for (int i = 1; i < n; i++)
            ans ^= (start + 2 * i);
        return ans;
    }
}
