/*
Runtime: 544 ms, Beats 94.44%
Memory: 57.5 MB, Beats 94.44%
Uploaded: Jan 16, 2023 20:47
*/

public class Solution {
    // for dsu
    int[] root;
    int[] cnt;
    int Find(int x)
    {
        return x == root[x] ? x : (root[x] = Find(root[x]));
    }


    public int NumberOfGoodPaths(int[] vals, int[][] edges)
    {
        // each node is a good path
        int n = vals.Length, ans = n;
        cnt = new int[n];
        root = new int[n];
        // each element is in its own group initially
        for(int i = 0; i < n; i++)
        {
            root[i] = i;
            cnt[i] = 1;
        }
        // sort by vals
        var edgesList = new PriorityQueue<int[],int>();
        foreach(var edge in edges)
        {
            int key = Math.Max(vals[edge[0]], vals[edge[1]]);
            edgesList.Enqueue(edge, key);
        }

        // iterate each edge
        while(edgesList.Count > 0)
        {
            var edge = edgesList.Dequeue();
            int x = edge[0], y = edge[1];
            // get the root of x
            x = Find(x);
            // get the root of y
            y = Find(y);
            // if their vals are same,
            if (vals[x] == vals[y]) {
                // then there would be cnt[x] * cnt[y] good paths
                ans += cnt[x] * cnt[y];
                // unite them
                root[x] = y;
                // add the count of x to that of y
                cnt[y] += cnt[x];
            } else if (vals[x] > vals[y]) {
                // unite them
                root[y] = x;
            } else {
                // unite them
                root[x] = y;
            }
        }

        return ans;
    }
}
