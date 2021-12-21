/*
Runtime: 24 ms, faster than 95.40% of C# online submissions for Number of 1 Bits.
Memory Usage: 26.7 MB, less than 59.70% of C# online submissions for Number of 1 Bits.
Uploaded: 12/21/2021 23:49
Url: https://leetcode.com/problems/number-of-1-bits
*/

public class Solution {
    public int HammingWeight(uint n) {
        int bits=0;
        uint root=1;
        for(int i=0;i<32;i++)
        {
            if( (n & root<<i)  > 0) bits+=1;
        }
        return bits;
    }
}
