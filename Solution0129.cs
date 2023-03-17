/*
Mar 17, 2023 22:00
Runtime 89 ms, Beats 47.61%
Memory 38 MB, Beats 77.19%
*/

public class Solution {
    private int result;

    public int SumNumbers(TreeNode root)
    {
        result = 0;
        CheckNodes(root, 0);
        return result;
    }

    private void CheckNodes(TreeNode node, int prefix)
    {
        if (node == null) return;

        int nodeVal = prefix * 10 + node.val;
        if (node.left == null && node.right == null)
            result += nodeVal;

        CheckNodes(node.left, nodeVal);
        CheckNodes(node.right, nodeVal);
    }
}
