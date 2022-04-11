/*
Runtime: 172 ms, faster than 88.00% of C# online submissions for Shift 2D Grid.
Memory Usage: 47.5 MB, less than 8.00% of C# online submissions for Shift 2D Grid.
Uploaded: 04/11/2022 23:58
*/


public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        List<int> list = new List<int>();
        int m = grid.Length;
        int n = grid[0].Length;
        int trueLoop = k % (m*n);

        foreach(int[] arr1 in grid){
            foreach(int t in arr1){
                list.Add(t);
            }
        }

        IList<IList<int>> result = new List<IList<int>>();
        int idx=(m*n-trueLoop);

        for (int i = 0; i < m; i++)
        {
            IList<int> inner = new List<int>();
            for (int j = 0; j < n; j++)
            {
                if(idx>=list.Count) idx = 0;
                inner.Add(list[idx++]);
            }
            result.Add(inner);
        }

        return result;
    }
}
