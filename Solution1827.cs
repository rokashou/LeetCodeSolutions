/*
Runtime: 560 ms, faster than 10.94% of C# online submissions for Queries on Number of Points Inside a Circle.
Memory Usage: 47.1 MB, less than 32.81% of C# online submissions for Queries on Number of Points Inside a Circle.
Uploaded: 05/30/2022 22:37
*/

public class Solution {
    private bool PointInCircle(int[] point, int[] circle)
    {
        double dx = point[0] - circle[0];
        double dy = point[1] - circle[1];
        if (Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2)) <= circle[2]) return true;
        return false;
    }

    public int[] CountPoints(int[][] points, int[][] queries)
    {
        int[] answer = new int[queries.Length];
        for(int i=0;i<queries.Length;i++)
        {
            foreach(var point in points)
            {
                if (PointInCircle(point, queries[i]))
                    answer[i] += 1;
            }
        }
        return answer;
    }
}
