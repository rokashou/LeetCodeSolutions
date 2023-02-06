/*
Runtime 119 ms, Beats 24.66%
Memory 39.9 MB, Beats 48.29%
Feb 07, 2023 00:36
*/


public class Solution {
    public int DiameterOfBinaryTree(TreeNode root)
    {
        if (root == null) return 0;
        int dia = TraceMaxHeightOfRoot(root.left) + TraceMaxHeightOfRoot(root.right);
        int ldia = DiameterOfBinaryTree(root.left);
        int rdia = DiameterOfBinaryTree(root.right);
        
        return Math.Max(dia, Math.Max(ldia,rdia));
    }

    private int TraceMaxHeightOfRoot(TreeNode root)
    {
        if (root == null) return 0;
        int ld = TraceMaxHeightOfRoot(root.left);
        int rd = TraceMaxHeightOfRoot(root.right);
        return Math.Max(ld, rd) + 1;
    }
}
