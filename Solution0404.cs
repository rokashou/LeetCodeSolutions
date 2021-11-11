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
        /*
         Runtime: 84 ms, faster than 88.72% of C# online submissions for Sum of Left Leaves.
         Memory Usage: 37.8 MB, less than 10.90% of C# online submissions for Sum of Left Leaves.
         Uploaded: 11/05/2021 00:17
        */
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
