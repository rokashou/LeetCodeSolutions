/*
Mar 25, 2023 09:39
Runtime 542 ms, Beats 100%
Memory 76.6 MB, Beats 80%
*/


public class Solution {
    private class UnionFind
    {
        private int[] parent;
        private int[] rank;

        public UnionFind(int size)
        {
            parent = new int[size];
            for (int i = 0; i < size; i++)
            {
                parent[i] = i;
            }
            rank = new int[size];
        }

        public int Find(int x)
        {
            if (parent[x] != x) parent[x] = Find(parent[x]);
            return parent[x];
        }

        public void SetUnion(int x, int y)
        {
            int xset = Find(x), yset = Find(y);
            if (xset == yset)
            {
                return;
            }
            else if (rank[xset] < rank[yset])
            {
                parent[xset] = yset;
            }
            else if (rank[xset] > rank[yset])
            {
                parent[yset] = xset;
            }
            else
            {
                parent[yset] = xset;
                rank[xset]++;
            }
        }
    }
    
    public long CountPairs(int n, int[][] edges)
    {
        var dsu = new UnionFind(n);
        foreach (var e in edges)
            dsu.SetUnion(e[0], e[1]);

        var componentSize = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            int parent = dsu.Find(i);
            if (componentSize.ContainsKey(parent))
                componentSize[parent] += 1;
            else
                componentSize.Add(parent, 1);
        }

        long numberOfPaths = 0;
        long remainingNodes = n;
        foreach (var compSize in componentSize.Values)
        {
            numberOfPaths += compSize * (remainingNodes-compSize);
            remainingNodes -= compSize;
        }

        return numberOfPaths;

    }
}
