/*
May 07, 2023 14:17
Runtime 418 ms Beats 50%
Memory 63.3 MB Beats 50%
*/

public class Solution {
    public int[] LongestObstacleCourseAtEachPosition(int[] obstacles)
    {
        int n = obstacles.Length, lisLength = 0;
        int[] ans = new int[n];
        int[] lis = new int[n];

        for (int i = 0; i < n; i++)
        {
            int h = obstacles[i];

            // Find the rightmost insertion position idx.
            int idx = BisectRight(lis, h, lisLength);
            if (idx == lisLength)
                lisLength++;

            lis[idx] = h;
            ans[i] = idx + 1;
        }

        return ans;
        
    }

    private int BisectRight(int[] A, int target, int right)
    {
        if (right == 0) return 0;

        int left = 0;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (A[mid] <= target)
                left = mid + 1;
            else
                right = mid;
        }

        return left;
    }
}
