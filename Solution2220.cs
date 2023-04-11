/*
Apr 11, 2023 22:52
Runtime 14 ms, Beats 100%
Memory 26.6 MB, Beats 64.29%
*/

public class Solution {
    public int MinBitFlips(int start, int goal) {
        int result = start ^ goal;
        int count = 0;
        while(result > 0)
        {
            count+=result & 1;
            result >>= 1;
        }
        return count;
        
    }
}
