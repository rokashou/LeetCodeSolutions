/*
Accepted: Jan 27, 2023 21:33
Runtime 173 ms, Beats 17.76%
Memory 40.4 MB, Beats 81.58%
*/


public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        // edge test first;
        if (root == null) return false;
        if (root.left == null && root.right == null)
        {
            return root.val == targetSum;
        }
        return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
    }
}
