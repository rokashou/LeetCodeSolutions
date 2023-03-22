/*
Mar 22, 2023 20:44
Runtime 418 ms, Beats 100%
Memory 68 MB, Beats 58.33%
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
            if (xset == yset) {
                return;
            } else if (rank[xset] < rank[yset]) {
                parent[xset] = yset;
            } else if (rank[xset] > rank[yset]) {
                parent[yset] = xset;
            } else {
                parent[yset] = xset;
                rank[xset]++;
            }
        }
    }

    public int MinScore(int n, int[][] roads)
    {
        UnionFind dsu = new UnionFind(n + 1);
        int answer = int.MaxValue;
        foreach (var road in roads)
        {
            dsu.SetUnion(road[0], road[1]);
        }

        foreach (var road in roads)
        {
            if (dsu.Find(1) == dsu.Find(road[0]))
            {
                answer = Math.Min(answer, road[2]);
            }
        }

        return answer;
    }
}
