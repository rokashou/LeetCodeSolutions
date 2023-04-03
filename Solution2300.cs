/*
Apr 03, 2023 21:58
Runtime 361 ms, Beats 81.82%
Memory 61.7 MB, Beats 86.36%
*/


public class Solution {
    private int LowerBound(int[] arr, int key)
    {
        int lo = 0, hi = arr.Length;
        while(lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (arr[mid] < key)
                lo = mid + 1;
            else
                hi = mid;
        }
        return lo;
    }

    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);
        int[] ans = new int[spells.Length];

        int m = potions.Length;
        int maxPotion = potions[m - 1];

        for (int i = 0; i < spells.Length; i++)
        {
            int sp = spells[i];
            long minPotion = (long)Math.Ceiling((1.0 * success) / sp);
            if (minPotion > maxPotion)
            {
                ans[i] = 0;
                continue;
            }
            int index = LowerBound(potions, (int)minPotion);
            ans[i] = m - index;
        }

        return ans;
    }
}
