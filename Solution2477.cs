/*
DFS Best Solution
Runtime 531 ms, Beats 100%
Memory 77.4 MB, Beats 63.64%
Feb 12, 2023 11:54
*/

public class Solution {
    private int _seatSize;
    private long ans = 0;

    public long MinimumFuelCost(int[][] roads, int seats)
    {
        var graph = new List<IList<int>>();
        _seatSize = seats;

        // initial the graph
        for (int i = 0; i < roads.Length + 1; i++)
        {
            graph.Add(new List<int>());
        }

        foreach(var road in roads)
        {
            graph[road[0]].Add(road[1]);
            graph[road[1]].Add(road[0]);
        }

        CountPeople(0, 0, graph);

        return ans;

    }

    private long CountPeople(int node, int prev, List<IList<int>> graph)
    {
        long people = 1; // the passenger from current node

        foreach(int x in graph[node])
        {
            if (x == prev) continue;
            people += CountPeople(x, node, graph);
        }
        if (node != 0)
        {
            ans += (people + _seatSize - 1) / _seatSize;
        }

        return people;
    }
}



/*
Runtime 823 ms, Beats 36.36%
Memory 118.9 MB, Beats 9.9%
Feb 12, 2023 11:41
My Solution
*/

public class Solution {
    private Dictionary<int, HashSet<int>> roadtable = new Dictionary<int, HashSet<int>>();
    private Dictionary<int, long[]> nodeTree = new Dictionary<int, long[]>(); // current node, passengers count, fuelSum 
    private int _seatSize;

    public long MinimumFuelCost(int[][] roads, int seats)
    {
        if (roads.Length == 0) return 0;

        _seatSize = seats;
        foreach(var road in roads)
        {
            if (!roadtable.ContainsKey(road[0]))
                roadtable.Add(road[0], new HashSet<int>());
            if (!roadtable.ContainsKey(road[1]))
                roadtable.Add(road[1], new HashSet<int>());
            roadtable[road[0]].Add(road[1]);
            roadtable[road[1]].Add(road[0]);
        }

        CountTreeSize(0, -1);

        return nodeTree[0][1];

    }

    private long CalculateMinCost(long passenger)
    {
        if(passenger % _seatSize == 0)
        {
            return passenger / _seatSize;
        }
        else
        {
            return passenger / _seatSize + 1;
        }
    }

    private void CountTreeSize(int current, int prev)
    {
        long psg_count = 1;
        long fuel_count = 0;
        foreach(var node in roadtable[current])
        {
            if(node != prev) {
                if (!nodeTree.ContainsKey(node))
                    CountTreeSize(node, current);
                psg_count += nodeTree[node][0];
                fuel_count += nodeTree[node][1] + CalculateMinCost(nodeTree[node][0]);
            }
        }
        nodeTree.TryAdd(current, new long[] { psg_count, fuel_count });
    }
}
