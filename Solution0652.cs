/*
Mar 02, 2023 00:12
Runtime 153 ms, Beats 86%
Memory 56.5 MB, Beats 84%
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
 public class Solution{
    private string serialize(TreeNode node, Dictionary<string, List<TreeNode>> map)
    {
        if (node == null) return "";
        string s = "(" + serialize(node.left, map) + node.val + serialize(node.right, map) + ")";
        if (!map.ContainsKey(s)) map.TryAdd(s, new List<TreeNode>());
        map[s].Add(node);
        return s;
    }

    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
    {
        Dictionary<string, List<TreeNode>> map = new Dictionary<string, List<TreeNode>>();
        List<TreeNode> dups = new List<TreeNode>();
        serialize(root, map);
        foreach (var group in map.Values)
            if (group.Count > 1) dups.Add(group[0]);
        return dups;
    }
}
