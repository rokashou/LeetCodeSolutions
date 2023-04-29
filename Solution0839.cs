/*
Apr 29, 2023 13:47
Runtime 112 ms Beats 58.33%
Memory 41 MB Beats 75%
*/


public class Solution
{
    private class UnionFind
    {
        int[] rank;
        int[] parent;

        public UnionFind(int n)
        {
            this.rank = new int[n];
            this.parent = new int[n];
            for(int i = 0; i < n; i++) {
                parent[i] = i;
                rank[i] = 0;
            }
        }

        public int Find(int x)
        {
            if (parent[x] == x) return x;

            parent[x] = Find(parent[x]);
            return parent[x];
        }

        public void Union(int x, int y)
        {
            int pX = Find(x);
            int pY = Find(y);

            if (pX != pY)
            {
                if (rank[pX] > rank[pY])
                    parent[pY] = pX;
                else if (rank[pX] < rank[pY])
                    parent[pX] = pY;
                else
                {
                    parent[pX] = pY;
                    rank[pY]++;
                }
            }
        }
    }

    private bool IsSimilar(string s1, string s2)
    {
        int diffCnt = 0;
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i]) diffCnt++;
        }
        return diffCnt == 0 || diffCnt == 2;
    }

    public int NumSimilarGroups(string[] strs)
    {
        int n = strs.Length;
        var uf = new UnionFind(n);
        int cnt = n;

        for (int i = 0; i < n; i++)
        {
            for(int j = i + 1; j < n; j++)
            {
                if (IsSimilar(strs[i], strs[j]) && uf.Find(i) != uf.Find(j))
                {
                    cnt--;
                    uf.Union(i, j);
                }
            }
        }

        return cnt;
    }
}
