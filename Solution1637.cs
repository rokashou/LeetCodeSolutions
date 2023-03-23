/*
Mar 23, 2023 22:12
Runtime 297 ms, Beats 80%
Memory 62.2 MB, Beats 30%
*/


public class Solution
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        List<int> list = new List<int>();
        int result = 0;

        foreach (var point in points)
            list.Add(point[0]);

        list.Sort();

        for (int i = 0; i < list.Count - 1; i++)
            result = Math.Max(result, list[i + 1] - list[i]);

        return result;
    }
}
