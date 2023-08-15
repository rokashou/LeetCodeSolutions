/*
Aug 15, 2023 23:12
Runtime 85 ms Beats 69.15%
Memory 39.4 MB Beats 61.70%
*/



public class Solution {
    public void Flatten(TreeNode root)
    {
        var node = root;
        while(node != null)
        {
            if(node.left != null)
            {
                var pre = node.left;
                while (pre.right != null)
                    pre = pre.right;
                pre.right = node.right;

                node.right = node.left;
                node.left = null;
            }
            node = node.right;
        }
    }
}

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
