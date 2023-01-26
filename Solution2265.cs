/*
Runtime 107 ms, Beats 37.29%
Memory 40.9 MB, Beats 18.64%
Accepted: Jan 26, 2023 09:05
*/

public class Solution {
    public int AverageOfSubtree(TreeNode root)
    {
        int result = 0;

        CalculateSubtreeAverage(root, ref result);

        return result;
    }

    private int[] CalculateSubtreeAverage(TreeNode node, ref int cnt)
    {
        int[] result = new int[2]; //(nodes count,sum) 
        var leftTree = node.left != null ? CalculateSubtreeAverage(node.left, ref cnt) : new int[2];
        var rightTree = node.right != null ? CalculateSubtreeAverage(node.right, ref cnt) : new int[2];

        result[0] = leftTree[0] + rightTree[0] + 1;
        result[1] = leftTree[1] + rightTree[1] + node.val;

        if (result[1] / result[0] == node.val) cnt += 1;

        return result;
    }
}
