/*
Runtime: 286 ms, faster than 81.52% of C# online submissions for Smallest String With Swaps.
Memory Usage: 61.4 MB, less than 92.39% of C# online submissions for Smallest String With Swaps.
Uploaded: 04/27/2022 21:00
*/

public class Solution {

    class UnionFind
    {
        private int[] root;
        private int[] rank;

        public UnionFind(int size)
        {
            root = new int[size];
            rank = new int[size];

            for(int i = 0; i < size; i++)
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

        public void union(int x, int y) {
            int rootX = find(x);
            int rootY = find(y);
            if(rootX != rootY)
            {
                if(rank[rootX] > rank[rootY]) {
                    root[rootY] = rootX;
                } else if (rank[rootX] < rank[rootY]) {
                    root[rootX] = rootY;
                } else {
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

    public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs)
    {
        int n = s.Length;
        UnionFind uf = new UnionFind(n);

        // Iterate over the edges
        foreach(var v in pairs)
        {
            // Perform the union of end points
            uf.union(v[0],v[1]);
        }

        Dictionary<int, List<int>> rootToComponent = new Dictionary<int, List<int>>();
        // Group the vertives that are in the same component
        for (int vertex = 0; vertex < n; vertex++)
        {
            int root = uf.find(vertex);
            rootToComponent.TryAdd(root, new List<int>());
            rootToComponent[root].Add(vertex);
        }

        char[] smallestString = new char[n];
        foreach (var indices in rootToComponent.Values)
        {
            List<char> tmp = new List<char>();
            foreach (var idx in indices) tmp.Add(s[idx]);
            tmp.Sort();
            for(int i = 0; i < tmp.Count; i++)
            {
                smallestString[indices[i]] = tmp[i];
            }
        }

        return new string(smallestString);
    }
}

