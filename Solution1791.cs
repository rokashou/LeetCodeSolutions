/*
Mar 23, 2023 22:21
Runtime 292 ms, Beats 43.24%
Memory 61.8 MB, Beats 56.76%
*/

public class Solution {
    public int FindCenter(int[][] edges) {
        if (edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1])
            return edges[0][0];
        return edges[0][1];
    }
}
