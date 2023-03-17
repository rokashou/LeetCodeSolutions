/*
Mar 17, 2023 23:11
Runtime 95 ms, Beats 82.94%
Memory 40.8 MB, Beats 65.88%
*/




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
    public bool IsCompleteTree(TreeNode root) {
        var qu = new Queue<TreeNode>();
        qu.Enqueue(root);
        bool nullNodeFound = false;
        while (qu.Count > 0)
        {
            var node = qu.Dequeue();
            if (node == null)
            {
                nullNodeFound = true;
            }
            else
            {
                if (nullNodeFound) return false;

                qu.Enqueue(node.left);
                qu.Enqueue(node.right);
            }
        }
        return true;
    }
}
