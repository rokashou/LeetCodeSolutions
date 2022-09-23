/*
Runtime: 163 ms, faster than 42.55% of C# online submissions for Max Increase to Keep City Skyline.
Memory Usage: 38 MB, less than 72.34% of C# online submissions for Max Increase to Keep City Skyline.
Uploaded: 09/23/2022 23:56
*/
// My Solution

public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        int[] rMax = new int[grid.Length];
        int[] cMax = new int[grid[0].Length];
        int result = 0;

        Array.Fill<int>(rMax,0);
        Array.Fill<int>(cMax,0);

        for(int r = 0; r < rMax.Length; r++)
        {
            for(int c = 0; c < cMax.Length; c++)
            {
                rMax[r] = Math.Max(rMax[r], grid[r][c]);
                cMax[c] = Math.Max(cMax[c], grid[r][c]);
            }
        }

        for(int r = 0; r < rMax.Length; r++)
        {
            for(int c = 0; c < cMax.Length; c++)
            {
                int minValue = Math.Min(rMax[r], cMax[c]);
                result += minValue - grid[r][c];
            }
        }

        return result;

    }
}

