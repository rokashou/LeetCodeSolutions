/*
Runtime: 708 ms, faster than 39.66% of C# online submissions for Min Cost to Connect All Points.
Memory Usage: 77.4 MB, less than 43.10% of C# online submissions for Min Cost to Connect All Points.
Uploaded: 04/26/2022 21:56

Official Solution 1: Kruskal's Algorithm

'
*/

public class Solution {
    class UnionFind
    {
        public int[] group;
        public int[] rank;

        public UnionFind(int size)
        {
            group = new int[size];
            rank = new int[size];
            for (int i = 0; i < size; i++) group[i] = i;
        }

        public int find(int node)
        {
            if (group[node] != node) group[node] = find(group[node]);
            return group[node];
        }

        public bool union(int node1, int node2)
        {
            int group1 = find(node1);
            int group2 = find(node2);

            // node 1 and node2 already belong to same group.
            if(group1 == group2)
            {
                return false;
            }

            if (rank[group1] > rank[group2])
                group[group2] = group1;
            else if(rank[group1] < rank[group2])
            {
                group[group1] = group2;
            }
            else
            {
                group[group1] = group2;
                rank[group2] += 1;
            }

            return true;    
        }
    }

    private static int CompareIntList(int[] list1, int[] list2)
    {
        return list1[0].CompareTo(list2[0]);
    }

    public int MinCostConnectPoints(int[][] points)
    {
        int n = points.Length;
        List<int[]> allEdges = new List<int[]>();

        // Storing all edges of our complete graph.
        for(int curr = 0; curr < n; ++curr)
        {
            for(int next = curr + 1; next < n; ++next)
            {
                int weight = Math.Abs(points[curr][0] - points[next][0]) +
                    Math.Abs(points[curr][1] - points[next][1]);

                int[] currEdge = { weight, curr, next };
                allEdges.Add(currEdge);
            }
        }

        // Sort all edges in increasing order.
        allEdges.Sort(CompareIntList);

        UnionFind uf = new UnionFind(n);
        int mstCost = 0;
        int edgesUsed = 0;
        for(int i=0;i<allEdges.Count && edgesUsed < n - 1; i++)
        {
            int node1 = allEdges[i][1];
            int node2 = allEdges[i][2];
            int weight = allEdges[i][0];

            if (uf.union(node1, node2))
            {
                mstCost += weight;
                edgesUsed++;
            }
        }

        return mstCost;
    }
}


//---------


/*
Runtime: 267 ms, faster than 81.61% of C# online submissions for Min Cost to Connect All Points.
Memory Usage: 57.9 MB, less than 86.21% of C# online submissions for Min Cost to Connect All Points.
Uploaded: 04/26/2022 22:35	

Official Solution 2: Prim's Algorithm
'

*/

public class Solution {
    public int MinCostConnectPoints(int[][] points)
    {
        int n = points.Length; // Number of nodes of the graph
        int mstCost = 0;  // Cost to build the MST
        int edgesUsed = 0; // Number of edges included in the MST
        bool[] inMST = new bool[n]; // Array to track if a node was already included in MST or not.

        // A min-heap to pick minimum weight edge, each element of heap is a pair of (edge weight, node).
        PriorityQueue<KeyValuePair<int,int>,int> heap = new PriorityQueue<KeyValuePair<int,int>,int>(); 

        heap.Enqueue(new KeyValuePair<int, int>(0,0),0);
        while(edgesUsed < n)
        {
            var nodePair = heap.Dequeue();
            int weight = nodePair.Key;
            int currNode = nodePair.Value;

            // If node was already included in MST we will discard this edge.
            if (inMST[currNode])
            {
                continue;
            }

            inMST[currNode] = true;
            mstCost += weight;
            edgesUsed++;

            for(int nextNode = 0; nextNode < n; nextNode++)
            {
                // if nextNode is not in MST, then edge from currNode
                // to nextNode can be pushed in the priority queue.
                if (!inMST[nextNode])
                {
                    int nextWeight = Math.Abs(points[currNode][0] - points[nextNode][0])
                            + Math.Abs(points[currNode][1] - points[nextNode][1]);
                    heap.Enqueue(new KeyValuePair<int, int>(nextWeight, nextNode), nextWeight);
                }
            }
        }


        return mstCost;
    }
}
