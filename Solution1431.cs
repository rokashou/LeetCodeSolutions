/*
Runtime: 200 ms, faster than 47.33% of C# online submissions for Kids With the Greatest Number of Candies.
Memory Usage: 42.8 MB, less than 95.06% of C# online submissions for Kids With the Greatest Number of Candies.
Uploaded: 05/28/2022 20:16
*/

public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> result = new List<bool>();

        int maxCount = 0;
        foreach (var v in candies) maxCount = Math.Max(maxCount, v);

        foreach(var v in candies)
        {
            if (v + extraCandies >= maxCount)
                result.Add(true);
            else
                result.Add(false);
        }

        return result;
    }
}
