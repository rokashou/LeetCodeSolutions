/*
Runtime: 134 ms, faster than 22.34% of C# online submissions for Partitioning Into Minimum Number Of Deci-Binary Numbers.
Memory Usage: 40.2 MB, less than 61.70% of C# online submissions for Partitioning Into Minimum Number Of Deci-Binary Numbers.
Uploaded: 05/27/2022 22:00
*/

public class Solution {
    public int MinPartitions(string n) {
        int k = 0;
        foreach(var c in n)
        {
            if (c - '0' > k) k = c - '0';
        }
        return k;
    }
}
