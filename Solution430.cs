/*
    Runtime: 84 ms, faster than 94.39% of C# online submissions for Flatten a Multilevel Doubly Linked List.
    Memory Usage: 37.9 MB, less than 14.80% of C# online submissions for Flatten a Multilevel Doubly Linked List.
 */

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head)
    {
        if (head == null) return head;

        Stack<Node> nodes = new Stack<Node>();
        Node newHead = new Node();
        newHead.val = head.val;
        Node last = newHead;
        nodes.Push(head);
        while (nodes.Count > 0)
        {
            Node temp = nodes.Pop();

            if (temp != head)
            {
                Node nextTemp = new Node { val = temp.val };
                last.next = nextTemp;
                nextTemp.prev = last;
                last = nextTemp;
            }

            if (temp.next != null) { nodes.Push(temp.next); }
            if (temp.child != null) { nodes.Push(temp.child); }
        }

        return newHead;
    }
}
