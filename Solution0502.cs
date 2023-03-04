/*
Mar 04, 2023 13:00
Runtime 297 ms, Beats 64.51%
Memory 55.8 MB, Beats 51.70%
*/

public class Solution {
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) {
        int n = profits.Length;
        List<int[]> projects = new List<int[]>();
        for (int i = 0; i < n; i++)
        {
            projects.Add(new int[] { capital[i], profits[i] });
        }
        projects.Sort((x, y) => (x[0]-y[0]==0)?(x[1]-y[1]):(x[0]-y[0]));
        PriorityQueue<int,int> q = new();
        int ptr = 0;
        for (int i = 0; i < k; i++) {
            while (ptr < n && projects[ptr][0] <= w)
            {
                q.Enqueue(projects[ptr][1], -1 * projects[ptr][1]);
                ptr++;
            }
            if (q.Count == 0)
            {
                break;
            }
            w += q.Peek();
            q.Dequeue();
        }
        return w;
    }
}
