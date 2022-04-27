/*
Runtime: 116 ms, faster than 79.09% of C# online submissions for Number of Provinces.
Memory Usage: 44.9 MB, less than 7.70% of C# online submissions for Number of Provinces.
Uploaded: 04/27/2022 21:17
*/

public class Solution {
    public int FindCircleNum(int[][] isConnected)
    {
        int n = isConnected.Length;
        int num = n;
        UnionFind uf = new UnionFind(n);
        for(int i = 0; i < n-1; i++)
        {
            for(int j = i + 1; j < n; j++)
            {
                if(isConnected[i][j]==1 && !uf.connected(i,j))
                {
                    uf.union(i, j);
                    num--;
                }
            }
        }
        return num;
    }

    class UnionFind
    {
        private int[] root;
        private int[] rank;

        public UnionFind(int size)
        {
            root = new int[size];
            rank = new int[size];

            for (int i = 0; i < size; i++)
            {
                root[i] = i;
                rank[i] = 1; // The initial "rank" of each vertex is 1, because each of them is
                             // a standalone vertex with no connection to other vertices.
            }
        }

        public int find(int x)
        {
            if (x == root[x]) return x;
            return root[x] = find(root[x]);
        }

        public void union(int x, int y)
        {
            int rootX = find(x);
            int rootY = find(y);
            if (rootX != rootY)
            {
                if (rank[rootX] > rank[rootY])
                {
                    root[rootY] = rootX;
                }
                else if (rank[rootX] < rank[rootY])
                {
                    root[rootX] = rootY;
                }
                else
                {
                    root[rootY] = rootX;
                    rank[rootX] += 1;
                }
            }
        }

        public bool connected(int x, int y)
        {
            return find(x) == find(y);
        }
    }
}

