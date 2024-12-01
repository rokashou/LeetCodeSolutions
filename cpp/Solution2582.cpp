/*
submitted at Jul 06, 2024 15:07

Runtime 0 ms, Beats 100.00%
Memory 7.02 MB, Beats 71.18%
*/

class Solution {
public:
    int passThePillow(int n, int time) {
        int mod = 2 * (n - 1);
        int curr = time % mod;
        return 1 + (curr < n ? curr : mod-curr);
        
    }
};
