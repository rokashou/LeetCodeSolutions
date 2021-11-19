/*
461. Hamming Distance
https://leetcode.com/problems/hamming-distance/

Uploaded: 11/19/2021 21:57
Runtime: 28 ms, faster than 92.75% of C# online submissions for Hamming Distance.
Memory Usage: 26.9 MB, less than 9.33% of C# online submissions for Hamming Distance.
*/

public class Solution {
    public int HammingDistance(int x, int y) {
        int result = 0;

        for(int i=0;i<32;i++){
            if( ((1<<i) & x) != ((1<<i) & y)) result += 1;
        }

        return result;

    }
}
