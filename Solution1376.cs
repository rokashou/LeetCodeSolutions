/*
Jun 04, 2023 19:59
Runtime 335 ms Beats 61.73%
Memory 57.5 MB Beats 65.43%
*/


public class Solution {
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) {
        if (n == 1) return 0;
        int[] informedNode = new int[n];
        int maxTime = 0;
        var dic = new Dictionary<int, List<int>>();

        for(int i = 0; i < n; i++)
        {
            if (!dic.ContainsKey(manager[i]))
                dic[manager[i]] = new List<int>();
            dic[manager[i]].Add(i);
        }

        var q = new Queue<int>();
        q.Enqueue(headID);

        while (q.Count > 0)
        {
            int node = q.Dequeue();
            if (manager[node] == -1)
                informedNode[node] = 0 + informTime[node];
            else
                informedNode[node] = informedNode[manager[node]] + informTime[node];

            if(dic.ContainsKey(node))
            foreach(var subnode in dic[node])
            {
                q.Enqueue(subnode);
            }

            maxTime = Math.Max(maxTime, informedNode[node]);
        }

        return maxTime;     
    }
}
