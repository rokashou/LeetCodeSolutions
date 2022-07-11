/*
Runtime: 171 ms, faster than 70.80% of C# online submissions for Binary Tree Right Side View.
Memory Usage: 41.2 MB, less than 94.10% of C# online submissions for Binary Tree Right Side View.
Uploaded: 07/11/2022 21:25
*/

public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        List<int> list = new List<int>();
        if (root == null) return list;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        queue.Enqueue(null);

        while(queue.Count > 0)
        {
            var node = queue.Dequeue();

            if(node == null) {
                if (queue.Count > 0)
                    queue.Enqueue(null);
                continue;
            }

            TreeNode nextnode;
            if (queue.TryPeek(out nextnode) && nextnode == null)
                list.Add(node.val);

            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);
        }

        return list;
    }
}

