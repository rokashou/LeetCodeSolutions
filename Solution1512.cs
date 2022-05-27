/*
Runtime: 129 ms, faster than 26.32% of C# online submissions for Number of Good Pairs.
Memory Usage: 36.9 MB, less than 31.80% of C# online submissions for Number of Good Pairs.
Uploaded: 05/27/2022 21:27
*/

public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        Dictionary<int, int> table = new Dictionary<int, int>();
        int[] pairsCount = new int[100];
        for (int i = 2; i < 100; i++)
            pairsCount[i] = pairsCount[i - 1] + (i - 1);

        foreach(int n in nums)
        {
            if (!table.ContainsKey(n))
            {
                table.Add(n, 0);
            }
            table[n] += 1;

        }

        int count = 0;
        foreach(var va in table.Values)
        {
            count += pairsCount[va];
        }
        return count;
    }
}
