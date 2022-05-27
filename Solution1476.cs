/*
Runtime: 234 ms, faster than 51.06% of C# online submissions for Subrectangle Queries.
Memory Usage: 47.9 MB, less than 50.00% of C# online submissions for Subrectangle Queries.
Uploaded: 05/27/2022 20:43
*/



public class SubrectangleQueries {
    private int[][] Rectangle;

    public SubrectangleQueries(int[][] rectangle)
    {
        Rectangle = rectangle;
    }

    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
    {
        for (int i = row1; i <= row2; i++)
            for (int j = col1; j <= col2; j++)
                Rectangle[i][j] = newValue;
    }

    public int GetValue(int row, int col)
    {
        return Rectangle[row][col];
    }
}

