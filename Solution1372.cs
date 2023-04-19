/*
Apr 19, 2023 20:08
Runtime 204 ms Beats 50%
Memory 55.6 MB Beats 75%
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
    private int _pathLength = 0;

    private void dfs(TreeNode node, bool goLeft, int steps)
    {
        if (node == null) return;

        _pathLength = Math.Max(_pathLength, steps);
        if (goLeft)
        {
            dfs(node.left, false, steps + 1);
            dfs(node.right, true, 1);
        }
        else
        {
            dfs(node.left, false, 1);
            dfs(node.right, true, steps + 1);
        }
    }

    public int LongestZigZag(TreeNode root)
    {
        dfs(root, false, 0);
        dfs(root, true, 0);
        return _pathLength;
    }
}
