/*
Apr 29, 2023 12:16
Runtime 569 ms Beats 77.78%
Memory 73.2 MB Beats 11.11%

The basic idea is to limited the edges with the queries request.
1. build the undirected graph with limited edges
2. link the nodes with the limited edges into groups
3. check if the nodes is in the same group for the queries

*/

public class Solution {
    public bool[] DistanceLimitedPathsExist(int n, int[][] edgeList, int[][] queries)
    {
        UnionFind uf = new UnionFind(n);
        int qCnt = queries.Length;
        bool[] ans = new bool[qCnt];

        // Store original indices with all queries.
        List<int[]> queryWzIdx = new List<int[]>();
        for(int i = 0; i < qCnt; i++) {
            int[] tmp = new int[4];
            tmp[0] = queries[i][0];
            tmp[1] = queries[i][1];
            tmp[2] = queries[i][2];
            tmp[3] = i;
            queryWzIdx.Add(tmp);
        }

        // Sort all edges in increasing order of their edge weights.
        Array.Sort(edgeList, (x, y) => (x[2] - y[2]));
        // Sort all queries in increasing order of the limit of edge allowed.
        queryWzIdx.Sort((x, y) => (x[2] - y[2]));

        int edgesIndex = 0;

        // Iterate on each query one by one.
        for (int qIdx = 0; qIdx < qCnt; qIdx++) {
            int p = queryWzIdx[qIdx][0];
            int q = queryWzIdx[qIdx][1];
            int limit = queryWzIdx[qIdx][2];
            int queryOriginalIndex = queryWzIdx[qIdx][3];

            // Attach all edges which satisfy the limit given by the query.
            while(edgesIndex < edgeList.Length && edgeList[edgesIndex][2] < limit)
            {
                int node1 = edgeList[edgesIndex][0];
                int node2 = edgeList[edgesIndex][1];
                uf.Join(node1, node2);
                edgesIndex++;
            }

            // if both nodes belong to the same component, it means we can reach them.
            ans[queryOriginalIndex] = uf.AreConnected(p, q);

        }

        return ans;

    }

    private class UnionFind
    {
        private int[] group;
        private int[] rank;

        public UnionFind(int size)
        {
            group = new int[size];
            rank = new int[size];
            for (int i = 0; i < size; i++)
            {
                group[i] = i;
            }
        }

        public int Find(int node) {
            if (group[node] != node)
            {
                group[node] = Find(group[node]);
            }
            return group[node];
        }

        public void Join(int node1, int node2)
        {
            int group1 = Find(node1);
            int group2 = Find(node2);

            if (group1 == group2) return;

            if (rank[group1] > rank[group2])
                group[group2] = group1;
            else if (rank[group1] < rank[group2])
                group[group1] = group2;
            else
            {
                group[group1] = group2;
                rank[group2] += 1;
            }
        }

        public bool AreConnected(int node1,int node2)
        {
            int group1 = Find(node1);
            int group2 = Find(node2);
            return group1 == group2;
        }

    }
}
