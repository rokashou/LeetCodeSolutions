/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int SumOfLeftLeaves(TreeNode root) {
        if(root == null) return 0;
        Queue<TreeNode> queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        int sum = 0;

        while (queue.Count > 0)
        {
            TreeNode tmp = queue.Dequeue();
            if(tmp.left != null)
            {
                queue.Enqueue(tmp.left);
                if(tmp.left.left == null && tmp.left.right == null)
                    sum += tmp.left.val;
            }
            if(tmp.right != null)
            {
                queue.Enqueue(tmp.right);
            }
        }

        return sum;
    }
}
