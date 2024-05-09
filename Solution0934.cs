/*
May 21, 2023 20:49
Runtime 115 ms Beats 96.83%
Memory 56.1 MB Beats 23.81%
*/


public class Solution {
    public int ShortestBridge(int[][] grid) {
        int n = grid.Length;
        int firstX = -1, firstY = -1;

        // Find any land cell, and we treat it as a cell of island A.
        for(int i = 0; i < n && firstX == -1; i++)
        {
            for(int j = 0;j < n; j++)
            {
                if (grid[i][j] == 1)
                {
                    firstX = i;
                    firstY = j;
                    break;
                }
            }
        }

        // bfsQueue for BFS on land cells of island A;
        // bfsQueue2nd for BFS on water cells.
        var bfsQueue = new List<int[]>();
        var bfsQueue2nd = new List<int[]>();
        bfsQueue.Add(new int[] { firstX, firstY });
        bfsQueue2nd.Add(new int[] { firstX, firstY });
        grid[firstX][firstY] = 2;

        int[][] dir = new int[][]
        {
            new int[]{1,0},
            new int[]{-1,0},
            new int[]{0,1},
            new int[]{0,-1}
        };

        

        // BFS for all land cells of island A and add them to bfsQueue2nd
        while(bfsQueue.Count > 0)
        {
            var newBfs = new List<int[]>();
            foreach(var cell in bfsQueue)
            {
                int x = cell[0];
                int y = cell[1];
                for(int d = 0; d < 4; d++)
                {
                    int curX = x + dir[d][0];
                    int curY = y + dir[d][1];
                    if(curX >=0 && curX < n && curY >=0 && curY < n && grid[curX][curY] == 1)
                    {
                        newBfs.Add(new int[] { curX, curY });
                        bfsQueue2nd.Add(new int[] { curX, curY });
                        grid[curX][curY] = 2;
                    }
                }
            }
            bfsQueue = newBfs;
        }

        int distance = 0;
        while(bfsQueue2nd.Count > 0)
        {
            var newBfs = new List<int[]>();
            foreach(var cell in bfsQueue2nd)
            {
                int x = cell[0];
                int y = cell[1];
                for(int d = 0; d < 4; d++)
                {
                    int curX = x + dir[d][0];
                    int curY = y + dir[d][1];
                    if (curX >= 0 && curX < n && curY >= 0 && curY < n)
                    {
                        if(grid[curX][curY] == 1)
                        {
                            return distance;
                        }else if (grid[curX][curY] == 0) { 
                            newBfs.Add(new int[] { curX, curY });
                            grid[curX][curY] = -1;
                        }
                    }
                }
            }
            // Once we finish one round without finding land cells of island B, we will
            // start the next round on all water cells that are 1 cell further away from
            // island A and increment the distance by 1.
            bfsQueue2nd = newBfs;
            distance++;
        }

        return distance;        
    }
}
