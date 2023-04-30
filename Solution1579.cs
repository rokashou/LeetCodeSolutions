/*
Apr 30, 2023 20:59
Runtime 481 ms Beats 100%
Memory 65.7 MB Beats 54.55%

With a customized UnionFind class:
1. We dont care about the group for each single node, so remove the rank array for saving memory.
2. Count the edge or not depent on whether the nodes are in the same union or not.
  a. If the nodes are already in the same union, the edge can be removed.
  b. If they are no in the same union, set them in the same union, and decrease the componets count.
*/

public class Solution
{
    public int MaxNumEdgesToRemove(int n, int[][] edges)
    {
        int res = 0;
        UnionFind alice = new UnionFind(n);
        UnionFind bob = new UnionFind(n);
        foreach (var edge in edges)
        {
            if(edge[0] == 3 && (!alice.Union(edge[1], edge[2]) || !bob.Union(edge[1], edge[2])))
                res++;
        }

        foreach (var edge in edges)
        {
            if (edge[0] == 1 && !alice.Union(edge[1], edge[2]))
                res++;
            if (edge[0] == 2 && !bob.Union(edge[1], edge[2]))
                res++;
        }

        return alice.Componets == 1 && bob.Componets == 1 ? res : -1;
    }
}

public class UnionFind
{
    private int[] parent;
    public int Componets { get; private set; }
    public UnionFind(int n)
    {
        Componets = n;
        parent = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            parent[i] = i;
        }
    }

    public int Find(int x)
    {
        if (parent[x] != x)
            parent[x] = Find(parent[x]);
        return parent[x];
    }

    public bool Union(int x, int y)
    {
        int px = Find(x);
        int py = Find(y);
        if (px != py)
        {
            parent[px] = py;
            Componets--;
            return true;
        }
        return false;
    }
}


