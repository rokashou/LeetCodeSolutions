/*
Sep 05, 2023 20:44
Runtime 79 ms Beats 89.53%
Memory 40 MB Beats 16.97%
*/


/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    Dictionary<Node, Node> clone = new Dictionary<Node, Node>();

    public bool IsCloneExist(Node node)
    {
        if (node == null || clone.ContainsKey(node)) return true;

        clone.Add(node, new Node(node.val));
        return false;
    }

    public void MakeClone(Node node)
    {
        if (IsCloneExist(node)) return;

        MakeClone(node.next);

        if (node.next != null)
            clone[node].next = clone[node.next];
        else
            clone[node].next = null;

        if (node.random != null)
            clone[node].random = clone[node.random];
        else
            clone[node].random = null;

    }

    public Node CopyRandomList(Node head)
    {
        if (head == null) return null;
        MakeClone(head);
        return clone[head];
    }
}
