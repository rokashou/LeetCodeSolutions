/*
My Solution
Apr 05, 2023 09:14
Runtime 162 ms, Beats 19.23%
Memory 45.4 MB, Beats 96.15%
*/

public class Solution {
    public int[][] DiagonalSort(int[][] mat) {
        int x = mat.Length-1, y = mat[0].Length-1;
        
        for(int t = -1*y; t <= x; t++)
        {
            var diagonalArray = new List<int>();
            for (int i = 0; i <= x; i++)
            {
                // t = i-j -> j=i-t;
                int j = i-t;
                if (j > y) break;
                if (j < 0) continue;
                diagonalArray.Add(mat[i][j]);
            }
            diagonalArray.Sort();

            // store the array back
            for(int i = 0,idx=0; i<=x; i++)
            {
                int j = i - t;
                if (j > y) break;
                if (j < 0) continue;
                mat[i][j] = diagonalArray[idx++];
            }
        }

        return mat;
    }
}
