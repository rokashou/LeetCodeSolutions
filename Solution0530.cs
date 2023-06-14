/*
Jun 14, 2023 21:36
Runtime 90 ms Beats 93.38%
Memory 42.3 MB Beats 72.19%
*/


public class Solution {
    private List<int> values = new List<int>();
    public int GetMinimumDifference(TreeNode root)
    {
        dfsTraversal(root);
        int ans = int.MaxValue;
        //traverse through array and get Min difference
        for (int i = 1; i < values.Count(); i++)
        {
            ans = Math.Min(ans, values[i] - values[i - 1]);
        }

        return ans;
    }

    //in-order traversal, guarantees a list of ordered values since the input tree is   binary search tree
    private void dfsTraversal(TreeNode node)
    {
        if (node == null)
            return;

        dfsTraversal(node.left);
        values.Add(node.val);
        dfsTraversal(node.right);
    }
}
