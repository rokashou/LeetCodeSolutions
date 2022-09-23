/*
Runtime: 36 ms, faster than 63.43% of C# online submissions for Smallest Even Multiple.
Memory Usage: 25.2 MB, less than 44.44% of C# online submissions for Smallest Even Multiple.
Uploaded: 09/23/2022 18:09
*/


public class Solution {
    public int SmallestEvenMultiple(int n) {
        if (n % 2 == 0)
            return n;
        else
            return n * 2;

    }
}
