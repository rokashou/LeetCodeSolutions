/*
Runtime: 116 ms, faster than 76.83% of C# online submissions for Koko Eating Bananas.
Memory Usage: 43.3 MB, less than 46.95% of C# online submissions for Koko Eating Bananas.
Uploaded: 01/21/2022 00:38
*/


public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        // Initalize the left and right boundaries
        int left = 1, right = 1;
        foreach (int p in piles)
        {
            right = Math.Max(right, p);
        }

        while (left < right)
        {
            // Get the middle index between left and right boundary indexes.
            // hourSpent stands for the total hour Koko spends.
            int middle = (left + right) / 2;
            int hourSpent = 0;

            // Iterate over the piles and calculate hourSpent.
            // We increase the hourSpent by ceil(pile/middle)
            foreach (int p in piles)
            {
                hourSpent += (int)Math.Ceiling((double)p / middle);
            }

            // Check if middle is a workable speed, and cut the search space by half.
            if (hourSpent <= h)
            {
                right = middle;
            }
            else
            {
                left = middle + 1;
            }
        }

        // Once the left and right boundaries coincide, we find the target value, 
        // that is, the minimum workable eating speed.
        return right;
    }
}

