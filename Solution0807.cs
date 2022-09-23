/*
Runtime: 102 ms, faster than 93.62% of C# online submissions for Max Increase to Keep City Skyline.
Memory Usage: 40 MB, less than 5.32% of C# online submissions for Max Increase to Keep City Skyline.
Uploaded: 09/24/2022 00:06 GMT+9=JST
*/
// My Solution

public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        int n = grid.Length;
        int[] rMax = new int[n];
        int[] cMax = new int[n];
        int result = 0;

        for(int r = 0; r < n; r++)
        {
            
            for(int c = 0; c < n; c++)
            {
                rMax[r] = Math.Max(rMax[r], grid[r][c]);
                cMax[c] = Math.Max(cMax[c], grid[r][c]);
            }
        }

        for(int r = 0; r < n; r++)
        {
            for(int c = 0; c < n; c++)
            {
                int minValue = Math.Min(rMax[r], cMax[c]);
                result += minValue - grid[r][c];
            }
        }

        return result;
    }
}

