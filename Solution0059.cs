/*
Runtime: 102 ms, faster than 76.43% of C# online submissions for Spiral Matrix II.
Memory Usage: 36.7 MB, less than 8.37% of C# online submissions for Spiral Matrix II.
Uploaded: 04/14/2022 00:42
*/

public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[][] result = new int[n][];
        int i;
        for(i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }

        i = 1;
        int x = 0;
        int y = 0;
        int d = 0;

        while(i <= n * n)
        {
            if (result[x][y] == 0) { 
                result[x][y] = i;
            }
            else
                break;
            switch (d)
            {
                case 0: // go right
                    if (y == n - 1 || result[x][y+1]!=0)
                    {
                        d = 1;
                        x += 1;
                        break;
                    }
                    y += 1;
                    break;
                case 1: // go down
                    if(x==n-1 || result[x + 1][y] != 0)
                    {
                        d = 2;
                        y -= 1;
                        break;
                    }
                    x += 1;
                    break;
                case 2: // go left
                    if(y==0 || result[x][y-1] != 0)
                    {
                        d = 3;
                        x -= 1;
                        break;
                    }
                    y -= 1;
                    break;
                case 3: // go up
                    if(x==0 || result[x-1][y] != 0)
                    {
                        d = 0;
                        y += 1;
                        break;
                    }
                    x -= 1;
                    break;
            }
            i++;
        }
        return result;
    }
}

