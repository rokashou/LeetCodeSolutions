/*
May 22, 2023 21:37
Runtime 96 ms Beats 63.51%
Memory 39.5 MB Beats 32.43%
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
    private IList<TreeNode> GenerateSubtrees(int left, int right)
    {
        var res = new List<TreeNode>();
        if (left > right)
        {
            res.Add(null);
            return res;
        }

        for (int i = left; i <= right; ++i)
        {
            var leftSubtrees = GenerateSubtrees(left, i - 1);
            var rightSubtrees = GenerateSubtrees(i + 1, right);

            foreach (var lNode in leftSubtrees)
            {
                foreach (var rNode in rightSubtrees)
                {
                    res.Add(new TreeNode(i, lNode, rNode));
                }
            }
        }
        return res;
    }

    public IList<TreeNode> GenerateTrees(int n)
    {
        return GenerateSubtrees(1, n);
    }
}
