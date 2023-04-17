/*
Apr 17, 2023 21:30
Runtime 137 ms Beats 74.76%
Memory 42.2 MB Beats 34.73%
*/

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int[]> dir = new List<int[]> {
        new int[]{ 0, 1 },
        new int[]{ 1, 0 },
        new int[]{ 0, -1 },
        new int[]{ -1, 0} };

        List<int> result = new List<int>();

        int flag = 0;
        int x = 0, y = 0, next=0;

        while (flag < 4)
        {
            result.Add(matrix[x][y]);
            matrix[x][y] = 999;

            flag = 0;
            while (flag<4) { 
                int nx = x + dir[next][0];
                int ny = y + dir[next][1];
                if (nx < 0 || ny < 0 || nx >= matrix.Length || ny >= matrix[0].Length || matrix[nx][ny] == 999) { 
                    next = (next + 1) % 4;
                    flag += 1;
                }
                else
                {
                    x = nx; y = ny;
                    break;
                }
            }
        }

        return result;
    }
}
