/*
Runtime: 158 ms, faster than 14.79% of C# online submissions for Populating Next Right Pointers in Each Node II.
Memory Usage: 39.4 MB, less than 51.43% of C# online submissions for Populating Next Right Pointers in Each Node II.
Uploaded: 05/13/2022 20:53
*/

public class Solution {
    public Node Connect(Node root) {
        if (root == null) return root;
        Queue<Node> stack = new Queue<Node>();
        stack.Enqueue(root);
        stack.Enqueue(null);

        while(stack.Count > 0)
        {
            var node = stack.Dequeue();
            if(node != null)
            {
                node.next = stack.Peek();
                if (node.left != null) stack.Enqueue(node.left);
                if (node.right != null) stack.Enqueue(node.right);
            }
            else
            {
                if(stack.Count > 0)
                    stack.Enqueue(null);
            }
        }

        return root;   
    }
}


/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/
