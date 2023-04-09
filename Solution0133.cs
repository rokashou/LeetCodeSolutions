/*
Apr 09, 2023 20:24
Runtime 163 ms, Beats 27.50%
Memory 43 MB, Beats 75%
*/

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node)
    {
        if (node == null)
        {
            return null;
        }

        var seen = new Dictionary<int, Node>();
        return dfs(seen, node);
    }

    private Node dfs(Dictionary<int, Node> seen, Node node)
    {
        var curr = new Node(node.val);
        seen.Add(curr.val, curr);

        foreach (var n in node.neighbors)
        {
            if (!seen.ContainsKey(n.val))
            {
                dfs(seen, n);
            }

            curr.neighbors.Add(seen[n.val]);
        }

        return curr;
    }
}
