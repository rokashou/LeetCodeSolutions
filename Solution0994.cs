public class Solution {
    /*
    Uploaded: 10/29/2021 20:12
    Runtime: 88 ms, faster than 91.75% of C# online submissions for Rotting Oranges.
    Memory Usage: 39.1 MB, less than 7.24% of C# online submissions for Rotting Oranges.
    */
    public int OrangesRotting(int[][] grid)
    {
        int[,,] matrix= new int[2,10,10];
        int gen = 0;
        int len1 = grid.Length;
        int len2 = grid[0].Length;
        // initialize the matrix
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                matrix[0, i, j] = grid[i][j];
                matrix[1, i, j] = grid[i][j];
            }
        }

        int check1,check2;

        while (true)
        {
            //check2 = 0;
            check1 = 0;
            check2 = 0;

            for(int i = 0; i < len1; i++)
            {
                for(int j = 0; j < len2; j++)
                {
                    if (matrix[0, i, j] == 0) matrix[1, i, j] = 0;
                    if (matrix[0, i, j] == 2)
                    {
                        matrix[1, i, j] = 2;
                        if (i > 0 && matrix[0, i - 1, j] == 1) { 
                            matrix[1, i - 1, j] = 2;
                            check1++;
                        }
                        if (j > 0 && matrix[0, i, j - 1] == 1) { 
                            matrix[1, i, j - 1] = 2;
                            check1++;
                        }
                        if (i < len1 - 1 && matrix[0, i + 1, j] == 1) { 
                            matrix[1, i + 1, j] = 2;
                            check1++;
                        }
                        if(j < len2 -1 && matrix[0, i, j + 1] == 1)
                        {
                            matrix[1, i, j + 1] = 2;
                            check1++;
                        }
                    }
                }
            }

            for (int i = 0; i < len1; i++)
            {
                for(int j = 0; j < len2; j++)
                {
                    matrix[0, i, j] = matrix[1, i, j];
                    if (matrix[0, i, j] == 1) check2 += 1;
                }
            }

            if (check1 > 0) {
                gen += 1;
            }
            if (check1 == 0) break;
        }

        if (check2 == 0)
            return gen;
        else
            return -1;
    }
}
