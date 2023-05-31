/*
May 31, 2023 21:15
Runtime 104 ms Beats 66.63%
Memory 42.4 MB Beats 48.43%
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
    private bool Validate(TreeNode root, int? low, int? high) {
        if (root == null) return true;

        if((low != null && root.val <= low) || (high != null && root.val >= high))
        {
            return false;
        }

        return Validate(root.right, root.val, high) &&
            Validate(root.left, low, root.val);
    }

    public bool IsValidBST(TreeNode root)
    {
        return Validate(root, null, null);
    }
}
