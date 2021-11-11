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
    /*
    Uploaded: 10/27/2021 00:01
    Runtime: 92 ms, 50.17%
    Memory Usage: 37.3 MB, 41.68%
    */
    
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;

        TreeNode invert = root;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(invert);
        while(queue.Count > 0)
        {
            var temp = queue.Dequeue();
            var left = temp.left;
            temp.left = temp.right;
            temp.right = left;
            if (temp.left != null) queue.Enqueue(temp.left);
            if (temp.right != null) queue.Enqueue(temp.right);
        }

        return invert;
    }

}
