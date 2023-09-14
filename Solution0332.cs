/*
Sep 15, 2023 00:00
Runtime 153 ms Beats 95.59%
Memory 57.6 MB Beats 71.32%
*/

public class Solution {
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        var graph = new Dictionary<string, List<string>>();

        foreach(var ticket in tickets)
        {
            if (!graph.ContainsKey(ticket[0]))
                graph[ticket[0]] = new List<string>();
            graph[ticket[0]].Add(ticket[1]);
        }

        foreach (var key in graph.Keys)
            graph[key].Sort((a, b) => b.CompareTo(a));

        var stack = new Stack<string>();
        stack.Push("JFK");
        var itinerary = new List<string>();

        while(stack.Count > 0)
        {
            string curr = stack.Peek();
            if(graph.ContainsKey(curr) && graph[curr].Count > 0)
            {
                var next = graph[curr].Last();
                graph[curr].RemoveAt(graph[curr].Count - 1);
                stack.Push(next);
            }
            else
            {
                itinerary.Add(stack.Pop());
            }
        }
        itinerary.Reverse();
        return itinerary;
    }
}
