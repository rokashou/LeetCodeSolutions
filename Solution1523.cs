/*
Runtime 23 ms, Beats 89.45%
Memory 26.7 MB, Beats 15.45%
Feb 13, 2023 20:50
*/

public class Solution {
    public int CountOdds(int low, int high) {
        return ( ((high % 2 == 0)?(high-1):high) - ((low%2==0)?(low+1):low) ) / 2 + 1;

    }
}
