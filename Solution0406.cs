/*
Runtime: 163 ms, faster than 89.09% of C# online submissions for Queue Reconstruction by Height.
Memory Usage: 48.5 MB, less than 14.55% of C# online submissions for Queue Reconstruction by Height.
Uploaded: 06/29/2022 23:38
*/


public class Solution {
    public int[][] ReconstructQueue(int[][] people)
    {
        Array.Sort(people, CompareFunc);

        List<int[]> res = new List<int[]>();
        foreach(int[] cur in people)
        {
            res.Insert(cur[1], cur);
        }
        return res.ToArray();
    }

    public int CompareFunc(int[] o1, int[] o2)
    {
        return o1[0] != o2[0] ? o2[0] - o1[0] : o1[1] - o2[1];
    }
}
