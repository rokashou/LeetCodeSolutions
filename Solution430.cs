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
