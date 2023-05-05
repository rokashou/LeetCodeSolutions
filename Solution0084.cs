/*
May 06, 2023 07:45
Runtime 213 ms Beats 79.24%
Memory 48.9 MB Beats 61.44%
*/

public class Solution {
    public int LargestRectangleArea(int[] heights) {
        if (heights == null || heights.Length == 0) return 0;

        int[] lessFromLeft = new int[heights.Length];
        int[] lessFromRight = new int[heights.Length];
        lessFromRight[heights.Length - 1] = heights.Length;
        lessFromLeft[0] = -1;

        // Scan left to right
        for(int i = 1; i < heights.Length; i++)
        {
            int p = i - 1;
            while(p>=0 && heights[p] >= heights[i])
            {
                p = lessFromLeft[p];
            }
            lessFromLeft[i] = p;
        }

        // Scan right to left
        for(int i = heights.Length - 2; i >= 0; i--)
        {
            int p = i + 1;
            while(p<heights.Length && heights[p] >= heights[i])
            {
                p = lessFromRight[p];
            }
            lessFromRight[i] = p;
        }

        int maxArea = 0;
        for(int i = 0; i < heights.Length; i++)
        {
            maxArea = Math.Max(maxArea, heights[i] * (lessFromRight[i] - lessFromLeft[i] - 1));
        }

        return maxArea;        
    }
}
