/*
submitted at Jul 06, 2024 15:02

Runtime 22 ms, Beats 47.83%
Memory 26.62 MB, Beats 80.43%
*/

public class Solution {
    public int PassThePillow(int n, int time) {
        int mod = 2 * (n - 1);
        int curr = time % mod;
        return 1 + (curr < n ? curr : mod-curr);
    }
}
