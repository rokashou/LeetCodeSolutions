/*
Runtime: 210 ms, faster than 38.13% of C# online submissions for Deepest Leaves Sum.
Memory Usage: 46.4 MB, less than 65.25% of C# online submissions for Deepest Leaves Sum.
Uploaded: 05/15/2022 11:25
*/

public class Solution {
    private int deepestLevel = 0;
    private int deepestSum = 0;

    private void DeepestSum(TreeNode node, int level)
    {
        if (node == null) return;

        if (node.left != null)
        {
            DeepestSum(node.left, level + 1);
        }

        if (node.right != null)
        {
            DeepestSum(node.right, level + 1);
        }

        if (level > deepestLevel)
        {
            deepestLevel = level;
            deepestSum = node.val;
            return;
        }

        if (level == deepestLevel) { 
            deepestSum += node.val;
            return;
        }

    }

    public int DeepestLeavesSum(TreeNode root)
    {
        DeepestSum(root, 0);

        return deepestSum;
    }
}
