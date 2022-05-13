/*
Runtime: 142 ms, faster than 86.92% of C# online submissions for Binary Tree Level Order Traversal.
Memory Usage: 43.2 MB, less than 19.81% of C# online submissions for Binary Tree Level Order Traversal.
Uploaded: 05/13/2022 21:22
*/


public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            List<int> newList = new List<int>();
            for(int i = queue.Count; i > 0; i--)
            {
                var node = queue.Dequeue();
                newList.Add(node.val);
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            result.Add(newList);
        }
        return result;
    }
}
