/*
Runtime: 103 ms, faster than 19.42% of C# online submissions for Jewels and Stones.
Memory Usage: 35.7 MB, less than 56.52% of C# online submissions for Jewels and Stones.
Uploaded: 05/28/2022 14:08
*/


public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int count = 0;
        foreach(var c in stones)
        {
            if (jewels.Contains(c)) count++;
        }
        return count;

    }
}
